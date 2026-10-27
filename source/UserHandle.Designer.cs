namespace finalProject_pharmacy_managment_system_
{
    partial class UserHandle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvuserinfo = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_managment_systemDataSet = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet();
            this.userInfoTableAdapter = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSetTableAdapters.UserInfoTableAdapter();
            this.btnshowall = new System.Windows.Forms.Button();
            this.lblsearch = new System.Windows.Forms.Label();
            this.lblusername = new System.Windows.Forms.Label();
            this.lblphone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.rdbManager = new System.Windows.Forms.RadioButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtuserid = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnclear = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.lblsearchtxt = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvuserinfo
            // 
            this.dgvuserinfo.AllowUserToAddRows = false;
            this.dgvuserinfo.AllowUserToDeleteRows = false;
            this.dgvuserinfo.AutoGenerateColumns = false;
            this.dgvuserinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvuserinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.userIdDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn});
            this.dgvuserinfo.DataSource = this.userInfoBindingSource;
            this.dgvuserinfo.Location = new System.Drawing.Point(3, 335);
            this.dgvuserinfo.Name = "dgvuserinfo";
            this.dgvuserinfo.ReadOnly = true;
            this.dgvuserinfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvuserinfo.Size = new System.Drawing.Size(1065, 202);
            this.dgvuserinfo.TabIndex = 0;
            this.dgvuserinfo.DoubleClick += new System.EventHandler(this.dgvuserinfo_DoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            this.roleDataGridViewTextBoxColumn.HeaderText = "Role";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            this.roleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userInfoBindingSource
            // 
            this.userInfoBindingSource.DataMember = "UserInfo";
            this.userInfoBindingSource.DataSource = this.pharmacy_managment_systemDataSet;
            // 
            // pharmacy_managment_systemDataSet
            // 
            this.pharmacy_managment_systemDataSet.DataSetName = "pharmacy_managment_systemDataSet";
            this.pharmacy_managment_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userInfoTableAdapter
            // 
            this.userInfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnshowall
            // 
            this.btnshowall.Location = new System.Drawing.Point(970, 256);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(75, 23);
            this.btnshowall.TabIndex = 1;
            this.btnshowall.Text = "show";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsearch.ForeColor = System.Drawing.Color.White;
            this.lblsearch.Location = new System.Drawing.Point(733, 10);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(73, 20);
            this.lblsearch.TabIndex = 2;
            this.lblsearch.Text = "search :";
            this.lblsearch.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblusername
            // 
            this.lblusername.AutoSize = true;
            this.lblusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblusername.ForeColor = System.Drawing.Color.White;
            this.lblusername.Location = new System.Drawing.Point(12, 46);
            this.lblusername.Name = "lblusername";
            this.lblusername.Size = new System.Drawing.Size(65, 20);
            this.lblusername.TabIndex = 3;
            this.lblusername.Text = "Name: ";
            // 
            // lblphone
            // 
            this.lblphone.AutoSize = true;
            this.lblphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphone.ForeColor = System.Drawing.Color.White;
            this.lblphone.Location = new System.Drawing.Point(12, 80);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(70, 20);
            this.lblphone.TabIndex = 4;
            this.lblphone.Text = "Phone :";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemail.ForeColor = System.Drawing.Color.White;
            this.lblemail.Location = new System.Drawing.Point(12, 110);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(63, 20);
            this.lblemail.TabIndex = 5;
            this.lblemail.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Address :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "UserId :";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password :";
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.BackColor = System.Drawing.Color.White;
            this.rdbAdmin.Location = new System.Drawing.Point(90, 239);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbAdmin.TabIndex = 10;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = false;
            this.rdbAdmin.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rdbManager
            // 
            this.rdbManager.AutoSize = true;
            this.rdbManager.BackColor = System.Drawing.Color.White;
            this.rdbManager.Location = new System.Drawing.Point(90, 262);
            this.rdbManager.Name = "rdbManager";
            this.rdbManager.Size = new System.Drawing.Size(67, 17);
            this.rdbManager.TabIndex = 11;
            this.rdbManager.TabStop = true;
            this.rdbManager.Text = "Manager";
            this.rdbManager.UseVisualStyleBackColor = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(26, 248);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(51, 20);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Role:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(110, 46);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(142, 20);
            this.txtname.TabIndex = 13;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(207, 46);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(10, 20);
            this.maskedTextBox1.TabIndex = 14;
            // 
            // txtphone
            // 
            this.txtphone.Location = new System.Drawing.Point(110, 80);
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(142, 20);
            this.txtphone.TabIndex = 15;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(110, 110);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(142, 20);
            this.txtemail.TabIndex = 16;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(110, 145);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(142, 20);
            this.txtaddress.TabIndex = 17;
            // 
            // txtuserid
            // 
            this.txtuserid.Location = new System.Drawing.Point(110, 179);
            this.txtuserid.Name = "txtuserid";
            this.txtuserid.Size = new System.Drawing.Size(142, 20);
            this.txtuserid.TabIndex = 18;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(110, 213);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(142, 20);
            this.txtpassword.TabIndex = 19;
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(16, 290);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 32);
            this.btnclear.TabIndex = 20;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btndelete
            // 
            this.btndelete.Location = new System.Drawing.Point(270, 288);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 32);
            this.btndelete.TabIndex = 21;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(97, 288);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(178, 290);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(74, 30);
            this.btnUpdate.TabIndex = 23;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(812, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(140, 20);
            this.txtsearch.TabIndex = 24;
            // 
            // lblsearchtxt
            // 
            this.lblsearchtxt.AutoSize = true;
            this.lblsearchtxt.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblsearchtxt.Location = new System.Drawing.Point(836, 41);
            this.lblsearchtxt.Name = "lblsearchtxt";
            this.lblsearchtxt.Size = new System.Drawing.Size(82, 13);
            this.lblsearchtxt.TabIndex = 26;
            this.lblsearchtxt.Text = "search by name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(970, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 27;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(3, 7);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // UserHandle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblsearchtxt);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuserid);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.rdbManager);
            this.Controls.Add(this.rdbAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblphone);
            this.Controls.Add(this.lblusername);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.dgvuserinfo);
            this.Name = "UserHandle";
            this.Size = new System.Drawing.Size(1058, 540);
            this.Load += new System.EventHandler(this.UserHandle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvuserinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvuserinfo;
        private System.Windows.Forms.BindingSource userInfoBindingSource;
        private pharmacy_managment_systemDataSet pharmacy_managment_systemDataSet;
        private pharmacy_managment_systemDataSetTableAdapters.UserInfoTableAdapter userInfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.Label lblusername;
        private System.Windows.Forms.Label lblphone;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.RadioButton rdbManager;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.TextBox txtuserid;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Label lblsearchtxt;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnBack;
    }
}
