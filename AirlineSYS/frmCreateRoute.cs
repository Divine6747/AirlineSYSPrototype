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
    public partial class frmCreateRoute : Form
    {
        frmAirlineMainMenu parent;
        public frmCreateRoute()
        {
            InitializeComponent();
        }
        public frmCreateRoute(frmAirlineMainMenu parent)
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

        private void grpOperatorDetails_Enter(object sender, EventArgs e)
        {

        }

        private void lblOperatorPhone_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateRouteConfirm_Click(object sender, EventArgs e)
        {
            if (txtDurationRoute.Text.Equals("") || cboArrAirportCreteRoute.Text.Equals("") || cboDeptAirportCreteRoute.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboDeptAirportCreteRoute.Focus();
                return;
            }
            else if (cboArrAirportCreteRoute.Text.Equals(cboDeptAirportCreteRoute.Text) || cboDeptAirportCreteRoute.Text.Equals(cboArrAirportCreteRoute.Text))
            {
                MessageBox.Show("Departure or Arrival Airports can not be the same", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboArrAirportCreteRoute.SelectedIndex = -1;
                cboDeptAirportCreteRoute.SelectedIndex = -1;
                return;
            }
            else if (!txtDurationRoute.Text.All(char.IsDigit))
            {
                MessageBox.Show("Route Duration must be NUMERIC", "Error !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtDurationRoute.Clear();
            }
            else
            {
                MessageBox.Show("Airport has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtDurationRoute.Clear();
                cboArrAirportCreteRoute.SelectedIndex = -1;
                cboDeptAirportCreteRoute.SelectedIndex = -1;
            }
        }
    }
}
