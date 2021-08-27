<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616279/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [BarItemExtender.cs](./CS/CustomRibbonControl/BarItemExtender.cs) (VB: [BarItemExtender.vb](./VB/CustomRibbonControl/BarItemExtender.vb))
* [Form1.cs](./CS/CustomRibbonControl/Form1.cs) (VB: [Form1.vb](./VB/CustomRibbonControl/Form1.vb))
* [Program.cs](./CS/CustomRibbonControl/Program.cs) (VB: [Program.vb](./VB/CustomRibbonControl/Program.vb))
* [RibbonControlDescendant.cs](./CS/CustomRibbonControl/RibbonControlDescendant.cs) (VB: [RibbonControlDescendant.vb](./VB/CustomRibbonControl/RibbonControlDescendant.vb))
* [RibbonPageGroupComplexLayoutCalculatorDescendant.cs](./CS/CustomRibbonControl/RibbonPageGroupComplexLayoutCalculatorDescendant.cs) (VB: [RibbonPageGroupComplexLayoutCalculatorDescendant.vb](./VB/CustomRibbonControl/RibbonPageGroupComplexLayoutCalculatorDescendant.vb))
* [RibbonViewInfoDescendant.cs](./CS/CustomRibbonControl/RibbonViewInfoDescendant.cs) (VB: [RibbonViewInfoDescendant.vb](./VB/CustomRibbonControl/RibbonViewInfoDescendant.vb))
<!-- default file list end -->
# How to change the location of bar items within a Ribbon page group


<p>This example shows how to change the location of bar items within a Ribbon page group. For this, we have created a custom RibbonControl.<br />
</p><p>To provide the capability to determine a <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarItemMembersTopicAll"><u>BarItem</u></a> location, we have created a special <strong>BarItemExtender </strong>component that implements the <a href="http://msdn.microsoft.com/ru-ru/library/system.componentmodel.iextenderprovider.aspx"><u>IExtenderProvider</u></a> interface. Thus, you can set the BarItem location at design time. That is, any BarItem will have a new location in the <strong>BarItemExtender </strong>property if you place the <strong>BarItemExtender </strong>component onto the form.</p><p>To make a custom RibbonControl take the <strong>Location </strong>option into account, set the <strong>RibbonControlDescendant.BarItemExtender</strong> property to the <strong>BarItemExtender </strong>component located on your form.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-change-the-location-of-bar-items-within-a-ribbon-page-group-e4315/12.1.7+/media/39cb19f8-b1fb-4fba-8f4a-3bd267db8249.png"></p>

<br/>


