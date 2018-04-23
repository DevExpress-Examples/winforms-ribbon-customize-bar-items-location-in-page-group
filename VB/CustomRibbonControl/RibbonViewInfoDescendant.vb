Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports DevExpress.XtraBars.Ribbon.ViewInfo
Imports DevExpress.XtraBars.Ribbon

Namespace CustomRibbonControl
	Public Class RibbonViewInfoDescendant
		Inherits RibbonViewInfo

		Public Sub New(ByVal ribbon As RibbonControl)
			MyBase.New(ribbon)
		End Sub
		Protected Overrides Function CreateGroupLayoutCalculator(ByVal pageInfo As RibbonPageGroupViewInfo) As RibbonPageGroupLayoutCalculator
			Return New RibbonPageGroupComplexLayoutCalculatorDescendant(pageInfo)
		End Function
	End Class
End Namespace
