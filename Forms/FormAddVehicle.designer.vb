<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAddVehicle
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
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.VehiclecategorytblComboBox = New System.Windows.Forms.ComboBox()
        Me.VehiclecategorytblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParkingdbDataSet = New VPMSFinal.parkingdbDataSet()
        Me.PlateNumberBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.StatusBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Remarkslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.RemarksBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Statuslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.PlateNumberlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Selectlbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.VehiclecategorytblTableAdapter = New VPMSFinal.parkingdbDataSetTableAdapters.vehiclecategorytblTableAdapter()
        Me.TableAdapterManager = New VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.VehiclecategorytblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1201, 685)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.VehiclecategorytblComboBox)
        Me.Guna2Panel1.Controls.Add(Me.PlateNumberBox)
        Me.Guna2Panel1.Controls.Add(Me.AddBtn)
        Me.Guna2Panel1.Controls.Add(Me.StatusBox)
        Me.Guna2Panel1.Controls.Add(Me.Remarkslbl)
        Me.Guna2Panel1.Controls.Add(Me.RemarksBox)
        Me.Guna2Panel1.Controls.Add(Me.Statuslbl)
        Me.Guna2Panel1.Controls.Add(Me.PlateNumberlbl)
        Me.Guna2Panel1.Controls.Add(Me.Selectlbl)
        Me.Guna2Panel1.Controls.Add(Me.Guna2Panel2)
        Me.Guna2Panel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2Panel1.Location = New System.Drawing.Point(210, 66)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel1.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2Panel1.Size = New System.Drawing.Size(750, 534)
        Me.Guna2Panel1.TabIndex = 0
        '
        'VehiclecategorytblComboBox
        '
        Me.VehiclecategorytblComboBox.DataSource = Me.VehiclecategorytblBindingSource
        Me.VehiclecategorytblComboBox.DisplayMember = "Category"
        Me.VehiclecategorytblComboBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.VehiclecategorytblComboBox.ForeColor = System.Drawing.Color.Black
        Me.VehiclecategorytblComboBox.FormattingEnabled = True
        Me.VehiclecategorytblComboBox.Location = New System.Drawing.Point(251, 91)
        Me.VehiclecategorytblComboBox.Name = "VehiclecategorytblComboBox"
        Me.VehiclecategorytblComboBox.Size = New System.Drawing.Size(473, 23)
        Me.VehiclecategorytblComboBox.TabIndex = 11
        Me.VehiclecategorytblComboBox.ValueMember = "AdminID"
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
        Me.PlateNumberBox.Location = New System.Drawing.Point(251, 142)
        Me.PlateNumberBox.Name = "PlateNumberBox"
        Me.PlateNumberBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.PlateNumberBox.PlaceholderText = "Plate Number"
        Me.PlateNumberBox.SelectedText = ""
        Me.PlateNumberBox.ShadowDecoration.Parent = Me.PlateNumberBox
        Me.PlateNumberBox.Size = New System.Drawing.Size(473, 38)
        Me.PlateNumberBox.TabIndex = 11
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
        Me.AddBtn.Location = New System.Drawing.Point(340, 431)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(69, 45)
        Me.AddBtn.TabIndex = 10
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseTransparentBackground = True
        '
        'StatusBox
        '
        Me.StatusBox.Animated = True
        Me.StatusBox.BorderColor = System.Drawing.Color.Black
        Me.StatusBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.StatusBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.StatusBox.DefaultText = "INCOMING VEHICLE"
        Me.StatusBox.DisabledState.BorderColor = System.Drawing.Color.Black
        Me.StatusBox.DisabledState.FillColor = System.Drawing.SystemColors.Control
        Me.StatusBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.StatusBox.DisabledState.Parent = Me.StatusBox
        Me.StatusBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.StatusBox.Enabled = False
        Me.StatusBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusBox.FocusedState.Parent = Me.StatusBox
        Me.StatusBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.StatusBox.ForeColor = System.Drawing.Color.Black
        Me.StatusBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusBox.HoverState.Parent = Me.StatusBox
        Me.StatusBox.Location = New System.Drawing.Point(251, 202)
        Me.StatusBox.Name = "StatusBox"
        Me.StatusBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.StatusBox.PlaceholderText = ""
        Me.StatusBox.SelectedText = ""
        Me.StatusBox.SelectionStart = 16
        Me.StatusBox.ShadowDecoration.Parent = Me.StatusBox
        Me.StatusBox.Size = New System.Drawing.Size(473, 36)
        Me.StatusBox.TabIndex = 9
        '
        'Remarkslbl
        '
        Me.Remarkslbl.BackColor = System.Drawing.Color.Transparent
        Me.Remarkslbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Remarkslbl.Location = New System.Drawing.Point(26, 267)
        Me.Remarkslbl.Name = "Remarkslbl"
        Me.Remarkslbl.Size = New System.Drawing.Size(75, 24)
        Me.Remarkslbl.TabIndex = 8
        Me.Remarkslbl.Text = "Remarks"
        '
        'RemarksBox
        '
        Me.RemarksBox.Animated = True
        Me.RemarksBox.BorderColor = System.Drawing.Color.Black
        Me.RemarksBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.RemarksBox.DefaultText = ""
        Me.RemarksBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.RemarksBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.RemarksBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RemarksBox.DisabledState.Parent = Me.RemarksBox
        Me.RemarksBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.RemarksBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemarksBox.FocusedState.Parent = Me.RemarksBox
        Me.RemarksBox.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.RemarksBox.ForeColor = System.Drawing.Color.Black
        Me.RemarksBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.RemarksBox.HoverState.Parent = Me.RemarksBox
        Me.RemarksBox.Location = New System.Drawing.Point(251, 267)
        Me.RemarksBox.Name = "RemarksBox"
        Me.RemarksBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.RemarksBox.PlaceholderText = "Remarks"
        Me.RemarksBox.SelectedText = ""
        Me.RemarksBox.ShadowDecoration.Parent = Me.RemarksBox
        Me.RemarksBox.Size = New System.Drawing.Size(473, 41)
        Me.RemarksBox.TabIndex = 7
        '
        'Statuslbl
        '
        Me.Statuslbl.BackColor = System.Drawing.Color.Transparent
        Me.Statuslbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Statuslbl.Location = New System.Drawing.Point(26, 208)
        Me.Statuslbl.Name = "Statuslbl"
        Me.Statuslbl.Size = New System.Drawing.Size(118, 24)
        Me.Statuslbl.TabIndex = 5
        Me.Statuslbl.Text = "Vehicle Status"
        '
        'PlateNumberlbl
        '
        Me.PlateNumberlbl.BackColor = System.Drawing.Color.Transparent
        Me.PlateNumberlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlateNumberlbl.Location = New System.Drawing.Point(26, 149)
        Me.PlateNumberlbl.Name = "PlateNumberlbl"
        Me.PlateNumberlbl.Size = New System.Drawing.Size(116, 24)
        Me.PlateNumberlbl.TabIndex = 4
        Me.PlateNumberlbl.Text = "Plate Number"
        '
        'Selectlbl
        '
        Me.Selectlbl.BackColor = System.Drawing.Color.Transparent
        Me.Selectlbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Selectlbl.Location = New System.Drawing.Point(26, 90)
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
        Me.Guna2Panel2.Size = New System.Drawing.Size(750, 51)
        Me.Guna2Panel2.TabIndex = 0
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(58, 13)
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
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(37, 24)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Add"
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
        'FormAddVehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1201, 685)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormAddVehicle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Vehicle"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        Me.Guna2Panel1.PerformLayout()
        CType(Me.VehiclecategorytblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ParkingdbDataSetBindingSource As BindingSource
    Friend WithEvents Selectlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents PlateNumberlbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Statuslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Remarkslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents RemarksBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents StatusBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PlateNumberBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ParkingdbDataSet As parkingdbDataSet
    Friend WithEvents VehiclecategorytblBindingSource As BindingSource
    Friend WithEvents VehiclecategorytblTableAdapter As parkingdbDataSetTableAdapters.vehiclecategorytblTableAdapter
    Friend WithEvents TableAdapterManager As parkingdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiclecategorytblComboBox As ComboBox
End Class
