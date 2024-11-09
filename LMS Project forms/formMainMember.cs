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

namespace LMS_Project_forms
{
    public partial class formMainMemberWindow : Form
    {
        private string memberId;
        private string memberName;


        public formMainMemberWindow()
        {
            InitializeComponent();

        }

        public formMainMemberWindow(string memberId, string memberName) : this()
        {
            this.memberId = memberId;
            this.memberName = memberName;
        }
        private void viewAllBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewAllBooks form13 = new memberViewAllBooks();
            form13.Show();
            this.Hide();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome form17 = new formWelcome();
            form17.Show();
            this.Hide();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bookToolStripMenu_Click(object sender, EventArgs e)
        {
            formBorrow form19 = new formBorrow();
            form19.Show();
            this.Hide();
        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formBookReturn formBookReturn = new formBookReturn();
            formBookReturn.Show();
            this.Hide();
        }

        private void formMainMemberWindow_Load(object sender, EventArgs e)
        {
            if (Program.currentUser != null)
            {
                lblWelcome.Text = "Welcome " + Program.currentUser.Name + "!";
            }
            else
            {
                lblWelcome.Visible = false;
            }
        }

        private void displayToolStripMenu_Click(object sender, EventArgs e)
        {

        }

        private void viewBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewBorrowedBooks formVBB = new memberViewBorrowedBooks();
            formVBB.Show();
            this.Hide();
        }
    }
}
