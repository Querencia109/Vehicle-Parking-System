Imports MySql.Data.MySqlClient
Public Class FormOverview
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub FormOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False
        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        RefreshBtn.PerformClick()
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Try
            Dim count1 As Int16
            Dim count2 As Int16
            Dim count3 As Int16
            Dim count4 As Int16
            conn.Open()
            sql = "SELECT count(*) FROM vehicletbl INNER JOIN vehiclecategorytbl ON vehicletbl.vehiclecategory = vehiclecategorytbl.category AND vehiclecategorytbl.type = '4 WHEELER VEHICLE' AND vehicletbl.vehiclestatus = 'INCOMING VEHICLE'"
            dbcomm = New MySqlCommand(sql, conn)
            count1 = Convert.ToInt16(dbcomm.ExecuteScalar())

            Total4Wheeler.Text = count1

            sql = "SELECT count(*) FROM vehicletbl INNER JOIN vehiclecategorytbl ON vehicletbl.vehiclecategory = vehiclecategorytbl.category AND vehiclecategorytbl.type = '3 WHEELER VEHICLE' AND vehicletbl.vehiclestatus = 'INCOMING VEHICLE'"
            dbcomm = New MySqlCommand(sql, conn)
            count2 = Convert.ToInt16(dbcomm.ExecuteScalar())

            Total3Wheeler.Text = count2

            sql = "SELECT count(*) FROM vehicletbl INNER JOIN vehiclecategorytbl ON vehicletbl.vehiclecategory = vehiclecategorytbl.category AND vehiclecategorytbl.type = '2 WHEELER VEHICLE' AND vehicletbl.vehiclestatus = 'INCOMING VEHICLE'"
            dbcomm = New MySqlCommand(sql, conn)
            count3 = Convert.ToInt16(dbcomm.ExecuteScalar())

            Total2Wheeler.Text = count3

            sql = "SELECT count(*) FROM vehicletbl WHERE VehicleStatus = 'INCOMING VEHICLE'"
            dbcomm = New MySqlCommand(sql, conn)
            count4 = Convert.ToInt16(dbcomm.ExecuteScalar())

            TotalParkedVehiclelbl.Text = count4
            SlotContainlbl.Text = 200 - count4
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class