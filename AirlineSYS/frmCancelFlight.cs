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
    public partial class frmCancelFlight : Form
    {
        frmAirlineMainMenu parent;
        public frmCancelFlight()
        {

            InitializeComponent();
        }
        public frmCancelFlight(frmAirlineMainMenu parent)
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

        private void grpCancelFlightDetails_Enter(object sender, EventArgs e)
        {

        }



        private void btnFlightSearch_Click(object sender, EventArgs e)
        {

            if (txtCancelFlightNumber.Text.Length == 6 && (txtCancelFlightNumber.Text != "AA4732" && txtCancelFlightNumber.Text != "JL8915" &&
                txtCancelFlightNumber.Text != "EK2468" && txtCancelFlightNumber.Text != "BA5739"))
            {
                MessageBox.Show("Flight number does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCancelFlightNumber.Focus();
                txtCancelFlightNumber.Clear();
                return;
            }
            else if (txtCancelFlightNumber.Text.Length != 6)
            {
                MessageBox.Show("Flight Number must be 6 characters long", "Errors!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCancelFlightNumber.Focus();
                txtCancelFlightNumber.Clear();
                return;
            }

            else
            {
                grpCancelFlightDetails.Visible = true;
                lblCancelFlightDetails.Font = new Font("Segoe UI", 12, FontStyle.Regular);

                if (txtCancelFlightNumber.Text.Equals("AA4732"))
                {
                    lblCancelFlightDetails.Text =

                        "Departure Airport : John F. Kennedy International Airport." +
                        "\n\nArrival Airport : Shannon Airport" +
                        "\n\nOperator Code : AA - American Airlines" +
                        "\n\nNumber of seats on Flight : 150 seats" +
                        "\n\nDeparture Date : 09-12-2035" +
                        "\n\nDeparture Time : 18:00 PM" +
                        "\n\nTicktet Price : €740.00";

                }

                else if (txtCancelFlightNumber.Text.Equals("JL8915"))
                {
                    lblCancelFlightDetails.Text =

                        "Departure Airport : John F. Kennedy International Airport." +
                        "\n\nArrival Airport : Shannon Airport" +
                        "\n\nOperator Code : AA - American Airlines" +
                        "\n\nNumber of seats on Flight : 150 seats" +
                        "\n\nDeparture Date : 09-12-2035" +
                        "\n\nDeparture Time : 18:00 PM" +
                        "\n\nTicktet Price : €740.00";

                }

                else if (txtCancelFlightNumber.Text.Equals("EK2468"))
                {
                    lblCancelFlightDetails.Text =

                        "Departure Airport :     John F. Kennedy International Airport." +
                        "\n\nArrival Airport :   Shannon Airport" +
                        "\n\nOperator Code:      AA - American Airlines" +
                        "\n\nNumber of seats on Flight :     150 seats" +
                        "\n\nDeparture Date :    09-12-2035" +
                        "\n\nDeparture Time :    18:00 PM" +
                        "\n\nTicktet Price :     €740.00";

                }

                else if (txtCancelFlightNumber.Text.Equals("FR5739"))
                {
                    lblCancelFlightDetails.Text =

                        "Departure Airport : John F. Kennedy International Airport." +
                        "\n\nArrival Airport : Shannon Airport" +
                        "\n\nOperator Code : AA - American Airlines" +
                        "\n\nNumber of seats on Flight : 150 seats" +
                        "\n\nDeparture Date : 09-12-2035" +
                        "\n\nDeparture Time : 18:00 PM" +
                        "\n\nTicktet Price : €740.00";

                }

            }
        }
        private void btnAirportConfirm_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to cancel the flight?",
                                                  "Confirmation",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Flight has been Cancelled",
                                "Success!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                grpCancelFlightDetails.Visible = false;
                txtCancelFlightNumber.Text = "";
            }
            else
            {
                MessageBox.Show("Flight has been Cancelled",
                                "Flight not Cancelled!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                grpCancelFlightDetails.Visible = false;
                txtCancelFlightNumber.Text = "";
            }

        }
    }
}
