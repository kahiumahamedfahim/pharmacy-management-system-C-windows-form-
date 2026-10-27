namespace finalProject_pharmacy_managment_system_
{
    partial class Sellcontrol
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
            this.dgvproduct = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_managment_systemDataSet2 = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet2();
            this.pharmacy_managment_systemDataSet = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet();
            this.pharmacymanagmentsystemDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet2TableAdapters.ProductTableAdapter();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblQunatity = new System.Windows.Forms.Label();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnshow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchByName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.dgvBilinginfo = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilinginfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pharmacy_managment_systemDataSet6 = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet6();
            this.pharmacy_managment_systemDataSet5 = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet5();
            this.billholdBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.billholdTableAdapter = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet5TableAdapters.BillholdTableAdapter();
            this.bilinginfoTableAdapter = new finalProject_pharmacy_managment_system_.pharmacy_managment_systemDataSet6TableAdapters.BilinginfoTableAdapter();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnCalculatePrice = new System.Windows.Forms.Button();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btntotalPrice = new System.Windows.Forms.Button();
            this.txtTotalPrice = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteFromChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacymanagmentsystemDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilinginfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilinginfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billholdBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvproduct
            // 
            this.dgvproduct.AllowUserToAddRows = false;
            this.dgvproduct.AllowUserToDeleteRows = false;
            this.dgvproduct.AutoGenerateColumns = false;
            this.dgvproduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvproduct.DataSource = this.productBindingSource;
            this.dgvproduct.Location = new System.Drawing.Point(0, 375);
            this.dgvproduct.Name = "dgvproduct";
            this.dgvproduct.ReadOnly = true;
            this.dgvproduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproduct.Size = new System.Drawing.Size(1058, 165);
            this.dgvproduct.TabIndex = 0;
            this.dgvproduct.DoubleClick += new System.EventHandler(this.dgvproduct_DoubleClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "CompanyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            this.quantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.pharmacy_managment_systemDataSet2;
            // 
            // pharmacy_managment_systemDataSet2
            // 
            this.pharmacy_managment_systemDataSet2.DataSetName = "pharmacy_managment_systemDataSet2";
            this.pharmacy_managment_systemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_managment_systemDataSet
            // 
            this.pharmacy_managment_systemDataSet.DataSetName = "pharmacy_managment_systemDataSet";
            this.pharmacy_managment_systemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacymanagmentsystemDataSetBindingSource
            // 
            this.pharmacymanagmentsystemDataSetBindingSource.DataSource = this.pharmacy_managment_systemDataSet;
            this.pharmacymanagmentsystemDataSetBindingSource.Position = 0;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Black;
            this.lblProductName.ForeColor = System.Drawing.Color.White;
            this.lblProductName.Location = new System.Drawing.Point(3, 61);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(84, 13);
            this.lblProductName.TabIndex = 1;
            this.lblProductName.Text = "Product Name : ";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // lblQunatity
            // 
            this.lblQunatity.AutoSize = true;
            this.lblQunatity.BackColor = System.Drawing.Color.Black;
            this.lblQunatity.ForeColor = System.Drawing.Color.White;
            this.lblQunatity.Location = new System.Drawing.Point(19, 108);
            this.lblQunatity.Name = "lblQunatity";
            this.lblQunatity.Size = new System.Drawing.Size(52, 13);
            this.lblQunatity.TabIndex = 2;
            this.lblQunatity.Text = "Qunatity :";
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(93, 58);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 4;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(77, 108);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 5;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(980, 349);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(75, 23);
            this.btnshow.TabIndex = 7;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(777, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "search by name : ";
            // 
            // txtSearchByName
            // 
            this.txtSearchByName.Location = new System.Drawing.Point(874, 351);
            this.txtSearchByName.Name = "txtSearchByName";
            this.txtSearchByName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchByName.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(195, 100);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(24, 28);
            this.btnPlus.TabIndex = 10;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(234, 100);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(24, 28);
            this.btnMinus.TabIndex = 11;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(119, 162);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // dgvBilinginfo
            // 
            this.dgvBilinginfo.AllowUserToAddRows = false;
            this.dgvBilinginfo.AllowUserToDeleteRows = false;
            this.dgvBilinginfo.AutoGenerateColumns = false;
            this.dgvBilinginfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBilinginfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn1,
            this.priceDataGridViewTextBoxColumn1});
            this.dgvBilinginfo.DataSource = this.bilinginfoBindingSource;
            this.dgvBilinginfo.Location = new System.Drawing.Point(611, 3);
            this.dgvBilinginfo.Name = "dgvBilinginfo";
            this.dgvBilinginfo.ReadOnly = true;
            this.dgvBilinginfo.Size = new System.Drawing.Size(444, 150);
            this.dgvBilinginfo.TabIndex = 14;
            this.dgvBilinginfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvBilinginfo_RowHeaderMouseDoubleClick);
            this.dgvBilinginfo.DoubleClick += new System.EventHandler(this.dgvBilinginfo_DoubleClick);
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn1
            // 
            this.quantityDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn1.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn1.Name = "quantityDataGridViewTextBoxColumn1";
            this.quantityDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            this.priceDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn1.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            this.priceDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // bilinginfoBindingSource
            // 
            this.bilinginfoBindingSource.DataMember = "Bilinginfo";
            this.bilinginfoBindingSource.DataSource = this.pharmacy_managment_systemDataSet6;
            // 
            // pharmacy_managment_systemDataSet6
            // 
            this.pharmacy_managment_systemDataSet6.DataSetName = "pharmacy_managment_systemDataSet6";
            this.pharmacy_managment_systemDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pharmacy_managment_systemDataSet5
            // 
            this.pharmacy_managment_systemDataSet5.DataSetName = "pharmacy_managment_systemDataSet5";
            this.pharmacy_managment_systemDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billholdBindingSource
            // 
            this.billholdBindingSource.DataMember = "Billhold";
            this.billholdBindingSource.DataSource = this.pharmacy_managment_systemDataSet5;
            // 
            // billholdTableAdapter
            // 
            this.billholdTableAdapter.ClearBeforeFill = true;
            // 
            // bilinginfoTableAdapter
            // 
            this.bilinginfoTableAdapter.ClearBeforeFill = true;
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(93, 221);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(75, 44);
            this.btnChart.TabIndex = 15;
            this.btnChart.Text = "Add to Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(971, 289);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(75, 23);
            this.btnBill.TabIndex = 17;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnCalculatePrice
            // 
            this.btnCalculatePrice.Location = new System.Drawing.Point(0, 162);
            this.btnCalculatePrice.Name = "btnCalculatePrice";
            this.btnCalculatePrice.Size = new System.Drawing.Size(111, 23);
            this.btnCalculatePrice.TabIndex = 18;
            this.btnCalculatePrice.Text = "Calculate Price :";
            this.btnCalculatePrice.UseVisualStyleBackColor = true;
            this.btnCalculatePrice.Click += new System.EventHandler(this.btnCalculatePrice_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(608, 171);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(88, 13);
            this.lblCustomerName.TabIndex = 19;
            this.lblCustomerName.Text = "Customer Name :";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.White;
            this.lblPhone.Location = new System.Drawing.Point(619, 202);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 13);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "Phone:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(619, 231);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(33, 13);
            this.lblDate.TabIndex = 21;
            this.lblDate.Text = "Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(668, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(702, 168);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(145, 20);
            this.txtCustomerName.TabIndex = 23;
            this.txtCustomerName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(702, 199);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(145, 20);
            this.txtPhone.TabIndex = 25;
            // 
            // btntotalPrice
            // 
            this.btntotalPrice.Location = new System.Drawing.Point(874, 162);
            this.btntotalPrice.Name = "btntotalPrice";
            this.btntotalPrice.Size = new System.Drawing.Size(75, 23);
            this.btntotalPrice.TabIndex = 26;
            this.btntotalPrice.Text = "Total:";
            this.btntotalPrice.UseVisualStyleBackColor = true;
            this.btntotalPrice.Click += new System.EventHandler(this.btntotalPrice_Click);
            // 
            // txtTotalPrice
            // 
            this.txtTotalPrice.Location = new System.Drawing.Point(955, 164);
            this.txtTotalPrice.Name = "txtTotalPrice";
            this.txtTotalPrice.Size = new System.Drawing.Size(82, 20);
            this.txtTotalPrice.TabIndex = 27;
            this.txtTotalPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 28;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDeleteFromChart
            // 
            this.btnDeleteFromChart.Location = new System.Drawing.Point(234, 221);
            this.btnDeleteFromChart.Name = "btnDeleteFromChart";
            this.btnDeleteFromChart.Size = new System.Drawing.Size(75, 44);
            this.btnDeleteFromChart.TabIndex = 29;
            this.btnDeleteFromChart.Text = "Delete from Chart";
            this.btnDeleteFromChart.UseVisualStyleBackColor = true;
            this.btnDeleteFromChart.Click += new System.EventHandler(this.btnDeleteFromChart_Click);
            // 
            // Sellcontrol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.btnDeleteFromChart);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtTotalPrice);
            this.Controls.Add(this.btntotalPrice);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.btnCalculatePrice);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.dgvBilinginfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.txtSearchByName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblQunatity);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.dgvproduct);
            this.Name = "Sellcontrol";
            this.Size = new System.Drawing.Size(1058, 540);
            this.Load += new System.EventHandler(this.Sellcontrol_Load);
            this.DoubleClick += new System.EventHandler(this.Sellcontrol_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvproduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacymanagmentsystemDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBilinginfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilinginfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_managment_systemDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billholdBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
        private pharmacy_managment_systemDataSet2 pharmacy_managment_systemDataSet2;
        private pharmacy_managment_systemDataSet pharmacy_managment_systemDataSet;
        private System.Windows.Forms.BindingSource pharmacymanagmentsystemDataSetBindingSource;
        private pharmacy_managment_systemDataSet2TableAdapters.ProductTableAdapter productTableAdapter;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblQunatity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchByName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.DataGridView dgvBilinginfo;
        private System.Windows.Forms.BindingSource billholdBindingSource;
        private pharmacy_managment_systemDataSet5 pharmacy_managment_systemDataSet5;
        private pharmacy_managment_systemDataSet5TableAdapters.BillholdTableAdapter billholdTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource bilinginfoBindingSource;
        private pharmacy_managment_systemDataSet6 pharmacy_managment_systemDataSet6;
        private pharmacy_managment_systemDataSet6TableAdapters.BilinginfoTableAdapter bilinginfoTableAdapter;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCalculatePrice;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btntotalPrice;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteFromChart;
    }
}
