# ObjectDataSource - How to provide a custom parameter editor.


<p>This example illustrates how to provide an End-User Report Designer with a custom editor for editing a value of a parameter passed to a member of an ObjectDataSource. To achieve this functionality, substitute the report designer's repository items provider service with a custom one.</p>
<p> In this example, a custom repository items provider extends the <strong>DevExpress.DataAccess.UI.Wizard.Services.DefaultRepositoryItemsProvider</strong> class and overrides its <strong>GetRepositoryItem</strong> method to dispatch a custom editor for a parameter of a custom <strong>Person</strong> type.</p>
<p> To view the result, run the application. Next, in the End-User Report Designer's Report Explorer select <strong>objectDataSource1</strong> and click the ellipse button for its <strong>Parameters</strong> property in the <strong>Property Grid</strong>. In the invoked <strong>Configure Parameters</strong> dialog, you will see the <strong>Customer</strong> parameter of the type <strong>Person</strong>. To view the custom lookup edit control used to edit this parameter, click the parameter's <strong>Value </strong>property.</p>

<br/>


