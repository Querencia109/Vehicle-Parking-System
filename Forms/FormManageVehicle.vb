Imports MySql.Data.MySqlClient
Public Class FormManageVehicle
    Dim conn As New MySqlConnection
    Public sql As String
    Public dbcomm As New MySqlCommand
    Public dbread As MySqlDataReader
    Dim usertable As New DataTable
    Private Sub FormOverview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.ControlBox = False
        Me.AutoSize = False
        disabletextbox()
        conn.ConnectionString = ("Data Source=localhost;user id=root;password=ManjaresEj109;database=parkingdb")
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub cleartextbox()
        Foundlbl.Text = ""
        ParkingIDBox.Text = ""
        VehicleCategoryBox.Text = ""
        PlateNumberBox.Text = ""
        DateInBox.Text = ""
        TimeInBox.Text = ""
        TimeOutBox.Text = ""
        StatusBox.Text = ""
        ParkingChargeBox.Text = ""
        PaymentMethodBox.Text = ""
        RemarksBox.Text = ""
    End Sub

    Sub disabletextbox()
        ParkingIDBox.Enabled = False
        VehicleCategoryBox.Enabled = False
        PlateNumberBox.Enabled = False
        DateInBox.Enabled = False
        TimeInBox.Enabled = False
        TimeOutBox.Enabled = False
        StatusBox.Enabled = False
        ParkingChargeBox.Enabled = False
        PaymentMethodBox.Enabled = False
        RemarksBox.Enabled = False
    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        ParkingIDBox.ReadOnly = True
        VehicleCategoryBox.ReadOnly = True
        PlateNumberBox.ReadOnly = True
        DateInBox.ReadOnly = True
        TimeInBox.ReadOnly = True
        TimeOutBox.ReadOnly = True
        StatusBox.ReadOnly = True
        ParkingChargeBox.ReadOnly = True
        PaymentMethodBox.Enabled = True
        RemarksBox.Enabled = True
        Try
            cleartextbox()
            sql = "SELECT * FROM vehicletbl WHERE PlateNum = '" & SearchBox.Text & "' OR ParkingID = '" & SearchBox.Text & "'"
            Dim da As New MySqlDataAdapter(sql, conn)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            VehicleTable.DataSource = dt
            If dt.Rows.Count > 0 Then
                Foundlbl.Text = "VEHICLE " & SearchBox.Text.ToUpper & " FOUND"
                ParkingIDBox.Text = (VehicleTable.CurrentRow.Cells(0).Value)
                VehicleCategoryBox.Text = (VehicleTable.CurrentRow.Cells(1).Value)
                PlateNumberBox.Text = (VehicleTable.CurrentRow.Cells(2).Value)
                DateInBox.Text = (VehicleTable.CurrentRow.Cells(3).Value)
                TimeInBox.Text = (VehicleTable.CurrentRow.Cells(4).Value)
                TimeOutBox.Text = Date.Now.ToString("hh:mm:ss tt")
                StatusBox.Text = "OUTGOING VEHICLE"

                Dim edate1 = TimeInBox.Text
                Dim edate2 = TimeOutBox.Text

                Dim oDate1 As DateTime = Convert.ToDateTime(edate1)
                Dim oDate2 As DateTime = Convert.ToDateTime(edate2)

                minus.Text = DateDiff(DateInterval.Hour, oDate1, oDate2)
                If minus.Text <= 3 Then
                    ParkingChargeBox.Text = "50 Pesos"
                ElseIf minus.Text > 3 Then
                    ParkingChargeBox.Text = "100 Pesos"
                End If
                Remarksbox.Text = (VehicleTable.CurrentRow.Cells(9).Value)
                PaymentMethodBox.Text = (VehicleTable.CurrentRow.Cells(8).Value)
            Else
                    MsgBox("No Such Car Found", MsgBoxStyle.Critical, "Search Record")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub VehicletblBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehicletblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ParkingdbDataSet)

    End Sub

    Private Sub VehicletblBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehicletblBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ParkingdbDataSet)

    End Sub

    Private Sub ParkingIDBox_TextChanged(sender As Object, e As EventArgs) Handles ParkingIDBox.TextChanged

    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        Dim result As MsgBoxResult = MsgBox("Are you sure you want to update the record?", MessageBoxButtons.YesNo, "Updating Record")
        If result = MsgBoxResult.Yes Then
            Try
                conn.Open()
                If ParkingChargeBox.Text = "" Or PaymentMethodBox.Text = "" Then
                    MsgBox("Input Necessary Record/s", MsgBoxStyle.Critical, "Manage Record")
                Else
                    Dim myCommand As New MySqlCommand
                    Dim myAdapter As New MySqlDataAdapter
                    sql = "UPDATE vehicletbl 
                    SET TimeOut = '" & TimeOutBox.Text & "', 
                        VehicleStatus = '" & StatusBox.Text & "', 
                        ParkingCharge = '" & ParkingChargeBox.Text & "', 
                        PaymentMethod = '" & PaymentMethodBox.Text & "', 
                        Remarks = '" & Remarksbox.Text & "' 
                        WHERE PlateNum = '" & SearchBox.Text & "' 
                        OR ParkingID = '" & SearchBox.Text & "'"
                    myCommand.CommandText = sql
                    dbcomm = New MySqlCommand(sql, conn)
                    dbread = dbcomm.ExecuteReader()
                    dbread.Close()

                    disabletextbox()

                    sql = "INSERT INTO adminrecordtbl(UserID,Action_Performed,Date_Performed,Time_Performed) VALUES('" & UserDashboardFinal2.UserID.Text & "', 'Modified Record', current_date, TIME_FORMAT(current_time,'%r'))"
                    Try
                        dbcomm = New MySqlCommand(sql, conn)
                        dbread = dbcomm.ExecuteReader()
                        dbread.Close()
                    Catch ex As Exception
                        MsgBox("Failed to insert data to admin record: " & ex.Message.ToString())
                    End Try
                    conn.Close()
                End If
            Catch ex As Exception
                MsgBox("failed to insert data " & ex.Message.ToString())
            End Try
            cleartextbox()
            SearchBox.Text = ""
        End If
    End Sub
End Class