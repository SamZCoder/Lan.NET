using Lan.NET.App.Properties;
using Lan.NET.Domain;
using Lan.NET.Network;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lan.NET.App.Forms
{
    public partial class IPScannerForm : Form
    {
        public IPScannerForm()
        {
            InitializeComponent();
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            IPScanner scanner = new IPScanner();
            scanner.IPScanned += this.Scanner_IPScanned;
            scanner.ScanRange(startText.Text, endText.Text);
            
        }

        private void Scanner_IPScanned(IPScanResult result)
        {
            try
            {
                this.Invoke((MethodInvoker)delegate
                {
                    Bitmap StatusIcon = (result.IsOnline) ? Properties.Resources.Online_Icon : Properties.Resources.Offline_Icon;
                    resultGridView.Rows.Add(
                        StatusIcon,
                        result.Address.ToString(),
                        result.IsOnline,
                        result.Status.ToString()
                    );
                });
            }
            catch { }
           
        }
    }
}
