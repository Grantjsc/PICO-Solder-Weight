Imports System.Threading

Public Class BuyOff_Form
    Private Sub BuyOff_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Form.btnSolderWeight.Enabled = False
        Main_Form.btnSolderCutter.Enabled = False
        Main_Form.btnEval.Enabled = False
        btnStart.Enabled = True
    End Sub

    Private Sub btnStart_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtQty.Text = "" Then
            MsgBox("Please enter quantity!", MsgBoxStyle.Critical)
            txtQty.Focus()
        Else
            Timer1.Enabled = True

            SolderCutter_Form.to_PLC("@00WD01080000")
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01090000")
            Thread.Sleep(100)

            Dim CutQty As String
            Dim QtyLength As String

            CutQty = CInt(txtQty.Text)
            QtyLength = CInt(CutQty.Length.ToString)

            Select Case QtyLength

                Case 1 'Ones
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtQty.Text).ToString("0000"))

                Case 2 'Tens
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtQty.Text).ToString("0000"))

                Case 3 'Hundreds
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtQty.Text).ToString("0000"))

                Case 4 'One Thousands
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtQty.Text).ToString("0000"))

                Case 5 'Ten Thousands
                    Dim str As String
                    Dim FirstDgt As String
                    Dim LastDgts As String
                    str = txtQty.Text
                    FirstDgt = str.Substring(0, 1)
                    LastDgts = str.Substring(1, 4)

                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0008" & CInt(FirstDgt).ToString("0000"))
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(LastDgts).ToString("0000"))

                Case 6 'Hundred Thousands
                    Dim str As String
                    Dim FirstDgt As String
                    Dim LastDgts As String
                    str = txtQty.Text
                    FirstDgt = str.Substring(0, 2)
                    LastDgts = str.Substring(2, 4)

                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0008" & CInt(FirstDgt).ToString("0000"))
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(LastDgts).ToString("0000"))

                Case Else

            End Select
        End If

        btnStart.Enabled = False
        'txtQty.Text = ""
        'Cutter2_Module.C2_ChagetoStop()
        'Me.Close()
    End Sub

    Public Sub Done()
        If CInt(lblcounter.Text) = CInt(txtQty.Text) Then
            Timer1.Enabled = False
            Dim dialog As DialogResult
            dialog = MsgBox("Done!", MsgBoxStyle.Information)
            If dialog = DialogResult.OK Then
                txtQty.Text = ""
                Main_Form.btnSolderWeight.Enabled = True
                Main_Form.btnSolderCutter.Enabled = True
                Main_Form.btnEval.Enabled = True
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Done()
    End Sub

End Class