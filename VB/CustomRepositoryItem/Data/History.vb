' Developer Express Code Central Example:
' ObjectDataSource - How to provide a custom parameter editor.
' 
' This example illustrates how to provide an End-User Report Designer with a
' custom editor for editting the value of a parameter passed to a member of an
' ObjectDataSource (in this case the custom parameter editor is a dropdown list
' with two columns). To achieve this functionality, substitute the report
' designer's repository items provider with a custom one.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=T246429

Imports System
Imports System.Collections.Generic
Imports DevExpress.DataAccess.ObjectBinding
' ...

Namespace CustomRepositoryItem.Data
    '''    
    '''     * This is a type to which an object data source is bound.
    '''     * 
    '''     * The 'public' access modifier is required to serialize the object data source to *.repx.
    '''     * Setting the [HighlightedClass] attribute highlightes a class in the Object Data Source wizard.
    '''     
    <HighlightedClass()> _
    Public NotInheritable Class History

        Private Sub New()
        End Sub
        Private Shared Data As List(Of Deal)

        Shared Sub New()
            Dim mrJohnDoe As Person = New Person With {.FirstName = "John", .LastName = "Doe"}
            Dim mrJohnJackson As Person = New Person With {.FirstName = "John", .LastName = "Jackson"}
            Dim mrJackJohnson As Person = New Person With {.FirstName = "Jack", .LastName = "Johnson"}

            Data = New List(Of Deal)()
            Data.AddRange({ _
                New Deal With {.Seller = mrJohnDoe, .Customer = mrJohnJackson, .Time = Date.Now.AddDays(-1)}, _
                New Deal With {.Seller = mrJohnDoe, .Customer = mrJackJohnson, .Time = Date.Now.AddDays(-2)} _
            })
        End Sub

        Public Shared Function GetAll() As IEnumerable(Of Deal)
            Return Data
        End Function

        Public Shared Function FilterByCustomer(ByVal customer As Person) As IEnumerable(Of Deal)
            Return Data.Where(Function(deal) deal.Customer.Equals(customer))
        End Function
    End Class
End Namespace
