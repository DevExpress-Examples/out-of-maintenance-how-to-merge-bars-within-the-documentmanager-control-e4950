Namespace DocumentManagerBarMerging
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.documentManager1 = New DevExpress.XtraBars.Docking2010.DocumentManager(Me.components)
            Me.tabbedView1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(Me.components)
            Me.document1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            Me.documentGroup1 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup(Me.components)
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.bar1 = New DevExpress.XtraBars.Bar()
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.barSubItem2 = New DevExpress.XtraBars.BarSubItem()
            Me.barButtonItem8 = New DevExpress.XtraBars.BarButtonItem()
            Me.barStaticItem1 = New DevExpress.XtraBars.BarStaticItem()
            Me.document2 = New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document(Me.components)
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' documentManager1
            ' 
            Me.documentManager1.ContainerControl = Me
            Me.documentManager1.MenuManager = Me.barManager1
            Me.documentManager1.View = Me.tabbedView1
            Me.documentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.tabbedView1})
            ' 
            ' tabbedView1
            ' 
            Me.tabbedView1.DocumentGroups.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup() { Me.documentGroup1})
            Me.tabbedView1.Documents.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseDocument() { Me.document1, Me.document2})
            ' 
            ' document1
            ' 
            Me.document1.Caption = "Document 1"
            Me.document1.ControlName = "document1"
            ' 
            ' documentGroup1
            ' 
            Me.documentGroup1.Items.AddRange(New DevExpress.XtraBars.Docking2010.Views.Tabbed.Document() { Me.document1, Me.document2})
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013"
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar1, Me.bar2, Me.bar3})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barButtonItem7, Me.barSubItem2, Me.barButtonItem8, Me.barStaticItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 11
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(910, 53)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 437)
            Me.barDockControlBottom.Size = New System.Drawing.Size(910, 24)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 53)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 384)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(910, 53)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 384)
            ' 
            ' bar1
            ' 
            Me.bar1.BarName = "Tools"
            Me.bar1.DockCol = 0
            Me.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem5) _
            })
            Me.bar1.Text = "Tools"
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1) _
            })
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barStaticItem1)})
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "Document"
            Me.barSubItem1.Id = 0
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem4) _
            })
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "Float"
            Me.barButtonItem1.Glyph = (DirectCast(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image))
            Me.barButtonItem1.Id = 1
            Me.barButtonItem1.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem1.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "Dock"
            Me.barButtonItem2.Glyph = (DirectCast(resources.GetObject("barButtonItem2.Glyph"), System.Drawing.Image))
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem2.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "Pin"
            Me.barButtonItem3.Id = 3
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "Unpin"
            Me.barButtonItem4.Id = 4
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "Reset Layout"
            Me.barButtonItem5.Glyph = (DirectCast(resources.GetObject("barButtonItem5.Glyph"), System.Drawing.Image))
            Me.barButtonItem5.Id = 5
            Me.barButtonItem5.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem5.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barButtonItem6
            ' 
            Me.barButtonItem6.Caption = "Select Next Tab"
            Me.barButtonItem6.Glyph = (DirectCast(resources.GetObject("barButtonItem6.Glyph"), System.Drawing.Image))
            Me.barButtonItem6.Id = 6
            Me.barButtonItem6.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem6.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem6.Name = "barButtonItem6"
            ' 
            ' barButtonItem7
            ' 
            Me.barButtonItem7.Caption = "Select Previous Tab"
            Me.barButtonItem7.Glyph = (DirectCast(resources.GetObject("barButtonItem7.Glyph"), System.Drawing.Image))
            Me.barButtonItem7.Id = 7
            Me.barButtonItem7.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem7.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem7.Name = "barButtonItem7"
            ' 
            ' barSubItem2
            ' 
            Me.barSubItem2.Caption = "File"
            Me.barSubItem2.Id = 8
            Me.barSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem8)})
            Me.barSubItem2.Name = "barSubItem2"
            ' 
            ' barButtonItem8
            ' 
            Me.barButtonItem8.Caption = "New Document"
            Me.barButtonItem8.Glyph = (DirectCast(resources.GetObject("barButtonItem8.Glyph"), System.Drawing.Image))
            Me.barButtonItem8.Id = 9
            Me.barButtonItem8.LargeGlyph = (DirectCast(resources.GetObject("barButtonItem8.LargeGlyph"), System.Drawing.Image))
            Me.barButtonItem8.Name = "barButtonItem8"
            ' 
            ' barStaticItem1
            ' 
            Me.barStaticItem1.Caption = "Ready"
            Me.barStaticItem1.Id = 10
            Me.barStaticItem1.Name = "barStaticItem1"
            Me.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near
            ' 
            ' document2
            ' 
            Me.document2.Caption = "Document 2"
            Me.document2.ControlName = "document2"
            Me.document2.FloatLocation = New System.Drawing.Point(206, 239)
            Me.document2.FloatSize = New System.Drawing.Size(904, 354)
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(910, 461)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.documentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tabbedView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.documentGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.document2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private documentManager1 As DevExpress.XtraBars.Docking2010.DocumentManager
        Private WithEvents tabbedView1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView
        Private documentGroup1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.DocumentGroup
        Private document1 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents barManager1 As DevExpress.XtraBars.BarManager
        Private bar1 As DevExpress.XtraBars.Bar
        Private bar2 As DevExpress.XtraBars.Bar
        Private barSubItem1 As DevExpress.XtraBars.BarSubItem
        Private WithEvents barButtonItem1 As DevExpress.XtraBars.BarButtonItem
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private WithEvents barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem4 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem5 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem6 As DevExpress.XtraBars.BarButtonItem
        Private WithEvents barButtonItem7 As DevExpress.XtraBars.BarButtonItem
        Private barSubItem2 As DevExpress.XtraBars.BarSubItem
        Private WithEvents barButtonItem8 As DevExpress.XtraBars.BarButtonItem
        Private barStaticItem1 As DevExpress.XtraBars.BarStaticItem
        Private document2 As DevExpress.XtraBars.Docking2010.Views.Tabbed.Document
    End Class
End Namespace

