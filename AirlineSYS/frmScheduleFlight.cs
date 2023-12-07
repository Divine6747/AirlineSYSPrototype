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
    public partial class frmScheduleFlight : Form
    {
        frmAirlineMainMenu parent;
        public frmScheduleFlight()
        {
            InitializeComponent();
        }
        public frmScheduleFlight(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmScheduleFlight_Load(object sender, EventArgs e)
        {

        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void lblOperatorCode_Click(object sender, EventArgs e)
        {

        }

        private void lblAirportPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblAirportEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtAirportEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpAirportDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblAddAirport_Click(object sender, EventArgs e)
        {

        }

        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {
            if (cboDeptAirportFlight.Text.Equals("") || cboArrAirportFlight.Text.Equals("") || txtOperatorCode.Text.Equals("") ||
                txtNumFlightSeats.Text.Equals("") ||
                txtTicketPriceFlight.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDeptAirportFlight.Focus();

                return;
            }
            else if (dtpDeptFlight.Value <= DateTime.Now)
            {
                MessageBox.Show("Date picked must be greater than current date", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDeptFlight.Focus();
            }

            else if (dtpDeptTimeFlight.Value <= DateTime.Now)
            {
                MessageBox.Show("Time picked must be greater than current time", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDeptFlight.Focus();
            }
        }
    }
}
