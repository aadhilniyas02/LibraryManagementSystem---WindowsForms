using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project_forms
{
    public partial class formMemberWindow : Form
    {
        public formMemberWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome form9 = new formWelcome();
            form9.Show();
            this.Hide();
        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
            formMainLibrarianWindow form10 = new formMainLibrarianWindow();
            form10.Show();
            this.Hide();
        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formBookWindow form11 = new formBookWindow();
            form11.Show();
            this.Hide();
        }

        private void displayToolStripMenu_Click(object sender, EventArgs e)
        {
            formLibrarianDisplay form15 = new formLibrarianDisplay();
            form15.Show();
            this.Hide();
        }


        // Email validate
        static bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }

        private void btnRegisterMember_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String))
            {
                con.Open();

                    // Check if all fields are entered
                    if (string.IsNullOrWhiteSpace(txtMemberId.Text) || string.IsNullOrWhiteSpace(txtMemberName.Text) ||
                    string.IsNullOrWhiteSpace(txtMemberEmail.Text) || string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtMemberPassword.Text))
                {
                    MessageBox.Show("Please Fill All The Fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if the Member ID already regsted
                SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Member_Details WHERE MemberID = @MemberID", con);
                checkCmd.Parameters.AddWithValue("@MemberID", int.Parse(txtMemberId.Text));
                int existingCount = (int)checkCmd.ExecuteScalar();

                if (existingCount > 0)
                {
                    MessageBox.Show("Member ID is Already Registered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Member name
                string memberName = txtMemberName.Text;
                if (!Regex.IsMatch(memberName, "^[a-zA-Z]+$"))
                {
                    MessageBox.Show("Member Name Should Contain Only Alphabets.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate email address
                string email = txtMemberEmail.Text;
                if (!IsValidEmail(email))
                {
                    MessageBox.Show("Invalid Email Address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                // Validate username
                string username = txtUsername.Text;
                if (!Regex.IsMatch(username, "^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Username Should Contain only Alphabets and Integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate password
                string password = txtMemberPassword.Text;
                if (!Regex.IsMatch(password, "^[a-zA-Z0-9]+$"))
                {
                    MessageBox.Show("Password Should Contain Only Alphabets and Integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO Member_Details (MemberID, Member_Name, Email, Username, Password) VALUES (@MemberID, @Member_Name, @Email, @Username, @Password)", con);
                cmd.Parameters.AddWithValue("@MemberID", int.Parse(txtMemberId.Text));
                cmd.Parameters.AddWithValue("@Member_Name", txtMemberName.Text);
                cmd.Parameters.AddWithValue("@Email", txtMemberEmail.Text);
                cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@Password", txtMemberPassword.Text);
                cmd.ExecuteNonQuery();

                con.Close();

                txtMemberId.Clear();
                txtMemberName.Clear();
                txtMemberEmail.Clear();
                txtUsername.Clear();
                txtMemberPassword.Clear();

                txtMemberId.Focus();

                MessageBox.Show("Member Successfully Registered");
            }
        }

        private void btnRemoveMember_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMemberId.Text))
            {
                MessageBox.Show("Please enter a Member ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMemberId.Focus();
                return; 
            }

            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("DELETE FROM Member_Details WHERE MemberID=@ID", con);
                cmd.Parameters.AddWithValue("@ID", int.Parse(txtMemberId.Text));

                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Member Removed");
                }
                else
                {
                    MessageBox.Show("No member found with the provided ID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            txtMemberId.Clear();
            txtMemberEmail.Clear();
            txtMemberName.Clear();
            txtUsername.Clear();
            txtMemberPassword.Clear();

            txtMemberId.Focus();

        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Member_Details", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridMemberDetails.DataSource = dt;
        }

        private void btnClearMember_Click(object sender, EventArgs e)
        {
            txtMemberId.Clear();
            txtMemberEmail.Clear();
            txtMemberName.Clear();
            txtUsername.Clear();
            txtMemberPassword.Clear();
        }
    }
}
