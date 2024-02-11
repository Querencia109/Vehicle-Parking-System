Public Class UserDashboardFinal2
    Dim OverviewForm As New FormOverview
    Dim VehicleTableForm As New FormVehicleTable
    Dim AddVehicleForm As New FormAddVehicle
    Dim ManageVehicleForm As New FormManageVehicle
    Private Sub OverviewBtn_Click(sender As Object, e As EventArgs) Handles OverviewBtn.Click
        Try
            OverviewForm.MdiParent = Me
            OverviewForm.TopMost = True
            OverviewForm.Dock = DockStyle.Fill
            OverviewForm.Show()
            VehicleTableForm.Hide()
            AddVehicleForm.Hide()
            ManageVehicleForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim Vf As New UserLoginFinal2
        With Vf
            .Username.Text = ""
            .Password.Text = ""
            '.ShowDialog()
            UserLoginFinal2.Show()
            Me.Close()
        End With
    End Sub

    Private Sub UserDashboardFinal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        IsMdiContainer = True
        OverviewBtn.PerformClick()
    End Sub

    Private Sub VehicleTableBtn_Click(sender As Object, e As EventArgs) Handles VehicleTableBtn.Click
        Try
            VehicleTableForm.MdiParent = Me
            VehicleTableForm.TopMost = True
            VehicleTableForm.Dock = DockStyle.Fill
            VehicleTableForm.Show()
            OverviewForm.Hide()
            AddVehicleForm.Hide()
            ManageVehicleForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub AddVehicleBtn_Click(sender As Object, e As EventArgs) Handles AddVehicleBtn.Click
        Try

            AddVehicleForm.MdiParent = Me
            AddVehicleForm.TopMost = True
            AddVehicleForm.Dock = DockStyle.Fill
            AddVehicleForm.Show()
            OverviewForm.Hide()
            VehicleTableForm.Hide()
            ManageVehicleForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ManageVehicleBtn_Click(sender As Object, e As EventArgs) Handles ManageVehicleBtn.Click
        Try
            ManageVehicleForm.MdiParent = Me
            ManageVehicleForm.TopMost = True
            ManageVehicleForm.Dock = DockStyle.Fill
            ManageVehicleForm.Show()
            OverviewForm.Hide()
            VehicleTableForm.Hide()
            AddVehicleForm.Hide()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
End Class