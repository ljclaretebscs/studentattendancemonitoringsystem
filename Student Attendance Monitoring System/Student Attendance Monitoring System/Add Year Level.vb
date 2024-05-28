Imports MySql.Data.MySqlClient
Public Class Add_Year_Level

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If String.IsNullOrWhiteSpace(YearLevelTxt.Text.Trim()) Then
                MessageBox.Show("Year Level Required !", "Save Year Level", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim save As New MySqlCommand("insert into yearleveltbl(Year_Level)values('" & YearLevelTxt.Text & "')", con)
                con.Open()
                save.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Year Level Saved", "Save Year Level", MessageBoxButtons.OK, MessageBoxIcon.Information)
                YearLevelTxt.Text = ""
                yearlevel()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Year Level Already Exist !", "Save Year Level", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Add_Year_Level_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        yearlevel()
    End Sub
    Public Sub yearlevel()
        Dim sql = "select Year_Level from yearleveltbl"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        If e.ColumnIndex = StudentDataGridView.Columns("Delete").Index Then
            Dim rs As DialogResult
            rs = MessageBox.Show("Delete this Year Level ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rs = Windows.Forms.DialogResult.Yes Then
                Dim delete As New MySqlCommand("delete from yearleveltbl where Year_Level='" & StudentDataGridView.CurrentRow.Cells("Year_Level").Value.ToString & "'", con)
                con.Open()
                delete.ExecuteNonQuery()
                con.Close()
                yearlevel()
            End If
        End If
    End Sub
End Class