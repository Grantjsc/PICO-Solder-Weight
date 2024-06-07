<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purging_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMsg = New System.Windows.Forms.Label()
        Me.TimerPurgingAndSamples = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCutSamples = New System.Windows.Forms.Timer(Me.components)
        Me.btnStartCut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnCutSample = New Guna.UI2.WinForms.Guna2Button()
        Me.SuspendLayout()
        '
        'lblMsg
        '
        Me.lblMsg.BackColor = System.Drawing.Color.Transparent
        Me.lblMsg.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsg.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblMsg.Location = New System.Drawing.Point(138, 355)
        Me.lblMsg.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMsg.Name = "lblMsg"
        Me.lblMsg.Size = New System.Drawing.Size(835, 216)
        Me.lblMsg.TabIndex = 5
        Me.lblMsg.Text = "The machine is purging ..."
        Me.lblMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TimerPurgingAndSamples
        '
        '
        'TimerCutSamples
        '
        '
        'btnStartCut
        '
        Me.btnStartCut.BackColor = System.Drawing.Color.Transparent
        Me.btnStartCut.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnStartCut.BorderRadius = 18
        Me.btnStartCut.BorderThickness = 3
        Me.btnStartCut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStartCut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnStartCut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnStartCut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnStartCut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnStartCut.FillColor = System.Drawing.Color.White
        Me.btnStartCut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartCut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStartCut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStartCut.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStartCut.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnStartCut.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartCut.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnStartCut.Location = New System.Drawing.Point(469, 582)
        Me.btnStartCut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnStartCut.Name = "btnStartCut"
        Me.btnStartCut.ShadowDecoration.BorderRadius = 18
        Me.btnStartCut.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnStartCut.ShadowDecoration.Depth = 20
        Me.btnStartCut.ShadowDecoration.Enabled = True
        Me.btnStartCut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnStartCut.Size = New System.Drawing.Size(116, 50)
        Me.btnStartCut.TabIndex = 76
        Me.btnStartCut.Text = "Start"
        '
        'btnCutSample
        '
        Me.btnCutSample.BackColor = System.Drawing.Color.Transparent
        Me.btnCutSample.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnCutSample.BorderRadius = 18
        Me.btnCutSample.BorderThickness = 3
        Me.btnCutSample.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCutSample.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnCutSample.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnCutSample.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnCutSample.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnCutSample.FillColor = System.Drawing.Color.White
        Me.btnCutSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCutSample.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCutSample.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCutSample.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCutSample.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnCutSample.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCutSample.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnCutSample.Location = New System.Drawing.Point(461, 582)
        Me.btnCutSample.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCutSample.Name = "btnCutSample"
        Me.btnCutSample.ShadowDecoration.BorderRadius = 18
        Me.btnCutSample.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCutSample.ShadowDecoration.Depth = 20
        Me.btnCutSample.ShadowDecoration.Enabled = True
        Me.btnCutSample.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnCutSample.Size = New System.Drawing.Size(116, 50)
        Me.btnCutSample.TabIndex = 77
        Me.btnCutSample.Text = "Start"
        Me.btnCutSample.Visible = False
        '
        'Purging_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 894)
        Me.Controls.Add(Me.btnCutSample)
        Me.Controls.Add(Me.btnStartCut)
        Me.Controls.Add(Me.lblMsg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Purging_Form"
        Me.Text = "Purging_Form"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblMsg As Label
    Friend WithEvents TimerPurgingAndSamples As Timer
    Friend WithEvents TimerCutSamples As Timer
    Friend WithEvents btnStartCut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnCutSample As Guna.UI2.WinForms.Guna2Button
End Class
