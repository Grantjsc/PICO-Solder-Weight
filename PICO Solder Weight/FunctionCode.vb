Imports System.Configuration
Imports System.IO.Ports
Imports System.Threading

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

    Sub GetOldmg()
        Dim Oldmg As String = System.Configuration.ConfigurationManager.AppSettings("mg")
        Console.WriteLine(Oldmg)

        OldWeight = Oldmg
    End Sub

    Sub CheckMg()
        Dim PurgeDone = False
        Dim Samples = False

        If NewWeightmg = OldWeight Then
            SolderCutter_Form.btnC2Start.Enabled = False
            SolderCutter_Form.to_PLC("@00WD00060025")
            While Samples = False
                If SolderCutter_Form.lblSamples106.Text = CInt("100") Then
                    SolderCutter_Form.btnC2Start.Enabled = True
                    Samples = True
                End If
            End While

        Else
            SolderCutter_Form.btnC2Start.Enabled = False
            SolderCutter_Form.to_PLC("@00WD00050010")

            With Purging_Form
                .TopLevel = False
                Main_Form.PanelMain.Controls.Add(Purging_Form)
                .WindowState = FormWindowState.Maximized
                .BringToFront()
                .Show()
            End With
            While PurgeDone = False
                If SolderCutter_Form.lblPurge105.Text = CInt("100") Then
                    Purging_Form.lblMsg.Text = "The machine is cutting samples ..."
                    SolderCutter_Form.to_PLC("@00WD00060025")
                    'PurgeDone = True

                    While Samples = False
                        If SolderCutter_Form.lblSamples106.Text = CInt("100") Then
                            SolderCutter_Form.btnC2Start.Enabled = True
                            Samples = True
                            PurgeDone = True

                            Purging_Form.Close()
                        End If

                    End While
                End If
            End While
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
                Master_login.lblErrorMsg.Text = "2nd OCAP!"
                Master_login.PanelWarning.Visible = True
                Form1.TimerErrorMsg.Enabled = True

                'SerialPort1.WriteLine("B")
                'Write to PLC Error

                Master_login.Label1.Text = "Please scan your finger. Tech or PO3"
                Master_login.ShowDialog()
                If Master_login.F1_get_title = "Technician" Or Master_login.F1_get_title = "PO3" Then
                    'SerialPort1.WriteLine("A")
                    'Wite to PLC Reset Error
                    ResetOCAP()
                    ChangeOCAP()
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
        End If
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
                .BringToFront()
                .Show()
            End With
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
            SolderCutter_Form.to_PLC("@00WD00000000")
            SolderCutter_Form.TimerQtyChecking.Enabled = False
        End If
    End Sub

    Sub ChangeSpool()
        If SolderCutter_Form.lblSpool107.Text = CInt("100") And CInt(SolderCutter_Form.lblC2counter.Text) <> CInt(Form1.txtQty.Text) Then
            'SerialPort2.WriteLine("A") 'deactivate door lock
            'Form1.txtQty.Text = ""

            Dim PurgeDone = False
            Dim Samples = False

            SolderCutter_Form.btnC2Start.Enabled = False
            SolderCutter_Form.to_PLC("@00WD00050010")

            With Purging_Form
                .TopLevel = False
                Main_Form.PanelMain.Controls.Add(Purging_Form)
                .WindowState = FormWindowState.Maximized
                .BringToFront()
                .Show()
            End With

            While PurgeDone = False
                If SolderCutter_Form.lblPurge105.Text = CInt("100") Then
                    Purging_Form.lblMsg.Text = "The machine is cutting samples ..."
                    SolderCutter_Form.to_PLC("@00WD00060025")
                    'PurgeDone = True

                    While Samples = False
                        If SolderCutter_Form.lblSamples106.Text = CInt("100") Then
                            SolderCutter_Form.btnC2Start.Enabled = True
                            Samples = True
                            PurgeDone = True

                            Purging_Form.Close()
                        End If

                    End While
                End If
            End While
        End If
    End Sub

End Module