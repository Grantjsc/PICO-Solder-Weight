Public Class SameLot_Form
    Private Sub btnOkay_Click(sender As Object, e As EventArgs) Handles btnOkay.Click
        Form1.txtQty.Text = ""
        Form1.txtQty.ReadOnly = False

        Form1.txtWeight.Text = "Enter weight"
        Form1.txtWeight.ForeColor = Color.Silver
        Form1.txtWeight.ReadOnly = False

        Form1.txtPartNo.ReadOnly = False
        Form1.txtPartNo.Text = "Enter Part Number"
        Form1.txtPartNo.ForeColor = Color.Silver

        Form1.txtLotNo.ReadOnly = False
        Form1.txtLotNo.Text = "Enter Lot Number"
        Form1.txtLotNo.ForeColor = Color.Silver

        Form1.txtEmployee.Text = "Samples"
        Form1.txtEmployee.ForeColor = Color.Silver

        Form1.txtQty.Focus()
        Me.Close()
    End Sub
End Class