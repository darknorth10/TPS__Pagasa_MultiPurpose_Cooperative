Public Class USRCTRLMEMBER

    Private Sub USRCTRLMEMBER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Member_tableTableAdapter.Fill(Pmc_dbDataSet.member_table)
    End Sub
    Sub memberRefresh()
        Me.Member_tableTableAdapter.FillByApproved(Me.Pmc_dbDataSet.member_table)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FRMMEMBERSHIP.Show()
        FRMMAINADMIN.Hide()

    End Sub

    Private Sub dgusers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgmembers.CellContentClick

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        FRMMEMBERSHIP_container.Show()
        FRMMAINADMIN.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FRMADDRESS.Show()
        FRMMAINADMIN.Hide()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FRMINCOME.Show()
        FRMMAINADMIN.Hide()
    End Sub
End Class
