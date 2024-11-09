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

namespace LMS_Project_forms
{
    public partial class formLibrarian : Form
    {
        public formLibrarian()
        {
            InitializeComponent();
        }

        // Librarian Login
        SqlConnection conn = new SqlConnection(Properties.Settings.Default.DB_String);
        private void btnLibrarianLogin_Click(object sender, EventArgs e)
        {
            string librarian_username, librarian_name;

            try
            {
                string querry = "SELECT * FROM Librarian_Details WHERE Username = @librarianusername AND Password = @librarianpassword";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                sda.SelectCommand.Parameters.AddWithValue("@librarianusername", txtLibrarianUserName.Text);
                sda.SelectCommand.Parameters.AddWithValue("@librarianpassword", txtLibrarianPassword.Text);
                DataTable dtabe = new DataTable();
                sda.Fill(dtabe);

                // User Name and Password Validate
                if(dtabe.Rows.Count > 0 ) 
                {
                    librarian_username = txtLibrarianUserName.Text;
                    librarian_name = dtabe.Rows[0]["LibrarianName"].ToString();

                    Program.currentUser = new CurrentUser{ UserId = librarian_username, Role = "Librarian", Name= librarian_name };

                    formMainLibrarianWindow form4 = new formMainLibrarianWindow();
                    form4.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLibrarianUserName.Clear();
                    txtLibrarianPassword.Clear();


                    txtLibrarianUserName.Focus();

                }
            }

            catch 
            {
                MessageBox.Show("Error");
            }

            finally
            {
                conn.Close();
            }
        }

        private void btnLibrarianLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLibrarianLoginBack_Click(object sender, EventArgs e)
        {
            formWelcome form1 = new formWelcome();
            form1.Show();
            this.Hide();
        }

        private void btnLibrarianLoginClear_Click(object sender, EventArgs e)
        {
            txtLibrarianUserName.Clear();
            txtLibrarianPassword.Clear();   

            txtLibrarianUserName.Focus();
        }

        private void checkBoxLibrarianPasswordHide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxLibrarianPasswordHide.Checked) 
            {
                txtLibrarianPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtLibrarianPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
