using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject_pharmacy_managment_system_
{
    public partial class loginform: Form
    {
        public  string loginid;
       public  DataAccess da
        {
            get;
            set;
        }
        public loginform()
        { 
            this.da=new DataAccess();
        
            InitializeComponent();
        }

        private void loginform_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (this.txtuserid.Text == "" || this.txtpassword.Text == "")
            { 
                MessageBox.Show("please fill up userid & password");

            }
            string sql = "select * from UserInfo where UserId = '"+this.txtuserid.Text+ "' and Password = '"+this.txtpassword.Text+"' ;";
           
            DataSet ds = da.ExecuteQuery(sql);
            if (ds.Tables[0].Rows.Count==1)
            {
                var name = ds.Tables[0].Rows[0]["Name"].ToString();
                MessageBox.Show("Valid User ");
                loginid = this.txtuserid.Text;
                this.Visible = false;

                if (ds.Tables[0].Rows[0]["Role"].ToString().Equals("Admin"))
                {
                    new Admin(name, loginid,this).Visible = true;

                }
                else if (ds.Tables[0].Rows[0]["Role"].ToString().Equals("Manager"))
                {
                    new Manager(name, this).Visible = true;
                }

            }
            else
            {
                MessageBox.Show("Invalid User !");
            }

            //sqlcon.Close();







            // MessageBox.Show("Buttion cliciked");
        }

        private void lblReset_Click(object sender, EventArgs e)
        {
            this.txtpassword.Clear();
            this.txtuserid.Clear();

        }

        private void btnExiit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
