Imports System.IO.Ports
Imports System.Text.RegularExpressions
Imports System.Threading

Public Class Eval_Form
    Private Sub Eval_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not SerialPort1.IsOpen Then
            SerialPort1.Open()
        End If

        SerialPort1.WriteLine("Z")
        Thread.Sleep(500)
        SerialPort1.WriteLine("CP")

        Timer1.Enabled = True

        Main_Form.btnSolderWeight.Enabled = False
        Main_Form.btnSolderCutter.Enabled = False
        Main_Form.btnBuyOff.Enabled = False
        btnSave.Enabled = False

        txtName.Text = ""
        txtKindOfEval.Text = ""
        txtWeight.Text = ""
        SolderCutter_Form.to_PLC("@00WD01070000") 'door unlocked
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        txt = SerialPort1.ReadLine

        txt = txt.Replace(" ", "")
        txt = txt.Replace("?", "")
        txt = txt.Replace("N", "")
        txt = txt.Replace(vbCr, "")
        txt = txt.Replace(vbLf, "")
        txt = txt.Replace("-OHAUS-", "")

        Dim regex As New Regex("-?\d+(\.\d+)?")

        Dim matches As MatchCollection = regex.Matches(txtEvalReading.Text)
        For Each match As Match In matches
            Console.WriteLine(match.Value)

            RealData = match.Value
        Next


        txtEvalReading.Text = txt

        If Timer1.Enabled = False And RealData = 0.00 And RealData > -0.1 Then
            Invoke(Sub()
                       Timer1.Enabled = True
                   End Sub)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If SolderCutter_Form.lblDoor_110.Text = 1 Then
            SolderCutter_Form.to_PLC("@00WD01070000") 'door locked

            saveEval()
        Else

            Dim dialog As DialogResult
            dialog = MessageBox.Show("Kindly close the door.", "PICO Solder Weight Closed loop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If dialog = DialogResult.OK Then
                'e.Cancel = True
                OpenSerialPort2()
            End If
            'MsgBox("Kindly close the door.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Weighing()
    End Sub
    Private Sub txtWeight_KeyUp(sender As Object, e As KeyEventArgs) Handles txtWeight.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtWeight.Text = 12 Or txtWeight.Text = 14 Then
                Evaluation = True
                GetEvalmg()
                GetOldmg()
                CheckMg()
            Else
                MsgBox("Please input 12 or 14 only", MsgBoxStyle.Critical)
                txtWeight.Text = ""
            End If
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

    Private Sub btnExitEval_Click(sender As Object, e As EventArgs) Handles btnExitEval.Click

        If SolderCutter_Form.lblDoor_110.Text = 1 Then

            SolderCutter_Form.to_PLC("@00WD01070000") 'door locked

            Timer1.Enabled = False
            txtEvalReading.Text = ""

            Main_Form.PanelEval.Visible = False
            Main_Form.btnEval.FillColor = Color.Transparent
            Main_Form.btnEval.ForeColor = Color.White

            Main_Form.btnEval.Image = My.Resources.evaluation

            Main_Form.btnSolderWeight.Enabled = True
            Main_Form.btnSolderCutter.Enabled = True
            Main_Form.btnBuyOff.Enabled = True
            Evaluation = False

            'If SerialPort1.IsOpen Then
            '    SerialPort1.Close()
            'End If

            Me.Close()

        Else

            Dim dialog As DialogResult
            dialog = MessageBox.Show("Kindly close the door.", "PICO Solder Weight Closed loop", MessageBoxButtons.OK, MessageBoxIcon.Information)
            If dialog = DialogResult.OK Then
                'e.Cancel = True
                OpenSerialPort2()
            End If
            'MsgBox("Kindly close the door.", MsgBoxStyle.Information)
        End If
    End Sub
End Class