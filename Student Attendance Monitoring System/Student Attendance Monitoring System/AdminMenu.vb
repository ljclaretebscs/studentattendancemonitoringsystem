Public Class AdminMenu
    Dim collapsed As Boolean
    Private Sub StudentCollapseTimer_Tick(sender As Object, e As EventArgs) Handles StudentCollapseTimer.Tick


        If collapsed Then
            Panel4.Height += 10
            If Panel4.Size = Panel4.MaximumSize Then
                StudentCollapseTimer.Stop()
                collapsed = False
            End If
        Else
            Panel4.Height -= 10
            If Panel4.Size = Panel4.MinimumSize Then
                StudentCollapseTimer.Stop()
                collapsed = True
            End If
        End If


    End Sub

    Private Sub StudentBtn_Click(sender As Object, e As EventArgs) Handles StudentBtn.Click
        StudentCollapseTimer.Start()
    End Sub

    Private Sub FullscreenBtn_Click(sender As Object, e As EventArgs) Handles FullscreenBtn.Click
        If WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        Else
            WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub AddStudentBtn_Click(sender As Object, e As EventArgs) Handles AddStudentBtn.Click
        AddStudent.ShowDialog()

    End Sub

    Private Sub SearchStudentBtn_Click(sender As Object, e As EventArgs) Handles SearchStudentBtn.Click
        searchstudent()
    End Sub

    Public Sub searchstudent()
        Panel2.Controls.Clear()
        Dim f As New SearchStudent With {.TopLevel = False, .AutoSize = False}
        f.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub
    Public Sub editstudent()
        Panel2.Controls.Clear()
        Dim f As New EditStudent With {.TopLevel = False, .AutoSize = False}
        f.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub
   
   
    Private Sub EditStudentBtn_Click(sender As Object, e As EventArgs) Handles EditStudentBtn.Click
        editstudent()
    End Sub

    Private Sub AttendanceBtn_Click(sender As Object, e As EventArgs) Handles AttendanceBtn.Click
        attendance()
    End Sub

    Public Sub attendance()
        Panel2.Controls.Clear()
        Dim f As New Attendance With {.TopLevel = False, .AutoSize = False}
        f.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

   
    Private Sub MaintenanceBtn_Click(sender As Object, e As EventArgs) Handles MaintenanceBtn.Click
        MaintenanceTimer.Start()
    End Sub

    Private Sub MaintenanceTimer_Tick(sender As Object, e As EventArgs) Handles MaintenanceTimer.Tick

        If collapsed Then
            Panel5.Height += 10
            If Panel5.Size = Panel5.MaximumSize Then
                MaintenanceTimer.Stop()
                collapsed = False
            End If
        Else
            Panel5.Height -= 10
            If Panel5.Size = Panel5.MinimumSize Then
                MaintenanceTimer.Stop()
                collapsed = True
            End If
        End If

    End Sub

    Private Sub AddYearLevelBtn_Click(sender As Object, e As EventArgs) Handles AddYearLevelBtn.Click
        Add_Year_Level.ShowDialog()
    End Sub

    Private Sub AddSectionBtn_Click(sender As Object, e As EventArgs) Handles AddSectionBtn.Click
        Add_Section.ShowDialog()
    End Sub

   
    Private Sub CreateUserBtn_Click(sender As Object, e As EventArgs) Handles CreateUserBtn.Click
        Create_Admin_User.ShowDialog()
    End Sub

   
    Private Sub ChangePasswordBtn_Click(sender As Object, e As EventArgs) Handles ChangePasswordBtn.Click
        ChangePassword.ShowDialog()
    End Sub

    Private Sub TimeandDateTimer_Tick(sender As Object, e As EventArgs) Handles TimeandDateTimer.Tick
        TimeLbl.Text = DateTime.Now.ToString("hh:mm:ss tt")
        DateLbl.Text = DateTime.Now.ToString("MMMM-dd-yyyy")
    End Sub

    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Controls.Clear()
        Dim f As New Dashboard With {.TopLevel = False, .AutoSize = False}
        f.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub DashboardBtn_Click(sender As Object, e As EventArgs) Handles DashboardBtn.Click
        Panel2.Controls.Clear()
        Dim f As New Dashboard With {.TopLevel = False, .AutoSize = False}
        f.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim rs As DialogResult
        rs = MessageBox.Show("You Want Log-Out ?", "Log-Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rs = Windows.Forms.DialogResult.Yes Then
            Login.Show()
            Close()
        End If
    End Sub

    Private Sub MinimizeBtn_Click(sender As Object, e As EventArgs) Handles MinimizeBtn.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub CreateReportsBtn_Click(sender As Object, e As EventArgs) Handles CreateReportsBtn.Click
        Panel2.Controls.Clear()
        Dim f As New Attendance_Report_Viewer With {.TopLevel = False, .AutoSize = False}
        f.Dock = DockStyle.Fill
        Me.Panel2.Controls.Add(f)
        f.Show()
    End Sub
End Class