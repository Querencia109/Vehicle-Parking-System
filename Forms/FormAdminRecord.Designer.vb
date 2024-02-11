<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdminRecord
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.RefreshBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.adminrecordtbl = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.SearchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.ParkingdbDataSet = New VPMSFinal.parkingdbDataSet()
        Me.AdminrecordtblBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AdminrecordtblTableAdapter = New VPMSFinal.parkingdbDataSetTableAdapters.adminrecordtblTableAdapter()
        Me.TableAdapterManager = New VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager()
        Me.UserIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ActionPerformedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatePerformedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TimePerformedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.adminrecordtbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AdminrecordtblBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.RefreshBtn)
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
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(1328, 660)
        Me.Guna2GradientPanel1.TabIndex = 2
        '
        'RefreshBtn
        '
        Me.RefreshBtn.Animated = True
        Me.RefreshBtn.BackColor = System.Drawing.Color.Transparent
        Me.RefreshBtn.CheckedState.Parent = Me.RefreshBtn
        Me.RefreshBtn.CustomImages.Parent = Me.RefreshBtn
        Me.RefreshBtn.CustomizableEdges.BottomRight = False
        Me.RefreshBtn.CustomizableEdges.TopRight = False
        Me.RefreshBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.RefreshBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.RefreshBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.RefreshBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.RefreshBtn.DisabledState.Parent = Me.RefreshBtn
        Me.RefreshBtn.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.RefreshBtn.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RefreshBtn.ForeColor = System.Drawing.Color.White
        Me.RefreshBtn.HoverState.Parent = Me.RefreshBtn
        Me.RefreshBtn.Location = New System.Drawing.Point(1018, 25)
        Me.RefreshBtn.Name = "RefreshBtn"
        Me.RefreshBtn.ShadowDecoration.Parent = Me.RefreshBtn
        Me.RefreshBtn.Size = New System.Drawing.Size(91, 30)
        Me.RefreshBtn.TabIndex = 4
        Me.RefreshBtn.Text = "Refresh"
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.adminrecordtbl)
        Me.Guna2Panel1.Location = New System.Drawing.Point(45, 73)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2Panel1.Size = New System.Drawing.Size(1064, 537)
        Me.Guna2Panel1.TabIndex = 3
        '
        'adminrecordtbl
        '
        Me.adminrecordtbl.AllowUserToAddRows = False
        Me.adminrecordtbl.AllowUserToDeleteRows = False
        Me.adminrecordtbl.AllowUserToResizeColumns = False
        Me.adminrecordtbl.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.adminrecordtbl.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.adminrecordtbl.AutoGenerateColumns = False
        Me.adminrecordtbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.adminrecordtbl.BackgroundColor = System.Drawing.Color.White
        Me.adminrecordtbl.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.adminrecordtbl.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.adminrecordtbl.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.adminrecordtbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.adminrecordtbl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIDDataGridViewTextBoxColumn, Me.ActionPerformedDataGridViewTextBoxColumn, Me.DatePerformedDataGridViewTextBoxColumn, Me.TimePerformedDataGridViewTextBoxColumn})
        Me.adminrecordtbl.DataSource = Me.AdminrecordtblBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.adminrecordtbl.DefaultCellStyle = DataGridViewCellStyle6
        Me.adminrecordtbl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.adminrecordtbl.EnableHeadersVisualStyles = False
        Me.adminrecordtbl.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.adminrecordtbl.Location = New System.Drawing.Point(0, 0)
        Me.adminrecordtbl.Name = "adminrecordtbl"
        Me.adminrecordtbl.ReadOnly = True
        Me.adminrecordtbl.RowHeadersVisible = False
        Me.adminrecordtbl.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.adminrecordtbl.Size = New System.Drawing.Size(1064, 537)
        Me.adminrecordtbl.TabIndex = 0
        Me.adminrecordtbl.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.adminrecordtbl.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.adminrecordtbl.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.adminrecordtbl.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.adminrecordtbl.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.adminrecordtbl.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.adminrecordtbl.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.adminrecordtbl.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.adminrecordtbl.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.adminrecordtbl.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.adminrecordtbl.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.adminrecordtbl.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.adminrecordtbl.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.adminrecordtbl.ThemeStyle.HeaderStyle.Height = 23
        Me.adminrecordtbl.ThemeStyle.ReadOnly = True
        Me.adminrecordtbl.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.adminrecordtbl.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.adminrecordtbl.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.adminrecordtbl.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.adminrecordtbl.ThemeStyle.RowsStyle.Height = 22
        Me.adminrecordtbl.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.adminrecordtbl.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.SearchBtn.Location = New System.Drawing.Point(45, 25)
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
        Me.SearchBox.Location = New System.Drawing.Point(128, 25)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBox.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.SearchBox.PlaceholderText = "USER ID"
        Me.SearchBox.SelectedText = ""
        Me.SearchBox.ShadowDecoration.Parent = Me.SearchBox
        Me.SearchBox.Size = New System.Drawing.Size(257, 30)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.TextOffset = New System.Drawing.Point(10, 0)
        '
        'ParkingdbDataSet
        '
        Me.ParkingdbDataSet.DataSetName = "parkingdbDataSet"
        Me.ParkingdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminrecordtblBindingSource
        '
        Me.AdminrecordtblBindingSource.DataMember = "adminrecordtbl"
        Me.AdminrecordtblBindingSource.DataSource = Me.ParkingdbDataSet
        '
        'AdminrecordtblTableAdapter
        '
        Me.AdminrecordtblTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.adminrecordtblTableAdapter = Me.AdminrecordtblTableAdapter
        Me.TableAdapterManager.admintblTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = VPMSFinal.parkingdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usertblTableAdapter = Nothing
        Me.TableAdapterManager.vehiclecategorytblTableAdapter = Nothing
        Me.TableAdapterManager.vehicletblTableAdapter = Nothing
        '
        'UserIDDataGridViewTextBoxColumn
        '
        Me.UserIDDataGridViewTextBoxColumn.DataPropertyName = "UserID"
        Me.UserIDDataGridViewTextBoxColumn.HeaderText = "User ID"
        Me.UserIDDataGridViewTextBoxColumn.Name = "UserIDDataGridViewTextBoxColumn"
        Me.UserIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ActionPerformedDataGridViewTextBoxColumn
        '
        Me.ActionPerformedDataGridViewTextBoxColumn.DataPropertyName = "Action_Performed"
        Me.ActionPerformedDataGridViewTextBoxColumn.HeaderText = "Action Performed"
        Me.ActionPerformedDataGridViewTextBoxColumn.Name = "ActionPerformedDataGridViewTextBoxColumn"
        Me.ActionPerformedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DatePerformedDataGridViewTextBoxColumn
        '
        Me.DatePerformedDataGridViewTextBoxColumn.DataPropertyName = "Date_Performed"
        Me.DatePerformedDataGridViewTextBoxColumn.HeaderText = "Date Performed"
        Me.DatePerformedDataGridViewTextBoxColumn.Name = "DatePerformedDataGridViewTextBoxColumn"
        Me.DatePerformedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TimePerformedDataGridViewTextBoxColumn
        '
        Me.TimePerformedDataGridViewTextBoxColumn.DataPropertyName = "Time_Performed"
        Me.TimePerformedDataGridViewTextBoxColumn.HeaderText = "Time Performed"
        Me.TimePerformedDataGridViewTextBoxColumn.Name = "TimePerformedDataGridViewTextBoxColumn"
        Me.TimePerformedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FormAdminRecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 660)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormAdminRecord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Record"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.adminrecordtbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParkingdbDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AdminrecordtblBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents RefreshBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents adminrecordtbl As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents SearchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ParkingdbDataSet As parkingdbDataSet
    Friend WithEvents AdminrecordtblBindingSource As BindingSource
    Friend WithEvents AdminrecordtblTableAdapter As parkingdbDataSetTableAdapters.adminrecordtblTableAdapter
    Friend WithEvents TableAdapterManager As parkingdbDataSetTableAdapters.TableAdapterManager
    Friend WithEvents UserIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ActionPerformedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatePerformedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TimePerformedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
