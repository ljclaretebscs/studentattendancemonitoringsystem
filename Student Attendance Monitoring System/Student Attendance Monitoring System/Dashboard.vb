Imports MySql.Data.MySqlClient
Public Class Dashboard

    Private Sub countalltimer_Tick(sender As Object, e As EventArgs) Handles countalltimer.Tick
        Dim todayattendance As New MySqlCommand("select count(*) from attendancetbl where Attendance_Date='" & DateTime.Now.ToString("MMMM-dd-yyyy") & "'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'", con)
        con.Open()
        Dim c1 = todayattendance.ExecuteScalar
        TodayAttendanceLbl.Text = c1.ToString

        Dim totaluserstudent As New MySqlCommand("select count(*) from addstudenttbl where Facilitator='" & AdminMenu.NameofUserLbl.Text & "'", con)
        Dim c2 = totaluserstudent.ExecuteScalar
        TotalUserStudentLbl.Text = c2.ToString

        Dim totalattendance As New MySqlCommand("select count(*) from attendancetbl where Attendance_Date='" & DateTime.Now.ToString("MMMM-dd-yyyy") & "'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'", con)
        Dim c3 = totalattendance.ExecuteScalar
        TotalAttendanceLbl.Text = c3.ToString


        con.Close()

    End Sub

    Private Sub DatePickerAttendance_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerAttendance.ValueChanged
        countalltimer.Stop()
        Dim totalattendance As New MySqlCommand("select count(*) from attendancetbl where Attendance_Date='" & DatePickerAttendance.Text & "'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'", con)
        con.Open()
        Dim c3 = totalattendance.ExecuteScalar
        TotalAttendanceLbl.Text = c3.ToString
        con.Close()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class