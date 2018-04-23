Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraBars
Imports System.Windows.Forms

Namespace CustomRibbonControl
	Public Class RibbonPageGroupComplexLayoutCalculatorDescendant
		Inherits RibbonPageGroupComplexLayoutCalculator
		Private offsetY As Integer
		Private offsetX As Integer
		Private widthList As New List(Of Integer)()

		Public Sub New(ByVal groupInfo As IRibbonGroupInfo)
			MyBase.New(groupInfo)
		End Sub

		Protected Overrides Sub InsertItemCore(ByVal info As RibbonPageGroupLayoutCalculator.GroupColumnLayoutInfo)
			MyBase.InsertItemCore(info)
			Dim barItemExtender As BarItemExtender = (CType(GroupInfo.ViewInfo.Ribbon, RibbonControlDescendant)).BarItemExtender
			If barItemExtender IsNot Nothing Then
				If TypeOf info.ItemInfo.Item Is BarItemLink Then
					Dim Location As Point = barItemExtender.GetLocation(CType((CType(info.ItemInfo.Item, BarItemLink)).Item, BarItem))
					offsetX = Location.X
					offsetY = Location.Y
					widthList.Add(offsetX + info.ItemInfo.Bounds.Width)
					If offsetY > info.ContentBounds.Height Then
						offsetY = info.ContentBounds.Height - info.ItemInfo.Bounds.Height
					End If
					info.ItemInfo.Bounds = New Rectangle(New Point(info.ContentBounds.X + offsetX, info.ContentBounds.Y + offsetY), info.ItemInfo.Bounds.Size)
					info.MaxColumnWidth = widthList.Max()
				End If
			End If
		End Sub
		Protected Overrides Function UpdateGroupLayout(ByVal contentBounds As Rectangle) As Integer
			Dim info As New GroupColumnLayoutInfo()
			info.Location = contentBounds.Location
			info.ContentBounds = contentBounds
			GroupInfo.ContentBounds = contentBounds
			info.MaxColumnWidth = 0
			info.ColumnItemCount = 0
			info.Position = 0
			Do While info.Position < GroupInfo.Items.Count
				info.ItemInfo = GroupInfo.Items(info.Position)
				InsertItem(info)
				info.Position += 1
			Loop
			If GroupInfo.ViewInfo.Ribbon.AutoSizeItems Then
				AutoSizeItems(info)
			End If
			RelayoutItemsInColumn()
			Dim width As Integer = info.Location.X + info.MaxColumnWidth - info.ContentBounds.Left
			Return width
		End Function
		Protected Overrides Sub RelayoutItemsInColumn()
		End Sub
	End Class
End Namespace
