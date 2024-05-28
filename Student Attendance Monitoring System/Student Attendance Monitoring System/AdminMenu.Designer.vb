<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMenu))
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateLbl = New System.Windows.Forms.Label()
        Me.TimeLbl = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SearchStudentBtn = New System.Windows.Forms.Button()
        Me.EditStudentBtn = New System.Windows.Forms.Button()
        Me.AddStudentBtn = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AddYearLevelBtn = New System.Windows.Forms.Button()
        Me.ChangePasswordBtn = New System.Windows.Forms.Button()
        Me.CreateUserBtn = New System.Windows.Forms.Button()
        Me.CreateReportsBtn = New System.Windows.Forms.Button()
        Me.AddSectionBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MinimizeBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.NameofUserLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FullscreenBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.StudentCollapseTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ControlForm = New Guna.UI.WinForms.GunaDragControl(Me.components)
        Me.MaintenanceTimer = New System.Windows.Forms.Timer(Me.components)
        Me.TimeandDateTimer = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.StudentBtn = New System.Windows.Forms.Button()
        Me.MaintenanceBtn = New System.Windows.Forms.Button()
        Me.AttendanceBtn = New System.Windows.Forms.Button()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(121, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.DashboardBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.AttendanceBtn)
        Me.FlowLayoutPanel1.Controls.Add(Me.LogOutBtn)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(223, 659)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.DateLbl)
        Me.Panel3.Controls.Add(Me.TimeLbl)
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(220, 187)
        Me.Panel3.TabIndex = 0
        '
        'DateLbl
        '
        Me.DateLbl.BackColor = System.Drawing.Color.Transparent
        Me.DateLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateLbl.ForeColor = System.Drawing.Color.White
        Me.DateLbl.Location = New System.Drawing.Point(3, 163)
        Me.DateLbl.Name = "DateLbl"
        Me.DateLbl.Size = New System.Drawing.Size(214, 24)
        Me.DateLbl.TabIndex = 7
        Me.DateLbl.Text = "UCC - SAMS"
        Me.DateLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimeLbl
        '
        Me.TimeLbl.BackColor = System.Drawing.Color.Transparent
        Me.TimeLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeLbl.ForeColor = System.Drawing.Color.White
        Me.TimeLbl.Location = New System.Drawing.Point(3, 143)
        Me.TimeLbl.Name = "TimeLbl"
        Me.TimeLbl.Size = New System.Drawing.Size(214, 20)
        Me.TimeLbl.TabIndex = 1
        Me.TimeLbl.Text = "12:00:00 am"
        Me.TimeLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.StudentBtn)
        Me.Panel4.Controls.Add(Me.SearchStudentBtn)
        Me.Panel4.Controls.Add(Me.EditStudentBtn)
        Me.Panel4.Controls.Add(Me.AddStudentBtn)
        Me.Panel4.Location = New System.Drawing.Point(3, 237)
        Me.Panel4.MaximumSize = New System.Drawing.Size(220, 116)
        Me.Panel4.MinimumSize = New System.Drawing.Size(220, 33)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(220, 33)
        Me.Panel4.TabIndex = 1
        '
        'SearchStudentBtn
        '
        Me.SearchStudentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.SearchStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchStudentBtn.ForeColor = System.Drawing.Color.White
        Me.SearchStudentBtn.Location = New System.Drawing.Point(3, 85)
        Me.SearchStudentBtn.Name = "SearchStudentBtn"
        Me.SearchStudentBtn.Size = New System.Drawing.Size(214, 28)
        Me.SearchStudentBtn.TabIndex = 0
        Me.SearchStudentBtn.Text = "Search Student"
        Me.SearchStudentBtn.UseVisualStyleBackColor = False
        '
        'EditStudentBtn
        '
        Me.EditStudentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditStudentBtn.ForeColor = System.Drawing.Color.White
        Me.EditStudentBtn.Location = New System.Drawing.Point(3, 60)
        Me.EditStudentBtn.Name = "EditStudentBtn"
        Me.EditStudentBtn.Size = New System.Drawing.Size(214, 28)
        Me.EditStudentBtn.TabIndex = 0
        Me.EditStudentBtn.Text = "Edit Student"
        Me.EditStudentBtn.UseVisualStyleBackColor = False
        '
        'AddStudentBtn
        '
        Me.AddStudentBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddStudentBtn.ForeColor = System.Drawing.Color.White
        Me.AddStudentBtn.Location = New System.Drawing.Point(3, 37)
        Me.AddStudentBtn.Name = "AddStudentBtn"
        Me.AddStudentBtn.Size = New System.Drawing.Size(214, 28)
        Me.AddStudentBtn.TabIndex = 0
        Me.AddStudentBtn.Text = "Add Student"
        Me.AddStudentBtn.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.AddYearLevelBtn)
        Me.Panel5.Controls.Add(Me.ChangePasswordBtn)
        Me.Panel5.Controls.Add(Me.CreateUserBtn)
        Me.Panel5.Controls.Add(Me.CreateReportsBtn)
        Me.Panel5.Controls.Add(Me.MaintenanceBtn)
        Me.Panel5.Controls.Add(Me.AddSectionBtn)
        Me.Panel5.Location = New System.Drawing.Point(3, 276)
        Me.Panel5.MaximumSize = New System.Drawing.Size(217, 168)
        Me.Panel5.MinimumSize = New System.Drawing.Size(217, 40)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(217, 40)
        Me.Panel5.TabIndex = 2
        '
        'AddYearLevelBtn
        '
        Me.AddYearLevelBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddYearLevelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddYearLevelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddYearLevelBtn.ForeColor = System.Drawing.Color.White
        Me.AddYearLevelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddYearLevelBtn.Location = New System.Drawing.Point(0, 43)
        Me.AddYearLevelBtn.Name = "AddYearLevelBtn"
        Me.AddYearLevelBtn.Size = New System.Drawing.Size(217, 25)
        Me.AddYearLevelBtn.TabIndex = 0
        Me.AddYearLevelBtn.Text = "Add Year Level"
        Me.AddYearLevelBtn.UseVisualStyleBackColor = False
        '
        'ChangePasswordBtn
        '
        Me.ChangePasswordBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChangePasswordBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ChangePasswordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ChangePasswordBtn.ForeColor = System.Drawing.Color.White
        Me.ChangePasswordBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ChangePasswordBtn.Location = New System.Drawing.Point(0, 143)
        Me.ChangePasswordBtn.Name = "ChangePasswordBtn"
        Me.ChangePasswordBtn.Size = New System.Drawing.Size(217, 24)
        Me.ChangePasswordBtn.TabIndex = 0
        Me.ChangePasswordBtn.Text = "Change Password"
        Me.ChangePasswordBtn.UseVisualStyleBackColor = False
        '
        'CreateUserBtn
        '
        Me.CreateUserBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CreateUserBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CreateUserBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateUserBtn.ForeColor = System.Drawing.Color.White
        Me.CreateUserBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateUserBtn.Location = New System.Drawing.Point(0, 117)
        Me.CreateUserBtn.Name = "CreateUserBtn"
        Me.CreateUserBtn.Size = New System.Drawing.Size(217, 27)
        Me.CreateUserBtn.TabIndex = 0
        Me.CreateUserBtn.Text = "Create Admin User"
        Me.CreateUserBtn.UseVisualStyleBackColor = False
        '
        'CreateReportsBtn
        '
        Me.CreateReportsBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CreateReportsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CreateReportsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CreateReportsBtn.ForeColor = System.Drawing.Color.White
        Me.CreateReportsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CreateReportsBtn.Location = New System.Drawing.Point(0, 91)
        Me.CreateReportsBtn.Name = "CreateReportsBtn"
        Me.CreateReportsBtn.Size = New System.Drawing.Size(217, 27)
        Me.CreateReportsBtn.TabIndex = 0
        Me.CreateReportsBtn.Text = "Create Reports"
        Me.CreateReportsBtn.UseVisualStyleBackColor = False
        '
        'AddSectionBtn
        '
        Me.AddSectionBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddSectionBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AddSectionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddSectionBtn.ForeColor = System.Drawing.Color.White
        Me.AddSectionBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AddSectionBtn.Location = New System.Drawing.Point(0, 68)
        Me.AddSectionBtn.Name = "AddSectionBtn"
        Me.AddSectionBtn.Size = New System.Drawing.Size(217, 28)
        Me.AddSectionBtn.TabIndex = 0
        Me.AddSectionBtn.Text = "Add Section"
        Me.AddSectionBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.MinimizeBtn)
        Me.Panel1.Controls.Add(Me.NameofUserLbl)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.FullscreenBtn)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1048, 31)
        Me.Panel1.TabIndex = 1
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MinimizeBtn.BackColor = System.Drawing.Color.Transparent
        Me.MinimizeBtn.CheckedState.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.CustomImages.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.FillColor = System.Drawing.Color.Transparent
        Me.MinimizeBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBtn.ForeColor = System.Drawing.Color.White
        Me.MinimizeBtn.HoverState.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.Location = New System.Drawing.Point(966, 3)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.ShadowDecoration.Parent = Me.MinimizeBtn
        Me.MinimizeBtn.Size = New System.Drawing.Size(34, 26)
        Me.MinimizeBtn.TabIndex = 8
        Me.MinimizeBtn.Text = "-"
        '
        'NameofUserLbl
        '
        Me.NameofUserLbl.AutoSize = True
        Me.NameofUserLbl.ForeColor = System.Drawing.Color.White
        Me.NameofUserLbl.Location = New System.Drawing.Point(73, 9)
        Me.NameofUserLbl.Name = "NameofUserLbl"
        Me.NameofUserLbl.Size = New System.Drawing.Size(55, 13)
        Me.NameofUserLbl.TabIndex = 7
        Me.NameofUserLbl.Text = "Welcome:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Welcome:"
        '
        'FullscreenBtn
        '
        Me.FullscreenBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullscreenBtn.BackColor = System.Drawing.Color.Transparent
        Me.FullscreenBtn.CheckedState.Parent = Me.FullscreenBtn
        Me.FullscreenBtn.CustomImages.Parent = Me.FullscreenBtn
        Me.FullscreenBtn.FillColor = System.Drawing.Color.Transparent
        Me.FullscreenBtn.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FullscreenBtn.ForeColor = System.Drawing.Color.White
        Me.FullscreenBtn.HoverState.Parent = Me.FullscreenBtn
        Me.FullscreenBtn.Location = New System.Drawing.Point(1008, 3)
        Me.FullscreenBtn.Name = "FullscreenBtn"
        Me.FullscreenBtn.ShadowDecoration.Parent = Me.FullscreenBtn
        Me.FullscreenBtn.Size = New System.Drawing.Size(34, 26)
        Me.FullscreenBtn.TabIndex = 6
        Me.FullscreenBtn.Text = "[ ]"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(229, 38)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(804, 633)
        Me.Panel2.TabIndex = 2
        '
        'StudentCollapseTimer
        '
        Me.StudentCollapseTimer.Enabled = True
        Me.StudentCollapseTimer.Interval = 1
        '
        'ControlForm
        '
        Me.ControlForm.TargetControl = Me.Panel1
        '
        'MaintenanceTimer
        '
        Me.MaintenanceTimer.Interval = 1
        '
        'TimeandDateTimer
        '
        Me.TimeandDateTimer.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.Student_Attendance_Monitoring_System.My.Resources.Resources.University_of_Caloocan_City_Coat_of_Arms
        Me.PictureBox1.Location = New System.Drawing.Point(44, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(131, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'DashboardBtn
        '
        Me.DashboardBtn.BackColor = System.Drawing.Color.Transparent
        Me.DashboardBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.ForeColor = System.Drawing.Color.White
        Me.DashboardBtn.Image = CType(resources.GetObject("DashboardBtn.Image"), System.Drawing.Image)
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(3, 196)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Size = New System.Drawing.Size(217, 35)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = "DashBoard"
        Me.DashboardBtn.UseVisualStyleBackColor = False
        '
        'StudentBtn
        '
        Me.StudentBtn.BackColor = System.Drawing.Color.Transparent
        Me.StudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.StudentBtn.FlatAppearance.BorderSize = 0
        Me.StudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.StudentBtn.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentBtn.ForeColor = System.Drawing.Color.White
        Me.StudentBtn.Image = CType(resources.GetObject("StudentBtn.Image"), System.Drawing.Image)
        Me.StudentBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.StudentBtn.Location = New System.Drawing.Point(0, 0)
        Me.StudentBtn.Name = "StudentBtn"
        Me.StudentBtn.Size = New System.Drawing.Size(217, 35)
        Me.StudentBtn.TabIndex = 0
        Me.StudentBtn.Text = "Students"
        Me.StudentBtn.UseVisualStyleBackColor = False
        '
        'MaintenanceBtn
        '
        Me.MaintenanceBtn.BackColor = System.Drawing.Color.Transparent
        Me.MaintenanceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MaintenanceBtn.FlatAppearance.BorderSize = 0
        Me.MaintenanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaintenanceBtn.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaintenanceBtn.ForeColor = System.Drawing.Color.White
        Me.MaintenanceBtn.Image = CType(resources.GetObject("MaintenanceBtn.Image"), System.Drawing.Image)
        Me.MaintenanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MaintenanceBtn.Location = New System.Drawing.Point(0, 2)
        Me.MaintenanceBtn.Name = "MaintenanceBtn"
        Me.MaintenanceBtn.Size = New System.Drawing.Size(217, 35)
        Me.MaintenanceBtn.TabIndex = 0
        Me.MaintenanceBtn.Text = "Maintenance"
        Me.MaintenanceBtn.UseVisualStyleBackColor = False
        '
        'AttendanceBtn
        '
        Me.AttendanceBtn.BackColor = System.Drawing.Color.Transparent
        Me.AttendanceBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AttendanceBtn.FlatAppearance.BorderSize = 0
        Me.AttendanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttendanceBtn.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttendanceBtn.ForeColor = System.Drawing.Color.White
        Me.AttendanceBtn.Image = CType(resources.GetObject("AttendanceBtn.Image"), System.Drawing.Image)
        Me.AttendanceBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AttendanceBtn.Location = New System.Drawing.Point(3, 322)
        Me.AttendanceBtn.Name = "AttendanceBtn"
        Me.AttendanceBtn.Size = New System.Drawing.Size(217, 33)
        Me.AttendanceBtn.TabIndex = 0
        Me.AttendanceBtn.Text = "Attendance"
        Me.AttendanceBtn.UseVisualStyleBackColor = False
        '
        'LogOutBtn
        '
        Me.LogOutBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LogOutBtn.BackColor = System.Drawing.Color.Transparent
        Me.LogOutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LogOutBtn.FlatAppearance.BorderSize = 0
        Me.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.LogOutBtn.Font = New System.Drawing.Font("Lucida Sans", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBtn.ForeColor = System.Drawing.Color.White
        Me.LogOutBtn.Image = CType(resources.GetObject("LogOutBtn.Image"), System.Drawing.Image)
        Me.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LogOutBtn.Location = New System.Drawing.Point(3, 361)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Size = New System.Drawing.Size(217, 33)
        Me.LogOutBtn.TabIndex = 0
        Me.LogOutBtn.Text = "Log-Out"
        Me.LogOutBtn.UseVisualStyleBackColor = False
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1045, 683)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdminMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Dashboard"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents SearchStudentBtn As System.Windows.Forms.Button
    Friend WithEvents EditStudentBtn As System.Windows.Forms.Button
    Friend WithEvents AddStudentBtn As System.Windows.Forms.Button
    Friend WithEvents StudentBtn As System.Windows.Forms.Button
    Friend WithEvents AttendanceBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents StudentCollapseTimer As System.Windows.Forms.Timer
    Friend WithEvents FullscreenBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DashboardBtn As System.Windows.Forms.Button
    Friend WithEvents ControlForm As Guna.UI.WinForms.GunaDragControl
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents MaintenanceBtn As System.Windows.Forms.Button
    Friend WithEvents AddSectionBtn As System.Windows.Forms.Button
    Friend WithEvents MaintenanceTimer As System.Windows.Forms.Timer
    Friend WithEvents AddYearLevelBtn As System.Windows.Forms.Button
    Friend WithEvents CreateReportsBtn As System.Windows.Forms.Button
    Friend WithEvents CreateUserBtn As System.Windows.Forms.Button
    Friend WithEvents ChangePasswordBtn As System.Windows.Forms.Button
    Friend WithEvents NameofUserLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TimeLbl As System.Windows.Forms.Label
    Friend WithEvents TimeandDateTimer As System.Windows.Forms.Timer
    Friend WithEvents LogOutBtn As System.Windows.Forms.Button
    Friend WithEvents MinimizeBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DateLbl As System.Windows.Forms.Label
End Class
