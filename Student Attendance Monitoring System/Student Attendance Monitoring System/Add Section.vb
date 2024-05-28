Imports MySql.Data.MySqlClient
Public Class Add_Section

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Close()
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Try
            If String.IsNullOrWhiteSpace(SectionTxt.Text.Trim()) Then
                MessageBox.Show("Section Required !", "Save Section", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim save As New MySqlCommand("insert into sectiontbl(Section)values('" & SectionTxt.Text & "')", con)
                con.Open()
                save.ExecuteNonQuery()
                con.Close()
                MessageBox.Show("Section Saved", "Save Section", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SectionTxt.Text = ""
                section()
            End If
        Catch ex As Exception
            con.Close()
            MessageBox.Show("Section Already Exist !", "Save Section", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub StudentDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles StudentDataGridView.CellContentClick
        If e.ColumnIndex = StudentDataGridView.Columns("Delete").Index Then
            Dim rs As DialogResult
            rs = MessageBox.Show("Delete this Section ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If rs = Windows.Forms.DialogResult.Yes Then
                Dim delete As New MySqlCommand("delete from sectiontbl where Section='" & StudentDataGridView.CurrentRow.Cells("Section").Value.ToString & "'", con)
                con.Open()
                delete.ExecuteNonQuery()
                con.Close()
                section()
            End If
        End If
    End Sub
    

    Public Sub section()
        Dim sql = "select Section from Sectiontbl"
        Dim da = New MySqlDataAdapter(sql, con)
        Dim ds = New DataSet
        da.Fill(ds)
        StudentDataGridView.DataSource = ds.Tables(0)
        BindingSource1.DataSource = ds.Tables(0)
    End Sub

    Private Sub Add_Section_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        section()
    End Sub
End Class