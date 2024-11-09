namespace LMS_Project_forms
{
    partial class memberViewAllBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridAllBooksMember = new System.Windows.Forms.DataGridView();
            this.btnSearchAllBooksMember = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bookToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllBooksMember)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridAllBooksMember
            // 
            this.dataGridAllBooksMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridAllBooksMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAllBooksMember.Location = new System.Drawing.Point(24, 95);
            this.dataGridAllBooksMember.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridAllBooksMember.Name = "dataGridAllBooksMember";
            this.dataGridAllBooksMember.RowHeadersWidth = 51;
            this.dataGridAllBooksMember.RowTemplate.Height = 24;
            this.dataGridAllBooksMember.Size = new System.Drawing.Size(569, 263);
            this.dataGridAllBooksMember.TabIndex = 0;
            // 
            // btnSearchAllBooksMember
            // 
            this.btnSearchAllBooksMember.Location = new System.Drawing.Point(24, 52);
            this.btnSearchAllBooksMember.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchAllBooksMember.Name = "btnSearchAllBooksMember";
            this.btnSearchAllBooksMember.Size = new System.Drawing.Size(64, 27);
            this.btnSearchAllBooksMember.TabIndex = 1;
            this.btnSearchAllBooksMember.Text = "Refresh";
            this.btnSearchAllBooksMember.UseVisualStyleBackColor = true;
            this.btnSearchAllBooksMember.Click += new System.EventHandler(this.btnSearchAllBooksMember_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(238, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "All Books";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenu,
            this.memberToolStripMenu,
            this.displayToolStripMenu,
            this.logoutToolStripMenu,
            this.exitToolStripMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(616, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bookToolStripMenu
            // 
            this.bookToolStripMenu.Name = "bookToolStripMenu";
            this.bookToolStripMenu.Size = new System.Drawing.Size(62, 21);
            this.bookToolStripMenu.Text = "Borrow";
            this.bookToolStripMenu.Click += new System.EventHandler(this.bookToolStripMenu_Click);
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(58, 21);
            this.memberToolStripMenu.Text = "Return";
            this.memberToolStripMenu.Click += new System.EventHandler(this.memberToolStripMenu_Click);
            // 
            // displayToolStripMenu
            // 
            this.displayToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBorrowedBooksToolStripMenuItem});
            this.displayToolStripMenu.Name = "displayToolStripMenu";
            this.displayToolStripMenu.Size = new System.Drawing.Size(62, 21);
            this.displayToolStripMenu.Text = "Display";
            // 
            // logoutToolStripMenu
            // 
            this.logoutToolStripMenu.Name = "logoutToolStripMenu";
            this.logoutToolStripMenu.Size = new System.Drawing.Size(61, 21);
            this.logoutToolStripMenu.Text = "Logout";
            this.logoutToolStripMenu.Click += new System.EventHandler(this.logoutToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenu.Text = "Exit";
            // 
            // viewBorrowedBooksToolStripMenuItem
            // 
            this.viewBorrowedBooksToolStripMenuItem.Name = "viewBorrowedBooksToolStripMenuItem";
            this.viewBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(205, 24);
            this.viewBorrowedBooksToolStripMenuItem.Text = "View Borrowed Books";
            this.viewBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBorrowedBooksToolStripMenuItem_Click);
            // 
            // memberViewAllBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 381);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearchAllBooksMember);
            this.Controls.Add(this.dataGridAllBooksMember);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "memberViewAllBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View All Books";
            this.Load += new System.EventHandler(this.memberViewAllBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAllBooksMember)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridAllBooksMember;
        private System.Windows.Forms.Button btnSearchAllBooksMember;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowedBooksToolStripMenuItem;
    }
}