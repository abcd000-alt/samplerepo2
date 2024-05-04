<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listofstudents
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listofstudents))
        Me.dgtv_dailysales = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.btn_printprev = New System.Windows.Forms.Button()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_dailysalessearch = New System.Windows.Forms.TextBox()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_studentList = New System.Windows.Forms.Button()
        Me.btn_updateStudent = New System.Windows.Forms.Button()
        Me.btn_addStudent = New System.Windows.Forms.Button()
        Me.btn_scan = New System.Windows.Forms.Button()
        Me.btn_dashboard = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgtv_dailysales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgtv_dailysales
        '
        Me.dgtv_dailysales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgtv_dailysales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgtv_dailysales.Location = New System.Drawing.Point(243, 176)
        Me.dgtv_dailysales.MultiSelect = False
        Me.dgtv_dailysales.Name = "dgtv_dailysales"
        Me.dgtv_dailysales.RowHeadersVisible = False
        Me.dgtv_dailysales.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgtv_dailysales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgtv_dailysales.Size = New System.Drawing.Size(810, 241)
        Me.dgtv_dailysales.TabIndex = 35
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(237, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Filter Date [From - To]"
        '
        'dtp_to
        '
        Me.dtp_to.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(353, 149)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(106, 20)
        Me.dtp_to.TabIndex = 34
        '
        'btn_printprev
        '
        Me.btn_printprev.BackColor = System.Drawing.Color.DimGray
        Me.btn_printprev.FlatAppearance.BorderSize = 0
        Me.btn_printprev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btn_printprev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Sienna
        Me.btn_printprev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_printprev.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_printprev.ForeColor = System.Drawing.Color.White
        Me.btn_printprev.Image = CType(resources.GetObject("btn_printprev.Image"), System.Drawing.Image)
        Me.btn_printprev.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_printprev.Location = New System.Drawing.Point(992, 147)
        Me.btn_printprev.Name = "btn_printprev"
        Me.btn_printprev.Size = New System.Drawing.Size(61, 21)
        Me.btn_printprev.TabIndex = 33
        Me.btn_printprev.Text = "Print"
        Me.btn_printprev.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_printprev.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_printprev.UseVisualStyleBackColor = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label25.Location = New System.Drawing.Point(666, 151)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 19)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Search"
        '
        'txt_dailysalessearch
        '
        Me.txt_dailysalessearch.Location = New System.Drawing.Point(727, 147)
        Me.txt_dailysalessearch.Multiline = True
        Me.txt_dailysalessearch.Name = "txt_dailysalessearch"
        Me.txt_dailysalessearch.Size = New System.Drawing.Size(237, 22)
        Me.txt_dailysalessearch.TabIndex = 31
        '
        'dtp_from
        '
        Me.dtp_from.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(243, 149)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(101, 20)
        Me.dtp_from.TabIndex = 30
        Me.dtp_from.Value = New Date(2023, 12, 28, 14, 50, 38, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(539, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 31)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "LIST OF STUDENTS"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(154, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1021, 74)
        Me.Panel3.TabIndex = 59
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
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.btn_studentList)
        Me.Panel2.Controls.Add(Me.btn_updateStudent)
        Me.Panel2.Controls.Add(Me.btn_addStudent)
        Me.Panel2.Controls.Add(Me.btn_scan)
        Me.Panel2.Controls.Add(Me.btn_dashboard)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(-1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(236, 434)
        Me.Panel2.TabIndex = 70
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Location = New System.Drawing.Point(-54, 368)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(74, 29)
        Me.Panel1.TabIndex = 71
        '
        'listofstudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1063, 423)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgtv_dailysales)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.btn_printprev)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_dailysalessearch)
        Me.Controls.Add(Me.dtp_from)
        Me.Name = "listofstudents"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "listofstudents"
        CType(Me.dgtv_dailysales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgtv_dailysales As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_printprev As System.Windows.Forms.Button
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_dailysalessearch As System.Windows.Forms.TextBox
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_studentList As System.Windows.Forms.Button
    Friend WithEvents btn_updateStudent As System.Windows.Forms.Button
    Friend WithEvents btn_addStudent As System.Windows.Forms.Button
    Friend WithEvents btn_scan As System.Windows.Forms.Button
    Friend WithEvents btn_dashboard As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
