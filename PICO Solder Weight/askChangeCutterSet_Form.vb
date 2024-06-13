Imports System.Threading

Public Class askChangeCutterSet_Form
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        OpenSerialPort2()
        Form1.SerialPort2.WriteLine("A") 'door unlock
        'CloseSerialPort2()
        Me.Close()
        Function_Module.PurgeAfterOCAP()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Close()
        Thread.Sleep(100)
        NewCutterSet_Form.ShowDialog()
    End Sub
End Class