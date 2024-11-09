using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project_forms
{
    public partial class formBookReturn : Form
    {
        private string connectionString = Properties.Settings.Default.DB_String;
        private bool isBookLoadSuccess = false;

        public formBookReturn()
        {
            InitializeComponent();
        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome formWelcome = new formWelcome();
            formWelcome.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuMemberToolStripMenu_Click(object sender, EventArgs e)
        {
            formMainMemberWindow formMainMemberWindow = new formMainMemberWindow();
            formMainMemberWindow.Show();
            this.Hide();
        }

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewAllBooks form15 = new memberViewAllBooks();
            form15.Show();
            this.Hide();
        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formBorrow formBorrow = new formBorrow();
            formBorrow.Show();
            this.Hide();
        }

        private void btnClearBookReturn_Click(object sender, EventArgs e)
        {
            formBookReturn_Load(null, null);
        }
        public bool IsBookRegistered(string bookId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Book_Details WHERE BookID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookId);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }

        private void btnBookReturn_Click(object sender, EventArgs e)
        {
            int bookId = 0;
            if (txtBookIdReturn.Text != "" || txtBookIdReturn.Text != null)
            {
                bookId = int.Parse(txtBookIdReturn.Text);
            }
            string bookName = cmbBorrowedBookReturn.Text;
            string memberId = txtMemberIdReturn.Text;
            string memberName = txtMemberNameReturn.Text;
            DateTime borrowedDate;
            DateTime dueDate;
            DateTime returnDate = DateTime.Now;

            if (DateTime.TryParse(txtBorrowedDateBookReturn.Text, out borrowedDate) && DateTime.TryParse(txtDueDateBookReturn.Text, out dueDate))
            {
                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DB_String))
                {
                    try
                    {
                        connection.Open();

                        if (bookId == 0 || cmbBorrowedBookReturn.Text == "")
                        {
                            MessageBox.Show("Book not selected, Select a book and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            cmbBorrowedBookReturn.SelectedValue = 0;
                            return;
                        }

                        string bookAvailabilityQuery = "SELECT Status FROM Book_Details WHERE BookID = @BookID";
                        SqlCommand bookAvailabilityCommand = new SqlCommand(bookAvailabilityQuery, connection);
                        bookAvailabilityCommand.Parameters.AddWithValue("@BookID", bookId);
                        string result = (string)bookAvailabilityCommand.ExecuteScalar();
                        if (result != "On Loan")
                        {
                            MessageBox.Show("Book is already Returned, if not something is wrong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        string returnQuery = "INSERT INTO Return_Book (Member_ID, Member_Name, Book_ID, Book_Name, Borrow_Date, Due_Date, Return_Date) " +
                                             "VALUES (@Member_ID, @Member_Name, @Book_ID, @Book_Name, @Borrow_Date, @Due_Date, @Return_Date)";
                        SqlCommand returnCommand = new SqlCommand(returnQuery, connection);
                        returnCommand.Parameters.AddWithValue("@Member_ID", memberId);
                        returnCommand.Parameters.AddWithValue("@Member_Name", memberName);
                        returnCommand.Parameters.AddWithValue("@Book_ID", bookId);
                        returnCommand.Parameters.AddWithValue("@Book_Name", bookName);
                        returnCommand.Parameters.AddWithValue("@Borrow_Date", borrowedDate);
                        returnCommand.Parameters.AddWithValue("@Due_Date", dueDate);
                        returnCommand.Parameters.AddWithValue("@Return_Date", returnDate);
                        int rows = returnCommand.ExecuteNonQuery();
                        connection.Close();


                        if (rows == 0)
                        {
                            MessageBox.Show("Failed to insert book record in Return book table, Try again", "Return Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        connection.Open();
                        string removeBorrowQuery = "DELETE FROM Borrow_Book WHERE Member_ID = @Member_ID AND Book_ID = @Book_ID";

                        SqlCommand removeBorrowCommand = new SqlCommand(removeBorrowQuery, connection);
                        removeBorrowCommand.Parameters.AddWithValue("@Member_ID", memberId);
                        removeBorrowCommand.Parameters.AddWithValue("@Book_ID", bookId);
                        int borrowBookDelete = removeBorrowCommand.ExecuteNonQuery();
                        connection.Close();


                        if (borrowBookDelete == 0)
                        {
                            MessageBox.Show("Something wrong, Book Returned but unable to remove borrowed book from Borrowed table", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        connection.Open();
                        string updateStatusQuery = "UPDATE Book_Details SET Status = 'Available' WHERE BookID = @BookID";

                        SqlCommand updateStatusCommand = new SqlCommand(updateStatusQuery, connection);
                        updateStatusCommand.Parameters.AddWithValue("@BookID", bookId);
                        int bookUpdate = updateStatusCommand.ExecuteNonQuery();

                        if (bookUpdate > 0)
                        {
                            MessageBox.Show("Book Returned Successfully!", "Return Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Something wrong, Book Returned but unable to change book status to 'Available'", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select a borrowed book to return", "Book Not Populated", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private DataTable GetBorrowedBooksList(int memberId, string bookId = null)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                try
                {
                    string query = "SELECT * FROM Borrow_Book WHERE Member_ID = @MemberID";

                    if (bookId != null)
                    {
                        query += " AND Book_ID = @BookID";
                    }

                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        command.Parameters.AddWithValue("@MemberID", memberId);
                        if (bookId != null)
                        {
                            command.Parameters.AddWithValue("@BookID", int.Parse(bookId));
                        }

                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(command);
                        DataTable dtable = new DataTable();
                        sda.Fill(dtable);

                        return dtable;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void formBookReturn_Load(object sender, EventArgs e)
        {
            txtMemberIdReturn.Text = Program.currentUser.UserId;
            txtMemberNameReturn.Text = Program.currentUser.Name;

            txtBorrowedDateBookReturn.Clear();
            txtDueDateBookReturn.Clear();
            txtBookIdReturn.Clear();

            cmbBorrowedBookReturn.DisplayMember = "Book_Name";
            cmbBorrowedBookReturn.ValueMember = "Book_ID";

            cmbBorrowedBookReturn.Tag = "";
            DataTable dtable = GetBorrowedBooksList(int.Parse(Program.currentUser.UserId));
            if (dtable != null)
            {
                cmbBorrowedBookReturn.DataSource = dtable;
                cmbBorrowedBookReturn.SelectedItem = null;
            }
            else
            {
                cmbBorrowedBookReturn.SelectedItem = null;
                cmbBorrowedBookReturn.DataSource = null;
            }
            cmbBorrowedBookReturn.Tag = "Started";
        }

        private void btnSearchBookIdMemberBookBorrow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBookIdReturn.Text))
            {

                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
                {
                    con.Open();

                    try
                    {
                        int bookIdReturn = int.Parse(txtBookIdReturn.Text);
                        string bookNameReturn = cmbBorrowedBookReturn.Text;

                        DataTable dt = new DataTable();

                        dt = GetBorrowedBooksList(int.Parse(Program.currentUser.UserId), bookIdReturn.ToString());

                        if (dt.Rows.Count > 0)
                        {
                            cmbBorrowedBookReturn.SelectedValue = dt.Rows[0]["Book_ID"].ToString();
                            txtBorrowedDateBookReturn.Text = dt.Rows[0]["Borrow_Date"].ToString();
                            txtDueDateBookReturn.Text = dt.Rows[0]["Due_Date"].ToString();
                        }
                        else if (!IsBookRegistered(bookIdReturn.ToString()))
                        {
                            MessageBox.Show("This book is not registered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (dt.Rows.Count == 0)
                        {
                            cmbBorrowedBookReturn.ResetText();
                            txtBookIdReturn.Clear();
                            MessageBox.Show("This book is not borrowed for returning. Select any borrowed book from the List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    catch (Exception ex)
                    {
                        if (ex is FormatException)
                        {
                            MessageBox.Show("Enter numeric book ID");
                        }
                        else
                        {
                            MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void currentDateReturnBook_ValueChanged(object sender, EventArgs e)
        {
            currentDateReturnBook.MinDate = DateTime.Now;
            currentDateReturnBook.MaxDate = DateTime.Now.AddMinutes(1);
        }

        private void cmbBorrowedBookReturn_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBorrowedBookReturn.Tag == "Started")
            {
                txtBookIdReturn.Text = cmbBorrowedBookReturn.SelectedValue.ToString();
                btnSearchBookIdMemberBookBorrow_Click(null, null);
            }
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewBorrowedBooks memberViewBorrowed = new memberViewBorrowedBooks();
            memberViewBorrowed.Show();
            this.Hide();
        }
    }
}
