Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports DevExpress.XtraBars

Namespace CustomRibbonControl

    <ProvideProperty("Location", GetType(BarItem))>
    Public Class BarItemExtender
        Inherits Component
        Implements IExtenderProvider

        Private controlsDictionary As Dictionary(Of BarItem, Point) = New Dictionary(Of BarItem, Point)()

        Public Event LocationChanged As EventHandler

        Public Function GetLocation(ByVal control As BarItem) As Point
            Dim location As Point = Point.Empty
            If controlsDictionary.ContainsKey(control) Then
                location = controlsDictionary(control)
            End If

            Return location
        End Function

        Public Sub SetLocation(ByVal control As BarItem, ByVal value As Point)
            If Not controlsDictionary.ContainsKey(control) Then
                controlsDictionary.Add(control, value)
            Else
                controlsDictionary.Remove(control)
                controlsDictionary.Add(control, value)
            End If

            RaiseEvent LocationChanged(Me, EventArgs.Empty)
        End Sub

'#Region "IExtenderProvider Members"
        Public Function CanExtend(ByVal control As Object) As Boolean Implements IExtenderProvider.CanExtend
            Return TypeOf control Is BarItem
        End Function
'#End Region
    End Class
End Namespace
