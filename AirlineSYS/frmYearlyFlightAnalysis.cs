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
    public partial class frmYearlyFlightAnalysis : Form
    {
        frmAirlineMainMenu parent;
        public frmYearlyFlightAnalysis()
        {
            InitializeComponent();
        }
        public frmYearlyFlightAnalysis(frmAirlineMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmYearlyFlightAnalysis_Load(object sender, EventArgs e)
        {

        }

        private void munBack_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAirlineMainMenu frmAirlineMainMenu = new frmAirlineMainMenu();
            frmAirlineMainMenu.Show();
        }
    }
}
