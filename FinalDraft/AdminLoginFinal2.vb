Imports MySql.Data.MySqlClient
Public Class AdminLoginFinal2
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Dim usertable As New DataTable

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Using obj As New MySqlCommand("SELECT * FROM admintbl WHERE UserID = @username AND Password_ = @password", conn)
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
                    Dim Vf As New AdminDashboardFinal2
                    With Vf
                        '.User.Text = Username.Text
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

    Private Sub AdminLoginBtn_Click(sender As Object, e As EventArgs) Handles AdminLoginBtn.Click
        Dim Uf As New UserLoginFinal2
        With Uf
            .Username.Text = ""
            .Password.Text = ""
            '.ShowDialog()
            UserLoginFinal2.Show()
            Me.Close()
        End With
    End Sub

    Private Sub LoginBtn_Click(sender As Object, e As EventArgs) Handles LoginBtn.Click

    End Sub
End Class