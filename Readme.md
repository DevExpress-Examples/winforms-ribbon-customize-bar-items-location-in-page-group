# How to change the location of bar items within a Ribbon page group


<p>This example shows how to change the location of bar items within a Ribbon page group. For this, we have created a custom RibbonControl.<br />
</p><p>To provide the capability to determine a <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsBarItemMembersTopicAll"><u>BarItem</u></a> location, we have created a special <strong>BarItemExtender </strong>component that implements the <a href="http://msdn.microsoft.com/ru-ru/library/system.componentmodel.iextenderprovider.aspx"><u>IExtenderProvider</u></a> interface. Thus, you can set the BarItem location at design time. That is, any BarItem will have a new location in the <strong>BarItemExtender </strong>property if you place the <strong>BarItemExtender </strong>component onto the form.</p><p>To make a custom RibbonControl take the <strong>Location </strong>option into account, set the <strong>RibbonControlDescendant.BarItemExtender</strong> property to the <strong>BarItemExtender </strong>component located on your form.</p><p><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-change-the-location-of-bar-items-within-a-ribbon-page-group-e4315/12.1.7+/media/39cb19f8-b1fb-4fba-8f4a-3bd267db8249.png"></p>

<br/>


