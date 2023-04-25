<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USRCTRLMEMBER
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgmembers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MembershipnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIN_num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CivilstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelphonenumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApproveddateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CapitalshareDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pmc_dbDataSet = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSet()
        Me.txtsearchmember = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Member_tableTableAdapter = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSetTableAdapters.member_tableTableAdapter()
        CType(Me.dgmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgmembers
        '
        Me.dgmembers.AllowUserToAddRows = False
        Me.dgmembers.AllowUserToDeleteRows = False
        Me.dgmembers.AllowUserToResizeColumns = False
        Me.dgmembers.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgmembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgmembers.AutoGenerateColumns = False
        Me.dgmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgmembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgmembers.BackgroundColor = System.Drawing.Color.White
        Me.dgmembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgmembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgmembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgmembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgmembers.ColumnHeadersHeight = 42
        Me.dgmembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembershipnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.TIN_num, Me.CivilstatusDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.BirthdateDataGridViewTextBoxColumn, Me.CelphonenumDataGridViewTextBoxColumn, Me.ApproveddateDataGridViewTextBoxColumn, Me.CapitalshareDataGridViewTextBoxColumn})
        Me.dgmembers.DataSource = Me.MembertableBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgmembers.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgmembers.EnableHeadersVisualStyles = False
        Me.dgmembers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgmembers.Location = New System.Drawing.Point(21, 245)
        Me.dgmembers.MultiSelect = False
        Me.dgmembers.Name = "dgmembers"
        Me.dgmembers.ReadOnly = True
        Me.dgmembers.RowHeadersVisible = False
        Me.dgmembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dgmembers.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgmembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgmembers.Size = New System.Drawing.Size(1188, 577)
        Me.dgmembers.TabIndex = 15
        Me.dgmembers.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgmembers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgmembers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgmembers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgmembers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgmembers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgmembers.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgmembers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgmembers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgmembers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgmembers.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgmembers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgmembers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgmembers.ThemeStyle.HeaderStyle.Height = 42
        Me.dgmembers.ThemeStyle.ReadOnly = True
        Me.dgmembers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgmembers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgmembers.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        Me.dgmembers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgmembers.ThemeStyle.RowsStyle.Height = 22
        Me.dgmembers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgmembers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'MembershipnoDataGridViewTextBoxColumn
        '
        Me.MembershipnoDataGridViewTextBoxColumn.DataPropertyName = "membership_no"
        Me.MembershipnoDataGridViewTextBoxColumn.HeaderText = "Member No."
        Me.MembershipnoDataGridViewTextBoxColumn.Name = "MembershipnoDataGridViewTextBoxColumn"
        Me.MembershipnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIN_num
        '
        Me.TIN_num.DataPropertyName = "TIN_num"
        Me.TIN_num.HeaderText = "TIN #"
        Me.TIN_num.Name = "TIN_num"
        Me.TIN_num.ReadOnly = True
        '
        'CivilstatusDataGridViewTextBoxColumn
        '
        Me.CivilstatusDataGridViewTextBoxColumn.DataPropertyName = "civil_status"
        Me.CivilstatusDataGridViewTextBoxColumn.HeaderText = "Civil Status"
        Me.CivilstatusDataGridViewTextBoxColumn.Name = "CivilstatusDataGridViewTextBoxColumn"
        Me.CivilstatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BirthdateDataGridViewTextBoxColumn
        '
        Me.BirthdateDataGridViewTextBoxColumn.DataPropertyName = "birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.HeaderText = "Birthdate"
        Me.BirthdateDataGridViewTextBoxColumn.Name = "BirthdateDataGridViewTextBoxColumn"
        Me.BirthdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CelphonenumDataGridViewTextBoxColumn
        '
        Me.CelphonenumDataGridViewTextBoxColumn.DataPropertyName = "celphone_num"
        Me.CelphonenumDataGridViewTextBoxColumn.HeaderText = "CP #"
        Me.CelphonenumDataGridViewTextBoxColumn.Name = "CelphonenumDataGridViewTextBoxColumn"
        Me.CelphonenumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApproveddateDataGridViewTextBoxColumn
        '
        Me.ApproveddateDataGridViewTextBoxColumn.DataPropertyName = "approved_date"
        Me.ApproveddateDataGridViewTextBoxColumn.HeaderText = "Approved"
        Me.ApproveddateDataGridViewTextBoxColumn.Name = "ApproveddateDataGridViewTextBoxColumn"
        Me.ApproveddateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CapitalshareDataGridViewTextBoxColumn
        '
        Me.CapitalshareDataGridViewTextBoxColumn.DataPropertyName = "capital_share"
        Me.CapitalshareDataGridViewTextBoxColumn.HeaderText = "Capital Share"
        Me.CapitalshareDataGridViewTextBoxColumn.Name = "CapitalshareDataGridViewTextBoxColumn"
        Me.CapitalshareDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembertableBindingSource
        '
        Me.MembertableBindingSource.DataMember = "member_table"
        Me.MembertableBindingSource.DataSource = Me.Pmc_dbDataSet
        '
        'Pmc_dbDataSet
        '
        Me.Pmc_dbDataSet.DataSetName = "pmc_dbDataSet"
        Me.Pmc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtsearchmember
        '
        Me.txtsearchmember.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsearchmember.DefaultText = ""
        Me.txtsearchmember.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsearchmember.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsearchmember.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearchmember.DisabledState.Parent = Me.txtsearchmember
        Me.txtsearchmember.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsearchmember.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchmember.FocusedState.Parent = Me.txtsearchmember
        Me.txtsearchmember.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearchmember.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsearchmember.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsearchmember.HoverState.Parent = Me.txtsearchmember
        Me.txtsearchmember.Location = New System.Drawing.Point(752, 190)
        Me.txtsearchmember.Margin = New System.Windows.Forms.Padding(5)
        Me.txtsearchmember.Name = "txtsearchmember"
        Me.txtsearchmember.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsearchmember.PlaceholderText = "Search"
        Me.txtsearchmember.SelectedText = ""
        Me.txtsearchmember.ShadowDecoration.Parent = Me.txtsearchmember
        Me.txtsearchmember.Size = New System.Drawing.Size(356, 34)
        Me.txtsearchmember.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtsearchmember.TabIndex = 16
        Me.txtsearchmember.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1105, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 34)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(624, 35)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(178, 40)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "View Addresses"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(827, 35)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(178, 40)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Income Info"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(34, 35)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 40)
        Me.Button4.TabIndex = 20
        Me.Button4.Text = "Apply Membership"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(268, 35)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(189, 40)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Edit Member Info"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(1031, 35)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(178, 40)
        Me.Button6.TabIndex = 22
        Me.Button6.Text = "Group Affiliations"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(624, 105)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(178, 40)
        Me.Button7.TabIndex = 23
        Me.Button7.Text = "View Eligibilities"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.ForeColor = System.Drawing.Color.White
        Me.Button8.Location = New System.Drawing.Point(827, 105)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(178, 40)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Initial Fees"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.ForeColor = System.Drawing.Color.White
        Me.Button9.Location = New System.Drawing.Point(1031, 105)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(178, 40)
        Me.Button9.TabIndex = 25
        Me.Button9.Text = "Dependants"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.MidnightBlue
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.ForeColor = System.Drawing.Color.White
        Me.Button10.Location = New System.Drawing.Point(34, 105)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(423, 40)
        Me.Button10.TabIndex = 26
        Me.Button10.Text = "Membership Approvals"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Member_tableTableAdapter
        '
        Me.Member_tableTableAdapter.ClearBeforeFill = True
        '
        'USRCTRLMEMBER
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtsearchmember)
        Me.Controls.Add(Me.dgmembers)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "USRCTRLMEMBER"
        Me.Size = New System.Drawing.Size(1227, 846)
        CType(Me.dgmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgmembers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents txtsearchmember As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents MembertableBindingSource As BindingSource
    Friend WithEvents Pmc_dbDataSet As pmc_dbDataSet
    Friend WithEvents Member_tableTableAdapter As pmc_dbDataSetTableAdapters.member_tableTableAdapter
    Friend WithEvents MembershipnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TIN_num As DataGridViewTextBoxColumn
    Friend WithEvents CivilstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelphonenumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApproveddateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapitalshareDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
