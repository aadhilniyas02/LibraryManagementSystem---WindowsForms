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
    public partial class formLibrarianDisplay : Form
    {
        public formLibrarianDisplay()
        {
            InitializeComponent();
        }

        // Exit Button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome form16 = new formWelcome();
            form16.Show();
            this.Hide();
        }

        // Log Out
        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
            formMainLibrarianWindow form17  = new formMainLibrarianWindow();
            form17.Show();
            this.Hide();
        }

        private void displayToolStripMenu_Click(object sender, EventArgs e)
        {
            formMemberWindow form19 = new formMemberWindow();
            form19.Show();
            this.Hide();
        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formBookWindow form20 = new formBookWindow();
            form20.Show();
            this.Hide();
        }

        private void btnSearchBookStatus_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Borrow_Book", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridLibrarianBookStatus.DataSource = dt;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void formLibrarianDisplay_Load(object sender, EventArgs e)
        {
            btnSearchBookStatus_Click(null, null);
            btnSearchTransactionHistory_Click(null, null);
        }

        private void btnSearchTransactionHistory_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Return_Book", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridLibrarianTransactionHistory.DataSource = dt;
        }
    }
}
