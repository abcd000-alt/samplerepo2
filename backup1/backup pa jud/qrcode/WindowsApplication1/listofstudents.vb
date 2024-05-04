Imports MySql.Data.MySqlClient

Public Class listofstudents

    Private Sub listofstudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DailyReport()
    End Sub
    'Sub DailyReport()
    '    Dim con As MySqlConnection = Connection.GetConnection

    '    Try
    '        ' Clear existing rows and columns
    '        dgtv_dailysales.Rows.Clear()
    '        dgtv_dailysales.Columns.Clear()

    '        con.Open()
    '        'Dim total As Double
    '        Dim i As Integer

    '        'sdate1 = Now.ToString("yyy-MM-dd")
    '        'sdate2 = Now.ToString


    '        ' Assuming you have DataGridViewTextBoxColumn for each column
    '        dgtv_dailysales.Columns.Add("Column1", "RECORD ID")
    '        dgtv_dailysales.Columns.Add("Column2", "STUDENT ID")
    '        dgtv_dailysales.Columns.Add("Column3", "NAME")
    '        dgtv_dailysales.Columns.Add("Column4", "COURSE")
    '        dgtv_dailysales.Columns.Add("Column5", "DATE")
    '        dgtv_dailysales.Columns.Add("Column6", "TIME")

    '        Dim command As New MySqlCommand("SELECT * FROM vwallatt WHERE (DateStamp BETWEEN @fromDate AND @toDate) AND (name LIKE @searchTerm OR course LIKE @searchTerm OR Stud_Id LIKE @searchTerm) ORDER BY DateStamp", con)
    '        command.Parameters.AddWithValue("@fromDate", dtp_from.Value.ToString("yyyy-MM-dd"))
    '        command.Parameters.AddWithValue("@toDate", dtp_to.Value.ToString("yyyy-MM-dd"))
    '        command.Parameters.AddWithValue("@searchTerm", "%" & txt_dailysalessearch.Text & "%")

    '        Dim reader As MySqlDataReader = command.ExecuteReader

    '        While reader.Read
    '            '' Convert the date to the "YYYY-MM-DD" format
    '            'Dim formattedDate As String = Convert.ToDateTime(reader.Item("DateStamp")).ToString("yyyy-MM-dd")
    '            Dim formattedDate As String = Convert.ToDateTime(reader.Item("DateStamp")).ToString("yyyy-MM-dd")

    '            i += 1
    '            ''total += CDbl(reader.Item("total").ToString)
    '            dgtv_dailysales.Rows.Add(i, reader.Item("Stud_ID").ToString, reader.Item("name").ToString, reader.Item("course").ToString, formattedDate, reader.Item("Time_In").ToString)
    '        End While

    '        reader.Close()
    '        con.Close()
    '        ' lb_total.Text = Format(total, "₱ #,##0.00")

    '    Catch ex As Exception
    '        con.Close()
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub


    Sub DailyReport()
        Dim con As MySqlConnection = Connection.GetConnection

        Try
            ' Clear existing rows and columns
            dgtv_dailysales.Rows.Clear()
            dgtv_dailysales.Columns.Clear()

            con.Open()
            'Dim total As Double
            Dim i As Integer

            'sdate1 = Now.ToString("yyy-MM-dd")
            'sdate2 = Now.ToString


            ' Assuming you have DataGridViewTextBoxColumn for each column
            dgtv_dailysales.Columns.Add("Column1", "RECORD ID")
            dgtv_dailysales.Columns.Add("Column2", "STUDENT ID")
            dgtv_dailysales.Columns.Add("Column3", "NAME")
            dgtv_dailysales.Columns.Add("Column4", "GENDER")
            dgtv_dailysales.Columns.Add("Column5", "COURSE")
            dgtv_dailysales.Columns.Add("Column6", "DATE")
            dgtv_dailysales.Columns.Add("Column7", "TIME")


            Dim command As New MySqlCommand("SELECT * FROM vwallattendance WHERE (DateStamp BETWEEN @fromDate AND @toDate) AND (name LIKE @searchTerm OR gender LIKE @searchTerm OR course LIKE @searchTerm OR Stud_Id LIKE @searchTerm) ORDER BY DateStamp", con)
            command.Parameters.AddWithValue("@fromDate", dtp_from.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@toDate", dtp_to.Value.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("@searchTerm", "%" & txt_dailysalessearch.Text & "%")

            Dim reader As MySqlDataReader = command.ExecuteReader

            While reader.Read
                ' Convert the date to the "YYYY-MM-DD" format
                Dim formattedDate As String = Convert.ToDateTime(reader.Item("DateStamp")).ToString("yyyy-MM-dd")

                i += 1
                'total += CDbl(reader.Item("total").ToString)
                ' dgtv_dailysales.Rows.Add(i, formattedDate, reader.Item("transno").ToString, reader.Item("product_name").ToString, reader.Item("price").ToString, reader.Item("qty").ToString, reader.Item("total").ToString, reader.Item("user").ToString)
                dgtv_dailysales.Rows.Add(i, reader.Item("Stud_ID").ToString, reader.Item("name").ToString, reader.Item("gender"), reader.Item("course").ToString, formattedDate, reader.Item("Time_In").ToString)

            End While

            reader.Close()
            con.Close()
            ' lb_total.Text = Format(total, "₱ #,##0.00")

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub txt_dailysalessearch_TextChanged(sender As Object, e As EventArgs) Handles txt_dailysalessearch.TextChanged
        DailyReport()
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Dim dashboard As New dashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        Dim scan As New qrscanning
        scan.Show()
        Me.Hide()
    End Sub

    Private Sub btn_addStudent_Click(sender As Object, e As EventArgs) Handles btn_addStudent.Click
        Dim add As New Form1
        add.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updateStudent_Click(sender As Object, e As EventArgs) Handles btn_updateStudent.Click
        Dim updt As New update
        updt.Show()
        Me.Hide()
    End Sub

    
    Private Sub btn_printprev_Click(sender As Object, e As EventArgs) Handles btn_printprev.Click
        Dim print As New printpreview
        print.Show()
    End Sub

    Private Sub dtp_from_ValueChanged(sender As Object, e As EventArgs) Handles dtp_from.ValueChanged
        DailyReport()
    End Sub

    Private Sub dtp_to_ValueChanged(sender As Object, e As EventArgs) Handles dtp_to.ValueChanged
        DailyReport()
    End Sub

    
End Class