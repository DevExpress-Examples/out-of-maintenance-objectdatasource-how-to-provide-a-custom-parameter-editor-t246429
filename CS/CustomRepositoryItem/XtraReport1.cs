using CustomRepositoryItem.Data;
using DevExpress.DataAccess.ObjectBinding;
// ...

namespace CustomRepositoryItem {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        public XtraReport1() {
            InitializeComponent();
            /**
             * In this example the Object Data Source’s DataMember property is initially set to “GetAll” 
             * so that the report data is visible in the Visual Studio print preview.
             * 
             * The FilterByCustomer method is not used at design time because it requires a
             * parameter that cannot be edited since it is impossible to provide a custom
             * repository item at design time within Visual Studio. To provide the required 
             * data binding at runtime, manually substitute a data member and initialize 
             * a parameter using API.
             */
            objectDataSource1.BeginUpdate();
            objectDataSource1.DataMember = "FilterByCustomer";
            objectDataSource1.Parameters.Clear();
            objectDataSource1.Parameters.Add(new Parameter("customer", typeof(Person), new Person { FirstName = "Jack", LastName = "Johnson" }));
            objectDataSource1.EndUpdate();
        }

    }
}
