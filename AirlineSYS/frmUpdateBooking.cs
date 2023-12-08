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
    public partial class frmUpdateBooking : Form
    {
        frmAirlineMainMenu parent;
        public frmUpdateBooking()
        {
            InitializeComponent();
        }
        public frmUpdateBooking(frmAirlineMainMenu parent)
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


        private void btnBookingIDSearch_Click(object sender, EventArgs e)
        {
            if (txtBookingID.Text.Length == 6 && (txtBookingID.Text != "ABC123" && txtBookingID.Text != "XYZ789" &&
                txtBookingID.Text != "456DEF" && txtBookingID.Text != "GHI321"))
            {
                MessageBox.Show("Flight number does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                txtBookingID.Clear();
                return;
            }
            else if (txtBookingID.Text.Length != 6)
            {
                MessageBox.Show("Booking ID must be 6 characters long", "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                txtBookingID.Clear();
                return;
            }

        }

        private void btnBookingIDSearch_Click(object sender, EventArgs e)
        {
            if (txtBookingID.Text.Length == 6 && (txtBookingID.Text != "ABC123" && txtBookingID.Text != "XYZ789" &&
                txtBookingID.Text != "456DEF" && txtBookingID.Text != "GHI321"))
            {
                MessageBox.Show("Flight number does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                txtBookingID.Clear();
                return;
            }
            else if (txtBookingID.Text.Length != 6)
            {
                MessageBox.Show("Booking ID must be 6 characters long", "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                txtBookingID.Clear();
                return;
            }
            else
            {
                grpCreateBookingDetails.Visible = true;

                if (txtBookingID.Text.Equals("ABC123"))
                {
                    cboDeptAirportBooking.Text = "JFK - New York";
                    cboArrAirportBooking.Text = "LAX - Los Angeles";
                    dtpDeptDate.Text = "09-12-2024";
                    dtpReturnDate.Text = "15-12-2023";
                    txtNumBaggage.Text = "3";
                    txtForeName.Text = "Maria";
                    txtSurname.Text = "Rossy";
                    txtCreateBooingPhone.Text = "0";
                }


                /**
                 * JFK - New York
LAX - Los Angeles
ORD - Chicago
DFW Dallas**/
                else if (txtBookingID.Text.Equals("XYZ789"))
                {
                    cboDeptAirportFlight.Text = "PEK";
                    cboArrAirportFlight.Text = "NRT";
                    cboOperatorCodeFlight.Text = "JL - Japan Airlines";
                    txtNumFlightSeats.Text = "200";
                    dtpDeptFlight.Text = "09-01-2025";
                    cboDeptTime.Text = "08:00 AM";
                    txtTicketPriceFlight.Text = "990.20";
                }

                else if (txtBookingID.Text.Equals("456DEF"))
                {
                    cboDeptAirportFlight.Text = "DXB";
                    cboArrAirportFlight.Text = "DUB";
                    cboOperatorCodeFlight.Text = "EK - Emirate";
                    txtNumFlightSeats.Text = "300.98";
                    dtpDeptFlight.Text = "07-05-2055";
                    cboDeptTime.Text = "07:00 AM";
                    txtTicketPriceFlight.Text = "1240.00";
                }

                else if (txtBookingID.Text.Equals("GHI321"))
                {
                    cboDeptAirportFlight.Text = "CDG";
                    cboArrAirportFlight.Text = "SNN";
                    cboOperatorCodeFlight.Text = "FR - Ryanair";
                    txtNumFlightSeats.Text = "580.67";
                    dtpDeptFlight.Text = "19-06-2030";
                    cboDeptTime.Text = "18:00 PM";
                    txtTicketPriceFlight.Text = "790.00";
                }
            }

        }








            private void btnUpadateBookingConfirm_Click(object sender, EventArgs e)
        {

        }
    }
}
