<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GenerateQrCode
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenerateQrCode))
        Me.SaveQrcodeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.CreateQRcodeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SaveFileQrcode = New System.Windows.Forms.SaveFileDialog()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SaveQrcodeBtn
        '
        Me.SaveQrcodeBtn.BorderRadius = 5
        Me.SaveQrcodeBtn.CheckedState.Parent = Me.SaveQrcodeBtn
        Me.SaveQrcodeBtn.CustomImages.Parent = Me.SaveQrcodeBtn
        Me.SaveQrcodeBtn.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.SaveQrcodeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveQrcodeBtn.ForeColor = System.Drawing.Color.White
        Me.SaveQrcodeBtn.HoverState.Parent = Me.SaveQrcodeBtn
        Me.SaveQrcodeBtn.Location = New System.Drawing.Point(117, 145)
        Me.SaveQrcodeBtn.Name = "SaveQrcodeBtn"
        Me.SaveQrcodeBtn.ShadowDecoration.Parent = Me.SaveQrcodeBtn
        Me.SaveQrcodeBtn.Size = New System.Drawing.Size(68, 42)
        Me.SaveQrcodeBtn.TabIndex = 7
        Me.SaveQrcodeBtn.Text = "Save Qr Code"
        '
        'CreateQRcodeBtn
        '
        Me.CreateQRcodeBtn.BorderRadius = 5
        Me.CreateQRcodeBtn.CheckedState.Parent = Me.CreateQRcodeBtn
        Me.CreateQRcodeBtn.CustomImages.Parent = Me.CreateQRcodeBtn
        Me.CreateQRcodeBtn.FillColor = System.Drawing.Color.CornflowerBlue
        Me.CreateQRcodeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.CreateQRcodeBtn.ForeColor = System.Drawing.Color.White
        Me.CreateQRcodeBtn.HoverState.Parent = Me.CreateQRcodeBtn
        Me.CreateQRcodeBtn.Location = New System.Drawing.Point(48, 145)
        Me.CreateQRcodeBtn.Name = "CreateQRcodeBtn"
        Me.CreateQRcodeBtn.ShadowDecoration.Parent = Me.CreateQRcodeBtn
        Me.CreateQRcodeBtn.Size = New System.Drawing.Size(63, 42)
        Me.CreateQRcodeBtn.TabIndex = 6
        Me.CreateQRcodeBtn.Text = "Generate Qr Code"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Attendance_Monitoring_System.My.Resources.Resources.barcode
        Me.PictureBox1.Location = New System.Drawing.Point(48, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(137, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(150, 205)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(75, 24)
        Me.CloseBtn.TabIndex = 8
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'GenerateQrCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(237, 241)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.SaveQrcodeBtn)
        Me.Controls.Add(Me.CreateQRcodeBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GenerateQrCode"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GenerateQrCode"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveQrcodeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CreateQRcodeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SaveFileQrcode As System.Windows.Forms.SaveFileDialog
End Class
