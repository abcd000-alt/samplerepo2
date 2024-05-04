<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_generate = New System.Windows.Forms.Button()
        Me.btn_saveQR = New System.Windows.Forms.Button()
        Me.pb_qrCode = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SFD = New System.Windows.Forms.SaveFileDialog()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cb_gender = New System.Windows.Forms.ComboBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_studentList = New System.Windows.Forms.Button()
        Me.btn_updateStudent = New System.Windows.Forms.Button()
        Me.btn_addStudent = New System.Windows.Forms.Button()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.pb_qrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!)
        Me.Button1.Location = New System.Drawing.Point(876, 119)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 23)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "SAVE INFO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btn_generate
        '
        Me.btn_generate.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_generate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_generate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_generate.Location = New System.Drawing.Point(700, 344)
        Me.btn_generate.Name = "btn_generate"
        Me.btn_generate.Size = New System.Drawing.Size(325, 29)
        Me.btn_generate.TabIndex = 49
        Me.btn_generate.Text = "GENERATE QR CODE"
        Me.btn_generate.UseVisualStyleBackColor = False
        '
        'btn_saveQR
        '
        Me.btn_saveQR.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btn_saveQR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_saveQR.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_saveQR.Location = New System.Drawing.Point(700, 379)
        Me.btn_saveQR.Name = "btn_saveQR"
        Me.btn_saveQR.Size = New System.Drawing.Size(325, 29)
        Me.btn_saveQR.TabIndex = 47
        Me.btn_saveQR.Text = "SAVE QR CODE"
        Me.btn_saveQR.UseVisualStyleBackColor = False
        '
        'pb_qrCode
        '
        Me.pb_qrCode.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pb_qrCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pb_qrCode.Location = New System.Drawing.Point(700, 148)
        Me.pb_qrCode.Name = "pb_qrCode"
        Me.pb_qrCode.Size = New System.Drawing.Size(325, 171)
        Me.pb_qrCode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pb_qrCode.TabIndex = 48
        Me.pb_qrCode.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(444, 257)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(189, 22)
        Me.TextBox3.TabIndex = 41
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(444, 211)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(189, 22)
        Me.TextBox2.TabIndex = 40
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(444, 162)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 21)
        Me.TextBox1.TabIndex = 39
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(173, 1)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1021, 74)
        Me.Panel3.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(242, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(506, 17)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Elpidio M. Gazmen Road, Gazmen Coumpound, Tagum City Davao del Norte"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(85, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(806, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "TAGUM CITY COLLEGE OF SCIENCE AND TECHNOLOGY FOUNDATION, INC."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(307, 166)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 15)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "STUDENT ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(307, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 15)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(307, 258)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 15)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "COURSE/GRADE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(497, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 28)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "STUDENT INFORMATION"
        '
        'cb_gender
        '
        Me.cb_gender.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_gender.FormattingEnabled = True
        Me.cb_gender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cb_gender.Location = New System.Drawing.Point(444, 299)
        Me.cb_gender.Name = "cb_gender"
        Me.cb_gender.Size = New System.Drawing.Size(129, 25)
        Me.cb_gender.TabIndex = 67
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(267, 298)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 66
        Me.PictureBox5.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(264, 203)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 65
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), System.Drawing.Image)
        Me.PictureBox7.Location = New System.Drawing.Point(264, 162)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox7.TabIndex = 64
        Me.PictureBox7.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(307, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 15)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "GENDER"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(267, 255)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 24)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 68
        Me.PictureBox1.TabStop = False
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
        Me.Panel2.Controls.Add(Me.btn_scan)
        Me.Panel2.Controls.Add(Me.btn_dashboard)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 434)
        Me.Panel2.TabIndex = 69
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
        'btn_addStudent
        '
        Me.btn_addStudent.BackColor = System.Drawing.Color.Linen
        Me.btn_addStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_addStudent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_addStudent.Location = New System.Drawing.Point(34, 263)
        Me.btn_addStudent.Name = "btn_addStudent"
        Me.btn_addStudent.Size = New System.Drawing.Size(166, 29)
        Me.btn_addStudent.TabIndex = 5
        Me.btn_addStudent.Text = "ADD STUDENT"
        Me.btn_addStudent.UseVisualStyleBackColor = False
        '
        'btn_scan
        '
        Me.btn_scan.BackColor = System.Drawing.Color.Linen
        Me.btn_scan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_scan.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_scan.Location = New System.Drawing.Point(34, 157)
        Me.btn_scan.Name = "btn_scan"
        Me.btn_scan.Size = New System.Drawing.Size(166, 29)
        Me.btn_scan.TabIndex = 4
        Me.btn_scan.Text = "SCAN"
        Me.btn_scan.UseVisualStyleBackColor = False
        '
        'btn_dashboard
        '
        Me.btn_dashboard.BackColor = System.Drawing.Color.Linen
        Me.btn_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_dashboard.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dashboard.Location = New System.Drawing.Point(34, 212)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(166, 29)
        Me.btn_dashboard.TabIndex = 3
        Me.btn_dashboard.Text = "DASHBOARD"
        Me.btn_dashboard.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Location = New System.Drawing.Point(-54, 261)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 29)
        Me.Panel1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1063, 423)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.cb_gender)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_generate)
        Me.Controls.Add(Me.btn_saveQR)
        Me.Controls.Add(Me.pb_qrCode)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.pb_qrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btn_generate As System.Windows.Forms.Button
    Friend WithEvents btn_saveQR As System.Windows.Forms.Button
    Friend WithEvents pb_qrCode As System.Windows.Forms.PictureBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents SFD As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cb_gender As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox7 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_studentList As System.Windows.Forms.Button
    Friend WithEvents btn_updateStudent As System.Windows.Forms.Button
    Friend WithEvents btn_addStudent As System.Windows.Forms.Button
    Friend WithEvents btn_scan As System.Windows.Forms.Button
    Friend WithEvents btn_dashboard As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
