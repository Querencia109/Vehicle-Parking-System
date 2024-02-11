Imports MySql.Data.MySqlClient
Public Class UserLoginFinal2
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Dim usertable As New DataTable

    Private Sub AdminLoginBtn_Click(sender As Object, e As EventArgs) Handles AdminLoginBtn.Click
        Dim Vf As New AdminLoginFinal2
        With Vf
            .Username.Text = ""
            .Password.Text = ""
            '.ShowDialog()
            AdminLoginFinal2.Show()
            Me.Close()
        End With
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Using obj As New MySqlCommand("SELECT * FROM usertbl WHERE UserID = @username AND Password_ = @password", conn)
            obj.Parameters.Add("@username", MySqlDbType.String).Value = Username.Text
            obj.Parameters.Add("@password", MySqlDbType.String).Value = Password.Text

            Using objadapter As New MySqlDataAdapter(obj)
                usertable.Clear()
                objadapter.Fill(usertable)

                If usertable.Rows.Count = Nothing Then
                    MsgBox("No Input or Wrong User ID or Password", MsgBoxStyle.Critical, "User Log In")
                    Username.Text = ""
                    Password.Text = ""
                Else
                    Dim Add As New FormAddVehicle
                    Dim Uf As New UserDashboardFinal2
                    With Uf
                        With Add
                            .UserIDlbl.Text = Username.Text
                        End With
                        MessageBox.Show("Welcome " & Username.Text & "!")
                            '.ShowDialog()
                            UserDashboardFinal2.Show()
                            Me.Close()
                        End With
                End If
            End Using
        End Using
        conn.Close()
    End Sub

    Private Sub UserLoginFinal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub
End Class