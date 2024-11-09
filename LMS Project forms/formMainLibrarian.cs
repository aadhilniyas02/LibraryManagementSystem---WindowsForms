using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS_Project_forms
{
    public partial class formMainLibrarianWindow : Form
    {
        public formMainLibrarianWindow()
        {
            InitializeComponent();
        }

        private void displayBookToolStripLibrarian_Click(object sender, EventArgs e)
        {

        }

        private void lblBookLibrarian_Click(object sender, EventArgs e)
        {

        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formMemberWindow form13 = new formMemberWindow();
            form13.Show();
            this.Hide();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {

            formWelcome form5 = new formWelcome();
            form5.Show();
            Program.currentUser = null;
            this.Hide();
        }


        private void bookToolStripMenu_Click(object sender, EventArgs e)
        {
            formBookWindow form8 = new formBookWindow();
            form8.Show();
            this.Hide();
        }

        private void displayToolStripMenu_Click(object sender, EventArgs e)
        {
            formLibrarianDisplay form14 = new formLibrarianDisplay();
            form14.Show();
            this.Hide();
        }

        private void formMainLibrarianWindow_Load(object sender, EventArgs e)
        {
            if (Program.currentUser != null)
            {
                lblWelcome.Text = "Welcome " + Program.currentUser.Name+"!";
            }
            else
            {
                lblWelcome.Visible = false;
            }
        }
    }
}
