using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LMS_Project_forms
{
    public partial class formBookWindow : Form
    {
        public formBookWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome form8 = new formWelcome();
            form8.Show();
            this.Hide();
        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
            formMainLibrarianWindow formMainLibrarian = new formMainLibrarianWindow();
            formMainLibrarian.Show();
            this.Hide();
        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formMemberWindow form12 = new formMemberWindow();
            form12.Show();
            this.Hide();
        }

        private void displayToolStripMenu_Click(object sender, EventArgs e)
        {
            formLibrarianDisplay form13 = new formLibrarianDisplay();
            form13.Show();
            this.Hide();
        }

        // Register a Book
        private void btnRegisterBook_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                con.Open();

                if (string.IsNullOrWhiteSpace(txtBookId.Text) || string.IsNullOrWhiteSpace(txtBookName.Text) ||
                    string.IsNullOrWhiteSpace(txtBookAuthor.Text) || string.IsNullOrWhiteSpace(txtBookIsbn.Text))
                {
                    MessageBox.Show("Please Fill All The Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Book_Details WHERE BookID = @BookID", con);
                checkCmd.Parameters.AddWithValue("@BookID", int.Parse(txtBookId.Text));
                int existingCount = (int)checkCmd.ExecuteScalar();

                if (existingCount > 0)
                {
                    MessageBox.Show("Book ID is Already Registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string bookName = txtBookName.Text;
                if (!Regex.IsMatch(bookName, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Book Name Should Contain Only Alphabets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate author name
                string authorName = txtBookAuthor.Text;
                if (!Regex.IsMatch(authorName, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Author Name Should Contain Only Alphabets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string isbn = txtBookIsbn.Text;
                if (isbn.Length != 3 || !isbn.All(char.IsDigit))
                {
                    MessageBox.Show("ISBN Number Should Only Contain 3 Digit Integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlCommand cmd = new SqlCommand("INSERT INTO Book_Details (BookID, Name, Author, ISBN, Status) VALUES (@BookID, @Name, @Author, @ISBN, @Status)", con);
                cmd.Parameters.AddWithValue("@BookID", int.Parse(txtBookId.Text));
                cmd.Parameters.AddWithValue("@Name", txtBookName.Text);
                cmd.Parameters.AddWithValue("@Author", txtBookAuthor.Text);
                cmd.Parameters.AddWithValue("@ISBN", txtBookIsbn.Text);
                cmd.Parameters.AddWithValue("@Status", "Available");
                cmd.ExecuteNonQuery();

                con.Close();

                txtBookId.Clear();
                txtBookName.Clear();
                txtBookAuthor.Clear();
                txtBookIsbn.Clear();

                txtBookId.Focus();

                MessageBox.Show("Book Successfully Registered");
            }
        }

        // Book Remove
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBookId.Text))
            {
                MessageBox.Show("Please enter a Book ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookId.Focus();
                return; 
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Book_Details WHERE BookID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtBookId.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Book Removed");
                }
                else
                {
                    MessageBox.Show("No book found with the provided ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            txtBookId.Clear();
            txtBookName.Clear();
            txtBookAuthor.Clear();
            txtBookIsbn.Clear();

            txtBookId.Focus();

        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Book_Details", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridBookDetails.DataSource = dt;
        }

        private void btnClearBook_Click(object sender, EventArgs e)
        {
            txtBookId.Clear();
            txtBookName.Clear();
            txtBookAuthor.Clear();
            txtBookIsbn.Clear();

            txtBookId.Focus();


        }
    }
}
