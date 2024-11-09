namespace LMS_Project_forms
{
    partial class formWelcome
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLibrarian = new System.Windows.Forms.Button();
            this.btnMember = new System.Windows.Forms.Button();
            this.btnWelcomeExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblWelcome.Location = new System.Drawing.Point(47, 66);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.lblWelcome.Size = new System.Drawing.Size(427, 35);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome to Library Management System";
            // 
            // btnLibrarian
            // 
            this.btnLibrarian.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLibrarian.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrarian.Location = new System.Drawing.Point(183, 151);
            this.btnLibrarian.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLibrarian.Name = "btnLibrarian";
            this.btnLibrarian.Size = new System.Drawing.Size(129, 33);
            this.btnLibrarian.TabIndex = 1;
            this.btnLibrarian.Text = "LIBRARIAN";
            this.btnLibrarian.UseVisualStyleBackColor = false;
            this.btnLibrarian.Click += new System.EventHandler(this.btnLibrarian_Click);
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMember.Font = new System.Drawing.Font("Calisto MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.Location = new System.Drawing.Point(183, 212);
            this.btnMember.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(129, 33);
            this.btnMember.TabIndex = 2;
            this.btnMember.Text = "MEMBER";
            this.btnMember.UseVisualStyleBackColor = false;
            this.btnMember.Click += new System.EventHandler(this.btnMember_Click);
            // 
            // btnWelcomeExit
            // 
            this.btnWelcomeExit.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeExit.Location = new System.Drawing.Point(43, 298);
            this.btnWelcomeExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnWelcomeExit.Name = "btnWelcomeExit";
            this.btnWelcomeExit.Size = new System.Drawing.Size(65, 23);
            this.btnWelcomeExit.TabIndex = 3;
            this.btnWelcomeExit.Text = "Exit";
            this.btnWelcomeExit.UseVisualStyleBackColor = true;
            this.btnWelcomeExit.Click += new System.EventHandler(this.btnWelcomeExit_Click);
            // 
            // formWelcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LMS_Project_forms.Properties.Resources.large_collection_old_books_wooden_shelves_generated_by_ai;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(506, 340);
            this.Controls.Add(this.btnWelcomeExit);
            this.Controls.Add(this.btnMember);
            this.Controls.Add(this.btnLibrarian);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formWelcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLibrarian;
        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnWelcomeExit;
    }
}

