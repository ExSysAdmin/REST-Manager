Public Class RESTParameters

#Region "Parameter Definitions"
    Partial Public Class Parameter
        Public Sub New()
            Id = Guid.NewGuid().ToString().Replace("-", "")
            Key = New Key()
            Value = New Value()
        End Sub
        <System.Xml.Serialization.XmlAttributeAttribute()>
        Public Property Id As String
        Public Property Key As Key
        Public Property Value As Value
    End Class


    Public Class Key
        <System.Xml.Serialization.XmlText>
        Public Property Key As String

        <System.Xml.Serialization.XmlAttributeAttribute>
        Public Property IsRequired As Boolean = False

    End Class

    Public Class Value
        <System.Xml.Serialization.XmlText>
        Public Property Value As String

        <System.Xml.Serialization.XmlAttributeAttribute>
        Public Property ValueType As String

        <System.Xml.Serialization.XmlAttributeAttribute>
        Public Property UserSuppliedValue As Boolean = False

    End Class

#End Region


End Class
