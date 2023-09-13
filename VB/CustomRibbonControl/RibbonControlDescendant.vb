Imports System
Imports DevExpress.XtraBars.Ribbon
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports System.Drawing

Namespace CustomRibbonControl

    Public Class RibbonControlDescendant
        Inherits RibbonControl

        Private _BarItemExtender As BarItemExtender

        Private viewInfo As RibbonViewInfoDescendant

        Public Property BarItemExtender As BarItemExtender
            Get
                Return _BarItemExtender
            End Get

            Set(ByVal value As BarItemExtender)
                _BarItemExtender = value
                If value IsNot Nothing Then AddHandler _BarItemExtender.LocationChanged, AddressOf OnItemLocationChanged
                Refresh()
            End Set
        End Property

        Public Sub New()
            MyBase.New()
        End Sub

        Private Sub OnItemLocationChanged(ByVal sender As Object, ByVal e As EventArgs)
            Refresh()
        End Sub

        Protected Overrides Function CreateViewInfo() As RibbonViewInfo
            viewInfo = New RibbonViewInfoDescendant(Me)
            Return CType(viewInfo, RibbonViewInfo)
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso _BarItemExtender IsNot Nothing Then RemoveHandler _BarItemExtender.LocationChanged, AddressOf OnItemLocationChanged
            MyBase.Dispose(disposing)
        End Sub

        Protected Overrides Sub OnGroupAdded(ByVal group As RibbonPageGroup)
            MyBase.OnGroupAdded(group)
            If group.AllowMinimize Then group.AllowMinimize = False
        End Sub

        Protected Overrides Sub OnGroupChanged(ByVal pageGroup As RibbonPageGroup)
            MyBase.OnGroupChanged(pageGroup)
            If pageGroup.AllowMinimize Then pageGroup.AllowMinimize = False
        End Sub
    End Class
End Namespace
