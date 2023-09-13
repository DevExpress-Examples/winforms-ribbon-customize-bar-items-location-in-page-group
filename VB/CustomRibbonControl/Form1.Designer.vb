Imports System.Drawing

Namespace CustomRibbonControl

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.barItemExtender2 = New CustomRibbonControl.BarItemExtender()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem1 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem15 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem16 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem17 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.barButtonItem18 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem19 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem20 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem21 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem22 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem23 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem24 = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem1 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem25 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.barEditItem2 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.barCheckItem2 = New DevExpress.XtraBars.BarCheckItem()
            Me.barEditItem3 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemRangeTrackBar1 = New DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar()
            Me.barMdiChildrenListItem1 = New DevExpress.XtraBars.BarMdiChildrenListItem()
            Me.barMdiChildrenListItem2 = New DevExpress.XtraBars.BarMdiChildrenListItem()
            Me.barCheckItem3 = New DevExpress.XtraBars.BarCheckItem()
            Me.barCheckItem4 = New DevExpress.XtraBars.BarCheckItem()
            Me.repositoryItemRadioGroup1 = New DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup()
            Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem5 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem6 = New DevExpress.XtraBars.BarButtonItem()
            Me.barCheckItem5 = New DevExpress.XtraBars.BarCheckItem()
            Me.barButtonItem7 = New DevExpress.XtraBars.BarButtonItem()
            Me.ribbonControlDescendant1 = New CustomRibbonControl.RibbonControlDescendant()
            Me.ribbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.ribbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.barEditItem4 = New DevExpress.XtraBars.BarEditItem()
            Me.repositoryItemTimeEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit()
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRangeTrackBar1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemRadioGroup1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.ribbonControlDescendant1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.repositoryItemTimeEdit1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Id = 1
            Me.barItemExtender2.SetLocation(Me.barButtonItem1, New System.Drawing.Point(20, 20))
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' barEditItem1
            ' 
            Me.barEditItem1.Caption = "barEditItem1"
            Me.barEditItem1.Edit = Me.repositoryItemButtonEdit1
            Me.barEditItem1.Id = 2
            Me.barItemExtender2.SetLocation(Me.barEditItem1, New System.Drawing.Point(200, 100))
            Me.barEditItem1.Name = "barEditItem1"
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "barButtonItem2"
            Me.barButtonItem2.Id = 3
            Me.barItemExtender2.SetLocation(Me.barButtonItem2, New System.Drawing.Point(300, 100))
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem15
            ' 
            Me.barButtonItem15.Caption = "barButtonItem15"
            Me.barButtonItem15.Id = 17
            Me.barItemExtender2.SetLocation(Me.barButtonItem15, New System.Drawing.Point(100, 100))
            Me.barButtonItem15.Name = "barButtonItem15"
            ' 
            ' barButtonItem16
            ' 
            Me.barButtonItem16.Caption = "barButtonItem16"
            Me.barButtonItem16.Id = 18
            Me.barItemExtender2.SetLocation(Me.barButtonItem16, New System.Drawing.Point(100, 100))
            Me.barButtonItem16.Name = "barButtonItem16"
            ' 
            ' barButtonItem17
            ' 
            Me.barButtonItem17.Caption = "barButtonItem17"
            Me.barButtonItem17.Id = 19
            Me.barItemExtender2.SetLocation(Me.barButtonItem17, New System.Drawing.Point(10, 0))
            Me.barButtonItem17.Name = "barButtonItem17"
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Caption = "barButtonGroup3"
            Me.barButtonGroup3.Id = 20
            Me.barButtonGroup3.ItemLinks.Add(Me.barButtonItem18)
            Me.barButtonGroup3.ItemLinks.Add(Me.barButtonItem19)
            Me.barButtonGroup3.ItemLinks.Add(Me.barButtonItem20)
            Me.barButtonGroup3.ItemLinks.Add(Me.barButtonItem21)
            Me.barButtonGroup3.ItemLinks.Add(Me.barButtonItem22)
            Me.barItemExtender2.SetLocation(Me.barButtonGroup3, New System.Drawing.Point(0, 0))
            Me.barButtonGroup3.Name = "barButtonGroup3"
            ' 
            ' barButtonItem18
            ' 
            Me.barButtonItem18.Caption = "barButtonItem18"
            Me.barButtonItem18.Id = 21
            Me.barItemExtender2.SetLocation(Me.barButtonItem18, New System.Drawing.Point(200, 100))
            Me.barButtonItem18.Name = "barButtonItem18"
            ' 
            ' barButtonItem19
            ' 
            Me.barButtonItem19.Caption = "barButtonItem19"
            Me.barButtonItem19.Id = 22
            Me.barItemExtender2.SetLocation(Me.barButtonItem19, New System.Drawing.Point(200, 100))
            Me.barButtonItem19.Name = "barButtonItem19"
            ' 
            ' barButtonItem20
            ' 
            Me.barButtonItem20.Caption = "barButtonItem20"
            Me.barButtonItem20.Id = 23
            Me.barItemExtender2.SetLocation(Me.barButtonItem20, New System.Drawing.Point(200, 100))
            Me.barButtonItem20.Name = "barButtonItem20"
            ' 
            ' barButtonItem21
            ' 
            Me.barButtonItem21.Caption = "barButtonItem21"
            Me.barButtonItem21.Id = 24
            Me.barItemExtender2.SetLocation(Me.barButtonItem21, New System.Drawing.Point(200, 100))
            Me.barButtonItem21.Name = "barButtonItem21"
            ' 
            ' barButtonItem22
            ' 
            Me.barButtonItem22.Caption = "barButtonItem22"
            Me.barButtonItem22.Id = 25
            Me.barItemExtender2.SetLocation(Me.barButtonItem22, New System.Drawing.Point(200, 100))
            Me.barButtonItem22.Name = "barButtonItem22"
            ' 
            ' barButtonItem23
            ' 
            Me.barButtonItem23.Caption = "barButtonItem23"
            Me.barButtonItem23.Id = 26
            Me.barButtonItem23.LargeGlyph = Global.CustomRibbonControl.Properties.Resources.Yellow
            Me.barItemExtender2.SetLocation(Me.barButtonItem23, New System.Drawing.Point(20, 20))
            Me.barButtonItem23.Name = "barButtonItem23"
            ' 
            ' barButtonItem24
            ' 
            Me.barButtonItem24.Caption = "barButtonItem24"
            Me.barButtonItem24.Id = 30
            Me.barItemExtender2.SetLocation(Me.barButtonItem24, New System.Drawing.Point(0, 0))
            Me.barButtonItem24.Name = "barButtonItem24"
            ' 
            ' barCheckItem1
            ' 
            Me.barCheckItem1.Caption = "barCheckItem1"
            Me.barCheckItem1.Id = 31
            Me.barItemExtender2.SetLocation(Me.barCheckItem1, New System.Drawing.Point(50, 50))
            Me.barCheckItem1.Name = "barCheckItem1"
            ' 
            ' barButtonItem25
            ' 
            Me.barButtonItem25.Caption = "barButtonItem25"
            Me.barButtonItem25.Id = 37
            Me.barItemExtender2.SetLocation(Me.barButtonItem25, New System.Drawing.Point(0, 0))
            Me.barButtonItem25.Name = "barButtonItem25"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "barButtonItem3"
            Me.barButtonItem3.Glyph = Global.CustomRibbonControl.Properties.Resources.ExportGraphicLarge1
            Me.barButtonItem3.Id = 39
            Me.barItemExtender2.SetLocation(Me.barButtonItem3, New System.Drawing.Point(0, 0))
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' barEditItem2
            ' 
            Me.barEditItem2.Caption = "barEditItem2"
            Me.barEditItem2.Edit = Me.repositoryItemFontEdit1
            Me.barEditItem2.Id = 40
            Me.barItemExtender2.SetLocation(Me.barEditItem2, New System.Drawing.Point(50, 20))
            Me.barEditItem2.Name = "barEditItem2"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' barCheckItem2
            ' 
            Me.barCheckItem2.Caption = "barCheckItem2"
            Me.barCheckItem2.Glyph = Global.CustomRibbonControl.Properties.Resources.Contact_Us
            Me.barCheckItem2.Id = 42
            Me.barItemExtender2.SetLocation(Me.barCheckItem2, New System.Drawing.Point(0, 45))
            Me.barCheckItem2.Name = "barCheckItem2"
            ' 
            ' barEditItem3
            ' 
            Me.barEditItem3.Caption = "barEditItem3"
            Me.barEditItem3.Edit = Me.repositoryItemRangeTrackBar1
            Me.barEditItem3.Glyph = Global.CustomRibbonControl.Properties.Resources.MultiplePagesLarge
            Me.barEditItem3.Id = 43
            Me.barItemExtender2.SetLocation(Me.barEditItem3, New System.Drawing.Point(200, 100))
            Me.barEditItem3.Name = "barEditItem3"
            ' 
            ' repositoryItemRangeTrackBar1
            ' 
            Me.repositoryItemRangeTrackBar1.Name = "repositoryItemRangeTrackBar1"
            ' 
            ' barMdiChildrenListItem1
            ' 
            Me.barMdiChildrenListItem1.Caption = "barMdiChildrenListItem1"
            Me.barMdiChildrenListItem1.Glyph = Global.CustomRibbonControl.Properties.Resources.PrintDirectLarge
            Me.barMdiChildrenListItem1.Id = 44
            Me.barItemExtender2.SetLocation(Me.barMdiChildrenListItem1, New System.Drawing.Point(180, 0))
            Me.barMdiChildrenListItem1.Name = "barMdiChildrenListItem1"
            ' 
            ' barMdiChildrenListItem2
            ' 
            Me.barMdiChildrenListItem2.Caption = "barMdiChildrenListItem2"
            Me.barMdiChildrenListItem2.Glyph = Global.CustomRibbonControl.Properties.Resources.PageMarginsWide
            Me.barMdiChildrenListItem2.Id = 46
            Me.barItemExtender2.SetLocation(Me.barMdiChildrenListItem2, New System.Drawing.Point(0, 0))
            Me.barMdiChildrenListItem2.Name = "barMdiChildrenListItem2"
            ' 
            ' barCheckItem3
            ' 
            Me.barCheckItem3.Caption = "barCheckItem3"
            Me.barCheckItem3.Id = 47
            Me.barItemExtender2.SetLocation(Me.barCheckItem3, New System.Drawing.Point(0, 22))
            Me.barCheckItem3.Name = "barCheckItem3"
            ' 
            ' barCheckItem4
            ' 
            Me.barCheckItem4.Caption = "barCheckItem4"
            Me.barCheckItem4.Glyph = Global.CustomRibbonControl.Properties.Resources.Online_Help1
            Me.barCheckItem4.Id = 48
            Me.barItemExtender2.SetLocation(Me.barCheckItem4, New System.Drawing.Point(80, 22))
            Me.barCheckItem4.Name = "barCheckItem4"
            ' 
            ' repositoryItemRadioGroup1
            ' 
            Me.repositoryItemRadioGroup1.Name = "repositoryItemRadioGroup1"
            ' 
            ' barButtonItem4
            ' 
            Me.barButtonItem4.Caption = "barButtonItem4"
            Me.barButtonItem4.Glyph = Global.CustomRibbonControl.Properties.Resources.PaperSizeLarge
            Me.barButtonItem4.Id = 50
            Me.barItemExtender2.SetLocation(Me.barButtonItem4, New System.Drawing.Point(0, 0))
            Me.barButtonItem4.Name = "barButtonItem4"
            ' 
            ' barButtonItem5
            ' 
            Me.barButtonItem5.Caption = "barButtonItem5"
            Me.barButtonItem5.Glyph = Global.CustomRibbonControl.Properties.Resources.Code_Central
            Me.barButtonItem5.Id = 51
            Me.barItemExtender2.SetLocation(Me.barButtonItem5, New System.Drawing.Point(75, 22))
            Me.barButtonItem5.Name = "barButtonItem5"
            ' 
            ' barButtonItem6
            ' 
            Me.barButtonItem6.Caption = "barButtonItem6"
            Me.barButtonItem6.Glyph = Global.CustomRibbonControl.Properties.Resources.ExportXlsLarge
            Me.barButtonItem6.Id = 52
            Me.barItemExtender2.SetLocation(Me.barButtonItem6, New System.Drawing.Point(150, 45))
            Me.barButtonItem6.Name = "barButtonItem6"
            ' 
            ' barCheckItem5
            ' 
            Me.barCheckItem5.Caption = "barCheckItem5"
            Me.barCheckItem5.Glyph = Global.CustomRibbonControl.Properties.Resources.ExportMhtLarge
            Me.barCheckItem5.Id = 53
            Me.barItemExtender2.SetLocation(Me.barCheckItem5, New System.Drawing.Point(0, 100))
            Me.barCheckItem5.Name = "barCheckItem5"
            ' 
            ' barButtonItem7
            ' 
            Me.barButtonItem7.Caption = "barButtonItem7"
            Me.barButtonItem7.Glyph = Global.CustomRibbonControl.Properties.Resources.ExportRtfLarge1
            Me.barButtonItem7.Id = 54
            Me.barItemExtender2.SetLocation(Me.barButtonItem7, New System.Drawing.Point(150, 0))
            Me.barButtonItem7.Name = "barButtonItem7"
            ' 
            ' ribbonControlDescendant1
            ' 
            Me.ribbonControlDescendant1.BarItemExtender = Me.barItemExtender2
            Me.ribbonControlDescendant1.ExpandCollapseItem.Id = 0
            Me.ribbonControlDescendant1.ExpandCollapseItem.Name = ""
            Me.ribbonControlDescendant1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.ribbonControlDescendant1.ExpandCollapseItem, Me.barButtonItem1, Me.barEditItem1, Me.barButtonItem2, Me.barButtonItem15, Me.barButtonItem16, Me.barButtonItem17, Me.barButtonGroup3, Me.barButtonItem18, Me.barButtonItem19, Me.barButtonItem20, Me.barButtonItem21, Me.barButtonItem22, Me.barButtonItem23, Me.barButtonItem24, Me.barCheckItem1, Me.barButtonItem25, Me.barButtonItem3, Me.barEditItem2, Me.barCheckItem2, Me.barEditItem3, Me.barMdiChildrenListItem1, Me.barMdiChildrenListItem2, Me.barCheckItem3, Me.barCheckItem4, Me.barButtonItem4, Me.barButtonItem5, Me.barButtonItem6, Me.barCheckItem5, Me.barButtonItem7, Me.barEditItem4})
            Me.ribbonControlDescendant1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControlDescendant1.MaxItemId = 56
            Me.ribbonControlDescendant1.Name = "ribbonControlDescendant1"
            Me.ribbonControlDescendant1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.ribbonPage1})
            Me.ribbonControlDescendant1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.repositoryItemButtonEdit1, Me.repositoryItemFontEdit1, Me.repositoryItemRangeTrackBar1, Me.repositoryItemRadioGroup1, Me.repositoryItemTimeEdit1})
            Me.ribbonControlDescendant1.Size = New System.Drawing.Size(1029, 142)
            ' 
            ' ribbonPage1
            ' 
            Me.ribbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.ribbonPageGroup1, Me.ribbonPageGroup2, Me.ribbonPageGroup3, Me.ribbonPageGroup4})
            Me.ribbonPage1.Name = "ribbonPage1"
            Me.ribbonPage1.Text = "ribbonPage1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.AllowMinimize = False
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barButtonItem3)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barEditItem2)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barCheckItem2)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barEditItem3)
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barMdiChildrenListItem1)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "ribbonPageGroup1"
            ' 
            ' ribbonPageGroup2
            ' 
            Me.ribbonPageGroup2.AllowMinimize = False
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barMdiChildrenListItem2)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barCheckItem3)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barCheckItem4)
            Me.ribbonPageGroup2.ItemLinks.Add(Me.barEditItem4)
            Me.ribbonPageGroup2.Name = "ribbonPageGroup2"
            Me.ribbonPageGroup2.Text = "ribbonPageGroup2"
            ' 
            ' ribbonPageGroup3
            ' 
            Me.ribbonPageGroup3.AllowMinimize = False
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barButtonItem4)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barButtonItem5)
            Me.ribbonPageGroup3.ItemLinks.Add(Me.barButtonItem6)
            Me.ribbonPageGroup3.Name = "ribbonPageGroup3"
            Me.ribbonPageGroup3.Text = "ribbonPageGroup3"
            ' 
            ' ribbonPageGroup4
            ' 
            Me.ribbonPageGroup4.AllowMinimize = False
            Me.ribbonPageGroup4.ItemLinks.Add(Me.barCheckItem5, False, "", "", True)
            Me.ribbonPageGroup4.ItemLinks.Add(Me.barButtonItem7)
            Me.ribbonPageGroup4.Name = "ribbonPageGroup4"
            Me.ribbonPageGroup4.Text = "ribbonPageGroup4"
            ' 
            ' barEditItem4
            ' 
            Me.barEditItem4.Caption = "barEditItem4"
            Me.barEditItem4.Edit = Me.repositoryItemTimeEdit1
            Me.barEditItem4.Id = 55
            Me.barItemExtender2.SetLocation(Me.barEditItem4, New System.Drawing.Point(50, 100))
            Me.barEditItem4.Name = "barEditItem4"
            ' 
            ' repositoryItemTimeEdit1
            ' 
            Me.repositoryItemTimeEdit1.AutoHeight = False
            Me.repositoryItemTimeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1029, 464)
            Me.Controls.Add(Me.ribbonControlDescendant1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.repositoryItemButtonEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemFontEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRangeTrackBar1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemRadioGroup1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.ribbonControlDescendant1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.repositoryItemTimeEdit1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private barItemExtender2 As CustomRibbonControl.BarItemExtender

        Private ribbonControlDescendant1 As CustomRibbonControl.RibbonControlDescendant

        Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage

        Private barEditItem1 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit

        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem15 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem16 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem17 As DevExpress.XtraBars.BarButtonItem

        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup

        Private barButtonItem18 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem19 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem20 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem21 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem22 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem23 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem24 As DevExpress.XtraBars.BarButtonItem

        Private barCheckItem1 As DevExpress.XtraBars.BarCheckItem

        Private barButtonItem25 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barEditItem2 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit

        Private barCheckItem2 As DevExpress.XtraBars.BarCheckItem

        Private barEditItem3 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemRangeTrackBar1 As DevExpress.XtraEditors.Repository.RepositoryItemRangeTrackBar

        Private barMdiChildrenListItem1 As DevExpress.XtraBars.BarMdiChildrenListItem

        Private ribbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barMdiChildrenListItem2 As DevExpress.XtraBars.BarMdiChildrenListItem

        Private barCheckItem3 As DevExpress.XtraBars.BarCheckItem

        Private barCheckItem4 As DevExpress.XtraBars.BarCheckItem

        Private repositoryItemRadioGroup1 As DevExpress.XtraEditors.Repository.RepositoryItemRadioGroup

        Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem5 As DevExpress.XtraBars.BarButtonItem

        Private barButtonItem6 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barCheckItem5 As DevExpress.XtraBars.BarCheckItem

        Private barButtonItem7 As DevExpress.XtraBars.BarButtonItem

        Private ribbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup

        Private barEditItem4 As DevExpress.XtraBars.BarEditItem

        Private repositoryItemTimeEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit
    End Class
End Namespace
