namespace finalProject_pharmacy_managment_system_
{
    partial class Sellinginfo
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
            this.dgvBilingHold = new System.Windows.Forms.DataGridView();
            this.pharmacy_managment_systemDataSet8 = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet8();
            this.billholdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billholdTableAdapter = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet8TableAdapters.BillholdTableAdapter();
            this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilingHold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billholdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBilingHold
            // 
            this.dgvBilingHold.AllowUserToAddRows = false;
            this.dgvBilingHold.AllowUserToDeleteRows = false;
            this.dgvBilingHold.AutoGenerateColumns = false;
            this.dgvBilingHold.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilingHold.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNameDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.billDataGridViewTextBoxColumn});
            this.dgvBilingHold.DataSource = this.billholdBindingSource;
            this.dgvBilingHold.Location = new System.Drawing.Point(0, 3);
            this.dgvBilingHold.Name = "dgvBilingHold";
            this.dgvBilingHold.ReadOnly = true;
            this.dgvBilingHold.Size = new System.Drawing.Size(1058, 238);
            this.dgvBilingHold.TabIndex = 0;
            // 
            // pharmacy_managment_systemDataSet8
            // 
            this.pharmacy_managment_systemDataSet8.DataSetName = "pharmacy_managment_systemDataSet8";
            this.pharmacy_managment_systemDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billholdBindingSource
            // 
            this.billholdBindingSource.DataMember = "Billhold";
            this.billholdBindingSource.DataSource = this.pharmacy_managment_systemDataSet8;
            // 
            // billholdTableAdapter
            // 
            this.billholdTableAdapter.ClearBeforeFill = true;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            this.customerNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.HeaderText = "CustomerName";
            this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // billDataGridViewTextBoxColumn
            // 
            this.billDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.billDataGridViewTextBoxColumn.DataPropertyName = "Bill";
            this.billDataGridViewTextBoxColumn.HeaderText = "Bill";
            this.billDataGridViewTextBoxColumn.Name = "billDataGridViewTextBoxColumn";
            this.billDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Sellinginfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.dgvBilingHold);
            this.Name = "Sellinginfo";
            this.Size = new System.Drawing.Size(1058, 540);
            this.Load += new System.EventHandler(this.Sellinginfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilingHold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billholdBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBilingHold;
        private System.Windows.Forms.BindingSource billholdBindingSource;
        private pharmacy_managment_systemDataSet8 pharmacy_managment_systemDataSet8;
        private pharmacy_managment_systemDataSet8TableAdapters.BillholdTableAdapter billholdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn billDataGridViewTextBoxColumn;
    }
}
