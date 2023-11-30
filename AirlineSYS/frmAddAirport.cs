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

        private void mnuAddAiport_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void frmAddAirport_Load(object sender, EventArgs e)
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
