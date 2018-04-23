Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms

Namespace DocumentManagerBarMerging
    Partial Public Class ucContent
        Inherits UserControl

        Public Sub New()
            InitializeComponent()
            barButtonItem2.Enabled = False
            barButtonItem1.Enabled = barButtonItem2.Enabled
        End Sub

        Private Sub barButtonItem1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem1.ItemClick
            richEditControl1.Undo()
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
            richEditControl1.Redo()
        End Sub

        Private Sub richEditControl1_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles richEditControl1.TextChanged
            If True = richEditControl1.CanUndo Then
                barButtonItem1.Enabled = True
                Else
                    barButtonItem1.Enabled = False
                End If
            If True = richEditControl1.CanRedo Then
                barButtonItem2.Enabled = True
                Else
                    barButtonItem2.Enabled = False
                End If
        End Sub
    End Class
End Namespace
