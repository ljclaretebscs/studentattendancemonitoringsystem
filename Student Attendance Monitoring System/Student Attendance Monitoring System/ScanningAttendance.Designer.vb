<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScanningAttendance
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScanningAttendance))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StudentIDTxt = New System.Windows.Forms.Label()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.Scanner = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timedate = New System.Windows.Forms.Timer(Me.components)
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.StudentNameTxt = New System.Windows.Forms.Label()
        Me.AttendanceCB = New Guna.UI.WinForms.GunaComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.formcontrol = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.WarningLbl = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 212)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'StudentIDTxt
        '
        Me.StudentIDTxt.BackColor = System.Drawing.Color.White
        Me.StudentIDTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentIDTxt.ForeColor = System.Drawing.Color.Black
        Me.StudentIDTxt.Location = New System.Drawing.Point(229, 261)
        Me.StudentIDTxt.Name = "StudentIDTxt"
        Me.StudentIDTxt.Size = New System.Drawing.Size(397, 25)
        Me.StudentIDTxt.TabIndex = 1
        Me.StudentIDTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLbl
        '
        Me.TimeLbl.AutoSize = True
        Me.TimeLbl.BackColor = System.Drawing.Color.White
        Me.TimeLbl.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.TimeLbl.ForeColor = System.Drawing.Color.Black
        Me.TimeLbl.Location = New System.Drawing.Point(362, 52)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(75, 37)
        Me.TimeLbl.TabIndex = 1
        Me.TimeLbl.Text = "Time"
        '
        'Scanner
        '
        Me.Scanner.Enabled = True
        Me.Scanner.Interval = 8000
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(669, 29)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(258, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Scanning Attendance"
        '
        'timedate
        '
        Me.timedate.Enabled = True
        '
        'DateLbl
        '
        Me.DateLbl.AutoSize = True
        Me.DateLbl.BackColor = System.Drawing.Color.White
        Me.DateLbl.Font = New System.Drawing.Font("Segoe UI", 20.0!)
        Me.DateLbl.ForeColor = System.Drawing.Color.Black
        Me.DateLbl.Location = New System.Drawing.Point(364, 108)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(73, 37)
        Me.DateLbl.TabIndex = 1
        Me.DateLbl.Text = "Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(266, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 32)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "TIME:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(266, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 32)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "DATE:"
        '
        'StudentNameTxt
        '
        Me.StudentNameTxt.BackColor = System.Drawing.Color.White
        Me.StudentNameTxt.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentNameTxt.ForeColor = System.Drawing.Color.Black
        Me.StudentNameTxt.Location = New System.Drawing.Point(231, 307)
        Me.StudentNameTxt.Name = "StudentNameTxt"
        Me.StudentNameTxt.Size = New System.Drawing.Size(395, 25)
        Me.StudentNameTxt.TabIndex = 1
        Me.StudentNameTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AttendanceCB
        '
        Me.AttendanceCB.BackColor = System.Drawing.Color.Transparent
        Me.AttendanceCB.BaseColor = System.Drawing.Color.White
        Me.AttendanceCB.BorderColor = System.Drawing.Color.Silver
        Me.AttendanceCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.AttendanceCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AttendanceCB.FocusedColor = System.Drawing.Color.Empty
        Me.AttendanceCB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.AttendanceCB.ForeColor = System.Drawing.Color.Black
        Me.AttendanceCB.FormattingEnabled = True
        Me.AttendanceCB.Items.AddRange(New Object() {"Time In", "Time Out"})
        Me.AttendanceCB.Location = New System.Drawing.Point(273, 197)
        Me.AttendanceCB.Name = "AttendanceCB"
        Me.AttendanceCB.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AttendanceCB.OnHoverItemForeColor = System.Drawing.Color.White
        Me.AttendanceCB.Size = New System.Drawing.Size(353, 26)
        Me.AttendanceCB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(269, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CHOOSE ATTENDANCE"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(549, 417)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(108, 37)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'formcontrol
        '
        Me.formcontrol.TargetControl = Me.Panel1
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(53, 275)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(146, 137)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'WarningLbl
        '
        Me.WarningLbl.BackColor = System.Drawing.Color.White
        Me.WarningLbl.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLbl.ForeColor = System.Drawing.Color.Red
        Me.WarningLbl.Location = New System.Drawing.Point(231, 340)
        Me.WarningLbl.Name = "WarningLbl"
        Me.WarningLbl.Size = New System.Drawing.Size(395, 84)
        Me.WarningLbl.TabIndex = 1
        Me.WarningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ScanningAttendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(669, 466)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.AttendanceCB)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DateLbl)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TimeLbl)
        Me.Controls.Add(Me.WarningLbl)
        Me.Controls.Add(Me.StudentNameTxt)
        Me.Controls.Add(Me.StudentIDTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ScanningAttendance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ScanningAttendance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents StudentIDTxt As System.Windows.Forms.Label
    Friend WithEvents TimeLbl As System.Windows.Forms.Label
    Friend WithEvents Scanner As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents timedate As System.Windows.Forms.Timer
    Friend WithEvents DateLbl As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentNameTxt As System.Windows.Forms.Label
    Friend WithEvents AttendanceCB As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents formcontrol As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents WarningLbl As System.Windows.Forms.Label
End Class
