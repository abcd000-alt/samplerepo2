Imports MySql.Data.MySqlClient
Imports System.IO
Imports WebCam_Capture
Imports MessagingToolkit.QRCode.Codec

Public Class qrscanning
    WithEvents mywebcam As WebCamCapture
    Dim qrcodereader As QRCodeDecoder
    Dim con As MySqlConnection = Connection.GetConnection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoNumber()
        'InitializeWebCam()
    End Sub

    Sub AutoNumber()
        Try
            Using cmd As New MySqlCommand
                With cmd
                    .Connection = con
                    .CommandText = "SP_Autonum_QRS"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("p_pfx", "REC")

                    ' Add the output parameter
                    Dim outParam As New MySqlParameter("@p_newnumber", MySqlDbType.VarChar, 13)
                    outParam.Direction = ParameterDirection.Output
                    .Parameters.Add(outParam)

                    con.Open()
                    .ExecuteNonQuery()

                    ' Retrieve the output parameter value
                    Dim result = outParam.Value

                    If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                        TextBox1.Text = result.ToString()
                    Else
                        ' Handle the case when the output parameter is null or DBNull
                        MessageBox.Show("Unable to retrieve or generate auto number.")
                    End If
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Sub CreateNewAutoNumber()
        Dim con As MySqlConnection = Connection.GetConnection
        Try
            con.Open()
            Dim cmd As New MySqlCommand
            With cmd
                .Connection = con
                .CommandText = "SP_Autonum_QRS"
                .CommandType = CommandType.StoredProcedure
                .Parameters.AddWithValue("@p_pfx", "REC")
            End With
            cmd.ExecuteScalar()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Sub InitializeWebCam()
        Try
            mywebcam = New WebCamCapture
            mywebcam.Start(0)
        Catch ex As Exception
            MessageBox.Show("An error occurred during capturing the video image: " & ex.Message)
        End Try
    End Sub
    Sub startcam()
        Try
            If mywebcam IsNot Nothing Then
                mywebcam.Start(0)
            Else
                InitializeWebCam()
            End If
            TextBox2.Clear()
        Catch ex As Exception
            MessageBox.Show("An error occurred during capturing the video image: " & ex.Message)
        End Try
    End Sub

    Sub stopcam()
        Try
            If mywebcam IsNot Nothing Then
                mywebcam.Stop()
                mywebcam.Dispose()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during stopping the video capture: " & ex.Message)
        End Try
    End Sub
    Private Sub mywebcam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles mywebcam.ImageCaptured
        PictureBox1.Image = e.WebCamImage
    End Sub


    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        startcam()
        TextBox2.Clear()
    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click
        Try
            If mywebcam IsNot Nothing Then
                mywebcam.Stop()
                mywebcam.Dispose()
                mywebcam = Nothing ' Set mywebcam to Nothing after disposing
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during stopping the video capture: " & ex.Message)
        End Try
    End Sub

    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Try
    '        stopcam()
    '        qrcodereader = New QRCodeDecoder
    '        TextBox2.Text = qrcodereader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
    '        MsgBox("Scan Successful")
    '    Catch ex As Exception
    '        startcam()
    '    End Try
    '    'con.Open()
    '    str = "SELECT * FROM tb_studlist where Stud_Id = '" & TextBox2.Text.ToString & "'"
    '    cm = New MySqlCommand(str, con)
    '    dr = cm.ExecuteReader
    '    While dr.Read
    '        If dr.HasRows Then
    '            time_in()
    '        End If
    '    End While
    '    con.Close()

    'End Sub
    'Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
    '    Try
    '        ' Stop the camera and attempt to decode the QR code
    '        stopcam()
    '        qrcodereader = New QRCodeDecoder
    '        TextBox2.Text = qrcodereader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
    '        MsgBox("Scan Successful")

    '        ' Process the scanned QR code
    '        If con.State <> ConnectionState.Open Then
    '            con.Open()
    '        End If

    '        str = "SELECT * FROM tb_studlist WHERE Stud_Id = @StudId"
    '        cm = New MySqlCommand(str, con)
    '        cm.Parameters.AddWithValue("@StudId", TextBox2.Text.ToString())

    '        ' Ensure the data reader is properly closed before executing the query
    '        If dr IsNot Nothing AndAlso Not dr.IsClosed Then
    '            dr.Close()
    '        End If

    '        dr = cm.ExecuteReader()

    '        If dr.HasRows Then
    '            While dr.Read
    '                ' Process data or call a method (e.g., time_in()) based on your needs
    '                time_in()
    '            End While
    '        Else
    '            MessageBox.Show("No matching record found for the scanned QR code.")
    '        End If
    '    Catch ex As Exception
    '        ' Handle exceptions related to QR code decoding or database query
    '        MessageBox.Show("An error occurred during decoding: " & ex.Message)
    '    Finally
    '        ' Always close the data reader and connection
    '        If dr IsNot Nothing AndAlso Not dr.IsClosed Then
    '            dr.Close()
    '        End If

    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If

    '        ' Restart the camera, even if an error occurred
    '        startcam()
    '    End Try
    'End Sub

    Private Sub Bbtn_scan_Click(sender As Object, e As EventArgs) Handles btn_scan.Click
        Try
            ' Stop the camera and attempt to decode the QR code

            stopcam()
            qrcodereader = New QRCodeDecoder
            TextBox2.Text = qrcodereader.Decode(New Data.QRCodeBitmapImage(PictureBox1.Image))
            MsgBox("Scan Successful")

            ' Process the scanned QR code
            If con.State <> ConnectionState.Open Then
                con.Open()
            End If

            str = "SELECT COUNT(*) FROM tb_studlist WHERE Stud_Id = @StudId"
            cm = New MySqlCommand(str, con)
            cm.Parameters.AddWithValue("@StudId", TextBox2.Text.ToString())

            ' Use ExecuteScalar to get the count of matching records
            Dim rowCount As Integer = Convert.ToInt32(cm.ExecuteScalar())

            If rowCount > 0 Then
                ' Matching record found, proceed with further actions
                time_in()
            Else
                MessageBox.Show("No matching record found for the scanned QR code.")
            End If
        Catch ex As Exception
            ' Handle exceptions related to QR code decoding or database query
            MessageBox.Show("An error occurred during decoding: " & ex.Message)
        Finally
            ' Always close the connection
            If con.State = ConnectionState.Open Then
                con.Close()
            End If

            ' Restart the camera, even if an error occurred
            startcam()
        End Try
    End Sub


    Sub time_in()
        query = "Insert into tb_getatt (RecNo, Stud_Id, DateStamp, Time_in) VAlUES (@RecNo, @Stud_Id, @DateStamp, @Time_in)"
        cm = New MySqlCommand(query, con)
        With cm
            .Parameters.AddWithValue("@RecNo", TextBox1.Text)
            .Parameters.AddWithValue("@Stud_Id", TextBox2.Text)
            .Parameters.AddWithValue("@DateStamp", CDate(Date.Now.ToString))
            .Parameters.AddWithValue("@Time_in", CDate(Date.Now.ToString))
        End With
        cm.ExecuteNonQuery()
        cm.Dispose()
    End Sub

  
   
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub

    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Dim dashboard As New dashboard
        dashboard.Show()
        Me.Hide()
    End Sub

    Private Sub btn_addStudent_Click(sender As Object, e As EventArgs) Handles btn_addStudent.Click
        Dim add As New Form1
        add.Show()
        Me.Hide()
    End Sub

    Private Sub btn_updateStudent_Click(sender As Object, e As EventArgs) Handles btn_updateStudent.Click
        Dim update As New update
        update.Show()
        Me.Hide()
    End Sub


    Private Sub btn_studentList_Click(sender As Object, e As EventArgs) Handles btn_studentList.Click
        Dim list As New listofstudents
        list.Show()
        Me.Hide()
    End Sub

    
End Class