Imports System.IO.Ports

Public Class Main_Form
    Private Sub btnSolderWeight_Click(sender As Object, e As EventArgs) Handles btnSolderWeight.Click
        Mainbtn_Module.ButtonSW()
    End Sub

    Private Sub btnSolderCutter_Click(sender As Object, e As EventArgs) Handles btnSolderCutter.Click
        Mainbtn_Module.ButtonSC()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized

        If SolderCutter_Form.Timer1.Enabled = False Then
            SolderCutter_Form.Timer1.Enabled = True
        End If


        GetLockSerialName()
        GetWeighingSerialName()
        GetPLCSerialName()

        Form1.SerialPort1.PortName = WeighingSerial
        Form1.SerialPort2.PortName = LockSerial
        SolderCutter_Form.SerialPort1.PortName = PLCSerial

        'Form1.SerialPort1.Open()
        'Form1.SerialPort2.Open()

        'SolderCutter_Form.to_PLC("@00WD00030000") 'door locked
        'SolderCutter_Form.to_PLC("@00WD01070000") 'Software is open

        'Dim Fngerprint = False
        'While Fngerprint = False

        '    Master_login.Label1.Text = "Please scan your finger."
        '    Master_login.ShowDialog()
        '    If Master_login.F1_get_title = "Engineer" Then
        '        Me.WindowState = FormWindowState.Maximized
        '        Master_login.Close()
        '        Fngerprint = True
        '    Else

        '        MsgBox("Authorized personnel only!", MsgBoxStyle.Exclamation)
        '        Master_login.Close()
        '    End If

        'End While
    End Sub

    Private Sub Main_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If SolderCutter_Form.lblDoor_110.Text = 1 Then

            Dim dialog As DialogResult
            dialog = MessageBox.Show("Do you really want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dialog = DialogResult.No Then
                e.Cancel = True
            Else

                If Form1.SerialPort1.IsOpen Then
                    Form1.SerialPort1.Close()
                End If
                SolderCutter_Form.to_PLC("@00WD00030000") 'door locked
                'SolderCutter_Form.to_PLC("@00WD01070000") 'Software is Close
                Application.ExitThread()
            End If

        Else
            Dim dialog As DialogResult
            dialog = MessageBox.Show("Kindly close the door.", "PICO Solder Weight Closed loop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If dialog = DialogResult.OK Then
                e.Cancel = True
            End If
            'MsgBox("Kindly close the door.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Purging_Form
            .TopLevel = False
            PanelMain.Controls.Add(Purging_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Function_Module.PurgingSample()
    End Sub

    Private Sub btnBuyOff_Click(sender As Object, e As EventArgs) Handles btnBuyOff.Click
        BuyOffBiometrics()
    End Sub

    Private Sub btnEval_Click(sender As Object, e As EventArgs) Handles btnEval.Click
        EvalBiometrics()
    End Sub
End Class