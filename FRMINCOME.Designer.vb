<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMINCOME
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.lblhidden = New System.Windows.Forms.Label()
        Me.dgincome = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Pmc_dbDataSet = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSet()
        Me.MembertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Member_tableTableAdapter = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSetTableAdapters.member_tableTableAdapter()
        Me.MembershipnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HighesteducattainDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PresentemployerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OthersrcincomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtoccupation = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemployer = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtsalary = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtothers = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgincome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(-7, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1339, 72)
        Me.Panel1.TabIndex = 4
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(41, 18)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(369, 30)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Members Income Information"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Gray
        Me.btnback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnback.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(39, 96)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(126, 41)
        Me.btnback.TabIndex = 28
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.lblhidden)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(187, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1059, 92)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action Panel"
        '
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Crimson
        Me.btnclear.Enabled = False
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclear.FlatAppearance.BorderSize = 0
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(218, 26)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(257, 49)
        Me.btnclear.TabIndex = 30
        Me.btnclear.Text = "Clear"
        Me.btnclear.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.SteelBlue
        Me.btnsave.Enabled = False
        Me.btnsave.FlatAppearance.BorderSize = 0
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Location = New System.Drawing.Point(514, 26)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(262, 49)
        Me.btnsave.TabIndex = 29
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'lblhidden
        '
        Me.lblhidden.AutoSize = True
        Me.lblhidden.Location = New System.Drawing.Point(826, 40)
        Me.lblhidden.Name = "lblhidden"
        Me.lblhidden.Size = New System.Drawing.Size(0, 21)
        Me.lblhidden.TabIndex = 32
        Me.lblhidden.Visible = False
        '
        'dgincome
        '
        Me.dgincome.AllowUserToAddRows = False
        Me.dgincome.AllowUserToDeleteRows = False
        Me.dgincome.AllowUserToResizeColumns = False
        Me.dgincome.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.dgincome.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgincome.AutoGenerateColumns = False
        Me.dgincome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgincome.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgincome.BackgroundColor = System.Drawing.Color.White
        Me.dgincome.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgincome.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgincome.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgincome.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgincome.ColumnHeadersHeight = 42
        Me.dgincome.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembershipnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.HighesteducattainDataGridViewTextBoxColumn, Me.OccupationDataGridViewTextBoxColumn, Me.PresentemployerDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.OthersrcincomeDataGridViewTextBoxColumn})
        Me.dgincome.DataSource = Me.MembertableBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgincome.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgincome.EnableHeadersVisualStyles = False
        Me.dgincome.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgincome.Location = New System.Drawing.Point(39, 395)
        Me.dgincome.MultiSelect = False
        Me.dgincome.Name = "dgincome"
        Me.dgincome.ReadOnly = True
        Me.dgincome.RowHeadersVisible = False
        Me.dgincome.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dgincome.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgincome.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgincome.Size = New System.Drawing.Size(1207, 551)
        Me.dgincome.TabIndex = 34
        Me.dgincome.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgincome.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgincome.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgincome.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgincome.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgincome.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgincome.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgincome.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgincome.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgincome.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgincome.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgincome.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgincome.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgincome.ThemeStyle.HeaderStyle.Height = 42
        Me.dgincome.ThemeStyle.ReadOnly = True
        Me.dgincome.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgincome.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgincome.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        Me.dgincome.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgincome.ThemeStyle.RowsStyle.Height = 22
        Me.dgincome.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgincome.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Pmc_dbDataSet
        '
        Me.Pmc_dbDataSet.DataSetName = "pmc_dbDataSet"
        Me.Pmc_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MembertableBindingSource
        '
        Me.MembertableBindingSource.DataMember = "member_table"
        Me.MembertableBindingSource.DataSource = Me.Pmc_dbDataSet
        '
        'Member_tableTableAdapter
        '
        Me.Member_tableTableAdapter.ClearBeforeFill = True
        '
        'MembershipnoDataGridViewTextBoxColumn
        '
        Me.MembershipnoDataGridViewTextBoxColumn.DataPropertyName = "membership_no"
        Me.MembershipnoDataGridViewTextBoxColumn.HeaderText = "Membership #"
        Me.MembershipnoDataGridViewTextBoxColumn.Name = "MembershipnoDataGridViewTextBoxColumn"
        Me.MembershipnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HighesteducattainDataGridViewTextBoxColumn
        '
        Me.HighesteducattainDataGridViewTextBoxColumn.DataPropertyName = "highest_educ_attain"
        Me.HighesteducattainDataGridViewTextBoxColumn.HeaderText = "Highest Education"
        Me.HighesteducattainDataGridViewTextBoxColumn.Name = "HighesteducattainDataGridViewTextBoxColumn"
        Me.HighesteducattainDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        Me.OccupationDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PresentemployerDataGridViewTextBoxColumn
        '
        Me.PresentemployerDataGridViewTextBoxColumn.DataPropertyName = "present_employer"
        Me.PresentemployerDataGridViewTextBoxColumn.HeaderText = "Present Employer"
        Me.PresentemployerDataGridViewTextBoxColumn.Name = "PresentemployerDataGridViewTextBoxColumn"
        Me.PresentemployerDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        Me.SalaryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OthersrcincomeDataGridViewTextBoxColumn
        '
        Me.OthersrcincomeDataGridViewTextBoxColumn.DataPropertyName = "other_src_income"
        Me.OthersrcincomeDataGridViewTextBoxColumn.HeaderText = "Other Sources of Income"
        Me.OthersrcincomeDataGridViewTextBoxColumn.Name = "OthersrcincomeDataGridViewTextBoxColumn"
        Me.OthersrcincomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(39, 214)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 36)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Occupation"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtoccupation
        '
        Me.txtoccupation.BackColor = System.Drawing.Color.Transparent
        Me.txtoccupation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtoccupation.BorderRadius = 10
        Me.txtoccupation.BorderThickness = 3
        Me.txtoccupation.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtoccupation.DefaultText = ""
        Me.txtoccupation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtoccupation.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtoccupation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoccupation.DisabledState.Parent = Me.txtoccupation
        Me.txtoccupation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtoccupation.Enabled = False
        Me.txtoccupation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoccupation.FocusedState.Parent = Me.txtoccupation
        Me.txtoccupation.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtoccupation.ForeColor = System.Drawing.Color.Black
        Me.txtoccupation.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtoccupation.HoverState.Parent = Me.txtoccupation
        Me.txtoccupation.Location = New System.Drawing.Point(39, 241)
        Me.txtoccupation.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtoccupation.Name = "txtoccupation"
        Me.txtoccupation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtoccupation.PlaceholderText = ""
        Me.txtoccupation.SelectedText = ""
        Me.txtoccupation.ShadowDecoration.Parent = Me.txtoccupation
        Me.txtoccupation.Size = New System.Drawing.Size(419, 47)
        Me.txtoccupation.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtoccupation.TabIndex = 36
        Me.txtoccupation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(481, 214)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 36)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Present Employer"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtemployer
        '
        Me.txtemployer.BackColor = System.Drawing.Color.Transparent
        Me.txtemployer.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtemployer.BorderRadius = 10
        Me.txtemployer.BorderThickness = 3
        Me.txtemployer.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtemployer.DefaultText = ""
        Me.txtemployer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtemployer.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtemployer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemployer.DisabledState.Parent = Me.txtemployer
        Me.txtemployer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtemployer.Enabled = False
        Me.txtemployer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemployer.FocusedState.Parent = Me.txtemployer
        Me.txtemployer.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemployer.ForeColor = System.Drawing.Color.Black
        Me.txtemployer.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtemployer.HoverState.Parent = Me.txtemployer
        Me.txtemployer.Location = New System.Drawing.Point(481, 241)
        Me.txtemployer.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtemployer.Name = "txtemployer"
        Me.txtemployer.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtemployer.PlaceholderText = ""
        Me.txtemployer.SelectedText = ""
        Me.txtemployer.ShadowDecoration.Parent = Me.txtemployer
        Me.txtemployer.Size = New System.Drawing.Size(417, 47)
        Me.txtemployer.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtemployer.TabIndex = 38
        Me.txtemployer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DimGray
        Me.Label2.Location = New System.Drawing.Point(915, 214)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 36)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Salary"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtsalary
        '
        Me.txtsalary.BackColor = System.Drawing.Color.Transparent
        Me.txtsalary.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtsalary.BorderRadius = 10
        Me.txtsalary.BorderThickness = 3
        Me.txtsalary.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtsalary.DefaultText = ""
        Me.txtsalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtsalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtsalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsalary.DisabledState.Parent = Me.txtsalary
        Me.txtsalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtsalary.Enabled = False
        Me.txtsalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsalary.FocusedState.Parent = Me.txtsalary
        Me.txtsalary.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsalary.ForeColor = System.Drawing.Color.Black
        Me.txtsalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtsalary.HoverState.Parent = Me.txtsalary
        Me.txtsalary.Location = New System.Drawing.Point(915, 241)
        Me.txtsalary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtsalary.Name = "txtsalary"
        Me.txtsalary.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtsalary.PlaceholderText = ""
        Me.txtsalary.SelectedText = ""
        Me.txtsalary.ShadowDecoration.Parent = Me.txtsalary
        Me.txtsalary.Size = New System.Drawing.Size(331, 47)
        Me.txtsalary.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtsalary.TabIndex = 40
        Me.txtsalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(39, 303)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(277, 36)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Other Sources of Income"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtothers
        '
        Me.txtothers.BackColor = System.Drawing.Color.Transparent
        Me.txtothers.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtothers.BorderRadius = 10
        Me.txtothers.BorderThickness = 3
        Me.txtothers.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtothers.DefaultText = ""
        Me.txtothers.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtothers.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtothers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtothers.DisabledState.Parent = Me.txtothers
        Me.txtothers.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtothers.Enabled = False
        Me.txtothers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtothers.FocusedState.Parent = Me.txtothers
        Me.txtothers.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtothers.ForeColor = System.Drawing.Color.Black
        Me.txtothers.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtothers.HoverState.Parent = Me.txtothers
        Me.txtothers.Location = New System.Drawing.Point(39, 329)
        Me.txtothers.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtothers.Name = "txtothers"
        Me.txtothers.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtothers.PlaceholderText = ""
        Me.txtothers.SelectedText = ""
        Me.txtothers.ShadowDecoration.Parent = Me.txtothers
        Me.txtothers.Size = New System.Drawing.Size(1207, 47)
        Me.txtothers.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtothers.TabIndex = 42
        Me.txtothers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(330, 303)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(357, 26)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Note:  You can add sources separated with comma"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FRMINCOME
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 969)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtothers)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsalary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtemployer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtoccupation)
        Me.Controls.Add(Me.dgincome)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMINCOME"
        Me.Text = "FRMINCOME"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgincome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnback As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents lblhidden As Label
    Friend WithEvents dgincome As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Pmc_dbDataSet As pmc_dbDataSet
    Friend WithEvents MembertableBindingSource As BindingSource
    Friend WithEvents Member_tableTableAdapter As pmc_dbDataSetTableAdapters.member_tableTableAdapter
    Friend WithEvents MembershipnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HighesteducattainDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PresentemployerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OthersrcincomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents txtoccupation As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemployer As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtsalary As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtothers As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
End Class
