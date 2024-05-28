Imports MySql.Data.MySqlClient
Public Class SearchStudent

    Private Sub SearchStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        students()
    End Sub

    Public Sub students()
        Dim sql = "select Student_ID,Student_Full_Name,FirstName,MiddleName,LastName,Section,Year_Level from addstudenttbl"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub

    Private Sub SearchTxt_TextChanged(sender As Object, e As EventArgs) Handles SearchTxt.TextChanged
        BindingSource1.Filter = "Student_Full_Name like '%" & SearchTxt.Text & "'or Student_ID like '%" & SearchTxt.Text & "%'"
    End Sub
End Class