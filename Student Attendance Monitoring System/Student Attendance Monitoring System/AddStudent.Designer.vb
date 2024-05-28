<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.FirstNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MiddleNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LastNameTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.StudentIDTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.SaveFileQrcode = New System.Windows.Forms.SaveFileDialog()
        Me.AddressTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SectionCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GenderCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.YearLevelCB = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.ContactPersonTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PhoneNumberTxt = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SaveStudentBtn = New System.Windows.Forms.Button()
        Me.UploadQrCodeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.GenerateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ControlForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.UploadStudentPictureBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FirstNameTxt
        '
        Me.FirstNameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FirstNameTxt.BorderRadius = 5
        Me.FirstNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.FirstNameTxt.DefaultText = ""
        Me.FirstNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.FirstNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.FirstNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTxt.DisabledState.Parent = Me.FirstNameTxt
        Me.FirstNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.FirstNameTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.FirstNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTxt.FocusedState.Parent = Me.FirstNameTxt
        Me.FirstNameTxt.ForeColor = System.Drawing.Color.Black
        Me.FirstNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.FirstNameTxt.HoverState.Parent = Me.FirstNameTxt
        Me.FirstNameTxt.Location = New System.Drawing.Point(160, 126)
        Me.FirstNameTxt.Name = "FirstNameTxt"
        Me.FirstNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.FirstNameTxt.PlaceholderText = ""
        Me.FirstNameTxt.SelectedText = ""
        Me.FirstNameTxt.ShadowDecoration.Parent = Me.FirstNameTxt
        Me.FirstNameTxt.Size = New System.Drawing.Size(157, 31)
        Me.FirstNameTxt.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(160, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "First Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(651, 31)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(285, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ADD NEW STUDENT"
        '
        'MiddleNameTxt
        '
        Me.MiddleNameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MiddleNameTxt.BorderRadius = 5
        Me.MiddleNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.MiddleNameTxt.DefaultText = ""
        Me.MiddleNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.MiddleNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.MiddleNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MiddleNameTxt.DisabledState.Parent = Me.MiddleNameTxt
        Me.MiddleNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.MiddleNameTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.MiddleNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MiddleNameTxt.FocusedState.Parent = Me.MiddleNameTxt
        Me.MiddleNameTxt.ForeColor = System.Drawing.Color.Black
        Me.MiddleNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MiddleNameTxt.HoverState.Parent = Me.MiddleNameTxt
        Me.MiddleNameTxt.Location = New System.Drawing.Point(323, 126)
        Me.MiddleNameTxt.Name = "MiddleNameTxt"
        Me.MiddleNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MiddleNameTxt.PlaceholderText = ""
        Me.MiddleNameTxt.SelectedText = ""
        Me.MiddleNameTxt.ShadowDecoration.Parent = Me.MiddleNameTxt
        Me.MiddleNameTxt.Size = New System.Drawing.Size(157, 31)
        Me.MiddleNameTxt.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(323, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Middle Name"
        '
        'LastNameTxt
        '
        Me.LastNameTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LastNameTxt.BorderRadius = 5
        Me.LastNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.LastNameTxt.DefaultText = ""
        Me.LastNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.LastNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.LastNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTxt.DisabledState.Parent = Me.LastNameTxt
        Me.LastNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.LastNameTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.LastNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTxt.FocusedState.Parent = Me.LastNameTxt
        Me.LastNameTxt.ForeColor = System.Drawing.Color.Black
        Me.LastNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LastNameTxt.HoverState.Parent = Me.LastNameTxt
        Me.LastNameTxt.Location = New System.Drawing.Point(486, 126)
        Me.LastNameTxt.Name = "LastNameTxt"
        Me.LastNameTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.LastNameTxt.PlaceholderText = ""
        Me.LastNameTxt.SelectedText = ""
        Me.LastNameTxt.ShadowDecoration.Parent = Me.LastNameTxt
        Me.LastNameTxt.Size = New System.Drawing.Size(153, 31)
        Me.LastNameTxt.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(486, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Last Name"
        '
        'StudentIDTxt
        '
        Me.StudentIDTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StudentIDTxt.BorderRadius = 5
        Me.StudentIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StudentIDTxt.DefaultText = ""
        Me.StudentIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StudentIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StudentIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentIDTxt.DisabledState.Parent = Me.StudentIDTxt
        Me.StudentIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StudentIDTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.StudentIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentIDTxt.FocusedState.Parent = Me.StudentIDTxt
        Me.StudentIDTxt.ForeColor = System.Drawing.Color.Black
        Me.StudentIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StudentIDTxt.HoverState.Parent = Me.StudentIDTxt
        Me.StudentIDTxt.Location = New System.Drawing.Point(156, 63)
        Me.StudentIDTxt.Name = "StudentIDTxt"
        Me.StudentIDTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StudentIDTxt.PlaceholderText = ""
        Me.StudentIDTxt.SelectedText = ""
        Me.StudentIDTxt.ShadowDecoration.Parent = Me.StudentIDTxt
        Me.StudentIDTxt.Size = New System.Drawing.Size(483, 31)
        Me.StudentIDTxt.TabIndex = 0
        Me.StudentIDTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(370, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Student ID"
        '
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.Red
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseBtn.ForeColor = System.Drawing.Color.White
        Me.CloseBtn.Location = New System.Drawing.Point(482, 382)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(157, 38)
        Me.CloseBtn.TabIndex = 5
        Me.CloseBtn.Text = "CLOSE"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'AddressTxt
        '
        Me.AddressTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AddressTxt.BorderRadius = 5
        Me.AddressTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.AddressTxt.DefaultText = ""
        Me.AddressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.AddressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.AddressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTxt.DisabledState.Parent = Me.AddressTxt
        Me.AddressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.AddressTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.AddressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTxt.FocusedState.Parent = Me.AddressTxt
        Me.AddressTxt.ForeColor = System.Drawing.Color.Black
        Me.AddressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddressTxt.HoverState.Parent = Me.AddressTxt
        Me.AddressTxt.Location = New System.Drawing.Point(159, 186)
        Me.AddressTxt.Name = "AddressTxt"
        Me.AddressTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.AddressTxt.PlaceholderText = ""
        Me.AddressTxt.SelectedText = ""
        Me.AddressTxt.ShadowDecoration.Parent = Me.AddressTxt
        Me.AddressTxt.Size = New System.Drawing.Size(480, 31)
        Me.AddressTxt.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(159, 167)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Address"
        '
        'SectionCB
        '
        Me.SectionCB.BackColor = System.Drawing.Color.Transparent
        Me.SectionCB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SectionCB.BorderRadius = 5
        Me.SectionCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.SectionCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.SectionCB.FillColor = System.Drawing.Color.WhiteSmoke
        Me.SectionCB.FocusedColor = System.Drawing.Color.Empty
        Me.SectionCB.FocusedState.Parent = Me.SectionCB
        Me.SectionCB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SectionCB.ForeColor = System.Drawing.Color.Black
        Me.SectionCB.FormattingEnabled = True
        Me.SectionCB.HoverState.Parent = Me.SectionCB
        Me.SectionCB.ItemHeight = 27
        Me.SectionCB.Items.AddRange(New Object() {"A"})
        Me.SectionCB.ItemsAppearance.Parent = Me.SectionCB
        Me.SectionCB.Location = New System.Drawing.Point(159, 246)
        Me.SectionCB.Name = "SectionCB"
        Me.SectionCB.ShadowDecoration.Parent = Me.SectionCB
        Me.SectionCB.Size = New System.Drawing.Size(168, 33)
        Me.SectionCB.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(159, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Section"
        '
        'GenderCB
        '
        Me.GenderCB.BackColor = System.Drawing.Color.Transparent
        Me.GenderCB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenderCB.BorderRadius = 5
        Me.GenderCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.GenderCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.GenderCB.FillColor = System.Drawing.Color.WhiteSmoke
        Me.GenderCB.FocusedColor = System.Drawing.Color.Empty
        Me.GenderCB.FocusedState.Parent = Me.GenderCB
        Me.GenderCB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.GenderCB.ForeColor = System.Drawing.Color.Black
        Me.GenderCB.FormattingEnabled = True
        Me.GenderCB.HoverState.Parent = Me.GenderCB
        Me.GenderCB.ItemHeight = 27
        Me.GenderCB.Items.AddRange(New Object() {"Male", "Female"})
        Me.GenderCB.ItemsAppearance.Parent = Me.GenderCB
        Me.GenderCB.Location = New System.Drawing.Point(333, 246)
        Me.GenderCB.Name = "GenderCB"
        Me.GenderCB.ShadowDecoration.Parent = Me.GenderCB
        Me.GenderCB.Size = New System.Drawing.Size(143, 33)
        Me.GenderCB.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(330, 230)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Gender"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(479, 230)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Year Level"
        '
        'YearLevelCB
        '
        Me.YearLevelCB.BackColor = System.Drawing.Color.Transparent
        Me.YearLevelCB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.YearLevelCB.BorderRadius = 5
        Me.YearLevelCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.YearLevelCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.YearLevelCB.FillColor = System.Drawing.Color.WhiteSmoke
        Me.YearLevelCB.FocusedColor = System.Drawing.Color.Empty
        Me.YearLevelCB.FocusedState.Parent = Me.YearLevelCB
        Me.YearLevelCB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.YearLevelCB.ForeColor = System.Drawing.Color.Black
        Me.YearLevelCB.FormattingEnabled = True
        Me.YearLevelCB.HoverState.Parent = Me.YearLevelCB
        Me.YearLevelCB.ItemHeight = 27
        Me.YearLevelCB.Items.AddRange(New Object() {"1st Year"})
        Me.YearLevelCB.ItemsAppearance.Parent = Me.YearLevelCB
        Me.YearLevelCB.Location = New System.Drawing.Point(482, 246)
        Me.YearLevelCB.Name = "YearLevelCB"
        Me.YearLevelCB.ShadowDecoration.Parent = Me.YearLevelCB
        Me.YearLevelCB.Size = New System.Drawing.Size(157, 33)
        Me.YearLevelCB.TabIndex = 6
        '
        'ContactPersonTxt
        '
        Me.ContactPersonTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ContactPersonTxt.BorderRadius = 5
        Me.ContactPersonTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ContactPersonTxt.DefaultText = ""
        Me.ContactPersonTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ContactPersonTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ContactPersonTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactPersonTxt.DisabledState.Parent = Me.ContactPersonTxt
        Me.ContactPersonTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ContactPersonTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.ContactPersonTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContactPersonTxt.FocusedState.Parent = Me.ContactPersonTxt
        Me.ContactPersonTxt.ForeColor = System.Drawing.Color.Black
        Me.ContactPersonTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ContactPersonTxt.HoverState.Parent = Me.ContactPersonTxt
        Me.ContactPersonTxt.Location = New System.Drawing.Point(159, 340)
        Me.ContactPersonTxt.Name = "ContactPersonTxt"
        Me.ContactPersonTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ContactPersonTxt.PlaceholderText = ""
        Me.ContactPersonTxt.SelectedText = ""
        Me.ContactPersonTxt.ShadowDecoration.Parent = Me.ContactPersonTxt
        Me.ContactPersonTxt.Size = New System.Drawing.Size(233, 31)
        Me.ContactPersonTxt.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(157, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(123, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Name of Contact Person"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(158, 291)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(196, 24)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "In Case of Emergency"
        '
        'PhoneNumberTxt
        '
        Me.PhoneNumberTxt.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PhoneNumberTxt.BorderRadius = 5
        Me.PhoneNumberTxt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PhoneNumberTxt.DefaultText = ""
        Me.PhoneNumberTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PhoneNumberTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PhoneNumberTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PhoneNumberTxt.DisabledState.Parent = Me.PhoneNumberTxt
        Me.PhoneNumberTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PhoneNumberTxt.FillColor = System.Drawing.Color.WhiteSmoke
        Me.PhoneNumberTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneNumberTxt.FocusedState.Parent = Me.PhoneNumberTxt
        Me.PhoneNumberTxt.ForeColor = System.Drawing.Color.Black
        Me.PhoneNumberTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PhoneNumberTxt.HoverState.Parent = Me.PhoneNumberTxt
        Me.PhoneNumberTxt.Location = New System.Drawing.Point(402, 340)
        Me.PhoneNumberTxt.Name = "PhoneNumberTxt"
        Me.PhoneNumberTxt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PhoneNumberTxt.PlaceholderText = ""
        Me.PhoneNumberTxt.SelectedText = ""
        Me.PhoneNumberTxt.ShadowDecoration.Parent = Me.PhoneNumberTxt
        Me.PhoneNumberTxt.Size = New System.Drawing.Size(237, 31)
        Me.PhoneNumberTxt.TabIndex = 0
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(400, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(78, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Phone Number"
        '
        'SaveStudentBtn
        '
        Me.SaveStudentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.SaveStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SaveStudentBtn.ForeColor = System.Drawing.Color.White
        Me.SaveStudentBtn.Location = New System.Drawing.Point(319, 382)
        Me.SaveStudentBtn.Name = "SaveStudentBtn"
        Me.SaveStudentBtn.Size = New System.Drawing.Size(157, 38)
        Me.SaveStudentBtn.TabIndex = 5
        Me.SaveStudentBtn.Text = "Save Student"
        Me.SaveStudentBtn.UseVisualStyleBackColor = False
        '
        'UploadQrCodeBtn
        '
        Me.UploadQrCodeBtn.BorderRadius = 5
        Me.UploadQrCodeBtn.CheckedState.Parent = Me.UploadQrCodeBtn
        Me.UploadQrCodeBtn.CustomImages.Parent = Me.UploadQrCodeBtn
        Me.UploadQrCodeBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UploadQrCodeBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UploadQrCodeBtn.ForeColor = System.Drawing.Color.White
        Me.UploadQrCodeBtn.HoverState.Parent = Me.UploadQrCodeBtn
        Me.UploadQrCodeBtn.Location = New System.Drawing.Point(11, 167)
        Me.UploadQrCodeBtn.Name = "UploadQrCodeBtn"
        Me.UploadQrCodeBtn.ShadowDecoration.Parent = Me.UploadQrCodeBtn
        Me.UploadQrCodeBtn.Size = New System.Drawing.Size(137, 25)
        Me.UploadQrCodeBtn.TabIndex = 4
        Me.UploadQrCodeBtn.Text = "Upload Qr Code"
        '
        'GenerateBtn
        '
        Me.GenerateBtn.BorderRadius = 5
        Me.GenerateBtn.CheckedState.Parent = Me.GenerateBtn
        Me.GenerateBtn.CustomImages.Parent = Me.GenerateBtn
        Me.GenerateBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GenerateBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.GenerateBtn.ForeColor = System.Drawing.Color.White
        Me.GenerateBtn.HoverState.Parent = Me.GenerateBtn
        Me.GenerateBtn.Location = New System.Drawing.Point(12, 201)
        Me.GenerateBtn.Name = "GenerateBtn"
        Me.GenerateBtn.ShadowDecoration.Parent = Me.GenerateBtn
        Me.GenerateBtn.Size = New System.Drawing.Size(136, 27)
        Me.GenerateBtn.TabIndex = 4
        Me.GenerateBtn.Text = "Generate Qr Code"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Student_Attendance_Monitoring_System.My.Resources.Resources.barcode
        Me.PictureBox2.Location = New System.Drawing.Point(11, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(137, 116)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog"
        '
        'ControlForm
        '
        Me.ControlForm.TargetControl = Me.Panel1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Student_Attendance_Monitoring_System.My.Resources.Resources.user
        Me.PictureBox1.Location = New System.Drawing.Point(13, 246)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(135, 116)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'UploadStudentPictureBtn
        '
        Me.UploadStudentPictureBtn.BorderRadius = 5
        Me.UploadStudentPictureBtn.CheckedState.Parent = Me.UploadStudentPictureBtn
        Me.UploadStudentPictureBtn.CustomImages.Parent = Me.UploadStudentPictureBtn
        Me.UploadStudentPictureBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.UploadStudentPictureBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UploadStudentPictureBtn.ForeColor = System.Drawing.Color.White
        Me.UploadStudentPictureBtn.HoverState.Parent = Me.UploadStudentPictureBtn
        Me.UploadStudentPictureBtn.Location = New System.Drawing.Point(13, 368)
        Me.UploadStudentPictureBtn.Name = "UploadStudentPictureBtn"
        Me.UploadStudentPictureBtn.ShadowDecoration.Parent = Me.UploadStudentPictureBtn
        Me.UploadStudentPictureBtn.Size = New System.Drawing.Size(137, 36)
        Me.UploadStudentPictureBtn.TabIndex = 4
        Me.UploadStudentPictureBtn.Text = "Upload Student Picture"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(42, 407)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Limit 1MB Only"
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(651, 426)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.YearLevelCB)
        Me.Controls.Add(Me.GenderCB)
        Me.Controls.Add(Me.SectionCB)
        Me.Controls.Add(Me.SaveStudentBtn)
        Me.Controls.Add(Me.CloseBtn)
        Me.Controls.Add(Me.UploadStudentPictureBtn)
        Me.Controls.Add(Me.UploadQrCodeBtn)
        Me.Controls.Add(Me.GenerateBtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LastNameTxt)
        Me.Controls.Add(Me.MiddleNameTxt)
        Me.Controls.Add(Me.StudentIDTxt)
        Me.Controls.Add(Me.AddressTxt)
        Me.Controls.Add(Me.PhoneNumberTxt)
        Me.Controls.Add(Me.ContactPersonTxt)
        Me.Controls.Add(Me.FirstNameTxt)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AddStudent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddStudent"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FirstNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MiddleNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LastNameTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents StudentIDTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents CloseBtn As System.Windows.Forms.Button
    Friend WithEvents SaveFileQrcode As System.Windows.Forms.SaveFileDialog
    Friend WithEvents AddressTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents SectionCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GenderCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents YearLevelCB As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents ContactPersonTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents PhoneNumberTxt As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents SaveStudentBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents UploadQrCodeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GenerateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ControlForm As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents UploadStudentPictureBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
