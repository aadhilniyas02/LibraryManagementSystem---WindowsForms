namespace LMS_Project_forms
{
    partial class formBookReturn
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
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDueDateBookReturn = new System.Windows.Forms.TextBox();
            this.lblReturnBookCurrentDate = new System.Windows.Forms.Label();
            this.lblReturnBorrowDate = new System.Windows.Forms.Label();
            this.txtMemberIdReturn = new System.Windows.Forms.TextBox();
            this.lblMemberIdBorrowBook = new System.Windows.Forms.Label();
            this.btnClearBookReturn = new System.Windows.Forms.Button();
            this.btnBookReturn = new System.Windows.Forms.Button();
            this.btnSearchBookIdMemberBookBorrow = new System.Windows.Forms.Button();
            this.currentDateReturnBook = new System.Windows.Forms.DateTimePicker();
            this.txtBookIdReturn = new System.Windows.Forms.TextBox();
            this.lblBookIdReturn = new System.Windows.Forms.Label();
            this.lblBookBorrowMember = new System.Windows.Forms.Label();
            this.cmbBorrowedBookReturn = new System.Windows.Forms.ComboBox();
            this.lblBookIdMemberBorrowBook = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberNameReturn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBorrowedDateBookReturn = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenu,
            this.displayToolStripMenu,
            this.menuMemberToolStripMenu,
            this.logoutToolStripMenu,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(688, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(71, 24);
            this.memberToolStripMenu.Text = "Borrow";
            this.memberToolStripMenu.Click += new System.EventHandler(this.memberToolStripMenu_Click);
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
            this.borrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.borrowedBooksToolStripMenuItem_Click);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtDueDateBookReturn
            // 
            this.txtDueDateBookReturn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDueDateBookReturn.Location = new System.Drawing.Point(268, 145);
            this.txtDueDateBookReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDueDateBookReturn.Name = "txtDueDateBookReturn";
            this.txtDueDateBookReturn.ReadOnly = true;
            this.txtDueDateBookReturn.Size = new System.Drawing.Size(257, 22);
            this.txtDueDateBookReturn.TabIndex = 40;
            // 
            // lblReturnBookCurrentDate
            // 
            this.lblReturnBookCurrentDate.Location = new System.Drawing.Point(137, 415);
            this.lblReturnBookCurrentDate.Name = "lblReturnBookCurrentDate";
            this.lblReturnBookCurrentDate.Size = new System.Drawing.Size(117, 16);
            this.lblReturnBookCurrentDate.TabIndex = 39;
            this.lblReturnBookCurrentDate.Text = "Current Date";
            // 
            // lblReturnBorrowDate
            // 
            this.lblReturnBorrowDate.Location = new System.Drawing.Point(137, 150);
            this.lblReturnBorrowDate.Name = "lblReturnBorrowDate";
            this.lblReturnBorrowDate.Size = new System.Drawing.Size(117, 16);
            this.lblReturnBorrowDate.TabIndex = 38;
            this.lblReturnBorrowDate.Text = "Due Date";
            // 
            // txtMemberIdReturn
            // 
            this.txtMemberIdReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMemberIdReturn.Location = new System.Drawing.Point(268, 321);
            this.txtMemberIdReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberIdReturn.Name = "txtMemberIdReturn";
            this.txtMemberIdReturn.ReadOnly = true;
            this.txtMemberIdReturn.Size = new System.Drawing.Size(175, 22);
            this.txtMemberIdReturn.TabIndex = 33;
            // 
            // lblMemberIdBorrowBook
            // 
            this.lblMemberIdBorrowBook.Location = new System.Drawing.Point(137, 327);
            this.lblMemberIdBorrowBook.Name = "lblMemberIdBorrowBook";
            this.lblMemberIdBorrowBook.Size = new System.Drawing.Size(117, 16);
            this.lblMemberIdBorrowBook.TabIndex = 32;
            this.lblMemberIdBorrowBook.Text = "Member ID";
            // 
            // btnClearBookReturn
            // 
            this.btnClearBookReturn.Location = new System.Drawing.Point(292, 482);
            this.btnClearBookReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearBookReturn.Name = "btnClearBookReturn";
            this.btnClearBookReturn.Size = new System.Drawing.Size(84, 27);
            this.btnClearBookReturn.TabIndex = 31;
            this.btnClearBookReturn.Text = "Clear";
            this.btnClearBookReturn.UseVisualStyleBackColor = true;
            this.btnClearBookReturn.Click += new System.EventHandler(this.btnClearBookReturn_Click);
            // 
            // btnBookReturn
            // 
            this.btnBookReturn.Location = new System.Drawing.Point(417, 482);
            this.btnBookReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookReturn.Name = "btnBookReturn";
            this.btnBookReturn.Size = new System.Drawing.Size(84, 27);
            this.btnBookReturn.TabIndex = 30;
            this.btnBookReturn.Text = "Return";
            this.btnBookReturn.UseVisualStyleBackColor = true;
            this.btnBookReturn.Click += new System.EventHandler(this.btnBookReturn_Click);
            // 
            // btnSearchBookIdMemberBookBorrow
            // 
            this.btnSearchBookIdMemberBookBorrow.Location = new System.Drawing.Point(452, 230);
            this.btnSearchBookIdMemberBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBookIdMemberBookBorrow.Name = "btnSearchBookIdMemberBookBorrow";
            this.btnSearchBookIdMemberBookBorrow.Size = new System.Drawing.Size(75, 26);
            this.btnSearchBookIdMemberBookBorrow.TabIndex = 29;
            this.btnSearchBookIdMemberBookBorrow.Text = "Check";
            this.btnSearchBookIdMemberBookBorrow.UseVisualStyleBackColor = true;
            this.btnSearchBookIdMemberBookBorrow.Click += new System.EventHandler(this.btnSearchBookIdMemberBookBorrow_Click);
            // 
            // currentDateReturnBook
            // 
            this.currentDateReturnBook.Location = new System.Drawing.Point(268, 409);
            this.currentDateReturnBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentDateReturnBook.Name = "currentDateReturnBook";
            this.currentDateReturnBook.Size = new System.Drawing.Size(257, 22);
            this.currentDateReturnBook.TabIndex = 28;
            this.currentDateReturnBook.ValueChanged += new System.EventHandler(this.currentDateReturnBook_ValueChanged);
            // 
            // txtBookIdReturn
            // 
            this.txtBookIdReturn.Location = new System.Drawing.Point(268, 230);
            this.txtBookIdReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookIdReturn.Name = "txtBookIdReturn";
            this.txtBookIdReturn.Size = new System.Drawing.Size(175, 22);
            this.txtBookIdReturn.TabIndex = 25;
            // 
            // lblBookIdReturn
            // 
            this.lblBookIdReturn.Location = new System.Drawing.Point(137, 235);
            this.lblBookIdReturn.Name = "lblBookIdReturn";
            this.lblBookIdReturn.Size = new System.Drawing.Size(117, 16);
            this.lblBookIdReturn.TabIndex = 24;
            this.lblBookIdReturn.Text = "Book ID";
            // 
            // lblBookBorrowMember
            // 
            this.lblBookBorrowMember.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBookBorrowMember.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookBorrowMember.Location = new System.Drawing.Point(0, 58);
            this.lblBookBorrowMember.Name = "lblBookBorrowMember";
            this.lblBookBorrowMember.Size = new System.Drawing.Size(688, 36);
            this.lblBookBorrowMember.TabIndex = 41;
            this.lblBookBorrowMember.Text = "Book Return";
            this.lblBookBorrowMember.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBorrowedBookReturn
            // 
            this.cmbBorrowedBookReturn.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBorrowedBookReturn.DisplayMember = "Book_Name";
            this.cmbBorrowedBookReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowedBookReturn.FormattingEnabled = true;
            this.cmbBorrowedBookReturn.Location = new System.Drawing.Point(268, 278);
            this.cmbBorrowedBookReturn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBorrowedBookReturn.Name = "cmbBorrowedBookReturn";
            this.cmbBorrowedBookReturn.Size = new System.Drawing.Size(257, 24);
            this.cmbBorrowedBookReturn.TabIndex = 43;
            this.cmbBorrowedBookReturn.ValueMember = "Book_ID";
            this.cmbBorrowedBookReturn.SelectedValueChanged += new System.EventHandler(this.cmbBorrowedBookReturn_SelectedValueChanged);
            // 
            // lblBookIdMemberBorrowBook
            // 
            this.lblBookIdMemberBorrowBook.Location = new System.Drawing.Point(137, 282);
            this.lblBookIdMemberBorrowBook.Name = "lblBookIdMemberBorrowBook";
            this.lblBookIdMemberBorrowBook.Size = new System.Drawing.Size(117, 16);
            this.lblBookIdMemberBorrowBook.TabIndex = 42;
            this.lblBookIdMemberBorrowBook.Text = "Book";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(137, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Member Name";
            // 
            // txtMemberNameReturn
            // 
            this.txtMemberNameReturn.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtMemberNameReturn.Location = new System.Drawing.Point(268, 364);
            this.txtMemberNameReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberNameReturn.Name = "txtMemberNameReturn";
            this.txtMemberNameReturn.ReadOnly = true;
            this.txtMemberNameReturn.Size = new System.Drawing.Size(175, 22);
            this.txtMemberNameReturn.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(137, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 38;
            this.label2.Text = "Borrowed Date";
            // 
            // txtBorrowedDateBookReturn
            // 
            this.txtBorrowedDateBookReturn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtBorrowedDateBookReturn.Location = new System.Drawing.Point(268, 187);
            this.txtBorrowedDateBookReturn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBorrowedDateBookReturn.Name = "txtBorrowedDateBookReturn";
            this.txtBorrowedDateBookReturn.ReadOnly = true;
            this.txtBorrowedDateBookReturn.Size = new System.Drawing.Size(257, 22);
            this.txtBorrowedDateBookReturn.TabIndex = 40;
            // 
            // formBookReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 569);
            this.Controls.Add(this.cmbBorrowedBookReturn);
            this.Controls.Add(this.lblBookIdMemberBorrowBook);
            this.Controls.Add(this.lblBookBorrowMember);
            this.Controls.Add(this.txtBorrowedDateBookReturn);
            this.Controls.Add(this.txtDueDateBookReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReturnBookCurrentDate);
            this.Controls.Add(this.lblReturnBorrowDate);
            this.Controls.Add(this.txtMemberNameReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemberIdReturn);
            this.Controls.Add(this.lblMemberIdBorrowBook);
            this.Controls.Add(this.btnClearBookReturn);
            this.Controls.Add(this.btnBookReturn);
            this.Controls.Add(this.btnSearchBookIdMemberBookBorrow);
            this.Controls.Add(this.currentDateReturnBook);
            this.Controls.Add(this.txtBookIdReturn);
            this.Controls.Add(this.lblBookIdReturn);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formBookReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member - Book Return";
            this.Load += new System.EventHandler(this.formBookReturn_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem viewAllBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuMemberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtDueDateBookReturn;
        private System.Windows.Forms.Label lblReturnBookCurrentDate;
        private System.Windows.Forms.Label lblReturnBorrowDate;
        private System.Windows.Forms.TextBox txtMemberIdReturn;
        private System.Windows.Forms.Label lblMemberIdBorrowBook;
        private System.Windows.Forms.Button btnClearBookReturn;
        private System.Windows.Forms.Button btnBookReturn;
        private System.Windows.Forms.Button btnSearchBookIdMemberBookBorrow;
        private System.Windows.Forms.DateTimePicker currentDateReturnBook;
        private System.Windows.Forms.TextBox txtBookIdReturn;
        private System.Windows.Forms.Label lblBookIdReturn;
        private System.Windows.Forms.Label lblBookBorrowMember;
        private System.Windows.Forms.ComboBox cmbBorrowedBookReturn;
        private System.Windows.Forms.Label lblBookIdMemberBorrowBook;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberNameReturn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBorrowedDateBookReturn;
        private System.Windows.Forms.ToolStripMenuItem borrowedBooksToolStripMenuItem;
    }
}