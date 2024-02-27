Module Mainbtn_Module
    Sub ButtonSW()
        Main_Form.PanelSW.Visible = True
        Main_Form.PanelSC.Visible = False
        Main_Form.PanelBuyOff.Visible = False
        Main_Form.PanelEval.Visible = False

        Main_Form.btnSolderWeight.FillColor = Color.FromArgb(250, 250, 250)
        Main_Form.btnSolderCutter.FillColor = Color.Transparent
        Main_Form.btnBuyOff.FillColor = Color.Transparent
        Main_Form.btnEval.FillColor = Color.Transparent

        Main_Form.btnSolderWeight.ForeColor = Color.Black
        Main_Form.btnSolderCutter.ForeColor = Color.White
        Main_Form.btnBuyOff.ForeColor = Color.White
        Main_Form.btnEval.ForeColor = Color.White


        With Form1
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(Form1)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub ButtonSC()
        Main_Form.PanelSW.Visible = False
        Main_Form.PanelSC.Visible = True
        Main_Form.PanelBuyOff.Visible = False
        Main_Form.PanelEval.Visible = False

        Main_Form.btnSolderWeight.FillColor = Color.Transparent
        Main_Form.btnSolderCutter.FillColor = Color.FromArgb(250, 250, 250)
        Main_Form.btnBuyOff.FillColor = Color.Transparent
        Main_Form.btnEval.FillColor = Color.Transparent

        Main_Form.btnSolderWeight.ForeColor = Color.White
        Main_Form.btnSolderCutter.ForeColor = Color.Black
        Main_Form.btnBuyOff.ForeColor = Color.White
        Main_Form.btnEval.ForeColor = Color.White

        With SolderCutter_Form
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(SolderCutter_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub ButtonBuyOff()
        Main_Form.PanelSW.Visible = False
        Main_Form.PanelSC.Visible = False
        Main_Form.PanelBuyOff.Visible = True
        Main_Form.PanelEval.Visible = False

        Main_Form.btnSolderWeight.FillColor = Color.Transparent
        Main_Form.btnSolderCutter.FillColor = Color.Transparent
        Main_Form.btnBuyOff.FillColor = Color.FromArgb(250, 250, 250)
        Main_Form.btnEval.FillColor = Color.Transparent

        Main_Form.btnSolderWeight.ForeColor = Color.White
        Main_Form.btnSolderCutter.ForeColor = Color.White
        Main_Form.btnBuyOff.ForeColor = Color.Black
        Main_Form.btnEval.ForeColor = Color.White

        With BuyOff_Form
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(BuyOff_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub BuyOffBiometrics()
        Dim Fngerprint = False
        While Fngerprint = False

            Master_login.Label1.Text = "Please scan your finger. SPC, P03 or Production only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "PO3" Or Master_login.F1_get_title = "Engineer" Or Master_login.F1_get_title = "Production" Then
                ButtonBuyOff()
                Fngerprint = True
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End While
    End Sub

    Sub ButtonEval()
        Main_Form.PanelSW.Visible = False
        Main_Form.PanelSC.Visible = False
        Main_Form.PanelBuyOff.Visible = False
        Main_Form.PanelEval.Visible = True

        Main_Form.btnSolderWeight.FillColor = Color.Transparent
        Main_Form.btnSolderCutter.FillColor = Color.Transparent
        Main_Form.btnBuyOff.FillColor = Color.Transparent
        Main_Form.btnEval.FillColor = Color.FromArgb(250, 250, 250)

        Main_Form.btnSolderWeight.ForeColor = Color.White
        Main_Form.btnSolderCutter.ForeColor = Color.White
        Main_Form.btnBuyOff.ForeColor = Color.White
        Main_Form.btnEval.ForeColor = Color.Black

        With Eval_Form
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(Eval_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub EvalBiometrics()
        Dim Fngerprint = False
        While Fngerprint = False

            Master_login.Label1.Text = "Please scan your finger. SPC, QA or Product only"
            Master_login.ShowDialog()
            If Master_login.F1_get_title = "SPC" Or Master_login.F1_get_title = "QA" Or Master_login.F1_get_title = "Engineer" Or Master_login.F1_get_title = "Product" Then
                askEval_Form.ShowDialog()
                Fngerprint = True
            Else

                MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
                Master_login.Close()
            End If
        End While
    End Sub
End Module