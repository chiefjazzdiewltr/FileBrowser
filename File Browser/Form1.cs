using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Browser {
    public partial class fileBrowser : Form {
        public fileBrowser() {
            InitializeComponent();
        }

        private void openNewBrowserToolStripMenuItem_Click(object sender, EventArgs e) {
            fileBrowser newBrowser = new fileBrowser();
            newBrowser.Show();
        }

        private void fileBrowser_FormClosing(object sender, FormClosingEventArgs e) {
            
        }
    }
}
