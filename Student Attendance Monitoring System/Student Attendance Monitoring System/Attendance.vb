Imports MySql.Data.MySqlClient
Public Class Attendance

    Private Sub Attendance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        students()
    End Sub
    Public Sub students()
        Dim sql = "select Attendance_No,Student_ID,Student_Name,TimeIn,TimeOut,Attendance_Date,Year_Level,Section,Facilitator from attendancetbl Where Facilitator='" & AdminMenu.NameofUserLbl.Text & "'"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub

    Public Sub timein()
        Dim sql = "select Attendance_No,Student_ID,Student_Name,TimeIn,Attendance_Date,Year_Level,Section,Facilitator from attendancetbl Where Facilitator='" & AdminMenu.NameofUserLbl.Text & "'"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub
    Public Sub timeout()
        Dim sql = "select Attendance_No,Student_ID,Student_Name,TimeOut,Attendance_Date,Year_Level,Section,Facilitator from attendancetbl Where Facilitator='" & AdminMenu.NameofUserLbl.Text & "'"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub

    Private Sub TimeInBtn_Click(sender As Object, e As EventArgs) Handles TimeInBtn.Click
        timein()
    End Sub


    Private Sub TimeOutBtn_Click(sender As Object, e As EventArgs) Handles TimeOutBtn.Click
        timeout()
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        BindingSource1.Filter = "Student_Name like '%" & SearchTxt.Text & "%'or Student_ID like '%" & SearchTxt.Text & "%'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'"
    End Sub

    Private Sub AllBtn_Click(sender As Object, e As EventArgs) Handles AllBtn.Click
        AdminMenu.attendance()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim sql = "select Attendance_No,Student_ID,Student_Name,TimeIn,TimeOut,Attendance_Date,Year_Level,Section,Facilitator from attendancetbl where Attendance_Date='" & DateTime.Now.ToString("MMMM-dd-yyyy") & "'and Facilitator='" & AdminMenu.NameofUserLbl.Text & "'"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub
End Class