using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineSYS
{
    
    public partial class frmAddOperator : Form
    {
        public frmAddOperator()
        {
            InitializeComponent();
        }

        private void mnuAddOperator_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAddOperator_Load(object sender, EventArgs e)
        {

        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void txtOperatorStreet_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOperatorCountry_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
