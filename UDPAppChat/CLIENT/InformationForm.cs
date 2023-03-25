using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLIENT
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }
        public InformationForm(string IPAddress, string localPortNmber, string remotePortNumber)
        {
            InitializeComponent();
            txtBIPAddress.ReadOnly = true;
            txtBLocalPort.ReadOnly = true;
            txtBRemotePort.ReadOnly = true;

            txtBIPAddress.Text = IPAddress;
            txtBLocalPort.Text = localPortNmber;
            txtBRemotePort.Text = remotePortNumber;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
