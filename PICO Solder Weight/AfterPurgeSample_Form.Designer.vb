<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AfterPurgeSample_Form
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
        Me.btnOkay = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSavingError = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnOkay
        '
        Me.btnOkay.BackColor = System.Drawing.SystemColors.Control
        Me.btnOkay.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOkay.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnOkay.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOkay.Location = New System.Drawing.Point(632, 336)
        Me.btnOkay.Name = "btnOkay"
        Me.btnOkay.Size = New System.Drawing.Size(176, 54)
        Me.btnOkay.TabIndex = 17
        Me.btnOkay.Text = "Okay"
        Me.btnOkay.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(888, 54)
        Me.Panel1.TabIndex = 16
        '
        'lblSavingError
        '
        Me.lblSavingError.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSavingError.Location = New System.Drawing.Point(219, 138)
        Me.lblSavingError.Name = "lblSavingError"
        Me.lblSavingError.Size = New System.Drawing.Size(657, 178)
        Me.lblSavingError.TabIndex = 15
        Me.lblSavingError.Text = "Please replace the NG bin with a sample bin before clicking okay."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PICO_Solder_Weight.My.Resources.Resources.info_ICON
        Me.PictureBox1.Location = New System.Drawing.Point(12, 119)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 168)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'AfterPurgeSample_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(888, 412)
        Me.Controls.Add(Me.btnOkay)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblSavingError)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AfterPurgeSample_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AfterPurgeSample_Form"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOkay As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblSavingError As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
