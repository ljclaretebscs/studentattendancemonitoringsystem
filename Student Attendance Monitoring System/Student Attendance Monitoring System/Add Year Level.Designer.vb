<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Year_Level
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Year_Level))
        Me.YearLevelTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.SaveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Delete = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ControlForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'YearLevelTxt
        '
        Me.YearLevelTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.YearLevelTxt.BorderRadius = 5
        Me.YearLevelTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.YearLevelTxt.DefaultText = ""
        Me.YearLevelTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.YearLevelTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.YearLevelTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.YearLevelTxt.DisabledState.Parent = Me.YearLevelTxt
        Me.YearLevelTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.YearLevelTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YearLevelTxt.FocusedState.Parent = Me.YearLevelTxt
        Me.YearLevelTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.YearLevelTxt.HoverState.Parent = Me.YearLevelTxt
        Me.YearLevelTxt.Location = New System.Drawing.Point(22, 63)
        Me.YearLevelTxt.Name = "YearLevelTxt"
        Me.YearLevelTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.YearLevelTxt.PlaceholderText = ""
        Me.YearLevelTxt.SelectedText = ""
        Me.YearLevelTxt.ShadowDecoration.Parent = Me.YearLevelTxt
        Me.YearLevelTxt.Size = New System.Drawing.Size(284, 30)
        Me.YearLevelTxt.TabIndex = 0
        '
        'SaveBtn
        '
        Me.SaveBtn.BackColor = System.Drawing.Color.White
        Me.SaveBtn.CheckedState.Parent = Me.SaveBtn
        Me.SaveBtn.CustomImages.Parent = Me.SaveBtn
        Me.SaveBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.SaveBtn.ForeColor = System.Drawing.Color.White
        Me.SaveBtn.HoverState.Parent = Me.SaveBtn
        Me.SaveBtn.Location = New System.Drawing.Point(312, 63)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.ShadowDecoration.Parent = Me.SaveBtn
        Me.SaveBtn.Size = New System.Drawing.Size(102, 30)
        Me.SaveBtn.TabIndex = 1
        Me.SaveBtn.Text = "SAVE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Year Level"
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
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Delete})
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
        Me.StudentDataGridView.Location = New System.Drawing.Point(22, 99)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        Me.StudentDataGridView.RowHeadersVisible = False
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(392, 166)
        Me.StudentDataGridView.TabIndex = 3
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
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Delete.HeaderText = ""
        Me.Delete.LinkColor = System.Drawing.Color.Red
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Text = "Delete"
        Me.Delete.UseColumnTextForLinkValue = True
        Me.Delete.VisitedLinkColor = System.Drawing.Color.Red
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(312, 271)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(102, 34)
        Me.CloseBtn.TabIndex = 6
        Me.CloseBtn.Text = "CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(439, 26)
        Me.Panel1.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(169, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ADD YEAR LEVEL"
        '
        'ControlForm
        '
        Me.ControlForm.TargetControl = Me.Panel1
        '
        'Add_Year_Level
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(440, 317)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.YearLevelTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Add_Year_Level"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add_Year_Level"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents YearLevelTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SaveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents StudentDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Delete As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ControlForm As Guna.UI.WinForms.GunaDragControl
End Class
