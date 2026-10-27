using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject_pharmacy_managment_system_
{
    public partial class Admin: Form
    {
        //public static string LoggedInUserId;
        public loginform Fl
        {
            get;
            set;
        }
        public string Idhold
        {
            get;
            set;
        }

        public Admin()
        {
            InitializeComponent();
           
        }
        public Admin(string name,string idhold, loginform fl):this()
        {
            this.lblAdmin.Text += name.ToUpper();
            this.Fl = fl;
            this.Idhold = idhold;
            
        }

        private void btnUserhanle_Click(object sender, EventArgs e)
        {
            UserHandle us = new UserHandle(Idhold);
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(us);

        }

        private void pnlDasboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnProductHandle_Click(object sender, EventArgs e)
        {
            ProductHandle ph = new ProductHandle();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(ph);

        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new loginform().Visible = true;
        }

        private void btnSellinginfo_Click(object sender, EventArgs e)
        {
            Sellinginfo sl = new Sellinginfo();
            this.panel1.Controls.Clear();
            this.panel1.Controls.Add(sl);
            

        }
    }
}
