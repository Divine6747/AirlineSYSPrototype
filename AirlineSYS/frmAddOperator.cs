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

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }

        private void btnOperatorConfirm_Click(object sender, EventArgs e)
        {
            if (txtOperatorCode.Text.Equals("") || txtOperatorName.Text.Equals("") || txtOperatorStreet.Text.Equals("") ||
                txtOperatorCity.Text.Equals("") || txtOperatorCountry.Text.Equals("") || txtOperatorEircode.Text.Equals("") ||
                txtOperatorPhone.Text.Equals("") || txtOperatorEmail.Text.Equals(""))
                        {
                MessageBox.Show("All fields must be entered", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorCode.Focus();

                return;
            }


            else if (txtOperatorCode.Text.Length != 2 || !txtOperatorCode.Text.All(char.IsUpper))
            {
                 MessageBox.Show("Operator Code must be a valid THREE UPPERCASE LETTER Operator Code.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 txtOperatorCode.Focus();
                 return;

            }

            else if (txtOperatorName.Text.Length > 60 || !txtOperatorName.Text.All(c => char.IsLetter(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator Name may only contain letters with the maximum length of 60", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorName.Focus();
                return;
            }


            else if (txtOperatorStreet.Text.Length > 40 || !txtOperatorStreet.Text.All(c => char.IsLetterOrDigit(c) || char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Operator Street has a MAXIMUM of 40 characters and contain only alphanumeric characters.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorStreet.Focus();
                return;
            }

            else if (txtOperatorCountry.Text.Length > 30 || !txtOperatorCountry.Text.All(char.IsLetter))
            {
                MessageBox.Show("Operator Country must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorCountry.Focus();
                return;
            }

            else if (txtOperatorEircode.Text.Length != 7 || !txtOperatorEircode.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Operator Eircode must be Alpha Numeric", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorEircode.Focus();
                return;
            }

            else if (!(txtOperatorPhone.Text.StartsWith("08") || txtOperatorPhone.Text.StartsWith("+353")) || !(txtOperatorPhone.Text.Length > 0 && txtOperatorPhone.Text.Length <= 15) || !txtOperatorPhone.Text.All(char.IsLetterOrDigit))
            {
                MessageBox.Show("Operator phone must be Numeric, Starts with (08 or +353 ) and Maxium 15 characters", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorPhone.Focus();
                return;
            }


            else if (txtOperatorEmail.Text.All(char.IsDigit) || txtOperatorEmail.Text.Length > 45)
            {
                MessageBox.Show("Operator Email must can not be Numeric and MAXIMUM length of 45", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorEmail.Focus();
                return;
            }


            string email = txtOperatorEmail.Text;

            string emailPattern = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}$";

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOperatorEmail.Focus();
                return;
            }
            else
            {
                MessageBox.Show("Operator has been added to the Database", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtOperatorCode.Clear();
                txtOperatorName.Clear();
                txtOperatorStreet.Clear();
                txtOperatorName.Clear();
                txtOperatorCity.Clear();
                txtOperatorCountry.Clear();
                txtOperatorEircode.Clear();
                txtOperatorPhone.Clear();
                txtOperatorEmail.Clear();
            }

            
        }

    }
}

