namespace finalProject_pharmacy_managment_system_
{
    partial class Manager
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
            this.btnSell = new System.Windows.Forms.Button();
            this.lblManager = new System.Windows.Forms.Label();
            this.pnlManagerSell = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlDasboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDasboard
            // 
            this.pnlDasboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pnlDasboard.Controls.Add(this.btnLogout);
            this.pnlDasboard.Controls.Add(this.btnSell);
            this.pnlDasboard.Controls.Add(this.lblManager);
            this.pnlDasboard.Location = new System.Drawing.Point(0, -3);
            this.pnlDasboard.Name = "pnlDasboard";
            this.pnlDasboard.Size = new System.Drawing.Size(204, 543);
            this.pnlDasboard.TabIndex = 1;
            this.pnlDasboard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDasboard_Paint);
            // 
            // btnSell
            // 
            this.btnSell.Location = new System.Drawing.Point(47, 84);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(75, 75);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // lblManager
            // 
            this.lblManager.AutoSize = true;
            this.lblManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManager.Location = new System.Drawing.Point(12, 19);
            this.lblManager.Name = "lblManager";
            this.lblManager.Size = new System.Drawing.Size(110, 24);
            this.lblManager.TabIndex = 0;
            this.lblManager.Text = "Manager : ";
            // 
            // pnlManagerSell
            // 
            this.pnlManagerSell.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlManagerSell.Location = new System.Drawing.Point(201, 0);
            this.pnlManagerSell.Name = "pnlManagerSell";
            this.pnlManagerSell.Size = new System.Drawing.Size(1058, 540);
            this.pnlManagerSell.TabIndex = 2;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(47, 460);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(81, 70);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 539);
            this.Controls.Add(this.pnlManagerSell);
            this.Controls.Add(this.pnlDasboard);
            this.Name = "Manager";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.Manager_Load);
            this.pnlDasboard.ResumeLayout(false);
            this.pnlDasboard.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDasboard;
        private System.Windows.Forms.Label lblManager;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Panel pnlManagerSell;
        private System.Windows.Forms.Button btnLogout;
    }
}