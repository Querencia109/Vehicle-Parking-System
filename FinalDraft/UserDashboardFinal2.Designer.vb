<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserDashboardFinal2
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
        Me.DashboardPanel = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2TextBox1 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ManageVehicleBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.AddVehicleBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.LogOutBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.VehicleTableBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.OverviewBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.DashboardPanel.SuspendLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DashboardPanel
        '
        Me.DashboardPanel.BackColor = System.Drawing.Color.Transparent
        Me.DashboardPanel.Controls.Add(Me.Guna2PictureBox1)
        Me.DashboardPanel.Controls.Add(Me.Guna2HtmlLabel1)
        Me.DashboardPanel.Controls.Add(Me.Guna2TextBox1)
        Me.DashboardPanel.Controls.Add(Me.ManageVehicleBtn)
        Me.DashboardPanel.Controls.Add(Me.AddVehicleBtn)
        Me.DashboardPanel.Controls.Add(Me.LogOutBtn)
        Me.DashboardPanel.Controls.Add(Me.VehicleTableBtn)
        Me.DashboardPanel.Controls.Add(Me.OverviewBtn)
        Me.DashboardPanel.CustomBorderColor = System.Drawing.Color.Black
        Me.DashboardPanel.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 1, 0)
        Me.DashboardPanel.CustomizableEdges.BottomLeft = False
        Me.DashboardPanel.CustomizableEdges.TopLeft = False
        Me.DashboardPanel.Dock = System.Windows.Forms.DockStyle.Left
        Me.DashboardPanel.FillColor = System.Drawing.Color.FromArgb(CType(CType(142, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DashboardPanel.Location = New System.Drawing.Point(0, 0)
        Me.DashboardPanel.Name = "DashboardPanel"
        Me.DashboardPanel.ShadowDecoration.Parent = Me.DashboardPanel
        Me.DashboardPanel.Size = New System.Drawing.Size(200, 688)
        Me.DashboardPanel.TabIndex = 0
        Me.DashboardPanel.UseTransparentBackground = True
        '
        'Guna2PictureBox1
        '
        Me.Guna2PictureBox1.Image = Global.VehicleParkingManagementSystem.My.Resources.Resources.BLSRParkSysFinal
        Me.Guna2PictureBox1.ImageRotate = 0!
        Me.Guna2PictureBox1.Location = New System.Drawing.Point(0, 3)
        Me.Guna2PictureBox1.Name = "Guna2PictureBox1"
        Me.Guna2PictureBox1.ShadowDecoration.Parent = Me.Guna2PictureBox1
        Me.Guna2PictureBox1.Size = New System.Drawing.Size(200, 165)
        Me.Guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2PictureBox1.TabIndex = 1
        Me.Guna2PictureBox1.TabStop = False
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Black
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(69, 188)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(62, 17)
        Me.Guna2HtmlLabel1.TabIndex = 5
        Me.Guna2HtmlLabel1.Text = "Dashboard"
        '
        'Guna2TextBox1
        '
        Me.Guna2TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.BorderColor = System.Drawing.Color.Transparent
        Me.Guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Guna2TextBox1.DefaultText = ""
        Me.Guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.DisabledState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.Enabled = False
        Me.Guna2TextBox1.FillColor = System.Drawing.Color.Black
        Me.Guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.FocusedState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2TextBox1.ForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2TextBox1.HoverState.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Location = New System.Drawing.Point(0, 174)
        Me.Guna2TextBox1.Name = "Guna2TextBox1"
        Me.Guna2TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.White
        Me.Guna2TextBox1.PlaceholderText = ""
        Me.Guna2TextBox1.ReadOnly = True
        Me.Guna2TextBox1.SelectedText = ""
        Me.Guna2TextBox1.ShadowDecoration.Parent = Me.Guna2TextBox1
        Me.Guna2TextBox1.Size = New System.Drawing.Size(200, 45)
        Me.Guna2TextBox1.TabIndex = 1
        '
        'ManageVehicleBtn
        '
        Me.ManageVehicleBtn.Animated = True
        Me.ManageVehicleBtn.CheckedState.Parent = Me.ManageVehicleBtn
        Me.ManageVehicleBtn.CustomImages.Parent = Me.ManageVehicleBtn
        Me.ManageVehicleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ManageVehicleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ManageVehicleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ManageVehicleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ManageVehicleBtn.DisabledState.Parent = Me.ManageVehicleBtn
        Me.ManageVehicleBtn.FillColor = System.Drawing.Color.Transparent
        Me.ManageVehicleBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ManageVehicleBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ManageVehicleBtn.ForeColor = System.Drawing.Color.White
        Me.ManageVehicleBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ManageVehicleBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ManageVehicleBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.ManageVehicleBtn.HoverState.Parent = Me.ManageVehicleBtn
        Me.ManageVehicleBtn.Location = New System.Drawing.Point(0, 378)
        Me.ManageVehicleBtn.Name = "ManageVehicleBtn"
        Me.ManageVehicleBtn.ShadowDecoration.Parent = Me.ManageVehicleBtn
        Me.ManageVehicleBtn.Size = New System.Drawing.Size(200, 45)
        Me.ManageVehicleBtn.TabIndex = 4
        Me.ManageVehicleBtn.Text = "Manage Vehicle"
        Me.ManageVehicleBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'AddVehicleBtn
        '
        Me.AddVehicleBtn.Animated = True
        Me.AddVehicleBtn.CheckedState.Parent = Me.AddVehicleBtn
        Me.AddVehicleBtn.CustomImages.Parent = Me.AddVehicleBtn
        Me.AddVehicleBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddVehicleBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddVehicleBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddVehicleBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddVehicleBtn.DisabledState.Parent = Me.AddVehicleBtn
        Me.AddVehicleBtn.FillColor = System.Drawing.Color.Transparent
        Me.AddVehicleBtn.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AddVehicleBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AddVehicleBtn.ForeColor = System.Drawing.Color.White
        Me.AddVehicleBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AddVehicleBtn.HoverState.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.AddVehicleBtn.HoverState.ForeColor = System.Drawing.Color.White
        Me.AddVehicleBtn.HoverState.Parent = Me.AddVehicleBtn
        Me.AddVehicleBtn.Location = New System.Drawing.Point(0, 327)
        Me.AddVehicleBtn.Name = "AddVehicleBtn"
        Me.AddVehicleBtn.ShadowDecoration.Parent = Me.AddVehicleBtn
        Me.AddVehicleBtn.Size = New System.Drawing.Size(200, 45)
        Me.AddVehicleBtn.TabIndex = 3
        Me.AddVehicleBtn.Text = "Add Vehicle"
        Me.AddVehicleBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'LogOutBtn
        '
        Me.LogOutBtn.Animated = True
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
        Me.VehicleTableBtn.Location = New System.Drawing.Point(0, 276)
        Me.VehicleTableBtn.Name = "VehicleTableBtn"
        Me.VehicleTableBtn.ShadowDecoration.Parent = Me.VehicleTableBtn
        Me.VehicleTableBtn.Size = New System.Drawing.Size(200, 45)
        Me.VehicleTableBtn.TabIndex = 1
        Me.VehicleTableBtn.Text = "Vehicle Table"
        Me.VehicleTableBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'OverviewBtn
        '
        Me.OverviewBtn.Animated = True
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
        Me.OverviewBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.OverviewBtn.Location = New System.Drawing.Point(0, 225)
        Me.OverviewBtn.Name = "OverviewBtn"
        Me.OverviewBtn.PressedColor = System.Drawing.Color.White
        Me.OverviewBtn.ShadowDecoration.Parent = Me.OverviewBtn
        Me.OverviewBtn.Size = New System.Drawing.Size(200, 45)
        Me.OverviewBtn.TabIndex = 0
        Me.OverviewBtn.Text = "Overview"
        Me.OverviewBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'UserDashboardFinal2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(1154, 688)
        Me.Controls.Add(Me.DashboardPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserDashboardFinal2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.DashboardPanel.ResumeLayout(False)
        Me.DashboardPanel.PerformLayout()
        CType(Me.Guna2PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DashboardPanel As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ManageVehicleBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents AddVehicleBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents LogOutBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents VehicleTableBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents OverviewBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2TextBox1 As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
End Class
