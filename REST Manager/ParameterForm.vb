Public Class ParameterForm
    Public ParameterName As String = ""
    Public ParameterValue As String = ""



    Private Sub ParameterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ParameterName
        TextBox2.Text = ParameterValue
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text.Trim() <> "" Then
            ParameterName = TextBox1.Text
            ParameterValue = TextBox2.Text
            Me.DialogResult = DialogResult.OK
            Me.Close()
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class