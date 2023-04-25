Public Class FRMMEMBERSHIP_container
    Private Sub FRMMEMBERSHIP_container_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pmc_dbDataSet.member_table' table. You can move, or remove it, as needed.
        Try
            Me.Member_tableTableAdapter.FillByPending(Pmc_dbDataSet.member_table)
        Catch ex As Exception

        End Try

        conn.ConnectionString = My.Settings.pmc_dbConnectionString
        cmd.Connection = conn

    End Sub
    Sub dgrefresh()
        Me.Member_tableTableAdapter.FillByPending(Pmc_dbDataSet.member_table)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        FRMMAINADMIN.Show()

    End Sub

    Private Sub btnapprove_Click(sender As Object, e As EventArgs) Handles btnapprove.Click
        Dim membershipNo As Double = Val(lblhidden.Text)

        Dim res As DialogResult
        res = MsgBox("Do you really want to approve the application?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            conn.Open()
            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("mn", membershipNo)
            cmd.CommandText = "update member_table set membership_status='Approved', approved_date=curdate() where membership_no=@mn"

            cmd.ExecuteNonQuery()

            cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("mn", membershipNo)
            cmd.Parameters.AddWithValue("cl", "Ineligible")
            cmd.Parameters.AddWithValue("rl", "Ineligible")
            cmd.Parameters.AddWithValue("gcl", "Ineligible")
            cmd.CommandText = "insert into eligibility_table values(@mn, @cl, @rl, @gcl)"

            cmd.ExecuteNonQuery()

            conn.Close()
            MsgBox("An Application has been Approved.", vbInformation, "System Notification")

            dgrefresh()
        End If



    End Sub

    Private Sub dgusers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgmembers.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgmembers.Rows(e.RowIndex)

            btnapprove.Enabled = True
            btnreject.Enabled = True

            lblhidden.Text = row.Cells(0).Value

        End If

    End Sub

End Class