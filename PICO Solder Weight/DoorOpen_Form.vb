Public Class DoorOpen_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click

        Form1.TimerCheckInfi.Interval = 5000
        Form1.TimerCheckInfi.Enabled = True
        Form1.checkSaveCon = True

        Me.Close()
    End Sub

    Private Sub DoorOpen_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'OpenSerialPort2()
    End Sub

End Class