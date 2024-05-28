<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.UsernameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.CloseBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.LoginBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.FormControl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.WarningLbl = New System.Windows.Forms.Label()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameTxt
        '
        Me.UsernameTxt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UsernameTxt.BorderRadius = 5
        Me.UsernameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UsernameTxt.DefaultText = ""
        Me.UsernameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UsernameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UsernameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxt.DisabledState.Parent = Me.UsernameTxt
        Me.UsernameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UsernameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxt.FocusedState.Parent = Me.UsernameTxt
        Me.UsernameTxt.ForeColor = System.Drawing.Color.Black
        Me.UsernameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UsernameTxt.HoverState.Parent = Me.UsernameTxt
        Me.UsernameTxt.Location = New System.Drawing.Point(535, 302)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxt.PlaceholderForeColor = System.Drawing.Color.Black
        Me.UsernameTxt.PlaceholderText = ""
        Me.UsernameTxt.SelectedText = ""
        Me.UsernameTxt.ShadowDecoration.Parent = Me.UsernameTxt
        Me.UsernameTxt.Size = New System.Drawing.Size(356, 35)
        Me.UsernameTxt.TabIndex = 1
        '
        'PasswordTxt
        '
        Me.PasswordTxt.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.PasswordTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PasswordTxt.BorderRadius = 5
        Me.PasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTxt.DefaultText = ""
        Me.PasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.DisabledState.Parent = Me.PasswordTxt
        Me.PasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.FocusedState.Parent = Me.PasswordTxt
        Me.PasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.PasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTxt.HoverState.Parent = Me.PasswordTxt
        Me.PasswordTxt.Location = New System.Drawing.Point(535, 376)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTxt.PlaceholderText = ""
        Me.PasswordTxt.SelectedText = ""
        Me.PasswordTxt.ShadowDecoration.Parent = Me.PasswordTxt
        Me.PasswordTxt.Size = New System.Drawing.Size(356, 35)
        Me.PasswordTxt.TabIndex = 2
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Guna2Button1)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(933, 32)
        Me.Panel1.TabIndex = 2
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(859, 3)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(34, 26)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "-"
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.CheckedState.Parent = Me.CloseBtn
        Me.CloseBtn.CustomImages.Parent = Me.CloseBtn
        Me.CloseBtn.FillColor = System.Drawing.Color.Transparent
        Me.CloseBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.HoverState.Parent = Me.CloseBtn
        Me.CloseBtn.Location = New System.Drawing.Point(899, 3)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.ShadowDecoration.Parent = Me.CloseBtn
        Me.CloseBtn.Size = New System.Drawing.Size(34, 26)
        Me.CloseBtn.TabIndex = 5
        Me.CloseBtn.Text = "X"
        '
        'LoginBtn
        '
        Me.LoginBtn.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.LoginBtn.AutoRoundedCorners = True
        Me.LoginBtn.BorderRadius = 19
        Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
        Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
        Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginBtn.ForeColor = System.Drawing.Color.White
        Me.LoginBtn.HoverState.Parent = Me.LoginBtn
        Me.LoginBtn.Location = New System.Drawing.Point(535, 452)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
        Me.LoginBtn.Size = New System.Drawing.Size(356, 40)
        Me.LoginBtn.TabIndex = 3
        Me.LoginBtn.Text = "LOGIN"
        '
        'FormControl
        '
        Me.FormControl.TargetControl = Me.Panel1
        '
        'WarningLbl
        '
        Me.WarningLbl.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.WarningLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WarningLbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.WarningLbl.Location = New System.Drawing.Point(535, 225)
        Me.WarningLbl.Name = "WarningLbl"
        Me.WarningLbl.Size = New System.Drawing.Size(356, 51)
        Me.WarningLbl.TabIndex = 5
        Me.WarningLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 19
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(535, 500)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(356, 40)
        Me.Guna2Button2.TabIndex = 4
        Me.Guna2Button2.Text = "ATTENDANCE NOW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(599, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 25)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "ADMINISTRATOR LOGIN"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(539, 420)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(102, 17)
        Me.CheckBox1.TabIndex = 9
        Me.CheckBox1.Text = "Show Password"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.Student_Attendance_Monitoring_System.My.Resources.Resources.received_547280115974431
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(-1, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(493, 531)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = Global.Student_Attendance_Monitoring_System.My.Resources.Resources.user1
        Me.PictureBox2.Location = New System.Drawing.Point(648, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(115, 119)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(533, 278)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "USERNAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(536, 351)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "PASSWORD"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(932, 563)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WarningLbl)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.UsernameTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "d"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UsernameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LoginBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FormControl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents WarningLbl As System.Windows.Forms.Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CloseBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
