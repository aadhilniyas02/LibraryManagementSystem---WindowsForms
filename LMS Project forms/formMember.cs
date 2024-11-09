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
    public partial class formMember : Form
    {
        private string memberId;
        private string memberName;
        public formMember()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(Properties.Settings.Default.DB_String);

        private void btnMemberLoginExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMemberLoginBack_Click(object sender, EventArgs e)
        {
            formWelcome form1 = new formWelcome();
            form1.Show();
            this.Hide();
        }

        private void btnMemberLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string querry = "SELECT MemberID, Member_Name FROM Member_Details WHERE Username = @MemberUsername AND Password = @MemberPassword";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);
                sda.SelectCommand.Parameters.AddWithValue("@MemberUsername", txtMemberUserName.Text);
                sda.SelectCommand.Parameters.AddWithValue("@MemberPassword", txtMemberPassword.Text);
                DataTable dtabe = new DataTable();
                sda.Fill(dtabe);

                // User Name and Password Validate
                if (dtabe.Rows.Count > 0)
                {
                    memberId = dtabe.Rows[0]["MemberID"].ToString();
                    memberName = dtabe.Rows[0]["Member_Name"].ToString();

                    Program.currentUser = new CurrentUser { UserId = memberId, Role = "Member", Name = memberName };

                    formMainMemberWindow form5 = new formMainMemberWindow(memberId, memberName); 
                    form5.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMemberUserName.Clear();
                    txtMemberPassword.Clear();
                    txtMemberUserName.Focus();
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

            private void btnMemberLoginClear_Click(object sender, EventArgs e)
        {
            txtMemberUserName.Clear();
            txtMemberPassword.Clear();


            txtMemberUserName.Focus();
        }

        private void checkBoxMemberPasswordHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxMemberPasswordHide.Checked)
            {
                txtMemberPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtMemberPassword.UseSystemPasswordChar = true;
            }
        }
    }
}

