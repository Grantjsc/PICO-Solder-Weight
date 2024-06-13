Public Class NewCutterSet_Form
    Private Sub txtNewCutSet_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewCutSet.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        If txtNewCutSet.Text = "" Then
            MsgBox("Please enter new cutter setting", MsgBoxStyle.Critical)
        Else
            Form1.txtCutterSet.Text = txtNewCutSet.Text

            OpenSerialPort2()
            Form1.SerialPort2.WriteLine("A") 'door unlock
            'CloseSerialPort2()

            Me.Close()
            Function_Module.PurgeAfterOCAP()
        End If
    End Sub

    Private Sub NewCutterSet_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtNewCutSet.Text = ""
        txtNewCutSet.Focus()
        Dim txtCenter As Point = txtNewCutSet.PointToScreen(New Point(txtNewCutSet.Width \ 2, txtNewCutSet.Height \ 2))

        Cursor.Position = txtCenter
    End Sub
End Class