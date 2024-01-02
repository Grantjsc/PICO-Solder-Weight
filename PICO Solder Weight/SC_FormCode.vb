Module Cutter1_Module
    Sub C1_ButtonStart()
        If SolderCutter_Form.btnC1Start.Text = "Start" Then
            SolderCutter_Form.btnC1Start.Text = "Stop"
            SolderCutter_Form.btnC1Start.FillColor = Color.Maroon
            SolderCutter_Form.btnC1Start.FillColor2 = Color.Red
            SolderCutter_Form.btnC1Start.ForeColor = Color.White

            'SolderCutter_Form.to_PLC("@00WD00000001")
        Else
            SolderCutter_Form.btnC1Start.Text = "Start"
            SolderCutter_Form.btnC1Start.FillColor = Color.LightGreen
            SolderCutter_Form.btnC1Start.FillColor2 = Color.Green
            SolderCutter_Form.btnC1Start.ForeColor = Color.Black

            'SolderCutter_Form.to_PLC("@00WD00000001")
        End If
    End Sub

    Dim C1JogP As Integer
    Dim C1JogM As Integer
    Sub C1_JogPlus()
        If C1JogP = 0 Then
            SolderCutter_Form.btnC1JogPlus.Image = My.Resources.add_White
            SolderCutter_Form.btnC1JogPlus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC1JogPlus.ForeColor = Color.White
            SolderCutter_Form.btnC1JogMinus.Enabled = False

            'SolderCutter_Form.to_PLC("@00WD05000003") 'Start run = #3
            C1JogP = 1
        Else
            SolderCutter_Form.btnC1JogPlus.Image = My.Resources.add_Blue
            SolderCutter_Form.btnC1JogPlus.FillColor = Color.White
            SolderCutter_Form.btnC1JogPlus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC1JogMinus.Enabled = True

            'SolderCutter_Form.to_PLC("@00WD05000003") 'Start run = #3
            C1JogP = 0
        End If
    End Sub

    Sub C1_JogMinus()
        If C1JogM = 0 Then
            SolderCutter_Form.btnC1JogMinus.Image = My.Resources.minus_White
            SolderCutter_Form.btnC1JogMinus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC1JogMinus.ForeColor = Color.White
            SolderCutter_Form.btnC1JogPlus.Enabled = False

            'SolderCutter_Form.to_PLC("@00WD05000003") 'Start run = #3
            C1JogM = 1
        Else
            SolderCutter_Form.btnC1JogMinus.Image = My.Resources.minus_Blue
            SolderCutter_Form.btnC1JogMinus.FillColor = Color.White
            SolderCutter_Form.btnC1JogMinus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC1JogPlus.Enabled = True

            'SolderCutter_Form.to_PLC("@00WD05000003") 'Start run = #3
            C1JogM = 0
        End If
    End Sub

    Sub C1_Cut()
        'SolderCutter_Form.to_PLC("@00WD00020001")
    End Sub

    Sub C1_Reset()
        'SolderCutter_Form.to_PLC("@00WD00020002")
    End Sub

End Module

Module Cutter2_Module
    Sub C2_ButtonStart()
        If SolderCutter_Form.btnC2Start.Text = "Start" Then
            SolderCutter_Form.btnC2Start.Text = "Stop"
            SolderCutter_Form.btnC2Start.FillColor = Color.Maroon
            SolderCutter_Form.btnC2Start.FillColor2 = Color.Red
            SolderCutter_Form.btnC2Start.ForeColor = Color.White

            SolderCutter_Form.to_PLC("@00WD00000001")
        Else
            SolderCutter_Form.btnC2Start.Text = "Start"
            SolderCutter_Form.btnC2Start.FillColor = Color.LightGreen
            SolderCutter_Form.btnC2Start.FillColor2 = Color.Green
            SolderCutter_Form.btnC2Start.ForeColor = Color.Black

            SolderCutter_Form.to_PLC("@00WD00000000")
        End If
    End Sub

    Dim C2JogP As Integer
    Dim C2JogM As Integer
    Sub C2_JogPlus()
        If C2JogP = 0 Then
            SolderCutter_Form.btnC2JogPlus.Image = My.Resources.add_White
            SolderCutter_Form.btnC2JogPlus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC2JogPlus.ForeColor = Color.White
            SolderCutter_Form.btnC2JogMinus.Enabled = False

            SolderCutter_Form.to_PLC("@00WD00010001")
            C2JogP = 1
        Else
            SolderCutter_Form.btnC2JogPlus.Image = My.Resources.add_Blue
            SolderCutter_Form.btnC2JogPlus.FillColor = Color.White
            SolderCutter_Form.btnC2JogPlus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC2JogMinus.Enabled = True

            SolderCutter_Form.to_PLC("@00WD00010000")
            C2JogP = 0
        End If
    End Sub

    Sub C2_JogMinus()
        If C2JogM = 0 Then
            SolderCutter_Form.btnC2JogMinus.Image = My.Resources.minus_White
            SolderCutter_Form.btnC2JogMinus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC2JogMinus.ForeColor = Color.White
            SolderCutter_Form.btnC2JogPlus.Enabled = False

            SolderCutter_Form.to_PLC("@00WD00010002")
            C2JogM = 1
        Else
            SolderCutter_Form.btnC2JogMinus.Image = My.Resources.minus_Blue
            SolderCutter_Form.btnC2JogMinus.FillColor = Color.White
            SolderCutter_Form.btnC2JogMinus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC2JogPlus.Enabled = True

            SolderCutter_Form.to_PLC("@00WD00010000")
            C2JogM = 0
        End If
    End Sub

    Sub C2_Cut()
        SolderCutter_Form.to_PLC("@00WD00020001")
    End Sub

    Sub C2_Reset()
        Master_login.lblErrorMsg.Visible = False
        Master_login.PanelWarning.Visible = False
        Form1.TimerErrorMsg.Enabled = False

        Master_login.Label1.Text = "Please scan your finger. SPC only"
        Master_login.ShowDialog()
        If Master_login.F1_get_title = "SPC" Then
            SolderCutter_Form.to_PLC("@00WD00020002")
            Master_login.Close()
        Else
            MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
            Master_login.Close()
        End If
    End Sub

End Module

Module Cutter3_Module
    Sub C3_ButtonStart()
        If SolderCutter_Form.btnC3Start.Text = "Start" Then
            SolderCutter_Form.btnC3Start.Text = "Stop"
            SolderCutter_Form.btnC3Start.FillColor = Color.Maroon
            SolderCutter_Form.btnC3Start.FillColor2 = Color.Red
            SolderCutter_Form.btnC3Start.ForeColor = Color.White

            'SolderCutter_Form.to_PLC("@00WD00000001")
        Else
            SolderCutter_Form.btnC3Start.Text = "Start"
            SolderCutter_Form.btnC3Start.FillColor = Color.LightGreen
            SolderCutter_Form.btnC3Start.FillColor2 = Color.Green
            SolderCutter_Form.btnC3Start.ForeColor = Color.Black

            'SolderCutter_Form.to_PLC("@00WD00000001")
        End If
    End Sub

    Dim C3JogP As Integer
    Dim C3JogM As Integer
    Sub C3_JogPlus()
        If C3JogP = 0 Then
            SolderCutter_Form.btnC3JogPlus.Image = My.Resources.add_White
            SolderCutter_Form.btnC3JogPlus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC3JogPlus.ForeColor = Color.White
            SolderCutter_Form.btnC3JogMinus.Enabled = False

            'SolderCutter_Form.to_PLC("@00WD00010001")
            C3JogP = 1
        Else
            SolderCutter_Form.btnC3JogPlus.Image = My.Resources.add_Blue
            SolderCutter_Form.btnC3JogPlus.FillColor = Color.White
            SolderCutter_Form.btnC3JogPlus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC3JogMinus.Enabled = True

            'SolderCutter_Form.to_PLC("@@00WD00010000")
            C3JogP = 0
        End If
    End Sub

    Sub C3_JogMinus()
        If C3JogM = 0 Then
            SolderCutter_Form.btnC3JogMinus.Image = My.Resources.minus_White
            SolderCutter_Form.btnC3JogMinus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC3JogMinus.ForeColor = Color.White
            SolderCutter_Form.btnC3JogPlus.Enabled = False

            'SolderCutter_Form.to_PLC("@00WD00010002")
            C3JogM = 1
        Else
            SolderCutter_Form.btnC3JogMinus.Image = My.Resources.minus_Blue
            SolderCutter_Form.btnC3JogMinus.FillColor = Color.White
            SolderCutter_Form.btnC3JogMinus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC3JogPlus.Enabled = True

            'SolderCutter_Form.to_PLC("@00WD00010000")
            C3JogM = 0
        End If
    End Sub

    Sub C3_Cut()
        'SolderCutter_Form.to_PLC("@00WD00020001")
    End Sub

    Sub C3_Reset()
        'SolderCutter_Form.to_PLC("@00WD00020002")
    End Sub

End Module
Module Cutter4_Module
    Sub C4_ButtonStart()
        If SolderCutter_Form.btnC4Start.Text = "Start" Then
            SolderCutter_Form.btnC4Start.Text = "Stop"
            SolderCutter_Form.btnC4Start.FillColor = Color.Maroon
            SolderCutter_Form.btnC4Start.FillColor2 = Color.Red
            SolderCutter_Form.btnC4Start.ForeColor = Color.White

            'SolderCutter_Form.to_PLC("@00WD00000001")
        Else
            SolderCutter_Form.btnC4Start.Text = "Start"
            SolderCutter_Form.btnC4Start.FillColor = Color.LightGreen
            SolderCutter_Form.btnC4Start.FillColor2 = Color.Green
            SolderCutter_Form.btnC4Start.ForeColor = Color.Black

            'SolderCutter_Form.to_PLC("@00WD00000001")
        End If
    End Sub

    Dim C4JogP As Integer
    Dim C4JogM As Integer
    Sub C4_JogPlus()
        If C4JogP = 0 Then
            SolderCutter_Form.btnC4JogPlus.Image = My.Resources.add_White
            SolderCutter_Form.btnC4JogPlus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC4JogPlus.ForeColor = Color.White
            SolderCutter_Form.btnC4JogMinus.Enabled = False

            'SolderCutter_Form.to_PLC("@00WD00010001")
            C4JogP = 1
        Else
            SolderCutter_Form.btnC4JogPlus.Image = My.Resources.add_Blue
            SolderCutter_Form.btnC4JogPlus.FillColor = Color.White
            SolderCutter_Form.btnC4JogPlus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC4JogMinus.Enabled = True

            'SolderCutter_Form.to_PLC("@@00WD00010000")
            C4JogP = 0
        End If
    End Sub

    Sub C4_JogMinus()
        If C4JogM = 0 Then
            SolderCutter_Form.btnC4JogMinus.Image = My.Resources.minus_White
            SolderCutter_Form.btnC4JogMinus.FillColor = Color.RoyalBlue
            SolderCutter_Form.btnC4JogMinus.ForeColor = Color.White
            SolderCutter_Form.btnC4JogPlus.Enabled = False

            'SolderCutter_Form.to_PLC("@00WD00010002")
            C4JogM = 1
        Else
            SolderCutter_Form.btnC4JogMinus.Image = My.Resources.minus_Blue
            SolderCutter_Form.btnC4JogMinus.FillColor = Color.White
            SolderCutter_Form.btnC4JogMinus.ForeColor = Color.FromArgb(94, 148, 255)
            SolderCutter_Form.btnC4JogPlus.Enabled = True

            'SolderCutter_Form.to_PLC("@00WD00010000")
            C4JogM = 0
        End If
    End Sub

    Sub C4_Cut()
        'SolderCutter_Form.to_PLC("@00WD00020001")
    End Sub

    Sub C4_Reset()
        'SolderCutter_Form.to_PLC("@00WD00020002")
    End Sub

End Module