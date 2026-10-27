using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace finalProject_pharmacy_managment_system_
{
    public partial class Manager: Form
    {
        public Manager()
        {
            InitializeComponent();
        }
        public loginform Fl
        {
            get;
            set;
        }
        public Manager(string name , loginform fl) : this()
        {
            
            this.Fl = fl;
            this.lblManager.Text += name.ToUpper();
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Sellcontrol sc = new Sellcontrol();
            this.pnlManagerSell.Controls.Clear();
            this.pnlManagerSell.Controls.Add(sc);

        }

        private void pnlDasboard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new loginform().Visible = true;
        }
    }
}
