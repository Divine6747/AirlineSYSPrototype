using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
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
            if (txtAirportCode.Text.Equals("") || txtAirportName.Text.Equals("") || txtAirportStreet.Text.Equals("") || 
                txtAirportCity.Text.Equals("") || txtAirportCountry.Text.Equals("") || txtAirportEircode.Text.Equals("") || 
                txtAirportPhone.Text.Equals("") || txtAirportEmail.Text.Equals(""))
            {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCode.Focus();
                
                return;
            }

            if (txtAirportCode.Text.Length != 3 || !txtAirportCode.Text.All(char.IsUpper))
            {
                MessageBox.Show("Airport Code must be a valid THREE UPPERCASE LETTER Airport Code.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCode.Focus();
                return;

            }

            if (!(txtAirportName.Text.Length > 0 && txtAirportName.Text.Length <= 60) || !txtAirportName.Text.All(char.IsLetter))
            {
                MessageBox.Show("Airport Name may only contain letters wuth the maximum length of 60", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportName.Focus();
                return;
            }


            if (txtAirportStreet.Text.Length >= 40 || !txtAirportStreet.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport Street has a MAXIMUM of 40 characters and contain only alphanumeric characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportStreet.Focus();
                return;
            }

            if (txtAirportCountry.Text.Length >= 20 || !txtAirportCountry.Text.All(char.IsLetter))
            {
                MessageBox.Show("Airport Country must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportCountry.Focus();
                return;
            }

            if (txtAirportEircode.Text.Length != 7 || !txtAirportEircode.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport Eircode must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportEircode.Focus();
                return;
            }

            if (!(txtAirportPhone.Text.StartsWith("08") || txtAirportPhone.Text.StartsWith("+353")) || !(txtAirportPhone.Text.Length > 0 && txtAirportPhone.Text.Length <= 15) || !txtAirportPhone.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Airport phone must be Numeric, Starts with (08 or +353 ) and Maxium 15 characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportPhone.Focus();
                return;
            }


            if (!txtAirportEmail.Text.All(char.IsDigit) || txtAirportEmail.Text.Length >= 15)
            {
                MessageBox.Show("Airport Email must be Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportEmail.Focus();
                return;
            }

           
            string email = txtAirportEmail.Text;

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAirportEmail.Focus();
                return;
            }

            MessageBox.Show("Airport has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtAirportCode.Clear();
            txtAirportName.Clear();
            txtAirportStreet.Clear();
            txtAirportName.Clear();
            txtAirportCity.Clear();
            txtAirportCountry.Clear();
            txtAirportEircode.Clear();
            txtAirportPhone.Clear();
            txtAirportEmail.Clear();
        }
       

        private void frmAddAirport_Load(object sender, EventArgs e)
        {

        }
    }
}
