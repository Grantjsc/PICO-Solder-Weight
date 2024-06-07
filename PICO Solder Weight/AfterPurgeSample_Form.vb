Imports System.Threading

Public Class AfterPurgeSample_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        'Form1.SerialPort1.WriteLine("Z")
        'Thread.Sleep(100)
        'Form1.SerialPort1.WriteLine("CP")

        Purging_Form.lblMsg.Text = "The machine is cutting samples ..."
        SolderCutter_Form.to_PLC("@00WD00060010")
        Thread.Sleep(500)
        Purging_Form.TimerPurgingAndSamples.Enabled = True
        'PurgeDone = True
        Samples = True
        Purging_Form.btnStartCut.Visible = False
        Purging_Form.btnCutSample.Visible = True

        Me.Close()
    End Sub
End Class