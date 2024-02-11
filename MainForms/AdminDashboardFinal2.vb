Public Class AdminDashboardFinal2
    Dim OverviewForm As New FormOverview
    Dim VehicleTableForm As New FormVehicleTable
    Dim AdminRecordForm As New FormAdminRecord
    Dim ManageCategoryForm As New FormManageCategory
    Dim ReportsForm As New FormReports
    Dim AdditionalForm As New FormAddtional
    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim Vf As New UserLoginFinal2
        With Vf
            .Username.Text = ""
            .Password.Text = ""
            '.ShowDialog()
            AdminLoginFinal2.Show()
            Me.Close()
        End With
    End Sub

    Private Sub VehicleTableBtn_Click(sender As Object, e As EventArgs) Handles VehicleTableBtn.Click
        Try
            VehicleTableForm.MdiParent = Me
            VehicleTableForm.TopMost = True
            VehicleTableForm.Dock = DockStyle.Fill
            VehicleTableForm.Show()
            OverviewForm.Hide()
            AdminRecordForm.Hide()
            ManageCategoryForm.Hide()
            AdditionalForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub AdminDashboardFinal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        OverviewBtn.PerformClick()
    End Sub

    Private Sub OverviewBtn_Click(sender As Object, e As EventArgs) Handles OverviewBtn.Click
        Try
            OverviewForm.MdiParent = Me
            OverviewForm.TopMost = True
            OverviewForm.Dock = DockStyle.Fill
            OverviewForm.Show()
            VehicleTableForm.Hide()
            AdminRecordForm.Hide()
            ManageCategoryForm.Hide()
            AdditionalForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub AdminRecordBtn_Click(sender As Object, e As EventArgs) Handles AdminRecordBtn.Click
        Try
            AdminRecordForm.MdiParent = Me
            AdminRecordForm.TopMost = True
            AdminRecordForm.Dock = DockStyle.Fill
            AdminRecordForm.Show()
            VehicleTableForm.Hide()
            OverviewForm.Hide()
            ManageCategoryForm.Hide()
            AdditionalForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ManageCategoryBtn_Click(sender As Object, e As EventArgs) Handles ManageCategoryBtn.Click
        Try
            ManageCategoryForm.MdiParent = Me
            ManageCategoryForm.TopMost = True
            ManageCategoryForm.Dock = DockStyle.Fill
            ManageCategoryForm.Show()
            VehicleTableForm.Hide()
            OverviewForm.Hide()
            AdminRecordForm.Hide()
            AdditionalForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        Try
            ReportsForm.MdiParent = Me
            ReportsForm.TopMost = True
            ReportsForm.Dock = DockStyle.Fill
            ReportsForm.Show()
            VehicleTableForm.Hide()
            OverviewForm.Hide()
            AdminRecordForm.Hide()
            ManageCategoryForm.Hide()
            AdditionalForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub AdditionalBtn_Click(sender As Object, e As EventArgs) Handles AdditionalBtn.Click
        Try
            AdditionalForm.MdiParent = Me
            AdditionalForm.TopMost = True
            AdditionalForm.Dock = DockStyle.Fill
            AdditionalForm.Show()
            VehicleTableForm.Hide()
            OverviewForm.Hide()
            AdminRecordForm.Hide()
            ManageCategoryForm.Hide()
            ReportsForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class