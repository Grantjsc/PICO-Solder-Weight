Imports System.Text.RegularExpressions

Public Class Eval_Form
    Private Sub Eval_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Timer1.Enabled = True
        'SerialPort1.Open()

        Main_Form.btnSolderWeight.Enabled = False
        Main_Form.btnSolderCutter.Enabled = False
        Main_Form.btnBuyOff.Enabled = False

        txtName.Text = ""
        txtKindOfEval.Text = ""
        txtWeight.Text = ""
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

        Dim matches As MatchCollection = regex.Matches(txtReading.Text)
        For Each match As Match In matches
            Console.WriteLine(match.Value)

            RealData = match.Value
        Next


        txtReading.Text = txt

        If Timer1.Enabled = False And RealData = 0.00 And RealData > -0.1 Then
            Invoke(Sub()
                       Timer1.Enabled = True
                   End Sub)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        saveEval()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Weighing()
    End Sub
    Private Sub txtWeight_KeyUp(sender As Object, e As KeyEventArgs) Handles txtWeight.KeyUp
        Evaluation = True
        GetEvalmg()
        GetOldmg()
        CheckMg()
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