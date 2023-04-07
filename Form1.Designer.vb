<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMMAINADMIN
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
        Me.BTNEXIT = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnprintables = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnabout = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnsettings = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnaudit = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnreports = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnservices = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnmembership = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btnum = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.btndashboard = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.pnlmain = New System.Windows.Forms.Panel()
        Me.lblpagename = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lbluser = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnlogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNEXIT
        '
        Me.BTNEXIT.BackColor = System.Drawing.Color.Red
        Me.BTNEXIT.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEXIT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEXIT.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEXIT.ForeColor = System.Drawing.SystemColors.Control
        Me.BTNEXIT.Location = New System.Drawing.Point(1642, -2)
        Me.BTNEXIT.Margin = New System.Windows.Forms.Padding(4)
        Me.BTNEXIT.Name = "BTNEXIT"
        Me.BTNEXIT.Size = New System.Drawing.Size(63, 44)
        Me.BTNEXIT.TabIndex = 1
        Me.BTNEXIT.Text = "X"
        Me.BTNEXIT.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MidnightBlue
        Me.Panel1.Controls.Add(Me.btnprintables)
        Me.Panel1.Controls.Add(Me.btnabout)
        Me.Panel1.Controls.Add(Me.btnsettings)
        Me.Panel1.Controls.Add(Me.btnaudit)
        Me.Panel1.Controls.Add(Me.btnreports)
        Me.Panel1.Controls.Add(Me.btnservices)
        Me.Panel1.Controls.Add(Me.btnmembership)
        Me.Panel1.Controls.Add(Me.btnum)
        Me.Panel1.Controls.Add(Me.btndashboard)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 913)
        Me.Panel1.TabIndex = 2
        '
        'btnprintables
        '
        Me.btnprintables.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnprintables.BackColor = System.Drawing.Color.Transparent
        Me.btnprintables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnprintables.BorderRadius = 0
        Me.btnprintables.ButtonText = "Printables"
        Me.btnprintables.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnprintables.DisabledColor = System.Drawing.Color.Gray
        Me.btnprintables.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnprintables.Iconimage = Nothing
        Me.btnprintables.Iconimage_right = Nothing
        Me.btnprintables.Iconimage_right_Selected = Nothing
        Me.btnprintables.Iconimage_Selected = Nothing
        Me.btnprintables.IconMarginLeft = 0
        Me.btnprintables.IconMarginRight = 0
        Me.btnprintables.IconRightVisible = True
        Me.btnprintables.IconRightZoom = 0R
        Me.btnprintables.IconVisible = True
        Me.btnprintables.IconZoom = 90.0R
        Me.btnprintables.IsTab = False
        Me.btnprintables.Location = New System.Drawing.Point(0, 733)
        Me.btnprintables.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnprintables.Name = "btnprintables"
        Me.btnprintables.Normalcolor = System.Drawing.Color.Transparent
        Me.btnprintables.OnHovercolor = System.Drawing.Color.White
        Me.btnprintables.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnprintables.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnprintables.selected = False
        Me.btnprintables.Size = New System.Drawing.Size(290, 59)
        Me.btnprintables.TabIndex = 11
        Me.btnprintables.Text = "Printables"
        Me.btnprintables.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnprintables.Textcolor = System.Drawing.Color.White
        Me.btnprintables.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnabout
        '
        Me.btnabout.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnabout.BackColor = System.Drawing.Color.Transparent
        Me.btnabout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnabout.BorderRadius = 0
        Me.btnabout.ButtonText = "About Us"
        Me.btnabout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnabout.DisabledColor = System.Drawing.Color.Gray
        Me.btnabout.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnabout.Iconimage = Nothing
        Me.btnabout.Iconimage_right = Nothing
        Me.btnabout.Iconimage_right_Selected = Nothing
        Me.btnabout.Iconimage_Selected = Nothing
        Me.btnabout.IconMarginLeft = 0
        Me.btnabout.IconMarginRight = 0
        Me.btnabout.IconRightVisible = True
        Me.btnabout.IconRightZoom = 0R
        Me.btnabout.IconVisible = True
        Me.btnabout.IconZoom = 90.0R
        Me.btnabout.IsTab = False
        Me.btnabout.Location = New System.Drawing.Point(0, 666)
        Me.btnabout.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnabout.Name = "btnabout"
        Me.btnabout.Normalcolor = System.Drawing.Color.Transparent
        Me.btnabout.OnHovercolor = System.Drawing.Color.White
        Me.btnabout.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnabout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnabout.selected = False
        Me.btnabout.Size = New System.Drawing.Size(290, 59)
        Me.btnabout.TabIndex = 10
        Me.btnabout.Text = "About Us"
        Me.btnabout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnabout.Textcolor = System.Drawing.Color.White
        Me.btnabout.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnsettings
        '
        Me.btnsettings.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnsettings.BackColor = System.Drawing.Color.Transparent
        Me.btnsettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnsettings.BorderRadius = 0
        Me.btnsettings.ButtonText = "Settings"
        Me.btnsettings.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsettings.DisabledColor = System.Drawing.Color.Gray
        Me.btnsettings.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnsettings.Iconimage = Nothing
        Me.btnsettings.Iconimage_right = Nothing
        Me.btnsettings.Iconimage_right_Selected = Nothing
        Me.btnsettings.Iconimage_Selected = Nothing
        Me.btnsettings.IconMarginLeft = 0
        Me.btnsettings.IconMarginRight = 0
        Me.btnsettings.IconRightVisible = True
        Me.btnsettings.IconRightZoom = 0R
        Me.btnsettings.IconVisible = True
        Me.btnsettings.IconZoom = 90.0R
        Me.btnsettings.IsTab = False
        Me.btnsettings.Location = New System.Drawing.Point(4, 599)
        Me.btnsettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsettings.Name = "btnsettings"
        Me.btnsettings.Normalcolor = System.Drawing.Color.Transparent
        Me.btnsettings.OnHovercolor = System.Drawing.Color.White
        Me.btnsettings.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnsettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnsettings.selected = False
        Me.btnsettings.Size = New System.Drawing.Size(290, 59)
        Me.btnsettings.TabIndex = 9
        Me.btnsettings.Text = "Settings"
        Me.btnsettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnsettings.Textcolor = System.Drawing.Color.White
        Me.btnsettings.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnaudit
        '
        Me.btnaudit.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnaudit.BackColor = System.Drawing.Color.Transparent
        Me.btnaudit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnaudit.BorderRadius = 0
        Me.btnaudit.ButtonText = "Audit Trail"
        Me.btnaudit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaudit.DisabledColor = System.Drawing.Color.Gray
        Me.btnaudit.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnaudit.Iconimage = Nothing
        Me.btnaudit.Iconimage_right = Nothing
        Me.btnaudit.Iconimage_right_Selected = Nothing
        Me.btnaudit.Iconimage_Selected = Nothing
        Me.btnaudit.IconMarginLeft = 0
        Me.btnaudit.IconMarginRight = 0
        Me.btnaudit.IconRightVisible = True
        Me.btnaudit.IconRightZoom = 0R
        Me.btnaudit.IconVisible = True
        Me.btnaudit.IconZoom = 90.0R
        Me.btnaudit.IsTab = False
        Me.btnaudit.Location = New System.Drawing.Point(0, 532)
        Me.btnaudit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnaudit.Name = "btnaudit"
        Me.btnaudit.Normalcolor = System.Drawing.Color.Transparent
        Me.btnaudit.OnHovercolor = System.Drawing.Color.White
        Me.btnaudit.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnaudit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnaudit.selected = False
        Me.btnaudit.Size = New System.Drawing.Size(290, 59)
        Me.btnaudit.TabIndex = 8
        Me.btnaudit.Text = "Audit Trail"
        Me.btnaudit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnaudit.Textcolor = System.Drawing.Color.White
        Me.btnaudit.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnreports
        '
        Me.btnreports.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnreports.BackColor = System.Drawing.Color.Transparent
        Me.btnreports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnreports.BorderRadius = 0
        Me.btnreports.ButtonText = "Reports"
        Me.btnreports.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnreports.DisabledColor = System.Drawing.Color.Gray
        Me.btnreports.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnreports.Iconimage = Nothing
        Me.btnreports.Iconimage_right = Nothing
        Me.btnreports.Iconimage_right_Selected = Nothing
        Me.btnreports.Iconimage_Selected = Nothing
        Me.btnreports.IconMarginLeft = 0
        Me.btnreports.IconMarginRight = 0
        Me.btnreports.IconRightVisible = True
        Me.btnreports.IconRightZoom = 0R
        Me.btnreports.IconVisible = True
        Me.btnreports.IconZoom = 90.0R
        Me.btnreports.IsTab = False
        Me.btnreports.Location = New System.Drawing.Point(0, 465)
        Me.btnreports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnreports.Name = "btnreports"
        Me.btnreports.Normalcolor = System.Drawing.Color.Transparent
        Me.btnreports.OnHovercolor = System.Drawing.Color.White
        Me.btnreports.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnreports.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnreports.selected = False
        Me.btnreports.Size = New System.Drawing.Size(290, 59)
        Me.btnreports.TabIndex = 7
        Me.btnreports.Text = "Reports"
        Me.btnreports.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnreports.Textcolor = System.Drawing.Color.White
        Me.btnreports.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnservices
        '
        Me.btnservices.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnservices.BackColor = System.Drawing.Color.Transparent
        Me.btnservices.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnservices.BorderRadius = 0
        Me.btnservices.ButtonText = "Services"
        Me.btnservices.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnservices.DisabledColor = System.Drawing.Color.Gray
        Me.btnservices.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnservices.Iconimage = Nothing
        Me.btnservices.Iconimage_right = Nothing
        Me.btnservices.Iconimage_right_Selected = Nothing
        Me.btnservices.Iconimage_Selected = Nothing
        Me.btnservices.IconMarginLeft = 0
        Me.btnservices.IconMarginRight = 0
        Me.btnservices.IconRightVisible = True
        Me.btnservices.IconRightZoom = 0R
        Me.btnservices.IconVisible = True
        Me.btnservices.IconZoom = 90.0R
        Me.btnservices.IsTab = False
        Me.btnservices.Location = New System.Drawing.Point(0, 398)
        Me.btnservices.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnservices.Name = "btnservices"
        Me.btnservices.Normalcolor = System.Drawing.Color.Transparent
        Me.btnservices.OnHovercolor = System.Drawing.Color.White
        Me.btnservices.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnservices.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnservices.selected = False
        Me.btnservices.Size = New System.Drawing.Size(290, 59)
        Me.btnservices.TabIndex = 6
        Me.btnservices.Text = "Services"
        Me.btnservices.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnservices.Textcolor = System.Drawing.Color.White
        Me.btnservices.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnmembership
        '
        Me.btnmembership.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnmembership.BackColor = System.Drawing.Color.Transparent
        Me.btnmembership.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnmembership.BorderRadius = 0
        Me.btnmembership.ButtonText = "Membership"
        Me.btnmembership.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmembership.DisabledColor = System.Drawing.Color.Gray
        Me.btnmembership.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnmembership.Iconimage = Nothing
        Me.btnmembership.Iconimage_right = Nothing
        Me.btnmembership.Iconimage_right_Selected = Nothing
        Me.btnmembership.Iconimage_Selected = Nothing
        Me.btnmembership.IconMarginLeft = 0
        Me.btnmembership.IconMarginRight = 0
        Me.btnmembership.IconRightVisible = True
        Me.btnmembership.IconRightZoom = 0R
        Me.btnmembership.IconVisible = True
        Me.btnmembership.IconZoom = 90.0R
        Me.btnmembership.IsTab = False
        Me.btnmembership.Location = New System.Drawing.Point(0, 331)
        Me.btnmembership.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnmembership.Name = "btnmembership"
        Me.btnmembership.Normalcolor = System.Drawing.Color.Transparent
        Me.btnmembership.OnHovercolor = System.Drawing.Color.White
        Me.btnmembership.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnmembership.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnmembership.selected = False
        Me.btnmembership.Size = New System.Drawing.Size(290, 59)
        Me.btnmembership.TabIndex = 5
        Me.btnmembership.Text = "Membership"
        Me.btnmembership.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnmembership.Textcolor = System.Drawing.Color.White
        Me.btnmembership.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btnum
        '
        Me.btnum.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btnum.BackColor = System.Drawing.Color.Transparent
        Me.btnum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnum.BorderRadius = 0
        Me.btnum.ButtonText = "User Management"
        Me.btnum.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnum.DisabledColor = System.Drawing.Color.Gray
        Me.btnum.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btnum.Iconimage = Nothing
        Me.btnum.Iconimage_right = Nothing
        Me.btnum.Iconimage_right_Selected = Nothing
        Me.btnum.Iconimage_Selected = Nothing
        Me.btnum.IconMarginLeft = 0
        Me.btnum.IconMarginRight = 0
        Me.btnum.IconRightVisible = True
        Me.btnum.IconRightZoom = 0R
        Me.btnum.IconVisible = True
        Me.btnum.IconZoom = 90.0R
        Me.btnum.IsTab = False
        Me.btnum.Location = New System.Drawing.Point(0, 264)
        Me.btnum.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnum.Name = "btnum"
        Me.btnum.Normalcolor = System.Drawing.Color.Transparent
        Me.btnum.OnHovercolor = System.Drawing.Color.White
        Me.btnum.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnum.selected = False
        Me.btnum.Size = New System.Drawing.Size(290, 59)
        Me.btnum.TabIndex = 4
        Me.btnum.Text = "User Management"
        Me.btnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnum.Textcolor = System.Drawing.Color.White
        Me.btnum.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'btndashboard
        '
        Me.btndashboard.Activecolor = System.Drawing.Color.RoyalBlue
        Me.btndashboard.BackColor = System.Drawing.Color.Transparent
        Me.btndashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btndashboard.BorderRadius = 0
        Me.btndashboard.ButtonText = "Dashboard"
        Me.btndashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndashboard.DisabledColor = System.Drawing.Color.Gray
        Me.btndashboard.Iconcolor = System.Drawing.Color.WhiteSmoke
        Me.btndashboard.Iconimage = Nothing
        Me.btndashboard.Iconimage_right = Nothing
        Me.btndashboard.Iconimage_right_Selected = Nothing
        Me.btndashboard.Iconimage_Selected = Nothing
        Me.btndashboard.IconMarginLeft = 0
        Me.btndashboard.IconMarginRight = 0
        Me.btndashboard.IconRightVisible = True
        Me.btndashboard.IconRightZoom = 0R
        Me.btndashboard.IconVisible = True
        Me.btndashboard.IconZoom = 90.0R
        Me.btndashboard.IsTab = False
        Me.btndashboard.Location = New System.Drawing.Point(0, 197)
        Me.btndashboard.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btndashboard.Name = "btndashboard"
        Me.btndashboard.Normalcolor = System.Drawing.Color.Transparent
        Me.btndashboard.OnHovercolor = System.Drawing.Color.White
        Me.btndashboard.OnHoverTextColor = System.Drawing.Color.Black
        Me.btndashboard.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btndashboard.selected = False
        Me.btndashboard.Size = New System.Drawing.Size(290, 59)
        Me.btndashboard.TabIndex = 3
        Me.btndashboard.Text = "Dashboard"
        Me.btndashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btndashboard.Textcolor = System.Drawing.Color.White
        Me.btndashboard.TextFont = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TPS__Pagasa_MultiPurpose_Cooperative.My.Resources.Resources.FB_IMG_1673280633955_removebg_preview
        Me.PictureBox1.Location = New System.Drawing.Point(66, 33)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(161, 127)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'pnlmain
        '
        Me.pnlmain.Location = New System.Drawing.Point(310, 60)
        Me.pnlmain.Name = "pnlmain"
        Me.pnlmain.Size = New System.Drawing.Size(1358, 818)
        Me.pnlmain.TabIndex = 3
        '
        'lblpagename
        '
        Me.lblpagename.AutoSize = True
        Me.lblpagename.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagename.ForeColor = System.Drawing.Color.RoyalBlue
        Me.lblpagename.Location = New System.Drawing.Point(310, 12)
        Me.lblpagename.Name = "lblpagename"
        Me.lblpagename.Size = New System.Drawing.Size(143, 30)
        Me.lblpagename.TabIndex = 4
        Me.lblpagename.Text = "Dashboard"
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.ForeColor = System.Drawing.Color.Black
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(1146, 17)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(108, 20)
        Me.BunifuCustomLabel1.TabIndex = 5
        Me.BunifuCustomLabel1.Text = "Current User :"
        '
        'lbluser
        '
        Me.lbluser.AutoSize = True
        Me.lbluser.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbluser.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lbluser.Location = New System.Drawing.Point(1281, 17)
        Me.lbluser.Name = "lbluser"
        Me.lbluser.Size = New System.Drawing.Size(55, 20)
        Me.lbluser.TabIndex = 6
        Me.lbluser.Text = "Admin"
        '
        'btnlogout
        '
        Me.btnlogout.Location = New System.Drawing.Point(1492, 12)
        Me.btnlogout.Name = "btnlogout"
        Me.btnlogout.Size = New System.Drawing.Size(94, 32)
        Me.btnlogout.TabIndex = 7
        Me.btnlogout.Text = "Logout"
        Me.btnlogout.UseVisualStyleBackColor = True
        '
        'FRMMAINADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer), CType(CType(238, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1700, 900)
        Me.Controls.Add(Me.btnlogout)
        Me.Controls.Add(Me.lbluser)
        Me.Controls.Add(Me.BunifuCustomLabel1)
        Me.Controls.Add(Me.lblpagename)
        Me.Controls.Add(Me.pnlmain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTNEXIT)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRMMAINADMIN"
        Me.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNEXIT As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btndashboard As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnabout As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnsettings As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnaudit As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnreports As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnservices As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnmembership As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents btnum As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pnlmain As Panel
    Friend WithEvents lblpagename As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnprintables As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lbluser As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnlogout As Button
End Class
