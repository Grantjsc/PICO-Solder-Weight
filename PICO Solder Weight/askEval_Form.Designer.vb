<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class askEval_Form
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
        Me.btnNo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSavingError = New System.Windows.Forms.Label()
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
        Me.btnYes.Location = New System.Drawing.Point(275, 338)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(176, 54)
        Me.btnYes.TabIndex = 13
        Me.btnYes.Text = "Yes"
        Me.btnYes.UseVisualStyleBackColor = False
        '
        'btnNo
        '
        Me.btnNo.BackColor = System.Drawing.SystemColors.Control
        Me.btnNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNo.Location = New System.Drawing.Point(541, 338)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(176, 54)
        Me.btnNo.TabIndex = 11
        Me.btnNo.Text = "No"
        Me.btnNo.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 54)
        Me.Panel1.TabIndex = 12
        '
        'lblSavingError
        '
        Me.lblSavingError.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingError.Location = New System.Drawing.Point(236, 154)
        Me.lblSavingError.Name = "lblSavingError"
        Me.lblSavingError.Size = New System.Drawing.Size(662, 139)
        Me.lblSavingError.TabIndex = 10
        Me.lblSavingError.Text = "Is this an evaluation for Barrier?"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PICO_Solder_Weight.My.Resources.Resources.question2
        Me.PictureBox1.Location = New System.Drawing.Point(29, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'askEval_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(929, 412)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblSavingError)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "askEval_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "askEval_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSavingError As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
