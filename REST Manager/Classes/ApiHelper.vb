Public Class RestAPITemplate

    Public Sub New()
        TemplateId = Guid.NewGuid().ToString().Replace("-", "")
    End Sub

    <System.Xml.Serialization.XmlAttributeAttribute()>
    Public Property TemplateId As String

    <System.Xml.Serialization.XmlElement([ElementName]:="TemplateName")>
    Public Property TemplateName As String
    <System.Xml.Serialization.XmlElement([ElementName]:="Version")>
    Public Property Version As String
    <System.Xml.Serialization.XmlElement([ElementName]:="Description")>
    Public Property Description As String


End Class


Public Class RESTAPIMethod
    Sub New()
        RESTAPIMethodId = Guid.NewGuid().ToString().Replace("-", "")
        Headers = New List(Of RESTParameters.Parameter)
        Parameters = New List(Of RESTParameters.Parameter)
    End Sub

    Public Property RESTAPIMethodId As String
    Public Property MethodType As String
    Public Property EndpointURI As String
    Public Property Headers As List(Of RESTParameters.Parameter)
    Public Property Parameters As List(Of RESTParameters.Parameter)

End Class







