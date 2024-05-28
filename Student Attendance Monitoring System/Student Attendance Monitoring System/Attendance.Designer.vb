<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Attendance
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Attendance))
        Me.SearchTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StudentDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimeOutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.TimeInBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AllBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTxt
        '
        Me.SearchTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchTxt.BorderRadius = 5
        Me.SearchTxt.BorderThickness = 2
        Me.SearchTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchTxt.DefaultText = ""
        Me.SearchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTxt.DisabledState.Parent = Me.SearchTxt
        Me.SearchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTxt.FocusedState.Parent = Me.SearchTxt
        Me.SearchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchTxt.HoverState.Parent = Me.SearchTxt
        Me.SearchTxt.Location = New System.Drawing.Point(12, 12)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTxt.PlaceholderText = "Search Student"
        Me.SearchTxt.SelectedText = ""
        Me.SearchTxt.ShadowDecoration.Parent = Me.SearchTxt
        Me.SearchTxt.Size = New System.Drawing.Size(390, 40)
        Me.SearchTxt.TabIndex = 5
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        Me.StudentDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.StudentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StudentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentDataGridView.ColumnHeadersHeight = 20
        Me.StudentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentDataGridView.EnableHeadersVisualStyles = False
        Me.StudentDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.StudentDataGridView.Location = New System.Drawing.Point(13, 61)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        Me.StudentDataGridView.RowHeadersVisible = False
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(779, 555)
        Me.StudentDataGridView.TabIndex = 4
        Me.StudentDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(201, Byte), Integer), CType(CType(197, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(188, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(76, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.Height = 20
        Me.StudentDataGridView.ThemeStyle.ReadOnly = True
        Me.StudentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(249, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(216, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.StudentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.StudentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'TimeOutBtn
        '
        Me.TimeOutBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeOutBtn.BorderRadius = 10
        Me.TimeOutBtn.CheckedState.Parent = Me.TimeOutBtn
        Me.TimeOutBtn.CustomImages.Parent = Me.TimeOutBtn
        Me.TimeOutBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(247, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.TimeOutBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOutBtn.ForeColor = System.Drawing.Color.White
        Me.TimeOutBtn.HoverState.Parent = Me.TimeOutBtn
        Me.TimeOutBtn.Location = New System.Drawing.Point(712, 12)
        Me.TimeOutBtn.Name = "TimeOutBtn"
        Me.TimeOutBtn.ShadowDecoration.Parent = Me.TimeOutBtn
        Me.TimeOutBtn.Size = New System.Drawing.Size(80, 40)
        Me.TimeOutBtn.TabIndex = 6
        Me.TimeOutBtn.Text = "Time Out"
        '
        'TimeInBtn
        '
        Me.TimeInBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TimeInBtn.BorderRadius = 10
        Me.TimeInBtn.CheckedState.Parent = Me.TimeInBtn
        Me.TimeInBtn.CustomImages.Parent = Me.TimeInBtn
        Me.TimeInBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(223, Byte), Integer), CType(CType(46, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.TimeInBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeInBtn.ForeColor = System.Drawing.Color.White
        Me.TimeInBtn.HoverState.Parent = Me.TimeInBtn
        Me.TimeInBtn.Location = New System.Drawing.Point(641, 12)
        Me.TimeInBtn.Name = "TimeInBtn"
        Me.TimeInBtn.ShadowDecoration.Parent = Me.TimeInBtn
        Me.TimeInBtn.Size = New System.Drawing.Size(67, 40)
        Me.TimeInBtn.TabIndex = 7
        Me.TimeInBtn.Text = "Time In"
        '
        'AllBtn
        '
        Me.AllBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AllBtn.BorderRadius = 10
        Me.AllBtn.CheckedState.Parent = Me.AllBtn
        Me.AllBtn.CustomImages.Parent = Me.AllBtn
        Me.AllBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AllBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AllBtn.ForeColor = System.Drawing.Color.White
        Me.AllBtn.HoverState.Parent = Me.AllBtn
        Me.AllBtn.Location = New System.Drawing.Point(570, 12)
        Me.AllBtn.Name = "AllBtn"
        Me.AllBtn.ShadowDecoration.Parent = Me.AllBtn
        Me.AllBtn.Size = New System.Drawing.Size(67, 40)
        Me.AllBtn.TabIndex = 7
        Me.AllBtn.Text = "All"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(167, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(420, 12)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(144, 40)
        Me.Guna2Button1.TabIndex = 7
        Me.Guna2Button1.Text = "Today Attendance"
        '
        'Attendance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 633)
        Me.Controls.Add(Me.TimeOutBtn)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.AllBtn)
        Me.Controls.Add(Me.TimeInBtn)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Attendance"
        Me.Text = "Attendance"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StudentDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TimeOutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TimeInBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AllBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
End Class
