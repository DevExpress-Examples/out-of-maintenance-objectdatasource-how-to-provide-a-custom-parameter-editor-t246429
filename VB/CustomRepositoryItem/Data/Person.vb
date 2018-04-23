Imports System
Imports System.ComponentModel
Imports System.Globalization
' ...

Namespace CustomRepositoryItem.Data
'''      
'''     * This is the class, for which a custom repository item is implemented in this example.
'''     *
'''     * The type converter is required to serialize parameter values to CodeDOM 
'''     * When an instance of the Person class is used as a custom parameter,  
'''     * it is converted to a string using this type converter and saved to 
'''     * the ValueInfo property. Accordingly, on deserialization this type converter 
'''     * is used to restore an original value from the stored string.
'''     *  
'''     * The ToString() method is used to display the Parameters property of an object 
'''     * data source in the property grid. For example, it can look like this:
'''     *     Parameters : customer = John Jackson
'''     * Here 'customer' is the name of a parameter and 'John Jackson' represents its value 
'''     * and is converted from it using the ToString() method.
'''     *  
'''     * The Equals(...) method is called from CustomRepositoryItem.Data.FilterByCustomer(...)
'''     * and is not necessary to be implemented in a general case.
'''     
    <TypeConverter(GetType(PersonConverter))> _
    Public Class Person
        Public Property FirstName() As String
        Public Property LastName() As String
#Region "Overrides of Object"

        Public Overrides Function Equals(ByVal obj As Object) As Boolean
            If ReferenceEquals(Me, obj) Then
                Return True
            End If
            If obj Is Nothing OrElse obj.GetType() IsNot Me.GetType() Then
                Return False
            End If
            Dim other As Person = DirectCast(obj, Person)
            Return String.Equals(FirstName, other.FirstName) AndAlso String.Equals(LastName, other.LastName)
        End Function
        Public Overrides Function ToString() As String
            Return String.Format("{0} {1}", FirstName, LastName)
        End Function

        Public Overrides Function GetHashCode() As Integer
            Return (If(FirstName Is Nothing, 0, FirstName.GetHashCode())) Xor (If(LastName Is Nothing, 0, LastName.GetHashCode()))
        End Function
#End Region
    End Class
End Namespace
