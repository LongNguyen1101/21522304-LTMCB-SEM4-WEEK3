using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SERVER
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        public InformationForm(string IPAddress, string portNmber)
        {
            InitializeComponent();
            txtBIPAddress.ReadOnly = true;
            txtBPort.ReadOnly = true;
            txtBIPAddress.Text = IPAddress;
            txtBPort.Text = portNmber;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
