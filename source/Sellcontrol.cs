using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Collections;
using System.Data.SqlClient;
using System.Diagnostics;

namespace finalProject_pharmacy_managment_system_
{
    public partial class Sellcontrol : UserControl
    {
        DataAccess Da
        {
            get;
            set;
        }
        double totalPrice = 0;

        public Sellcontrol()
        {
            InitializeComponent();
            this.Da = new DataAccess();

        }
        private void PopulateGridView(string sql = "select* from Product;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvproduct.AutoGenerateColumns = false;
            this.dgvproduct.DataSource = ds.Tables[0];
        }
        private void PopulateGridViewfForBillinginfo(string sql = "select* from Bilinginfo;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBilinginfo.AutoGenerateColumns = false;
            this.dgvBilinginfo.DataSource = ds.Tables[0];
        }
        private void btnshow_Click(object sender, EventArgs e)
        {
            string name = this.txtSearchByName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                this.PopulateGridView();
            }
            else
            {
                string query = $"SELECT * FROM Product WHERE Name LIKE '%{name}%';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Sorry, this product is not available here.");
                    return;
                }

                this.dgvproduct.DataSource = ds.Tables[0];
            }
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrWhiteSpace(this.txtProductName.Text) ||
                string.IsNullOrWhiteSpace(this.txtPrice.Text) ||
                string.IsNullOrWhiteSpace(this.txtQuantity.Text))
            {
                return false;
            }
            return true;
        }
        private bool IsValidToSaveCustomer()
        {
            if (string.IsNullOrWhiteSpace(this.txtCustomerName.Text) ||
                string.IsNullOrWhiteSpace(this.txtPhone.Text) ||
                string.IsNullOrWhiteSpace(this.txtPrice.Text))
            {
                return false;
            }
            return true;
        }




        private void Sellcontrol_Load(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void dgvproduct_DoubleClick(object sender, EventArgs e)
        {
            //this.txtName.Text = this.dgvproduct.CurrentRow.Cells[0].Value.ToString();
            this.txtProductName.Text = this.dgvproduct.CurrentRow.Cells[0].Value.ToString();
            this.txtQuantity.Text = this.dgvproduct.CurrentRow.Cells[2].Value.ToString();

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // int x= Convert.ToInt32(this.txtQuantity.Text);

            try
            {
                int currentQuantity = 0;
                if (!string.IsNullOrWhiteSpace(this.txtQuantity.Text))
                    currentQuantity = Convert.ToInt32(this.txtQuantity.Text);

                currentQuantity++;

                string productName = this.txtProductName.Text;

                string query = $"SELECT Quantity FROM Product WHERE Name = '{productName}'";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Product not found in database.");
                    return;
                }

                int stockQuantity = Convert.ToInt32(ds.Tables[0].Rows[0]["Quantity"]);

                if (currentQuantity > stockQuantity)
                {
                    MessageBox.Show($" Sorry, only {stockQuantity} items available in stock.", "Stock Limit", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                this.txtQuantity.Text = currentQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please enter a valid number in Quantity.\n\nError: " + ex.Message);
            }
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = Convert.ToInt32(this.txtQuantity.Text);

                if (quantity <= 0)
                {
                    MessageBox.Show("Quantity cannot be less than 0.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                quantity = quantity - 1;
                this.txtQuantity.Text = quantity.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter a valid number for quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }








        private void txtTotalprice_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            try
            {
                
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }

                
                string productName = this.txtProductName.Text;
                int quantity = Convert.ToInt32(this.txtQuantity.Text);
                double price = Convert.ToDouble(this.txtPrice.Text);

                var query = "SELECT * FROM Bilinginfo WHERE ProductName = '" + productName + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // UPDATE existing product
                    var sql = @"
                UPDATE Bilinginfo
                SET Quantity = " + quantity + @",
                    Price = " + price + @"
                WHERE ProductName = '" + productName + "';";

                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been updated in the list");
                    else
                        MessageBox.Show("Data hasn't been updated in the list");
                }
                else
                {
                    if(quantity<0)
                    {
                        MessageBox.Show("Quantity not be negative ");
                        return;
                    }
                  
                    var sql = "INSERT INTO Bilinginfo VALUES('" + productName + "', " + quantity + ", " + price + ");";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Data has been added in the list");
                    else
                        MessageBox.Show("Data hasn't been added in the list");
                }
                this.txtProductName.Text = "";
                this.txtQuantity.Text = "";
                this.txtPrice.Text = "";
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error has occurred in the system, please try again.\n" + exc.Message);
            }

      
            this.PopulateGridViewfForBillinginfo();
        }
        
        private void btnBill_Click(object sender, EventArgs e)
        {
            try
            {
                var ds = this.Da.ExecuteQuery("SELECT ProductName, Quantity FROM Bilinginfo");

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string prod = row[0].ToString();
                    int qty = Convert.ToInt32(row[1]);

                
                    string checkStockSql = "SELECT Quantity FROM Product WHERE Name = @ProductName;";
                    var dt = this.Da.ExecuteQueryTable(checkStockSql, new SqlParameter("@ProductName", prod));

                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show($"Product '{prod}' not found in the Product table.", "Product Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int currentStock = Convert.ToInt32(dt.Rows[0]["Quantity"]);

                 
                    if (qty <= 0)
                    {
                        MessageBox.Show($"Quantity for '{prod}' must be greater than zero.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if (qty > currentStock)
                    {
                        MessageBox.Show($"'{prod}' is out of stock or requested quantity is too high.\nAvailable: {currentStock}, Requested: {qty}\n\nPlease check the stock and confirm your shopping again.",
                            "Stock Issue", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string sql = @"
                UPDATE Product
                SET Quantity = Quantity - @Qty
                WHERE Name = @ProductName;";

                    this.Da.ExecuteDMLQuery(sql,
                        new SqlParameter("@Qty", qty),
                        new SqlParameter("@ProductName", prod)
                    );
                }

                // Step 4: Save Customer Info
                if (!IsValidToSaveCustomer())
                {
                    MessageBox.Show("Please fill the Customer Name and Phone.", "Customer Info Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string customerName = this.txtCustomerName.Text;
                string phone = this.txtPhone.Text;
                string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                double totalPrice = Convert.ToDouble(this.txtTotalPrice.Text);

                string insertCustomerSql = @"
            INSERT INTO Billhold (CustomerName, Phone, Date, Bill)
            VALUES (@CustomerName, @Phone, @Date, @Bill);";

                int flag = this.Da.ExecuteDMLQuery(insertCustomerSql,
                    new SqlParameter("@CustomerName", customerName),
                    new SqlParameter("@Phone", phone),
                    new SqlParameter("@Date", date),
                    new SqlParameter("@Bill", totalPrice)
                );

                if (flag == 1)
                    MessageBox.Show("Customer information has been saved successfully.");
                else
                    MessageBox.Show("Failed to save customer information.");

                // Step 5: Confirm Shopping
                var result = MessageBox.Show("Are you sure to confirm the shopping?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                    return;

                // Step 6: Delete Billing Info
                string sqlDelete = "DELETE FROM BilingInfo;";
                int count = this.Da.ExecuteDMLQuery(sqlDelete);

                if (count > 0)
                    MessageBox.Show("All shopping completed successfully.");
                else
                    MessageBox.Show("No items were found to delete from billing list.");

                // Step 7: Cleanup
                this.txtTotalPrice.Text = "";
                this.PopulateGridViewfForBillinginfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }



        private void Sellcontrol_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dgvBilinginfo_DoubleClick(object sender, EventArgs e)
        {

            this.txtProductName.Text = this.dgvBilinginfo.CurrentRow.Cells[0].Value.ToString();
            this.txtPrice.Text = this.dgvBilinginfo.CurrentRow.Cells[2].Value.ToString();
            this.txtQuantity.Text = this.dgvBilinginfo.CurrentRow.Cells[1].Value.ToString();
        }

        private void dgvBilinginfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }


        private void btnCalculatePrice_Click(object sender, EventArgs e)
        {
            this.txtPrice.Text = Calculateprice().ToString();
        }
        private double Calculateprice()
        {
            try
            {
                string name = this.txtProductName.Text;
                int quantity = Convert.ToInt32(this.txtQuantity.Text);
                if(quantity<0)
                {
                    MessageBox.Show("please check the quantity!");
                }

                string sql = "SELECT Price FROM Product WHERE Name = '" + name + "';";

                DataTable dt = this.Da.ExecuteQueryTable(sql); 

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Product not found!");
                    return 0;
                }

                double price = Convert.ToDouble(dt.Rows[0]["Price"]);
                return price * quantity;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btntotalPrice_Click(object sender, EventArgs e)
        {
            try
            {
                // Step 1: SQL query to calculate sum of Price column
                string sql = "SELECT SUM(Price) AS TotalPrice FROM Bilinginfo;";

                // Step 2: Execute the query and get result in DataTable
                DataTable dt = this.Da.ExecuteQueryTable(sql);

                // Step 3: Check if result is valid and not null
                if (dt.Rows.Count > 0 && dt.Rows[0]["TotalPrice"] != DBNull.Value)
                {
                    double total = Convert.ToDouble(dt.Rows[0]["TotalPrice"]);
                    this.txtTotalPrice.Text = total.ToString("0.00"); // 2 decimal format
                }
                else
                {
                    this.txtTotalPrice.Text = "0.00"; // fallback if no data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error calculating total price:\n" + ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            //new Manager().Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

      
            private void btnDeleteFromChart_Click(object sender, EventArgs e)
        {
            try
            {
                string productName = this.txtProductName.Text.Trim();

                if (string.IsNullOrWhiteSpace(productName))
                {
                    MessageBox.Show("Please enter the product name to delete from the chart.", "Input Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string sql = $"DELETE FROM Bilinginfo WHERE ProductName = '{productName}'";
                int count = this.Da.ExecuteDMLQuery(sql);

                if (count > 0)
                {
                    MessageBox.Show("Product has been removed from the chart successfully.");
                }
                else
                {
                    MessageBox.Show("No matching product found in the chart.");
                }

                this.PopulateGridViewfForBillinginfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting from chart: " + ex.Message);
            }
        }


    }
}


