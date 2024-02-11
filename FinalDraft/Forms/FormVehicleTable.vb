Public Class FormVehicleTable
    Private Sub FormVehicleTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkingdbDataSet.vehicletbl' table. You can move, or remove it, as needed.
        Me.VehicletblTableAdapter.Fill(Me.ParkingdbDataSet.vehicletbl)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False
    End Sub

    Private Sub VehicletblGuna2DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub VehicletblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub VehicletblBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub VehicletblBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)

    End Sub
End Class