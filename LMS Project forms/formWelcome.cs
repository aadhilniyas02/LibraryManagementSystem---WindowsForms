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
    public partial class formWelcome : Form
    {
        public formWelcome()
        {
            InitializeComponent();
        }

        private void btnLibrarian_Click(object sender, EventArgs e)
        {
            formLibrarian from2 = new formLibrarian();
            from2.Show();
            this.Hide();
        }

        private void btnWelcomeExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            formMember form3 = new formMember();
            form3.Show();
            this.Hide();
        }
    }
}
