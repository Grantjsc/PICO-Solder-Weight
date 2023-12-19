Module Mainbtn_Module
    Sub ButtonSW()
        Main_Form.PanelSW.Visible = True
        Main_Form.PanelSC.Visible = False

        Main_Form.btnSolderWeight.FillColor = Color.FromArgb(250, 250, 250)
        Main_Form.btnSolderCutter.FillColor = Color.Transparent

        Main_Form.btnSolderWeight.ForeColor = Color.Black
        Main_Form.btnSolderCutter.ForeColor = Color.White


        With Form1
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(Form1)
            .BringToFront()
            .Show()
        End With
    End Sub

    Sub ButtonSC()
        Main_Form.PanelSW.Visible = False
        Main_Form.PanelSC.Visible = True

        Main_Form.btnSolderWeight.FillColor = Color.Transparent
        Main_Form.btnSolderCutter.FillColor = Color.FromArgb(250, 250, 250)

        Main_Form.btnSolderWeight.ForeColor = Color.White
        Main_Form.btnSolderCutter.ForeColor = Color.Black

        With SolderCutter_Form
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(SolderCutter_Form)
            .BringToFront()
            .Show()
        End With
    End Sub
End Module