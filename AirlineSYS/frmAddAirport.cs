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
    public partial class frmAddAirport : Form
    {
        frmAirlineMainMenu parent;
        public frmAddAirport()
        {
            InitializeComponent();
        }
        public frmAddAirport(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            /*if (txtAirportStreet.Text.Equals("") && txtAirportName.Text.Equals("") && txtAirportCode.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCode.Focus();
                return;
            }

            if (int.txtAirportCity.Text)
            {

            }
            */
            if (txtAirportCode.Text.Length != 3 && !txtAirportCode.Text.All(char.IsLetter))
            {
                MessageBox.Show("Please enter a valid three-letter airport code.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCode.Focus();
                return;

            }


        }

        private void frmAddAirport_Load(object sender, EventArgs e)
        {

        }

        private void txtAirportCode_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
