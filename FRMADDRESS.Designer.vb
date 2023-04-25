<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMADDRESS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnback = New System.Windows.Forms.Button()
        Me.lblhidden = New System.Windows.Forms.Label()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.MembertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pmc_dbDataSet = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSet()
        Me.Member_tableTableAdapter = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSetTableAdapters.member_tableTableAdapter()
        Me.txtaddress = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtspouse = New Guna.UI2.WinForms.Guna2TextBox()
        Me.spouse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgaddress = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.lbladdress = New System.Windows.Forms.Label()
        Me.lblspouse = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgaddress, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(-6, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1339, 72)
        Me.Panel1.TabIndex = 3
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.SteelBlue
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(41, 18)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(224, 30)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Members Address"
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.Color.Gray
        Me.btnback.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnback.FlatAppearance.BorderSize = 0
        Me.btnback.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnback.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.ForeColor = System.Drawing.Color.Black
        Me.btnback.Location = New System.Drawing.Point(40, 105)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(126, 41)
        Me.btnback.TabIndex = 27
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
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
        'btnclear
        '
        Me.btnclear.BackColor = System.Drawing.Color.Crimson
        Me.btnclear.Enabled = False
        Me.btnclear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnclear.FlatAppearance.BorderSize = 0
        Me.btnclear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnclear.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.ForeColor = System.Drawing.Color.White
        Me.btnclear.Location = New System.Drawing.Point(213, 26)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(237, 49)
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
        Me.btnsave.Location = New System.Drawing.Point(522, 26)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(245, 49)
        Me.btnsave.TabIndex = 29
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnclear)
        Me.GroupBox1.Controls.Add(Me.btnsave)
        Me.GroupBox1.Controls.Add(Me.lblhidden)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(200, 105)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1047, 92)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action Panel"
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
        'Member_tableTableAdapter
        '
        Me.Member_tableTableAdapter.ClearBeforeFill = True
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.Transparent
        Me.txtaddress.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtaddress.BorderRadius = 10
        Me.txtaddress.BorderThickness = 3
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.DefaultText = ""
        Me.txtaddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtaddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtaddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.DisabledState.Parent = Me.txtaddress
        Me.txtaddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtaddress.Enabled = False
        Me.txtaddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.FocusedState.Parent = Me.txtaddress
        Me.txtaddress.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.ForeColor = System.Drawing.Color.Black
        Me.txtaddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.HoverState.Parent = Me.txtaddress
        Me.txtaddress.Location = New System.Drawing.Point(40, 252)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.PlaceholderText = ""
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.ShadowDecoration.Parent = Me.txtaddress
        Me.txtaddress.Size = New System.Drawing.Size(717, 47)
        Me.txtaddress.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtaddress.TabIndex = 34
        Me.txtaddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.DimGray
        Me.Label10.Location = New System.Drawing.Point(40, 227)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(190, 36)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Present Address"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(787, 227)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(190, 36)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Name of Spouse"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtspouse
        '
        Me.txtspouse.BackColor = System.Drawing.Color.Transparent
        Me.txtspouse.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtspouse.BorderRadius = 10
        Me.txtspouse.BorderThickness = 3
        Me.txtspouse.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtspouse.DefaultText = ""
        Me.txtspouse.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtspouse.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtspouse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtspouse.DisabledState.Parent = Me.txtspouse
        Me.txtspouse.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtspouse.Enabled = False
        Me.txtspouse.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtspouse.FocusedState.Parent = Me.txtspouse
        Me.txtspouse.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtspouse.ForeColor = System.Drawing.Color.Black
        Me.txtspouse.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtspouse.HoverState.Parent = Me.txtspouse
        Me.txtspouse.Location = New System.Drawing.Point(787, 252)
        Me.txtspouse.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtspouse.Name = "txtspouse"
        Me.txtspouse.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtspouse.PlaceholderText = ""
        Me.txtspouse.SelectedText = ""
        Me.txtspouse.ShadowDecoration.Parent = Me.txtspouse
        Me.txtspouse.Size = New System.Drawing.Size(460, 47)
        Me.txtspouse.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material
        Me.txtspouse.TabIndex = 36
        Me.txtspouse.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'spouse
        '
        Me.spouse.DataPropertyName = "spouse"
        Me.spouse.HeaderText = "Spouse"
        Me.spouse.Name = "spouse"
        Me.spouse.ReadOnly = True
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Full Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembershipnoDataGridViewTextBoxColumn
        '
        Me.MembershipnoDataGridViewTextBoxColumn.DataPropertyName = "membership_no"
        Me.MembershipnoDataGridViewTextBoxColumn.HeaderText = "Membership #"
        Me.MembershipnoDataGridViewTextBoxColumn.Name = "MembershipnoDataGridViewTextBoxColumn"
        Me.MembershipnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'dgaddress
        '
        Me.dgaddress.AllowUserToAddRows = False
        Me.dgaddress.AllowUserToDeleteRows = False
        Me.dgaddress.AllowUserToResizeColumns = False
        Me.dgaddress.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgaddress.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgaddress.AutoGenerateColumns = False
        Me.dgaddress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgaddress.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgaddress.BackgroundColor = System.Drawing.Color.White
        Me.dgaddress.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgaddress.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgaddress.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgaddress.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgaddress.ColumnHeadersHeight = 42
        Me.dgaddress.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembershipnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.spouse})
        Me.dgaddress.DataSource = Me.MembertableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgaddress.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgaddress.EnableHeadersVisualStyles = False
        Me.dgaddress.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgaddress.Location = New System.Drawing.Point(40, 320)
        Me.dgaddress.MultiSelect = False
        Me.dgaddress.Name = "dgaddress"
        Me.dgaddress.ReadOnly = True
        Me.dgaddress.RowHeadersVisible = False
        Me.dgaddress.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgaddress.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgaddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgaddress.Size = New System.Drawing.Size(1207, 552)
        Me.dgaddress.TabIndex = 33
        Me.dgaddress.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.dgaddress.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.dgaddress.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.dgaddress.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.dgaddress.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.dgaddress.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.dgaddress.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.dgaddress.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgaddress.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgaddress.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgaddress.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgaddress.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.dgaddress.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.dgaddress.ThemeStyle.HeaderStyle.Height = 42
        Me.dgaddress.ThemeStyle.ReadOnly = True
        Me.dgaddress.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.dgaddress.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgaddress.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        Me.dgaddress.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.dgaddress.ThemeStyle.RowsStyle.Height = 22
        Me.dgaddress.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgaddress.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'lbladdress
        '
        Me.lbladdress.AutoSize = True
        Me.lbladdress.Location = New System.Drawing.Point(659, 436)
        Me.lbladdress.Name = "lbladdress"
        Me.lbladdress.Size = New System.Drawing.Size(0, 13)
        Me.lbladdress.TabIndex = 38
        Me.lbladdress.Visible = False
        '
        'lblspouse
        '
        Me.lblspouse.AutoSize = True
        Me.lblspouse.Location = New System.Drawing.Point(667, 444)
        Me.lblspouse.Name = "lblspouse"
        Me.lblspouse.Size = New System.Drawing.Size(0, 13)
        Me.lblspouse.TabIndex = 39
        Me.lblspouse.Visible = False
        '
        'FRMADDRESS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 884)
        Me.Controls.Add(Me.lblspouse)
        Me.Controls.Add(Me.lbladdress)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtspouse)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.dgaddress)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnback)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMADDRESS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMADDRESS"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgaddress, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnback As Button
    Friend WithEvents lblhidden As Label
    Friend WithEvents btnclear As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Pmc_dbDataSet As pmc_dbDataSet
    Friend WithEvents MembertableBindingSource As BindingSource
    Friend WithEvents Member_tableTableAdapter As pmc_dbDataSetTableAdapters.member_tableTableAdapter
    Friend WithEvents txtaddress As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtspouse As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents spouse As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembershipnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgaddress As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lbladdress As Label
    Friend WithEvents lblspouse As Label
End Class
