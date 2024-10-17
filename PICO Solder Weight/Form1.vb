Imports System.Collections.ObjectModel
Imports System.ComponentModel.Design
Imports System.Data.OleDb
Imports System.Threading
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.Timers

Public Class Form1

    Public txt As String
    Public retext As String

    Public data(5000) As Decimal
    Public count As Integer
    Public param As String
    Public RealData As String

    Public port1 As String

    Public Sub Get_portname()
        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")


        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            con.Open()

            MyData = "SELECT * From SerialPort_tb WHERE sname Like 'Serial1' "
            cmd.Connection = con
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then
                port1 = Data.Rows(0).Item("portname").ToString
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()

        End Try

    End Sub
    Public Sub SerialName()
        SerialPort1.PortName = port1
    End Sub

    Public Weight As Decimal = 0.00
    Public stopwatch As New Stopwatch()
    Public isTimerRunning As Boolean = False



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Windows.Forms.Control.CheckForIllegalCrossThreadCalls = False

        'Get_portname()
        'SerialName()
        'SerialPort1.Open()
        'SerialPort1.WriteLine("Z")

        btnNewLot.Enabled = False
        btnWeight.Enabled = False
        btnSave.Enabled = False
        btnReset.Enabled = True

        'Timer1.Enabled = True
        Timer2.Enabled = True

        If Not TimerPLC.Enabled = True Then
            TimerPLC.Enabled = True
        End If

        to_PLC("@00WD01070000") 'Software is Open

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If RealData > 0.1 Then
            If RealData > Weight Then
                Weight = RealData
                stopwatch.Restart()
            ElseIf RealData = 0.00 AndAlso isTimerRunning Then
                stopwatch.Stop()
                Weight = 0.00
                isTimerRunning = False
            ElseIf RealData > 0.00 Then
                isTimerRunning = True
            End If

            If stopwatch.ElapsedMilliseconds >= 4000 Then

                SerialPort1.WriteLine("SP")
                Thread.Sleep(100)

                data(count) = RealData
                count += 1
                lstResult.Items.Add(count & ". " & RealData)
                lstResult.SelectedIndex = lstResult.Items.Count - 1
                btnReset.Enabled = False



                stopwatch.Stop()
                Weight = 0.00
                isTimerRunning = False

                Timer1.Enabled = False
                SerialPort1.WriteLine("Z")
                Thread.Sleep(500)
                SerialPort1.WriteLine("CP")

                If count = CInt(txtEmployee.Text) Then
                    btnNewLot.Enabled = True
                    btnWeight.Enabled = False
                    btnSave.Enabled = True
                    btnReset.Enabled = False
                    btnSave.Focus()

                    Timer1.Enabled = False
                    SerialPort1.WriteLine("Z")

                    MsgBox("DONE!", MsgBoxStyle.Information)
                    txtReading.Text = ""
                    SerialPort1.Close()

                End If
            End If
        Else

        End If
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        txt = SerialPort1.ReadLine

        txt = txt.Replace(" ", "")
        txt = txt.Replace("?", "")
        txt = txt.Replace("N", "")
        txt = txt.Replace(vbCr, "")
        txt = txt.Replace(vbLf, "")
        txt = txt.Replace("-OHAUS-", "")

        'If txt.Length >= 2 Then
        '    RealData = txt.Substring(0, txt.Length - 2)
        'Else
        '    Console.WriteLine("Error!")
        'End If

        Dim regex As New Regex("-?\d+(\.\d+)?")

        Dim matches As MatchCollection = regex.Matches(txtReading.Text)
        For Each match As Match In matches
            Console.WriteLine(match.Value)

            RealData = match.Value
        Next


        txtReading.Text = txt

        'Console.WriteLine(SerialPort1.ReadLine)
        'Console.WriteLine(RealData)


        If Timer1.Enabled = False And RealData = 0.00 And RealData > -0.1 Then
            Invoke(Sub()
                       Timer1.Enabled = True
                   End Sub)
        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If lblDoor_110.Text = 1 Then

            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you really want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
                e.Cancel = True
            Else

                to_PLC("@00WD01070000") 'Door locked
                to_PLC("@00WD01070000") 'Software is close

                Application.ExitThread()
            End If

        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Kindly close the door.", "PICO Solder Cutter", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If dialog = DialogResult.OK Then
                e.Cancel = True
            End If
            'DoorOpen_Form.ShowDialog()
        End If
    End Sub

    Private Sub txtPartNo_Enter(sender As Object, e As EventArgs) Handles txtPartNo.Enter
        If txtPartNo.Text = "Enter Part Number" Then

            txtPartNo.Text = ""
            txtPartNo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPartNo_Leave(sender As Object, e As EventArgs) Handles txtPartNo.Leave
        If txtPartNo.Text = "" Then

            txtPartNo.Text = "Enter Part Number"
            txtPartNo.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtEmployee_Enter(sender As Object, e As EventArgs) Handles txtEmployee.Enter
        If txtEmployee.Text = "Employee" Then

            txtEmployee.Text = ""
            txtEmployee.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtEmployee_Leave(sender As Object, e As EventArgs) Handles txtEmployee.Leave
        If txtEmployee.Text = "" Then

            txtEmployee.Text = "Samples"
            txtEmployee.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtLotNo_Enter(sender As Object, e As EventArgs) Handles txtLotNo.Enter
        If txtLotNo.Text = "Enter Lot Number" Then

            txtLotNo.Text = ""
            txtLotNo.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtLotNo_Leave(sender As Object, e As EventArgs) Handles txtLotNo.Leave
        If txtLotNo.Text = "" Then

            txtLotNo.Text = "Enter Lot Number"
            txtLotNo.ForeColor = Color.Silver
        End If
    End Sub


    Public Sub CheckPartNo()

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")
        Dim inputText As String = txtPartNo.Text.Trim()

        If String.IsNullOrEmpty(inputText) Then
            MessageBox.Show("Please enter Part Number")
            Return
        End If

        Try
            con.Open()

            Dim query As String = "SELECT * FROM SolderWeight_tb WHERE barcode_partnum = @inputText"
            Using cmd As New OleDbCommand(query, con)
                cmd.Parameters.AddWithValue("@inputText", inputText)

                Dim result As Integer = CInt(cmd.ExecuteScalar())

                If result > 0 Then
                    cboProcess.Focus()
                    EmployeeBasis()
                    txtPartNo.ReadOnly = True
                Else
                    MessageBox.Show("It does not exist in the database.")
                    txtPartNo.Text = ""
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Process()

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")
        con.Open()
        Dim df As String = "select process from Process_tb"
        Dim cmd As New OleDbCommand(df, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Try

            While dr.Read
                cboProcess.Items.Add(dr("process").ToString)
            End While
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try


    End Sub
    Public infi As String
    Public Sub EmployeeBasis()

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")


        Try
            Dim MyData As String
            Dim cmd As New OleDbCommand
            Dim Data As New DataTable
            Dim adap As New OleDbDataAdapter
            con.Open()

            MyData = "SELECT * From SolderWeight_tb WHERE barcode_partnum = '" + txtPartNo.Text + "'"
            cmd.Connection = con
            cmd.CommandText = MyData
            adap.SelectCommand = cmd

            adap.Fill(Data)

            If Data.Rows.Count > 0 Then

                txtEmployee.Text = Data.Rows(0).Item("_sample").ToString
                txtEmployee.ForeColor = Color.Black
                infi = Data.Rows(0).Item("part_number").ToString
                'Console.WriteLine(infi)
                txtLotNo.Focus()
                txtPartNo.ReadOnly = True
            Else
                MsgBox("Part number does not exist in the database.", MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub Shift()
        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")
        con.Open()
        Dim df As String = "select shift from shift_tb"
        Dim cmd As New OleDbCommand(df, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Try

            While dr.Read
                cboShift.Items.Add(dr("shift").ToString)
            End While
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try
    End Sub

    Public Sub Associate()

        Dim con As OleDbConnection = New OleDbConnection
        con.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder")
        con.Open()
        Dim df As String = "select associate from associate_tb"
        Dim cmd As New OleDbCommand(df, con)
        Dim dr As OleDbDataReader
        dr = cmd.ExecuteReader
        Try

            While dr.Read
                cboAssociate.Items.Add(dr("associate").ToString)
            End While
            con.Close()


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)

        End Try

    End Sub

    Private Sub txtPartNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPartNo.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtPartNo.Text = "" Then
                MsgBox("Please enter Part Number!", MsgBoxStyle.Exclamation)
                txtPartNo.Text = ""
            Else
                'CheckPartNo()
                EmployeeBasis()
                'txtPartNo.Enabled = False
            End If
        End If
    End Sub

    Private Sub cboProcess_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboProcess.SelectedIndexChanged
        Process()
    End Sub

    Private Sub cboProcess_MouseClick(sender As Object, e As MouseEventArgs) Handles cboProcess.MouseClick
        cboProcess.Items.Clear()
        Process()
    End Sub

    Private Sub txtEmployee_KeyUp(sender As Object, e As KeyEventArgs) Handles txtEmployee.KeyUp
        If e.KeyCode = Keys.Enter Then
            EmployeeBasis()
        End If
    End Sub

    Private Sub cboShift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShift.SelectedIndexChanged
        Shift()
    End Sub

    Private Sub cboShift_MouseClick(sender As Object, e As MouseEventArgs) Handles cboShift.MouseClick
        cboShift.Items.Clear()
        Shift()
    End Sub

    Private Sub txtLotNo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLotNo.KeyUp
        If e.KeyCode = Keys.Enter Then

            If txtLotNo.Text = "" Then
                MsgBox("Please enter Lot Number!", MsgBoxStyle.Exclamation)
                txtLotNo.Text = ""
            Else
                cboShift.Focus()
                txtLotNo.ReadOnly = True
            End If
        End If
    End Sub

    Private Sub cboAssociate_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAssociate.SelectedIndexChanged

        If txtPartNo.Text = "" Or txtPartNo.Text = "Enter Part Number" Then
            cboAssociate.Text = Nothing
            MsgBox("Please enter Part Number!", MsgBoxStyle.Exclamation)
        ElseIf cboProcess.Text = "" Then
            cboAssociate.Text = Nothing
            MsgBox("Please enter process!", MsgBoxStyle.Exclamation)
        ElseIf cboShift.Text = "" Then
            cboAssociate.Text = Nothing
            MsgBox("Please enter your shift!", MsgBoxStyle.Exclamation)
        ElseIf txtLotNo.Text = "" Or txtPartNo.Text = "Enter Lot Number" Then
            cboAssociate.Text = Nothing
            MsgBox("Please enter Lot Numbwe!", MsgBoxStyle.Exclamation)
        Else

            to_PLC("@00WD01070000") 'Door unlocked

            Associate()

                'btnWeight.Focus()
                SerialPort1.Open()

                SerialPort1.WriteLine("Z")
                Thread.Sleep(500)
                SerialPort1.WriteLine("CP")
                Timer1.Enabled = True

                btnWeight.Enabled = True
                btnWeight.Focus()
            End If
    End Sub

    Private Sub cboAssociate_MouseClick(sender As Object, e As MouseEventArgs) Handles cboAssociate.MouseClick
        cboAssociate.Items.Clear()
        Associate()
    End Sub

    Private Sub cboProcess_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboProcess.SelectedValueChanged

        cboAssociate.Focus()
    End Sub

    Private Sub cboShift_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboShift.SelectedValueChanged

        cboProcess.Focus()
    End Sub

    'Private Sub cboAssociate_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboAssociate.SelectedValueChanged

    '    btnWeight.Enabled = True
    '    btnWeight.Focus()

    '    SerialPort1.WriteLine("CP")
    '    Timer1.Start()
    'End Sub

    Private Sub btnNewLot_Click(sender As Object, e As EventArgs) Handles btnNewLot.Click

        btnNewLot.Enabled = False
        btnWeight.Enabled = False
        btnSave.Enabled = False
        btnReset.Enabled = True

        btnReset.Visible = True
        btnEnable.Visible = False

        count = 0
        lstResult.Items.Clear()

        txtPartNo.ReadOnly = False
        txtPartNo.Text = "Enter Part Number"
        txtPartNo.ForeColor = Color.Silver
        cboProcess.Text = Nothing

        txtEmployee.Text = "Employee"
        txtEmployee.ForeColor = Color.Silver
        cboShift.Text = Nothing

        txtLotNo.ReadOnly = False
        txtLotNo.Text = "Enter Lot Number"
        txtLotNo.ForeColor = Color.Silver
        cboAssociate.Text = Nothing

        Timer1.Enabled = False

        txtReading.Text = ""
        Array.Clear(data, 0, data.Length)

        txtPartNo.Focus()
    End Sub

    Private Sub btnWeight_Click(sender As Object, e As EventArgs) Handles btnWeight.Click
        '------------------- OHOUS weighing scale --------------------

        ' IP = Immediate Print of displayed weight (stable or unstable)
        ' P = Print displayed weight (stable or unstable). 
        ' PSN = Serial Number
        ' SP = Print on Stability
        ' Z = Same as pressing Zero Key
        ' T = Same as pressing Tare Key
        ' CP = Continuous Print

        If txtPartNo.Text = "" Or txtPartNo.Text = "Enter Part Number" Then
            MsgBox("Please enter Part Number!", MsgBoxStyle.Exclamation)
        ElseIf cboProcess.Text = "" Then
            MsgBox("Please enter process!", MsgBoxStyle.Exclamation)
        ElseIf cboShift.Text = "" Then
            MsgBox("Please enter your shift!", MsgBoxStyle.Exclamation)
        ElseIf txtLotNo.Text = "" Or txtPartNo.Text = "Enter Lot Number" Then
            MsgBox("Please enter Lot Numbwe!", MsgBoxStyle.Exclamation)
        Else

            SerialPort1.WriteLine("SP")
            Thread.Sleep(100)

            data(count) = RealData
            count += 1
            lstResult.Items.Add(count & ". " & RealData)
            btnReset.Enabled = False
            If count = CInt(txtEmployee.Text) Then
                btnNewLot.Enabled = True
                btnWeight.Enabled = False
                btnSave.Enabled = True
                btnReset.Enabled = False
                btnSave.Focus()

                MsgBox("DONE!", MsgBoxStyle.Information)
            End If

            Thread.Sleep(100)
            SerialPort1.WriteLine("CP")

        End If

    End Sub

    Private Sub btnWeight_KeyDown(sender As Object, e As KeyEventArgs) Handles btnWeight.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnWeight.FillColor = Color.RoyalBlue


            If txtPartNo.Text = "" Or txtPartNo.Text = "Enter Part Number" Then
                MsgBox("Please enter Part Number!", MsgBoxStyle.Exclamation)
            ElseIf cboProcess.Text = "" Then
                MsgBox("Please enter process!", MsgBoxStyle.Exclamation)
            ElseIf cboShift.Text = "" Then
                MsgBox("Please enter your shift!", MsgBoxStyle.Exclamation)
            ElseIf txtLotNo.Text = "" Or txtPartNo.Text = "Enter Lot Number" Then
                MsgBox("Please enter Lot Numbwe!", MsgBoxStyle.Exclamation)
            Else

                SerialPort1.WriteLine("SP")
                Thread.Sleep(100)
                data(count) = RealData
                count += 1
                lstResult.Items.Add(count & ". " & RealData)
                btnReset.Enabled = False
                If count = CDec(txtEmployee.Text) Then
                    btnNewLot.Enabled = False
                    btnWeight.Enabled = False
                    btnSave.Enabled = True
                    btnReset.Enabled = False
                    btnSave.Focus()
                    MsgBox("DONE!")
                End If
                Thread.Sleep(100)
                SerialPort1.WriteLine("CP")
                btnWeight.FillColor = Color.White
            End If
        End If
    End Sub

    'Public get_FolderPath2 As String = "\\lffile001\infinity\Philippines\Nano Log\" & dateNtime & "Nano Selas temp.csv"

    'C:\Users\gcatapang\OneDrive - Littelfuse, Inc\Desktop\Selas
    'C:\Users\gcatapang\OneDrive - Littelfuse, Inc\Desktop\Selas Backup

    '\\lffile001\infinity\Philippines\Buffer File\PICO

    Public dateNtime As String = DateTime.Now.ToString("yyyy_MM_dd_HHmmtt ")

    Public get_FolderPath As String = "\\lffile001\infinity\Philippines\Buffer File\PICO\PICO Solder Weight.csv"
    'Public get_FolderPath2 As String = "\\lffile001\infinity\Philippines\Nano Log\PICO Solder Weight.csv"
    Public get_message As String
    Public get_message2 As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If lblDoor_110.Text = 1 Then
            Dim isFileEmpty As Boolean = IsCSVFileEmpty(get_FolderPath)
            get_message = """Part Number,""" & "," & """Process,""" & "," & """Pico-Shift,""" & "," & """Pico-Lot Number,""" & "," & """Pico Premelt Associate,""" & "," & """Solder Weight,""" & vbCrLf
            'get_message2 = """Part Number,""" & "," & """Process,""" & "," & """Pico-Shift,""" & "," & """Pico-Lot Number,""" & "," & """Pico Premelt Associate,""" & "," & """Solder Weight,""" & "," & """Date and Time,""" & vbCrLf
            Try
                If isFileEmpty Then
                    For n As Integer = 0 To data.Length - 1
                        If data(n) > 0 Then
                            get_message = get_message & infi & "," & cboProcess.Text & "," & cboShift.Text & "," & txtLotNo.Text & "," & cboAssociate.Text & "," & data(n).ToString & vbCrLf
                            'get_message2 = get_message2 & txtPartNo.Text & "," & cboProcess.Text & "," & cboShift.Text & "," & txtLotNo.Text & "," & cboAssociate.Text & "," & data(n).ToString & "," & dateNtime & vbCrLf
                        End If
                    Next
                    My.Computer.FileSystem.WriteAllText(get_FolderPath, get_message, False)
                    'My.Computer.FileSystem.WriteAllText(get_FolderPath2, get_message, True)
                    MessageBox.Show("The data is saved in " & get_FolderPath)
                    btnNewLot.Enabled = True
                    btnSave.Enabled = False

                    Timer1.Enabled = False

                    btnEnable.Visible = True
                    btnReset.Visible = False

                    btnEnable.Focus()


                    'txtReading.Text = ""
                    'SerialPort1.Close()

                    to_PLC("@00WD01070000") 'Door locked

                Else

                    MessageBox.Show("Cannot Proceed Saving!!! There is a file for upload at Infinity." & vbNewLine & "Please add the data In Infinity, then click Save.", "PICO Solder Weight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Catch ex As Exception
                MsgBox(ex, vbCritical)
            End Try

        Else
            MessageBox.Show("The door is still open. Kindly close the door.", "PICO Solder Weight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Function IsCSVFileEmpty(filePath As String) As Boolean
        ' Check if the file exists
        If File.Exists(filePath) Then
            ' Read the entire file content as a string
            Dim fileContent As String = File.ReadAllText(filePath)
            ' Check if the file content contains any non-whitespace characters
            Return String.IsNullOrWhiteSpace(fileContent)
        Else
            ' File doesn't exist, so it's considered empty
            Return True
        End If
    End Function

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you want to clear Lot Details ?", "CLear Lot Details", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.Yes Then

            'cboAssociate.Enabled = True
            'cboShift.Enabled = True
            'cboProcess.Enabled = True

            count = 0
            lstResult.Items.Clear()

            txtPartNo.ReadOnly = False
            txtPartNo.Text = "Enter Part Number"
            txtPartNo.ForeColor = Color.Silver
            cboProcess.Text = Nothing

            txtEmployee.Text = "Samples"
            txtEmployee.ForeColor = Color.Silver
            cboShift.Text = Nothing

            txtLotNo.ReadOnly = False
            txtLotNo.Text = "Enter Lot Number"
            txtLotNo.ForeColor = Color.Silver
            cboAssociate.Text = Nothing

        Else
            Return
        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblDate.Text = Date.Now.ToString("MMM dd, yyyy")
        lblTime.Text = Date.Now.ToString("hh:mm tt")
    End Sub

    Private Sub btnEnable_Click(sender As Object, e As EventArgs) Handles btnEnable.Click
        btnSave.Enabled = True
        btnEnable.Visible = False
        btnReset.Visible = True
        btnSave.Focus()
    End Sub

    'Public DoorSignal As String
    'Public DoorState As Boolean = True

    Private Sub SerialPort2_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort2.DataReceived

    End Sub

    '******************* PLC Door Lock Connection ***********************

    Public TX As String
    Public FCS As String
    Public RXD As String

    Private Sub TimerPLC_Tick(sender As Object, e As EventArgs) Handles TimerPLC.Tick
        TimerPLC.Enabled = False
        'Display current date and time
        'timetoday.Text = System.DateTime.Now
        Try
            If SerialPort2.IsOpen = False Then
                SerialPort2.Open()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & vbCr & "Connect to PLC Error!", vbCritical)
            End
        End Try
        'Check DM AREA DM486 data update; range: 9
        TX = "@00RD01050006"
        GetFCS()
        'Console.WriteLine(FCS)
        communicate()
        SerialPort2.Close()
        ' Set information on the screen

        'Console.WriteLine(RXD)
        'lblPurge105.Text = RXD.Substring(7, 4) 'CInt("&H" & RXD.Substring(7, 4))
        'lblSamples106.Text = RXD.Substring(11, 4) 'CInt("&H" & RXD.Substring(11, 4))
        'lblSpool107.Text = RXD.Substring(15, 4)
        'lblQty108.Text = RXD.Substring(19, 4)
        'lblQty109.Text = RXD.Substring(23, 4)
        lblDoor_110.Text = RXD.Substring(27, 4)

        'lblC2counter.Text = (CInt(RXD.Substring(23, 4) & RXD.Substring(19, 4))).ToString("N0")

        ''actl_qty_lbl.Text = (CInt(RXD.Substring(15, 4))).ToString("N0")
        'actl_tray_qty_lbl.Text = (CInt(RXD.Substring(19, 4))).ToString("N0")
        'actl_qty_lbl.Text = ((CDec(RXD.Substring(19, 4))) * slide_qty).ToString("N0")
        'PLC_alarm = CInt(RXD.Substring(23, 4))
        'temp1_plus_offset = CInt(RXD.Substring(27, 4))
        'temp1_neg_offset = CInt(RXD.Substring(31, 4))
        'temp2_plus_offset = CInt(RXD.Substring(35, 4))
        'temp2_neg_offset = CInt(RXD.Substring(39, 4))

        If RXD = "error" Then
            send_status_lbl.Text = "Communication lost..."
        Else
            send_status_lbl.Text = "Connected to PLC."
        End If
        TimerPLC.Enabled = True
    End Sub

    Private Sub GetFCS()
        'This will calculate the FCS value for the communications
        Dim trans_text As Integer
        Dim sumcheck_single As String
        Dim running_check As String
        trans_text = Len(TX)
        sumcheck_single = 0
        For n = 1 To trans_text
            running_check = Mid$(TX, n, 1)
            sumcheck_single = Asc(running_check) Xor sumcheck_single
        Next n
        FCS = Hex$(sumcheck_single)
        If Len(FCS) = 1 Then FCS = "0" + FCS
    End Sub



    Private Sub communicate()
        'This will communicate to the Omron PLC
        Dim BufferTX As String
        Dim fcs_rxd As String
        Try
            RXD = ""
            BufferTX = TX + FCS + "*" + Chr(13)

            'Send the information out the serial port
            SerialPort2.Write(BufferTX)

            'Sleep for 50 msec so the information can be sent on the port
            System.Threading.Thread.Sleep(50)

            'Set the timeout for the serial port at 100 msec
            SerialPort2.ReadTimeout = 100

            'Read up to the carriage return
            RXD = (SerialPort2.ReadTo(Chr(13)))
            'Console.WriteLine(RXD)
        Catch ex As Exception
            'If an error occurs then indicate communication error
            RXD = "error"
        End Try

        'Get the FCS of the returned information
        fcs_rxd = RXD.Substring(RXD.Length - 3, 2)
        If RXD.Substring(0, 1) = "@" Then
            TX = RXD.Substring(0, RXD.Length - 3)
        ElseIf RXD.Substring(2, 1) = "@" Then
            TX = RXD.Substring(2, RXD.Length - 5)
            RXD = RXD.Substring(2, RXD.Length - 1)
        End If

        'Check the FCS of the return information. If they are not the same then an error has occurred.
        GetFCS()
        If FCS <> fcs_rxd Then
            RXD = "Communication Error"
        End If
    End Sub

    Public tosend As String

    Public Sub to_PLC(mystring As String)
        send_status_lbl.Text = "Send to PLC initiated.."
        If SerialPort2.IsOpen = False Then
            SerialPort2.Open()
        End If
        System.Threading.Thread.Sleep(50)
        ' write data to D0,D1,D2,D3,D4,D5,D6
        tosend = mystring '"@00WD0000" & "F000" & "E000"
        Dim trans_text As Integer
        Dim sumcheck_single As String
        Dim running_check As String
        trans_text = Len(tosend)
        sumcheck_single = 0
        For n = 1 To trans_text
            running_check = Mid$(tosend, n, 1)
            sumcheck_single = Asc(running_check) Xor sumcheck_single
        Next n
        FCS = Hex$(sumcheck_single)
        If Len(FCS) = 1 Then FCS = "0" + FCS



        Dim BufferTX As String
        Try
            RXD = ""
            BufferTX = tosend + FCS + "*" + Chr(13)

            'Send the information out the serial port
            SerialPort2.Write(BufferTX)

            'Sleep for 50 msec so the information can be sent on the port
            System.Threading.Thread.Sleep(50)

            'Set the timeout for the serial port at 100 msec
            SerialPort2.ReadTimeout = 100

            'Read up to the carriage return
            RXD = (SerialPort2.ReadTo(Chr(13)))
            If RXD = "@00WD0053*" Then
                send_status_lbl.Text = "Send to PLC success.."
            Else
                MsgBox("Send to PLC error!", vbCritical)
            End If

            'Console.WriteLine(RXD)
        Catch ex As Exception
            'If an error occurs then indicate communication error
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class
