<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditStudent))
        Me.SearchTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StudentDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.EditStud = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoadStudBtn = New Guna.UI2.WinForms.Guna2Button()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SearchTxt
        '
        Me.SearchTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchTxt.BorderRadius = 5
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
        Me.SearchTxt.Location = New System.Drawing.Point(12, 20)
        Me.SearchTxt.Name = "SearchTxt"
        Me.SearchTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchTxt.PlaceholderText = "Search Student"
        Me.SearchTxt.SelectedText = ""
        Me.SearchTxt.ShadowDecoration.Parent = Me.SearchTxt
        Me.SearchTxt.Size = New System.Drawing.Size(365, 32)
        Me.SearchTxt.TabIndex = 3
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
        Me.StudentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EditStud})
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
        Me.StudentDataGridView.Location = New System.Drawing.Point(13, 58)
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        Me.StudentDataGridView.RowHeadersVisible = False
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(779, 555)
        Me.StudentDataGridView.TabIndex = 2
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
        'EditStud
        '
        Me.EditStud.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.EditStud.HeaderText = ""
        Me.EditStud.Name = "EditStud"
        Me.EditStud.ReadOnly = True
        Me.EditStud.Text = "Edit Student"
        Me.EditStud.UseColumnTextForLinkValue = True
        Me.EditStud.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'LoadStudBtn
        '
        Me.LoadStudBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoadStudBtn.BorderRadius = 5
        Me.LoadStudBtn.CheckedState.Parent = Me.LoadStudBtn
        Me.LoadStudBtn.CustomImages.Parent = Me.LoadStudBtn
        Me.LoadStudBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.LoadStudBtn.ForeColor = System.Drawing.Color.White
        Me.LoadStudBtn.HoverState.Parent = Me.LoadStudBtn
        Me.LoadStudBtn.Location = New System.Drawing.Point(663, 20)
        Me.LoadStudBtn.Name = "LoadStudBtn"
        Me.LoadStudBtn.ShadowDecoration.Parent = Me.LoadStudBtn
        Me.LoadStudBtn.Size = New System.Drawing.Size(129, 32)
        Me.LoadStudBtn.TabIndex = 5
        Me.LoadStudBtn.Text = "Load Your Student"
        '
        'EditStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(804, 633)
        Me.Controls.Add(Me.LoadStudBtn)
        Me.Controls.Add(Me.SearchTxt)
        Me.Controls.Add(Me.StudentDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EditStudent"
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SearchTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StudentDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents EditStud As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents LoadStudBtn As Guna.UI2.WinForms.Guna2Button
End Class
