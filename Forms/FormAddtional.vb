Imports MySql.Data.MySqlClient
Public Class FormAddtional
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub FormAddtional_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkingdbDataSet.vehicletbl' table. You can move, or remove it, as needed.
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False
        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        Try
            sql = "SELECT * FROM vehicletbl"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            vehicletbl.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            sql = "SELECT * FROM vehicletbl WHERE PlateNum like '%" & SearchBox.Text & "%'"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            vehicletbl.DataSource = dt
            If dt.Rows.Count > 0 Then

            Else
                MsgBox("Record Not Found", MsgBoxStyle.Critical, "Search Record")
                Me.VehicletblTableAdapter.Fill(Me.ParkingdbDataSet.vehicletbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Try
            sql = "SELECT * FROM vehicletbl"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            vehicletbl.DataSource = dt
            If dt.Rows.Count > 0 Then
                SearchBox.Text = ""
            Else
                MsgBox("No Records", MsgBoxStyle.Critical, "Show Record")
                Me.VehicletblTableAdapter.Fill(Me.ParkingdbDataSet.vehicletbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class