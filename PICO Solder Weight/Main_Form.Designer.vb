<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelEval = New System.Windows.Forms.Panel()
        Me.btnEval = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelBuyOff = New System.Windows.Forms.Panel()
        Me.btnBuyOff = New Guna.UI2.WinForms.Guna2Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PanelSC = New System.Windows.Forms.Panel()
        Me.PanelSW = New System.Windows.Forms.Panel()
        Me.btnSolderCutter = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSolderWeight = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCR = New System.Windows.Forms.Label()
        Me.lblfooter = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.ForestGreen
        Me.Panel1.Controls.Add(Me.PanelEval)
        Me.Panel1.Controls.Add(Me.btnEval)
        Me.Panel1.Controls.Add(Me.PanelBuyOff)
        Me.Panel1.Controls.Add(Me.btnBuyOff)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PanelSC)
        Me.Panel1.Controls.Add(Me.PanelSW)
        Me.Panel1.Controls.Add(Me.btnSolderCutter)
        Me.Panel1.Controls.Add(Me.btnSolderWeight)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblCR)
        Me.Panel1.Controls.Add(Me.lblfooter)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 1055)
        Me.Panel1.TabIndex = 0
        '
        'PanelEval
        '
        Me.PanelEval.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelEval.Location = New System.Drawing.Point(0, 454)
        Me.PanelEval.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelEval.Name = "PanelEval"
        Me.PanelEval.Size = New System.Drawing.Size(11, 46)
        Me.PanelEval.TabIndex = 83
        Me.PanelEval.Visible = False
        '
        'btnEval
        '
        Me.btnEval.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEval.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEval.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEval.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEval.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnEval.FillColor = System.Drawing.Color.Transparent
        Me.btnEval.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEval.ForeColor = System.Drawing.Color.White
        Me.btnEval.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnEval.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnEval.HoverState.Image = Global.PICO_Solder_Weight.My.Resources.Resources.evaluation_colored
        Me.btnEval.Image = Global.PICO_Solder_Weight.My.Resources.Resources.evaluation
        Me.btnEval.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnEval.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnEval.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEval.Location = New System.Drawing.Point(0, 456)
        Me.btnEval.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEval.Name = "btnEval"
        Me.btnEval.Size = New System.Drawing.Size(280, 46)
        Me.btnEval.TabIndex = 84
        Me.btnEval.Text = "Eval"
        Me.btnEval.TextOffset = New System.Drawing.Point(15, 0)
        '
        'PanelBuyOff
        '
        Me.PanelBuyOff.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelBuyOff.Location = New System.Drawing.Point(0, 408)
        Me.PanelBuyOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelBuyOff.Name = "PanelBuyOff"
        Me.PanelBuyOff.Size = New System.Drawing.Size(11, 46)
        Me.PanelBuyOff.TabIndex = 81
        Me.PanelBuyOff.Visible = False
        '
        'btnBuyOff
        '
        Me.btnBuyOff.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnBuyOff.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnBuyOff.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnBuyOff.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnBuyOff.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnBuyOff.FillColor = System.Drawing.Color.Transparent
        Me.btnBuyOff.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyOff.ForeColor = System.Drawing.Color.White
        Me.btnBuyOff.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnBuyOff.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnBuyOff.HoverState.Image = Global.PICO_Solder_Weight.My.Resources.Resources.buyoff_colored
        Me.btnBuyOff.Image = Global.PICO_Solder_Weight.My.Resources.Resources.buyoff
        Me.btnBuyOff.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnBuyOff.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnBuyOff.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnBuyOff.Location = New System.Drawing.Point(0, 410)
        Me.btnBuyOff.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBuyOff.Name = "btnBuyOff"
        Me.btnBuyOff.Size = New System.Drawing.Size(280, 46)
        Me.btnBuyOff.TabIndex = 82
        Me.btnBuyOff.Text = "Buy-off"
        Me.btnBuyOff.TextOffset = New System.Drawing.Point(15, 0)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(84, 703)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.TabIndex = 80
        Me.TextBox2.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(84, 667)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.TabIndex = 79
        Me.TextBox1.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(100, 794)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'PanelSC
        '
        Me.PanelSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSC.Location = New System.Drawing.Point(0, 363)
        Me.PanelSC.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSC.Name = "PanelSC"
        Me.PanelSC.Size = New System.Drawing.Size(11, 46)
        Me.PanelSC.TabIndex = 36
        Me.PanelSC.Visible = False
        '
        'PanelSW
        '
        Me.PanelSW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSW.Location = New System.Drawing.Point(0, 318)
        Me.PanelSW.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelSW.Name = "PanelSW"
        Me.PanelSW.Size = New System.Drawing.Size(11, 46)
        Me.PanelSW.TabIndex = 37
        Me.PanelSW.Visible = False
        '
        'btnSolderCutter
        '
        Me.btnSolderCutter.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSolderCutter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSolderCutter.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSolderCutter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSolderCutter.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSolderCutter.FillColor = System.Drawing.Color.Transparent
        Me.btnSolderCutter.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolderCutter.ForeColor = System.Drawing.Color.White
        Me.btnSolderCutter.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnSolderCutter.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSolderCutter.HoverState.Image = Global.PICO_Solder_Weight.My.Resources.Resources.Spool_colored
        Me.btnSolderCutter.Image = Global.PICO_Solder_Weight.My.Resources.Resources.Spool
        Me.btnSolderCutter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSolderCutter.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSolderCutter.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSolderCutter.Location = New System.Drawing.Point(0, 364)
        Me.btnSolderCutter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSolderCutter.Name = "btnSolderCutter"
        Me.btnSolderCutter.Size = New System.Drawing.Size(280, 46)
        Me.btnSolderCutter.TabIndex = 37
        Me.btnSolderCutter.Text = "Solder Cutter"
        Me.btnSolderCutter.TextOffset = New System.Drawing.Point(20, 0)
        '
        'btnSolderWeight
        '
        Me.btnSolderWeight.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSolderWeight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSolderWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSolderWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSolderWeight.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSolderWeight.FillColor = System.Drawing.Color.Transparent
        Me.btnSolderWeight.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolderWeight.ForeColor = System.Drawing.Color.White
        Me.btnSolderWeight.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnSolderWeight.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSolderWeight.HoverState.Image = Global.PICO_Solder_Weight.My.Resources.Resources.scale_colored
        Me.btnSolderWeight.Image = Global.PICO_Solder_Weight.My.Resources.Resources.scale
        Me.btnSolderWeight.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSolderWeight.ImageOffset = New System.Drawing.Point(10, 0)
        Me.btnSolderWeight.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSolderWeight.Location = New System.Drawing.Point(0, 318)
        Me.btnSolderWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSolderWeight.Name = "btnSolderWeight"
        Me.btnSolderWeight.Size = New System.Drawing.Size(280, 46)
        Me.btnSolderWeight.TabIndex = 35
        Me.btnSolderWeight.Text = "Solder Weight"
        Me.btnSolderWeight.TextOffset = New System.Drawing.Point(20, 0)
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 207)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 111)
        Me.Panel2.TabIndex = 0
        '
        'lblCR
        '
        Me.lblCR.AutoSize = True
        Me.lblCR.BackColor = System.Drawing.Color.Transparent
        Me.lblCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCR.Location = New System.Drawing.Point(36, 1154)
        Me.lblCR.Name = "lblCR"
        Me.lblCR.Size = New System.Drawing.Size(158, 13)
        Me.lblCR.TabIndex = 34
        Me.lblCR.Text = "© LF Philipines - TSG 2024"
        '
        'lblfooter
        '
        Me.lblfooter.AutoSize = True
        Me.lblfooter.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfooter.Location = New System.Drawing.Point(36, 1143)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(183, 13)
        Me.lblfooter.TabIndex = 33
        Me.lblfooter.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(280, 207)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'PanelMain
        '
        Me.PanelMain.AutoScroll = True
        Me.PanelMain.Controls.Add(Me.PictureBox2)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMain.Location = New System.Drawing.Point(280, 0)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1324, 1055)
        Me.PanelMain.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(530, 428)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(493, 127)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(324, 588)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(865, 62)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PICO Solder Weight Closed Loop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Timer1
        '
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 1055)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMain As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCR As Label
    Friend WithEvents lblfooter As Label
    Friend WithEvents btnSolderCutter As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelSC As Panel
    Friend WithEvents btnSolderWeight As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelSW As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PanelBuyOff As Panel
    Friend WithEvents btnBuyOff As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelEval As Panel
    Friend WithEvents btnEval As Guna.UI2.WinForms.Guna2Button
End Class
