<!-- default file list -->
*Files to look at*:

* [Deal.cs](./CS/CustomRepositoryItem/Data/Deal.cs) (VB: [Deal.vb](./VB/CustomRepositoryItem/Data/Deal.vb))
* [History.cs](./CS/CustomRepositoryItem/Data/History.cs) (VB: [History.vb](./VB/CustomRepositoryItem/Data/History.vb))
* [Person.cs](./CS/CustomRepositoryItem/Data/Person.cs) (VB: [PersonConverter.vb](./VB/CustomRepositoryItem/Data/PersonConverter.vb))
* [fmDesigner.cs](./CS/CustomRepositoryItem/fmDesigner.cs) (VB: [fmDesigner.vb](./VB/CustomRepositoryItem/fmDesigner.vb))
* [MyRepositoryItemsProvider.cs](./CS/CustomRepositoryItem/MyRepositoryItemsProvider.cs) (VB: [MyRepositoryItemsProvider.vb](./VB/CustomRepositoryItem/MyRepositoryItemsProvider.vb))
* [XtraReport1.cs](./CS/CustomRepositoryItem/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/CustomRepositoryItem/XtraReport1.vb))
<!-- default file list end -->
# ObjectDataSource - How to provide a custom parameter editor.


<p>This example illustrates how to provide an End-User Report Designer with a custom editor for editing a value of a parameter passed to a member of an ObjectDataSource. To achieve this functionality, substitute the report designer's repository items provider service with a custom one.</p>
<p> In this example, a custom repository items provider extends the <strong>DevExpress.DataAccess.UI.Wizard.Services.DefaultRepositoryItemsProvider</strong> class and overrides its <strong>GetRepositoryItem</strong> method to dispatch a custom editor for a parameter of a custom <strong>Person</strong> type.</p>
<p> To view the result, run the application. Next, in the End-User Report Designer's Report Explorer select <strong>objectDataSource1</strong> and click the ellipse button for its <strong>Parameters</strong> property in the <strong>Property Grid</strong>. In the invoked <strong>Configure Parameters</strong> dialog, you will see the <strong>Customer</strong> parameter of the type <strong>Person</strong>. To view the custom lookup edit control used to edit this parameter, click the parameter's <strong>Value </strong>property.</p>

<br/>


