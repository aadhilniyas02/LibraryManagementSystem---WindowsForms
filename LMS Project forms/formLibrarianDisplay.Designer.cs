namespace LMS_Project_forms
{
    partial class formLibrarianDisplay
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
            this.btnSearchBookStatus = new System.Windows.Forms.Button();
            this.dataGridLibrarianBookStatus = new System.Windows.Forms.DataGridView();
            this.btnSearchTransactionHistory = new System.Windows.Forms.Button();
            this.dataGridLibrarianTransactionHistory = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibrarianBookStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibrarianTransactionHistory)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchBookStatus
            // 
            this.btnSearchBookStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchBookStatus.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBookStatus.Location = new System.Drawing.Point(2, 42);
            this.btnSearchBookStatus.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchBookStatus.Name = "btnSearchBookStatus";
            this.btnSearchBookStatus.Size = new System.Drawing.Size(67, 36);
            this.btnSearchBookStatus.TabIndex = 19;
            this.btnSearchBookStatus.Text = "Refresh";
            this.btnSearchBookStatus.UseVisualStyleBackColor = true;
            this.btnSearchBookStatus.Click += new System.EventHandler(this.btnSearchBookStatus_Click);
            // 
            // dataGridLibrarianBookStatus
            // 
            this.dataGridLibrarianBookStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibrarianBookStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLibrarianBookStatus.Location = new System.Drawing.Point(2, 82);
            this.dataGridLibrarianBookStatus.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridLibrarianBookStatus.Name = "dataGridLibrarianBookStatus";
            this.dataGridLibrarianBookStatus.RowHeadersWidth = 51;
            this.dataGridLibrarianBookStatus.RowTemplate.Height = 24;
            this.dataGridLibrarianBookStatus.Size = new System.Drawing.Size(563, 421);
            this.dataGridLibrarianBookStatus.TabIndex = 18;
            // 
            // btnSearchTransactionHistory
            // 
            this.btnSearchTransactionHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSearchTransactionHistory.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTransactionHistory.Location = new System.Drawing.Point(569, 42);
            this.btnSearchTransactionHistory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchTransactionHistory.Name = "btnSearchTransactionHistory";
            this.btnSearchTransactionHistory.Size = new System.Drawing.Size(67, 36);
            this.btnSearchTransactionHistory.TabIndex = 21;
            this.btnSearchTransactionHistory.Text = "Refresh";
            this.btnSearchTransactionHistory.UseVisualStyleBackColor = true;
            this.btnSearchTransactionHistory.Click += new System.EventHandler(this.btnSearchTransactionHistory_Click);
            // 
            // dataGridLibrarianTransactionHistory
            // 
            this.dataGridLibrarianTransactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLibrarianTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridLibrarianTransactionHistory.Location = new System.Drawing.Point(569, 82);
            this.dataGridLibrarianTransactionHistory.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridLibrarianTransactionHistory.Name = "dataGridLibrarianTransactionHistory";
            this.dataGridLibrarianTransactionHistory.RowHeadersWidth = 51;
            this.dataGridLibrarianTransactionHistory.RowTemplate.Height = 24;
            this.dataGridLibrarianTransactionHistory.Size = new System.Drawing.Size(563, 421);
            this.dataGridLibrarianTransactionHistory.TabIndex = 20;
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 25);
            this.menuStrip1.TabIndex = 22;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(49, 21);
            this.memberToolStripMenu.Text = "Book";
            this.memberToolStripMenu.Click += new System.EventHandler(this.memberToolStripMenu_Click);
            // 
            // displayToolStripMenu
            // 
            this.displayToolStripMenu.Name = "displayToolStripMenu";
            this.displayToolStripMenu.Size = new System.Drawing.Size(70, 21);
            this.displayToolStripMenu.Text = "Member";
            this.displayToolStripMenu.Click += new System.EventHandler(this.displayToolStripMenu_Click);
            // 
            // logoutToolStripMenu
            // 
            this.logoutToolStripMenu.Name = "logoutToolStripMenu";
            this.logoutToolStripMenu.Size = new System.Drawing.Size(53, 21);
            this.logoutToolStripMenu.Text = "Menu";
            this.logoutToolStripMenu.Click += new System.EventHandler(this.logoutToolStripMenu_Click);
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(61, 21);
            this.exitToolStripMenu.Text = "Logout";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 21);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(563, 40);
            this.label1.TabIndex = 23;
            this.label1.Text = "Borrowed Books";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchTransactionHistory, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSearchBookStatus, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridLibrarianTransactionHistory, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.dataGridLibrarianBookStatus, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(32, 62);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 505);
            this.tableLayoutPanel1.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(563, 40);
            this.label2.TabIndex = 24;
            this.label2.Text = "Transaction History";
            // 
            // formLibrarianDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1200, 594);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formLibrarianDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian - Display";
            this.Load += new System.EventHandler(this.formLibrarianDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibrarianBookStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLibrarianTransactionHistory)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchBookStatus;
        private System.Windows.Forms.DataGridView dataGridLibrarianBookStatus;
        private System.Windows.Forms.Button btnSearchTransactionHistory;
        private System.Windows.Forms.DataGridView dataGridLibrarianTransactionHistory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
    }
}