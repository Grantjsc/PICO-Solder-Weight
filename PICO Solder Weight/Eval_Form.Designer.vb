<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Eval_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Eval_Form))
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReading = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.txtWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtKindOfEval = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtName = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BorderRadius = 15
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(1300, 146)
        Me.Guna2CustomGradientPanel2.TabIndex = 9
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(22, 21)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(139, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(464, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 75)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PICO Solder Eval"
        '
        'txtReading
        '
        Me.txtReading.BackColor = System.Drawing.Color.Transparent
        Me.txtReading.BorderColor = System.Drawing.Color.Black
        Me.txtReading.BorderRadius = 20
        Me.txtReading.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReading.DefaultText = ""
        Me.txtReading.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReading.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReading.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReading.FillColor = System.Drawing.Color.Black
        Me.txtReading.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReading.Font = New System.Drawing.Font("Lucida Fax", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReading.ForeColor = System.Drawing.Color.Lime
        Me.txtReading.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReading.Location = New System.Drawing.Point(585, 94)
        Me.txtReading.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtReading.Name = "txtReading"
        Me.txtReading.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReading.PlaceholderText = ""
        Me.txtReading.SelectedText = ""
        Me.txtReading.ShadowDecoration.BorderRadius = 30
        Me.txtReading.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReading.ShadowDecoration.Enabled = True
        Me.txtReading.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtReading.Size = New System.Drawing.Size(495, 88)
        Me.txtReading.TabIndex = 33
        Me.txtReading.TabStop = False
        Me.txtReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(766, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 47)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Result"
        '
        'lstResult
        '
        Me.lstResult.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lstResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 36
        Me.lstResult.Location = New System.Drawing.Point(585, 205)
        Me.lstResult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(495, 436)
        Me.lstResult.TabIndex = 31
        Me.lstResult.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Transparent
        Me.btnSave.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.BorderRadius = 18
        Me.btnSave.BorderThickness = 3
        Me.btnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSave.FillColor = System.Drawing.Color.White
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSave.Location = New System.Drawing.Point(222, 503)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 18
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.ShadowDecoration.Depth = 20
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnSave.Size = New System.Drawing.Size(151, 68)
        Me.btnSave.TabIndex = 34
        Me.btnSave.Text = "Save"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lblWeight)
        Me.Panel1.Controls.Add(Me.txtWeight)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtKindOfEval)
        Me.Panel1.Controls.Add(Me.txtName)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.lstResult)
        Me.Panel1.Controls.Add(Me.txtReading)
        Me.Panel1.Location = New System.Drawing.Point(136, 203)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1060, 779)
        Me.Panel1.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(83, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(26, 31)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(94, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(359, 18)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "Please press enter key after you input the weight(mg)."
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.BackColor = System.Drawing.Color.Transparent
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeight.Location = New System.Drawing.Point(107, 348)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(172, 31)
        Me.lblWeight.TabIndex = 45
        Me.lblWeight.Text = "Weight(mg):"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.Transparent
        Me.txtWeight.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtWeight.BorderRadius = 20
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.DefaultText = ""
        Me.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.ForeColor = System.Drawing.Color.Black
        Me.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(98, 388)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.PlaceholderText = ""
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.ShadowDecoration.BorderRadius = 30
        Me.txtWeight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtWeight.ShadowDecoration.Enabled = True
        Me.txtWeight.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtWeight.Size = New System.Drawing.Size(394, 50)
        Me.txtWeight.TabIndex = 44
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(107, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 31)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Name:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(107, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 31)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Kind of Eval:"
        '
        'txtKindOfEval
        '
        Me.txtKindOfEval.BackColor = System.Drawing.Color.Transparent
        Me.txtKindOfEval.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtKindOfEval.BorderRadius = 20
        Me.txtKindOfEval.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtKindOfEval.DefaultText = ""
        Me.txtKindOfEval.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtKindOfEval.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtKindOfEval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKindOfEval.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtKindOfEval.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKindOfEval.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKindOfEval.ForeColor = System.Drawing.Color.Black
        Me.txtKindOfEval.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtKindOfEval.Location = New System.Drawing.Point(98, 264)
        Me.txtKindOfEval.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtKindOfEval.Name = "txtKindOfEval"
        Me.txtKindOfEval.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtKindOfEval.PlaceholderText = ""
        Me.txtKindOfEval.SelectedText = ""
        Me.txtKindOfEval.ShadowDecoration.BorderRadius = 30
        Me.txtKindOfEval.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtKindOfEval.ShadowDecoration.Enabled = True
        Me.txtKindOfEval.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtKindOfEval.Size = New System.Drawing.Size(394, 50)
        Me.txtKindOfEval.TabIndex = 37
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Transparent
        Me.txtName.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtName.BorderRadius = 20
        Me.txtName.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtName.DefaultText = ""
        Me.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtName.Location = New System.Drawing.Point(98, 146)
        Me.txtName.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtName.Name = "txtName"
        Me.txtName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtName.PlaceholderText = ""
        Me.txtName.SelectedText = ""
        Me.txtName.ShadowDecoration.BorderRadius = 30
        Me.txtName.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtName.ShadowDecoration.Enabled = True
        Me.txtName.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtName.Size = New System.Drawing.Size(394, 50)
        Me.txtName.TabIndex = 36
        '
        'Timer1
        '
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Eval_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 1044)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Eval_Form"
        Me.Text = "Eval_Form"
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReading As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lstResult As ListBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label5 As Label
    Friend WithEvents txtKindOfEval As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblWeight As Label
    Friend WithEvents txtWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
End Class
