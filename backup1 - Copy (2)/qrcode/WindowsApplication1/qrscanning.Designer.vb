<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qrscanning
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(qrscanning))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_addStudent = New System.Windows.Forms.Button()
        Me.btn_updateStudent = New System.Windows.Forms.Button()
        Me.btn_studentList = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(722, 207)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(110, 20)
        Me.TextBox1.TabIndex = 15
        '
        'btn_stop
        '
        Me.btn_stop.Location = New System.Drawing.Point(591, 160)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(86, 40)
        Me.btn_stop.TabIndex = 14
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = True
        '
        'btn_scan
        '
        Me.btn_scan.Location = New System.Drawing.Point(591, 211)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(86, 43)
        Me.btn_scan.TabIndex = 13
        Me.btn_scan.Text = "Scan"
        Me.btn_scan.UseVisualStyleBackColor = True
        '
        'btn_start
        '
        Me.btn_start.Location = New System.Drawing.Point(591, 104)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(86, 42)
        Me.btn_start.TabIndex = 12
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(273, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(303, 271)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(273, 382)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(303, 20)
        Me.TextBox2.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(56, 18)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(123, 114)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'btn_dashboard
        '
        Me.btn_dashboard.BackColor = System.Drawing.Color.Linen
        Me.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_dashboard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashboard.Location = New System.Drawing.Point(34, 211)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(166, 29)
        Me.btn_dashboard.TabIndex = 3
        Me.btn_dashboard.Text = "DASHBOARD"
        Me.btn_dashboard.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Linen
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(34, 160)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 29)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "SCAN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_addStudent
        '
        Me.btn_addStudent.BackColor = System.Drawing.Color.Linen
        Me.btn_addStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addStudent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addStudent.Location = New System.Drawing.Point(34, 268)
        Me.btn_addStudent.Name = "btn_addStudent"
        Me.btn_addStudent.Size = New System.Drawing.Size(166, 29)
        Me.btn_addStudent.TabIndex = 5
        Me.btn_addStudent.Text = "ADD STUDENT"
        Me.btn_addStudent.UseVisualStyleBackColor = False
        '
        'btn_updateStudent
        '
        Me.btn_updateStudent.BackColor = System.Drawing.Color.Linen
        Me.btn_updateStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_updateStudent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_updateStudent.Location = New System.Drawing.Point(34, 318)
        Me.btn_updateStudent.Name = "btn_updateStudent"
        Me.btn_updateStudent.Size = New System.Drawing.Size(166, 29)
        Me.btn_updateStudent.TabIndex = 6
        Me.btn_updateStudent.Text = "UPDATE STUDENTS"
        Me.btn_updateStudent.UseVisualStyleBackColor = False
        '
        'btn_studentList
        '
        Me.btn_studentList.BackColor = System.Drawing.Color.Linen
        Me.btn_studentList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_studentList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_studentList.Location = New System.Drawing.Point(34, 371)
        Me.btn_studentList.Name = "btn_studentList"
        Me.btn_studentList.Size = New System.Drawing.Size(166, 29)
        Me.btn_studentList.TabIndex = 7
        Me.btn_studentList.Text = "LIST OF STUDENTS"
        Me.btn_studentList.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.btn_studentList)
        Me.Panel2.Controls.Add(Me.btn_updateStudent)
        Me.Panel2.Controls.Add(Me.btn_addStudent)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btn_dashboard)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 434)
        Me.Panel2.TabIndex = 71
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Location = New System.Drawing.Point(230, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(469, 74)
        Me.Panel3.TabIndex = 60
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(125, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(221, 24)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "QR CODE SCANNER"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(595, 365)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(86, 40)
        Me.Button2.TabIndex = 72
        Me.Button2.Text = "Done"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Location = New System.Drawing.Point(-53, 160)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 29)
        Me.Panel1.TabIndex = 10
        '
        'qrscanning
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(693, 423)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_scan)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "qrscanning"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "qrscanning"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btn_stop As System.Windows.Forms.Button
    Friend WithEvents btn_scan As System.Windows.Forms.Button
    Friend WithEvents btn_start As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_dashboard As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_addStudent As System.Windows.Forms.Button
    Friend WithEvents btn_updateStudent As System.Windows.Forms.Button
    Friend WithEvents btn_studentList As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
