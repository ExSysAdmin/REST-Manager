Imports System.IO
Imports Newtonsoft.Json

Public Class JsonHelper

    Public Shared Function GetJsonProperties(ByVal Json As String) As Dictionary(Of String, Type)
        Dim Props As Dictionary(Of String, Type) = New Dictionary(Of String, Type)

        Dim StartObjectCount As Int32 = 0
        Dim EndObjectCount As Int32 = 0

        Dim CurrentPropertyName As String = ""
        'Dim CurrentType0 As String = ""
        'Dim CurrentType1 As String = ""

        Dim CurrentType As Type = Nothing



        Dim reader As JsonTextReader = New JsonTextReader(New StringReader(Json))




        While (reader.Read())
            If (StartObjectCount > 0) AndAlso (StartObjectCount = EndObjectCount) Then
                Exit While
            Else
                Select Case (reader.TokenType)

                    Case JsonToken.StartObject
                        StartObjectCount += 1
                    Case JsonToken.EndObject
                        EndObjectCount += 1

                    Case JsonToken.PropertyName
                        CurrentPropertyName = reader.Value

                    Case JsonToken.StartArray
                    Case JsonToken.EndArray

                    Case JsonToken.StartConstructor
                    Case JsonToken.EndConstructor

                    Case JsonToken.Boolean
                        CurrentType = GetType(Boolean)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.Bytes
                        CurrentType = GetType(Byte)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.Comment
                        CurrentType = GetType(String)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.Date
                        CurrentType = GetType(Date)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.Float
                        CurrentType = GetType(Decimal)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.Integer
                        CurrentType = GetType(Integer)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.String
                        CurrentType = GetType(String)
                        Props.Add(CurrentPropertyName, CurrentType)
                        CurrentPropertyName = ""
                        CurrentType = Nothing

                    Case JsonToken.None
                    Case JsonToken.Null
                    Case JsonToken.Raw
                    Case JsonToken.Undefined
                End Select
            End If

        End While













        Return Props
    End Function

End Class
