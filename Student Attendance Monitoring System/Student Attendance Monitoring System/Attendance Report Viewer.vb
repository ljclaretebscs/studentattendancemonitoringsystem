Imports MySql.Data.MySqlClient
Public Class Attendance_Report_Viewer

    Private Sub Attendance_Report_Viewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'studentattendancesystemdbDataSet.attendancetbl' table. You can move, or remove it, as needed.
        Me.attendancetblTableAdapter.Fill(Me.studentattendancesystemdbDataSet.attendancetbl)
        Dim print As New MySqlCommand("select * from attendancetbl where Attendance_Date='" & DateTime.Now.ToString("MMMM-dd-yyyy") & "'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'", con)
        con.Open()
        Dim dt As New DataTable
        Dim adp As New MySqlDataAdapter(print)
        adp.Fill(dt)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .DataSources.Add(
                New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        ReportViewer1.RefreshReport()
        con.Close()

    End Sub

    Public Sub loadreports()
        Dim print As New MySqlCommand("select * from attendancetbl where Attendance_Date='" & DatePickerAttendance.Text & "'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'", con)
        con.Open()
        Dim dt As New DataTable
        Dim adp As New MySqlDataAdapter(print)
        adp.Fill(dt)
        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .DataSources.Add(
                New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt))
        End With
        ReportViewer1.RefreshReport()
        con.Close()
    End Sub

    Private Sub DatePickerAttendance_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerAttendance.ValueChanged
        loadreports()
    End Sub
End Class