Imports System.IO
Imports System.Net
Imports System.Text
Imports Newtonsoft.Json

Public Class RESTManagerForm

    Public Property Parameters As List(Of KeyValuePair(Of String, String)) = New List(Of KeyValuePair(Of String, String))




    Private Sub RESTManagerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeListViewColumns()
    End Sub

    Sub ResizeListViewColumns()
        Try
            QASHeaderListView.Columns(0).Width = Convert.ToInt32((QASHeaderListView.Width / 2) - 20)
            QASHeaderListView.Columns(1).Width = Convert.ToInt32(QASHeaderListView.Width / 2)
            QASParameterListView.Columns(0).Width = Convert.ToInt32((QASParameterListView.Width / 2) - 20)
            QASParameterListView.Columns(1).Width = Convert.ToInt32(QASParameterListView.Width / 2)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RESTManagerForm_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        ResizeListViewColumns()
    End Sub




    Private Sub QASAHBtn_Click(sender As Object, e As EventArgs) Handles QASAHBtn.Click
        Dim PF As New ParameterForm
        PF.Text = "Add Header"
        If PF.ShowDialog() = DialogResult.OK Then
            Dim NewRow As ListViewItem = QASHeaderListView.Items.Add(PF.ParameterName)
            NewRow.SubItems.Add(PF.ParameterValue)
        End If
    End Sub

    Private Sub QASAPBtn_Click(sender As Object, e As EventArgs) Handles QASAPBtn.Click
        Dim PF As New ParameterForm
        PF.Text = "Add Parameter"
        If PF.ShowDialog() = DialogResult.OK Then
            Dim NewRow As ListViewItem = QASParameterListView.Items.Add(PF.ParameterName)
            NewRow.SubItems.Add(PF.ParameterValue)
            Parameters.Add(New KeyValuePair(Of String, String)(PF.ParameterName, PF.ParameterValue))
        End If
    End Sub

    Private Sub QASMHBtn_Click(sender As Object, e As EventArgs) Handles QASMHBtn.Click
        Try
            Dim SelectedItem As ListViewItem = QASHeaderListView.SelectedItems(0)
            Dim PF As New ParameterForm
            PF.Text = "Modify Header"
            PF.ParameterName = SelectedItem.Text
            PF.ParameterValue = SelectedItem.SubItems.Item(1).Text
            If PF.ShowDialog() = DialogResult.OK Then
                SelectedItem.Text = PF.ParameterName
                SelectedItem.SubItems.Item(1).Text = PF.ParameterValue
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub QASMPBtn_Click(sender As Object, e As EventArgs) Handles QASMPBtn.Click
        Try
            Dim SelectedItem As ListViewItem = QASParameterListView.SelectedItems(0)
            Dim PF As New ParameterForm
            PF.Text = "Modify Parameter"
            PF.ParameterName = SelectedItem.Text
            PF.ParameterValue = SelectedItem.SubItems.Item(1).Text
            If PF.ShowDialog() = DialogResult.OK Then
                SelectedItem.Text = PF.ParameterName
                SelectedItem.SubItems.Item(1).Text = PF.ParameterValue
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub QASDHBtn_Click(sender As Object, e As EventArgs) Handles QASDHBtn.Click
        Try
            Dim SelectedItem As ListViewItem = QASHeaderListView.SelectedItems(0)
            Dim PropertyName As String = SelectedItem.Text
            If MsgBox("Are you sure you want to delete Header: " & PropertyName & "?", MsgBoxStyle.YesNoCancel, "Delete Header") = MsgBoxResult.Yes Then
                QASHeaderListView.Items.Remove(SelectedItem)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub QASDPBtn_Click(sender As Object, e As EventArgs) Handles QASDPBtn.Click
        Try
            Dim SelectedItem As ListViewItem = QASParameterListView.SelectedItems(0)
            Dim PropertyName As String = SelectedItem.Text
            If MsgBox("Are you sure you want to delete Parameter: " & PropertyName & "?", MsgBoxStyle.YesNoCancel, "Delete Parameter") = MsgBoxResult.Yes Then
                QASParameterListView.Items.Remove(SelectedItem)
            End If
        Catch ex As Exception

        End Try
    End Sub











    Private Sub QASHeaderListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles QASHeaderListView.ItemSelectionChanged
        If QASHeaderListView.SelectedItems.Count > 0 Then
            QASMHBtn.Enabled = True
            QASDHBtn.Enabled = True
        Else
            QASMHBtn.Enabled = False
            QASDHBtn.Enabled = False
        End If
    End Sub

    Private Sub QASParameterListView_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles QASParameterListView.ItemSelectionChanged
        If QASParameterListView.SelectedItems.Count > 0 Then
            QASMPBtn.Enabled = True
            QASDPBtn.Enabled = True
        Else
            QASMPBtn.Enabled = False
            QASDPBtn.Enabled = False
        End If
    End Sub

    Function BuildQuery() As String
        Dim Query As String = ""

        If QASURITextBox.Text.Trim() <> "" Then
            Query = QASURITextBox.Text.Trim()
        End If


        'Dim JsonData As String = JsonConvert.SerializeObject(Parameters)
        ' Dim RestContent As New Http.StringContent(JsonData, Encoding.UTF8, "application/json")
        'Query = JsonData
        'Dim myReq As HttpWebRequest
        'Dim myResp As HttpWebResponse
        'Dim myReader As StreamReader
        'myReq = HttpWebRequest.Create(QASURITextBox.Text)
        'myReq.Method = "GET"
        'myReq.ContentType = "application/json"
        'myReq.Accept = "application/json"
        'For Each HeaderItem As ListViewItem In QASHeaderListView.Items
        'Dim aHeaderName As String = HeaderItem.Text
        'Dim aHeaderValue As String = HeaderItem.SubItems.Item(1).Text
        'myReq.Headers.Add(aHeaderName, aHeaderValue)
        'Next
        'Query = myReq.Address.PathAndQuery
        'Dim myData As String = "{""riskLevelStatus"":""0001"",""userId"":""10000004030"",""applicationName"":""MyTestRESTAPI""}"
        'myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
        'myResp = myReq.GetResponse
        'myReader = New System.IO.StreamReader(myResp.GetResponseStream)
        'TextBox1.Text = myReader.ReadToEnd

        Dim cQuery As String = ""
        For Each ParameterItem As ListViewItem In QASParameterListView.Items
            Dim aHeaderName As String = ParameterItem.Text
            Dim aHeaderValue As String = ParameterItem.SubItems.Item(1).Text
            If InStr(aHeaderValue, " ") Then
                aHeaderValue = aHeaderValue.Replace(" ", "%20")
            End If
            If cQuery = "" Then
                cQuery = "?" & aHeaderName & "=" & aHeaderValue
            Else
                cQuery = cQuery & "&" & aHeaderName & "=" & aHeaderValue
            End If
        Next

        If Not Query.EndsWith("/") AndAlso cQuery <> "" Then
            Query = Query & cQuery
        End If

        Return Query
    End Function






    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim VQ As New ViewQuery
        VQ.RESTQuery = BuildQuery()
        VQ.ShowDialog()
    End Sub

    Private Sub QASRunQueryBtn_Click(sender As Object, e As EventArgs) Handles QASRunQueryBtn.Click
        Dim QueryURI As String = ""
        QueryURI = BuildQuery()

        If QueryURI <> "" Then
            Try
                Dim EndPointURI As String = QueryURI
                Dim myReq As HttpWebRequest
                Dim myResp As HttpWebResponse
                Dim myReader As StreamReader
                Dim JsonReturnString As String = ""







                myReq = HttpWebRequest.Create(EndPointURI)
                myReq.Method = "GET"
                myReq.ContentType = "application/json"
                myReq.Accept = "application/json"
                'Dim myData As String = "{""riskLevelStatus"":""0001"",""userId"":""10000004030"",""applicationName"":""MyTestRESTAPI""}"
                'myReq.GetRequestStream.Write(System.Text.Encoding.UTF8.GetBytes(myData), 0, System.Text.Encoding.UTF8.GetBytes(myData).Count)
                myResp = myReq.GetResponse
                myReader = New System.IO.StreamReader(myResp.GetResponseStream)
                JsonReturnString = myReader.ReadToEnd





                Try
                    Dim Props As Dictionary(Of String, Type) = JsonHelper.GetJsonProperties(JsonReturnString)
                    For Each Prop As KeyValuePair(Of String, Type) In Props
                        RawDataTextBox.Text = RawDataTextBox.Text & Prop.Key.ToString() & vbTab & Prop.Value.Name & vbCrLf
                    Next
                Catch ex As Exception

                End Try

                RawDataTextBox.Text = JsonReturnString

                Dim ds As DataTable = Nothing


                Try
                    ds = JsonConvert.DeserializeObject(Of DataTable)(JsonReturnString)

                    If ds.Rows.Count > 0 Then
                        'For i = 0 To (ds.Tables.Count - 1)
                        'If ds.Tables(i).Rows.Count > 0 Then
                        TableDataGridView.DataSource = ds
                        TableDataGridView.Update()
                        'Exit For
                        'End If
                        'Next
                    End If

                Catch ex As Exception
                    ToolStripStatusLabel1.Text = ex.Message
                End Try
            Catch ex As Exception

            End Try
        End If
    End Sub



    Sub ShowPane(ByVal a As Int32)
        ResponseViewLayoutPanel.Visible = False
        For i = 0 To (ResponseViewLayoutPanel.ColumnStyles.Count - 1)
            ' /// Close Other Panels ///
            ResponseViewLayoutPanel.ColumnStyles(i).SizeType = SizeType.Absolute
            ResponseViewLayoutPanel.ColumnStyles(i).Width = 0
        Next
        ResponseViewLayoutPanel.ColumnStyles(a).SizeType = SizeType.Percent
        ResponseViewLayoutPanel.ColumnStyles(a).Width = 100
        Me.Refresh()
        ResponseViewLayoutPanel.Visible = True
        Me.Update()
    End Sub





    Private Sub QASTableBtn_Click(sender As Object, e As EventArgs) Handles QASTableBtn.Click
        ShowPane(0)
    End Sub

    Private Sub QASDesignBtn_Click(sender As Object, e As EventArgs) Handles QASDesignBtn.Click
        ShowPane(1)
    End Sub

    Private Sub QASRawDataBtn_Click(sender As Object, e As EventArgs) Handles QASRawDataBtn.Click
        ShowPane(2)
    End Sub

    Private Sub QASLogBtn_Click(sender As Object, e As EventArgs) Handles QASLogBtn.Click
        ShowPane(3)
    End Sub

    Private Sub AllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllToolStripMenuItem.Click
        QASURITextBox.Text = ""
        QASHeaderListView.Items.Clear()
        QASParameterListView.Items.Clear()
        TableDataGridView.DataSource = Nothing
        TableDataGridView.Update()
        RawDataTextBox.Text = ""
    End Sub

    Private Sub RequestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RequestToolStripMenuItem.Click
        QASURITextBox.Text = ""
        QASHeaderListView.Items.Clear()
        QASParameterListView.Items.Clear()
    End Sub

    Private Sub ResponseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResponseToolStripMenuItem.Click
        TableDataGridView.DataSource = Nothing
        TableDataGridView.Update()
        RawDataTextBox.Text = ""
    End Sub
End Class
