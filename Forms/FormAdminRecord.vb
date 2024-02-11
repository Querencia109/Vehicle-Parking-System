Imports MySql.Data.MySqlClient
Public Class FormAdminRecord
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Private Sub FormAdminRecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ParkingdbDataSet.adminrecordtbl' table. You can move, or remove it, as needed.
        Me.AdminrecordtblTableAdapter.Fill(Me.ParkingdbDataSet.adminrecordtbl)
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

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Try
            sql = "SELECT * FROM adminrecordtbl WHERE UserID like '%" & SearchBox.Text & "%'"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            adminrecordtbl.DataSource = dt
            If dt.Rows.Count > 0 Then

            Else
                MsgBox("Record Not Found", MsgBoxStyle.Critical, "Search Record")
                Me.AdminrecordtblTableAdapter.Fill(Me.ParkingdbDataSet.adminrecordtbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RefreshBtn_Click(sender As Object, e As EventArgs) Handles RefreshBtn.Click
        Try
            sql = "SELECT * FROM adminrecordtbl"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            adminrecordtbl.DataSource = dt
            If dt.Rows.Count > 0 Then
                SearchBox.Text = ""
            Else
                MsgBox("No Records", MsgBoxStyle.Critical, "Show Record")
                Me.AdminrecordtblTableAdapter.Fill(Me.ParkingdbDataSet.adminrecordtbl)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class