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
    public partial class memberViewBorrowedBooks : Form
    {
        public memberViewBorrowedBooks()
        {
            InitializeComponent();
        }

        private void btnRefreshBorrowedBooksMember_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(Properties.Settings.Default.DB_String);
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Borrow_Book WHERE Member_ID = @Member_ID", con);
            cmd.Parameters.AddWithValue("@Member_ID", int.Parse(Program.currentUser.UserId));
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dataGridBorrowedBooksMember.DataSource = dt;
        }

        private void memberViewBorrowedBooks_Load(object sender, EventArgs e)
        {
            btnRefreshBorrowedBooksMember_Click(null, null);
        }

        private void viewAllBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            memberViewAllBooks formVAB = new memberViewAllBooks();
            formVAB.Show();
            this.Hide();
        }

        private void ReturnStripMenuItem1_Click(object sender, EventArgs e)
        {
            formBookReturn form19 = new formBookReturn();
            form19.Show();
            this.Hide();
        }

        private void menuMemberToolStripMenu_Click(object sender, EventArgs e)
        {
            formMainMemberWindow formMainMemberWindow = new formMainMemberWindow();
            formMainMemberWindow.Show();
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
