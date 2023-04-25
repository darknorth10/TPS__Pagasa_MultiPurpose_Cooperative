Public Class FRMADDRESS
    Private Sub FRMADDRESS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Pmc_dbDataSet.member_table' table. You can move, or remove it, as needed.
        Me.Member_tableTableAdapter.Fill(Me.Pmc_dbDataSet.member_table)

        conn.ConnectionString = My.Settings.pmc_dbConnectionString
        cmd.Connection = conn
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        FRMMAINADMIN.Show()
        Me.Close()
    End Sub

    Private Sub dgaddress_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgaddress.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgaddress.Rows(e.RowIndex)

            btnsave.Enabled = True
            btnclear.Enabled = True
            txtaddress.Text = row.Cells(2).Value
            txtspouse.Text = row.Cells(3).Value
            lbladdress.Text = row.Cells(2).Value
            lblspouse.Text = row.Cells(3).Value
            txtaddress.Enabled = True
            txtspouse.Enabled = True
            lblhidden.Text = row.Cells(0).Value

        End If
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        txtaddress.Text = ""
        txtspouse.Text = ""
        txtaddress.Enabled = False
        txtspouse.Enabled = False
        btnsave.Enabled = False
        btnclear.Enabled = False
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim membershipNo As Double = Val(lblhidden.Text)

        If Not txtaddress.Text = lbladdress.Text Or Not txtspouse.Text = lblspouse.Text Then

            Dim res As DialogResult
            res = MsgBox("Do you really want to save the changes?", vbYesNo, "System Confirmation")

            If res = DialogResult.Yes Then
                conn.Open()
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("mn", membershipNo)
                cmd.Parameters.AddWithValue("ad", txtaddress.Text)
                cmd.Parameters.AddWithValue("sp", txtspouse.Text)
                cmd.CommandText = "update member_table set address=@ad, spouse=@sp where membership_no=@mn"

                cmd.ExecuteNonQuery()


                conn.Close()

                txtaddress.Text = ""
                txtspouse.Text = ""
                txtaddress.Enabled = False
                txtspouse.Enabled = False
                btnsave.Enabled = False
                btnclear.Enabled = False

                MsgBox("Successfully Changed.", vbInformation, "System Notification")
                Me.Member_tableTableAdapter.Fill(Me.Pmc_dbDataSet.member_table)


            End If

        Else
            MsgBox("The are no changes detected.", vbCritical, "System Notification")
        End If

    End Sub
End Class