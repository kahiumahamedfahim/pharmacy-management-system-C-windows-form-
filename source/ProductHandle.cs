using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject_pharmacy_managment_system_
{
    public partial class ProductHandle : UserControl
    {
        public DataAccess Da { get; set; }
        public string Idhold
        {
            get;
            set;
        }
        public ProductHandle()
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

        private void ProductHandle_Load(object sender, EventArgs e)
        {

        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvproduct_DoubleClick(object sender, EventArgs e)
        {
            this.txtName.Text = this.dgvproduct.CurrentRow.Cells[0].Value.ToString();
            this.txtCompanyName.Text = this.dgvproduct.CurrentRow.Cells[1].Value.ToString();
            this.txtQuantity.Text = this.dgvproduct.CurrentRow.Cells[2].Value.ToString();
            this.txtPrice.Text = this.dgvproduct.CurrentRow.Cells[3].Value.ToString();


        }

        private void btnQuantityPlus_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(this.txtQuantity.Text);
            quantity = quantity + 1;
            this.txtQuantity.Text = quantity.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int quantity = Convert.ToInt32(this.txtQuantity.Text);
            if (quantity <= 0)
            {
                MessageBox.Show(
                     "Sorry, the quantity cannot go below zero.\nPlease enter a valid non‑negative number.",
                     "Warning: Invalid Operation",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);
                quantity = 0;
                this.txtQuantity.Text = quantity.ToString();


            }
            else
            {
                quantity = quantity - 1;
                this.txtQuantity.Text = quantity.ToString();
            }

        }
        private bool IsValid()
        {
            if (string.IsNullOrEmpty(this.txtName.Text) ||
                string.IsNullOrEmpty(this.txtCompanyName.Text) ||
                string.IsNullOrEmpty(this.txtQuantity.Text) ||
                string.IsNullOrEmpty(this.txtPrice.Text))
                return false;
            else
                return true;
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValid())
                {
                    MessageBox.Show("Please fill all the empty fields.");
                    return;
                }

                // Optional: Quantity & Price validation
                int quantity = Convert.ToInt32(this.txtQuantity.Text);
                if (quantity < 0)
                {
                    MessageBox.Show("Quantity can't be negative.");
                    return;
                }

                double price = Convert.ToDouble(this.txtPrice.Text);
                if (price < 0)
                {
                    MessageBox.Show("Price can't be negative.");
                    return;
                }

                string productName = this.txtName.Text;

                var query = "SELECT * FROM Product WHERE Name = '" + productName + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // Product exists → update
                    var sql = @"UPDATE Product
                        SET 
                            CompanyName = '" + this.txtCompanyName.Text + @"',
                            Quantity = " + quantity + @",
                            Price = " + price + @"
                        WHERE Name = '" + productName + "';";
                    int count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("Product data has been updated.");
                    else
                        MessageBox.Show("Update failed.");
                }
                else
                {
                    MessageBox.Show("Product not found! Please insert it using the Insert button.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong!\n" + ex.Message);
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvproduct.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                string currentName = this.dgvproduct.CurrentRow.Cells[0].Value.ToString();

                        string sql = @"
                    DELETE FROM Product
                WHERE Name = '" + currentName + @"';
                        ";

                int count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show("Product deleted successfully.");
                else
                    MessageBox.Show("Delete failed.");

                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValid())
                {
                    MessageBox.Show("Please fill all the required fields.");
                    return;
                }

                string name = this.txtName.Text;
                string company = this.txtCompanyName.Text;
                int quantity = Convert.ToInt32(this.txtQuantity.Text);
                if(quantity<0)
                {
                    MessageBox.Show("Quentity cant be a negative Number !");
                    return;
                }
                double price = Convert.ToDouble(this.txtPrice.Text);

                string checkQuery = "SELECT * FROM Product WHERE Name = '" + name + "';";
                DataSet ds = this.Da.ExecuteQuery(checkQuery);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("This product already exists. You can update it.");
                    return;
                }

                string insertQuery = @"
                INSERT INTO Product (Name, CompanyName, Quantity, Price)
                VALUES ('" + name + "', '" + company + "', " + quantity + ", " + price + ");";

                int count = this.Da.ExecuteDMLQuery(insertQuery);

                if (count == 1)
                    MessageBox.Show("Product inserted successfully.");
                else
                    MessageBox.Show("Insert failed.");

                this.PopulateGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtCompanyName.Text = "";
            this.txtName.Text = "";
            this.txtQuantity.Text = "";
            this.txtPrice.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string name = this.txtSearch.Text.Trim();

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a product name to search.");
                    return;
                }

                string sql = "SELECT * FROM Product WHERE Name LIKE '%" + name + "%';";
                var ds = this.Da.ExecuteQuery(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    this.dgvproduct.DataSource = ds.Tables[0];
                }
                else
                {
                    MessageBox.Show("No product found with that name.");
                    this.dgvproduct.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while searching:\n" + ex.Message);
            }
        }

    }
}
