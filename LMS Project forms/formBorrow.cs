using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static LMS_Project_forms.formBorrow;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LMS_Project_forms
{
    public partial class formBorrow : Form
    {
        private string memberId;

        public formBorrow()
        {
            InitializeComponent();
     
            
        }

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewAllBooks form15 = new memberViewAllBooks();
            form15.Show();
            this.Hide();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome form18 = new formWelcome();
            form18.Show();
            this.Hide();
        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
           formMainMemberWindow form16 = new formMainMemberWindow();
           form16.Show();
           this.Hide();
        }


        private void btnSearchMemberIdBookBorrow_Click(object sender, EventArgs e)
        {         

            if (!string.IsNullOrEmpty(txtMemberIdBookBorrow.Text))
            {
                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
                {
                    try
                    {
                        con.Open();

                        string query = "SELECT MemberID FROM Member_Details WHERE MemberID = @MemberID AND Member_Name = @Member_Name";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.Parameters.AddWithValue("@MemberID", txtMemberIdBookBorrow.Text);
                        cmd.Parameters.AddWithValue("@Member_Name", txtMemberNameBookBorrow.Text);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                      
                            }

                            MessageBox.Show("Member ID is valid. Proceed with borrowing process.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            txtMemberIdBookBorrow.Clear();
                            MessageBox.Show("Member ID not found or does not match the provided name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter a Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnClearBookBorrow_Click(object sender, EventArgs e)
        {
            cmbBookMemberBookBorrow.Tag = "";
            txtReuturnDate.Clear();
            formBorrow_Load(null, null);
        }

        private void btnSearchBookIdMemberBookBorrow_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBookIdMemberBookBorrow.Text))
            {          

                using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
                {
                    con.Open();

                    try
                    {
                        int bookIdBorrow = int.Parse(txtBookIdMemberBookBorrow.Text);
                        string bookNameBorrow = cmbBookMemberBookBorrow.Text;

                        SqlCommand cmd = new SqlCommand("SELECT * FROM Book_Details WHERE BookID = @BookID", con);
                        cmd.Parameters.AddWithValue("@BookID", bookIdBorrow);

                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {

                            bool isAvailable = CheckBookAvailability(bookIdBorrow);

                            if (isAvailable)
                            {
                                cmbBookMemberBookBorrow.SelectedValue = dt.Rows[0]["BookID"].ToString();
                            }
                            else
                            {
                                cmbBookMemberBookBorrow.ResetText();
                                txtBookIdMemberBookBorrow.Clear();
                                MessageBox.Show("This book is currently not available for borrowing. Select Available books from the Dropdown", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            cmbBookMemberBookBorrow.ResetText();
                            txtBookIdMemberBookBorrow.Clear();
                            MessageBox.Show("Book ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool CheckBookAvailability(int bookId)
        {
            bool isAvailable = false;

          
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT Status FROM Book_Details WHERE BookID = @BookID", con);
                cmd.Parameters.AddWithValue("@BookID", bookId);
                object result = cmd.ExecuteScalar();

                
                if ((string)result == "Available")
                {
                    isAvailable = true;
                }
            }

            return isAvailable;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool IsBookAvailableForBorrowing(string bookId)
        {
            bool isAvailable = false;

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                connection.Open();

                string query = "SELECT Status FROM Book_Details WHERE BookID = @BookID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@BookID", bookId);
                    object result = command.ExecuteScalar();

                    if ((string)result == "Available")
                    {
                        isAvailable = true;
                    }
                }
            }

            return isAvailable;
        }       

        private void btnBookBorrow_Click(object sender, EventArgs e)
        {
            int bookId = 0;
            if (cmbBookMemberBookBorrow.SelectedValue != null)
            {
                bookId = (int)cmbBookMemberBookBorrow.SelectedValue;
            }
            string bookName = cmbBookMemberBookBorrow.Text;
            string memberId = txtMemberIdBookBorrow.Text;
            string memberName = txtMemberNameBookBorrow.Text;
            DateTime borrowDate = DateTime.Now;
            DateTime dueDate = borrowDate.AddDays(14); 

            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                try
                {
                    connection.Open();

                    string borrowCountQuery = "SELECT COUNT(*) FROM Borrow_Book WHERE Member_ID = @Member_ID";
                    SqlCommand borrowCountCommand = new SqlCommand(borrowCountQuery, connection);
                    borrowCountCommand.Parameters.AddWithValue("@Member_ID", memberId);
                    int borrowCount = (int)borrowCountCommand.ExecuteScalar();

                    if (bookId == 0 || cmbBookMemberBookBorrow.Text == "")
                    {
                        MessageBox.Show("Book not selected, Select a book and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        cmbBookMemberBookBorrow.SelectedValue = 0;
                        return;
                    }

                    if (borrowCount >= 2)
                    {
                        MessageBox.Show("The Borrowing Member Has Already Borrowed The Maximum Allowed Number of Books (2).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string bookAvailabilityQuery = "SELECT Status FROM Book_Details WHERE BookID = @BookID";
                    SqlCommand bookAvailabilityCommand = new SqlCommand(bookAvailabilityQuery, connection);
                    bookAvailabilityCommand.Parameters.AddWithValue("@BookID", bookId);
                    string result = (string)bookAvailabilityCommand.ExecuteScalar();
                    if (result != "Available")
                    {
                        MessageBox.Show("Book is Not Available For borrowing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string borrowQuery = "INSERT INTO Borrow_Book (Member_ID, Member_Name, Book_ID, Book_Name, Borrow_Date, Due_Date) " +
                                         "VALUES (@Member_ID, @Member_Name, @Book_ID, @Book_Name, @Borrow_Date, @Due_Date)";
                    SqlCommand borrowCommand = new SqlCommand(borrowQuery, connection);
                    borrowCommand.Parameters.AddWithValue("@Member_ID", memberId);
                    borrowCommand.Parameters.AddWithValue("@Member_Name", memberName);
                    borrowCommand.Parameters.AddWithValue("@Book_ID", bookId);
                    borrowCommand.Parameters.AddWithValue("@Book_Name", bookName);
                    borrowCommand.Parameters.AddWithValue("@Borrow_Date", borrowDate);
                    borrowCommand.Parameters.AddWithValue("@Due_Date", dueDate);
                    int rows = borrowCommand.ExecuteNonQuery();
                    connection.Close();

                    if (rows > 0)
                    {
                        connection.Open();

                        string query = "UPDATE Book_Details SET Status = 'On Loan' WHERE BookID = @BookID";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@BookID", bookId);
                            int bookUpdate= command.ExecuteNonQuery();
                            if (bookUpdate > 0)
                            {
                                MessageBox.Show("Book Borrowed Successfully!\nReturn Date:  " + dueDate.ToString("dd MMMM yyyy"), "Borrow Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Something wrong, Book Borrowed but unable to change book status to 'On Loan'", "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                    
                    txtBookIdMemberBookBorrow.Clear();
                    txtReuturnDate.Clear();

                    txtReuturnDate.Text = dueDate.ToString("dd MMMM yyyy");
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

        private void txtMemberPasswordBookBorrow_TextChanged(object sender, EventArgs e)
        {

        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formBookReturn formBookReturn = new formBookReturn();
            formBookReturn.Show();
            this.Hide();
        }

        private DataTable GetAvailableBooksList()
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                try
                {
                    string query = "SELECT * FROM Book_Details WHERE Status = 'Available'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, con);

                    DataTable dtable = new DataTable();
                    sda.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        return dtable;
                    }
                    else
                    {
                        return null;
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

        private void formBorrow_Load(object sender, EventArgs e)
        {
            txtMemberIdBookBorrow.Text = Program.currentUser.UserId;
            txtMemberNameBookBorrow.Text = Program.currentUser.Name;

            cmbBookMemberBookBorrow.DisplayMember = "Name";
            cmbBookMemberBookBorrow.ValueMember = "BookID";
            
            cmbBookMemberBookBorrow.Tag = "";
            txtBookIdMemberBookBorrow.Clear();


            DataTable dtable = GetAvailableBooksList();
            if (dtable != null)
            {
                cmbBookMemberBookBorrow.DataSource = dtable;
                cmbBookMemberBookBorrow.SelectedItem = null;
                cmbBookMemberBookBorrow.Text = "-- Select Book --";
               
            }
            else
            {
                cmbBookMemberBookBorrow.DataSource = null;
                cmbBookMemberBookBorrow.SelectedItem = null;
                cmbBookMemberBookBorrow.Text = "-- No Books Available --";
            }

            cmbBookMemberBookBorrow.Tag = "Started";
        }

        private void displayToolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void cmbBookMemberBookBorrow_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbBookMemberBookBorrow.Tag == "Started")
            {
                txtBookIdMemberBookBorrow.Text = cmbBookMemberBookBorrow.SelectedValue.ToString();
            }
        }

        private void dateTimePickerBorrow_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerBorrow.MinDate = DateTime.Now;
            dateTimePickerBorrow.MaxDate = DateTime.Now.AddMinutes(1);
        }

        private void viewBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewBorrowedBooks formVBB = new memberViewBorrowedBooks();
            formVBB.Show();
            this.Hide();
        }
    }
}
