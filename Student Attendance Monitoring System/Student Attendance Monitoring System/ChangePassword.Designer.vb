<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.UpdatePasswordBtn = New System.Windows.Forms.Button()
        Me.ConfirmPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.OldPasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PasswordTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ControlForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
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
        Me.Panel1.Size = New System.Drawing.Size(417, 30)
        Me.Panel1.TabIndex = 49
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(143, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "CHANGE PASSWORD"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(12, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Confirm Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(15, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Old Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "New Password"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(334, 247)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(68, 41)
        Me.CloseBtn.TabIndex = 44
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'UpdatePasswordBtn
        '
        Me.UpdatePasswordBtn.BackColor = System.Drawing.SystemColors.Highlight
        Me.UpdatePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.UpdatePasswordBtn.ForeColor = System.Drawing.Color.White
        Me.UpdatePasswordBtn.Location = New System.Drawing.Point(215, 247)
        Me.UpdatePasswordBtn.Name = "UpdatePasswordBtn"
        Me.UpdatePasswordBtn.Size = New System.Drawing.Size(113, 41)
        Me.UpdatePasswordBtn.TabIndex = 45
        Me.UpdatePasswordBtn.Text = "Update Password"
        Me.UpdatePasswordBtn.UseVisualStyleBackColor = False
        '
        'ConfirmPasswordTxt
        '
        Me.ConfirmPasswordTxt.BorderColor = System.Drawing.Color.Black
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
        Me.ConfirmPasswordTxt.Location = New System.Drawing.Point(12, 193)
        Me.ConfirmPasswordTxt.Name = "ConfirmPasswordTxt"
        Me.ConfirmPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ConfirmPasswordTxt.PlaceholderText = ""
        Me.ConfirmPasswordTxt.SelectedText = ""
        Me.ConfirmPasswordTxt.ShadowDecoration.Parent = Me.ConfirmPasswordTxt
        Me.ConfirmPasswordTxt.Size = New System.Drawing.Size(390, 36)
        Me.ConfirmPasswordTxt.TabIndex = 41
        Me.ConfirmPasswordTxt.UseSystemPasswordChar = True
        '
        'OldPasswordTxt
        '
        Me.OldPasswordTxt.BorderColor = System.Drawing.Color.Black
        Me.OldPasswordTxt.BorderRadius = 5
        Me.OldPasswordTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.OldPasswordTxt.DefaultText = ""
        Me.OldPasswordTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.OldPasswordTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.OldPasswordTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OldPasswordTxt.DisabledState.Parent = Me.OldPasswordTxt
        Me.OldPasswordTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.OldPasswordTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OldPasswordTxt.FocusedState.Parent = Me.OldPasswordTxt
        Me.OldPasswordTxt.ForeColor = System.Drawing.Color.Black
        Me.OldPasswordTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.OldPasswordTxt.HoverState.Parent = Me.OldPasswordTxt
        Me.OldPasswordTxt.Location = New System.Drawing.Point(15, 75)
        Me.OldPasswordTxt.Name = "OldPasswordTxt"
        Me.OldPasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.OldPasswordTxt.PlaceholderText = ""
        Me.OldPasswordTxt.SelectedText = ""
        Me.OldPasswordTxt.ShadowDecoration.Parent = Me.OldPasswordTxt
        Me.OldPasswordTxt.Size = New System.Drawing.Size(390, 36)
        Me.OldPasswordTxt.TabIndex = 42
        Me.OldPasswordTxt.UseSystemPasswordChar = True
        '
        'PasswordTxt
        '
        Me.PasswordTxt.BorderColor = System.Drawing.Color.Black
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
        Me.PasswordTxt.Location = New System.Drawing.Point(12, 138)
        Me.PasswordTxt.Name = "PasswordTxt"
        Me.PasswordTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PasswordTxt.PlaceholderText = ""
        Me.PasswordTxt.SelectedText = ""
        Me.PasswordTxt.ShadowDecoration.Parent = Me.PasswordTxt
        Me.PasswordTxt.Size = New System.Drawing.Size(390, 36)
        Me.PasswordTxt.TabIndex = 43
        Me.PasswordTxt.UseSystemPasswordChar = True
        '
        'ControlForm
        '
        Me.ControlForm.TargetControl = Me.Panel1
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(416, 292)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.UpdatePasswordBtn)
        Me.Controls.Add(Me.ConfirmPasswordTxt)
        Me.Controls.Add(Me.OldPasswordTxt)
        Me.Controls.Add(Me.PasswordTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents UpdatePasswordBtn As System.Windows.Forms.Button
    Friend WithEvents ConfirmPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents OldPasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ControlForm As Guna.UI.WinForms.GunaDragControl
End Class
