Imports System.Configuration
Imports System.IO.Ports

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

End Module