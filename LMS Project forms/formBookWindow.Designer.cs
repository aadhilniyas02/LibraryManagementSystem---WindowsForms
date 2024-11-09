namespace LMS_Project_forms
{
    partial class formBookWindow
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
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookIsbn = new System.Windows.Forms.TextBox();
            this.lblBookIsbn = new System.Windows.Forms.Label();
            this.btnRegisterBook = new System.Windows.Forms.Button();
            this.btnClearBook = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.dataGridBookDetails = new System.Windows.Forms.DataGridView();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.memberToolStripMenu,
            this.displayToolStripMenu,
            this.logoutToolStripMenu,
            this.exitToolStripMenu,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(763, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(79, 24);
            this.memberToolStripMenu.Text = "Member";
            this.memberToolStripMenu.Click += new System.EventHandler(this.memberToolStripMenu_Click);
            // 
            // displayToolStripMenu
            // 
            this.displayToolStripMenu.Name = "displayToolStripMenu";
            this.displayToolStripMenu.Size = new System.Drawing.Size(72, 24);
            this.displayToolStripMenu.Text = "Display";
            this.displayToolStripMenu.Click += new System.EventHandler(this.displayToolStripMenu_Click);
            // 
            // logoutToolStripMenu
            // 
            this.logoutToolStripMenu.Name = "logoutToolStripMenu";
            this.logoutToolStripMenu.Size = new System.Drawing.Size(60, 24);
            this.logoutToolStripMenu.Text = "Menu";
            this.logoutToolStripMenu.Click += new System.EventHandler(this.logoutToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(70, 24);
            this.exitToolStripMenu.Text = "Logout";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookTitle.Location = new System.Drawing.Point(137, 60);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(383, 32);
            this.lblBookTitle.TabIndex = 3;
            this.lblBookTitle.Text = "Book Register and Remove";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookId.Location = new System.Drawing.Point(203, 121);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(74, 23);
            this.lblBookId.TabIndex = 4;
            this.lblBookId.Text = "Book ID";
            // 
            // txtBookId
            // 
            this.txtBookId.Location = new System.Drawing.Point(313, 121);
            this.txtBookId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.Size = new System.Drawing.Size(191, 22);
            this.txtBookId.TabIndex = 5;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(313, 169);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(191, 22);
            this.txtBookName.TabIndex = 7;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookName.Location = new System.Drawing.Point(203, 169);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(57, 23);
            this.lblBookName.TabIndex = 6;
            this.lblBookName.Text = "Name";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(313, 217);
            this.txtBookAuthor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(191, 22);
            this.txtBookAuthor.TabIndex = 9;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookAuthor.Location = new System.Drawing.Point(203, 215);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(65, 23);
            this.lblBookAuthor.TabIndex = 8;
            this.lblBookAuthor.Text = "Author";
            // 
            // txtBookIsbn
            // 
            this.txtBookIsbn.Location = new System.Drawing.Point(313, 258);
            this.txtBookIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBookIsbn.Name = "txtBookIsbn";
            this.txtBookIsbn.Size = new System.Drawing.Size(191, 22);
            this.txtBookIsbn.TabIndex = 11;
            // 
            // lblBookIsbn
            // 
            this.lblBookIsbn.AutoSize = true;
            this.lblBookIsbn.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookIsbn.Location = new System.Drawing.Point(203, 258);
            this.lblBookIsbn.Name = "lblBookIsbn";
            this.lblBookIsbn.Size = new System.Drawing.Size(48, 23);
            this.lblBookIsbn.TabIndex = 10;
            this.lblBookIsbn.Text = "ISBN";
            // 
            // btnRegisterBook
            // 
            this.btnRegisterBook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegisterBook.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterBook.Location = new System.Drawing.Point(499, 309);
            this.btnRegisterBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterBook.Name = "btnRegisterBook";
            this.btnRegisterBook.Size = new System.Drawing.Size(89, 33);
            this.btnRegisterBook.TabIndex = 12;
            this.btnRegisterBook.Text = "Register";
            this.btnRegisterBook.UseVisualStyleBackColor = true;
            this.btnRegisterBook.Click += new System.EventHandler(this.btnRegisterBook_Click);
            // 
            // btnClearBook
            // 
            this.btnClearBook.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearBook.Location = new System.Drawing.Point(360, 309);
            this.btnClearBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearBook.Name = "btnClearBook";
            this.btnClearBook.Size = new System.Drawing.Size(89, 33);
            this.btnClearBook.TabIndex = 13;
            this.btnClearBook.Text = "Clear";
            this.btnClearBook.UseVisualStyleBackColor = true;
            this.btnClearBook.Click += new System.EventHandler(this.btnClearBook_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBook.Location = new System.Drawing.Point(205, 309);
            this.btnDeleteBook.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(89, 33);
            this.btnDeleteBook.TabIndex = 15;
            this.btnDeleteBook.Text = "Remove";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // dataGridBookDetails
            // 
            this.dataGridBookDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridBookDetails.Location = new System.Drawing.Point(53, 425);
            this.dataGridBookDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridBookDetails.Name = "dataGridBookDetails";
            this.dataGridBookDetails.RowHeadersWidth = 51;
            this.dataGridBookDetails.RowTemplate.Height = 24;
            this.dataGridBookDetails.Size = new System.Drawing.Size(609, 288);
            this.dataGridBookDetails.TabIndex = 16;
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookSearch.Location = new System.Drawing.Point(53, 386);
            this.btnBookSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(89, 33);
            this.btnBookSearch.TabIndex = 17;
            this.btnBookSearch.Text = "Refresh";
            this.btnBookSearch.UseVisualStyleBackColor = true;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // formBookWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(763, 756);
            this.Controls.Add(this.btnBookSearch);
            this.Controls.Add(this.dataGridBookDetails);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnClearBook);
            this.Controls.Add(this.btnRegisterBook);
            this.Controls.Add(this.txtBookIsbn);
            this.Controls.Add(this.lblBookIsbn);
            this.Controls.Add(this.txtBookAuthor);
            this.Controls.Add(this.lblBookAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.txtBookId);
            this.Controls.Add(this.lblBookId);
            this.Controls.Add(this.lblBookTitle);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formBookWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian - Book Details";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridBookDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookIsbn;
        private System.Windows.Forms.Label lblBookIsbn;
        private System.Windows.Forms.Button btnRegisterBook;
        private System.Windows.Forms.Button btnClearBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.DataGridView dataGridBookDetails;
        private System.Windows.Forms.Button btnBookSearch;
    }
}