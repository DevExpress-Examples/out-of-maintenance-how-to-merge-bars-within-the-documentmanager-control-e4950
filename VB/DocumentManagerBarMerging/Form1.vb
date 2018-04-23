Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DocumentManagerBarMerging
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            tabbedView1.DocumentProperties.AllowPin = True
            documentManager1.RibbonAndBarsMergeStyle = DevExpress.XtraBars.Docking2010.Views.RibbonAndBarsMergeStyle.Always
        End Sub

        Private Sub tabbedView1_QueryControl(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking2010.Views.QueryControlEventArgs) Handles tabbedView1.QueryControl
            e.Control = New ucContent()
        End Sub

        Private Overloads Sub Dock(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            If tabbedView1.ActiveDocument IsNot Nothing Then
                tabbedView1.Controller.Float(tabbedView1.ActiveDocument)
            End If
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
            If tabbedView1.ActiveFloatDocument IsNot Nothing Then
                tabbedView1.Controller.Dock(tabbedView1.ActiveFloatDocument)
            End If
        End Sub

        Private Sub barButtonItem3_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem3.ItemClick
            If tabbedView1.ActiveDocument IsNot Nothing Then
                TryCast(tabbedView1.ActiveDocument, DevExpress.XtraBars.Docking2010.Views.Tabbed.Document).Pinned = True
            End If
        End Sub

        Private Sub barButtonItem4_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem4.ItemClick
            If tabbedView1.ActiveDocument IsNot Nothing Then
                TryCast(tabbedView1.ActiveDocument, DevExpress.XtraBars.Docking2010.Views.Tabbed.Document).Pinned = False
            End If
        End Sub

        Private Sub barButtonItem5_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem5.ItemClick
            tabbedView1.Controller.ResetLayout()
        End Sub

        Private Sub barButtonItem6_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem6.ItemClick
            tabbedView1.Controller.SelectNextTab(True)
        End Sub

        Private Sub barButtonItem7_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem7.ItemClick
            tabbedView1.Controller.SelectNextTab(False)
        End Sub

        Private Sub barButtonItem8_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem8.ItemClick
            Dim newDoc As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document = TryCast(tabbedView1.AddDocument(New ucContent()), DevExpress.XtraBars.Docking2010.Views.Tabbed.Document)
            newDoc.Caption = "New Document " & (tabbedView1.Documents.Count).ToString()
        End Sub

        Private Sub barManager1_Merge(ByVal sender As Object, ByVal e As DevExpress.XtraBars.BarManagerMergeEventArgs) Handles barManager1.Merge
            bar1.Merge(e.ChildManager.Bars(0))
            barManager1.StatusBar.Merge(e.ChildManager.StatusBar)
        End Sub

        Private Sub barManager1_UnMerge(ByVal sender As Object, ByVal e As DevExpress.XtraBars.BarManagerMergeEventArgs) Handles barManager1.UnMerge
            bar1.UnMerge()
            barManager1.StatusBar.UnMerge()
        End Sub
    End Class
End Namespace
