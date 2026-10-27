namespace finalProject_pharmacy_managment_system_
{
    partial class loginform
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
            this.pnl1ForPicture = new System.Windows.Forms.Panel();
            this.pnlForLogin = new System.Windows.Forms.Panel();
            this.lblReset = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lbluserid = new System.Windows.Forms.Label();
            this.btnExiit = new System.Windows.Forms.Button();
            this.pnlForLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl1ForPicture
            // 
            this.pnl1ForPicture.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnl1ForPicture.Location = new System.Drawing.Point(3, 2);
            this.pnl1ForPicture.Name = "pnl1ForPicture";
            this.pnl1ForPicture.Size = new System.Drawing.Size(358, 645);
            this.pnl1ForPicture.TabIndex = 0;
            // 
            // pnlForLogin
            // 
            this.pnlForLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.pnlForLogin.Controls.Add(this.btnExiit);
            this.pnlForLogin.Controls.Add(this.lblReset);
            this.pnlForLogin.Controls.Add(this.btnLogin);
            this.pnlForLogin.Controls.Add(this.txtpassword);
            this.pnlForLogin.Controls.Add(this.txtuserid);
            this.pnlForLogin.Controls.Add(this.lblPassword);
            this.pnlForLogin.Controls.Add(this.lbluserid);
            this.pnlForLogin.Location = new System.Drawing.Point(349, -1);
            this.pnlForLogin.Name = "pnlForLogin";
            this.pnlForLogin.Size = new System.Drawing.Size(477, 645);
            this.pnlForLogin.TabIndex = 1;
            // 
            // lblReset
            // 
            this.lblReset.BackColor = System.Drawing.Color.IndianRed;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReset.ForeColor = System.Drawing.Color.Black;
            this.lblReset.Location = new System.Drawing.Point(310, 330);
            this.lblReset.Name = "lblReset";
            this.lblReset.Size = new System.Drawing.Size(96, 42);
            this.lblReset.TabIndex = 5;
            this.lblReset.Text = "Reset";
            this.lblReset.UseVisualStyleBackColor = false;
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Blue;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(189, 330);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(96, 42);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(235, 264);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(161, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(235, 210);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(161, 20);
            this.txtuserid.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(104, 264);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(112, 24);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password :";
            // 
            // lbluserid
            // 
            this.lbluserid.AutoSize = true;
            this.lbluserid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbluserid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluserid.Location = new System.Drawing.Point(128, 210);
            this.lbluserid.Name = "lbluserid";
            this.lbluserid.Size = new System.Drawing.Size(88, 24);
            this.lbluserid.TabIndex = 0;
            this.lbluserid.Text = "User Id :";
            // 
            // btnExiit
            // 
            this.btnExiit.BackColor = System.Drawing.Color.Red;
            this.btnExiit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExiit.Location = new System.Drawing.Point(361, 572);
            this.btnExiit.Name = "btnExiit";
            this.btnExiit.Size = new System.Drawing.Size(75, 44);
            this.btnExiit.TabIndex = 6;
            this.btnExiit.Text = "Exit";
            this.btnExiit.UseVisualStyleBackColor = false;
            this.btnExiit.Click += new System.EventHandler(this.btnExiit_Click);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 636);
            this.Controls.Add(this.pnlForLogin);
            this.Controls.Add(this.pnl1ForPicture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "loginform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginform_Load);
            this.pnlForLogin.ResumeLayout(false);
            this.pnlForLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl1ForPicture;
        private System.Windows.Forms.Panel pnlForLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lbluserid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button lblReset;
        private System.Windows.Forms.Button btnExiit;
    }
}

