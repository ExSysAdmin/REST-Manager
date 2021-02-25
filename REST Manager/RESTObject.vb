Imports System.Xml.Serialization

Public Class RESTObject

    Sub New()
        Id = Guid.NewGuid().ToString().Replace("-", "")
    End Sub

    Public Property Id As String

    Public Property Name As String

    Public Property Description As String

    Public Property URI As String

    Public Property Method As String

    Public Property Headers As List(Of RESTParameter)

    Public Property Parameters As List(Of RESTParameter)

End Class



<Serializable>
Public Class RESTParameter

    Sub New()
        Id = Guid.NewGuid().ToString().Replace("-", "")
    End Sub

    Public Property Id As String

    Public Property Required As Boolean

    Public Property RequireUserInput As Boolean

    Public Property ParameterName As String

    Public Property ParameterValueType As String

    Public Property ParameterValue As String

End Class