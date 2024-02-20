Imports System.Threading

Public Class askChangeCutterSet_Form
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
        Function_Module.PurgeAfterOCAP()
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Me.Close()
        Thread.Sleep(100)
        NewCutterSet_Form.ShowDialog()
    End Sub
End Class