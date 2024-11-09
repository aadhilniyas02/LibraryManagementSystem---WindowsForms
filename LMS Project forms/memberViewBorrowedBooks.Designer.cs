namespace LMS_Project_forms
{
    partial class memberViewBorrowedBooks
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ReturnStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRefreshBorrowedBooksMember = new System.Windows.Forms.Button();
            this.dataGridBorrowedBooksMember = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrowedBooksMember)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenu,
            this.ReturnStripMenuItem1,
            this.displayToolStripMenu,
            this.menuMemberToolStripMenu,
            this.logoutToolStripMenu,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(71, 24);
            this.memberToolStripMenu.Text = "Borrow";
            // 
            // ReturnStripMenuItem1
            // 
            this.ReturnStripMenuItem1.Name = "ReturnStripMenuItem1";
            this.ReturnStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.ReturnStripMenuItem1.Text = "Return";
            this.ReturnStripMenuItem1.Click += new System.EventHandler(this.ReturnStripMenuItem1_Click);
            // 
            // displayToolStripMenu
            // 
            this.displayToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBooksToolStripMenuItem,
            this.borrowedBooksToolStripMenuItem});
            this.displayToolStripMenu.Name = "displayToolStripMenu";
            this.displayToolStripMenu.Size = new System.Drawing.Size(72, 24);
            this.displayToolStripMenu.Text = "Display";
            // 
            // viewAllBooksToolStripMenuItem
            // 
            this.viewAllBooksToolStripMenuItem.Name = "viewAllBooksToolStripMenuItem";
            this.viewAllBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.viewAllBooksToolStripMenuItem.Text = "View All Books";
            this.viewAllBooksToolStripMenuItem.Click += new System.EventHandler(this.viewAllBooksToolStripMenuItem_Click);
            // 
            // borrowedBooksToolStripMenuItem
            // 
            this.borrowedBooksToolStripMenuItem.Name = "borrowedBooksToolStripMenuItem";
            this.borrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.borrowedBooksToolStripMenuItem.Text = "View Borrowed Books";
            // 
            // menuMemberToolStripMenu
            // 
            this.menuMemberToolStripMenu.Name = "menuMemberToolStripMenu";
            this.menuMemberToolStripMenu.Size = new System.Drawing.Size(60, 24);
            this.menuMemberToolStripMenu.Text = "Menu";
            this.menuMemberToolStripMenu.Click += new System.EventHandler(this.menuMemberToolStripMenu_Click);
            // 
            // logoutToolStripMenu
            // 
            this.logoutToolStripMenu.Name = "logoutToolStripMenu";
            this.logoutToolStripMenu.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenu.Text = "Logout";
            this.logoutToolStripMenu.Click += new System.EventHandler(this.logoutToolStripMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 39);
            this.label1.TabIndex = 8;
            this.label1.Text = "My Borrowed Books";
            // 
            // btnRefreshBorrowedBooksMember
            // 
            this.btnRefreshBorrowedBooksMember.Location = new System.Drawing.Point(29, 69);
            this.btnRefreshBorrowedBooksMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshBorrowedBooksMember.Name = "btnRefreshBorrowedBooksMember";
            this.btnRefreshBorrowedBooksMember.Size = new System.Drawing.Size(85, 33);
            this.btnRefreshBorrowedBooksMember.TabIndex = 7;
            this.btnRefreshBorrowedBooksMember.Text = "Refresh";
            this.btnRefreshBorrowedBooksMember.UseVisualStyleBackColor = true;
            this.btnRefreshBorrowedBooksMember.Click += new System.EventHandler(this.btnRefreshBorrowedBooksMember_Click);
            // 
            // dataGridBorrowedBooksMember
            // 
            this.dataGridBorrowedBooksMember.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridBorrowedBooksMember.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBorrowedBooksMember.Location = new System.Drawing.Point(29, 118);
            this.dataGridBorrowedBooksMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridBorrowedBooksMember.Name = "dataGridBorrowedBooksMember";
            this.dataGridBorrowedBooksMember.RowHeadersWidth = 51;
            this.dataGridBorrowedBooksMember.RowTemplate.Height = 24;
            this.dataGridBorrowedBooksMember.Size = new System.Drawing.Size(1008, 411);
            this.dataGridBorrowedBooksMember.TabIndex = 6;
            // 
            // memberViewBorrowedBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRefreshBorrowedBooksMember);
            this.Controls.Add(this.dataGridBorrowedBooksMember);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "memberViewBorrowedBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member - View Borrowed Books";
            this.Load += new System.EventHandler(this.memberViewBorrowedBooks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBorrowedBooksMember)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem viewAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowedBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMemberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRefreshBorrowedBooksMember;
        private System.Windows.Forms.DataGridView dataGridBorrowedBooksMember;
        private System.Windows.Forms.ToolStripMenuItem ReturnStripMenuItem1;
    }
}