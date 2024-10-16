Imports System.Configuration
Imports System.Data.OleDb
Imports System.IO.Ports
Imports System.Reflection
Imports System.Runtime.Remoting.Lifetime
Imports System.Threading
Imports DPFP

Module Function_Module

    Public PNseries As Integer
    Public NewWeightmg As Decimal

    Public OldWeight As Decimal
    Public NewOCAP As Integer
    Public OldOCAP As Integer

    Sub GetSeries()
        Dim str As String
        str = Form1.txtPartNo.Text
        PNseries = str.Substring(1, 3)
        Console.WriteLine(PNseries)
    End Sub

    Sub GetNewmg()
        NewWeightmg = CDec(Form1.txtWeight.Text)
    End Sub

    Sub GetEvalmg()
        NewWeightmg = CDec(Eval_Form.txtWeight.Text)
    End Sub

    Sub GetOldmg()
        Dim Oldmg As String = System.Configuration.ConfigurationManager.AppSettings("mg")
        Console.WriteLine(Oldmg)

        OldWeight = Oldmg
    End Sub

    Public Samples = False
    Sub PurgeAndCutSamples()
        Dim PurgeDone = False

        If PurgeDone = False Then
            If CInt(SolderCutter_Form.lblPurge105.Text) = 100 Then
                Purging_Form.TimerPurgingAndSamples.Enabled = False
                SolderCutter_Form.to_PLC("@00WD01050000")
                Thread.Sleep(100)
                'Dim dialog As DialogResult
                'dialog = MessageBox.Show("Please replace the NG bin with a sample bin before clicking okay.", "PICO Solder Weight", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'If dialog = DialogResult.OK Then

                PurgeDone = True
                'Samples = True
                AfterPurgeSample_Form.ShowDialog()

                'End If
            End If
        End If

        If Samples = True Then
            If CInt(SolderCutter_Form.lblSamples106.Text) = 100 Then
                SolderCutter_Form.to_PLC("@00WD01060000")
                SolderCutter_Form.btnC2Start.Enabled = True
                Samples = False
                Purging_Form.TimerPurgingAndSamples.Enabled = False

                If Evaluation = False Then
                    'Open Weighing Scale after cutting Samples
                    WeighingScalebyON()
                    Thread.Sleep(100)
                    Form1.SerialPort1.WriteLine("Z")
                    Thread.Sleep(100)
                    Form1.SerialPort1.WriteLine("CP")
                    Form1.Timer1.Enabled = True
                    'Else
                    '    'For Evaluation
                    '    Eval_Form.SerialPort1.Open()
                    '    Thread.Sleep(100)
                    '    Eval_Form.SerialPort1.WriteLine("Z")
                    '    Thread.Sleep(100)
                    '    Eval_Form.SerialPort1.WriteLine("CP")
                    '    Eval_Form.Timer1.Enabled = True
                End If

                'SolderCutter_Form.to_PLC("@00WD01060000")
                Thread.Sleep(100)
                'Purging_Form.TimerPurgingAndSamples.Enabled = False
                Purging_Form.Close()

            End If
        End If
    End Sub

    Sub CutSamples()
        Dim Samples = False
        If Samples = False Then
            If SolderCutter_Form.lblSamples106.Text = 100 Then
                SolderCutter_Form.btnC2Start.Enabled = True
                Samples = True
                Purging_Form.TimerCutSamples.Enabled = False

                If Evaluation = False Then
                    'Open Weighing Scale after cutting Samples
                    WeighingScalebyON()
                    Thread.Sleep(100)
                    Form1.SerialPort1.WriteLine("Z")
                    Thread.Sleep(100)
                    Form1.SerialPort1.WriteLine("CP")
                    Form1.Timer1.Enabled = True
                    'Else
                    '    'For Evaluation
                    '    Eval_Form.SerialPort1.Open()
                    '    Thread.Sleep(100)
                    '    Eval_Form.SerialPort1.WriteLine("Z")
                    '    Thread.Sleep(100)
                    '    Eval_Form.SerialPort1.WriteLine("CP")
                    '    Eval_Form.Timer1.Enabled = True
                End If

                SolderCutter_Form.to_PLC("@00WD01060000")
                Purging_Form.Close()
            End If
        End If
    End Sub

    Sub CheckMg()
        Dim PurgeDone = False
        Dim Samples = False

        If NewWeightmg = OldWeight Then
            With Purging_Form
                .TopLevel = False
                Main_Form.PanelMain.Controls.Add(Purging_Form)
                .WindowState = FormWindowState.Maximized
                Purging_Form.lblMsg.Text = "The machine is cutting samples ..."
                Purging_Form.btnStartCut.Visible = False
                Purging_Form.btnCutSample.Visible = True
                .BringToFront()
                .Show()
            End With

            SolderCutter_Form.btnC2Start.Enabled = False
            SolderCutter_Form.to_PLC("@00WD00060010")

            Purging_Form.TimerCutSamples.Enabled = True

        Else
            With Purging_Form
                .TopLevel = False
                Main_Form.PanelMain.Controls.Add(Purging_Form)
                .WindowState = FormWindowState.Maximized
                Purging_Form.btnStartCut.Visible = True
                Purging_Form.btnCutSample.Visible = False
                .BringToFront()
                .Show()
            End With

            SolderCutter_Form.btnC2Start.Enabled = False
            SolderCutter_Form.to_PLC("@00WD00050010")

            Purging_Form.TimerPurgingAndSamples.Enabled = True
        End If
    End Sub

    Sub GetOldOCAP()
        Dim OCAPcount As String = System.Configuration.ConfigurationManager.AppSettings("OCAP")
        Console.WriteLine(OCAPcount)

        OldOCAP = CInt(OCAPcount)
    End Sub

    Sub IncOCAP()
        NewOCAP = CInt(OldOCAP) + 1
    End Sub
    Sub ResetOCAP()
        NewOCAP = 1
    End Sub

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
    Sub ChangeMg()
        config.AppSettings.Settings("mg").Value = NewWeightmg ' Rewrite Weight(mg)
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub ChangeOCAP()
        config.AppSettings.Settings("OCAP").Value = NewOCAP ' Rewrite Weight(mg)
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub


    Sub BiometricsOCAP()
        Dim Fngerprint = False
        GetOldOCAP()
        If OldOCAP = 2 Then
            While Fngerprint = False
                'Invoke(Sub()
                'SolderCutter_Form.to_PLC("@00WD00000000")
                Master_login.lblErrorMsg.Text = "2nd OCAP!"
                Master_login.PanelWarning.Visible = True
                Form1.TimerErrorMsg.Enabled = True

                'SerialPort1.WriteLine("B")
                'Write to PLC Error

                Master_login.Label1.Text = "Perform OCAP, please scan your finger. Technician only"
                Master_login.ShowDialog()
                If Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                    SolderCutter_Form.to_PLC("@00WD01070000") ' door unlocked

                    'Wite to PLC Reset Error
                    ResetOCAP()
                    ChangeOCAP()

                    Form1.count = 0
                    Form1.lstResult.Items.Clear()
                    Array.Clear(Form1.data, 0, Form1.data.Length)

                    With OCAP_Form
                        .TopLevel = False
                        Main_Form.PanelMain.Controls.Add(OCAP_Form)
                        .WindowState = FormWindowState.Maximized

                        Dim Limit As String
                        Limit = CDec(Form1.txtWeight.Text)
                        Select Case Limit

                            Case 12
                                SetLowLimit = CDec(Form1.TopLowLim)
                                SetUpperLimit = CDec(Form1.TopUppLim)

                                'Form1.RealData >= 12.6 Or Form1.RealData <= 11.4

                                If CDec(Form1.RealData) >= 12.6 Then
                                    OCAP_Form.txtAlarm.Text = ">USL"

                                ElseIf CDec(Form1.RealData) <= 11.4 Then
                                    OCAP_Form.txtAlarm.Text = "<LSL"

                                End If

                            Case 14
                                SetLowLimit = CDec(Form1.BotLowLim)
                                SetUpperLimit = CDec(Form1.BotUppLim)

                                'Form1.RealData >= 14.7 Or Form1.RealData <= 13.3

                                If CDec(Form1.RealData) >= 14.7 Then
                                    OCAP_Form.txtAlarm.Text = ">USL"

                                ElseIf CDec(Form1.RealData) <= 13.3 Then
                                    OCAP_Form.txtAlarm.Text = "<LSL"

                                End If

                        End Select
                        OCAP_Form.txtAssociate.Text = Master_login.F1_get_user
                        OCAP_Form.txtPartNum.Text = Form1.txtPartNo.Text
                        OCAP_Form.txtLotNum.Text = Form1.txtLotNo.Text
                        OCAP_Form.txtMachine.Text = Form1.cboProcess.Text
                        OCAP_Form.txtTest.Text = Form1.txtWeight.Text
                        .BringToFront()
                        .Show()
                    End With
                    Master_login.Close()
                    Fngerprint = True
                Else

                    MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                    Master_login.Close()
                End If
                'End Sub)
            End While

        Else

            IncOCAP()
            ChangeOCAP()

            'Form1.DoorState = False

            'SolderCutter_Form.to_PLC("@00WD00000000")
            MsgBox("Please perform OCAP!", MessageBoxIcon.Error)

            SolderCutter_Form.to_PLC("@00WD01070000") ' door unlocked

            Form1.count = 0
            Form1.lstResult.Items.Clear()
            Array.Clear(Form1.data, 0, Form1.data.Length)

            With OCAP_Form
                .TopLevel = False
                Main_Form.PanelMain.Controls.Add(OCAP_Form)
                .WindowState = FormWindowState.Maximized

                Dim Limit As String
                Limit = CDec(Form1.txtWeight.Text)
                Select Case Limit

                    Case 12
                        SetLowLimit = CDec(Form1.TopLowLim)
                        SetUpperLimit = CDec(Form1.TopUppLim)

                        'Form1.RealData >= 12.6 Or Form1.RealData <= 11.4

                        If CDec(Form1.RealData) >= 12.6 Then
                            OCAP_Form.txtAlarm.Text = ">USL"

                        ElseIf CDec(Form1.RealData) <= 11.4 Then
                            OCAP_Form.txtAlarm.Text = "<LSL"

                        End If

                    Case 14
                        SetLowLimit = CDec(Form1.BotLowLim)
                        SetUpperLimit = CDec(Form1.BotUppLim)

                        'Form1.RealData >= 14.7 Or Form1.RealData <= 13.3

                        If CDec(Form1.RealData) >= 14.7 Then
                            OCAP_Form.txtAlarm.Text = ">USL"

                        ElseIf CDec(Form1.RealData) <= 13.3 Then
                            OCAP_Form.txtAlarm.Text = "<LSL"

                        End If

                End Select

                OCAP_Form.txtAssociate.Text = Form1.cboAssociate.Text
                OCAP_Form.txtPartNum.Text = Form1.txtPartNo.Text
                OCAP_Form.txtLotNum.Text = Form1.txtLotNo.Text
                OCAP_Form.txtMachine.Text = Form1.cboProcess.Text
                OCAP_Form.txtTest.Text = Form1.txtWeight.Text

                .BringToFront()
                .Show()
            End With
        End If
    End Sub

    Sub BiometricsOCAPcontinuesRun()
        Dim Fngerprint = False
        GetOldOCAP()
        If OldOCAP = 2 Then
            While Fngerprint = False

                Master_login.lblErrorMsg.Text = "2nd OCAP!"
                Master_login.PanelWarning.Visible = True
                Form1.TimerErrorMsg.Enabled = True

                Master_login.Label1.Text = "Perform OCAP, please scan your finger after performing OCAP. Technician only"
                Master_login.ShowDialog()
                If Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then

                    SolderCutter_Form.to_PLC("@00WD01070000") 'door unlocked
                    'CloseSerialPort2()

                    'Form1.DoorState = False

                    ResetOCAP()
                    ChangeOCAP()

                    Form1.btnEnable.Visible = False
                    Form1.btnReset.Visible = True
                    Form1.btnReset.Enabled = False

                    Form1.count = 0
                    Form1.lstResult.Items.Clear()
                    Array.Clear(Form1.data, 0, Form1.data.Length)

                    PurgeAfterOCAP()
                    ''Moved after cutting samples
                    'WeighingScalebyON()
                    'Thread.Sleep(100)
                    'Form1.SerialPort1.WriteLine("Z")
                    'Thread.Sleep(100)
                    'Form1.SerialPort1.WriteLine("CP")
                    'Form1.Timer1.Enabled = True
                    Master_login.Close()

                    Fngerprint = True
                Else

                    MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                    Master_login.Close()
                End If

            End While

        Else

            IncOCAP()
            ChangeOCAP()
            While Fngerprint = False
                'Master_login.lblErrorMsg.Text = "Please perform OCAP!"
                'Master_login.PanelWarning.Visible = True
                'Form1.TimerErrorMsg.Enabled = True

                Master_login.Label1.Text = "Perform OCAP, please scan your finger after performing OCAP. SPC only"
                Master_login.ShowDialog()
                If Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Engineer" Then

                    SolderCutter_Form.to_PLC("@00WD01070000") 'door unlocked
                    'CloseSerialPort2()

                    'Form1.DoorState = False

                    Form1.btnEnable.Visible = False
                    Form1.btnReset.Visible = True
                    Form1.btnReset.Enabled = False

                    Form1.count = 0
                    Form1.lstResult.Items.Clear()
                    Array.Clear(Form1.data, 0, Form1.data.Length)

                    PurgeAfterOCAP()
                    ''Chnage to after cutting samples
                    'WeighingScalebyON()
                    'Thread.Sleep(100)
                    'Form1.SerialPort1.WriteLine("Z")
                    'Thread.Sleep(100)
                    'Form1.SerialPort1.WriteLine("CP")
                    'Form1.Timer1.Enabled = True
                    Master_login.Close()

                    Fngerprint = True
                Else

                    MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                    Master_login.Close()
                End If
            End While

        End If
    End Sub

    Sub PurgeAfterOCAP()
        With Purging_Form
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(Purging_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With

        SolderCutter_Form.btnC2Start.Enabled = False
        SolderCutter_Form.to_PLC("@00WD00050010")

        Purging_Form.TimerPurgingAndSamples.Enabled = True

    End Sub

    Sub BiometricsRegisterUser()
        Master_login.lblErrorMsg.Visible = False
        Master_login.PanelWarning.Visible = False
        Form1.TimerErrorMsg.Enabled = False

        Master_login.Label1.Text = "Please scan your finger. Engineer only"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "Engineer" Then
            Master_login.Close()
            With Add_Form
                .TopLevel = False
                Main_Form.PanelMain.Controls.Add(Add_Form)
                .WindowState = FormWindowState.Maximized
                .BringToFront()
                .Show()
            End With
        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

    Sub BiometricsChangeCOMName()
        Master_login.lblErrorMsg.Visible = False
        Master_login.PanelWarning.Visible = False
        Form1.TimerErrorMsg.Enabled = False

        Master_login.Label1.Text = "Please scan your finger. Engineer or Technician"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "Engineer" Or Master_login.F1_get_title = "Technician" Then
            Master_login.Close()
            ChangeComPort_Form.ShowDialog()
        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

    Sub BiometricsSPCRules()
        Master_login.lblErrorMsg.Visible = False
        Master_login.PanelWarning.Visible = False
        Form1.TimerErrorMsg.Enabled = False

        Master_login.Label1.Text = "Please scan your finger Engineer only."
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "Engineer" Then
            Master_login.Close()
            SPCRules_Form.ShowDialog()
        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

    Sub RunMachine()
        Dim CutQty As String
        Dim QtyLength As String

        CutQty = CInt(Form1.txtQty.Text)
        QtyLength = CInt(CutQty.Length.ToString)


        Select Case QtyLength

            Case 1 'Ones
                SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD00080000")
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0007" & CInt(Form1.txtQty.Text).ToString("0000"))

            Case 2 'Tens
                SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD00080000")
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0007" & CInt(Form1.txtQty.Text).ToString("0000"))

            Case 3 'Hundreds
                SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD00080000")
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0007" & CInt(Form1.txtQty.Text).ToString("0000"))

            Case 4 'One Thousands
                SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD00080000")
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0007" & CInt(Form1.txtQty.Text).ToString("0000"))

            Case 5 'Ten Thousands
                Dim str As String
                Dim FirstDgt As String
                Dim LastDgts As String
                str = Form1.txtQty.Text
                FirstDgt = str.Substring(0, 1)
                LastDgts = str.Substring(1, 4)

                SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0008" & CInt(FirstDgt).ToString("0000"))
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0007" & CInt(LastDgts).ToString("0000"))

            Case 6 'Hundred Thousands
                Dim str As String
                Dim FirstDgt As String
                Dim LastDgts As String
                str = Form1.txtQty.Text
                FirstDgt = str.Substring(0, 2)
                LastDgts = str.Substring(2, 4)

                SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0008" & CInt(FirstDgt).ToString("0000"))
                Thread.Sleep(500)
                SolderCutter_Form.to_PLC("@00WD0007" & CInt(LastDgts).ToString("0000"))

            Case Else

        End Select
    End Sub

    Sub QuantityChecking()
        If CInt(SolderCutter_Form.lblC2counter.Text) = CInt(Form1.txtQty.Text) Then
            'SolderCutter_Form.to_PLC("@00WD00000000")
            SolderCutter_Form.TimerQtyChecking.Enabled = False
            Cutter2_Module.C2_ChagetoStart()
            Main_Form.btnBuyOff.Enabled = True
        End If
    End Sub

    Sub ChangeSpool()
        If SolderCutter_Form.lblSpool107.Text = CInt("100") Then 'And CInt(SolderCutter_Form.lblC2counter.Text) <> CInt(Form1.txtQty.Text)
            SolderCutter_Form.TimerChangeSpool.Enabled = False
            SolderCutter_Form.to_PLC("@00WD00000000")
            Cutter2_Module.C2_ChagetoStart()
            'MessageBox.Show("Please change spool!", "PICO Solder Weight", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ChangeSpoolMsg_Form.ShowDialog()


            ''Verrify if need Biometrics if change spool
            'Dim Fngerprint = False
            'While Fngerprint = False

            '    Master_login.Label1.Text = "Spool is empty!, Please scan your finger. SPC or Technician only"
            '    Master_login.ShowDialog()
            '    If Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
            '        ChangeSpoolMsg_Form.ShowDialog()
            '        Fngerprint = True
            '    Else

            '        MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            '        Master_login.Close()
            '    End If
            'End While
        End If
    End Sub

    Sub ResetChangeSpool()
        If SolderCutter_Form.lblSpool107.Text = CInt("100") Then
            SolderCutter_Form.to_PLC("@00WD01070000")
            SolderCutter_Form.TimerChangeSpool.Enabled = True
        End If
    End Sub

    Public SetUpperLimit As String
    Public SetLowLimit As String
    Sub WeightLimits()
        Dim Limit As String
        Limit = CDec(Form1.txtWeight.Text)


        Select Case Limit

            Case 12
                SetLowLimit = CDec(Form1.TopLowLim)
                SetUpperLimit = CDec(Form1.TopUppLim)

                'Form1.RealData >= SetUpperLimit Or Form1.RealData <= SetLowLimit

                'Form1.RealData >= 12.6 Or Form1.RealData <= 11.4

                If Form1.RealData >= 12.6 Or Form1.RealData <= 11.4 Then
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    Form1.Timer1.Enabled = False
                    Form1.SerialPort1.WriteLine("Z")
                    Thread.Sleep(100)
                    Form1.SerialPort1.Close()
                    Form1.txtReading.Text = ""

                    Thread.Sleep(500)

                    BiometricsOCAP()

                End If

            Case 14
                SetLowLimit = CDec(Form1.BotLowLim)
                SetUpperLimit = CDec(Form1.BotUppLim)
                'Form1.RealData >= SetUpperLimit Or Form1.RealData <= SetLowLimit

                'Form1.RealData >= 14.7 Or Form1.RealData <= 13.3

                If Form1.RealData >= 14.7 Or Form1.RealData <= 13.3 Then
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    Form1.Timer1.Enabled = False
                    Form1.SerialPort1.WriteLine("Z")
                    Thread.Sleep(100)
                    Form1.SerialPort1.Close()
                    Form1.txtReading.Text = ""

                    Thread.Sleep(500)

                    BiometricsOCAP()

                End If

        End Select
    End Sub


    Sub CheckWTinControl()
        'Verify if there ia a interruption (Continue/WeightLimit)
        'NewWeightmg = OldWeight And InterruptionCheck = False

        If NewWeightmg = OldWeight And InterruptionCheck = False Then

        Else
            WeightLimits()
        End If

    End Sub


    Sub PurgingSample()
        Dim PurgeDone = False
        Dim Samples = False

        SolderCutter_Form.btnC2Start.Enabled = False
        'SolderCutter_Form.to_PLC("@00WD00050010")

        If PurgeDone = False Then
            If Main_Form.TextBox1.Text = 100 Then
                Purging_Form.lblMsg.Text = "The machine is cutting samples ..."
                'SolderCutter_Form.to_PLC("@00WD00060025")
                PurgeDone = True
                Samples = True
            End If
        End If

        If Samples = True Then
            If Main_Form.TextBox2.Text = 100 Then
                SolderCutter_Form.btnC2Start.Enabled = True
                Samples = False
                'PurgeDone = True

                Purging_Form.Close()
                Main_Form.Timer1.Enabled = False
            End If
        End If

    End Sub

    Sub CheckInifinity()
        'Dim isFileEmpty As Boolean = Form1.IsCSVFileEmpty(Form1.get_FolderPath)
        Dim isFileEmpty12mg As Boolean = Form1.IsCSVFileEmpty(Form1.get_FolderPath)
        Dim isFileEmpty14mg As Boolean = Form1.IsCSVFileEmpty(Form1.get_FolderPath14mg)
        Dim isFileEmpty As Boolean

        If SolderCutter_Form.lblDoor_110.Text = 1 Then

            SolderCutter_Form.to_PLC("@00WD01070000") 'door locked

            Select Case CInt(Form1.txtWeight.Text)
                Case 12
                    isFileEmpty = isFileEmpty12mg
                Case 14
                    isFileEmpty = isFileEmpty14mg
            End Select

            If isFileEmpty Then

                RuleOne_FlowTwo()

            Else
                Form1.TimerCheckInfi.Enabled = False
                SavingError_Form.ShowDialog()

            End If

        Else
            Form1.TimerCheckInfi.Enabled = False
            DoorOpen_Form.ShowDialog()
        End If
    End Sub

    Sub CheckContinuesRun()
        'Dim isFileEmpty As Boolean = Form1.IsCSVFileEmpty(Form1.get_FolderPath)
        Dim isFileEmpty12mg As Boolean = Form1.IsCSVFileEmpty(Form1.get_FolderPath)
        Dim isFileEmpty14mg As Boolean = Form1.IsCSVFileEmpty(Form1.get_FolderPath14mg)
        Dim isFileEmpty As Boolean

        Select Case CInt(Form1.txtWeight.Text)
            Case 12
                isFileEmpty = isFileEmpty12mg
            Case 14
                isFileEmpty = isFileEmpty14mg
        End Select

        If isFileEmpty Then
            Form1.TimerCheckCR.Enabled = False

            'Form1.count = 0
            'Form1.lstResult.Items.Clear()
            'Array.Clear(Form1.data, 0, Form1.data.Length)

            BiometricsOCAPcontinuesRun()
        Else
            Form1.TimerCheckCR.Enabled = False
            SavingError_Form.ShowDialog()

        End If
    End Sub

    Sub CheckSavingOption()
        If Form1.checkSaveCon = True Then

            Form1.TimerCheckInfi.Interval = 10000
            Form1.TimerCheckInfi.Enabled = True
            Form1.checkSaveCon = False
            SavingError_Form.Close()
        Else

            Form1.TimerCheckCR.Interval = 10000
            Form1.TimerCheckCR.Enabled = True
            SavingError_Form.Close()
        End If
    End Sub

    Sub WeighingScalebyON()
        If Not Form1.SerialPort1.IsOpen Then
            Form1.SerialPort1.Open()
        End If
        'Thread.Sleep(100)
        'Form1.SerialPort1.WriteLine("ON")
    End Sub

    Sub WeighingScaleOFF()
        If Form1.SerialPort1.IsOpen Then
            Form1.SerialPort1.Close()
        End If
    End Sub

    Sub OpenSerialPort2()
        If Not Form1.SerialPort2.IsOpen Then
            Form1.SerialPort2.Open()
        End If
    End Sub
    Sub CloseSerialPort2()
        If Form1.SerialPort2.IsOpen Then
            Form1.SerialPort2.Close()
        End If
    End Sub

    Sub ResetAll()
        Master_login.Label1.Text = "Please scan your finger. SPC or Technician only"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "Engineer" Then
            SolderCutter_Form.to_PLC("@00WD00050000") ' Head 2 Set Purging to 0
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD00060000") ' Head 2 Set Cut samples t0 0
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01050000") ' Head 2 For Signal done Purging
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01060000") ' Head 2 For Signal done Cut samples
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01070000") ' Head 2 Change Spool
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01080000") ' Head 2 Counter
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01090000") ' Head 2 Counter
            Master_login.Close()
        Else

            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub
End Module

Module SPCRule_Module
    Public average As Decimal

    Public ConStr As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\LF Database\PICO Solder Weight.accdb;Persist Security Info=True;Jet OLEDB:Database Password=lfpicosolder"
    Public Connection As New OleDbConnection(ConStr)

    Public AverageData(7) As Decimal
    Sub Get_Top8()
        Connection.Open()
        Dim query As String = "SELECT TOP 8 * FROM TopAve_tb ORDER BY ID DESC"

        Using cmd As OleDbCommand = New OleDbCommand(query, Connection)

            Using reader As OleDbDataReader = cmd.ExecuteReader()
                Dim index As Integer = 0
                While reader.Read() AndAlso index < 8
                    AverageData(index) = Convert.ToDecimal(reader("Average"))
                    index += 1
                End While
            End Using
        End Using
        Connection.Close()

        For Each val As Decimal In AverageData
            Console.WriteLine(val)
        Next
    End Sub

    Sub Get_Bottom8()
        Connection.Open()
        Dim query As String = "SELECT TOP 8 * FROM BottomAve_tb ORDER BY ID DESC"

        Using cmd As OleDbCommand = New OleDbCommand(query, Connection)

            Using reader As OleDbDataReader = cmd.ExecuteReader()
                Dim index As Integer = 0
                While reader.Read() AndAlso index < 8
                    AverageData(index) = Convert.ToDecimal(reader("Average"))
                    index += 1
                End While
            End Using
        End Using
        Connection.Close()

        For Each val As Decimal In AverageData
            Console.WriteLine(val)
        Next
    End Sub

    Public Low2s As Decimal
    Public Low1s As Decimal
    Public CenterL As Decimal
    Public Upp1s As Decimal
    Public Upp2s As Decimal

    Sub Get_Sigma()

        Dim Upp As Decimal
        Dim Low As Decimal

        Dim Limit As String
        Limit = CDec(Form1.txtWeight.Text)
        Select Case Limit

            Case 12
                Low = CDec(Form1.TopLowLim)
                Upp = CDec(Form1.TopUppLim)
                Get_Top8()

            Case 14
                Low = CDec(Form1.BotLowLim)
                Upp = CDec(Form1.BotUppLim)
                Get_Bottom8()

        End Select

        Dim n As Decimal = (Upp - Low) / 6

        Low2s = Math.Round(n + Low, 4)
        Low1s = Math.Round(Low2s + n, 4)
        CenterL = Math.Round(Low1s + n, 4)
        Upp1s = Math.Round(CenterL + n, 4)
        Upp2s = Math.Round(Upp1s + n, 4)

        'MsgBox("Upp Lim: " & Upp & vbNewLine &
        '       Upp2s & vbNewLine &
        '       Upp1s & vbNewLine &
        '       "CL: " & CenterL & vbNewLine &
        '       Low1s & vbNewLine &
        '       Low2s & vbNewLine &
        '       "Low Lim: " & Low)

    End Sub

    Sub RuleOne_FlowOne()
        Dim sum As Decimal = 0
        For Each number As Decimal In Form1.data
            sum += number
        Next
        'Dim average As Double = sum / data.Length
        average = sum / Form1.data.Length

        'MsgBox("Average: " & average & vbNewLine & "Length: " & Form1.data.Length)

        Dim Limit As String
        Limit = CDec(Form1.txtWeight.Text)
        Select Case Limit

            Case 12

                SetLowLimit = CDec(Form1.TopLowLim)
                SetUpperLimit = CDec(Form1.TopUppLim)

                If average > SetUpperLimit Then '12.2435

                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = ">cUCL"

                ElseIf average < SetLowLimit Then '11.7271

                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = "<cLCL"

                End If

            Case 14

                SetLowLimit = CDec(Form1.BotLowLim)
                SetUpperLimit = CDec(Form1.BotUppLim)

                If average > SetUpperLimit Then

                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = ">cUCL"

                ElseIf average < SetLowLimit Then

                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = "<cLCL"

                End If
        End Select

        'SaveAverage()

    End Sub

    Sub RuleOne_FlowTwo()
        Dim sum As Decimal = 0
        For Each number As Decimal In Form1.data
            sum += number
        Next
        'Dim average As Double = sum / data.Length
        average = sum / Form1.data.Length

        'MsgBox("Average: " & average & vbNewLine & "Length: " & Form1.data.Length)

        Dim Limit As String
        Limit = CDec(Form1.txtWeight.Text)
        Select Case Limit

            Case 12

                SetLowLimit = CDec(Form1.TopLowLim)
                SetUpperLimit = CDec(Form1.TopUppLim)

                If average > SetUpperLimit Then '12.2435

                    Form1.TimerCheckInfi.Enabled = False
                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    SaveAverage()

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = ">cUCL"

                ElseIf average < SetLowLimit Then '11.7271

                    Form1.TimerCheckInfi.Enabled = False
                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    SaveAverage()

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = "<cLCL"

                Else

                    SaveAverage()
                    GetRule4()

                    If Rule4State = "True" Then
                        Rule4()
                    Else

                        Form1.TimerCheckInfi.Enabled = False

                        'CloseSerialPort2()

                        SolderCutter_Form.to_PLC("@00WD01080000")
                        Thread.Sleep(100)
                        SolderCutter_Form.to_PLC("@00WD01090000")

                        Form1.TimerCheckInfi.Enabled = False
                        SolderCutter_Form.TimerQtyChecking.Enabled = True
                        SolderCutter_Form.TimerChangeSpool.Enabled = True
                        Function_Module.RunMachine()
                        Cutter2_Module.C2_ChagetoStop()
                        Main_Form.btnBuyOff.Enabled = False
                        Form1.btnNewLot.Enabled = True

                        InterruptionCheck = False
                        ResetChangeSpool()

                        'SaveAverage()

                        'CloseSerialPort2()

                    End If

                End If

            Case 14

                SetLowLimit = CDec(Form1.BotLowLim)
                SetUpperLimit = CDec(Form1.BotUppLim)

                If average > SetUpperLimit Then

                    Form1.TimerCheckInfi.Enabled = False
                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    SaveAverage()

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = ">cUCL"

                ElseIf average < SetLowLimit Then

                    Form1.TimerCheckInfi.Enabled = False
                    Thread.Sleep(100)
                    Main_Form.btnSolderCutter.Enabled = False
                    Main_Form.btnSolderWeight.Enabled = False
                    Main_Form.btnBuyOff.Enabled = False
                    Main_Form.btnEval.Enabled = False

                    SaveAverage()

                    Thread.Sleep(500)

                    BiometricsOCAP()
                    OCAP_Form.txtAlarm.Text = "<cLCL"

                Else

                    SaveAverage()
                    GetRule4()

                    If Rule4State = "True" Then
                        Rule4()
                    Else

                        Form1.TimerCheckInfi.Enabled = False

                        'CloseSerialPort2()

                        SolderCutter_Form.to_PLC("@00WD01080000")
                        Thread.Sleep(100)
                        SolderCutter_Form.to_PLC("@00WD01090000")

                        Form1.TimerCheckInfi.Enabled = False
                        SolderCutter_Form.TimerQtyChecking.Enabled = True
                        SolderCutter_Form.TimerChangeSpool.Enabled = True
                        Function_Module.RunMachine()
                        Cutter2_Module.C2_ChagetoStop()
                        Main_Form.btnBuyOff.Enabled = False
                        Form1.btnNewLot.Enabled = True

                        InterruptionCheck = False
                        ResetChangeSpool()

                        'SaveAverage()

                        'CloseSerialPort2()

                    End If

                End If

        End Select
    End Sub

    Sub CheckRuleOne()
        If NewWeightmg = OldWeight And InterruptionCheck = False Then

        Else
            RuleOne_FlowOne()
        End If
    End Sub

    Sub Rule4()

        GetRule5()
        Get_Sigma()

        Dim OneLessThanCenterline As Boolean = False
        Dim OneGreaterThanCenterline As Boolean = False
        Dim hasEqualCenterline As Boolean = False

        For Each number In AverageData
            If number = CenterL Then
                hasEqualCenterline = True
            End If
            If number < CenterL Then
                OneLessThanCenterline = True
            End If
            If number > CenterL Then
                OneGreaterThanCenterline = True
            End If
        Next

        If OneGreaterThanCenterline = True And OneLessThanCenterline = True Then
            If Rule5State = "True" Then
                Rule5()
            Else

                Form1.TimerCheckInfi.Enabled = False

                'CloseSerialPort2()

                SolderCutter_Form.to_PLC("@00WD01080000")
                Thread.Sleep(100)
                SolderCutter_Form.to_PLC("@00WD01090000")

                Form1.TimerCheckInfi.Enabled = False
                SolderCutter_Form.TimerQtyChecking.Enabled = True
                SolderCutter_Form.TimerChangeSpool.Enabled = True
                Function_Module.RunMachine()
                Cutter2_Module.C2_ChagetoStop()
                Main_Form.btnBuyOff.Enabled = False
                Form1.btnNewLot.Enabled = True

                InterruptionCheck = False
                ResetChangeSpool()

                'CloseSerialPort2()

                'SaveAverage()

                'OpenSerialPort2()
                'SerialPort2.WriteLine("A") 'Activate door lock
            End If
        End If

        If (hasEqualCenterline = True And OneGreaterThanCenterline = False) Or (hasEqualCenterline = True And OneLessThanCenterline = False) Or OneGreaterThanCenterline = False Or OneLessThanCenterline = False Then
            Form1.TimerCheckInfi.Enabled = False
            BiometricsOCAP()
            OCAP_Form.txtAlarm.Text = "SPC Rule 4"
        End If

    End Sub

    Sub Rule5()

        ' check if all numbers are increasing
        Dim increasing As Boolean = CheckIncreasing(AverageData)

        ' Check if the numbers are decreasing
        Dim decreasing As Boolean = CheckDecreasing(AverageData)

        If increasing Then
            Form1.TimerCheckInfi.Enabled = False
            BiometricsOCAP()
            OCAP_Form.txtAlarm.Text = "SPC Rule 5"
        ElseIf decreasing Then
            Form1.TimerCheckInfi.Enabled = False
            BiometricsOCAP()
            OCAP_Form.txtAlarm.Text = "SPC Rule 5"
        Else

            Form1.TimerCheckInfi.Enabled = False

            'CloseSerialPort2()

            SolderCutter_Form.to_PLC("@00WD01080000")
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01090000")

            Form1.TimerCheckInfi.Enabled = False
            SolderCutter_Form.TimerQtyChecking.Enabled = True
            SolderCutter_Form.TimerChangeSpool.Enabled = True
            Function_Module.RunMachine()
            Cutter2_Module.C2_ChagetoStop()
            Main_Form.btnBuyOff.Enabled = False
            Form1.btnNewLot.Enabled = True

            InterruptionCheck = False
            ResetChangeSpool()

            'CloseSerialPort2()

            'SaveAverage()

            'OpenSerialPort2()
            'SerialPort2.WriteLine("A") 'Activate door lock

        End If
    End Sub

    Function CheckIncreasing(numbers() As Decimal) As Boolean

        For i As Integer = 1 To numbers.Length - 1
            ' Check if the current number is less than or equal to the previous number
            If numbers(i) <= numbers(i - 1) Then
                ' If found, return false
                Return False
            End If
        Next

        Return True
    End Function

    Function CheckDecreasing(numbers() As Decimal) As Boolean
        ' Loop through the array starting from the second element
        For i As Integer = 1 To numbers.Length - 1
            ' Check if the current number is greater than or equal to the previous number
            If numbers(i) >= numbers(i - 1) Then
                ' If found, return false 
                Return False
            End If
        Next

        Return True
    End Function

    Public config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

    Public Rule4State As String
    Public Rule5State As String

    Public NewRule4_State As String
    Public NewRule5_State As String

    Sub GetRule4()
        Dim state As String = System.Configuration.ConfigurationManager.AppSettings("SPCRule4")
        Console.WriteLine(state)

        Rule4State = state
    End Sub

    Sub GetRule5()
        Dim state As String = System.Configuration.ConfigurationManager.AppSettings("SPCRule5")
        Console.WriteLine(state)

        Rule5State = state
    End Sub

    Sub GetNew4_State()
        If SPCRules_Form.chkRule4.Checked = True Then
            NewRule4_State = "True"
        Else
            NewRule4_State = "False"
        End If
    End Sub
    Sub ChangeRule4_state()
        config.AppSettings.Settings("SPCRule4").Value = NewRule4_State
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

    Sub GetNew5_State()
        If SPCRules_Form.chkRule5.Checked = True Then
            NewRule5_State = "True"
        Else
            NewRule5_State = "False"
        End If
    End Sub
    Sub ChangeRule5_state()
        config.AppSettings.Settings("SPCRule5").Value = NewRule5_State
        config.Save(ConfigurationSaveMode.Modified) ' save the new value

        ConfigurationManager.RefreshSection("appSettings") 'refresh
    End Sub

End Module

Module AveQuery_Module
    Sub SaveAverage()

        Dim partno, lotno, _date As String

        partno = Form1.txtPartNo.Text
        lotno = Form1.txtLotNo.Text
        _date = Date.Now.ToString("MM/dd/yyyy hh:mmtt")

        Connect()
        Dim mycommand As String

        Dim Limit As String

        Limit = CDec(Form1.txtWeight.Text)
        Select Case Limit

            Case 12

                Try
                    myconnection.Open()
                    mycommand = "INSERT INTO [TopAve_tb] ([Average], [Part_Number], [Lot_Number], [_DateandTime]) 
                                   VALUES (@_average, @partnum, @lotnum, @_dateNtime)"
                    Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                        cmd.Parameters.AddWithValue("@_average", average)
                        cmd.Parameters.AddWithValue("@partnum", partno)
                        cmd.Parameters.AddWithValue("@lotnum", lotno)
                        cmd.Parameters.AddWithValue("@_dateNtime", _date)
                        cmd.ExecuteNonQuery()
                    End Using
                    myconnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                End Try

            Case 14

                Try
                    myconnection.Open()
                    mycommand = "INSERT INTO [BottomAve_tb] ([Average], [Part_Number], [Lot_Number], [_DateandTime]) 
                                 VALUES (@_average, @partnum, @lotnum, @_dateNtime)"
                    Using cmd As OleDbCommand = New OleDbCommand(mycommand, myconnection)
                        cmd.Parameters.AddWithValue("@_average", average)
                        cmd.Parameters.AddWithValue("@partnum", partno)
                        cmd.Parameters.AddWithValue("@lotnum", lotno)
                        cmd.Parameters.AddWithValue("@_dateNtime", _date)
                        cmd.ExecuteNonQuery()
                    End Using
                    myconnection.Close()
                Catch ex As Exception
                    MsgBox(ex.Message, vbCritical)
                End Try

        End Select

    End Sub

End Module