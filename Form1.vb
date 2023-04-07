Public Class FRMMAINADMIN

    Private Sub FRMMAINADMIN_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlmain.Controls.Clear()
        lblpagename.Text = "Dashboard"

        Dim D As New USRCTRLDASHBOARD()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill

    End Sub

    Private Sub btndashboard_Click(sender As Object, e As EventArgs) Handles btndashboard.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Dashboard"

        Dim D As New USRCTRLDASHBOARD()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnum_Click(sender As Object, e As EventArgs) Handles btnum.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "User Management"

        Dim D As New USRCTRLUSM()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnmembership_Click(sender As Object, e As EventArgs) Handles btnmembership.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Membership"

        Dim D As New USRCTRLMEMBER()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnservices_Click(sender As Object, e As EventArgs) Handles btnservices.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Services"

        Dim D As New USRCTRLSERVCES()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnreports_Click(sender As Object, e As EventArgs) Handles btnreports.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Reports"

        Dim D As New USRCTRLREPORTS()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnaudit_Click(sender As Object, e As EventArgs) Handles btnaudit.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Audit Trail"

        Dim D As New USRCTRLAUDIT()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Dim res As DialogResult
        res = MsgBox("Do you really want to exit the application?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            System.Windows.Forms.Application.Exit()
        End If
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "About Us"

        Dim D As New USRCTRLABOUT()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnsettings_Click(sender As Object, e As EventArgs) Handles btnsettings.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Settings"

        Dim D As New USRCTRLSETTINGS()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnprintables_Click(sender As Object, e As EventArgs) Handles btnprintables.Click
        pnlmain.Controls.Clear()
        lblpagename.Text = "Printables"

        Dim D As New USRCTRLPRINTABLES()
        D.Parent = pnlmain
        D.Show()
        D.Dock = DockStyle.Fill
    End Sub

    Private Sub btnlogout_Click(sender As Object, e As EventArgs) Handles btnlogout.Click
        Dim res As DialogResult

        res = MsgBox("Are you sure you want to logout?", vbYesNo, "System Notification")

        If res = DialogResult.Yes Then

            Me.Hide()

        End If
    End Sub

End Class