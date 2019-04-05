<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/MainWindow.xaml.vb))
<!-- default file list end -->
# How to: Customize the Way Properties Are Displayed and Edited in XAML


<p>This example demonstrates how to customize displayed properties in XAML by adding the required<a href="https://documentation.devexpress.com/#WPF/CustomDocument15521"> Property Definitions</a> and<a href="https://documentation.devexpress.com/#WPF/CustomDocument15719"> Collection Definitions</a> objects to the PropertyGridControl.</p>
<p>There are several properties you can use to map PropertyDefinition objects to properties:</p>
<p><a href="https://documentation.devexpress.com/#WPF/CustomDocument15521">Path</a> - the path to the property;</p>
<p><a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyDefinition_Scopetopic">Scope</a> - the path to the parent property;</p>
<p><a href="https://documentation.devexpress.com/WPF/DevExpressXpfPropertyGridPropertyDefinition_Typetopic.aspx">Type</a> - the type of the property.</p>
<p>To learn more on this functionality, refer to <a href="https://documentation.devexpress.com/#WPF/CustomDocument15521">Property Definitions</a>.</p>
<p> </p>
<p>Note that we have set the <a href="https://documentation.devexpress.com/#WPF/DevExpressXpfPropertyGridPropertyGridControl_ShowPropertiestopic">PropertyGridControl.ShowProperties</a> property to ‘WithPropertyDefinitions’ to show only properties for defined definitions. You can remove this setter to be able to see all object properties.</p>

<br/>


