<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616279/12.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4315)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Ribbon - Display bar items in different locations within Ribbon page groups

This example creates a custom Ribbon control.

![WinForms Ribbon - Change the location of bar items within a Ribbon page group](https://raw.githubusercontent.com/DevExpress-Examples/how-to-change-the-location-of-bar-items-within-a-ribbon-page-group-e4315/12.1.7+/media/39cb19f8-b1fb-4fba-8f4a-3bd267db8249.png)

The example also creates a `BarItemExtender` component that allows you to specify the location of a bar item. This component implements [IExtenderProvider](https://learn.microsoft.com/ru-ru/dotnet/api/system.componentmodel.iextenderprovider?view=net-7.0&redirectedfrom=MSDN). Assign this component to the Ribbon control's `RibbonControlDescendant.BarItemExtender` property.


## Files to Review

* [BarItemExtender.cs](./CS/CustomRibbonControl/BarItemExtender.cs) (VB: [BarItemExtender.vb](./VB/CustomRibbonControl/BarItemExtender.vb))
* [Form1.cs](./CS/CustomRibbonControl/Form1.cs) (VB: [Form1.vb](./VB/CustomRibbonControl/Form1.vb))
* [RibbonControlDescendant.cs](./CS/CustomRibbonControl/RibbonControlDescendant.cs) (VB: [RibbonControlDescendant.vb](./VB/CustomRibbonControl/RibbonControlDescendant.vb))
* [RibbonPageGroupComplexLayoutCalculatorDescendant.cs](./CS/CustomRibbonControl/RibbonPageGroupComplexLayoutCalculatorDescendant.cs) (VB: [RibbonPageGroupComplexLayoutCalculatorDescendant.vb](./VB/CustomRibbonControl/RibbonPageGroupComplexLayoutCalculatorDescendant.vb))
* [RibbonViewInfoDescendant.cs](./CS/CustomRibbonControl/RibbonViewInfoDescendant.cs) (VB: [RibbonViewInfoDescendant.vb](./VB/CustomRibbonControl/RibbonViewInfoDescendant.vb))
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-ribbon-customize-bar-items-location-in-page-group&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-ribbon-customize-bar-items-location-in-page-group&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
