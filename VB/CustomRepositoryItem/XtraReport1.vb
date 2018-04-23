Imports CustomRepositoryItem.Data
Imports DevExpress.DataAccess.ObjectBinding
' ...

Namespace CustomRepositoryItem
    Partial Public Class XtraReport1
        Inherits DevExpress.XtraReports.UI.XtraReport

        Public Sub New()
            InitializeComponent()
'''            
'''             * In this example the Object Data Source’s DataMember property is initially set to "GetAll" 
'''             * so that the report data is visible in the Visual Studio print preview.
'''             * 
'''             * The FilterByCustomer method is not used at design time because it requires a
'''             * parameter that cannot be edited since it is impossible to provide a custom
'''             * repository item at design time within Visual Studio. To provide the required 
'''             * data binding at runtime, manually substitute a data member and initialize 
'''             * a parameter using API.
'''             
            objectDataSource1.BeginUpdate()
            objectDataSource1.DataMember = "FilterByCustomer"
            objectDataSource1.Parameters.Clear()
            objectDataSource1.Parameters.Add(New Parameter("customer", GetType(Person), New Person With {.FirstName = "Jack", .LastName = "Johnson"}))
            objectDataSource1.EndUpdate()
        End Sub

    End Class
End Namespace
