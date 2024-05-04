Imports MySql.Data.MySqlClient
Imports System.IO
Imports MessagingToolkit.Barcode

Public Class update

   
    Private Sub dgv_table_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_table.CellClick
        Try
            Dim index As Integer = e.RowIndex

            If index >= 0 Then
                Dim selectedRow As DataGridViewRow = dgv_table.Rows(index)

                TextBox1.Text = selectedRow.Cells(0).Value.ToString
                TextBox2.Text = selectedRow.Cells(1).Value.ToString
                cb_gender.Text = selectedRow.Cells(2).Value.ToString
                TextBox3.Text = selectedRow.Cells(3).Value.ToString

                ' Retrieve the image data from the database based on user ID
                Dim studId As String = selectedRow.Cells(0).Value.ToString
                Dim imageBytes As Byte() = GetImageFromDatabase(studId)

                ' Convert the byte array to an Image
                If imageBytes IsNot Nothing AndAlso imageBytes.Length > 0 Then
                    Dim ms As New MemoryStream(imageBytes)
                    pb_qrCode.Image = Image.FromStream(ms)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error displaying image: " & ex.Message)
        End Try
    End Sub

    Private Function GetImageFromDatabase(studId As String) As Byte()
        ' Query to retrieve image data based on user ID
        Dim query As String = "SELECT qrcode FROM tb_studlist WHERE Stud_Id = @Stud_Id"

        Using con As MySqlConnection = Connection.GetConnection()
            Using command As New MySqlCommand(query, con)
                command.Parameters.AddWithValue("@Stud_Id", studId)

                con.Open()

                ' Execute the query to retrieve the image data
                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Retrieve the image data
                    Return DirectCast(reader("qrcode"), Byte())
                End If
            End Using
        End Using

        Return Nothing
    End Function

    Private Sub getAllInfo()
        Dim con As MySqlConnection = Connection.GetConnection

        Try
            con.Open()

            Dim query As String = "SELECT * FROM tb_studlist"
            Dim command As New MySqlCommand(query, con)

            Dim reader As MySqlDataReader = command.ExecuteReader()

            If reader.HasRows Then
                While reader.Read()
                    Dim row As DataGridViewRow = New DataGridViewRow()
                    row.CreateCells(dgv_table)
                    row.Cells(0).Value = reader("Stud_Id")
                    row.Cells(1).Value = reader("name")
                    row.Cells(2).Value = reader("gender")
                    row.Cells(3).Value = reader("course")
                    
                    dgv_table.Rows.Add(row)

                End While
            End If
            reader.Close()


        Catch ex As Exception
            MessageBox.Show("An error occures while saving the data" & ex.Message)
        Finally
            con.Close()

        End Try
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

    'Private Sub btn_updateStudent_Click(sender As Object, e As EventArgs) Handles btn_updateStudent.Click
    '    Dim updt As New update
    '    updt.Show()
    '    Me.Hide()
    'End Sub

    Private Sub btn_studentList_Click(sender As Object, e As EventArgs) Handles btn_studentList.Click
        Dim listofstud As New listofstudents
        listofstud.Show()
        Me.Hide()
    End Sub

    Private Sub update_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getAllInfo()
    End Sub

    'Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
    '    Dim con As MySqlConnection = Connection.GetConnection()

    '    Try

    '        con.Open()
    '        Dim query As String = "UPDATE tb_studlist SET name = @name,course = @course, gender = @gender, qrcode = @qrcode WHERE Stud_Id = @Stud_Id"
    '        Dim command As New MySqlCommand(query, con)

    '        command.Parameters.AddWithValue("@name", TextBox2.Text)
    '        command.Parameters.AddWithValue("@course", TextBox3.Text)

    '        ' Check if a position is selected
    '        If cb_gender.SelectedItem IsNot Nothing Then
    '            command.Parameters.AddWithValue("@gender", cb_gender.SelectedItem.ToString())
    '        Else
    '            ' Handle the case where no position is selected
    '            command.Parameters.AddWithValue("@gender", DBNull.Value)
    '        End If

    '        ' Check if a new image is selected
    '        If pb_qrCode.Image IsNot Nothing Then
    '            Dim ms As New MemoryStream
    '            pb_qrCode.Image.Save(ms, pb_qrCode.Image.RawFormat)
    '            command.Parameters.Add("@qrcode", MySqlDbType.Blob).Value = ms.ToArray()
    '        Else
    '            ' If no new image is selected, retain the existing image
    '            Dim existingImage As Byte() = GetImageFromDatabase(Integer.Parse(TextBox1.Text))
    '            command.Parameters.Add("@qrcode", MySqlDbType.Blob).Value = existingImage
    '        End If

    '        ' Add the user_id parameter
    '        command.Parameters.AddWithValue("@Stud_Id", TextBox1.Text)

    '        command.ExecuteNonQuery()
    '        MessageBox.Show("Data has been updated to the database", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '        dgv_table.Rows.Clear()
    '        getAllInfo()
    '        'eraseInfo()

    '    Catch ex As Exception
    '        MessageBox.Show("An error occurs while saving the data: " & ex.Message)
    '    Finally
    '        con.Close()
    '    End Try
    'End Sub
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Dim con As MySqlConnection = Connection.GetConnection()

        Try
            con.Open()
            Dim query As String = "UPDATE tb_studlist SET name = @name, course = @course, gender = @gender, qrcode = @qrcode WHERE Stud_Id = @Stud_Id"
            Dim command As New MySqlCommand(query, con)

            command.Parameters.AddWithValue("@name", TextBox2.Text)
            command.Parameters.AddWithValue("@course", TextBox3.Text)

            ' Check if a position is selected
            If cb_gender.SelectedItem IsNot Nothing Then
                command.Parameters.AddWithValue("@gender", cb_gender.SelectedItem.ToString())
            Else
                ' Handle the case where no position is selected
                command.Parameters.AddWithValue("@gender", DBNull.Value)
            End If

            ' Check if a new image is selected
            If pb_qrCode.Image IsNot Nothing Then
                Dim ms As New MemoryStream
                pb_qrCode.Image.Save(ms, pb_qrCode.Image.RawFormat)
                command.Parameters.Add("@qrcode", MySqlDbType.Blob).Value = ms.ToArray()
            Else
                ' If no new image is selected, retain the existing image
                Dim existingImage As Byte() = GetImageFromDatabase(TextBox1.Text)
                command.Parameters.Add("@qrcode", MySqlDbType.Blob).Value = If(existingImage IsNot Nothing, existingImage, DBNull.Value)
            End If

            ' Add the user_id parameter
            command.Parameters.AddWithValue("@Stud_Id", TextBox1.Text)

            command.ExecuteNonQuery()
            MessageBox.Show("Data has been updated to the database", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dgv_table.Rows.Clear()
            getAllInfo()
            eraseInfo()

        Catch ex As Exception
            MessageBox.Show("An error occurs while saving the data: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub


    'Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
    '    Dim gen As New MessagingToolkit.Barcode.BarcodeEncoder
    '    gen.BackColor = Color.White
    '    gen.LabelFont = New Font("Arial", 7, FontStyle.Regular)
    '    gen.IncludeLabel = True
    '    gen.CustomLabel = TextBox1.Text

    '    Try

    '        pb_qrCode.Image = New Bitmap(gen.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, TextBox1.Text))

    '    Catch ex As Exception
    '        pb_qrCode.Image = Nothing
    '    End Try
    'End Sub
    'Private Sub btn_generate_Click(sender As Object, e As EventArgs) Handles btn_generate.Click
    '    If Not String.IsNullOrEmpty(TextBox1.Text) Then
    '        Dim gen As New MessagingToolkit.Barcode.BarcodeEncoder
    '        gen.BackColor = Color.White
    '        gen.LabelFont = New Font("Arial", 7, FontStyle.Regular)
    '        gen.IncludeLabel = True
    '        gen.CustomLabel = TextBox1.Text

    '        Try
    '            pb_qrCode.Image = New Bitmap(gen.Encode(MessagingToolkit.Barcode.BarcodeFormat.QRCode, TextBox1.Text))
    '        Catch ex As Exception
    '            pb_qrCode.Image = Nothing
    '            MessageBox.Show("Error generating QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        End Try
    '    Else
    '        MessageBox.Show("Please enter a valid value in TextBox1 before generating the QR code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End If
    'End Sub


    'Private Sub Save_QR()
    '    Try
    '        ' Use SaveFileDialog to get the file path
    '        SFD.Filter = "PNG Image | *.png"
    '        SFD.InitialDirectory = "C:\Users\Hilary Poralan\Documents\Visual Studio 2013\Projects\qrcode\QRCODES"
    '        SFD.FileName = "QR." & TextBox1.Text & ".png" 'instead na name ang namefile himoon natong id no.

    '        If SFD.ShowDialog() = DialogResult.OK Then
    '            ' Save the QR code as a PNG image
    '            Dim img As New Bitmap(pb_qrCode.Image)
    '            img.Save(SFD.FileName, Imaging.ImageFormat.Png)
    '            MsgBox("QR Code Successfully Saved!!!")
    '        End If
    '    Catch ex As Exception
    '        ' Handle exceptions here
    '        MessageBox.Show("Error saving QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub btn_saveQR_Click(sender As Object, e As EventArgs) Handles btn_saveQR.Click
        'Save_QR()
    End Sub

    Private Sub txt_search_TextChanged(sender As Object, e As EventArgs) Handles txt_search.TextChanged
        Dim con As MySqlConnection = Connection.GetConnection()

        Try
            con.Open()
            If Not String.IsNullOrWhiteSpace(txt_search.Text) Then
                Dim query As String = "SELECT Stud_Id, name, course, gender  FROM tb_studlist WHERE Stud_Id LIKE @search OR name LIKE @search OR gender LIKE @search OR course LIKE @search"
                Dim command As MySqlCommand = New MySqlCommand(query, con)
                command.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Dim reader As MySqlDataReader = command.ExecuteReader

                dgv_table.Rows.Clear()

                If reader.HasRows Then
                    While reader.Read()
                        Dim row As DataGridViewRow = New DataGridViewRow()
                        row.CreateCells(dgv_table)
                       row.Cells(0).Value = reader("Stud_Id")
                        row.Cells(1).Value = reader("name")
                        row.Cells(2).Value = reader("gender")
                        row.Cells(3).Value = reader("course")

                        dgv_table.Rows.Add(row)
                    End While
                End If
            Else
                Dim query As String = "SELECT * FROM tb_studlist"
                Dim command As MySqlCommand = New MySqlCommand(query, con)
                command.Parameters.AddWithValue("@search", "%" & txt_search.Text & "%")
                Dim reader As MySqlDataReader = command.ExecuteReader

                dgv_table.Rows.Clear()

                If reader.HasRows Then
                    While reader.Read()
                        Dim row As DataGridViewRow = New DataGridViewRow()
                        row.CreateCells(dgv_table)
                        row.Cells(0).Value = reader("Stud_Id")
                        row.Cells(1).Value = reader("name")
                        row.Cells(2).Value = reader("gender")
                        row.Cells(3).Value = reader("course")

                        dgv_table.Rows.Add(row)
                    End While

                End If
                reader.Close()
            End If

        Catch ex As Exception
            MessageBox.Show("An error occures while saving the data" & ex.Message)
        Finally
            con.Close()

        End Try
    End Sub
    Private Sub eraseInfo()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        cb_gender.SelectedIndex = -1
        pb_qrCode.Image = Nothing
    End Sub
End Class