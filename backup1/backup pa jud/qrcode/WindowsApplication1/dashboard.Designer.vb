<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboard))
        Me.lbl_totalnum = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_studentList = New System.Windows.Forms.Button()
        Me.btn_updateStudent = New System.Windows.Forms.Button()
        Me.btn_addStudent = New System.Windows.Forms.Button()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_totalnum
        '
        Me.lbl_totalnum.AutoSize = True
        Me.lbl_totalnum.BackColor = System.Drawing.Color.Transparent
        Me.lbl_totalnum.Font = New System.Drawing.Font("Arial Black", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_totalnum.ForeColor = System.Drawing.Color.Black
        Me.lbl_totalnum.Location = New System.Drawing.Point(471, 254)
        Me.lbl_totalnum.Name = "lbl_totalnum"
        Me.lbl_totalnum.Size = New System.Drawing.Size(61, 68)
        Me.lbl_totalnum.TabIndex = 24
        Me.lbl_totalnum.Text = "0"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(280, 195)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(100, 81)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 23
        Me.PictureBox3.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(400, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(211, 24)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "NO. OF  STUDENTS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(564, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 28)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "DASHBOARD"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btn_studentList)
        Me.Panel1.Controls.Add(Me.btn_updateStudent)
        Me.Panel1.Controls.Add(Me.btn_addStudent)
        Me.Panel1.Controls.Add(Me.btn_scan)
        Me.Panel1.Controls.Add(Me.btn_dashboard)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(-9, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(236, 434)
        Me.Panel1.TabIndex = 21
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
        Me.btn_addStudent.Location = New System.Drawing.Point(34, 260)
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
        Me.btn_scan.Location = New System.Drawing.Point(34, 151)
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
        Me.btn_dashboard.Location = New System.Drawing.Point(34, 204)
        Me.btn_dashboard.Name = "btn_dashboard"
        Me.btn_dashboard.Size = New System.Drawing.Size(166, 29)
        Me.btn_dashboard.TabIndex = 3
        Me.btn_dashboard.Text = "DASHBOARD"
        Me.btn_dashboard.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 114)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(167, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1021, 74)
        Me.Panel3.TabIndex = 53
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
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Linen
        Me.Panel2.Location = New System.Drawing.Point(-47, 204)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(74, 29)
        Me.Panel2.TabIndex = 9
        '
        'dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1063, 423)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_totalnum)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_totalnum As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_studentList As System.Windows.Forms.Button
    Friend WithEvents btn_updateStudent As System.Windows.Forms.Button
    Friend WithEvents btn_addStudent As System.Windows.Forms.Button
    Friend WithEvents btn_scan As System.Windows.Forms.Button
    Friend WithEvents btn_dashboard As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
