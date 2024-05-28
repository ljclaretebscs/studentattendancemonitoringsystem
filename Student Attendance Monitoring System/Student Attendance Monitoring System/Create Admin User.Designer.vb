<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Create_Admin_User
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Create_Admin_User))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.CreateUserBtn = New System.Windows.Forms.Button()
        Me.ConfirmPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UsernameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ControlForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.FacilitatorNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(430, 30)
        Me.Panel1.TabIndex = 43
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(108, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CREATE ADMINISTRATOR ACCOUNT"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Confirm Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Username"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(341, 270)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(72, 42)
        Me.CloseBtn.TabIndex = 38
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'CreateUserBtn
        '
        Me.CreateUserBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.CreateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateUserBtn.ForeColor = System.Drawing.Color.White
        Me.CreateUserBtn.Location = New System.Drawing.Point(254, 270)
        Me.CreateUserBtn.Name = "CreateUserBtn"
        Me.CreateUserBtn.Size = New System.Drawing.Size(85, 42)
        Me.CreateUserBtn.TabIndex = 39
        Me.CreateUserBtn.Text = "Create User"
        Me.CreateUserBtn.UseVisualStyleBackColor = False
        '
        'ConfirmPasswordTxt
        '
        Me.ConfirmPasswordTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ConfirmPasswordTxt.BorderRadius = 5
        Me.ConfirmPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ConfirmPasswordTxt.DefaultText = ""
        Me.ConfirmPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ConfirmPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ConfirmPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPasswordTxt.DisabledState.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ConfirmPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPasswordTxt.FocusedState.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.ConfirmPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ConfirmPasswordTxt.HoverState.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.Location = New System.Drawing.Point(7, 225)
        Me.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt"
        Me.ConfirmPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConfirmPasswordTxt.PlaceholderText = ""
        Me.ConfirmPasswordTxt.SelectedText = ""
        Me.ConfirmPasswordTxt.ShadowDecoration.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.Size = New System.Drawing.Size(404, 36)
        Me.ConfirmPasswordTxt.TabIndex = 35
        Me.ConfirmPasswordTxt.UseSystemPasswordChar = True
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.PasswordTxt.Location = New System.Drawing.Point(7, 170)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTxt.PlaceholderText = ""
        Me.PasswordTxt.SelectedText = ""
        Me.PasswordTxt.ShadowDecoration.Parent = Me.PasswordTxt
        Me.PasswordTxt.Size = New System.Drawing.Size(404, 36)
        Me.PasswordTxt.TabIndex = 36
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'UsernameTxt
        '
        Me.UsernameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
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
        Me.UsernameTxt.Location = New System.Drawing.Point(7, 112)
        Me.UsernameTxt.Name = "UsernameTxt"
        Me.UsernameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UsernameTxt.PlaceholderText = ""
        Me.UsernameTxt.SelectedText = ""
        Me.UsernameTxt.ShadowDecoration.Parent = Me.UsernameTxt
        Me.UsernameTxt.Size = New System.Drawing.Size(404, 39)
        Me.UsernameTxt.TabIndex = 37
        '
        'ControlForm
        '
        Me.ControlForm.TargetControl = Me.Panel1
        '
        'FacilitatorNameTxt
        '
        Me.FacilitatorNameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FacilitatorNameTxt.BorderRadius = 5
        Me.FacilitatorNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FacilitatorNameTxt.DefaultText = ""
        Me.FacilitatorNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FacilitatorNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FacilitatorNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FacilitatorNameTxt.DisabledState.Parent = Me.FacilitatorNameTxt
        Me.FacilitatorNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FacilitatorNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FacilitatorNameTxt.FocusedState.Parent = Me.FacilitatorNameTxt
        Me.FacilitatorNameTxt.ForeColor = System.Drawing.Color.Black
        Me.FacilitatorNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FacilitatorNameTxt.HoverState.Parent = Me.FacilitatorNameTxt
        Me.FacilitatorNameTxt.Location = New System.Drawing.Point(9, 57)
        Me.FacilitatorNameTxt.Name = "FacilitatorNameTxt"
        Me.FacilitatorNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FacilitatorNameTxt.PlaceholderText = ""
        Me.FacilitatorNameTxt.SelectedText = ""
        Me.FacilitatorNameTxt.ShadowDecoration.Parent = Me.FacilitatorNameTxt
        Me.FacilitatorNameTxt.Size = New System.Drawing.Size(404, 36)
        Me.FacilitatorNameTxt.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Facilitator Full Name"
        '
        'Create_Admin_User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(427, 325)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.CreateUserBtn)
        Me.Controls.Add(Me.ConfirmPasswordTxt)
        Me.Controls.Add(Me.PasswordTxt)
        Me.Controls.Add(Me.FacilitatorNameTxt)
        Me.Controls.Add(Me.UsernameTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Create_Admin_User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create_Admin_User"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents CreateUserBtn As System.Windows.Forms.Button
    Friend WithEvents ConfirmPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UsernameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ControlForm As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents FacilitatorNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
