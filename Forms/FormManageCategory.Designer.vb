<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormManageCategory
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
        Me.ParkingIDlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.VehicleCategorylbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PlateNumberlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimeInlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.TimeOutlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Statuslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Remarkslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DateInlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ParkingChargelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PaymentMethodlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Foundlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.TypeComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TypeComboBox = New System.Windows.Forms.ComboBox()
        Me.Guna2HtmlLabel6 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel5 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.UpdateCategoryBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2HtmlLabel4 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel3 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.VehiclecategorytblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParkingdbDataSet = New VPMSFinal.parkingdbDataSet()
        Me.ManageBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.NewCategoryBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Selectlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.VehiclecategorytblTableAdapter = New VPMSFinal.parkingdbDataSetTableAdapters.vehiclecategorytblTableAdapter()
        Me.TableAdapterManager = New VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager()
        Me.VehiclecategorytblBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Guna2HtmlLabel7 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.RemoveBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.VehiclecategorytblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.VehiclecategorytblBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1328, 660)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.RemoveBtn)
        Me.Guna2Panel1.Controls.Add(Me.ComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel7)
        Me.Guna2Panel1.Controls.Add(Me.TypeComboBox1)
        Me.Guna2Panel1.Controls.Add(Me.TypeComboBox)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel6)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel5)
        Me.Guna2Panel1.Controls.Add(Me.UpdateCategoryBox)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2HtmlLabel3)
        Me.Guna2Panel1.Controls.Add(Me.CategoryComboBox)
        Me.Guna2Panel1.Controls.Add(Me.ManageBtn)
        Me.Guna2Panel1.Controls.Add(Me.NewCategoryBox)
        Me.Guna2Panel1.Controls.Add(Me.AddBtn)
        Me.Guna2Panel1.Controls.Add(Me.Selectlbl)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(140, 26)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2Panel1.Size = New System.Drawing.Size(792, 592)
        Me.Guna2Panel1.TabIndex = 1
        '
        'TypeComboBox1
        '
        Me.TypeComboBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TypeComboBox1.FormattingEnabled = True
        Me.TypeComboBox1.Location = New System.Drawing.Point(251, 267)
        Me.TypeComboBox1.Name = "TypeComboBox1"
        Me.TypeComboBox1.Size = New System.Drawing.Size(473, 26)
        Me.TypeComboBox1.TabIndex = 21
        '
        'TypeComboBox
        '
        Me.TypeComboBox.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.TypeComboBox.FormattingEnabled = True
        Me.TypeComboBox.Location = New System.Drawing.Point(251, 68)
        Me.TypeComboBox.Name = "TypeComboBox"
        Me.TypeComboBox.Size = New System.Drawing.Size(473, 26)
        Me.TypeComboBox.TabIndex = 20
        '
        'Guna2HtmlLabel6
        '
        Me.Guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel6.Location = New System.Drawing.Point(23, 268)
        Me.Guna2HtmlLabel6.Name = "Guna2HtmlLabel6"
        Me.Guna2HtmlLabel6.Size = New System.Drawing.Size(96, 24)
        Me.Guna2HtmlLabel6.TabIndex = 19
        Me.Guna2HtmlLabel6.Text = "Select Type"
        '
        'Guna2HtmlLabel5
        '
        Me.Guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel5.Location = New System.Drawing.Point(23, 69)
        Me.Guna2HtmlLabel5.Name = "Guna2HtmlLabel5"
        Me.Guna2HtmlLabel5.Size = New System.Drawing.Size(96, 24)
        Me.Guna2HtmlLabel5.TabIndex = 17
        Me.Guna2HtmlLabel5.Text = "Select Type"
        '
        'UpdateCategoryBox
        '
        Me.UpdateCategoryBox.Animated = True
        Me.UpdateCategoryBox.BorderColor = System.Drawing.Color.Black
        Me.UpdateCategoryBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UpdateCategoryBox.DefaultText = ""
        Me.UpdateCategoryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UpdateCategoryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UpdateCategoryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UpdateCategoryBox.DisabledState.Parent = Me.UpdateCategoryBox
        Me.UpdateCategoryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UpdateCategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateCategoryBox.FocusedState.Parent = Me.UpdateCategoryBox
        Me.UpdateCategoryBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.UpdateCategoryBox.ForeColor = System.Drawing.Color.Black
        Me.UpdateCategoryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UpdateCategoryBox.HoverState.Parent = Me.UpdateCategoryBox
        Me.UpdateCategoryBox.Location = New System.Drawing.Point(251, 150)
        Me.UpdateCategoryBox.Name = "UpdateCategoryBox"
        Me.UpdateCategoryBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UpdateCategoryBox.PlaceholderText = "Update Category"
        Me.UpdateCategoryBox.SelectedText = ""
        Me.UpdateCategoryBox.ShadowDecoration.Parent = Me.UpdateCategoryBox
        Me.UpdateCategoryBox.Size = New System.Drawing.Size(473, 38)
        Me.UpdateCategoryBox.TabIndex = 16
        '
        'Guna2HtmlLabel4
        '
        Me.Guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel4.Location = New System.Drawing.Point(23, 157)
        Me.Guna2HtmlLabel4.Name = "Guna2HtmlLabel4"
        Me.Guna2HtmlLabel4.Size = New System.Drawing.Size(142, 24)
        Me.Guna2HtmlLabel4.TabIndex = 15
        Me.Guna2HtmlLabel4.Text = "Update Category"
        '
        'Guna2HtmlLabel3
        '
        Me.Guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel3.Location = New System.Drawing.Point(23, 334)
        Me.Guna2HtmlLabel3.Name = "Guna2HtmlLabel3"
        Me.Guna2HtmlLabel3.Size = New System.Drawing.Size(155, 24)
        Me.Guna2HtmlLabel3.TabIndex = 14
        Me.Guna2HtmlLabel3.Text = "Add New Category"
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclecategorytblBindingSource, "Category", True))
        Me.CategoryComboBox.DataSource = Me.VehiclecategorytblBindingSource
        Me.CategoryComboBox.DisplayMember = "Category"
        Me.CategoryComboBox.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.CategoryComboBox.ForeColor = System.Drawing.Color.Black
        Me.CategoryComboBox.ItemHeight = 18
        Me.CategoryComboBox.Location = New System.Drawing.Point(251, 112)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(473, 26)
        Me.CategoryComboBox.TabIndex = 13
        '
        'VehiclecategorytblBindingSource
        '
        Me.VehiclecategorytblBindingSource.DataMember = "vehiclecategorytbl"
        Me.VehiclecategorytblBindingSource.DataSource = Me.ParkingdbDataSet
        '
        'ParkingdbDataSet
        '
        Me.ParkingdbDataSet.DataSetName = "parkingdbDataSet"
        Me.ParkingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ManageBtn
        '
        Me.ManageBtn.Animated = True
        Me.ManageBtn.AutoRoundedCorners = True
        Me.ManageBtn.BackColor = System.Drawing.Color.Transparent
        Me.ManageBtn.BorderRadius = 21
        Me.ManageBtn.CheckedState.Parent = Me.ManageBtn
        Me.ManageBtn.CustomImages.Parent = Me.ManageBtn
        Me.ManageBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.ManageBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.ManageBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.ManageBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.ManageBtn.DisabledState.Parent = Me.ManageBtn
        Me.ManageBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.ManageBtn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ManageBtn.ForeColor = System.Drawing.Color.White
        Me.ManageBtn.HoverState.Parent = Me.ManageBtn
        Me.ManageBtn.Location = New System.Drawing.Point(317, 207)
        Me.ManageBtn.Name = "ManageBtn"
        Me.ManageBtn.ShadowDecoration.Parent = Me.ManageBtn
        Me.ManageBtn.Size = New System.Drawing.Size(95, 45)
        Me.ManageBtn.TabIndex = 12
        Me.ManageBtn.Text = "Update"
        Me.ManageBtn.UseTransparentBackground = True
        '
        'NewCategoryBox
        '
        Me.NewCategoryBox.Animated = True
        Me.NewCategoryBox.BorderColor = System.Drawing.Color.Black
        Me.NewCategoryBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.NewCategoryBox.DefaultText = ""
        Me.NewCategoryBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.NewCategoryBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.NewCategoryBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewCategoryBox.DisabledState.Parent = Me.NewCategoryBox
        Me.NewCategoryBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.NewCategoryBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewCategoryBox.FocusedState.Parent = Me.NewCategoryBox
        Me.NewCategoryBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NewCategoryBox.ForeColor = System.Drawing.Color.Black
        Me.NewCategoryBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.NewCategoryBox.HoverState.Parent = Me.NewCategoryBox
        Me.NewCategoryBox.Location = New System.Drawing.Point(251, 327)
        Me.NewCategoryBox.Name = "NewCategoryBox"
        Me.NewCategoryBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.NewCategoryBox.PlaceholderText = "New Category"
        Me.NewCategoryBox.SelectedText = ""
        Me.NewCategoryBox.ShadowDecoration.Parent = Me.NewCategoryBox
        Me.NewCategoryBox.Size = New System.Drawing.Size(473, 38)
        Me.NewCategoryBox.TabIndex = 11
        '
        'AddBtn
        '
        Me.AddBtn.Animated = True
        Me.AddBtn.AutoRoundedCorners = True
        Me.AddBtn.BackColor = System.Drawing.Color.Transparent
        Me.AddBtn.BorderRadius = 21
        Me.AddBtn.CheckedState.Parent = Me.AddBtn
        Me.AddBtn.CustomImages.Parent = Me.AddBtn
        Me.AddBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.AddBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.AddBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.AddBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.AddBtn.DisabledState.Parent = Me.AddBtn
        Me.AddBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.AddBtn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.HoverState.Parent = Me.AddBtn
        Me.AddBtn.Location = New System.Drawing.Point(330, 382)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(69, 45)
        Me.AddBtn.TabIndex = 10
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseTransparentBackground = True
        '
        'Selectlbl
        '
        Me.Selectlbl.BackColor = System.Drawing.Color.Transparent
        Me.Selectlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selectlbl.Location = New System.Drawing.Point(23, 113)
        Me.Selectlbl.Name = "Selectlbl"
        Me.Selectlbl.Size = New System.Drawing.Size(131, 24)
        Me.Selectlbl.TabIndex = 2
        Me.Selectlbl.Text = "Select Category"
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(792, 51)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(95, 13)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(140, 24)
        Me.Guna2HtmlLabel2.TabIndex = 15
        Me.Guna2HtmlLabel2.Text = "Vehicle Category"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(23, 13)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(70, 24)
        Me.Guna2HtmlLabel1.TabIndex = 14
        Me.Guna2HtmlLabel1.Text = "Manage"
        '
        'VehiclecategorytblTableAdapter
        '
        Me.VehiclecategorytblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminrecordtblTableAdapter = Nothing
        Me.TableAdapterManager.admintblTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usertblTableAdapter = Nothing
        Me.TableAdapterManager.vehiclecategorytblTableAdapter = Me.VehiclecategorytblTableAdapter
        Me.TableAdapterManager.vehicletblTableAdapter = Nothing
        '
        'VehiclecategorytblBindingSource1
        '
        Me.VehiclecategorytblBindingSource1.DataMember = "vehiclecategorytbl"
        Me.VehiclecategorytblBindingSource1.DataSource = Me.ParkingdbDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VehiclecategorytblBindingSource, "Category", True))
        Me.ComboBox1.DataSource = Me.VehiclecategorytblBindingSource
        Me.ComboBox1.DisplayMember = "Category"
        Me.ComboBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.ItemHeight = 18
        Me.ComboBox1.Location = New System.Drawing.Point(251, 468)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(473, 26)
        Me.ComboBox1.TabIndex = 23
        '
        'Guna2HtmlLabel7
        '
        Me.Guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel7.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel7.Location = New System.Drawing.Point(23, 469)
        Me.Guna2HtmlLabel7.Name = "Guna2HtmlLabel7"
        Me.Guna2HtmlLabel7.Size = New System.Drawing.Size(131, 24)
        Me.Guna2HtmlLabel7.TabIndex = 22
        Me.Guna2HtmlLabel7.Text = "Select Category"
        '
        'RemoveBtn
        '
        Me.RemoveBtn.Animated = True
        Me.RemoveBtn.AutoRoundedCorners = True
        Me.RemoveBtn.BackColor = System.Drawing.Color.Transparent
        Me.RemoveBtn.BorderRadius = 21
        Me.RemoveBtn.CheckedState.Parent = Me.RemoveBtn
        Me.RemoveBtn.CustomImages.Parent = Me.RemoveBtn
        Me.RemoveBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RemoveBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RemoveBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RemoveBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RemoveBtn.DisabledState.Parent = Me.RemoveBtn
        Me.RemoveBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.RemoveBtn.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold)
        Me.RemoveBtn.ForeColor = System.Drawing.Color.White
        Me.RemoveBtn.HoverState.Parent = Me.RemoveBtn
        Me.RemoveBtn.Location = New System.Drawing.Point(314, 516)
        Me.RemoveBtn.Name = "RemoveBtn"
        Me.RemoveBtn.ShadowDecoration.Parent = Me.RemoveBtn
        Me.RemoveBtn.Size = New System.Drawing.Size(100, 45)
        Me.RemoveBtn.TabIndex = 24
        Me.RemoveBtn.Text = "Remove"
        Me.RemoveBtn.UseTransparentBackground = True
        '
        'FormManageCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1328, 660)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "FormManageCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormManageCategory"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.VehiclecategorytblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.VehiclecategorytblBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ParkingIDlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents VehicleCategorylbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PlateNumberlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimeInlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents TimeOutlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Statuslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Remarkslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DateInlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ParkingChargelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PaymentMethodlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Foundlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents NewCategoryBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Selectlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents ManageBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ParkingdbDataSet As parkingdbDataSet
    Friend WithEvents VehiclecategorytblBindingSource As BindingSource
    Friend WithEvents VehiclecategorytblTableAdapter As parkingdbDataSetTableAdapters.vehiclecategorytblTableAdapter
    Friend WithEvents TableAdapterManager As parkingdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents UpdateCategoryBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel4 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents VehiclecategorytblBindingSource1 As BindingSource
    Friend WithEvents TypeComboBox1 As ComboBox
    Friend WithEvents TypeComboBox As ComboBox
    Friend WithEvents RemoveBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Guna2HtmlLabel7 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
