Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms

Public Class printpreview

    Sub LoadReport()
        Dim con As MySqlConnection = Connection.GetConnection
        Dim rptDs As ReportDataSource
        Me.ReportViewer1.RefreshReport()

        Try
            With ReportViewer1.LocalReport
                .ReportPath = Application.StartupPath & "\Reports\Report1.rdlc"
                .DataSources.Clear()
            End With

            Dim ds As New DataSet1
            Dim da As New MySqlDataAdapter

            con.Open()

            ' Use a parameterized query to prevent SQL injection
            Dim query As String = "SELECT RecNo, Stud_Id, name, gender, course, DateStamp, Time_In FROM vwallattendance WHERE date(DateStamp) BETWEEN @FromDate AND @ToDate AND (name LIKE @SearchTerm OR course LIKE @SearchTerm OR Stud_Id LIKE @SearchTerm OR gender LIKE @SearchTerm)"
            da.SelectCommand = New MySqlCommand(query, con)

            ' Add parameters to the query
            da.SelectCommand.Parameters.AddWithValue("@FromDate", dtp_from.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand.Parameters.AddWithValue("@ToDate", dtp_to.Value.ToString("yyyy-MM-dd"))
            da.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" & txt_dailysalessearch.Text & "%")

            da.Fill(ds.Tables("dt_report"))
            con.Close()

            rptDs = New ReportDataSource("DataSet1", ds.Tables("dt_report"))
            ReportViewer1.LocalReport.DataSources.Add(rptDs)
            ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
            ReportViewer1.ZoomMode = ZoomMode.Percent
            ReportViewer1.ZoomPercent = 75
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub printpreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadReport()
    End Sub

    Private Sub dtp_from_ValueChanged(sender As Object, e As EventArgs) Handles dtp_from.ValueChanged
        LoadReport()
    End Sub

    Private Sub dtp_to_ValueChanged(sender As Object, e As EventArgs) Handles dtp_to.ValueChanged
        LoadReport()
    End Sub

    Private Sub txt_dailysalessearch_TextChanged(sender As Object, e As EventArgs) Handles txt_dailysalessearch.TextChanged
        LoadReport()
    End Sub
End Class