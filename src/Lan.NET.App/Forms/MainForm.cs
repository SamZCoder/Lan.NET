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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void networkScannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new IPScannerForm()).Show();
        }
    }
}
