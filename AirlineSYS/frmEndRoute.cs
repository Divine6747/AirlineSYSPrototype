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
    public partial class frmEndRoute : Form
    {
        frmAirlineMainMenu parent;
        public frmEndRoute()
        {
            InitializeComponent();
        }
        public frmEndRoute(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmEndRoute_Load(object sender, EventArgs e)
        {

        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }


        private void btnRouteSearch_Click(object sender, EventArgs e)
        {
            grpEndRouteDetails.Visible = true;
            lblEndRouteDetails.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            

            if (cboEndRoute.SelectedIndex == 0)
            {
                lblEndRouteDetails.Text = "Departure Airport: Dublin Aiport" +
                    "\n\nArrival Airport: Shanghai Airport" +
                    "\n\nDuration: 60 mins" +
                    "\n\nDeparture Airport Email: dublin.airport@airport.ie" +
                    "\n\nArrival Airport Email: shanghai.airport@airport.ie";

            }

            else if (cboEndRoute.SelectedIndex == 1)
            {
                lblEndRouteDetails.Text = "Departure Airport: New York Aiport" +
                    "\n\nArrival Airport: Shanghai Airport" +
                    "\n\nDuration: 60 mins" +
                    "\n\nDeparture Airport Email: newyork.airport@airport.ie" +
                    "\n\nArrival Airport Email: shanghai.airport@airport.ie";

            }

            else if (cboEndRoute.SelectedIndex == 2)
            {
                lblEndRouteDetails.Text = "Departure Airport: Shanghai Aiport" +
                     "\n\nArrival Airport: Beijing Airport" +
                     "\n\nDuration: 60 mins" +
                     "\n\nDeparture Airport Email: shanghai.airport@airport.ie" +
                     "\n\nArrival Airport Email: beijing.airport@airport.ie";

            }

            else if (cboEndRoute.SelectedIndex == 3)
            {
                lblEndRouteDetails.Text = "Departure Airport: Shannon Aiport" +
                    "\n\nArrival Airport: Rome Airport" +
                    "\n\nDuration: 60 mins" +
                    "\n\nDeparture Airport Email: shannon.airport@airport.ie" +
                    "\n\nArrival Airport Email: rome.airport@airport.ie";

            }

            else if (cboEndRoute.SelectedIndex == 4)
            {
                lblEndRouteDetails.Text = "Departure Airport: Dublin Aiport" +
                    "\n\nArrival Airport: Millan Airport" +
                    "\n\nDuration: 60 mins" +
                    "\n\nDeparture Airport Email: dublin.airport@airport.ie" +
                    "\n\nArrival Airport Email: millan.airport@airport.ie";

            }
            

        }


        private void btnEndRouteConfirm_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the route?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Route has been Ended",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                grpEndRouteDetails.Visible = false;
                cboEndRoute.Text = "";
            }
            else
            {
                MessageBox.Show("Route has not been ended",
                                "End not Ended!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                grpEndRouteDetails.Visible = false;
                cboEndRoute.Text = "";
            }

        }


    }
}
