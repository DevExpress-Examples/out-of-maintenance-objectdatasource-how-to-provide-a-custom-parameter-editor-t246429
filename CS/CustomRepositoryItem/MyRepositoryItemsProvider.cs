using System;
using System.Linq;
using CustomRepositoryItem.Data;
using CustomRepositoryItem.Properties;
using DevExpress.DataAccess.UI.Wizard.Services;
using DevExpress.Utils;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
// ...

namespace CustomRepositoryItem {
    class MyRepositoryItemsProvider : DefaultRepositoryItemsProvider {
        class Record {
            public Record(Person value) { Value = value; }

            public string FirstName {
                get { return Value.FirstName; }
                set { this.Value = new Person { FirstName = value, LastName = this.Value.LastName }; }
            }

            public string LastName {
                get { return Value.LastName; }
                set { this.Value = new Person { FirstName = this.Value.FirstName, LastName = value }; }
            }

            public string FullName { get { return Value.ToString(); } }

            public Person Value { get; set; }
        }

        readonly RepositoryItemGridLookUpEdit lookUpEdit;

        public MyRepositoryItemsProvider() {
            lookUpEdit = new RepositoryItemGridLookUpEdit();
            lookUpEdit.View.OptionsBehavior.AutoPopulateColumns = false;
            lookUpEdit.DataSource = History.GetAll().Select(deal => new Record(deal.Customer)).ToList();
            lookUpEdit.DisplayMember = "FullName";
            lookUpEdit.ValueMember = "Value";
            lookUpEdit.NullText = Resources.MyRepositoryItemsProvider_GetRepositoryItem_Nobody;
            lookUpEdit.AllowNullInput = DefaultBoolean.True;

            GridColumn col1 = lookUpEdit.View.Columns.AddField("FirstName");
            col1.VisibleIndex = 0;
            col1.Caption = Resources.MyRepositoryItemsProvider_GetRepositoryItem_First_Name;

            GridColumn col2 = lookUpEdit.View.Columns.AddField("LastName");
            col2.VisibleIndex = 1;
            col2.Caption = Resources.MyRepositoryItemsProvider_GetRepositoryItem_Last_Name;

            lookUpEdit.View.BestFitColumns();
        }

        #region Overrides of DefaultRepositoryItemsProvider

        public override RepositoryItem GetRepositoryItem(Type type) {
            return type == typeof(Person) ? lookUpEdit : base.GetRepositoryItem(type);
        }

        #endregion
    }
}
