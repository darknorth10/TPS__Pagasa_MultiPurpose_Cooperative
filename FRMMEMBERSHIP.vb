Public Class FRMMEMBERSHIP
    Private Sub FRMMEMBERSHIP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = My.Settings.pmc_dbConnectionString
        cmd.Connection = conn
    End Sub

    Private Sub BTNEXIT_Click(sender As Object, e As EventArgs) Handles BTNEXIT.Click
        Dim res As DialogResult
        res = MsgBox("Do you really want to close the form? You will lose your progress when form is closed.", vbYesNo, "System Confirmation")

        If res = DialogResult.Yes Then
            Me.Close()
            FRMMAINADMIN.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'Apply Membership Button
        If txtfn.Text = "" Or txtmn.Text = "" Or txtln.Text = "" Or cbcs.Text = "" Or txtmembershipno.Text = "" Or txttin.Text = "" Or txtage.Text = "" Or cbosex.Text = "" Or txtbirthplace.Text = "" Or txtaddress.Text = "" Or txtoccupation.Text = "" Or txteduc.Text = "" Or txtemployer.Text = "" Or txtsalary.Text = "" Or txtsourceincome.Text = "" Or txtrelative.Text = "" Or txtrelationship.Text = "" Or txtsaffil.Text = "" Or txtspouse.Text = "" Or txtdepend.Text = "" Or txtcontact.Text = "" Then
            MsgBox("All personal info fields are required.", vbCritical, "System Notification")


        ElseIf chkvalidid.Checked = False Or chkresidency.Checked = False Or chkmembershipfee.Checked = False Or chksminarfee.Checked = False Or txtcapitalshare.Text = "" Then
            MsgBox("All requirement fees and documents are required.", vbCritical, "System Notification")

        ElseIf Val(txtcapitalshare.Text) < 1000 Or Val(txtcapitalshare.Text) > 20000 Then
            MsgBox("Initial Capital share can not be lower than 1000 pesos and can not be more than 20000 pesos.", vbCritical, "System Notification")

        Else
            'check if membership no or TIN is taken
            conn.Open()
            Dim c = cmd.Parameters
            c.Clear()

            c.AddWithValue("mn", Val(txtmembershipno.Text))
            c.AddWithValue("tin", txttin.Text)

            cmd.CommandText = "select membership_no from member_table where membership_no = @mn or TIN_num = @tin"

            cmd.ExecuteNonQuery()

            Dim result = cmd.ExecuteReader

            result.Read()

            If result.HasRows Then
                MsgBox("Membership Number or TIN is already taken.", vbCritical, "System Notification")
            Else
                conn.Close()
                conn.Open()

                Dim fullname As String = txtfn.Text + " " + txtmn.Text + " " + txtln.Text
                c.Clear()
                c.AddWithValue("mn", txtmembershipno.Text)
                c.AddWithValue("fn", fullname)
                c.AddWithValue("tin", txttin.Text)
                c.AddWithValue("cs", cbcs.SelectedItem)
                c.AddWithValue("age", txtage.Text)
                c.AddWithValue("gen", cbosex.SelectedItem)
                c.AddWithValue("bp", txtbirthplace.Text)
                c.AddWithValue("bd", dpbirthdate.Text)
                c.AddWithValue("add", txtaddress.Text)
                c.AddWithValue("occ", txtoccupation.Text)
                c.AddWithValue("educ", txteduc.Text)
                c.AddWithValue("empl", txtemployer.Text)
                c.AddWithValue("sal", Val(txtsalary.Text))
                c.AddWithValue("osi", txtsourceincome.Text)
                c.AddWithValue("near", txtrelative.Text)
                c.AddWithValue("rel", txtrelationship.Text)
                c.AddWithValue("aff", txtsaffil.Text)
                c.AddWithValue("spo", txtspouse.Text)
                c.AddWithValue("dep", Val(txtdepend.Text))
                c.AddWithValue("cp", txtcontact.Text)
                c.AddWithValue("share", Val(txtcapitalshare.Text))
                c.AddWithValue("vid", True)
                c.AddWithValue("pr", True)
                c.AddWithValue("stat", "Pending")

                cmd.CommandText = "INSERT INTO `member_table`
(`membership_no`, `name`, `TIN_num`, `civil_status`, `age`, `gender`, `birth_place`, `birthdate`, `address`, `occupation`, `highest_educ_attain`, `present_employer`, `salary`, `other_src_income`, `nearest_relative`, `relationship_nearest_rel`, `social_religous_aff`, `spouse`, `num_o_dependents`, `celphone_num`, `capital_share`, `valid_id`, `proof_ressidency`, `membership_status`)
VALUES (@mn, @fn, @tin, @cs, @age, @gen, @bp, @bd, @add, @occ, @educ, @empl, @sal, @osi, @near, @rel, @aff, @spo, @dep, @cp, @share, @vid, @pr, @stat)"

                cmd.ExecuteNonQuery()

                ' Insert Fee Information to fee table
                c.Clear()
                c.AddWithValue("mn", txtmembershipno.Text)
                c.AddWithValue("fn", fullname)
                c.AddWithValue("share", Val(txtcapitalshare.Text))
                c.AddWithValue("mf", 100)
                c.AddWithValue("sf", 100)

                cmd.CommandText = "insert into fees_table (membership_no, fullname, membership_fee, seminar_fee, paidup_capital) VALUES (@mn, @fn, @mf, @sf, @share)"

                cmd.ExecuteNonQuery()

                'set eligibility

                MsgBox("Application has been added in the Approval.", vbInformation, "System Notification")

                FRMMAINADMIN.Show()

                Me.Close()

            End If
            conn.Close()

        End If
    End Sub

    Private Sub txttin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttin.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Guna2TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtmembershipno.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtsalary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtsalary.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtdepend_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdepend.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcapitalshare_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcapitalshare.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtage_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtage.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtcontact_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcontact.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class