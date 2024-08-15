Imports System.IO.Ports

Public Class DoorOpen_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Me.Close()
    End Sub

    Private Sub DoorOpen_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not Form1.SerialPort2.IsOpen Then
            Form1.SerialPort2.Open()
        End If
    End Sub

End Class