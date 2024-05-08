Imports System.Threading

Public Class BuyOff_Form
    Private Sub BuyOff_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Main_Form.btnSolderWeight.Enabled = False
        Main_Form.btnSolderCutter.Enabled = False
        Main_Form.btnEval.Enabled = False
        btnStart.Enabled = True
        txtBuyOffQty.Text = ""
    End Sub

    Private Sub btnStart_Click_1(sender As Object, e As EventArgs) Handles btnStart.Click
        If txtBuyOffQty.Text = "" Then
            MsgBox("Please enter quantity!", MsgBoxStyle.Critical)
            txtBuyOffQty.Focus()
        Else

            SolderCutter_Form.to_PLC("@00WD01080000")
            Thread.Sleep(100)
            SolderCutter_Form.to_PLC("@00WD01090000")
            Thread.Sleep(100)

            btnStart.Enabled = False
            btnExitBuyOff.Enabled = False
            Timer1.Enabled = True
            txtBuyOffQty.ReadOnly = True

            Dim CutQty As String
            Dim QtyLength As String

            CutQty = CInt(txtBuyOffQty.Text)
            QtyLength = CInt(CutQty.Length.ToString)

            Select Case QtyLength

                Case 1 'Ones
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    'SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtBuyOffQty.Text).ToString("0000"))

                Case 2 'Tens
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    'SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtBuyOffQty.Text).ToString("0000"))

                Case 3 'Hundreds
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    'SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtBuyOffQty.Text).ToString("0000"))

                Case 4 'One Thousands
                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    'SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD00080000")
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(txtBuyOffQty.Text).ToString("0000"))

                Case 5 'Ten Thousands
                    Dim str As String
                    Dim FirstDgt As String
                    Dim LastDgts As String
                    str = txtBuyOffQty.Text
                    FirstDgt = str.Substring(0, 1)
                    LastDgts = str.Substring(1, 4)

                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    'SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0008" & CInt(FirstDgt).ToString("0000"))
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(LastDgts).ToString("0000"))

                Case 6 'Hundred Thousands
                    Dim str As String
                    Dim FirstDgt As String
                    Dim LastDgts As String
                    str = txtBuyOffQty.Text
                    FirstDgt = str.Substring(0, 2)
                    LastDgts = str.Substring(2, 4)

                    SolderCutter_Form.to_PLC("@00WD00000001") 'Start Machine
                    'SolderCutter_Form.TimerQtyChecking.Enabled = True
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0008" & CInt(FirstDgt).ToString("0000"))
                    Thread.Sleep(500)
                    SolderCutter_Form.to_PLC("@00WD0007" & CInt(LastDgts).ToString("0000"))

                Case Else

            End Select
        End If
    End Sub

    Public Sub Done()
        If CInt(lblcounter.Text) = CInt(txtBuyOffQty.Text) Then
            Timer1.Enabled = False
            Dim dialog As DialogResult
            dialog = MsgBox("Done!", MsgBoxStyle.Information)
            If dialog = DialogResult.OK Then
                txtBuyOffQty.Text = ""

                btnExitBuyOff.Enabled = True
                txtBuyOffQty.ReadOnly = False

                Main_Form.PanelBuyOff.Visible = False
                Main_Form.btnBuyOff.FillColor = Color.Transparent
                Main_Form.btnBuyOff.ForeColor = Color.White

                Main_Form.btnBuyOff.Image = My.Resources.buyoff

                Main_Form.btnSolderWeight.Enabled = True
                Main_Form.btnSolderCutter.Enabled = True
                Main_Form.btnEval.Enabled = True

                SolderCutter_Form.to_PLC("@00WD01080000")
                Thread.Sleep(100)
                SolderCutter_Form.to_PLC("@00WD01090000")
                Thread.Sleep(100)
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Done()
    End Sub

    Private Sub btnExitBuyOff_Click(sender As Object, e As EventArgs) Handles btnExitBuyOff.Click
        Main_Form.PanelBuyOff.Visible = False
        Main_Form.btnBuyOff.FillColor = Color.Transparent
        Main_Form.btnBuyOff.ForeColor = Color.White

        Main_Form.btnBuyOff.Image = My.Resources.buyoff

        Main_Form.btnSolderWeight.Enabled = True
        Main_Form.btnSolderCutter.Enabled = True
        Main_Form.btnEval.Enabled = True
        Me.Close()
    End Sub
End Class