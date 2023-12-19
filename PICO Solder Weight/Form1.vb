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

        btnNewLot.Focus()

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
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            SerialPort1.Close()
            Application.ExitThread()
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
                txtSolderWire.Focus()
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

        txtWeight.Text = "Enter weight"
        txtWeight.ForeColor = Color.Silver

        txtSolderWire.Text = "Enter Solder Wire Part #"
        txtSolderWire.ForeColor = Color.Silver

        txtBareWire.Text = "Enter Bare Wire Lot #"
        txtBareWire.ForeColor = Color.Silver

        txtCutterSet.Text = "Enter Cutter Setting"
        txtCutterSet.ForeColor = Color.Silver

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

    Public dateNtime As String '= DateTime.Now.ToString("yyyy_MM_dd_HHmmtt ")

    Public get_FolderPath As String = "\\lffile001\infinity\Philippines\Buffer File\PICO\PICO Solder Weight.csv"
    'Public get_FolderPath2 As String = "\\lffile001\infinity\Philippines\Nano Log\PICO Solder Weight.csv"
    Public get_message As String
    Public get_message2 As String
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        dateNtime = Date.Now.ToString("yyyy_MM_dd_HHmmtt ")

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

            Else

                MessageBox.Show("Cannot Proceed Saving!!! There is a file for upload at Infinity. Please add the data In Infinity, then click Save.", "PICO Solder Weight", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
            MsgBox(ex, vbCritical)
        End Try


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

            txtWeight.Text = "Enter weight"
            txtWeight.ForeColor = Color.Silver

            txtSolderWire.Text = "Enter Solder Wire Part #"
            txtSolderWire.ForeColor = Color.Silver

            txtBareWire.Text = "Enter Bare Wire Lot #"
            txtBareWire.ForeColor = Color.Silver

            txtCutterSet.Text = "Enter Cutter Setting"
            txtCutterSet.ForeColor = Color.Silver

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

    Private Sub txtWeight_KeyUp(sender As Object, e As KeyEventArgs) Handles txtWeight.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtWeight.Text = "" Then
                MsgBox("Please enter the weight!", MsgBoxStyle.Exclamation)
                txtWeight.Text = ""
            Else
                txtPartNo.Focus()
            End If
        End If
    End Sub

    Private Sub txtWeight_Leave(sender As Object, e As EventArgs) Handles txtWeight.Leave
        If txtWeight.Text = "" Then

            txtWeight.Text = "Enter weight"
            txtWeight.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtSolderWire_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSolderWire.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtSolderWire.Text = "" Then
                MsgBox("Please enter solder wire part number!", MsgBoxStyle.Exclamation)
                txtSolderWire.Text = ""
            Else
                txtBareWire.Focus()
            End If
        End If
    End Sub

    Private Sub txtSolderWire_Leave(sender As Object, e As EventArgs) Handles txtSolderWire.Leave
        If txtSolderWire.Text = "" Then

            txtSolderWire.Text = "Enter Solder Wire Part #"
            txtSolderWire.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtBareWire_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBareWire.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtBareWire.Text = "" Then
                MsgBox("Please enter Bare wire lot number!", MsgBoxStyle.Exclamation)
                txtBareWire.Text = ""
            Else
                txtCutterSet.Focus()
            End If
        End If
    End Sub

    Private Sub txtBareWire_Leave(sender As Object, e As EventArgs) Handles txtBareWire.Leave
        If txtBareWire.Text = "" Then

            txtBareWire.Text = "Enter Bare Wire Lot #"
            txtBareWire.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtCutterSet_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCutterSet.KeyUp

        If e.KeyCode = Keys.Enter Then
            If txtCutterSet.Text = "" Then
                MsgBox("Please enter Cutter Setting!", MsgBoxStyle.Exclamation)
                txtCutterSet.Text = ""
            Else
                cboShift.Focus()
            End If
        End If
    End Sub

    Private Sub txtCutterSet_Leave(sender As Object, e As EventArgs) Handles txtCutterSet.Leave
        If txtCutterSet.Text = "" Then

            txtCutterSet.Text = "Enter Cutter Setting"
            txtCutterSet.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub txtWeight_Enter(sender As Object, e As EventArgs) Handles txtWeight.Enter
        If txtWeight.Text = "Enter weight" Then

            txtWeight.Text = ""
            txtWeight.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtSolderWire_Enter(sender As Object, e As EventArgs) Handles txtSolderWire.Enter
        If txtSolderWire.Text = "Enter Solder Wire Part #" Then

            txtSolderWire.Text = ""
            txtSolderWire.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtBareWire_Enter(sender As Object, e As EventArgs) Handles txtBareWire.Enter
        If txtBareWire.Text = "Enter Bare Wire Lot #" Then

            txtBareWire.Text = ""
            txtBareWire.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtCutterSet_Enter(sender As Object, e As EventArgs) Handles txtCutterSet.Enter
        If txtCutterSet.Text = "Enter Cutter Setting" Then

            txtCutterSet.Text = ""
            txtCutterSet.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Function_Module.GetOldmg()
        Function_Module.GetOldOCAP()
        'If IsNumeric(txtWeight.Text) Then
        '    Console.WriteLine("Numeric")
        'Else
        '    Console.WriteLine("Error")
        'End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Function_Module.GetNewmg()
        Function_Module.ChangeMg()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Function_Module.GetOldOCAP()
        If OldOCAP = 2 Then
            MsgBox("Need Tech/P03")
            Function_Module.ResetOCAP()
            Function_Module.ChangeOCAP()
        Else
            Function_Module.IncOCAP()
            Function_Module.ChangeOCAP()
        End If
    End Sub

    Private Sub txtWeight_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWeight.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            'If Asc(e.KeyChar) <> 45 Then
            If Asc(e.KeyChar) <> 46 Then
                If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                    e.Handled = True
                    'MessageBox.Show("Please enter numeric value!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            'End If
        End If
    End Sub
End Class
