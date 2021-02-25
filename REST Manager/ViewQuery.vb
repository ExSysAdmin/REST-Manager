Public Class ViewQuery

    Public RESTQuery As String = ""

    Private Sub ViewQuery_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = RESTQuery
    End Sub
End Class