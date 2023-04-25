Public Class USRCTRLUSM
    'user status vriable
    Dim status As String


    'refresh the user table function
    Sub dguser_refresh()
        Me.User_tableTableAdapter.Fill(Me.Pmc_dbDataSet.user_table)
    End Sub

    'clear field function
    Sub FieldClear()
        txtfn.Text = ""
        txtln.Text = ""
        txtun.Text = ""
        txtcpassword.Text = ""
        txtpassword.Text = ""
        cbout.SelectedItem = ""
        cbus.SelectedItem = ""

        btnadduser.Enabled = True
        btnchangepass.Enabled = False
        btnupdateuser.Enabled = False
        btnsavepass.Enabled = False

        txtfn.Enabled = True
        txtln.Enabled = True
        txtun.Enabled = True
        cbout.Enabled = True
        cbus.Enabled = True
        txtpassword.Enabled = True
        txtcpassword.Enabled = True
    End Sub

    Private Sub USRCTRLUSM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.User_tableTableAdapter.Fill(Me.Pmc_dbDataSet.user_table)
    End Sub

    Private Sub btnadduser_Click(sender As Object, e As EventArgs) Handles btnadduser.Click
        ' thsi is for creating a user

        'error trapping

        If txtfn.Text = "" Or txtln.Text = "" Or txtun.Text = "" Or txtpassword.Text = "" Or txtcpassword.Text = "" Or cbout.SelectedItem = "" Or cbus.SelectedItem = "" Then
            MsgBox("All fields are required", vbInformation, "Error Creating User")
        ElseIf Not txtcpassword.Text = txtpassword.Text Then
            MsgBox("Passwords do not match", vbInformation, "Error Creating User")
            txtpassword.Text = ""
            txtcpassword.Text = ""
            txtpassword.Focus()
        Else
            'connect to database
            conn.ConnectionString = My.Settings.pmc_dbConnectionString
            cmd.Connection = conn

            'open connection
            conn.Open()

            Dim a = cmd.Parameters
            a.Clear()
            a.AddWithValue("un", txtun.Text)
            cmd.CommandText = "select * from user_table where username = @un"

            'execute the sql query
            cmd.ExecuteNonQuery()

            'readd values from thhe result

            Dim result = cmd.ExecuteReader()

            If result.HasRows Then
                MsgBox("User with same username already exist", vbCritical, "Error")
                txtun.Text = ""
                txtun.Focus()
                conn.Close()
            Else
                conn.Close()
                conn.Open()

                a.Clear()
                a.AddWithValue("fn", txtfn.Text)
                a.AddWithValue("ln", txtln.Text)
                a.AddWithValue("un", txtun.Text)
                a.AddWithValue("pw", txtpassword.Text)
                a.AddWithValue("ut", cbout.SelectedItem)
                a.AddWithValue("us", cbus.SelectedItem)
                cmd.CommandText = "insert into user_table values(null, @un, SHA(@pw), @us, @ut, @fn, @ln)"

                'execute
                cmd.ExecuteNonQuery()

                conn.Close()

                dguser_refresh()

                'alert for successful operation
                MsgBox("User has been created successfully!", vbInformation, "System Notificaton")

                FieldClear()

            End If
        End If

    End Sub

    Private Sub btnclearuser_Click(sender As Object, e As EventArgs) Handles btnclearuser.Click
        Dim res As DialogResult
        res = MsgBox("Do you really want to clear the fields?", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            FieldClear()
            btnadduser.Enabled = True
            btnchangepass.Enabled = False
            btnupdateuser.Enabled = False
            btnsavepass.Enabled = False

            txtfn.Enabled = True
            txtln.Enabled = True
            txtun.Enabled = True
            cbout.Enabled = True
            cbus.Enabled = True
            txtpassword.Enabled = True
            txtcpassword.Enabled = True
        End If
    End Sub

    Private Sub dgusers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgusers.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgusers.Rows(e.RowIndex)

            txtfn.Text = row.Cells(1).Value
            txtln.Text = row.Cells(2).Value
            txtun.Text = row.Cells(3).Value
            cbout.Text = row.Cells(6).Value
            cbus.Text = row.Cells(5).Value

            btnadduser.Enabled = False
            btnupdateuser.Enabled = True
            btnchangepass.Enabled = True

            txtpassword.Enabled = False
            txtcpassword.Enabled = False
            txtun.Enabled = False

        End If
    End Sub

    Private Sub btnchangepass_Click(sender As Object, e As EventArgs) Handles btnchangepass.Click
        btnadduser.Enabled = False
        btnchangepass.Enabled = False
        btnupdateuser.Enabled = False
        btnsavepass.Enabled = True

        txtpassword.Enabled = True
        txtcpassword.Enabled = True
        txtpassword.Focus()

        txtfn.Enabled = False
        txtln.Enabled = False
        txtun.Enabled = False
        cbout.Enabled = False
        cbus.Enabled = False

    End Sub

    Private Sub btnupdateuser_Click(sender As Object, e As EventArgs) Handles btnupdateuser.Click
        conn.ConnectionString = My.Settings.pmc_dbConnectionString
        cmd.Connection = conn

        conn.Open()

        Dim a = cmd.Parameters
        a.Clear()

        a.AddWithValue("fn", txtfn.Text)
        a.AddWithValue("ln", txtln.Text)
        a.AddWithValue("un", txtun.Text)
        a.AddWithValue("ut", cbout.Text)
        a.AddWithValue("us", cbus.Text)


        cmd.CommandText = "select * from user_table where username = @un"
        cmd.ExecuteNonQuery()

        dr = cmd.ExecuteReader()
        dr.Read()

        If txtfn.Text = dr(5) And txtln.Text = dr(6) And cbout.Text = dr(4) And cbus.Text = dr(3) Then
            MsgBox("No changes detected", vbInformation, "System Notification")
            conn.Close()
            Return
        ElseIf txtfn.Text = "" Or txtln.Text = "" Or cbus.Text = "" Or cbout.Text = "" Then
            MsgBox("All fields are required", vbCritical, "System Notification")
        Else

            conn.Close()

            conn.Open()

            cmd.CommandText = "update user_table set firstname = @fn, lastname = @ln, type = @ut, status = @us where username = @un"

            cmd.ExecuteNonQuery()

            MsgBox("User was updated successfully", vbInformation, "System Notification")

            dguser_refresh()
            FieldClear()

        End If

        conn.Close()
    End Sub

    Private Sub btnsavepass_Click(sender As Object, e As EventArgs) Handles btnsavepass.Click
        Dim res As DialogResult

        res = MsgBox("Are you sure you want to reset password for this user?", vbYesNo, "System Notification")

        If res = DialogResult.Yes Then

            If txtpassword.Text = "" Or txtcpassword.Text = "" Then
                MsgBox("Both fields are required", vbCritical, "System Notification")

            ElseIf Not txtcpassword.Text = txtpassword.Text Then
                MsgBox("Passwords do not match", vbCritical, "System Notification")

                txtpassword.Text = ""
                txtcpassword.Text = ""
                txtpassword.Focus()

            Else
                conn.ConnectionString = My.Settings.pmc_dbConnectionString
                cmd.Connection = conn

                conn.Open()

                Dim a = cmd.Parameters

                a.Clear()

                a.AddWithValue("pw", txtpassword.Text)
                a.AddWithValue("un", txtun.Text)

                cmd.CommandText = "update user_table set password = sha(@pw) where username = @un"
                cmd.ExecuteNonQuery()

                MsgBox("Password has been reset", vbInformation, "System Notification")

                FieldClear()
                dguser_refresh()

                conn.Close()

            End If

        End If

    End Sub


End Class
