namespace LMS_Project_forms
{
    partial class formMainMemberWindow
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
            this.bookToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.memberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(675, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // bookToolStripMenu
            // 
            this.bookToolStripMenu.Name = "bookToolStripMenu";
            this.bookToolStripMenu.Size = new System.Drawing.Size(71, 24);
            this.bookToolStripMenu.Text = "Borrow";
            this.bookToolStripMenu.Click += new System.EventHandler(this.bookToolStripMenu_Click);
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(66, 24);
            this.memberToolStripMenu.Text = "Return";
            this.memberToolStripMenu.Click += new System.EventHandler(this.memberToolStripMenu_Click);
            // 
            // displayToolStripMenu
            // 
            this.displayToolStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewAllBookToolStripMenuItem,
            this.viewBorrowedBooksToolStripMenuItem});
            this.displayToolStripMenu.Name = "displayToolStripMenu";
            this.displayToolStripMenu.Size = new System.Drawing.Size(72, 24);
            this.displayToolStripMenu.Text = "Display";
            this.displayToolStripMenu.Click += new System.EventHandler(this.displayToolStripMenu_Click);
            // 
            // viewAllBookToolStripMenuItem
            // 
            this.viewAllBookToolStripMenuItem.Name = "viewAllBookToolStripMenuItem";
            this.viewAllBookToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.viewAllBookToolStripMenuItem.Text = "View All Book";
            this.viewAllBookToolStripMenuItem.Click += new System.EventHandler(this.viewAllBookToolStripMenuItem_Click);
            // 
            // viewBorrowedBooksToolStripMenuItem
            // 
            this.viewBorrowedBooksToolStripMenuItem.Name = "viewBorrowedBooksToolStripMenuItem";
            this.viewBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.viewBorrowedBooksToolStripMenuItem.Text = "View Borrowed Books";
            this.viewBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBorrowedBooksToolStripMenuItem_Click);
            // 
            // logoutToolStripMenu
            // 
            this.logoutToolStripMenu.Name = "logoutToolStripMenu";
            this.logoutToolStripMenu.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenu.Text = "Logout";
            this.logoutToolStripMenu.Click += new System.EventHandler(this.logoutToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(0, 188);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(13, 6, 13, 6);
            this.lblWelcome.Size = new System.Drawing.Size(675, 43);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formMainMemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS_Project_forms.Properties.Resources.librarian1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 418);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMainMemberWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member - Menu";
            this.Load += new System.EventHandler(this.formMainMemberWindow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem viewAllBookToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowedBooksToolStripMenuItem;
    }
}