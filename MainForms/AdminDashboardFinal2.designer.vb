<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminDashboardFinal2
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
        Me.DashboardPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.AdminRecordBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ReportsBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.ManageCategoryBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.UserID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.LogOutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.VehicleTableBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.OverviewBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AdditionalBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardPanel
        '
        Me.DashboardPanel.BackColor = System.Drawing.Color.Transparent
        Me.DashboardPanel.Controls.Add(Me.AdditionalBtn)
        Me.DashboardPanel.Controls.Add(Me.AdminRecordBtn)
        Me.DashboardPanel.Controls.Add(Me.ReportsBtn)
        Me.DashboardPanel.Controls.Add(Me.ManageCategoryBtn)
        Me.DashboardPanel.Controls.Add(Me.UserID)
        Me.DashboardPanel.Controls.Add(Me.Guna2HtmlLabel2)
        Me.DashboardPanel.Controls.Add(Me.Guna2PictureBox1)
        Me.DashboardPanel.Controls.Add(Me.LogOutBtn)
        Me.DashboardPanel.Controls.Add(Me.VehicleTableBtn)
        Me.DashboardPanel.Controls.Add(Me.OverviewBtn)
        Me.DashboardPanel.CustomBorderColor = System.Drawing.Color.Transparent
        Me.DashboardPanel.CustomizableEdges.BottomLeft = False
        Me.DashboardPanel.CustomizableEdges.TopLeft = False
        Me.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DashboardPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DashboardPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboardPanel.Name = "DashboardPanel"
        Me.DashboardPanel.ShadowDecoration.Parent = Me.DashboardPanel
        Me.DashboardPanel.Size = New System.Drawing.Size(200, 688)
        Me.DashboardPanel.TabIndex = 1
        Me.DashboardPanel.UseTransparentBackground = True
        '
        'AdminRecordBtn
        '
        Me.AdminRecordBtn.Animated = True
        Me.AdminRecordBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.AdminRecordBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.AdminRecordBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.AdminRecordBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources.cells__1_
        Me.AdminRecordBtn.CheckedState.Parent = Me.AdminRecordBtn
        Me.AdminRecordBtn.CustomImages.Parent = Me.AdminRecordBtn
        Me.AdminRecordBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AdminRecordBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AdminRecordBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AdminRecordBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AdminRecordBtn.DisabledState.Parent = Me.AdminRecordBtn
        Me.AdminRecordBtn.FillColor = System.Drawing.Color.Transparent
        Me.AdminRecordBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AdminRecordBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdminRecordBtn.ForeColor = System.Drawing.Color.White
        Me.AdminRecordBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AdminRecordBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdminRecordBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.AdminRecordBtn.HoverState.Parent = Me.AdminRecordBtn
        Me.AdminRecordBtn.Image = Global.VPMSFinal.My.Resources.Resources.cells
        Me.AdminRecordBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminRecordBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.AdminRecordBtn.Location = New System.Drawing.Point(0, 463)
        Me.AdminRecordBtn.Name = "AdminRecordBtn"
        Me.AdminRecordBtn.PressedColor = System.Drawing.Color.White
        Me.AdminRecordBtn.ShadowDecoration.Parent = Me.AdminRecordBtn
        Me.AdminRecordBtn.Size = New System.Drawing.Size(200, 45)
        Me.AdminRecordBtn.TabIndex = 10
        Me.AdminRecordBtn.Text = "Admin Record"
        Me.AdminRecordBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdminRecordBtn.TextOffset = New System.Drawing.Point(20, 0)
        '
        'ReportsBtn
        '
        Me.ReportsBtn.Animated = True
        Me.ReportsBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ReportsBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ReportsBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.ReportsBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources.edit
        Me.ReportsBtn.CheckedState.Parent = Me.ReportsBtn
        Me.ReportsBtn.CustomImages.Parent = Me.ReportsBtn
        Me.ReportsBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ReportsBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ReportsBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ReportsBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ReportsBtn.DisabledState.Parent = Me.ReportsBtn
        Me.ReportsBtn.FillColor = System.Drawing.Color.Transparent
        Me.ReportsBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ReportsBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsBtn.ForeColor = System.Drawing.Color.White
        Me.ReportsBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ReportsBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ReportsBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.ReportsBtn.HoverState.Parent = Me.ReportsBtn
        Me.ReportsBtn.Image = Global.VPMSFinal.My.Resources.Resources.edit__1_
        Me.ReportsBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ReportsBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.ReportsBtn.Location = New System.Drawing.Point(3, 565)
        Me.ReportsBtn.Name = "ReportsBtn"
        Me.ReportsBtn.PressedColor = System.Drawing.Color.White
        Me.ReportsBtn.ShadowDecoration.Parent = Me.ReportsBtn
        Me.ReportsBtn.Size = New System.Drawing.Size(200, 45)
        Me.ReportsBtn.TabIndex = 9
        Me.ReportsBtn.Text = "Reports"
        Me.ReportsBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ReportsBtn.TextOffset = New System.Drawing.Point(20, 0)
        '
        'ManageCategoryBtn
        '
        Me.ManageCategoryBtn.Animated = True
        Me.ManageCategoryBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.ManageCategoryBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.ManageCategoryBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.ManageCategoryBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources.settings_cog
        Me.ManageCategoryBtn.CheckedState.Parent = Me.ManageCategoryBtn
        Me.ManageCategoryBtn.CustomImages.Parent = Me.ManageCategoryBtn
        Me.ManageCategoryBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ManageCategoryBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ManageCategoryBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ManageCategoryBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ManageCategoryBtn.DisabledState.Parent = Me.ManageCategoryBtn
        Me.ManageCategoryBtn.FillColor = System.Drawing.Color.Transparent
        Me.ManageCategoryBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ManageCategoryBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ManageCategoryBtn.ForeColor = System.Drawing.Color.White
        Me.ManageCategoryBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ManageCategoryBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ManageCategoryBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.ManageCategoryBtn.HoverState.Parent = Me.ManageCategoryBtn
        Me.ManageCategoryBtn.Image = Global.VPMSFinal.My.Resources.Resources.settings_cog__1_
        Me.ManageCategoryBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ManageCategoryBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.ManageCategoryBtn.Location = New System.Drawing.Point(0, 514)
        Me.ManageCategoryBtn.Name = "ManageCategoryBtn"
        Me.ManageCategoryBtn.PressedColor = System.Drawing.Color.White
        Me.ManageCategoryBtn.ShadowDecoration.Parent = Me.ManageCategoryBtn
        Me.ManageCategoryBtn.Size = New System.Drawing.Size(200, 45)
        Me.ManageCategoryBtn.TabIndex = 8
        Me.ManageCategoryBtn.Text = "Manage Category"
        Me.ManageCategoryBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.ManageCategoryBtn.TextOffset = New System.Drawing.Point(20, 0)
        '
        'UserID
        '
        Me.UserID.BackColor = System.Drawing.Color.Transparent
        Me.UserID.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserID.ForeColor = System.Drawing.Color.White
        Me.UserID.Location = New System.Drawing.Point(81, 244)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(10, 28)
        Me.UserID.TabIndex = 7
        Me.UserID.Text = "1"
        Me.UserID.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(45, 210)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(110, 28)
        Me.Guna2HtmlLabel2.TabIndex = 6
        Me.Guna2HtmlLabel2.Text = "WELCOME"
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.VPMSFinal.My.Resources.Resources.BLSRParkSysFinal
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 23)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(200, 165)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'LogOutBtn
        '
        Me.LogOutBtn.Animated = True
        Me.LogOutBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.LogOutBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.LogOutBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources._exit
        Me.LogOutBtn.CheckedState.Parent = Me.LogOutBtn
        Me.LogOutBtn.CustomImages.Parent = Me.LogOutBtn
        Me.LogOutBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.LogOutBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.LogOutBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.LogOutBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.LogOutBtn.DisabledState.Parent = Me.LogOutBtn
        Me.LogOutBtn.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LogOutBtn.FillColor = System.Drawing.Color.Transparent
        Me.LogOutBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LogOutBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LogOutBtn.ForeColor = System.Drawing.Color.White
        Me.LogOutBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.LogOutBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LogOutBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.LogOutBtn.HoverState.Parent = Me.LogOutBtn
        Me.LogOutBtn.Image = Global.VPMSFinal.My.Resources.Resources.exit__1_
        Me.LogOutBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.LogOutBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.LogOutBtn.Location = New System.Drawing.Point(0, 643)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.ShadowDecoration.Parent = Me.LogOutBtn
        Me.LogOutBtn.Size = New System.Drawing.Size(200, 45)
        Me.LogOutBtn.TabIndex = 2
        Me.LogOutBtn.Text = "Log Out"
        '
        'VehicleTableBtn
        '
        Me.VehicleTableBtn.Animated = True
        Me.VehicleTableBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.VehicleTableBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.VehicleTableBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.VehicleTableBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources.cells__1_
        Me.VehicleTableBtn.CheckedState.Parent = Me.VehicleTableBtn
        Me.VehicleTableBtn.CustomImages.Parent = Me.VehicleTableBtn
        Me.VehicleTableBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.VehicleTableBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.VehicleTableBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.VehicleTableBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.VehicleTableBtn.DisabledState.Parent = Me.VehicleTableBtn
        Me.VehicleTableBtn.FillColor = System.Drawing.Color.Transparent
        Me.VehicleTableBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.VehicleTableBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VehicleTableBtn.ForeColor = System.Drawing.Color.White
        Me.VehicleTableBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.VehicleTableBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.VehicleTableBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.VehicleTableBtn.HoverState.Parent = Me.VehicleTableBtn
        Me.VehicleTableBtn.Image = Global.VPMSFinal.My.Resources.Resources.cells
        Me.VehicleTableBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.VehicleTableBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.VehicleTableBtn.Location = New System.Drawing.Point(0, 361)
        Me.VehicleTableBtn.Name = "VehicleTableBtn"
        Me.VehicleTableBtn.PressedColor = System.Drawing.Color.White
        Me.VehicleTableBtn.ShadowDecoration.Parent = Me.VehicleTableBtn
        Me.VehicleTableBtn.Size = New System.Drawing.Size(200, 45)
        Me.VehicleTableBtn.TabIndex = 1
        Me.VehicleTableBtn.Text = "Vehicle Table"
        Me.VehicleTableBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.VehicleTableBtn.TextOffset = New System.Drawing.Point(20, 0)
        '
        'OverviewBtn
        '
        Me.OverviewBtn.Animated = True
        Me.OverviewBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.OverviewBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.OverviewBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.OverviewBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources.file__1_
        Me.OverviewBtn.CheckedState.Parent = Me.OverviewBtn
        Me.OverviewBtn.CustomImages.Parent = Me.OverviewBtn
        Me.OverviewBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.OverviewBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.OverviewBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.OverviewBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.OverviewBtn.DisabledState.Parent = Me.OverviewBtn
        Me.OverviewBtn.FillColor = System.Drawing.Color.Transparent
        Me.OverviewBtn.FocusedColor = System.Drawing.Color.Transparent
        Me.OverviewBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OverviewBtn.ForeColor = System.Drawing.Color.White
        Me.OverviewBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.OverviewBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.OverviewBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.OverviewBtn.HoverState.Parent = Me.OverviewBtn
        Me.OverviewBtn.Image = Global.VPMSFinal.My.Resources.Resources.file
        Me.OverviewBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.OverviewBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.OverviewBtn.Location = New System.Drawing.Point(0, 310)
        Me.OverviewBtn.Name = "OverviewBtn"
        Me.OverviewBtn.PressedColor = System.Drawing.Color.White
        Me.OverviewBtn.ShadowDecoration.Parent = Me.OverviewBtn
        Me.OverviewBtn.Size = New System.Drawing.Size(200, 45)
        Me.OverviewBtn.TabIndex = 0
        Me.OverviewBtn.Text = "Overview"
        Me.OverviewBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.OverviewBtn.TextOffset = New System.Drawing.Point(20, 0)
        '
        'AdditionalBtn
        '
        Me.AdditionalBtn.Animated = True
        Me.AdditionalBtn.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton
        Me.AdditionalBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.AdditionalBtn.CheckedState.ForeColor = System.Drawing.Color.Black
        Me.AdditionalBtn.CheckedState.Image = Global.VPMSFinal.My.Resources.Resources.cells__1_
        Me.AdditionalBtn.CheckedState.Parent = Me.AdditionalBtn
        Me.AdditionalBtn.CustomImages.Parent = Me.AdditionalBtn
        Me.AdditionalBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AdditionalBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AdditionalBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AdditionalBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AdditionalBtn.DisabledState.Parent = Me.AdditionalBtn
        Me.AdditionalBtn.FillColor = System.Drawing.Color.Transparent
        Me.AdditionalBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AdditionalBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdditionalBtn.ForeColor = System.Drawing.Color.White
        Me.AdditionalBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AdditionalBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AdditionalBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.AdditionalBtn.HoverState.Parent = Me.AdditionalBtn
        Me.AdditionalBtn.Image = Global.VPMSFinal.My.Resources.Resources.cells
        Me.AdditionalBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdditionalBtn.ImageOffset = New System.Drawing.Point(10, 0)
        Me.AdditionalBtn.Location = New System.Drawing.Point(0, 412)
        Me.AdditionalBtn.Name = "AdditionalBtn"
        Me.AdditionalBtn.PressedColor = System.Drawing.Color.White
        Me.AdditionalBtn.ShadowDecoration.Parent = Me.AdditionalBtn
        Me.AdditionalBtn.Size = New System.Drawing.Size(200, 45)
        Me.AdditionalBtn.TabIndex = 11
        Me.AdditionalBtn.Text = "Additional Vehicle Info"
        Me.AdditionalBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.AdditionalBtn.TextOffset = New System.Drawing.Point(20, 0)
        '
        'AdminDashboardFinal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1355, 688)
        Me.Controls.Add(Me.DashboardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdminDashboardFinal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AdminDashboardFinal2"
        Me.DashboardPanel.ResumeLayout(False)
        Me.DashboardPanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents UserID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents LogOutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VehicleTableBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OverviewBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ManageCategoryBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ReportsBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AdminRecordBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AdditionalBtn As Guna.UI2.WinForms.Guna2Button
End Class
