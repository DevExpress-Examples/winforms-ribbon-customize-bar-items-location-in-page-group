Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Ribbon.ViewInfo

Namespace CustomRibbonControl
	<ProvideProperty("Location", GetType(BarItem))> _
	Public Class BarItemExtender
		Inherits Component
		Implements IExtenderProvider
		Private controlsDictionary As New Dictionary(Of BarItem, Point)()
		Public Event LocationChanged As EventHandler

		Public Function GetLocation(ByVal control As BarItem) As Point
			Dim location As Point = Point.Empty
			If controlsDictionary.ContainsKey(control) Then
				location = controlsDictionary(control)
			End If
			Return location
		End Function
		Public Sub SetLocation(ByVal control As BarItem, ByVal value As Point)
			If (Not controlsDictionary.ContainsKey(control)) Then
				controlsDictionary.Add(control, value)
			Else
				controlsDictionary.Remove(control)
				controlsDictionary.Add(control, value)
			End If
			RaiseEvent LocationChanged(Me, EventArgs.Empty)
		End Sub

		#Region "IExtenderProvider Members"

		Public Function CanExtend(ByVal control As Object) As Boolean Implements IExtenderProvider.CanExtend
			Return TypeOf control Is BarItem
		End Function
		#End Region
	End Class
End Namespace
