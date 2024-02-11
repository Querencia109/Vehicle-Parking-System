Imports MySql.Data.MySqlClient
Public Class AdminLoginFinal2
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Dim usertable As New DataTable

    Private Sub AdminLoginBtn_Click(sender As Object, e As EventArgs) Handles AdminLoginBtn.Click
        Dim Vf As New UserLoginFinal2
        Vf.Username.Text = ""
        Vf.Password.Text = ""
        UserLoginFinal2.Show()
        Me.Close()
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Using obj As New MySqlCommand("SELECT * FROM admintbl WHERE AdminID = @username AND Password_ = @password", conn)
            obj.Parameters.Add("@username", MySqlDbType.String).Value = Username.Text
            obj.Parameters.Add("@password", MySqlDbType.String).Value = Password.Text

            Using objadapter As New MySqlDataAdapter(obj)
                usertable.Clear()
                objadapter.Fill(usertable)

                If usertable.Rows.Count = Nothing Then
                    MsgBox("No Input or Wrong User ID or Password", MsgBoxStyle.Critical, "Admin Log In")
                    Username.Text = ""
                    Password.Text = ""
                Else
                    AdminDashboardFinal2.UserID.Text = Username.Text
                    MsgBox("Welcome " & Username.Text & "!", MsgBoxStyle.Information, "Logging In")
                    AdminDashboardFinal2.Show()
                    Me.Close()
                End If
            End Using
        End Using
        conn.Close()
    End Sub

    Private Sub AdminLoginFinal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class