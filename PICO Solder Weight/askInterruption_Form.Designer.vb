<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class askInterruption_Form
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
        Me.btnYes = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblErrorMsg = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.BackColor = System.Drawing.SystemColors.Control
        Me.btnYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnYes.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYes.Location = New System.Drawing.Point(261, 304)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(176, 54)
        Me.btnYes.TabIndex = 15
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 54)
        Me.Panel1.TabIndex = 17
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(544, 304)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(176, 54)
        Me.btnNo.TabIndex = 13
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'lblErrorMsg
        '
        Me.lblErrorMsg.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErrorMsg.Location = New System.Drawing.Point(218, 72)
        Me.lblErrorMsg.Name = "lblErrorMsg"
        Me.lblErrorMsg.Size = New System.Drawing.Size(745, 214)
        Me.lblErrorMsg.TabIndex = 16
        Me.lblErrorMsg.Text = " Encountered interruption during cutting of wire?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(No power, Change Spool, Machi" &
    "ne trouble)"
        Me.lblErrorMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PICO_Solder_Weight.My.Resources.Resources.question2
        Me.PictureBox1.Location = New System.Drawing.Point(12, 96)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(200, 176)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'askInterruption_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(963, 412)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblErrorMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "askInterruption_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "askInterruption_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnNo As Button
    Friend WithEvents lblErrorMsg As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
