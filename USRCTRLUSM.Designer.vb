<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class USRCTRLUSM
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuCards1 = New Bunifu.Framework.UI.BunifuCards()
        Me.btnclearuser = New System.Windows.Forms.Button()
        Me.btnsavepass = New System.Windows.Forms.Button()
        Me.btnchangepass = New System.Windows.Forms.Button()
        Me.btnupdateuser = New System.Windows.Forms.Button()
        Me.btnadduser = New System.Windows.Forms.Button()
        Me.lblpagename = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtfn = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtln = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtun = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbout = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtcpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtpassword = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbus = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgusers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pmc_dbDataSet = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSet()
        Me.User_tableTableAdapter = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSetTableAdapters.user_tableTableAdapter()
        Me.BunifuCards1.SuspendLayout()
        CType(Me.dgusers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuCards1
        '
        Me.BunifuCards1.BackColor = System.Drawing.Color.MidnightBlue
        Me.BunifuCards1.BorderRadius = 5
        Me.BunifuCards1.BottomSahddow = True
        Me.BunifuCards1.color = System.Drawing.Color.MediumTurquoise
        Me.BunifuCards1.Controls.Add(Me.btnclearuser)
        Me.BunifuCards1.Controls.Add(Me.btnsavepass)
        Me.BunifuCards1.Controls.Add(Me.btnchangepass)
        Me.BunifuCards1.Controls.Add(Me.btnupdateuser)
        Me.BunifuCards1.Controls.Add(Me.btnadduser)
        Me.BunifuCards1.Controls.Add(Me.lblpagename)
        Me.BunifuCards1.LeftSahddow = False
        Me.BunifuCards1.Location = New System.Drawing.Point(631, 18)
        Me.BunifuCards1.Margin = New System.Windows.Forms.Padding(2)
        Me.BunifuCards1.Name = "BunifuCards1"
        Me.BunifuCards1.RightSahddow = True
        Me.BunifuCards1.ShadowDepth = 20
        Me.BunifuCards1.Size = New System.Drawing.Size(571, 252)
        Me.BunifuCards1.TabIndex = 0
        '
        'btnclearuser
        '
        Me.btnclearuser.BackColor = System.Drawing.Color.White
        Me.btnclearuser.FlatAppearance.BorderSize = 0
        Me.btnclearuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnclearuser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclearuser.Location = New System.Drawing.Point(38, 181)
        Me.btnclearuser.Name = "btnclearuser"
        Me.btnclearuser.Size = New System.Drawing.Size(494, 34)
        Me.btnclearuser.TabIndex = 10
        Me.btnclearuser.Text = "Clear Fields"
        Me.btnclearuser.UseVisualStyleBackColor = False
        '
        'btnsavepass
        '
        Me.btnsavepass.BackColor = System.Drawing.Color.White
        Me.btnsavepass.Enabled = False
        Me.btnsavepass.FlatAppearance.BorderSize = 0
        Me.btnsavepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsavepass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsavepass.Location = New System.Drawing.Point(303, 121)
        Me.btnsavepass.Name = "btnsavepass"
        Me.btnsavepass.Size = New System.Drawing.Size(229, 34)
        Me.btnsavepass.TabIndex = 9
        Me.btnsavepass.Text = "Save Password"
        Me.btnsavepass.UseVisualStyleBackColor = False
        '
        'btnchangepass
        '
        Me.btnchangepass.BackColor = System.Drawing.Color.White
        Me.btnchangepass.Enabled = False
        Me.btnchangepass.FlatAppearance.BorderSize = 0
        Me.btnchangepass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnchangepass.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnchangepass.Location = New System.Drawing.Point(38, 121)
        Me.btnchangepass.Name = "btnchangepass"
        Me.btnchangepass.Size = New System.Drawing.Size(227, 34)
        Me.btnchangepass.TabIndex = 8
        Me.btnchangepass.Text = "Change Password"
        Me.btnchangepass.UseVisualStyleBackColor = False
        '
        'btnupdateuser
        '
        Me.btnupdateuser.BackColor = System.Drawing.Color.White
        Me.btnupdateuser.Enabled = False
        Me.btnupdateuser.FlatAppearance.BorderSize = 0
        Me.btnupdateuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdateuser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdateuser.Location = New System.Drawing.Point(303, 78)
        Me.btnupdateuser.Name = "btnupdateuser"
        Me.btnupdateuser.Size = New System.Drawing.Size(229, 34)
        Me.btnupdateuser.TabIndex = 7
        Me.btnupdateuser.Text = "Update User"
        Me.btnupdateuser.UseVisualStyleBackColor = False
        '
        'btnadduser
        '
        Me.btnadduser.BackColor = System.Drawing.Color.White
        Me.btnadduser.FlatAppearance.BorderSize = 0
        Me.btnadduser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadduser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadduser.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnadduser.Location = New System.Drawing.Point(38, 78)
        Me.btnadduser.Name = "btnadduser"
        Me.btnadduser.Size = New System.Drawing.Size(227, 34)
        Me.btnadduser.TabIndex = 6
        Me.btnadduser.Text = "Create User"
        Me.btnadduser.UseVisualStyleBackColor = False
        '
        'lblpagename
        '
        Me.lblpagename.AutoSize = True
        Me.lblpagename.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagename.ForeColor = System.Drawing.Color.White
        Me.lblpagename.Location = New System.Drawing.Point(226, 26)
        Me.lblpagename.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblpagename.Name = "lblpagename"
        Me.lblpagename.Size = New System.Drawing.Size(110, 21)
        Me.lblpagename.TabIndex = 5
        Me.lblpagename.Text = "Action Panel"
        '
        'txtfn
        '
        Me.txtfn.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtfn.BorderRadius = 10
        Me.txtfn.BorderThickness = 3
        Me.txtfn.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtfn.DefaultText = ""
        Me.txtfn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtfn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtfn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfn.DisabledState.Parent = Me.txtfn
        Me.txtfn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtfn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfn.FocusedState.Parent = Me.txtfn
        Me.txtfn.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfn.ForeColor = System.Drawing.Color.Black
        Me.txtfn.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtfn.HoverState.Parent = Me.txtfn
        Me.txtfn.Location = New System.Drawing.Point(12, 18)
        Me.txtfn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtfn.Name = "txtfn"
        Me.txtfn.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtfn.PlaceholderText = "First Name"
        Me.txtfn.SelectedText = ""
        Me.txtfn.ShadowDecoration.Parent = Me.txtfn
        Me.txtfn.Size = New System.Drawing.Size(238, 47)
        Me.txtfn.TabIndex = 1
        Me.txtfn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtln
        '
        Me.txtln.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtln.BorderRadius = 10
        Me.txtln.BorderThickness = 3
        Me.txtln.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtln.DefaultText = ""
        Me.txtln.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtln.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtln.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtln.DisabledState.Parent = Me.txtln
        Me.txtln.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtln.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtln.FocusedState.Parent = Me.txtln
        Me.txtln.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtln.ForeColor = System.Drawing.Color.Black
        Me.txtln.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtln.HoverState.Parent = Me.txtln
        Me.txtln.Location = New System.Drawing.Point(288, 18)
        Me.txtln.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtln.Name = "txtln"
        Me.txtln.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtln.PlaceholderText = "Last Name"
        Me.txtln.SelectedText = ""
        Me.txtln.ShadowDecoration.Parent = Me.txtln
        Me.txtln.Size = New System.Drawing.Size(238, 47)
        Me.txtln.TabIndex = 3
        Me.txtln.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(343, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 36)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtun
        '
        Me.txtun.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtun.BorderRadius = 10
        Me.txtun.BorderThickness = 3
        Me.txtun.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtun.DefaultText = ""
        Me.txtun.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtun.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtun.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtun.DisabledState.Parent = Me.txtun
        Me.txtun.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtun.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtun.FocusedState.Parent = Me.txtun
        Me.txtun.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtun.ForeColor = System.Drawing.Color.Black
        Me.txtun.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtun.HoverState.Parent = Me.txtun
        Me.txtun.Location = New System.Drawing.Point(12, 112)
        Me.txtun.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtun.Name = "txtun"
        Me.txtun.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtun.PlaceholderText = "Username"
        Me.txtun.SelectedText = ""
        Me.txtun.ShadowDecoration.Parent = Me.txtun
        Me.txtun.Size = New System.Drawing.Size(238, 47)
        Me.txtun.TabIndex = 5
        Me.txtun.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(67, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 36)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Username"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbout
        '
        Me.cbout.BackColor = System.Drawing.Color.Transparent
        Me.cbout.BorderColor = System.Drawing.Color.Black
        Me.cbout.BorderRadius = 8
        Me.cbout.BorderThickness = 3
        Me.cbout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbout.FocusedColor = System.Drawing.Color.Empty
        Me.cbout.FocusedState.Parent = Me.cbout
        Me.cbout.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbout.ForeColor = System.Drawing.Color.Black
        Me.cbout.FormattingEnabled = True
        Me.cbout.HoverState.Parent = Me.cbout
        Me.cbout.ItemHeight = 40
        Me.cbout.Items.AddRange(New Object() {"", "Admin", "Cashier", "Loan Officer", "Secretary", "Treasurer"})
        Me.cbout.ItemsAppearance.Parent = Me.cbout
        Me.cbout.Location = New System.Drawing.Point(288, 112)
        Me.cbout.Margin = New System.Windows.Forms.Padding(2)
        Me.cbout.Name = "cbout"
        Me.cbout.ShadowDecoration.Parent = Me.cbout
        Me.cbout.Size = New System.Drawing.Size(239, 46)
        Me.cbout.TabIndex = 6
        Me.cbout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cbout.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(343, 153)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 36)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "User Type"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtcpassword
        '
        Me.txtcpassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtcpassword.BorderRadius = 10
        Me.txtcpassword.BorderThickness = 3
        Me.txtcpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcpassword.DefaultText = ""
        Me.txtcpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtcpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtcpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcpassword.DisabledState.Parent = Me.txtcpassword
        Me.txtcpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtcpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcpassword.FocusedState.Parent = Me.txtcpassword
        Me.txtcpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcpassword.ForeColor = System.Drawing.Color.Black
        Me.txtcpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcpassword.HoverState.Parent = Me.txtcpassword
        Me.txtcpassword.Location = New System.Drawing.Point(288, 223)
        Me.txtcpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtcpassword.Name = "txtcpassword"
        Me.txtcpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtcpassword.PlaceholderText = "Confirm Password"
        Me.txtcpassword.SelectedText = ""
        Me.txtcpassword.ShadowDecoration.Parent = Me.txtcpassword
        Me.txtcpassword.Size = New System.Drawing.Size(238, 47)
        Me.txtcpassword.TabIndex = 11
        Me.txtcpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(343, 265)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 36)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Re-type Password"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtpassword
        '
        Me.txtpassword.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtpassword.BorderRadius = 10
        Me.txtpassword.BorderThickness = 3
        Me.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpassword.DefaultText = ""
        Me.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.DisabledState.Parent = Me.txtpassword
        Me.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.FocusedState.Parent = Me.txtpassword
        Me.txtpassword.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.ForeColor = System.Drawing.Color.Black
        Me.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpassword.HoverState.Parent = Me.txtpassword
        Me.txtpassword.Location = New System.Drawing.Point(12, 223)
        Me.txtpassword.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txtpassword.PlaceholderText = "Password"
        Me.txtpassword.SelectedText = ""
        Me.txtpassword.ShadowDecoration.Parent = Me.txtpassword
        Me.txtpassword.Size = New System.Drawing.Size(238, 47)
        Me.txtpassword.TabIndex = 9
        Me.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.0!)
        Me.Label6.Location = New System.Drawing.Point(68, 266)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 36)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Password"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbus
        '
        Me.cbus.BackColor = System.Drawing.Color.Transparent
        Me.cbus.BorderColor = System.Drawing.Color.Black
        Me.cbus.BorderRadius = 8
        Me.cbus.BorderThickness = 3
        Me.cbus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cbus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbus.FocusedColor = System.Drawing.Color.Empty
        Me.cbus.FocusedState.Parent = Me.cbus
        Me.cbus.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbus.ForeColor = System.Drawing.Color.Black
        Me.cbus.FormattingEnabled = True
        Me.cbus.HoverState.Parent = Me.cbus
        Me.cbus.ItemHeight = 40
        Me.cbus.Items.AddRange(New Object() {"", "Active", "Inactive"})
        Me.cbus.ItemsAppearance.Parent = Me.cbus
        Me.cbus.Location = New System.Drawing.Point(12, 330)
        Me.cbus.Margin = New System.Windows.Forms.Padding(2)
        Me.cbus.Name = "cbus"
        Me.cbus.ShadowDecoration.Parent = Me.cbus
        Me.cbus.Size = New System.Drawing.Size(239, 46)
        Me.cbus.TabIndex = 12
        Me.cbus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.cbus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(67, 371)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 36)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "User Status"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgusers
        '
        Me.dgusers.AllowUserToAddRows = False
        Me.dgusers.AllowUserToDeleteRows = False
        Me.dgusers.AllowUserToResizeColumns = False
        Me.dgusers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgusers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgusers.AutoGenerateColumns = False
        Me.dgusers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgusers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgusers.BackgroundColor = System.Drawing.Color.White
        Me.dgusers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgusers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgusers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgusers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgusers.ColumnHeadersHeight = 42
        Me.dgusers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn})
        Me.dgusers.DataSource = Me.UsertableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgusers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgusers.EnableHeadersVisualStyles = False
        Me.dgusers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgusers.Location = New System.Drawing.Point(12, 440)
        Me.dgusers.MultiSelect = False
        Me.dgusers.Name = "dgusers"
        Me.dgusers.ReadOnly = True
        Me.dgusers.RowHeadersVisible = False
        Me.dgusers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgusers.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgusers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgusers.Size = New System.Drawing.Size(1203, 390)
        Me.dgusers.TabIndex = 14
        Me.dgusers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgusers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgusers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgusers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgusers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgusers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgusers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgusers.ThemeStyle.HeaderStyle.Height = 42
        Me.dgusers.ThemeStyle.ReadOnly = True
        Me.dgusers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgusers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgusers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        Me.dgusers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgusers.ThemeStyle.RowsStyle.Height = 22
        Me.dgusers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgusers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        Me.UsernameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        Me.PasswordDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        Me.StatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UsertableBindingSource
        '
        Me.UsertableBindingSource.DataMember = "user_table"
        Me.UsertableBindingSource.DataSource = Me.Pmc_dbDataSet
        '
        'Pmc_dbDataSet
        '
        Me.Pmc_dbDataSet.DataSetName = "pmc_dbDataSet"
        Me.Pmc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'User_tableTableAdapter
        '
        Me.User_tableTableAdapter.ClearBeforeFill = True
        '
        'USRCTRLUSM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgusers)
        Me.Controls.Add(Me.cbus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtcpassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cbout)
        Me.Controls.Add(Me.txtun)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtln)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtfn)
        Me.Controls.Add(Me.BunifuCards1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "USRCTRLUSM"
        Me.Size = New System.Drawing.Size(1227, 846)
        Me.BunifuCards1.ResumeLayout(False)
        Me.BunifuCards1.PerformLayout()
        CType(Me.dgusers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BunifuCards1 As Bunifu.Framework.UI.BunifuCards
    Friend WithEvents lblpagename As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtfn As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtln As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtun As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbout As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtcpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtpassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cbus As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents dgusers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsertableBindingSource As BindingSource
    Friend WithEvents Pmc_dbDataSet As pmc_dbDataSet
    Friend WithEvents User_tableTableAdapter As pmc_dbDataSetTableAdapters.user_tableTableAdapter
    Friend WithEvents btnchangepass As Button
    Friend WithEvents btnupdateuser As Button
    Friend WithEvents btnadduser As Button
    Friend WithEvents btnclearuser As Button
    Friend WithEvents btnsavepass As Button
End Class
