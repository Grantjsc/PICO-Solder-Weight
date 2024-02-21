﻿Imports System.Threading

Public Class ChangeSpoolMsg_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        With Form1
            .TopLevel = False
            Main_Form.PanelMain.Controls.Add(Form1)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()

            'SerialPort2.WriteLine("B") 'deactivate door lock

            Form1.count = 0
            Form1.lstResult.Items.Clear()
            Array.Clear(Form1.data, 0, Form1.data.Length)
            'Form1.cboAssociate.Text = Nothing
            Thread.Sleep(500)
            If Form1.SerialPort1.IsOpen Then
                Form1.SerialPort1.Close()
            End If

            'If CInt(SolderCutter_Form.lblC2counter.Text) <> CInt(Form1.txtQty.Text) Then
            Dim NewQty As Integer
            NewQty = CInt(Form1.txtQty.Text) - CInt(SolderCutter_Form.lblC2counter.Text)
            Form1.txtQty.Text = NewQty
            'End If

            Form1.txtReading.Text = ""
            'Form1.txtQty.ReadOnly = False
            'Form1.txtQty.Focus()
            Form1.btnSave.Enabled = False
            Form1.btnNewLot.Enabled = False
            Form1.cboAssociate.Text = Nothing
            Form1.cboAssociate.Focus()

            'SolderCutter_Form.to_PLC("@00WD00000000")

            'GetLockSerialName()
            'SerialPort2.PortName = LockSerial
            'OpenSerialPort2()
            'SerialPort2.WriteLine("B") 'deactivate door lock

        End With
        Me.Close()
        Thread.Sleep(100)
        ReEnterName_Form.ShowDialog()
    End Sub

    Private Sub ChangeSpoolMsg_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnOkay.Focus()
        Dim buttonCenter As Point = btnOkay.PointToScreen(New Point(btnOkay.Width \ 2, btnOkay.Height \ 2))

        Cursor.Position = buttonCenter
    End Sub
End Class