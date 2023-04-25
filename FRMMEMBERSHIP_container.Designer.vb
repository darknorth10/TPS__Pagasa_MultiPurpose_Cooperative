<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMMEMBERSHIP_container
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgmembers = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.MembershipnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CelphonenumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApplicationdateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValididDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProofressidencyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembershipstatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MembertableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Pmc_dbDataSet = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSet()
        Me.Member_tableTableAdapter = New TPS__Pagasa_MultiPurpose_Cooperative.pmc_dbDataSetTableAdapters.member_tableTableAdapter()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnapprove = New System.Windows.Forms.Button()
        Me.btnreject = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblhidden = New System.Windows.Forms.Label()
        CType(Me.dgmembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgmembers
        '
        Me.dgmembers.AllowUserToAddRows = False
        Me.dgmembers.AllowUserToDeleteRows = False
        Me.dgmembers.AllowUserToResizeColumns = False
        Me.dgmembers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.dgmembers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgmembers.AutoGenerateColumns = False
        Me.dgmembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgmembers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgmembers.BackgroundColor = System.Drawing.Color.White
        Me.dgmembers.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgmembers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgmembers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 10, 0, 10)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgmembers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgmembers.ColumnHeadersHeight = 42
        Me.dgmembers.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MembershipnoDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.CelphonenumDataGridViewTextBoxColumn, Me.ApplicationdateDataGridViewTextBoxColumn, Me.ValididDataGridViewTextBoxColumn, Me.ProofressidencyDataGridViewTextBoxColumn, Me.MembershipstatusDataGridViewTextBoxColumn})
        Me.dgmembers.DataSource = Me.MembertableBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.75!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgmembers.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgmembers.EnableHeadersVisualStyles = False
        Me.dgmembers.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dgmembers.Location = New System.Drawing.Point(59, 261)
        Me.dgmembers.MultiSelect = False
        Me.dgmembers.Name = "dgmembers"
        Me.dgmembers.ReadOnly = True
        Me.dgmembers.RowHeadersVisible = False
        Me.dgmembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.dgmembers.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgmembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgmembers.Size = New System.Drawing.Size(1207, 577)
        Me.dgmembers.TabIndex = 25
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
        Me.MembershipnoDataGridViewTextBoxColumn.HeaderText = "Membership #"
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
        'CelphonenumDataGridViewTextBoxColumn
        '
        Me.CelphonenumDataGridViewTextBoxColumn.DataPropertyName = "celphone_num"
        Me.CelphonenumDataGridViewTextBoxColumn.HeaderText = "Cellphone #"
        Me.CelphonenumDataGridViewTextBoxColumn.Name = "CelphonenumDataGridViewTextBoxColumn"
        Me.CelphonenumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApplicationdateDataGridViewTextBoxColumn
        '
        Me.ApplicationdateDataGridViewTextBoxColumn.DataPropertyName = "application_date"
        Me.ApplicationdateDataGridViewTextBoxColumn.HeaderText = "Application Date"
        Me.ApplicationdateDataGridViewTextBoxColumn.Name = "ApplicationdateDataGridViewTextBoxColumn"
        Me.ApplicationdateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ValididDataGridViewTextBoxColumn
        '
        Me.ValididDataGridViewTextBoxColumn.DataPropertyName = "valid_id"
        Me.ValididDataGridViewTextBoxColumn.HeaderText = "Valid ID"
        Me.ValididDataGridViewTextBoxColumn.Name = "ValididDataGridViewTextBoxColumn"
        Me.ValididDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ProofressidencyDataGridViewTextBoxColumn
        '
        Me.ProofressidencyDataGridViewTextBoxColumn.DataPropertyName = "proof_ressidency"
        Me.ProofressidencyDataGridViewTextBoxColumn.HeaderText = "Proof of Residency"
        Me.ProofressidencyDataGridViewTextBoxColumn.Name = "ProofressidencyDataGridViewTextBoxColumn"
        Me.ProofressidencyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MembershipstatusDataGridViewTextBoxColumn
        '
        Me.MembershipstatusDataGridViewTextBoxColumn.DataPropertyName = "membership_status"
        Me.MembershipstatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.MembershipstatusDataGridViewTextBoxColumn.Name = "MembershipstatusDataGridViewTextBoxColumn"
        Me.MembershipstatusDataGridViewTextBoxColumn.ReadOnly = True
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
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.DarkCyan
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(41, 18)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(278, 30)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Membership Approval"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkCyan
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Location = New System.Drawing.Point(-16, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1339, 72)
        Me.Panel1.TabIndex = 2
        '
        'btnapprove
        '
        Me.btnapprove.BackColor = System.Drawing.Color.CornflowerBlue
        Me.btnapprove.Enabled = False
        Me.btnapprove.FlatAppearance.BorderSize = 0
        Me.btnapprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnapprove.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnapprove.ForeColor = System.Drawing.Color.White
        Me.btnapprove.Location = New System.Drawing.Point(431, 155)
        Me.btnapprove.Name = "btnapprove"
        Me.btnapprove.Size = New System.Drawing.Size(260, 49)
        Me.btnapprove.TabIndex = 23
        Me.btnapprove.Text = "Approve"
        Me.btnapprove.UseVisualStyleBackColor = False
        '
        'btnreject
        '
        Me.btnreject.BackColor = System.Drawing.Color.Crimson
        Me.btnreject.Enabled = False
        Me.btnreject.FlatAppearance.BorderSize = 0
        Me.btnreject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreject.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreject.ForeColor = System.Drawing.Color.White
        Me.btnreject.Location = New System.Drawing.Point(769, 155)
        Me.btnreject.Name = "btnreject"
        Me.btnreject.Size = New System.Drawing.Size(260, 49)
        Me.btnreject.TabIndex = 24
        Me.btnreject.Text = "Reject"
        Me.btnreject.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gray
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(12, 93)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(126, 41)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Back"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblhidden)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(250, 118)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1016, 116)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action Panel"
        '
        'lblhidden
        '
        Me.lblhidden.AutoSize = True
        Me.lblhidden.Location = New System.Drawing.Point(913, 37)
        Me.lblhidden.Name = "lblhidden"
        Me.lblhidden.Size = New System.Drawing.Size(0, 21)
        Me.lblhidden.TabIndex = 28
        Me.lblhidden.Visible = False
        '
        'FRMMEMBERSHIP_container
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1318, 884)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.dgmembers)
        Me.Controls.Add(Me.btnreject)
        Me.Controls.Add(Me.btnapprove)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FRMMEMBERSHIP_container"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRMMEMBERSHIP_container"
        CType(Me.dgmembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MembertableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pmc_dbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgmembers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Pmc_dbDataSet As pmc_dbDataSet
    Friend WithEvents MembertableBindingSource As BindingSource
    Friend WithEvents Member_tableTableAdapter As pmc_dbDataSetTableAdapters.member_tableTableAdapter
    Friend WithEvents MembershipnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CelphonenumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ApplicationdateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ValididDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ProofressidencyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MembershipstatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnapprove As Button
    Friend WithEvents btnreject As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblhidden As Label
End Class
