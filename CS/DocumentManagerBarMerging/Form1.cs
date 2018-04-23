using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocumentManagerBarMerging {
    public partial class Form1 : Form {
        
        public Form1() {
            InitializeComponent();
            tabbedView1.DocumentProperties.AllowPin = true;
            documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always;
        }

        private void tabbedView1_QueryControl(object sender, DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs e) {
            e.Control = new ucContent();
        }

        private void Dock(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (tabbedView1.ActiveDocument != null) tabbedView1.Controller.Float(tabbedView1.ActiveDocument);
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (tabbedView1.ActiveFloatDocument != null) tabbedView1.Controller.Dock(tabbedView1.ActiveFloatDocument);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (tabbedView1.ActiveDocument != null) (tabbedView1.ActiveDocument as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document).Pinned = true;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (tabbedView1.ActiveDocument != null) (tabbedView1.ActiveDocument as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document).Pinned = false;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            tabbedView1.Controller.ResetLayout();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            tabbedView1.Controller.SelectNextTab(true);
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            tabbedView1.Controller.SelectNextTab(false);
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            DevExpress.XtraBars.Docking2010.Views.Tabbed.Document newDoc = tabbedView1.AddDocument(new ucContent()) as DevExpress.XtraBars.Docking2010.Views.Tabbed.Document;
            newDoc.Caption = "New Document " + (tabbedView1.Documents.Count).ToString();
        }

        private void barManager1_Merge(object sender, DevExpress.XtraBars.BarManagerMergeEventArgs e) {
            bar1.Merge(e.ChildManager.Bars[0]);
            barManager1.StatusBar.Merge(e.ChildManager.StatusBar);
        }

        private void barManager1_UnMerge(object sender, DevExpress.XtraBars.BarManagerMergeEventArgs e) {
            bar1.UnMerge();
            barManager1.StatusBar.UnMerge();
        }
    }
}
