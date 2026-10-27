using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Runtime.CompilerServices;

namespace finalProject_pharmacy_managment_system_
{
    public partial class UserHandle : UserControl

    {
        public DataAccess Da { get; set; }
        public string Idhold
        {
            get;
            set;
        }

        public UserHandle(string idhold)
        {
            InitializeComponent();
            this.Da = new DataAccess();
            this.Idhold = idhold;

            //this.PopulateGridView();

        }
        private void PopulateGridView(string sql )
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvuserinfo.AutoGenerateColumns = false;
            this.dgvuserinfo.DataSource = ds.Tables[0];
        }

        private void UserHandle_Load(object sender, EventArgs e)
        {

        }
        private void ClearAll()
        {
            this.txtname.Clear();
            this.txtphone.Clear();
            this.txtemail.Clear();
            this.txtaddress.Clear();
            this.txtuserid.Clear();
            this.txtpassword.Clear();

            this.rdbAdmin.Checked = false;
            this.rdbManager.Checked = false;

            this.dgvuserinfo.ClearSelection();
        }


        private void btnshowall_Click(object sender, EventArgs e)

        {
            string sql = "select*from userinfo";
            this.PopulateGridView(sql);
        }
        private bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(this.txtname.Text) ||
                string.IsNullOrEmpty(this.txtphone.Text) ||
                string.IsNullOrEmpty(this.txtemail.Text) ||
                string.IsNullOrEmpty(this.txtaddress.Text) ||
                string.IsNullOrEmpty(this.txtuserid.Text) ||
                string.IsNullOrEmpty(this.txtpassword.Text) ||
                (!this.rdbAdmin.Checked && !this.rdbManager.Checked))

            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void dgvuserinfo_DoubleClick(object sender, EventArgs e)
        {
            this.txtname.Text = this.dgvuserinfo.CurrentRow.Cells[0].Value.ToString();
            this.txtphone.Text = this.dgvuserinfo.CurrentRow.Cells[1].Value.ToString();
            this.txtemail.Text = this.dgvuserinfo.CurrentRow.Cells[2].Value.ToString();
            this.txtaddress.Text = this.dgvuserinfo.CurrentRow.Cells[3].Value.ToString();
            this.txtuserid.Text = this.dgvuserinfo.CurrentRow.Cells[4].Value.ToString();
            this.txtpassword.Text = this.dgvuserinfo.CurrentRow.Cells[5].Value.ToString();
            string role = this.dgvuserinfo.CurrentRow.Cells[6].Value.ToString();
            if (role == "Admin")
            {
                this.rdbAdmin.Checked = true;
            }
            else
            {
                this.rdbManager.Checked = true;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.ClearAll();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvuserinfo.SelectedRows.Count < 1)
                {
                    MessageBox.Show("Please select a row first to delete.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                var userid = this.dgvuserinfo.CurrentRow.Cells[4].Value.ToString();
                var name = this.dgvuserinfo.CurrentRow.Cells[0].Value.ToString();
                if(userid==Idhold)
                {
                    MessageBox.Show("You can not Delete yourself !");
                    return;
                }

                //var result = MessageBox.Show("Are you sure to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                var result = MessageBox.Show("Are you sure to delete this user?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (result == DialogResult.No)
                {
                    return;
                }

                var sql = "delete from userinfo where userid = '" + userid + "';";
                var count = this.Da.ExecuteDMLQuery(sql);

                if (count == 1)
                    MessageBox.Show(name.ToUpper() + " has been deleted from user list");
                else
                    MessageBox.Show("User hasn't been deleted");

                this.PopulateGridView("select*from userinfo");
                this.ClearAll();
            }
            catch (Exception exc)
            {
                MessageBox.Show("An error occurred while trying to delete.\n" + exc.Message);
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            {
                try
                {
                    if (!this.IsValidToSave())
                    {
                        MessageBox.Show("Please fill all the empty fields");
                        return;
                    }

                    string role = this.rdbAdmin.Checked ? "Admin" : "Manager";

                    var query = "select * from userinfo where userid = '" + this.txtuserid.Text + "';";
                    var ds = this.Da.ExecuteQuery(query);

                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        
                        MessageBox.Show("this user is already listed you can update only !");
                    }
                    else
                    {
                        
                        string name = this.txtname.Text;
                        string phone = this.txtphone.Text;
                        string email = this.txtemail.Text;
                        string address = this.txtaddress.Text;
                        string userid = this.txtuserid.Text;
                        string password = this.txtpassword.Text;
                        string rl;
                        if(this.rdbAdmin.Checked==true)
                        {
                             rl = "Admin";
                        }
                        else
                        {
                            rl = "Manager";
                        }
                        string sql = @"insert into userinfo 
(Name, Phone, Email, Adress, UserId, Password, Role)
values('" + name + "', '" + phone + "', '" + email + "', '" + address + "', '" + userid + "', '" + password + "', '" + rl + "');";

                        var count = this.Da.ExecuteDMLQuery(sql);

                        if (count == 1)
                        {
                            MessageBox.Show("User has been added");
                            this.ClearAll();
                        }
                        else
                            MessageBox.Show("Insert failed");
                    }

                    this.PopulateGridView("select * from userinfo");
                    //this.ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!this.IsValidToSave())
                {
                    MessageBox.Show("Please fill all the empty fields");
                    return;
                }
                string role = this.rdbAdmin.Checked ? "Admin" : "Manager";

                var query = "select * from userinfo where userid = '" + this.txtuserid.Text + "';";
                var ds = this.Da.ExecuteQuery(query);

                if (ds.Tables[0].Rows.Count == 1)
                {
                    // update
                    var sql = @"update userinfo
                        set Name = '" + this.txtname.Text + @"',
                        Phone = '" + this.txtphone.Text + @"',
                        Email = '" + this.txtemail.Text + @"',
                        Adress = '" + this.txtaddress.Text + @"',
                        Password = '" + this.txtpassword.Text + @"',
                        role = '" + role + @"'
                        where userid = '" + this.txtuserid.Text + "';";
                    var count = this.Da.ExecuteDMLQuery(sql);

                    if (count == 1)
                        MessageBox.Show("User data has been updated");
                    else
                        MessageBox.Show("Update failed");
                }
            }
            catch
            {
                MessageBox.Show("something is wrong!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Button is Clicked");
            string sql = "SELECT * FROM UserInfo WHERE Name = '" + this.txtsearch.Text + "';";
            this.PopulateGridView(sql);

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;

            //new Admin().Visible = true;
        }
    }
}
