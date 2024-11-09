namespace LMS_Project_forms
{
    partial class formBorrow
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
            this.lblBookBorrowMember = new System.Windows.Forms.Label();
            this.lblBookIdMemberBorrowBook = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBorrowedBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMemberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBookIdMemberBookBorrow = new System.Windows.Forms.TextBox();
            this.lblBookNameMemberBookBorrow = new System.Windows.Forms.Label();
            this.dateTimePickerBorrow = new System.Windows.Forms.DateTimePicker();
            this.btnSearchBookIdMemberBookBorrow = new System.Windows.Forms.Button();
            this.btnBookBorrow = new System.Windows.Forms.Button();
            this.btnClearBookBorrow = new System.Windows.Forms.Button();
            this.txtMemberIdBookBorrow = new System.Windows.Forms.TextBox();
            this.lblMemberIdBorrowBook = new System.Windows.Forms.Label();
            this.txtMemberNameBookBorrow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtReuturnDate = new System.Windows.Forms.TextBox();
            this.cmbBookMemberBookBorrow = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBookBorrowMember
            // 
            this.lblBookBorrowMember.AutoSize = true;
            this.lblBookBorrowMember.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookBorrowMember.Location = new System.Drawing.Point(219, 52);
            this.lblBookBorrowMember.Name = "lblBookBorrowMember";
            this.lblBookBorrowMember.Size = new System.Drawing.Size(187, 35);
            this.lblBookBorrowMember.TabIndex = 0;
            this.lblBookBorrowMember.Text = "Book Borrow";
            // 
            // lblBookIdMemberBorrowBook
            // 
            this.lblBookIdMemberBorrowBook.AutoSize = true;
            this.lblBookIdMemberBorrowBook.Location = new System.Drawing.Point(100, 197);
            this.lblBookIdMemberBorrowBook.Name = "lblBookIdMemberBorrowBook";
            this.lblBookIdMemberBorrowBook.Size = new System.Drawing.Size(39, 16);
            this.lblBookIdMemberBorrowBook.TabIndex = 1;
            this.lblBookIdMemberBorrowBook.Text = "Book";
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
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            this.viewAllBooksToolStripMenuItem,
            this.viewBorrowedBooksToolStripMenuItem});
            this.displayToolStripMenu.Name = "displayToolStripMenu";
            this.displayToolStripMenu.Size = new System.Drawing.Size(72, 24);
            this.displayToolStripMenu.Text = "Display";
            this.displayToolStripMenu.Click += new System.EventHandler(this.displayToolStripMenu_Click);
            // 
            // viewAllBooksToolStripMenuItem
            // 
            this.viewAllBooksToolStripMenuItem.Name = "viewAllBooksToolStripMenuItem";
            this.viewAllBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.viewAllBooksToolStripMenuItem.Text = "View All Books";
            this.viewAllBooksToolStripMenuItem.Click += new System.EventHandler(this.viewAllBooksToolStripMenuItem_Click);
            // 
            // viewBorrowedBooksToolStripMenuItem
            // 
            this.viewBorrowedBooksToolStripMenuItem.Name = "viewBorrowedBooksToolStripMenuItem";
            this.viewBorrowedBooksToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.viewBorrowedBooksToolStripMenuItem.Text = "View Borrowed Books";
            this.viewBorrowedBooksToolStripMenuItem.Click += new System.EventHandler(this.viewBorrowedBooksToolStripMenuItem_Click);
            // 
            // menuMemberToolStripMenu
            // 
            this.menuMemberToolStripMenu.Name = "menuMemberToolStripMenu";
            this.menuMemberToolStripMenu.Size = new System.Drawing.Size(60, 24);
            this.menuMemberToolStripMenu.Text = "Menu";
            this.menuMemberToolStripMenu.Click += new System.EventHandler(this.logoutToolStripMenu_Click);
            // 
            // logoutToolStripMenu
            // 
            this.logoutToolStripMenu.Name = "logoutToolStripMenu";
            this.logoutToolStripMenu.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenu.Text = "Logout";
            this.logoutToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // txtBookIdMemberBookBorrow
            // 
            this.txtBookIdMemberBookBorrow.Location = new System.Drawing.Point(225, 148);
            this.txtBookIdMemberBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookIdMemberBookBorrow.Name = "txtBookIdMemberBookBorrow";
            this.txtBookIdMemberBookBorrow.Size = new System.Drawing.Size(168, 22);
            this.txtBookIdMemberBookBorrow.TabIndex = 5;
            // 
            // lblBookNameMemberBookBorrow
            // 
            this.lblBookNameMemberBookBorrow.AutoSize = true;
            this.lblBookNameMemberBookBorrow.Location = new System.Drawing.Point(100, 154);
            this.lblBookNameMemberBookBorrow.Name = "lblBookNameMemberBookBorrow";
            this.lblBookNameMemberBookBorrow.Size = new System.Drawing.Size(55, 16);
            this.lblBookNameMemberBookBorrow.TabIndex = 4;
            this.lblBookNameMemberBookBorrow.Text = "Book ID";
            // 
            // dateTimePickerBorrow
            // 
            this.dateTimePickerBorrow.Location = new System.Drawing.Point(224, 106);
            this.dateTimePickerBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerBorrow.Name = "dateTimePickerBorrow";
            this.dateTimePickerBorrow.Size = new System.Drawing.Size(257, 22);
            this.dateTimePickerBorrow.TabIndex = 10;
            this.dateTimePickerBorrow.ValueChanged += new System.EventHandler(this.dateTimePickerBorrow_ValueChanged);
            // 
            // btnSearchBookIdMemberBookBorrow
            // 
            this.btnSearchBookIdMemberBookBorrow.Location = new System.Drawing.Point(400, 148);
            this.btnSearchBookIdMemberBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchBookIdMemberBookBorrow.Name = "btnSearchBookIdMemberBookBorrow";
            this.btnSearchBookIdMemberBookBorrow.Size = new System.Drawing.Size(84, 26);
            this.btnSearchBookIdMemberBookBorrow.TabIndex = 12;
            this.btnSearchBookIdMemberBookBorrow.Text = "Check";
            this.btnSearchBookIdMemberBookBorrow.UseVisualStyleBackColor = true;
            this.btnSearchBookIdMemberBookBorrow.Click += new System.EventHandler(this.btnSearchBookIdMemberBookBorrow_Click);
            // 
            // btnBookBorrow
            // 
            this.btnBookBorrow.Location = new System.Drawing.Point(397, 368);
            this.btnBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookBorrow.Name = "btnBookBorrow";
            this.btnBookBorrow.Size = new System.Drawing.Size(84, 27);
            this.btnBookBorrow.TabIndex = 13;
            this.btnBookBorrow.Text = "Borrow";
            this.btnBookBorrow.UseVisualStyleBackColor = true;
            this.btnBookBorrow.Click += new System.EventHandler(this.btnBookBorrow_Click);
            // 
            // btnClearBookBorrow
            // 
            this.btnClearBookBorrow.Location = new System.Drawing.Point(271, 368);
            this.btnClearBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearBookBorrow.Name = "btnClearBookBorrow";
            this.btnClearBookBorrow.Size = new System.Drawing.Size(84, 26);
            this.btnClearBookBorrow.TabIndex = 14;
            this.btnClearBookBorrow.Text = "Clear";
            this.btnClearBookBorrow.UseVisualStyleBackColor = true;
            this.btnClearBookBorrow.Click += new System.EventHandler(this.btnClearBookBorrow_Click);
            // 
            // txtMemberIdBookBorrow
            // 
            this.txtMemberIdBookBorrow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberIdBookBorrow.Location = new System.Drawing.Point(224, 233);
            this.txtMemberIdBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberIdBookBorrow.Name = "txtMemberIdBookBorrow";
            this.txtMemberIdBookBorrow.ReadOnly = true;
            this.txtMemberIdBookBorrow.Size = new System.Drawing.Size(171, 22);
            this.txtMemberIdBookBorrow.TabIndex = 16;
            // 
            // lblMemberIdBorrowBook
            // 
            this.lblMemberIdBorrowBook.AutoSize = true;
            this.lblMemberIdBorrowBook.Location = new System.Drawing.Point(100, 240);
            this.lblMemberIdBorrowBook.Name = "lblMemberIdBorrowBook";
            this.lblMemberIdBorrowBook.Size = new System.Drawing.Size(73, 16);
            this.lblMemberIdBorrowBook.TabIndex = 15;
            this.lblMemberIdBorrowBook.Text = "Member ID";
            // 
            // txtMemberNameBookBorrow
            // 
            this.txtMemberNameBookBorrow.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtMemberNameBookBorrow.Location = new System.Drawing.Point(224, 274);
            this.txtMemberNameBookBorrow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberNameBookBorrow.Name = "txtMemberNameBookBorrow";
            this.txtMemberNameBookBorrow.ReadOnly = true;
            this.txtMemberNameBookBorrow.Size = new System.Drawing.Size(171, 22);
            this.txtMemberNameBookBorrow.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Member Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(100, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Borrow Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Return Date";
            // 
            // txtReuturnDate
            // 
            this.txtReuturnDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtReuturnDate.Location = new System.Drawing.Point(223, 316);
            this.txtReuturnDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReuturnDate.Name = "txtReuturnDate";
            this.txtReuturnDate.ReadOnly = true;
            this.txtReuturnDate.Size = new System.Drawing.Size(257, 22);
            this.txtReuturnDate.TabIndex = 23;
            // 
            // cmbBookMemberBookBorrow
            // 
            this.cmbBookMemberBookBorrow.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbBookMemberBookBorrow.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBookMemberBookBorrow.FormattingEnabled = true;
            this.cmbBookMemberBookBorrow.Location = new System.Drawing.Point(225, 190);
            this.cmbBookMemberBookBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbBookMemberBookBorrow.Name = "cmbBookMemberBookBorrow";
            this.cmbBookMemberBookBorrow.Size = new System.Drawing.Size(257, 24);
            this.cmbBookMemberBookBorrow.TabIndex = 25;
            this.cmbBookMemberBookBorrow.SelectedValueChanged += new System.EventHandler(this.cmbBookMemberBookBorrow_SelectedValueChanged);
            // 
            // formBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 454);
            this.Controls.Add(this.cmbBookMemberBookBorrow);
            this.Controls.Add(this.txtReuturnDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMemberNameBookBorrow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMemberIdBookBorrow);
            this.Controls.Add(this.lblMemberIdBorrowBook);
            this.Controls.Add(this.btnClearBookBorrow);
            this.Controls.Add(this.btnBookBorrow);
            this.Controls.Add(this.btnSearchBookIdMemberBookBorrow);
            this.Controls.Add(this.dateTimePickerBorrow);
            this.Controls.Add(this.txtBookIdMemberBookBorrow);
            this.Controls.Add(this.lblBookNameMemberBookBorrow);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lblBookIdMemberBorrowBook);
            this.Controls.Add(this.lblBookBorrowMember);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member - Book Borrow ";
            this.Load += new System.EventHandler(this.formBorrow_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookBorrowMember;
        private System.Windows.Forms.Label lblBookIdMemberBorrowBook;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem menuMemberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.TextBox txtBookIdMemberBookBorrow;
        private System.Windows.Forms.Label lblBookNameMemberBookBorrow;
        private System.Windows.Forms.DateTimePicker dateTimePickerBorrow;
        private System.Windows.Forms.Button btnSearchBookIdMemberBookBorrow;
        private System.Windows.Forms.Button btnBookBorrow;
        private System.Windows.Forms.ToolStripMenuItem viewAllBooksToolStripMenuItem;
        private System.Windows.Forms.Button btnClearBookBorrow;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtMemberIdBookBorrow;
        private System.Windows.Forms.Label lblMemberIdBorrowBook;
        private System.Windows.Forms.TextBox txtMemberNameBookBorrow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtReuturnDate;
        private System.Windows.Forms.ComboBox cmbBookMemberBookBorrow;
        private System.Windows.Forms.ToolStripMenuItem viewBorrowedBooksToolStripMenuItem;
    }
}