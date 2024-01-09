Imports System.IO.Ports

Public Class Main_Form
    Private Sub btnSolderWeight_Click(sender As Object, e As EventArgs) Handles btnSolderWeight.Click
        Mainbtn_Module.ButtonSW()
    End Sub

    Private Sub btnSolderCutter_Click(sender As Object, e As EventArgs) Handles btnSolderCutter.Click
        Mainbtn_Module.ButtonSC()
    End Sub

    Private Sub Main_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        SolderCutter_Form.Timer1.Enabled = True
    End Sub

    Private Sub Main_Form_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to exit?", "Exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Form1.SerialPort1.Close()
            'SerialPort2.WriteLine("B") 'deactivate door lock
            Application.ExitThread()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With Purging_Form
            .TopLevel = False
            PanelMain.Controls.Add(Purging_Form)
            .WindowState = FormWindowState.Maximized
            .BringToFront()
            .Show()
        End With
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Function_Module.PurgingSample()
    End Sub
End Class