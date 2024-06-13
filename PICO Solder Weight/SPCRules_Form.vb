Imports System.Threading

Public Class SPCRules_Form
    Private Sub SPCRules_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetRule4()
        GetRule5()

        If Rule4State = "True" And Rule5State = "False" Then
            chkRule4.Checked = True
            chkRule5.Checked = False
        ElseIf Rule4State = "False" And Rule5State = "True" Then
            chkRule4.Checked = False
            chkRule5.Checked = True
        ElseIf Rule4State = "True" And Rule5State = "True" Then
            chkRule4.Checked = True
            chkRule5.Checked = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If chkRule4.Checked = False And chkRule5.Checked = False Then
            NewRule4_State = "False"
            NewRule4_State = "False"
        ElseIf chkRule4.Checked = True And chkRule5.Checked = False Then
            NewRule4_State = "True"
            NewRule4_State = "False"
        ElseIf chkRule4.Checked = False And chkRule5.Checked = True Then
            NewRule4_State = "False"
            NewRule4_State = "True"
        ElseIf chkRule4.Checked = True And chkRule5.Checked = True Then
            NewRule4_State = "True"
            NewRule4_State = "True"
        End If

        GetNew4_State()
        ChangeRule4_state()
        Thread.Sleep(500)
        GetNew5_State()
        ChangeRule5_state()

        Me.Close()
    End Sub
End Class