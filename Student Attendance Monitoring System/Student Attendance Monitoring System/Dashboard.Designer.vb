<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TodayAttendanceLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TotalUserStudentLbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DatePickerAttendance = New Guna.UI.WinForms.GunaDateTimePicker()
        Me.TotalAttendanceLbl = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.countalltimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(189, Byte), Integer))
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Controls.Add(Me.TodayAttendanceLbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(13, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 77)
        Me.Panel1.TabIndex = 0
        '
        'TodayAttendanceLbl
        '
        Me.TodayAttendanceLbl.AutoSize = True
        Me.TodayAttendanceLbl.BackColor = System.Drawing.Color.Transparent
        Me.TodayAttendanceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TodayAttendanceLbl.ForeColor = System.Drawing.Color.White
        Me.TodayAttendanceLbl.Location = New System.Drawing.Point(15, 38)
        Me.TodayAttendanceLbl.Name = "TodayAttendanceLbl"
        Me.TodayAttendanceLbl.Size = New System.Drawing.Size(30, 31)
        Me.TodayAttendanceLbl.TabIndex = 0
        Me.TodayAttendanceLbl.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(180, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Today Attendance"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(198, Byte), Integer), CType(CType(151, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Controls.Add(Me.TotalUserStudentLbl)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(247, 13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(228, 77)
        Me.Panel2.TabIndex = 0
        '
        'TotalUserStudentLbl
        '
        Me.TotalUserStudentLbl.AutoSize = True
        Me.TotalUserStudentLbl.BackColor = System.Drawing.Color.Transparent
        Me.TotalUserStudentLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalUserStudentLbl.ForeColor = System.Drawing.Color.White
        Me.TotalUserStudentLbl.Location = New System.Drawing.Point(16, 38)
        Me.TotalUserStudentLbl.Name = "TotalUserStudentLbl"
        Me.TotalUserStudentLbl.Size = New System.Drawing.Size(30, 31)
        Me.TotalUserStudentLbl.TabIndex = 0
        Me.TotalUserStudentLbl.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(3, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total User Students"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(178, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(104, Byte), Integer))
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Controls.Add(Me.DatePickerAttendance)
        Me.Panel3.Controls.Add(Me.TotalAttendanceLbl)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(481, 13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(275, 77)
        Me.Panel3.TabIndex = 0
        '
        'DatePickerAttendance
        '
        Me.DatePickerAttendance.BackColor = System.Drawing.Color.Transparent
        Me.DatePickerAttendance.BaseColor = System.Drawing.Color.Transparent
        Me.DatePickerAttendance.BorderColor = System.Drawing.Color.Transparent
        Me.DatePickerAttendance.CustomFormat = "MMMM-dd-yyyy"
        Me.DatePickerAttendance.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.DatePickerAttendance.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatePickerAttendance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePickerAttendance.ForeColor = System.Drawing.Color.White
        Me.DatePickerAttendance.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePickerAttendance.Location = New System.Drawing.Point(101, 38)
        Me.DatePickerAttendance.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePickerAttendance.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePickerAttendance.Name = "DatePickerAttendance"
        Me.DatePickerAttendance.OnHoverBaseColor = System.Drawing.Color.White
        Me.DatePickerAttendance.OnHoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatePickerAttendance.OnHoverForeColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DatePickerAttendance.OnPressedColor = System.Drawing.Color.Black
        Me.DatePickerAttendance.Size = New System.Drawing.Size(171, 30)
        Me.DatePickerAttendance.TabIndex = 1
        Me.DatePickerAttendance.Text = "November-18-2022"
        Me.DatePickerAttendance.Value = New Date(2022, 11, 18, 5, 17, 43, 268)
        '
        'TotalAttendanceLbl
        '
        Me.TotalAttendanceLbl.AutoSize = True
        Me.TotalAttendanceLbl.BackColor = System.Drawing.Color.Transparent
        Me.TotalAttendanceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAttendanceLbl.ForeColor = System.Drawing.Color.White
        Me.TotalAttendanceLbl.Location = New System.Drawing.Point(17, 38)
        Me.TotalAttendanceLbl.Name = "TotalAttendanceLbl"
        Me.TotalAttendanceLbl.Size = New System.Drawing.Size(30, 31)
        Me.TotalAttendanceLbl.TabIndex = 0
        Me.TotalAttendanceLbl.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(3, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 24)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Total Attendance "
        '
        'countalltimer
        '
        Me.countalltimer.Enabled = True
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 633)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "r"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TodayAttendanceLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents TotalUserStudentLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TotalAttendanceLbl As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DatePickerAttendance As Guna.UI.WinForms.GunaDateTimePicker
    Friend WithEvents countalltimer As System.Windows.Forms.Timer
End Class
