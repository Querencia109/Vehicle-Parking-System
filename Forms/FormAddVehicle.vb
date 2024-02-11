Imports MySql.Data.MySqlClient
Public Class FormAddVehicle
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader

    Private Sub FormAddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkingdbDataSet.vehiclecategorytbl' table. You can move, or remove it, as needed.
        Me.VehiclecategorytblTableAdapter.Fill(Me.ParkingdbDataSet.vehiclecategorytbl)
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False

        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to add the record?", MessageBoxButtons.YesNo, "Adding Record")
        If result = MsgBoxResult.Yes Then
            sql = "INSERT INTO vehicletbl(VehicleCategory,PlateNum,DateIn,TimeIn,VehicleStatus,Remarks) VALUES('" & VehiclecategorytblComboBox.Text & "', '" & PlateNumberBox.Text.ToUpper & "', current_date(), TIME_FORMAT(current_time, '%r'), 'INCOMING VEHICLE', '" & RemarksBox.Text & "')"
            conn.Open()
            Try
                dbcomm = New MySqlCommand(sql, conn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
                MsgBox("Data Inserted.", MsgBoxStyle.Information, "Inserting Record")
            Catch ex As Exception
                MsgBox("Failed To insert data: " & ex.Message.ToString())
            End Try

            sql = "INSERT INTO adminrecordtbl(UserID,Action_Performed,Date_Performed,Time_Performed) VALUES('" & UserDashboardFinal2.UserID.Text & "', 'Added Record', current_date, TIME_FORMAT(current_time,'%r'))"
            Try
                dbcomm = New MySqlCommand(sql, conn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
            Catch ex As Exception
                MsgBox("Failed to insert data to admin record: " & ex.Message.ToString())
            End Try
            conn.Close()

            VehiclecategorytblComboBox.Text = ""
            PlateNumberBox.Text = ""
            RemarksBox.Text = ""
        End If
    End Sub

    Private Sub VehiclecategorytblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehiclecategorytblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ParkingdbDataSet)

    End Sub
End Class