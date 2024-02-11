<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageVehicle
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.minus = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Remarksbox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Foundlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UpdateBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.PaymentMethodBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ParkingChargeBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.StatusBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TimeOutBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.TimeInBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.DateInBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PlateNumberBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VehicleCategoryBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ParkingIDBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PaymentMethodlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ParkingChargelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DateInlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Remarkslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Statuslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimeOutlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimeInlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PlateNumberlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.VehicleCategorylbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ParkingIDlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.VehicleTable = New System.Windows.Forms.DataGridView()
        Me.ParkingIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PlateNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimeOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ParkingChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentMethodDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemarksDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicletblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParkingdbDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParkingdbDataSet = New VPMSFinal.parkingdbDataSet()
        Me.SearchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.VehicletblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VehicletblTableAdapter = New VPMSFinal.parkingdbDataSetTableAdapters.vehicletblTableAdapter()
        Me.TableAdapterManager = New VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.VehicleTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicletblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkingdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehicletblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel3)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.SearchBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.SearchBox)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1168, 1041)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 974)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(1168, 67)
        Me.Guna2Panel3.TabIndex = 4
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Remarksbox)
        Me.Guna2Panel1.Controls.Add(Me.Foundlbl)
        Me.Guna2Panel1.Controls.Add(Me.UpdateBtn)
        Me.Guna2Panel1.Controls.Add(Me.PaymentMethodBox)
        Me.Guna2Panel1.Controls.Add(Me.ParkingChargeBox)
        Me.Guna2Panel1.Controls.Add(Me.StatusBox)
        Me.Guna2Panel1.Controls.Add(Me.TimeOutBox)
        Me.Guna2Panel1.Controls.Add(Me.TimeInBox)
        Me.Guna2Panel1.Controls.Add(Me.DateInBox)
        Me.Guna2Panel1.Controls.Add(Me.PlateNumberBox)
        Me.Guna2Panel1.Controls.Add(Me.VehicleCategoryBox)
        Me.Guna2Panel1.Controls.Add(Me.ParkingIDBox)
        Me.Guna2Panel1.Controls.Add(Me.PaymentMethodlbl)
        Me.Guna2Panel1.Controls.Add(Me.ParkingChargelbl)
        Me.Guna2Panel1.Controls.Add(Me.DateInlbl)
        Me.Guna2Panel1.Controls.Add(Me.Remarkslbl)
        Me.Guna2Panel1.Controls.Add(Me.Statuslbl)
        Me.Guna2Panel1.Controls.Add(Me.TimeOutlbl)
        Me.Guna2Panel1.Controls.Add(Me.TimeInlbl)
        Me.Guna2Panel1.Controls.Add(Me.PlateNumberlbl)
        Me.Guna2Panel1.Controls.Add(Me.VehicleCategorylbl)
        Me.Guna2Panel1.Controls.Add(Me.ParkingIDlbl)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.Controls.Add(Me.VehicleTable)
        Me.Guna2Panel1.Controls.Add(Me.minus)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(224, 91)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2Panel1.Size = New System.Drawing.Size(751, 877)
        Me.Guna2Panel1.TabIndex = 3
        '
        'minus
        '
        Me.minus.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.minus.DefaultText = ""
        Me.minus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.minus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.minus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.minus.DisabledState.Parent = Me.minus
        Me.minus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.minus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minus.FocusedState.Parent = Me.minus
        Me.minus.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.minus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.minus.HoverState.Parent = Me.minus
        Me.minus.Location = New System.Drawing.Point(378, 783)
        Me.minus.Name = "minus"
        Me.minus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.minus.PlaceholderText = ""
        Me.minus.SelectedText = ""
        Me.minus.ShadowDecoration.Parent = Me.minus
        Me.minus.Size = New System.Drawing.Size(10, 10)
        Me.minus.TabIndex = 34
        '
        'Remarksbox
        '
        Me.Remarksbox.Animated = True
        Me.Remarksbox.BorderColor = System.Drawing.Color.Black
        Me.Remarksbox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Remarksbox.DefaultText = ""
        Me.Remarksbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.Remarksbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.Remarksbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Remarksbox.DisabledState.Parent = Me.Remarksbox
        Me.Remarksbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.Remarksbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Remarksbox.FocusedState.Parent = Me.Remarksbox
        Me.Remarksbox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Remarksbox.ForeColor = System.Drawing.Color.Black
        Me.Remarksbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Remarksbox.HoverState.Parent = Me.Remarksbox
        Me.Remarksbox.Location = New System.Drawing.Point(258, 629)
        Me.Remarksbox.Name = "Remarksbox"
        Me.Remarksbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.Remarksbox.PlaceholderText = "Remarks"
        Me.Remarksbox.SelectedText = ""
        Me.Remarksbox.ShadowDecoration.Parent = Me.Remarksbox
        Me.Remarksbox.Size = New System.Drawing.Size(473, 37)
        Me.Remarksbox.TabIndex = 33
        '
        'Foundlbl
        '
        Me.Foundlbl.BackColor = System.Drawing.Color.Transparent
        Me.Foundlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Foundlbl.ForeColor = System.Drawing.Color.ForestGreen
        Me.Foundlbl.IsSelectionEnabled = False
        Me.Foundlbl.Location = New System.Drawing.Point(258, 72)
        Me.Foundlbl.Name = "Foundlbl"
        Me.Foundlbl.Size = New System.Drawing.Size(3, 2)
        Me.Foundlbl.TabIndex = 2
        Me.Foundlbl.Text = Nothing
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Animated = True
        Me.UpdateBtn.AutoRoundedCorners = True
        Me.UpdateBtn.BackColor = System.Drawing.Color.Transparent
        Me.UpdateBtn.BorderRadius = 21
        Me.UpdateBtn.CheckedState.Parent = Me.UpdateBtn
        Me.UpdateBtn.CustomImages.Parent = Me.UpdateBtn
        Me.UpdateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.UpdateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.UpdateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.UpdateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.UpdateBtn.DisabledState.Parent = Me.UpdateBtn
        Me.UpdateBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.UpdateBtn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.UpdateBtn.ForeColor = System.Drawing.Color.White
        Me.UpdateBtn.HoverState.Parent = Me.UpdateBtn
        Me.UpdateBtn.Location = New System.Drawing.Point(335, 766)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.ShadowDecoration.Parent = Me.UpdateBtn
        Me.UpdateBtn.Size = New System.Drawing.Size(95, 45)
        Me.UpdateBtn.TabIndex = 32
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseTransparentBackground = True
        '
        'PaymentMethodBox
        '
        Me.PaymentMethodBox.Animated = True
        Me.PaymentMethodBox.BorderColor = System.Drawing.Color.Black
        Me.PaymentMethodBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PaymentMethodBox.DefaultText = ""
        Me.PaymentMethodBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PaymentMethodBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PaymentMethodBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PaymentMethodBox.DisabledState.Parent = Me.PaymentMethodBox
        Me.PaymentMethodBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PaymentMethodBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentMethodBox.FocusedState.Parent = Me.PaymentMethodBox
        Me.PaymentMethodBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PaymentMethodBox.ForeColor = System.Drawing.Color.Black
        Me.PaymentMethodBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PaymentMethodBox.HoverState.Parent = Me.PaymentMethodBox
        Me.PaymentMethodBox.Location = New System.Drawing.Point(258, 577)
        Me.PaymentMethodBox.Name = "PaymentMethodBox"
        Me.PaymentMethodBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PaymentMethodBox.PlaceholderText = "Payment Method"
        Me.PaymentMethodBox.SelectedText = ""
        Me.PaymentMethodBox.ShadowDecoration.Parent = Me.PaymentMethodBox
        Me.PaymentMethodBox.Size = New System.Drawing.Size(473, 37)
        Me.PaymentMethodBox.TabIndex = 31
        '
        'ParkingChargeBox
        '
        Me.ParkingChargeBox.Animated = True
        Me.ParkingChargeBox.BorderColor = System.Drawing.Color.Black
        Me.ParkingChargeBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ParkingChargeBox.DefaultText = ""
        Me.ParkingChargeBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ParkingChargeBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ParkingChargeBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ParkingChargeBox.DisabledState.Parent = Me.ParkingChargeBox
        Me.ParkingChargeBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ParkingChargeBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParkingChargeBox.FocusedState.Parent = Me.ParkingChargeBox
        Me.ParkingChargeBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ParkingChargeBox.ForeColor = System.Drawing.Color.Black
        Me.ParkingChargeBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParkingChargeBox.HoverState.Parent = Me.ParkingChargeBox
        Me.ParkingChargeBox.Location = New System.Drawing.Point(258, 519)
        Me.ParkingChargeBox.Name = "ParkingChargeBox"
        Me.ParkingChargeBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ParkingChargeBox.PlaceholderText = "Parking Charge"
        Me.ParkingChargeBox.SelectedText = ""
        Me.ParkingChargeBox.ShadowDecoration.Parent = Me.ParkingChargeBox
        Me.ParkingChargeBox.Size = New System.Drawing.Size(473, 37)
        Me.ParkingChargeBox.TabIndex = 30
        '
        'StatusBox
        '
        Me.StatusBox.Animated = True
        Me.StatusBox.BorderColor = System.Drawing.Color.Black
        Me.StatusBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StatusBox.DefaultText = ""
        Me.StatusBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.StatusBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.StatusBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StatusBox.DisabledState.Parent = Me.StatusBox
        Me.StatusBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.StatusBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusBox.FocusedState.Parent = Me.StatusBox
        Me.StatusBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusBox.ForeColor = System.Drawing.Color.Black
        Me.StatusBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusBox.HoverState.Parent = Me.StatusBox
        Me.StatusBox.Location = New System.Drawing.Point(258, 461)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StatusBox.PlaceholderText = "Status"
        Me.StatusBox.SelectedText = ""
        Me.StatusBox.ShadowDecoration.Parent = Me.StatusBox
        Me.StatusBox.Size = New System.Drawing.Size(473, 37)
        Me.StatusBox.TabIndex = 29
        '
        'TimeOutBox
        '
        Me.TimeOutBox.Animated = True
        Me.TimeOutBox.BorderColor = System.Drawing.Color.Black
        Me.TimeOutBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TimeOutBox.DefaultText = ""
        Me.TimeOutBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TimeOutBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TimeOutBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TimeOutBox.DisabledState.Parent = Me.TimeOutBox
        Me.TimeOutBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TimeOutBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeOutBox.FocusedState.Parent = Me.TimeOutBox
        Me.TimeOutBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TimeOutBox.ForeColor = System.Drawing.Color.Black
        Me.TimeOutBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeOutBox.HoverState.Parent = Me.TimeOutBox
        Me.TimeOutBox.Location = New System.Drawing.Point(258, 403)
        Me.TimeOutBox.Name = "TimeOutBox"
        Me.TimeOutBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TimeOutBox.PlaceholderText = "Time Out"
        Me.TimeOutBox.SelectedText = ""
        Me.TimeOutBox.ShadowDecoration.Parent = Me.TimeOutBox
        Me.TimeOutBox.Size = New System.Drawing.Size(473, 37)
        Me.TimeOutBox.TabIndex = 28
        '
        'TimeInBox
        '
        Me.TimeInBox.Animated = True
        Me.TimeInBox.BorderColor = System.Drawing.Color.Black
        Me.TimeInBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TimeInBox.DefaultText = ""
        Me.TimeInBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TimeInBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TimeInBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TimeInBox.DisabledState.Parent = Me.TimeInBox
        Me.TimeInBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TimeInBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeInBox.FocusedState.Parent = Me.TimeInBox
        Me.TimeInBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TimeInBox.ForeColor = System.Drawing.Color.Black
        Me.TimeInBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TimeInBox.HoverState.Parent = Me.TimeInBox
        Me.TimeInBox.Location = New System.Drawing.Point(258, 345)
        Me.TimeInBox.Name = "TimeInBox"
        Me.TimeInBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TimeInBox.PlaceholderText = "Time In"
        Me.TimeInBox.SelectedText = ""
        Me.TimeInBox.ShadowDecoration.Parent = Me.TimeInBox
        Me.TimeInBox.Size = New System.Drawing.Size(473, 37)
        Me.TimeInBox.TabIndex = 27
        '
        'DateInBox
        '
        Me.DateInBox.Animated = True
        Me.DateInBox.BorderColor = System.Drawing.Color.Black
        Me.DateInBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.DateInBox.DefaultText = ""
        Me.DateInBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.DateInBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.DateInBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DateInBox.DisabledState.Parent = Me.DateInBox
        Me.DateInBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.DateInBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateInBox.FocusedState.Parent = Me.DateInBox
        Me.DateInBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DateInBox.ForeColor = System.Drawing.Color.Black
        Me.DateInBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DateInBox.HoverState.Parent = Me.DateInBox
        Me.DateInBox.Location = New System.Drawing.Point(258, 287)
        Me.DateInBox.Name = "DateInBox"
        Me.DateInBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.DateInBox.PlaceholderText = "Date In"
        Me.DateInBox.SelectedText = ""
        Me.DateInBox.ShadowDecoration.Parent = Me.DateInBox
        Me.DateInBox.Size = New System.Drawing.Size(473, 37)
        Me.DateInBox.TabIndex = 26
        '
        'PlateNumberBox
        '
        Me.PlateNumberBox.Animated = True
        Me.PlateNumberBox.BorderColor = System.Drawing.Color.Black
        Me.PlateNumberBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PlateNumberBox.DefaultText = ""
        Me.PlateNumberBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PlateNumberBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PlateNumberBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PlateNumberBox.DisabledState.Parent = Me.PlateNumberBox
        Me.PlateNumberBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PlateNumberBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlateNumberBox.FocusedState.Parent = Me.PlateNumberBox
        Me.PlateNumberBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.PlateNumberBox.ForeColor = System.Drawing.Color.Black
        Me.PlateNumberBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PlateNumberBox.HoverState.Parent = Me.PlateNumberBox
        Me.PlateNumberBox.Location = New System.Drawing.Point(258, 229)
        Me.PlateNumberBox.Name = "PlateNumberBox"
        Me.PlateNumberBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PlateNumberBox.PlaceholderText = "Plate Number"
        Me.PlateNumberBox.SelectedText = ""
        Me.PlateNumberBox.ShadowDecoration.Parent = Me.PlateNumberBox
        Me.PlateNumberBox.Size = New System.Drawing.Size(473, 37)
        Me.PlateNumberBox.TabIndex = 25
        '
        'VehicleCategoryBox
        '
        Me.VehicleCategoryBox.Animated = True
        Me.VehicleCategoryBox.BorderColor = System.Drawing.Color.Black
        Me.VehicleCategoryBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.VehicleCategoryBox.DefaultText = ""
        Me.VehicleCategoryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.VehicleCategoryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.VehicleCategoryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VehicleCategoryBox.DisabledState.Parent = Me.VehicleCategoryBox
        Me.VehicleCategoryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.VehicleCategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VehicleCategoryBox.FocusedState.Parent = Me.VehicleCategoryBox
        Me.VehicleCategoryBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VehicleCategoryBox.ForeColor = System.Drawing.Color.Black
        Me.VehicleCategoryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.VehicleCategoryBox.HoverState.Parent = Me.VehicleCategoryBox
        Me.VehicleCategoryBox.Location = New System.Drawing.Point(258, 171)
        Me.VehicleCategoryBox.Name = "VehicleCategoryBox"
        Me.VehicleCategoryBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.VehicleCategoryBox.PlaceholderText = "Vehicle Category"
        Me.VehicleCategoryBox.SelectedText = ""
        Me.VehicleCategoryBox.ShadowDecoration.Parent = Me.VehicleCategoryBox
        Me.VehicleCategoryBox.Size = New System.Drawing.Size(473, 37)
        Me.VehicleCategoryBox.TabIndex = 24
        '
        'ParkingIDBox
        '
        Me.ParkingIDBox.Animated = True
        Me.ParkingIDBox.BorderColor = System.Drawing.Color.Black
        Me.ParkingIDBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ParkingIDBox.DefaultText = ""
        Me.ParkingIDBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.ParkingIDBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.ParkingIDBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ParkingIDBox.DisabledState.Parent = Me.ParkingIDBox
        Me.ParkingIDBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.ParkingIDBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParkingIDBox.FocusedState.Parent = Me.ParkingIDBox
        Me.ParkingIDBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ParkingIDBox.ForeColor = System.Drawing.Color.Black
        Me.ParkingIDBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ParkingIDBox.HoverState.Parent = Me.ParkingIDBox
        Me.ParkingIDBox.Location = New System.Drawing.Point(258, 113)
        Me.ParkingIDBox.Name = "ParkingIDBox"
        Me.ParkingIDBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.ParkingIDBox.PlaceholderText = "Parking ID"
        Me.ParkingIDBox.SelectedText = ""
        Me.ParkingIDBox.ShadowDecoration.Parent = Me.ParkingIDBox
        Me.ParkingIDBox.Size = New System.Drawing.Size(473, 37)
        Me.ParkingIDBox.TabIndex = 23
        '
        'PaymentMethodlbl
        '
        Me.PaymentMethodlbl.BackColor = System.Drawing.Color.Transparent
        Me.PaymentMethodlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PaymentMethodlbl.Location = New System.Drawing.Point(14, 577)
        Me.PaymentMethodlbl.Name = "PaymentMethodlbl"
        Me.PaymentMethodlbl.Size = New System.Drawing.Size(145, 24)
        Me.PaymentMethodlbl.TabIndex = 22
        Me.PaymentMethodlbl.Text = "Payment Method"
        '
        'ParkingChargelbl
        '
        Me.ParkingChargelbl.BackColor = System.Drawing.Color.Transparent
        Me.ParkingChargelbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParkingChargelbl.Location = New System.Drawing.Point(14, 519)
        Me.ParkingChargelbl.Name = "ParkingChargelbl"
        Me.ParkingChargelbl.Size = New System.Drawing.Size(128, 24)
        Me.ParkingChargelbl.TabIndex = 21
        Me.ParkingChargelbl.Text = "Parking Charge"
        '
        'DateInlbl
        '
        Me.DateInlbl.BackColor = System.Drawing.Color.Transparent
        Me.DateInlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInlbl.Location = New System.Drawing.Point(14, 287)
        Me.DateInlbl.Name = "DateInlbl"
        Me.DateInlbl.Size = New System.Drawing.Size(62, 24)
        Me.DateInlbl.TabIndex = 10
        Me.DateInlbl.Text = "Date In"
        Me.DateInlbl.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Remarkslbl
        '
        Me.Remarkslbl.BackColor = System.Drawing.Color.Transparent
        Me.Remarkslbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarkslbl.Location = New System.Drawing.Point(17, 635)
        Me.Remarkslbl.Name = "Remarkslbl"
        Me.Remarkslbl.Size = New System.Drawing.Size(75, 24)
        Me.Remarkslbl.TabIndex = 9
        Me.Remarkslbl.Text = "Remarks"
        '
        'Statuslbl
        '
        Me.Statuslbl.BackColor = System.Drawing.Color.Transparent
        Me.Statuslbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslbl.Location = New System.Drawing.Point(14, 461)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(55, 24)
        Me.Statuslbl.TabIndex = 8
        Me.Statuslbl.Text = "Status"
        '
        'TimeOutlbl
        '
        Me.TimeOutlbl.BackColor = System.Drawing.Color.Transparent
        Me.TimeOutlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeOutlbl.Location = New System.Drawing.Point(14, 403)
        Me.TimeOutlbl.Name = "TimeOutlbl"
        Me.TimeOutlbl.Size = New System.Drawing.Size(78, 24)
        Me.TimeOutlbl.TabIndex = 7
        Me.TimeOutlbl.Text = "Time Out"
        '
        'TimeInlbl
        '
        Me.TimeInlbl.BackColor = System.Drawing.Color.Transparent
        Me.TimeInlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TimeInlbl.Location = New System.Drawing.Point(14, 345)
        Me.TimeInlbl.Name = "TimeInlbl"
        Me.TimeInlbl.Size = New System.Drawing.Size(63, 24)
        Me.TimeInlbl.TabIndex = 6
        Me.TimeInlbl.Text = "Time In"
        '
        'PlateNumberlbl
        '
        Me.PlateNumberlbl.BackColor = System.Drawing.Color.Transparent
        Me.PlateNumberlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNumberlbl.Location = New System.Drawing.Point(14, 229)
        Me.PlateNumberlbl.Name = "PlateNumberlbl"
        Me.PlateNumberlbl.Size = New System.Drawing.Size(116, 24)
        Me.PlateNumberlbl.TabIndex = 5
        Me.PlateNumberlbl.Text = "Plate Number"
        '
        'VehicleCategorylbl
        '
        Me.VehicleCategorylbl.BackColor = System.Drawing.Color.Transparent
        Me.VehicleCategorylbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VehicleCategorylbl.Location = New System.Drawing.Point(14, 171)
        Me.VehicleCategorylbl.Name = "VehicleCategorylbl"
        Me.VehicleCategorylbl.Size = New System.Drawing.Size(140, 24)
        Me.VehicleCategorylbl.TabIndex = 4
        Me.VehicleCategorylbl.Text = "Vehicle Category"
        '
        'ParkingIDlbl
        '
        Me.ParkingIDlbl.BackColor = System.Drawing.Color.Transparent
        Me.ParkingIDlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParkingIDlbl.Location = New System.Drawing.Point(14, 113)
        Me.ParkingIDlbl.Name = "ParkingIDlbl"
        Me.ParkingIDlbl.Size = New System.Drawing.Size(87, 24)
        Me.ParkingIDlbl.TabIndex = 3
        Me.ParkingIDlbl.Text = "Parking ID"
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel2.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel2.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel2.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.Size = New System.Drawing.Size(751, 51)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(87, 13)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(62, 24)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Vehicle"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 13)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(70, 24)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Manage"
        '
        'VehicleTable
        '
        Me.VehicleTable.AllowUserToAddRows = False
        Me.VehicleTable.AllowUserToDeleteRows = False
        Me.VehicleTable.AutoGenerateColumns = False
        Me.VehicleTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehicleTable.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ParkingIDDataGridViewTextBoxColumn, Me.VehicleCategoryDataGridViewTextBoxColumn, Me.PlateNumDataGridViewTextBoxColumn, Me.DateInDataGridViewTextBoxColumn, Me.TimeInDataGridViewTextBoxColumn, Me.TimeOutDataGridViewTextBoxColumn, Me.VehicleStatusDataGridViewTextBoxColumn, Me.ParkingChargeDataGridViewTextBoxColumn, Me.PaymentMethodDataGridViewTextBoxColumn, Me.RemarksDataGridViewTextBoxColumn})
        Me.VehicleTable.DataSource = Me.VehicletblBindingSource1
        Me.VehicleTable.Enabled = False
        Me.VehicleTable.Location = New System.Drawing.Point(378, 783)
        Me.VehicleTable.Name = "VehicleTable"
        Me.VehicleTable.ReadOnly = True
        Me.VehicleTable.Size = New System.Drawing.Size(10, 10)
        Me.VehicleTable.TabIndex = 32
        '
        'ParkingIDDataGridViewTextBoxColumn
        '
        Me.ParkingIDDataGridViewTextBoxColumn.DataPropertyName = "ParkingID"
        Me.ParkingIDDataGridViewTextBoxColumn.HeaderText = "ParkingID"
        Me.ParkingIDDataGridViewTextBoxColumn.Name = "ParkingIDDataGridViewTextBoxColumn"
        Me.ParkingIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleCategoryDataGridViewTextBoxColumn
        '
        Me.VehicleCategoryDataGridViewTextBoxColumn.DataPropertyName = "VehicleCategory"
        Me.VehicleCategoryDataGridViewTextBoxColumn.HeaderText = "VehicleCategory"
        Me.VehicleCategoryDataGridViewTextBoxColumn.Name = "VehicleCategoryDataGridViewTextBoxColumn"
        Me.VehicleCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PlateNumDataGridViewTextBoxColumn
        '
        Me.PlateNumDataGridViewTextBoxColumn.DataPropertyName = "PlateNum"
        Me.PlateNumDataGridViewTextBoxColumn.HeaderText = "PlateNum"
        Me.PlateNumDataGridViewTextBoxColumn.Name = "PlateNumDataGridViewTextBoxColumn"
        Me.PlateNumDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateInDataGridViewTextBoxColumn
        '
        Me.DateInDataGridViewTextBoxColumn.DataPropertyName = "DateIn"
        Me.DateInDataGridViewTextBoxColumn.HeaderText = "DateIn"
        Me.DateInDataGridViewTextBoxColumn.Name = "DateInDataGridViewTextBoxColumn"
        Me.DateInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeInDataGridViewTextBoxColumn
        '
        Me.TimeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.HeaderText = "TimeIn"
        Me.TimeInDataGridViewTextBoxColumn.Name = "TimeInDataGridViewTextBoxColumn"
        Me.TimeInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimeOutDataGridViewTextBoxColumn
        '
        Me.TimeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut"
        Me.TimeOutDataGridViewTextBoxColumn.Name = "TimeOutDataGridViewTextBoxColumn"
        Me.TimeOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicleStatusDataGridViewTextBoxColumn
        '
        Me.VehicleStatusDataGridViewTextBoxColumn.DataPropertyName = "VehicleStatus"
        Me.VehicleStatusDataGridViewTextBoxColumn.HeaderText = "VehicleStatus"
        Me.VehicleStatusDataGridViewTextBoxColumn.Name = "VehicleStatusDataGridViewTextBoxColumn"
        Me.VehicleStatusDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ParkingChargeDataGridViewTextBoxColumn
        '
        Me.ParkingChargeDataGridViewTextBoxColumn.DataPropertyName = "ParkingCharge"
        Me.ParkingChargeDataGridViewTextBoxColumn.HeaderText = "ParkingCharge"
        Me.ParkingChargeDataGridViewTextBoxColumn.Name = "ParkingChargeDataGridViewTextBoxColumn"
        Me.ParkingChargeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PaymentMethodDataGridViewTextBoxColumn
        '
        Me.PaymentMethodDataGridViewTextBoxColumn.DataPropertyName = "PaymentMethod"
        Me.PaymentMethodDataGridViewTextBoxColumn.HeaderText = "PaymentMethod"
        Me.PaymentMethodDataGridViewTextBoxColumn.Name = "PaymentMethodDataGridViewTextBoxColumn"
        Me.PaymentMethodDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemarksDataGridViewTextBoxColumn
        '
        Me.RemarksDataGridViewTextBoxColumn.DataPropertyName = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.HeaderText = "Remarks"
        Me.RemarksDataGridViewTextBoxColumn.Name = "RemarksDataGridViewTextBoxColumn"
        Me.RemarksDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VehicletblBindingSource1
        '
        Me.VehicletblBindingSource1.DataMember = "vehicletbl"
        Me.VehicletblBindingSource1.DataSource = Me.ParkingdbDataSetBindingSource
        '
        'ParkingdbDataSetBindingSource
        '
        Me.ParkingdbDataSetBindingSource.DataSource = Me.ParkingdbDataSet
        Me.ParkingdbDataSetBindingSource.Position = 0
        '
        'ParkingdbDataSet
        '
        Me.ParkingdbDataSet.DataSetName = "parkingdbDataSet"
        Me.ParkingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchBtn
        '
        Me.SearchBtn.Animated = True
        Me.SearchBtn.AutoRoundedCorners = True
        Me.SearchBtn.BackColor = System.Drawing.Color.Transparent
        Me.SearchBtn.BorderRadius = 14
        Me.SearchBtn.CheckedState.Parent = Me.SearchBtn
        Me.SearchBtn.CustomImages.Parent = Me.SearchBtn
        Me.SearchBtn.CustomizableEdges.BottomRight = False
        Me.SearchBtn.CustomizableEdges.TopRight = False
        Me.SearchBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.SearchBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.SearchBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.SearchBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.SearchBtn.DisabledState.Parent = Me.SearchBtn
        Me.SearchBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.SearchBtn.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.HoverState.Parent = Me.SearchBtn
        Me.SearchBtn.Location = New System.Drawing.Point(224, 31)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.ShadowDecoration.Parent = Me.SearchBtn
        Me.SearchBtn.Size = New System.Drawing.Size(76, 30)
        Me.SearchBtn.TabIndex = 2
        Me.SearchBtn.Text = "Search"
        '
        'SearchBox
        '
        Me.SearchBox.Animated = True
        Me.SearchBox.AutoRoundedCorners = True
        Me.SearchBox.BackColor = System.Drawing.Color.Transparent
        Me.SearchBox.BorderColor = System.Drawing.Color.White
        Me.SearchBox.BorderRadius = 14
        Me.SearchBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SearchBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.SearchBox.CustomizableEdges.BottomLeft = False
        Me.SearchBox.CustomizableEdges.TopLeft = False
        Me.SearchBox.DefaultText = ""
        Me.SearchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.SearchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.SearchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBox.DisabledState.Parent = Me.SearchBox
        Me.SearchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.SearchBox.FillColor = System.Drawing.Color.WhiteSmoke
        Me.SearchBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.FocusedState.Parent = Me.SearchBox
        Me.SearchBox.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.ForeColor = System.Drawing.Color.Black
        Me.SearchBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SearchBox.HoverState.Parent = Me.SearchBox
        Me.SearchBox.Location = New System.Drawing.Point(307, 31)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBox.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.SearchBox.PlaceholderText = "PLATE NUMBER OR PARKING ID"
        Me.SearchBox.SelectedText = ""
        Me.SearchBox.ShadowDecoration.Parent = Me.SearchBox
        Me.SearchBox.Size = New System.Drawing.Size(257, 30)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.TextOffset = New System.Drawing.Point(10, 0)
        '
        'VehicletblBindingSource
        '
        Me.VehicletblBindingSource.DataMember = "vehicletbl"
        Me.VehicletblBindingSource.DataSource = Me.ParkingdbDataSet
        '
        'VehicletblTableAdapter
        '
        Me.VehicletblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminrecordtblTableAdapter = Nothing
        Me.TableAdapterManager.admintblTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usertblTableAdapter = Nothing
        Me.TableAdapterManager.vehiclecategorytblTableAdapter = Nothing
        Me.TableAdapterManager.vehicletblTableAdapter = Me.VehicletblTableAdapter
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'FormManageVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1168, 1041)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(1920, 1080)
        Me.Name = "FormManageVehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manage Vehicle"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.VehicleTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicletblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkingdbDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehicletblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents SearchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents VehicleCategorylbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ParkingIDlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PlateNumberlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimeOutlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimeInlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Statuslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Remarkslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DateInlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ParkingChargelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PaymentMethodlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ParkingIDBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents VehicleCategoryBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TimeOutBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TimeInBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents DateInBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PlateNumberBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PaymentMethodBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ParkingChargeBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StatusBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UpdateBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Foundlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ParkingdbDataSet As parkingdbDataSet
    Friend WithEvents VehicletblBindingSource As BindingSource
    Friend WithEvents VehicletblTableAdapter As parkingdbDataSetTableAdapters.vehicletblTableAdapter
    Friend WithEvents TableAdapterManager As parkingdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehicleTable As DataGridView
    Friend WithEvents ParkingIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PlateNumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeInDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimeOutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicleStatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ParkingChargeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PaymentMethodDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RemarksDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VehicletblBindingSource1 As BindingSource
    Friend WithEvents ParkingdbDataSetBindingSource As BindingSource
    Friend WithEvents Remarksbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents minus As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
End Class
