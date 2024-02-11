<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormVehicleTable
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
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.SearchBtn = New Guna.UI2.WinForms.Guna2Button()
        Me.SearchBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2Panel1)
        Me.Guna2GradientPanel1.Controls.Add(Me.SearchBtn)
        Me.Guna2GradientPanel1.Controls.Add(Me.SearchBox)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(119, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.ShadowDecoration.Parent = Me.Guna2GradientPanel1
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(956, 770)
        Me.Guna2GradientPanel1.TabIndex = 1
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Location = New System.Drawing.Point(113, 179)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Enabled = True
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.Guna2Panel1.Size = New System.Drawing.Size(731, 591)
        Me.Guna2Panel1.TabIndex = 3
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
        Me.SearchBtn.Location = New System.Drawing.Point(113, 93)
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
        Me.SearchBox.Location = New System.Drawing.Point(196, 93)
        Me.SearchBox.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.SearchBox.PlaceholderForeColor = System.Drawing.Color.DimGray
        Me.SearchBox.PlaceholderText = "PLATE NUMBER"
        Me.SearchBox.SelectedText = ""
        Me.SearchBox.ShadowDecoration.Parent = Me.SearchBox
        Me.SearchBox.Size = New System.Drawing.Size(257, 30)
        Me.SearchBox.TabIndex = 1
        Me.SearchBox.TextOffset = New System.Drawing.Point(10, 0)
        '
        'FormVehicleTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(956, 770)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FormVehicleTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Table"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents SearchBtn As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SearchBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
End Class
