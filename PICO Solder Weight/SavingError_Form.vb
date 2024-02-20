Public Class SavingError_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If Form1.csvfull = True Then
            Form1.csvfull = False
            Me.Close()
        Else
            Function_Module.CheckSavingOption()
        End If
    End Sub

    Private Sub SavingError_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOkay.Focus()
        Dim buttonCenter As Point = btnOkay.PointToScreen(New Point(btnOkay.Width \ 2, btnOkay.Height \ 2))

        Cursor.Position = buttonCenter
    End Sub
End Class