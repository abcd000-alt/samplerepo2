Imports MySql.Data.MySqlClient
Public Class dashboard




    Sub Dashboard()
        Dim con As MySqlConnection = Connection.GetConnection
        Try
            con.Open()

            Dim sdate As String = Now.ToString("yyyy-MM-dd")

            Dim command As New MySqlCommand("SELECT COUNT(*) FROM vwallatt WHERE DateStamp BETWEEN @startDate AND @endDate", con)
            command.Parameters.AddWithValue("@startDate", sdate & " 00:00:00") ' Start of the day
            command.Parameters.AddWithValue("@endDate", sdate & " 23:59:59")   ' End of the day
            Dim total As Double = CDbl(command.ExecuteScalar)
            lbl_totalnum.Text = Format(total, "0")
            con.Close()

        Catch ex As Exception
            MessageBox.Show("An error occures while saving the data" & ex.Message)
        End Try
    End Sub

    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dashboard()

    End Sub

    'Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
    '    Dim dashboard As New dashboard
    '    dashboard.Show()
    '    Me.Hide()
    'End Sub

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

    Private Sub btn_studentList_Click(sender As Object, e As EventArgs) Handles btn_studentList.Click
        Dim listofstud As New listofstudents
        listofstud.Show()
        Me.Hide()
    End Sub
End Class