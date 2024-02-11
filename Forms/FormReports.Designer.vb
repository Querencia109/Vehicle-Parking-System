<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormReports
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Totallbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Reportslbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.ToDatelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.DatePicker = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.DatePicker2 = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.AddBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.FromDatelbl = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2Panel3 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Pesos50 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Pesos100 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.AutoScroll = True
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel2)
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
        'Guna2Panel2
        '
        Me.Guna2Panel2.AutoScroll = True
        Me.Guna2Panel2.Controls.Add(Me.Pesos100)
        Me.Guna2Panel2.Controls.Add(Me.Pesos50)
        Me.Guna2Panel2.Controls.Add(Me.Totallbl)
        Me.Guna2Panel2.Controls.Add(Me.DataGridView)
        Me.Guna2Panel2.Controls.Add(Me.Reportslbl)
        Me.Guna2Panel2.Controls.Add(Me.ToDatelbl)
        Me.Guna2Panel2.Controls.Add(Me.DatePicker)
        Me.Guna2Panel2.Controls.Add(Me.DatePicker2)
        Me.Guna2Panel2.Controls.Add(Me.AddBtn)
        Me.Guna2Panel2.Controls.Add(Me.FromDatelbl)
        Me.Guna2Panel2.Controls.Add(Me.Guna2Panel3)
        Me.Guna2Panel2.FillColor = System.Drawing.Color.FromArgb(CType(CType(211, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.Guna2Panel2.Location = New System.Drawing.Point(169, 56)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.ShadowDecoration.CustomizableEdges.BottomLeft = False
        Me.Guna2Panel2.ShadowDecoration.CustomizableEdges.TopLeft = False
        Me.Guna2Panel2.ShadowDecoration.Enabled = True
        Me.Guna2Panel2.ShadowDecoration.Parent = Me.Guna2Panel2
        Me.Guna2Panel2.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2Panel2.Size = New System.Drawing.Size(689, 534)
        Me.Guna2Panel2.TabIndex = 4
        '
        'Totallbl
        '
        Me.Totallbl.BackColor = System.Drawing.Color.Transparent
        Me.Totallbl.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Totallbl.Location = New System.Drawing.Point(26, 314)
        Me.Totallbl.Name = "Totallbl"
        Me.Totallbl.Size = New System.Drawing.Size(38, 20)
        Me.Totallbl.TabIndex = 14
        Me.Totallbl.Text = "Total: "
        Me.Totallbl.Visible = False
        '
        'DataGridView
        '
        Me.DataGridView.AllowUserToAddRows = False
        Me.DataGridView.AllowUserToDeleteRows = False
        Me.DataGridView.AllowUserToResizeColumns = False
        Me.DataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable
        Me.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView.EnableHeadersVisualStyles = False
        Me.DataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView.Location = New System.Drawing.Point(26, 359)
        Me.DataGridView.Name = "DataGridView"
        Me.DataGridView.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView.RowHeadersVisible = False
        Me.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView.Size = New System.Drawing.Size(633, 150)
        Me.DataGridView.TabIndex = 13
        Me.DataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(62, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(16, Byte), Integer), CType(CType(18, Byte), Integer))
        Me.DataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView.ThemeStyle.HeaderStyle.Height = 23
        Me.DataGridView.ThemeStyle.ReadOnly = True
        Me.DataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(33, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(41, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White
        Me.DataGridView.ThemeStyle.RowsStyle.Height = 22
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(114, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.DataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'Reportslbl
        '
        Me.Reportslbl.BackColor = System.Drawing.Color.Transparent
        Me.Reportslbl.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Reportslbl.Location = New System.Drawing.Point(26, 288)
        Me.Reportslbl.Name = "Reportslbl"
        Me.Reportslbl.Size = New System.Drawing.Size(53, 20)
        Me.Reportslbl.TabIndex = 12
        Me.Reportslbl.Text = "Reports"
        Me.Reportslbl.Visible = False
        '
        'ToDatelbl
        '
        Me.ToDatelbl.BackColor = System.Drawing.Color.Transparent
        Me.ToDatelbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDatelbl.Location = New System.Drawing.Point(26, 155)
        Me.ToDatelbl.Name = "ToDatelbl"
        Me.ToDatelbl.Size = New System.Drawing.Size(65, 24)
        Me.ToDatelbl.TabIndex = 11
        Me.ToDatelbl.Text = "To Date"
        '
        'DatePicker
        '
        Me.DatePicker.Animated = True
        Me.DatePicker.BackColor = System.Drawing.Color.Transparent
        Me.DatePicker.Checked = True
        Me.DatePicker.CheckedState.Parent = Me.DatePicker
        Me.DatePicker.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DatePicker.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatePicker.ForeColor = System.Drawing.Color.Black
        Me.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker.HoverState.Parent = Me.DatePicker
        Me.DatePicker.Location = New System.Drawing.Point(270, 84)
        Me.DatePicker.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePicker.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.ShadowDecoration.Parent = Me.DatePicker
        Me.DatePicker.Size = New System.Drawing.Size(389, 36)
        Me.DatePicker.TabIndex = 0
        Me.DatePicker.Value = New Date(2021, 11, 17, 14, 17, 6, 941)
        '
        'DatePicker2
        '
        Me.DatePicker2.Animated = True
        Me.DatePicker2.BackColor = System.Drawing.Color.Transparent
        Me.DatePicker2.Checked = True
        Me.DatePicker2.CheckedState.Parent = Me.DatePicker2
        Me.DatePicker2.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.DatePicker2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.DatePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatePicker2.HoverState.Parent = Me.DatePicker2
        Me.DatePicker2.Location = New System.Drawing.Point(270, 149)
        Me.DatePicker2.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.DatePicker2.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.DatePicker2.Name = "DatePicker2"
        Me.DatePicker2.ShadowDecoration.Parent = Me.DatePicker2
        Me.DatePicker2.Size = New System.Drawing.Size(389, 36)
        Me.DatePicker2.TabIndex = 3
        Me.DatePicker2.Value = New Date(2021, 11, 17, 14, 17, 6, 941)
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
        Me.AddBtn.Location = New System.Drawing.Point(280, 214)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.ShadowDecoration.Parent = Me.AddBtn
        Me.AddBtn.Size = New System.Drawing.Size(91, 45)
        Me.AddBtn.TabIndex = 10
        Me.AddBtn.Text = "Submit"
        Me.AddBtn.UseTransparentBackground = True
        '
        'FromDatelbl
        '
        Me.FromDatelbl.BackColor = System.Drawing.Color.Transparent
        Me.FromDatelbl.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDatelbl.Location = New System.Drawing.Point(26, 90)
        Me.FromDatelbl.Name = "FromDatelbl"
        Me.FromDatelbl.Size = New System.Drawing.Size(89, 24)
        Me.FromDatelbl.TabIndex = 2
        Me.FromDatelbl.Text = "From Date"
        '
        'Guna2Panel3
        '
        Me.Guna2Panel3.BorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel2)
        Me.Guna2Panel3.Controls.Add(Me.Guna2HtmlLabel1)
        Me.Guna2Panel3.CustomBorderColor = System.Drawing.Color.Black
        Me.Guna2Panel3.CustomBorderThickness = New System.Windows.Forms.Padding(0, 0, 0, 1)
        Me.Guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel3.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Guna2Panel3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel3.Name = "Guna2Panel3"
        Me.Guna2Panel3.ShadowDecoration.Parent = Me.Guna2Panel3
        Me.Guna2Panel3.Size = New System.Drawing.Size(689, 51)
        Me.Guna2Panel3.TabIndex = 0
        '
        'Guna2HtmlLabel2
        '
        Me.Guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel2.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel2.IsSelectionEnabled = False
        Me.Guna2HtmlLabel2.Location = New System.Drawing.Point(99, 13)
        Me.Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Me.Guna2HtmlLabel2.Size = New System.Drawing.Size(67, 24)
        Me.Guna2HtmlLabel2.TabIndex = 1
        Me.Guna2HtmlLabel2.Text = "Reports"
        '
        'Guna2HtmlLabel1
        '
        Me.Guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2HtmlLabel1.ForeColor = System.Drawing.Color.White
        Me.Guna2HtmlLabel1.IsSelectionEnabled = False
        Me.Guna2HtmlLabel1.Location = New System.Drawing.Point(15, 13)
        Me.Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Me.Guna2HtmlLabel1.Size = New System.Drawing.Size(80, 24)
        Me.Guna2HtmlLabel1.TabIndex = 0
        Me.Guna2HtmlLabel1.Text = "Generate"
        '
        'Pesos50
        '
        Me.Pesos50.BackColor = System.Drawing.Color.Transparent
        Me.Pesos50.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pesos50.Location = New System.Drawing.Point(351, 288)
        Me.Pesos50.Name = "Pesos50"
        Me.Pesos50.Size = New System.Drawing.Size(38, 20)
        Me.Pesos50.TabIndex = 15
        Me.Pesos50.Text = "Total: "
        Me.Pesos50.Visible = False
        '
        'Pesos100
        '
        Me.Pesos100.BackColor = System.Drawing.Color.Transparent
        Me.Pesos100.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pesos100.Location = New System.Drawing.Point(351, 314)
        Me.Pesos100.Name = "Pesos100"
        Me.Pesos100.Size = New System.Drawing.Size(38, 20)
        Me.Pesos100.TabIndex = 16
        Me.Pesos100.Text = "Total: "
        Me.Pesos100.Visible = False
        '
        'FormReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1328, 660)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.Name = "FormReports"
        Me.Text = "Reports Form"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2Panel3.ResumeLayout(False)
        Me.Guna2Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents DatePicker As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents DatePicker2 As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents AddBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents FromDatelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2Panel3 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents ToDatelbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Reportslbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents DataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Totallbl As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Pesos100 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Pesos50 As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
