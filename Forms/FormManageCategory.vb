Imports MySql.Data.MySqlClient
Public Class FormManageCategory
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Dim usertable As New DataTable
    Private Sub VehiclecategorytblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehiclecategorytblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ParkingdbDataSet)

    End Sub

    Private Sub FormManageCategory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        sql = "SELECT DISTINCT Type FROM vehiclecategorytbl"
        Try
            conn.Open()
            dbcomm = New MySqlCommand(sql, conn)
            dbread = dbcomm.ExecuteReader()
            usertable.Load(dbread)
            TypeComboBox.ValueMember = "Type"
            TypeComboBox.DisplayMember = "Type"
            TypeComboBox.DataSource = usertable
            TypeComboBox1.ValueMember = "Type"
            TypeComboBox1.DisplayMember = "Type"
            TypeComboBox1.DataSource = usertable
            dbread.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        Dim result2 As MsgBoxResult = MsgBox("Are you sure you want to add the category?", MessageBoxButtons.YesNo, "Adding Category")
        If result2 = MsgBoxResult.Yes Then
            sql = "INSERT INTO vehiclecategorytbl VALUES ('111', '" & NewCategoryBox.Text.ToUpper & "', '" & TypeComboBox1.Text & "')"
            conn.Open()
            Try
                dbcomm = New MySqlCommand(sql, conn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
                MsgBox("Category Inserted.", MsgBoxStyle.Information, "Inserting New Category")
                NewCategoryBox.Text = ""
                Me.VehiclecategorytblTableAdapter.Fill(Me.ParkingdbDataSet.vehiclecategorytbl)
            Catch ex As Exception
                MsgBox("Failed To insert data: " & ex.Message.ToString())
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub ManageBtn_Click(sender As Object, e As EventArgs) Handles ManageBtn.Click
        Dim result1 As MsgBoxResult = MsgBox("Are you sure you want to update the category?", MessageBoxButtons.YesNo, "Updating Category")
        If result1 = MsgBoxResult.Yes Then
            sql = "UPDATE vehiclecategorytbl SET Category = '" & UpdateCategoryBox.Text.ToUpper & "' WHERE Category = '" & CategoryComboBox.Text & "' AND Type = '" & TypeComboBox1.Text & "'"
            conn.Open()
            Try
                dbcomm = New MySqlCommand(sql, conn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
                MsgBox("Category Inserted.", MsgBoxStyle.Information, "Inserting New Category")
                UpdateCategoryBox.Text = ""
                CategoryComboBox.Text = ""
                Me.VehiclecategorytblTableAdapter.Fill(Me.ParkingdbDataSet.vehiclecategorytbl)
            Catch ex As Exception
                MsgBox("Failed To insert data: " & ex.Message.ToString())
            End Try
            conn.Close()
        End If
    End Sub

    Private Sub RemoveBtn_Click(sender As Object, e As EventArgs) Handles RemoveBtn.Click
        Dim result3 As MsgBoxResult = MsgBox("Are you sure you want to remove the category?", MessageBoxButtons.YesNo, "Removing Category")
        If result3 = MsgBoxResult.Yes Then
            sql = "DELETE FROM vehiclecategorytbl WHERE Category = '" & ComboBox1.Text & "'"
            conn.Open()
            Try
                dbcomm = New MySqlCommand(sql, conn)
                dbread = dbcomm.ExecuteReader()
                dbread.Close()
                MsgBox("Category Deleted.", MsgBoxStyle.Information, "Deleting Category")
                UpdateCategoryBox.Text = ""
                CategoryComboBox.Text = ""
                Me.VehiclecategorytblTableAdapter.Fill(Me.ParkingdbDataSet.vehiclecategorytbl)
            Catch ex As Exception
                MsgBox("Failed To delete category: " & ex.Message.ToString())
            End Try
            conn.Close()
        End If
    End Sub
End Class