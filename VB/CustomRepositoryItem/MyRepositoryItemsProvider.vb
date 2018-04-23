Imports System
Imports System.Linq
Imports CustomRepositoryItem.Data
Imports DevExpress.DataAccess.UI.Wizard.Services
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
' ...

Namespace CustomRepositoryItem
    Friend Class MyRepositoryItemsProvider
        Inherits DefaultRepositoryItemsProvider

        Private Class Record
            Public Sub New(ByVal value As Person)
                Me.Value = value
            End Sub

            Public Property FirstName() As String
                Get
                    Return Value.FirstName
                End Get
                Set(ByVal value As String)
                    Me.Value = New Person With {.FirstName = value, .LastName = Me.Value.LastName}
                End Set
            End Property

            Public Property LastName() As String
                Get
                    Return Value.LastName
                End Get
                Set(ByVal value As String)
                    Me.Value = New Person With {.FirstName = Me.Value.FirstName, .LastName = value}
                End Set
            End Property

            Public ReadOnly Property FullName() As String
                Get
                    Return Value.ToString()
                End Get
            End Property

            Public Property Value() As Person
        End Class

        Private ReadOnly lookUpEdit As RepositoryItemGridLookUpEdit

        Public Sub New()
            lookUpEdit = New RepositoryItemGridLookUpEdit()
            lookUpEdit.View.OptionsBehavior.AutoPopulateColumns = False
            lookUpEdit.DataSource = History.GetAll().Select(Function(deal) New Record(deal.Customer)).ToList()
            lookUpEdit.DisplayMember = "FullName"
            lookUpEdit.ValueMember = "Value"
            lookUpEdit.NullText = My.Resources.MyRepositoryItemsProvider_GetRepositoryItem_Nobody
            lookUpEdit.AllowNullInput = DefaultBoolean.True

            Dim col1 As GridColumn = lookUpEdit.View.Columns.AddField("FirstName")
            col1.VisibleIndex = 0
            col1.Caption = My.Resources.MyRepositoryItemsProvider_GetRepositoryItem_First_Name

            Dim col2 As GridColumn = lookUpEdit.View.Columns.AddField("LastName")
            col2.VisibleIndex = 1
            col2.Caption = My.Resources.MyRepositoryItemsProvider_GetRepositoryItem_Last_Name

            lookUpEdit.View.BestFitColumns()
        End Sub

        #Region "Overrides of DefaultRepositoryItemsProvider"

        Public Overrides Function GetRepositoryItem(ByVal type As Type) As RepositoryItem
            Return If(type Is GetType(Person), lookUpEdit, MyBase.GetRepositoryItem(type))
        End Function

        #End Region
    End Class
End Namespace
