Imports MySql.Data.MySqlClient
Public Class Form1
    Dim con As MySqlConnection = Connection.GetConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoNumber()
    End Sub

    Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
        Dim gen As New MessagingToolkit.Barcode.BarcodeEncoder
        gen.BackColor = Color.White
        gen.LabelFont = New Font("Arial", 7, FontStyle.Regular)
        gen.IncludeLabel = True
        gen.CustomLabel = TextBox1.Text

        Try

            pb_qrCode.Image = New Bitmap(gen.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, TextBox1.Text))

        Catch ex As Exception
            pb_qrCode.Image = Nothing
        End Try
    End Sub

    Sub AutoNumber()
        Try
            Using cmd As New MySqlCommand
                With cmd
                    .Connection = con
                    .CommandText = "SP_Autonum_QRS"
                    .CommandType = CommandType.StoredProcedure
                    .Parameters.AddWithValue("@p_pfx", "ABC")

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
                .Parameters.AddWithValue("@p_pfx", "ABC")
            End With
            cmd.ExecuteScalar()
            cmd.Dispose()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    'Sub CreateNewAutoNumber()
    '    Try
    '        Using cmd As New MySqlCommand
    '            With cmd
    '                .Connection = con
    '                .CommandText = "SP_Autonum_QRS"
    '                .CommandType = CommandType.StoredProcedure
    '                .Parameters.AddWithValue("@p_pfx", "ABC")

    '                con.Open()
    '                .ExecuteScalar()
    '            End With
    '        End Using
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    Finally
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '    End Try
    'End Sub

    Private Sub btn_saveQR_Click(sender As Object, e As EventArgs) Handles btn_saveQR.Click
        
        Save_QR()
    End Sub

    Private Sub Save_QR()
        Try
            ' Use SaveFileDialog to get the file path
            SFD.Filter = "PNG Image | *.png"
            SFD.InitialDirectory = "C:\Users\Hilary Poralan\Documents\Visual Studio 2013\Projects\qrcode\QRCODES"
            SFD.FileName = "QR." & TextBox1.Text & ".png" 'instead na name ang namefile himoon natong id no.

            If SFD.ShowDialog() = DialogResult.OK Then
                ' Save the QR code as a PNG image
                Dim img As New Bitmap(pb_qrCode.Image)
                img.Save(SFD.FileName, Imaging.ImageFormat.Png)
                MsgBox("QR Code Successfully Saved!!!")
            End If
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error saving QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Sub savestuddata()
    '    Dim con As MySqlConnection = Connection.GetConnection

    '    Try
    '        con.Open()
    '        Dim ms As New IO.MemoryStream
    '        pb_qrCode.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

    '        query = "insert into tb_studlist(Stud_Id, name, course, qrcode)Values(@Stud_id, @name, @course, @qrcode)"
    '        cm = New MySqlCommand(query, con)

    '        With cm
    '            .Parameters.AddWithValue("@Stud_id", TextBox1.Text)
    '            .Parameters.AddWithValue("@name", TextBox1.Text)
    '            .Parameters.AddWithValue("@course", TextBox1.Text)
    '            .Parameters.AddWithValue("@qrcode", ms.ToArray())

    '        End With
    '        cm.ExecuteNonQuery()
    '        cm.Dispose()

    '    Catch ex As Exception
    '        MsgBox(ex.Message, vbCritical)
    '    Finally

    '        con.Close()
    '    End Try
    'End Sub

    'Sub savestuddata()
    '    Try
    '        con.Open()

    '        Dim ms As New IO.MemoryStream
    '        pb_qrCode.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

    '        query = "INSERT INTO tb_studlist(Stud_Id, name, course, qrcode) VALUES(@Stud_id, @name, @course, @qrcode)"
    '        cm = New MySqlCommand(query, con)

    '        With cm
    '            .Parameters.AddWithValue("@Stud_id", TextBox1.Text)
    '            .Parameters.AddWithValue("@name", TextBox2.Text) ' Replace with the correct TextBox for name
    '            .Parameters.AddWithValue("@course", TextBox3.Text) ' Replace with the correct TextBox for course
    '            .Parameters.AddWithValue("@qrcode", ms.ToArray())
    '        End With

    '        cm.ExecuteNonQuery()
    '        MsgBox("Data successfully saved!")
    '    Catch ex As Exception
    '        MsgBox("An error occurred: " & ex.Message, vbCritical)
    '    Finally
    '        If con.State = ConnectionState.Open Then
    '            con.Close()
    '        End If
    '    End Try
    'End Sub


    'Sub savestuddata()
    '    Try
    '        Using con As MySqlConnection = Connection.GetConnection()
    '            con.Open()

    '            Dim ms As New IO.MemoryStream
    '            pb_qrCode.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

    '            query = "INSERT INTO tb_studlist(Stud_Id, name, gender, course, qrcode) VALUES(@Stud_id, @name, @gender, @course, @qrcode)"
    '            cm = New MySqlCommand(query, con)

    '            With cm
    '                .Parameters.AddWithValue("@Stud_id", TextBox1.Text)
    '                .Parameters.AddWithValue("@name", TextBox2.Text) ' Replace with the correct TextBox for name
    '                .Parameters.AddWithValue("@gender", cb_gender.SelectedItem.ToString)
    '                .Parameters.AddWithValue("@course", TextBox3.Text) ' Replace with the correct TextBox for course
    '                .Parameters.AddWithValue("@qrcode", ms.ToArray())
    '            End With

    '            cm.ExecuteNonQuery()
    '            MsgBox("Data successfully saved!")
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("An error occurred: " & ex.Message, vbCritical)
    '    End Try
    'End Sub


    Sub savestuddata()
        Try
            Using con As MySqlConnection = Connection.GetConnection()
                con.Open()

                Dim ms As New IO.MemoryStream
                pb_qrCode.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)

                query = "INSERT INTO tb_studlist(Stud_Id, name, gender, course, qrcode) VALUES(@Stud_id, @name, @gender, @course, @qrcode)"
                cm = New MySqlCommand(query, con)

                With cm
                    .Parameters.AddWithValue("@Stud_id", TextBox1.Text)
                    .Parameters.AddWithValue("@name", TextBox2.Text)
                    .Parameters.AddWithValue("@gender", cb_gender.SelectedItem.ToString)
                    .Parameters.AddWithValue("@course", TextBox3.Text)
                    .Parameters.AddWithValue("@qrcode", ms.ToArray())
                End With

                ' Execute the query
                Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                If rowsAffected > 0 Then
                    ' Data successfully inserted, generate AutoNumber
                    AutoNumber()
                    MsgBox("Data successfully saved!")
                Else
                    ' Handle the case where no rows were affected
                    MsgBox("No rows were affected. Data not saved.", vbExclamation)
                End If
            End Using
        Catch ex As Exception
            MsgBox("An error occurred: " & ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        savestuddata()
        clear()
        'CreateNewAutoNumber()
        'AutoNumber()
    End Sub

    Sub clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        cb_gender.SelectedIndex = -1
        pb_qrCode.Image = Nothing
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
    
    Private Sub btn_dashboard_Click(sender As Object, e As EventArgs) Handles btn_dashboard.Click
        Dim dashboard As New dashboard
        dashboard.Show()
        Me.Hide()
    End Sub
End Class
