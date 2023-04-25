Public Class FRMINCOME
    Private Sub FRMINCOME_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pmc_dbDataSet.member_table' table. You can move, or remove it, as needed.
        Me.Member_tableTableAdapter.Fill(Me.Pmc_dbDataSet.member_table)

    End Sub

    Private Sub dgincome_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgincome.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgincome.Rows(e.RowIndex)

            btnsave.Enabled = True
            btnclear.Enabled = True
            txtoccupation.Text = row.Cells(3).Value
            txtemployer.Text = row.Cells(4).Value
            txtsalary.Text = row.Cells(5).Value
            txtothers.Text = row.Cells(6).Value
            txtoccupation.Enabled = True
            txtemployer.Enabled = True
            txtsalary.Enabled = True
            txtothers.Enabled = True
            lblhidden.Text = row.Cells(0).Value

        End If
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        FRMMAINADMIN.Show()
        Me.Close()
    End Sub
End Class