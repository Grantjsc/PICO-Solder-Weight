Imports System.Data.OleDb
Imports System.IO.Ports

Module SameLotQuery_Module
    Public myconnection As OleDbConnection = New OleDbConnection
    Sub Connect()
        myconnection.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")
    End Sub

    Sub RecordHistory()
        Connect()
        Dim mycommand As String
        Dim wt As String = Form1.txtWeight.Text
        Dim lot As String = Form1.txtLotNo.Text

        If Form1.txtWeight.Text = "" Then
            MsgBox("Please enter weight!", MessageBoxIcon.Error)
        ElseIf Form1.txtLotNo.Text = "" Then
            MsgBox("Please enter lot number!", MessageBoxIcon.Error)
        Else
            Try
                myconnection.Open()
                mycommand = "INSERT INTO [LotHistory_tb] ([Lot_Number], [Weight_mg]) VALUES (@lotnumber,@weight)"
                Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                    cmd.Parameters.AddWithValue("@lotnumber", lot)
                    cmd.Parameters.AddWithValue("@weight", wt)
                    cmd.ExecuteNonQuery()
                End Using
                myconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Sub RecordLotChecking()
        Connect()
        Dim mycommand As String
        Dim RealLot As String = Form1.txtLotNo.Text & Form1.txtWeight.Text

        If Form1.txtWeight.Text = "" Then
            MsgBox("Please enter weight!", MessageBoxIcon.Error)
        ElseIf Form1.txtLotNo.Text = "" Then
            MsgBox("Please enter lot number!", MessageBoxIcon.Error)
        Else

            Try
                myconnection.Open()
                mycommand = "INSERT INTO [LotChecking_tb] ([Lot_Number]) VALUES (@lotnumber)"
                Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                    cmd.Parameters.AddWithValue("@lotnumber", RealLot)
                    cmd.ExecuteNonQuery()
                End Using
                myconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical)
            End Try
        End If
    End Sub

    Sub CheckLotNumber()
        Dim lot As String
        Dim RealLot As String = Form1.txtLotNo.Text & Form1.txtWeight.Text

        Try
            Connect()
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            myconnection.Open()

            MyData = "SELECT * From LotChecking_tb WHERE Lot_Number = '" + RealLot + "'"
            cmd.Connection = myconnection
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                lot = Data.Rows(0).Item("Lot_Number").ToString
                'Console.WriteLine(lot)
                'MsgBox("Lot number already exist!", MsgBoxStyle.Critical)

                SameLot_Form.ShowDialog()

            Else
                myconnection.Close()
                RecordLotChecking()
                RecordHistory()

                Form1.txtSolderWire.Focus()
                Form1.txtLotNo.ReadOnly = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            myconnection.Close()
        End Try
    End Sub
End Module

Module SameLotCondition_Module
    Public InterruptionCheck As Boolean = False
    Sub SamelotNo()
        Form1.txtQty.Text = ""
        Form1.txtQty.ReadOnly = False

        Form1.txtWeight.ReadOnly = False
        Form1.txtWeight.Text = "Enter weight"
        Form1.txtWeight.ForeColor = Color.Silver

        Form1.txtPartNo.ReadOnly = False
        Form1.txtPartNo.Text = "Enter Part Number"
        Form1.txtPartNo.ForeColor = Color.Silver

        Form1.txtEmployee.Text = "Samples"
        Form1.txtEmployee.ForeColor = Color.Silver

        Form1.txtLotNo.ReadOnly = False
        Form1.txtLotNo.Text = "Enter Lot Number"
        Form1.txtLotNo.ForeColor = Color.Silver

        Form1.txtQty.Focus()
        SameLot_Form.Close()
    End Sub

    Sub SamelotYes()
        askInterruption_Form.ShowDialog()
    End Sub

    Sub InterruptionYes()
        Dim NewQty As Integer
        NewQty = CInt(Form1.txtQty.Text) - CInt(SolderCutter_Form.lblC2counter.Text)
        Form1.txtQty.Text = NewQty
        Form1.txtSolderWire.Focus()
        InterruptionCheck = True
        askInterruption_Form.Close()
    End Sub

    Sub InterruptionNo()
        Form1.txtQty.Text = ""
        Form1.txtQty.ReadOnly = False

        Form1.txtWeight.ReadOnly = False
        Form1.txtWeight.Text = "Enter weight"
        Form1.txtWeight.ForeColor = Color.Silver

        Form1.txtPartNo.ReadOnly = False
        Form1.txtPartNo.Text = "Enter Part Number"
        Form1.txtPartNo.ForeColor = Color.Silver

        Form1.txtEmployee.Text = "Samples"
        Form1.txtEmployee.ForeColor = Color.Silver

        Form1.txtLotNo.ReadOnly = False
        Form1.txtLotNo.Text = "Enter Lot Number"
        Form1.txtLotNo.ForeColor = Color.Silver

        Form1.txtQty.Focus()
        askInterruption_Form.Close()
    End Sub

    Sub BuyOffYes()
        Dim Fngerprint = False
        While Fngerprint = False
            'SolderCutter_Form.to_PLC("@00WD00000000")
            Master_login.Label1.Text = "For Buy-off, please scan your finger. SPC, PO3 or Production only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "Production" Then
                Master_login.Close()
                Fngerprint = True
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End While
    End Sub

End Module