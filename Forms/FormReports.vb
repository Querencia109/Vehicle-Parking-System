Imports MySql.Data.MySqlClient
Public Class FormReports
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub FormReports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False
        DatePicker.Format = DateTimePickerFormat.Custom
        DatePicker.CustomFormat = "yyyy-MM-dd"
        DatePicker2.Format = DateTimePickerFormat.Custom
        DatePicker2.CustomFormat = "yyyy-MM-dd"

        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        sql = "SELECT ParkingID, PlateNum FROM vehicletbl WHERE DateIn BETWEEN '" & DatePicker.Text & "' AND '" & DatePicker2.Text & "'"
        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            DataGridView.DataSource = dt
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Reportslbl.Visible = True
        Reportslbl.Text = "Reports from " & DatePicker.Text & " to " & DatePicker2.Text

        'sql = "SELECT count(*) FROM vehicletbl WHERE DateIn BETWEEN '" & DatePicker.Text & "' AND '" & DatePicker2.Text & "'"
        Try
            Dim count As Int16
            conn.Open()
            sql = "SELECT count(PlateNum) FROM vehicletbl WHERE DateIn BETWEEN '" & DatePicker.Text & "' AND '" & DatePicker2.Text & "'"
            dbcomm = New MySqlCommand(sql, conn)
            count = Convert.ToInt16(dbcomm.ExecuteScalar())

            Totallbl.Visible = True
            Totallbl.Text = "Total: " & count
            'MsgBox(count.ToString())
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim count1 As Int16
            conn.Open()
            sql = "SELECT count(PlateNum) FROM vehicletbl WHERE ParkingCharge = '50 pesos' AND DateIn BETWEEN '" & DatePicker.Text & "' AND '" & DatePicker2.Text & "'"
            dbcomm = New MySqlCommand(sql, conn)
            count1 = Convert.ToInt16(dbcomm.ExecuteScalar())

            Pesos50.Visible = True
            Pesos50.Text = "Total Vehicle (Less than 3 hours): " & count1
            'MsgBox(count.ToString())
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Try
            Dim count1 As Int16
            conn.Open()
            sql = "SELECT count(PlateNum) FROM vehicletbl WHERE ParkingCharge = '100 pesos' AND DateIn BETWEEN '" & DatePicker.Text & "' AND '" & DatePicker2.Text & "'"
            dbcomm = New MySqlCommand(sql, conn)
            count1 = Convert.ToInt16(dbcomm.ExecuteScalar())

            Pesos100.Visible = True
            Pesos100.Text = "Total Vehicle (More than 3 hours): " & count1
            'MsgBox(count.ToString())
            conn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class