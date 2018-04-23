using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManagerBarMerging {
    public partial class ucContent : UserControl {
        public ucContent() {
            InitializeComponent();
            barButtonItem1.Enabled = barButtonItem2.Enabled = false;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            richEditControl1.Undo();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            richEditControl1.Redo();
        }

        private void richEditControl1_TextChanged(object sender, EventArgs e) {
            if (true == richEditControl1.CanUndo) barButtonItem1.Enabled = true;
                else barButtonItem1.Enabled = false;
            if (true == richEditControl1.CanRedo) barButtonItem2.Enabled = true;
                else barButtonItem2.Enabled = false;
        }
    }
}
