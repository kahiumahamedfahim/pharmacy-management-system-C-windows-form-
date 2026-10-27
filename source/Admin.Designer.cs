namespace finalProject_pharmacy_managment_system_
{
    partial class Admin
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
            this.pnlDasboard = new System.Windows.Forms.Panel();
            this.btnSellinginfo = new System.Windows.Forms.Button();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnProductHandle = new System.Windows.Forms.Button();
            this.btnUserhanle = new System.Windows.Forms.Button();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlDasboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDasboard
            // 
            this.pnlDasboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlDasboard.Controls.Add(this.btnSellinginfo);
            this.pnlDasboard.Controls.Add(this.btnlogout);
            this.pnlDasboard.Controls.Add(this.btnProductHandle);
            this.pnlDasboard.Controls.Add(this.btnUserhanle);
            this.pnlDasboard.Controls.Add(this.lblAdmin);
            this.pnlDasboard.Location = new System.Drawing.Point(0, 3);
            this.pnlDasboard.Name = "pnlDasboard";
            this.pnlDasboard.Size = new System.Drawing.Size(252, 537);
            this.pnlDasboard.TabIndex = 0;
            this.pnlDasboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDasboard_Paint);
            // 
            // btnSellinginfo
            // 
            this.btnSellinginfo.Location = new System.Drawing.Point(44, 253);
            this.btnSellinginfo.Name = "btnSellinginfo";
            this.btnSellinginfo.Size = new System.Drawing.Size(102, 73);
            this.btnSellinginfo.TabIndex = 4;
            this.btnSellinginfo.Text = "Selling Info";
            this.btnSellinginfo.UseVisualStyleBackColor = true;
            this.btnSellinginfo.Click += new System.EventHandler(this.btnSellinginfo_Click);
            // 
            // btnlogout
            // 
            this.btnlogout.Location = new System.Drawing.Point(59, 417);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(75, 62);
            this.btnlogout.TabIndex = 3;
            this.btnlogout.Text = "Log out";
            this.btnlogout.UseVisualStyleBackColor = true;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnProductHandle
            // 
            this.btnProductHandle.Location = new System.Drawing.Point(44, 163);
            this.btnProductHandle.Name = "btnProductHandle";
            this.btnProductHandle.Size = new System.Drawing.Size(102, 73);
            this.btnProductHandle.TabIndex = 2;
            this.btnProductHandle.Text = "Product Handle";
            this.btnProductHandle.UseVisualStyleBackColor = true;
            this.btnProductHandle.Click += new System.EventHandler(this.btnProductHandle_Click);
            // 
            // btnUserhanle
            // 
            this.btnUserhanle.Location = new System.Drawing.Point(44, 58);
            this.btnUserhanle.Name = "btnUserhanle";
            this.btnUserhanle.Size = new System.Drawing.Size(102, 76);
            this.btnUserhanle.TabIndex = 1;
            this.btnUserhanle.Text = "UserHandle";
            this.btnUserhanle.UseVisualStyleBackColor = true;
            this.btnUserhanle.Click += new System.EventHandler(this.btnUserhanle_Click);
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(3, 9);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(88, 24);
            this.lblAdmin.TabIndex = 0;
            this.lblAdmin.Text = "Admin : ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(213, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1058, 540);
            this.panel1.TabIndex = 1;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlDasboard);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.pnlDasboard.ResumeLayout(false);
            this.pnlDasboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDasboard;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnUserhanle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnProductHandle;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnSellinginfo;
    }
}