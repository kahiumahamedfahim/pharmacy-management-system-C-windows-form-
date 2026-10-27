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
    public partial class Sellinginfo: UserControl
    {
        DataAccess Da
        {
            get;
            set;
        }
        public Sellinginfo()
        {
            InitializeComponent();
            this.Da = new DataAccess();
        }
        private void PopulateGridView(string sql = "select* from Billhold;")
        {
            var ds = this.Da.ExecuteQuery(sql);

            this.dgvBilingHold.AutoGenerateColumns = false;
            this.dgvBilingHold.DataSource = ds.Tables[0];
        }

        private void Sellinginfo_Load(object sender, EventArgs e)
        {
            this.PopulateGridView();
        }
    }
}
