namespace LMS_Project_forms
{
    partial class formMemberWindow
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
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.dataGridMemberDetails = new System.Windows.Forms.DataGridView();
            this.btnRemoveMember = new System.Windows.Forms.Button();
            this.btnClearMember = new System.Windows.Forms.Button();
            this.btnRegisterMember = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblMemberUsername = new System.Windows.Forms.Label();
            this.txtMemberEmail = new System.Windows.Forms.TextBox();
            this.lblMemberEmail = new System.Windows.Forms.Label();
            this.txtMemberName = new System.Windows.Forms.TextBox();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.lblMemberId = new System.Windows.Forms.Label();
            this.lblMemberTitle = new System.Windows.Forms.Label();
            this.txtMemberPassword = new System.Windows.Forms.TextBox();
            this.lblMemberPassword = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.memberToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.displayToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMemberDetails)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchMember.Location = new System.Drawing.Point(112, 415);
            this.btnSearchMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(89, 33);
            this.btnSearchMember.TabIndex = 32;
            this.btnSearchMember.Text = "Refresh";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // dataGridMemberDetails
            // 
            this.dataGridMemberDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMemberDetails.Location = new System.Drawing.Point(112, 454);
            this.dataGridMemberDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridMemberDetails.Name = "dataGridMemberDetails";
            this.dataGridMemberDetails.RowHeadersWidth = 51;
            this.dataGridMemberDetails.RowTemplate.Height = 24;
            this.dataGridMemberDetails.Size = new System.Drawing.Size(605, 267);
            this.dataGridMemberDetails.TabIndex = 31;
            // 
            // btnRemoveMember
            // 
            this.btnRemoveMember.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveMember.Location = new System.Drawing.Point(189, 341);
            this.btnRemoveMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveMember.Name = "btnRemoveMember";
            this.btnRemoveMember.Size = new System.Drawing.Size(89, 33);
            this.btnRemoveMember.TabIndex = 30;
            this.btnRemoveMember.Text = "Remove";
            this.btnRemoveMember.UseVisualStyleBackColor = true;
            this.btnRemoveMember.Click += new System.EventHandler(this.btnRemoveMember_Click);
            // 
            // btnClearMember
            // 
            this.btnClearMember.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMember.Location = new System.Drawing.Point(333, 341);
            this.btnClearMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearMember.Name = "btnClearMember";
            this.btnClearMember.Size = new System.Drawing.Size(89, 33);
            this.btnClearMember.TabIndex = 28;
            this.btnClearMember.Text = "Clear";
            this.btnClearMember.UseVisualStyleBackColor = true;
            this.btnClearMember.Click += new System.EventHandler(this.btnClearMember_Click);
            // 
            // btnRegisterMember
            // 
            this.btnRegisterMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegisterMember.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterMember.Location = new System.Drawing.Point(481, 341);
            this.btnRegisterMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegisterMember.Name = "btnRegisterMember";
            this.btnRegisterMember.Size = new System.Drawing.Size(89, 33);
            this.btnRegisterMember.TabIndex = 27;
            this.btnRegisterMember.Text = "Register";
            this.btnRegisterMember.UseVisualStyleBackColor = true;
            this.btnRegisterMember.Click += new System.EventHandler(this.btnRegisterMember_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(333, 252);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(191, 22);
            this.txtUsername.TabIndex = 26;
            // 
            // lblMemberUsername
            // 
            this.lblMemberUsername.AutoSize = true;
            this.lblMemberUsername.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberUsername.Location = new System.Drawing.Point(181, 252);
            this.lblMemberUsername.Name = "lblMemberUsername";
            this.lblMemberUsername.Size = new System.Drawing.Size(89, 23);
            this.lblMemberUsername.TabIndex = 25;
            this.lblMemberUsername.Text = "Username";
            // 
            // txtMemberEmail
            // 
            this.txtMemberEmail.Location = new System.Drawing.Point(333, 210);
            this.txtMemberEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberEmail.Name = "txtMemberEmail";
            this.txtMemberEmail.Size = new System.Drawing.Size(191, 22);
            this.txtMemberEmail.TabIndex = 24;
            // 
            // lblMemberEmail
            // 
            this.lblMemberEmail.AutoSize = true;
            this.lblMemberEmail.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberEmail.Location = new System.Drawing.Point(185, 210);
            this.lblMemberEmail.Name = "lblMemberEmail";
            this.lblMemberEmail.Size = new System.Drawing.Size(52, 23);
            this.lblMemberEmail.TabIndex = 23;
            this.lblMemberEmail.Text = "Email";
            // 
            // txtMemberName
            // 
            this.txtMemberName.Location = new System.Drawing.Point(333, 162);
            this.txtMemberName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberName.Name = "txtMemberName";
            this.txtMemberName.Size = new System.Drawing.Size(191, 22);
            this.txtMemberName.TabIndex = 22;
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberName.Location = new System.Drawing.Point(185, 162);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(57, 23);
            this.lblMemberName.TabIndex = 21;
            this.lblMemberName.Text = "Name";
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(333, 114);
            this.txtMemberId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(191, 22);
            this.txtMemberId.TabIndex = 20;
            // 
            // lblMemberId
            // 
            this.lblMemberId.AutoSize = true;
            this.lblMemberId.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberId.Location = new System.Drawing.Point(185, 114);
            this.lblMemberId.Name = "lblMemberId";
            this.lblMemberId.Size = new System.Drawing.Size(98, 23);
            this.lblMemberId.TabIndex = 19;
            this.lblMemberId.Text = "Member Id";
            // 
            // lblMemberTitle
            // 
            this.lblMemberTitle.AutoSize = true;
            this.lblMemberTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberTitle.Location = new System.Drawing.Point(145, 54);
            this.lblMemberTitle.Name = "lblMemberTitle";
            this.lblMemberTitle.Size = new System.Drawing.Size(423, 32);
            this.lblMemberTitle.TabIndex = 18;
            this.lblMemberTitle.Text = "Member Register and Remove";
            // 
            // txtMemberPassword
            // 
            this.txtMemberPassword.Location = new System.Drawing.Point(333, 292);
            this.txtMemberPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMemberPassword.Name = "txtMemberPassword";
            this.txtMemberPassword.Size = new System.Drawing.Size(191, 22);
            this.txtMemberPassword.TabIndex = 34;
            // 
            // lblMemberPassword
            // 
            this.lblMemberPassword.AutoSize = true;
            this.lblMemberPassword.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberPassword.Location = new System.Drawing.Point(181, 290);
            this.lblMemberPassword.Name = "lblMemberPassword";
            this.lblMemberPassword.Size = new System.Drawing.Size(86, 23);
            this.lblMemberPassword.TabIndex = 33;
            this.lblMemberPassword.Text = "Password";
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
            this.menuStrip1.TabIndex = 35;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // memberToolStripMenu
            // 
            this.memberToolStripMenu.Name = "memberToolStripMenu";
            this.memberToolStripMenu.Size = new System.Drawing.Size(57, 24);
            this.memberToolStripMenu.Text = "Book";
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
            // formMemberWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(763, 756);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtMemberPassword);
            this.Controls.Add(this.lblMemberPassword);
            this.Controls.Add(this.btnSearchMember);
            this.Controls.Add(this.dataGridMemberDetails);
            this.Controls.Add(this.btnRemoveMember);
            this.Controls.Add(this.btnClearMember);
            this.Controls.Add(this.btnRegisterMember);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblMemberUsername);
            this.Controls.Add(this.txtMemberEmail);
            this.Controls.Add(this.lblMemberEmail);
            this.Controls.Add(this.txtMemberName);
            this.Controls.Add(this.lblMemberName);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.lblMemberId);
            this.Controls.Add(this.lblMemberTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formMemberWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarian - Member Details";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMemberDetails)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.DataGridView dataGridMemberDetails;
        private System.Windows.Forms.Button btnRemoveMember;
        private System.Windows.Forms.Button btnClearMember;
        private System.Windows.Forms.Button btnRegisterMember;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblMemberUsername;
        private System.Windows.Forms.TextBox txtMemberEmail;
        private System.Windows.Forms.Label lblMemberEmail;
        private System.Windows.Forms.TextBox txtMemberName;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Label lblMemberId;
        private System.Windows.Forms.Label lblMemberTitle;
        private System.Windows.Forms.TextBox txtMemberPassword;
        private System.Windows.Forms.Label lblMemberPassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem memberToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem displayToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}