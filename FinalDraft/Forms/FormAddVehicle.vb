Imports MySql.Data.MySqlClient
Public Class FormAddVehicle
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader

    Private Sub FormAddVehicle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        sql = "INSERT INTO vehicletbl(VehicleCategory,PlateNum,DateIn,TimeIn) VALUES('" & VehicleCategoryBox.Text & "', " & PlateNumberBox.Text & "', current_date, TIME_FORMAT(current_time,'%r')"
        Try
            conn.Open()
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
            MsgBox("Data Inserted.", MsgBoxStyle.Information, "Inserting Record")
            conn.Close()
        Catch ex As Exception
            MsgBox("Failed To insert data: " & ex.Message.ToString())
        End Try

        sql = "INSERT INTO adminrecordtbl(UserID,Action_Performed,Date_Performed,Time_Performed) VALUES('" & UserIDlbl.Text & "', 'Added Record', current_date, TIME_FORMAT(current_time,'%r'))"
        Try
            conn.Open()
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            dbread.Close()
            conn.Close()
        Catch ex As Exception
            MsgBox("Failed to insert data to admin record: " & ex.Message.ToString())
        End Try
    End Sub
End Class