Public Class ReEnterName_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub

    Private Sub ReEnterName_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOkay.Focus()
        Dim buttonCenter As Point = btnOkay.PointToScreen(New Point(btnOkay.Width \ 2, btnOkay.Height \ 2))

        Cursor.Position = buttonCenter
    End Sub
End Class