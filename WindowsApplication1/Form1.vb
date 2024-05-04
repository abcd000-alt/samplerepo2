Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow

Public Class Form1
    Dim Camera As VideoCaptureDevice
    Dim bmp As Bitmap

    Private Sub captured(ByVal sender As Object, ByVal eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        PictureBox1.Image = DirectCast(eventArgs.Frame.Clone(), Bitmap)


    End Sub
    Private Sub btnOpenCam_Click(sender As Object, e As EventArgs) Handles btnOpenCam.Click

        Try
            Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
            If cameras.ShowDialog = Windows.Forms.DialogResult.OK Then
                Camera = cameras.VideoDevice
                AddHandler Camera.NewFrame, New NewFrameEventHandler(AddressOf captured)
                Camera.Start()
            End If
        Catch ex As Exception

        End Try

    End Sub


    Private Sub btnCapture_Click(sender As Object, e As EventArgs) Handles btnCapture.Click
        Camera.Stop()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Camera.Stop()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Save_QR()
    End Sub
    Private Sub Save_QR()
        Try
            ' Use SaveFileDialog to get the file path
            SFD.Filter = "PNG Image | *.png"
            'SFD.InitialDirectory = "C:\Users\Hilary Poralan\Documents\Visual Studio 2013\Projects\qrcode\QRCODES"
            'SFD.FileName = "QR." & TextBox1.Text & ".png" 'instead na name ang namefile himoon natong id no.

            If SFD.ShowDialog() = DialogResult.OK Then
                ' Save the QR code as a PNG image
               
                MsgBox("ImageSuccessfully Saved!!!")

            End If
        Catch ex As Exception
            ' Handle exceptions here
            MessageBox.Show("Error saving QR code: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Camera.Start()
    End Sub
End Class
