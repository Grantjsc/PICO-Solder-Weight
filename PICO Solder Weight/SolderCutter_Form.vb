Public Class SolderCutter_Form
    Private Sub btnC1Start_Click(sender As Object, e As EventArgs) Handles btnC1Start.Click
        Cutter1_Module.C1_ButtonStart()
    End Sub

    Private Sub btnC2Start_Click(sender As Object, e As EventArgs) Handles btnC2Start.Click
        Cutter2_Module.C2_ButtonStart()
    End Sub

    Private Sub btnC3Start_Click(sender As Object, e As EventArgs) Handles btnC3Start.Click
        Cutter3_Module.C3_ButtonStart()
    End Sub

    Private Sub btnC4Start_Click(sender As Object, e As EventArgs) Handles btnC4Start.Click
        Cutter4_Module.C4_ButtonStart()
    End Sub

    Private Sub SolderCutter_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Timer1.Enabled = False Then
            Timer1.Enabled = True
        End If
    End Sub

    Public TX As String
    Public FCS As String
    Public RXD As String

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        'Display current date and time
        'timetoday.Text = System.DateTime.Now
        Try
            If SerialPort1.IsOpen = False Then
                SerialPort1.Open()
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
        SerialPort1.Close()
        ' Set information on the screen

        'Console.WriteLine(RXD)
        lblPurge105.Text = RXD.Substring(7, 4) 'CInt("&H" & RXD.Substring(7, 4))
        lblSamples106.Text = RXD.Substring(11, 4) 'CInt("&H" & RXD.Substring(11, 4))
        lblSpool107.Text = RXD.Substring(15, 4)
        lblQty108.Text = RXD.Substring(19, 4)
        lblQty109.Text = RXD.Substring(23, 4)
        lblDoor_110.Text = RXD.Substring(27, 4)

        lblC2counter.Text = (CInt(RXD.Substring(23, 4) & RXD.Substring(19, 4))).ToString("N0")
        BuyOff_Form.lblcounter.Text = (CInt(RXD.Substring(23, 4) & RXD.Substring(19, 4))).ToString("N0")

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
        Timer1.Enabled = True
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
            SerialPort1.Write(BufferTX)

            'Sleep for 50 msec so the information can be sent on the port
            System.Threading.Thread.Sleep(50)

            'Set the timeout for the serial port at 100 msec
            SerialPort1.ReadTimeout = 100

            'Read up to the carriage return
            RXD = (SerialPort1.ReadTo(Chr(13)))
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
        If SerialPort1.IsOpen = False Then
            SerialPort1.Open()
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
            SerialPort1.Write(BufferTX)

            'Sleep for 50 msec so the information can be sent on the port
            System.Threading.Thread.Sleep(50)

            'Set the timeout for the serial port at 100 msec
            SerialPort1.ReadTimeout = 100

            'Read up to the carriage return
            RXD = (SerialPort1.ReadTo(Chr(13)))
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


    '********************* CUTTER 1 Buttons *********************
    Private Sub btnC1JogPlus_Click(sender As Object, e As EventArgs) Handles btnC1JogPlus.Click
        Cutter1_Module.C1_JogPlus()
    End Sub

    Private Sub btnC1JogMinus_Click(sender As Object, e As EventArgs) Handles btnC1JogMinus.Click
        Cutter1_Module.C1_JogMinus()
    End Sub

    Private Sub btnC1cut_Click(sender As Object, e As EventArgs) Handles btnC1cut.Click
        Cutter1_Module.C1_Cut()
    End Sub

    Private Sub btnC1Reset_Click(sender As Object, e As EventArgs) Handles btnC1Reset.Click
        Cutter1_Module.C1_Reset()
    End Sub

    '********************* CUTTER 2 Buttons *********************
    Private Sub btnC2JogPlus_Click(sender As Object, e As EventArgs) Handles btnC2JogPlus.Click
        Cutter2_Module.C2_JogPlus()
    End Sub

    Private Sub btnC2JogMinus_Click(sender As Object, e As EventArgs) Handles btnC2JogMinus.Click
        Cutter2_Module.C2_JogMinus()
    End Sub

    Private Sub btnC2cut_Click(sender As Object, e As EventArgs) Handles btnC2cut.Click
        Cutter2_Module.C2_Cut()
    End Sub

    Private Sub btnC2Reset_Click(sender As Object, e As EventArgs) Handles btnC2Reset.Click
        Cutter2_Module.C2_Reset()
    End Sub

    '********************* CUTTER 3 Buttons *********************
    Private Sub btnC3JogPlus_Click(sender As Object, e As EventArgs) Handles btnC3JogPlus.Click
        Cutter3_Module.C3_JogPlus()
    End Sub

    Private Sub btnC3JogMinus_Click(sender As Object, e As EventArgs) Handles btnC3JogMinus.Click
        Cutter3_Module.C3_JogMinus()
    End Sub

    Private Sub btnC3cut_Click(sender As Object, e As EventArgs) Handles btnC3cut.Click
        Cutter3_Module.C3_Cut()
    End Sub

    Private Sub btnC3Reset_Click(sender As Object, e As EventArgs) Handles btnC3Reset.Click
        Cutter3_Module.C3_Reset()
    End Sub

    '********************* CUTTER 4 Buttons *********************
    Private Sub btnC4JogPlus_Click(sender As Object, e As EventArgs) Handles btnC4JogPlus.Click
        Cutter4_Module.C4_JogPlus()
    End Sub

    Private Sub btnC4JogMinus_Click(sender As Object, e As EventArgs) Handles btnC4JogMinus.Click
        Cutter4_Module.C4_JogMinus()
    End Sub

    Private Sub btnC4cut_Click(sender As Object, e As EventArgs) Handles btnC4cut.Click
        Cutter4_Module.C4_Cut()
    End Sub

    Private Sub btnC4Reset_Click(sender As Object, e As EventArgs) Handles btnC4Reset.Click
        Cutter4_Module.C4_Reset()
    End Sub

    Private Sub TimerQtyChecking_Tick(sender As Object, e As EventArgs) Handles TimerQtyChecking.Tick
        Function_Module.QuantityChecking()
    End Sub

    Private Sub TimerChangeSpool_Tick(sender As Object, e As EventArgs) Handles TimerChangeSpool.Tick
        Function_Module.ChangeSpool()
        'Function_Module.ChangeSpool()
    End Sub

    Private Sub btnResetAll_Click(sender As Object, e As EventArgs) Handles btnResetAll.Click
        ResetAll()
    End Sub
End Class