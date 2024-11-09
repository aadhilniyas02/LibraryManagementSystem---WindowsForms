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
    public partial class memberViewAllBooks : Form
    {
        public memberViewAllBooks()
        {
            InitializeComponent();
        }

        private void btnSearchAllBooksMember_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Book_Details", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridAllBooksMember.DataSource = dt;
        }

        private void bookToolStripMenu_Click(object sender, EventArgs e)
        {
            formBorrow form18 = new formBorrow();
            form18.Show();
            this.Hide();
        }

        private void memberToolStripMenu_Click(object sender, EventArgs e)
        {
            formBookReturn form19 = new formBookReturn();
            form19.Show();  
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void memberViewAllBooks_Load(object sender, EventArgs e)
        {
            btnSearchAllBooksMember_Click(null,null);
        }

        private void viewBorrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewBorrowedBooks formVBB = new memberViewBorrowedBooks();
            formVBB.Show();
            this.Hide();
        }

        private void logoutToolStripMenu_Click(object sender, EventArgs e)
        {
            formWelcome form9 = new formWelcome();
            form9.Show();
            this.Hide();
        }
    }
}
