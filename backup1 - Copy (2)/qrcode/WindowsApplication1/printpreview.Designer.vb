<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class printpreview
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
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_dailysalessearch = New System.Windows.Forms.TextBox()
        Me.btnfilter = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtp_to = New System.Windows.Forms.DateTimePicker()
        Me.dtp_from = New System.Windows.Forms.DateTimePicker()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SuspendLayout()
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label25.Location = New System.Drawing.Point(484, 45)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(55, 19)
        Me.Label25.TabIndex = 46
        Me.Label25.Text = "Search"
        '
        'txt_dailysalessearch
        '
        Me.txt_dailysalessearch.Location = New System.Drawing.Point(545, 41)
        Me.txt_dailysalessearch.Multiline = True
        Me.txt_dailysalessearch.Name = "txt_dailysalessearch"
        Me.txt_dailysalessearch.Size = New System.Drawing.Size(237, 22)
        Me.txt_dailysalessearch.TabIndex = 45
        '
        'btnfilter
        '
        Me.btnfilter.Location = New System.Drawing.Point(249, 38)
        Me.btnfilter.Name = "btnfilter"
        Me.btnfilter.Size = New System.Drawing.Size(75, 23)
        Me.btnfilter.TabIndex = 44
        Me.btnfilter.Text = "Filter"
        Me.btnfilter.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(5, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 16)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Filter Date [From - To]"
        '
        'dtp_to
        '
        Me.dtp_to.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_to.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_to.Location = New System.Drawing.Point(121, 41)
        Me.dtp_to.Name = "dtp_to"
        Me.dtp_to.Size = New System.Drawing.Size(106, 20)
        Me.dtp_to.TabIndex = 42
        '
        'dtp_from
        '
        Me.dtp_from.CalendarFont = New System.Drawing.Font("Microsoft Tai Le", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_from.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_from.Location = New System.Drawing.Point(11, 41)
        Me.dtp_from.Name = "dtp_from"
        Me.dtp_from.Size = New System.Drawing.Size(101, 20)
        Me.dtp_from.TabIndex = 41
        Me.dtp_from.Value = New Date(2023, 12, 28, 14, 50, 38, 0)
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 77)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(885, 407)
        Me.ReportViewer1.TabIndex = 40
        '
        'printpreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(891, 485)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txt_dailysalessearch)
        Me.Controls.Add(Me.btnfilter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtp_to)
        Me.Controls.Add(Me.dtp_from)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "printpreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "printpreview"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txt_dailysalessearch As System.Windows.Forms.TextBox
    Friend WithEvents btnfilter As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtp_to As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_from As System.Windows.Forms.DateTimePicker
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
