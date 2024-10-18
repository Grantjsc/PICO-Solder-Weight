Public Class ChangeComPort_Form
    Private Sub ChangeComPort_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadComPort1()
        LoadComPort2()
        LoadComPort3()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ChangeNames()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        cboWeighing.Items.Clear()
        cboLock.Items.Clear()
        Me.Close()
    End Sub
End Class