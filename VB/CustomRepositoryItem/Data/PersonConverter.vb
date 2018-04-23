Imports System
Imports System.ComponentModel
Imports System.Globalization
' ...

Namespace CustomRepositoryItem.Data
    Public Class PersonConverter
        Inherits TypeConverter

#Region "Overrides of TypeConverter"

        Public Overrides Function CanConvertFrom(ByVal context As ITypeDescriptorContext, ByVal sourceType As Type) As Boolean
            If sourceType Is GetType(String) Then
                Return True
            End If
            Return MyBase.CanConvertFrom(context, sourceType)
        End Function

        Public Overrides Function CanConvertTo(ByVal context As ITypeDescriptorContext, ByVal destinationType As Type) As Boolean
            If destinationType Is GetType(String) Then
                Return True
            End If
            Return MyBase.CanConvertTo(context, destinationType)
        End Function

        Public Overrides Function ConvertFrom(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object) As Object
            Dim str As String = TryCast(value, String)
            If str IsNot Nothing Then
                Dim parts() As String = str.Split("|"c)
                If parts.Length = 2 Then
                    Return New Person With {.FirstName = parts(0), .LastName = parts(1)}
                End If
            End If
            Return MyBase.ConvertFrom(context, culture, value)
        End Function

        Public Overrides Function ConvertTo(ByVal context As ITypeDescriptorContext, ByVal culture As CultureInfo, ByVal value As Object, ByVal destinationType As Type) As Object
            If destinationType Is GetType(String) Then
                Dim person As Person = DirectCast(value, Person)
                Return If(value Is Nothing, Nothing, String.Format("{0}|{1}", person.FirstName, person.LastName))
            End If
            Return MyBase.ConvertTo(context, culture, value, destinationType)
        End Function
#End Region
    End Class
End Namespace
