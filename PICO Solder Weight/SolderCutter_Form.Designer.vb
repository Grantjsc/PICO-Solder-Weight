<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SolderCutter_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SolderCutter_Form))
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PanelCut1EM = New System.Windows.Forms.Panel()
        Me.btnC1Reset = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC1cut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC1JogMinus = New Guna.UI2.WinForms.Guna2Button()
        Me.lblC1counter = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnC1JogPlus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC1Start = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelCut2EM = New System.Windows.Forms.Panel()
        Me.btnC2Reset = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC2cut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC2JogMinus = New Guna.UI2.WinForms.Guna2Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblC2counter = New System.Windows.Forms.Label()
        Me.btnC2JogPlus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC2Start = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PanelCut3EM = New System.Windows.Forms.Panel()
        Me.btnC3Reset = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC3cut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC3JogMinus = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblC3counter = New System.Windows.Forms.Label()
        Me.btnC3JogPlus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC3Start = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PanelCut4EM = New System.Windows.Forms.Panel()
        Me.btnC4Reset = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC4cut = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC4JogMinus = New Guna.UI2.WinForms.Guna2Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblC4counter = New System.Windows.Forms.Label()
        Me.btnC4JogPlus = New Guna.UI2.WinForms.Guna2Button()
        Me.btnC4Start = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.actual_temp1_lbl = New System.Windows.Forms.Label()
        Me.send_status_lbl = New System.Windows.Forms.Label()
        Me.timetoday = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.PanelCut2EM.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BorderRadius = 15
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(1441, 122)
        Me.Guna2CustomGradientPanel2.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(497, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(480, 75)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PICO Solder Cutter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.PanelCut1EM)
        Me.Panel2.Controls.Add(Me.btnC1Reset)
        Me.Panel2.Controls.Add(Me.btnC1cut)
        Me.Panel2.Controls.Add(Me.btnC1JogMinus)
        Me.Panel2.Controls.Add(Me.lblC1counter)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.btnC1JogPlus)
        Me.Panel2.Controls.Add(Me.btnC1Start)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 122)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 978)
        Me.Panel2.TabIndex = 1
        '
        'PanelCut1EM
        '
        Me.PanelCut1EM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelCut1EM.Location = New System.Drawing.Point(16, 144)
        Me.PanelCut1EM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCut1EM.Name = "PanelCut1EM"
        Me.PanelCut1EM.Size = New System.Drawing.Size(293, 275)
        Me.PanelCut1EM.TabIndex = 64
        '
        'btnC1Reset
        '
        Me.btnC1Reset.BackColor = System.Drawing.Color.Transparent
        Me.btnC1Reset.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC1Reset.BorderRadius = 18
        Me.btnC1Reset.BorderThickness = 3
        Me.btnC1Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC1Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC1Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC1Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC1Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC1Reset.FillColor = System.Drawing.Color.White
        Me.btnC1Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1Reset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1Reset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1Reset.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC1Reset.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1Reset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC1Reset.HoverState.Image = CType(resources.GetObject("resource.Image"), System.Drawing.Image)
        Me.btnC1Reset.Image = CType(resources.GetObject("btnC1Reset.Image"), System.Drawing.Image)
        Me.btnC1Reset.Location = New System.Drawing.Point(172, 767)
        Me.btnC1Reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC1Reset.Name = "btnC1Reset"
        Me.btnC1Reset.ShadowDecoration.BorderRadius = 18
        Me.btnC1Reset.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1Reset.ShadowDecoration.Depth = 20
        Me.btnC1Reset.ShadowDecoration.Enabled = True
        Me.btnC1Reset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC1Reset.Size = New System.Drawing.Size(139, 55)
        Me.btnC1Reset.TabIndex = 63
        Me.btnC1Reset.Text = "Reset"
        '
        'btnC1cut
        '
        Me.btnC1cut.BackColor = System.Drawing.Color.Transparent
        Me.btnC1cut.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC1cut.BorderRadius = 18
        Me.btnC1cut.BorderThickness = 3
        Me.btnC1cut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC1cut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC1cut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC1cut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC1cut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC1cut.FillColor = System.Drawing.Color.White
        Me.btnC1cut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1cut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1cut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1cut.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1cut.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC1cut.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1cut.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC1cut.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnC1cut.Image = CType(resources.GetObject("btnC1cut.Image"), System.Drawing.Image)
        Me.btnC1cut.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnC1cut.Location = New System.Drawing.Point(11, 767)
        Me.btnC1cut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC1cut.Name = "btnC1cut"
        Me.btnC1cut.ShadowDecoration.BorderRadius = 18
        Me.btnC1cut.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1cut.ShadowDecoration.Depth = 20
        Me.btnC1cut.ShadowDecoration.Enabled = True
        Me.btnC1cut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC1cut.Size = New System.Drawing.Size(139, 55)
        Me.btnC1cut.TabIndex = 62
        Me.btnC1cut.Text = "Cut"
        '
        'btnC1JogMinus
        '
        Me.btnC1JogMinus.BackColor = System.Drawing.Color.Transparent
        Me.btnC1JogMinus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC1JogMinus.BorderRadius = 18
        Me.btnC1JogMinus.BorderThickness = 3
        Me.btnC1JogMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC1JogMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC1JogMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC1JogMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC1JogMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC1JogMinus.FillColor = System.Drawing.Color.White
        Me.btnC1JogMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1JogMinus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogMinus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogMinus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogMinus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC1JogMinus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1JogMinus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC1JogMinus.HoverState.Image = CType(resources.GetObject("resource.Image2"), System.Drawing.Image)
        Me.btnC1JogMinus.Image = CType(resources.GetObject("btnC1JogMinus.Image"), System.Drawing.Image)
        Me.btnC1JogMinus.Location = New System.Drawing.Point(172, 682)
        Me.btnC1JogMinus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC1JogMinus.Name = "btnC1JogMinus"
        Me.btnC1JogMinus.ShadowDecoration.BorderRadius = 18
        Me.btnC1JogMinus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogMinus.ShadowDecoration.Depth = 20
        Me.btnC1JogMinus.ShadowDecoration.Enabled = True
        Me.btnC1JogMinus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC1JogMinus.Size = New System.Drawing.Size(139, 55)
        Me.btnC1JogMinus.TabIndex = 61
        Me.btnC1JogMinus.Text = "Jog"
        '
        'lblC1counter
        '
        Me.lblC1counter.AutoSize = True
        Me.lblC1counter.BackColor = System.Drawing.Color.Transparent
        Me.lblC1counter.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC1counter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblC1counter.Location = New System.Drawing.Point(75, 578)
        Me.lblC1counter.Name = "lblC1counter"
        Me.lblC1counter.Size = New System.Drawing.Size(154, 42)
        Me.lblC1counter.TabIndex = 60
        Me.lblC1counter.Text = "123,456"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(79, 538)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 43)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Counter:"
        '
        'btnC1JogPlus
        '
        Me.btnC1JogPlus.BackColor = System.Drawing.Color.Transparent
        Me.btnC1JogPlus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC1JogPlus.BorderRadius = 18
        Me.btnC1JogPlus.BorderThickness = 3
        Me.btnC1JogPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC1JogPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC1JogPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC1JogPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC1JogPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC1JogPlus.FillColor = System.Drawing.Color.White
        Me.btnC1JogPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1JogPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogPlus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogPlus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogPlus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC1JogPlus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC1JogPlus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC1JogPlus.HoverState.Image = CType(resources.GetObject("resource.Image3"), System.Drawing.Image)
        Me.btnC1JogPlus.Image = CType(resources.GetObject("btnC1JogPlus.Image"), System.Drawing.Image)
        Me.btnC1JogPlus.Location = New System.Drawing.Point(11, 682)
        Me.btnC1JogPlus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC1JogPlus.Name = "btnC1JogPlus"
        Me.btnC1JogPlus.ShadowDecoration.BorderRadius = 18
        Me.btnC1JogPlus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC1JogPlus.ShadowDecoration.Depth = 20
        Me.btnC1JogPlus.ShadowDecoration.Enabled = True
        Me.btnC1JogPlus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC1JogPlus.Size = New System.Drawing.Size(139, 55)
        Me.btnC1JogPlus.TabIndex = 55
        Me.btnC1JogPlus.Text = "Jog"
        '
        'btnC1Start
        '
        Me.btnC1Start.AutoRoundedCorners = True
        Me.btnC1Start.BorderColor = System.Drawing.Color.Transparent
        Me.btnC1Start.BorderRadius = 26
        Me.btnC1Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC1Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC1Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC1Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC1Start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC1Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC1Start.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnC1Start.FillColor2 = System.Drawing.Color.Green
        Me.btnC1Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnC1Start.ForeColor = System.Drawing.Color.Black
        Me.btnC1Start.Location = New System.Drawing.Point(67, 881)
        Me.btnC1Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC1Start.Name = "btnC1Start"
        Me.btnC1Start.Size = New System.Drawing.Size(167, 54)
        Me.btnC1Start.TabIndex = 53
        Me.btnC1Start.Text = "Start"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(53, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 69)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cutter 1"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.timetoday)
        Me.Panel1.Controls.Add(Me.send_status_lbl)
        Me.Panel1.Controls.Add(Me.PanelCut2EM)
        Me.Panel1.Controls.Add(Me.btnC2Reset)
        Me.Panel1.Controls.Add(Me.btnC2cut)
        Me.Panel1.Controls.Add(Me.btnC2JogMinus)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.lblC2counter)
        Me.Panel1.Controls.Add(Me.btnC2JogPlus)
        Me.Panel1.Controls.Add(Me.btnC2Start)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(349, 122)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 978)
        Me.Panel1.TabIndex = 2
        '
        'PanelCut2EM
        '
        Me.PanelCut2EM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelCut2EM.Controls.Add(Me.actual_temp1_lbl)
        Me.PanelCut2EM.Location = New System.Drawing.Point(41, 144)
        Me.PanelCut2EM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCut2EM.Name = "PanelCut2EM"
        Me.PanelCut2EM.Size = New System.Drawing.Size(293, 275)
        Me.PanelCut2EM.TabIndex = 76
        '
        'btnC2Reset
        '
        Me.btnC2Reset.BackColor = System.Drawing.Color.Transparent
        Me.btnC2Reset.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC2Reset.BorderRadius = 18
        Me.btnC2Reset.BorderThickness = 3
        Me.btnC2Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC2Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC2Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC2Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC2Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC2Reset.FillColor = System.Drawing.Color.White
        Me.btnC2Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2Reset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2Reset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2Reset.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC2Reset.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2Reset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC2Reset.HoverState.Image = CType(resources.GetObject("resource.Image4"), System.Drawing.Image)
        Me.btnC2Reset.Image = CType(resources.GetObject("btnC2Reset.Image"), System.Drawing.Image)
        Me.btnC2Reset.Location = New System.Drawing.Point(197, 767)
        Me.btnC2Reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC2Reset.Name = "btnC2Reset"
        Me.btnC2Reset.ShadowDecoration.BorderRadius = 18
        Me.btnC2Reset.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2Reset.ShadowDecoration.Depth = 20
        Me.btnC2Reset.ShadowDecoration.Enabled = True
        Me.btnC2Reset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC2Reset.Size = New System.Drawing.Size(139, 55)
        Me.btnC2Reset.TabIndex = 75
        Me.btnC2Reset.Text = "Reset"
        '
        'btnC2cut
        '
        Me.btnC2cut.BackColor = System.Drawing.Color.Transparent
        Me.btnC2cut.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC2cut.BorderRadius = 18
        Me.btnC2cut.BorderThickness = 3
        Me.btnC2cut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC2cut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC2cut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC2cut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC2cut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC2cut.FillColor = System.Drawing.Color.White
        Me.btnC2cut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2cut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2cut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2cut.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2cut.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC2cut.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2cut.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC2cut.HoverState.Image = CType(resources.GetObject("resource.Image5"), System.Drawing.Image)
        Me.btnC2cut.Image = CType(resources.GetObject("btnC2cut.Image"), System.Drawing.Image)
        Me.btnC2cut.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnC2cut.Location = New System.Drawing.Point(36, 767)
        Me.btnC2cut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC2cut.Name = "btnC2cut"
        Me.btnC2cut.ShadowDecoration.BorderRadius = 18
        Me.btnC2cut.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2cut.ShadowDecoration.Depth = 20
        Me.btnC2cut.ShadowDecoration.Enabled = True
        Me.btnC2cut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC2cut.Size = New System.Drawing.Size(139, 55)
        Me.btnC2cut.TabIndex = 74
        Me.btnC2cut.Text = "Cut"
        '
        'btnC2JogMinus
        '
        Me.btnC2JogMinus.BackColor = System.Drawing.Color.Transparent
        Me.btnC2JogMinus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC2JogMinus.BorderRadius = 18
        Me.btnC2JogMinus.BorderThickness = 3
        Me.btnC2JogMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC2JogMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC2JogMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC2JogMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC2JogMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC2JogMinus.FillColor = System.Drawing.Color.White
        Me.btnC2JogMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2JogMinus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogMinus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogMinus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogMinus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC2JogMinus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2JogMinus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC2JogMinus.HoverState.Image = CType(resources.GetObject("resource.Image6"), System.Drawing.Image)
        Me.btnC2JogMinus.Image = CType(resources.GetObject("btnC2JogMinus.Image"), System.Drawing.Image)
        Me.btnC2JogMinus.Location = New System.Drawing.Point(197, 682)
        Me.btnC2JogMinus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC2JogMinus.Name = "btnC2JogMinus"
        Me.btnC2JogMinus.ShadowDecoration.BorderRadius = 18
        Me.btnC2JogMinus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogMinus.ShadowDecoration.Depth = 20
        Me.btnC2JogMinus.ShadowDecoration.Enabled = True
        Me.btnC2JogMinus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC2JogMinus.Size = New System.Drawing.Size(139, 55)
        Me.btnC2JogMinus.TabIndex = 73
        Me.btnC2JogMinus.Text = "Jog"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial Narrow", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(104, 538)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 43)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Counter:"
        '
        'lblC2counter
        '
        Me.lblC2counter.AutoSize = True
        Me.lblC2counter.BackColor = System.Drawing.Color.Transparent
        Me.lblC2counter.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC2counter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblC2counter.Location = New System.Drawing.Point(100, 578)
        Me.lblC2counter.Name = "lblC2counter"
        Me.lblC2counter.Size = New System.Drawing.Size(154, 42)
        Me.lblC2counter.TabIndex = 72
        Me.lblC2counter.Text = "123,456"
        '
        'btnC2JogPlus
        '
        Me.btnC2JogPlus.BackColor = System.Drawing.Color.Transparent
        Me.btnC2JogPlus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC2JogPlus.BorderRadius = 18
        Me.btnC2JogPlus.BorderThickness = 3
        Me.btnC2JogPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC2JogPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC2JogPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC2JogPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC2JogPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC2JogPlus.FillColor = System.Drawing.Color.White
        Me.btnC2JogPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2JogPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogPlus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogPlus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogPlus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC2JogPlus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC2JogPlus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC2JogPlus.HoverState.Image = CType(resources.GetObject("resource.Image1"), System.Drawing.Image)
        Me.btnC2JogPlus.Image = CType(resources.GetObject("btnC2JogPlus.Image"), System.Drawing.Image)
        Me.btnC2JogPlus.Location = New System.Drawing.Point(36, 682)
        Me.btnC2JogPlus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC2JogPlus.Name = "btnC2JogPlus"
        Me.btnC2JogPlus.ShadowDecoration.BorderRadius = 18
        Me.btnC2JogPlus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC2JogPlus.ShadowDecoration.Depth = 20
        Me.btnC2JogPlus.ShadowDecoration.Enabled = True
        Me.btnC2JogPlus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC2JogPlus.Size = New System.Drawing.Size(139, 55)
        Me.btnC2JogPlus.TabIndex = 70
        Me.btnC2JogPlus.Text = "Jog"
        '
        'btnC2Start
        '
        Me.btnC2Start.AutoRoundedCorners = True
        Me.btnC2Start.BorderColor = System.Drawing.Color.Transparent
        Me.btnC2Start.BorderRadius = 26
        Me.btnC2Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC2Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC2Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC2Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC2Start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC2Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC2Start.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnC2Start.FillColor2 = System.Drawing.Color.Green
        Me.btnC2Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnC2Start.ForeColor = System.Drawing.Color.Black
        Me.btnC2Start.Location = New System.Drawing.Point(92, 881)
        Me.btnC2Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC2Start.Name = "btnC2Start"
        Me.btnC2Start.Size = New System.Drawing.Size(167, 54)
        Me.btnC2Start.TabIndex = 54
        Me.btnC2Start.Text = "Start"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(73, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(215, 69)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cutter 2"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.PanelCut3EM)
        Me.Panel3.Controls.Add(Me.btnC3Reset)
        Me.Panel3.Controls.Add(Me.btnC3cut)
        Me.Panel3.Controls.Add(Me.btnC3JogMinus)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.lblC3counter)
        Me.Panel3.Controls.Add(Me.btnC3JogPlus)
        Me.Panel3.Controls.Add(Me.btnC3Start)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(714, 122)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(371, 978)
        Me.Panel3.TabIndex = 3
        '
        'PanelCut3EM
        '
        Me.PanelCut3EM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelCut3EM.Location = New System.Drawing.Point(33, 144)
        Me.PanelCut3EM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCut3EM.Name = "PanelCut3EM"
        Me.PanelCut3EM.Size = New System.Drawing.Size(293, 275)
        Me.PanelCut3EM.TabIndex = 76
        '
        'btnC3Reset
        '
        Me.btnC3Reset.BackColor = System.Drawing.Color.Transparent
        Me.btnC3Reset.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC3Reset.BorderRadius = 18
        Me.btnC3Reset.BorderThickness = 3
        Me.btnC3Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC3Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC3Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC3Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC3Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC3Reset.FillColor = System.Drawing.Color.White
        Me.btnC3Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3Reset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3Reset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3Reset.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC3Reset.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3Reset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC3Reset.HoverState.Image = CType(resources.GetObject("resource.Image8"), System.Drawing.Image)
        Me.btnC3Reset.Image = CType(resources.GetObject("btnC3Reset.Image"), System.Drawing.Image)
        Me.btnC3Reset.Location = New System.Drawing.Point(189, 767)
        Me.btnC3Reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC3Reset.Name = "btnC3Reset"
        Me.btnC3Reset.ShadowDecoration.BorderRadius = 18
        Me.btnC3Reset.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3Reset.ShadowDecoration.Depth = 20
        Me.btnC3Reset.ShadowDecoration.Enabled = True
        Me.btnC3Reset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC3Reset.Size = New System.Drawing.Size(139, 55)
        Me.btnC3Reset.TabIndex = 75
        Me.btnC3Reset.Text = "Reset"
        '
        'btnC3cut
        '
        Me.btnC3cut.BackColor = System.Drawing.Color.Transparent
        Me.btnC3cut.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC3cut.BorderRadius = 18
        Me.btnC3cut.BorderThickness = 3
        Me.btnC3cut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC3cut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC3cut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC3cut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC3cut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC3cut.FillColor = System.Drawing.Color.White
        Me.btnC3cut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3cut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3cut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3cut.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3cut.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC3cut.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3cut.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC3cut.HoverState.Image = CType(resources.GetObject("resource.Image9"), System.Drawing.Image)
        Me.btnC3cut.Image = CType(resources.GetObject("btnC3cut.Image"), System.Drawing.Image)
        Me.btnC3cut.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnC3cut.Location = New System.Drawing.Point(28, 767)
        Me.btnC3cut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC3cut.Name = "btnC3cut"
        Me.btnC3cut.ShadowDecoration.BorderRadius = 18
        Me.btnC3cut.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3cut.ShadowDecoration.Depth = 20
        Me.btnC3cut.ShadowDecoration.Enabled = True
        Me.btnC3cut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC3cut.Size = New System.Drawing.Size(139, 55)
        Me.btnC3cut.TabIndex = 74
        Me.btnC3cut.Text = "Cut"
        '
        'btnC3JogMinus
        '
        Me.btnC3JogMinus.BackColor = System.Drawing.Color.Transparent
        Me.btnC3JogMinus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC3JogMinus.BorderRadius = 18
        Me.btnC3JogMinus.BorderThickness = 3
        Me.btnC3JogMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC3JogMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC3JogMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC3JogMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC3JogMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC3JogMinus.FillColor = System.Drawing.Color.White
        Me.btnC3JogMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3JogMinus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogMinus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogMinus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogMinus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC3JogMinus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3JogMinus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC3JogMinus.HoverState.Image = CType(resources.GetObject("resource.Image10"), System.Drawing.Image)
        Me.btnC3JogMinus.Image = CType(resources.GetObject("btnC3JogMinus.Image"), System.Drawing.Image)
        Me.btnC3JogMinus.Location = New System.Drawing.Point(189, 682)
        Me.btnC3JogMinus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC3JogMinus.Name = "btnC3JogMinus"
        Me.btnC3JogMinus.ShadowDecoration.BorderRadius = 18
        Me.btnC3JogMinus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogMinus.ShadowDecoration.Depth = 20
        Me.btnC3JogMinus.ShadowDecoration.Enabled = True
        Me.btnC3JogMinus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC3JogMinus.Size = New System.Drawing.Size(139, 55)
        Me.btnC3JogMinus.TabIndex = 73
        Me.btnC3JogMinus.Text = "Jog"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial Narrow", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(96, 538)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(147, 43)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Counter:"
        '
        'lblC3counter
        '
        Me.lblC3counter.AutoSize = True
        Me.lblC3counter.BackColor = System.Drawing.Color.Transparent
        Me.lblC3counter.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC3counter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblC3counter.Location = New System.Drawing.Point(92, 578)
        Me.lblC3counter.Name = "lblC3counter"
        Me.lblC3counter.Size = New System.Drawing.Size(154, 42)
        Me.lblC3counter.TabIndex = 72
        Me.lblC3counter.Text = "123,456"
        '
        'btnC3JogPlus
        '
        Me.btnC3JogPlus.BackColor = System.Drawing.Color.Transparent
        Me.btnC3JogPlus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC3JogPlus.BorderRadius = 18
        Me.btnC3JogPlus.BorderThickness = 3
        Me.btnC3JogPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC3JogPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC3JogPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC3JogPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC3JogPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC3JogPlus.FillColor = System.Drawing.Color.White
        Me.btnC3JogPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3JogPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogPlus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogPlus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogPlus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC3JogPlus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC3JogPlus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC3JogPlus.HoverState.Image = CType(resources.GetObject("resource.Image11"), System.Drawing.Image)
        Me.btnC3JogPlus.Image = CType(resources.GetObject("btnC3JogPlus.Image"), System.Drawing.Image)
        Me.btnC3JogPlus.Location = New System.Drawing.Point(28, 682)
        Me.btnC3JogPlus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC3JogPlus.Name = "btnC3JogPlus"
        Me.btnC3JogPlus.ShadowDecoration.BorderRadius = 18
        Me.btnC3JogPlus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC3JogPlus.ShadowDecoration.Depth = 20
        Me.btnC3JogPlus.ShadowDecoration.Enabled = True
        Me.btnC3JogPlus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC3JogPlus.Size = New System.Drawing.Size(139, 55)
        Me.btnC3JogPlus.TabIndex = 70
        Me.btnC3JogPlus.Text = "Jog"
        '
        'btnC3Start
        '
        Me.btnC3Start.AutoRoundedCorners = True
        Me.btnC3Start.BorderColor = System.Drawing.Color.Transparent
        Me.btnC3Start.BorderRadius = 26
        Me.btnC3Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC3Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC3Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC3Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC3Start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC3Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC3Start.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnC3Start.FillColor2 = System.Drawing.Color.Green
        Me.btnC3Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnC3Start.ForeColor = System.Drawing.Color.Black
        Me.btnC3Start.Location = New System.Drawing.Point(99, 881)
        Me.btnC3Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC3Start.Name = "btnC3Start"
        Me.btnC3Start.Size = New System.Drawing.Size(167, 54)
        Me.btnC3Start.TabIndex = 55
        Me.btnC3Start.Text = "Start"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(68, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 69)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cutter 3"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.PanelCut4EM)
        Me.Panel4.Controls.Add(Me.btnC4Reset)
        Me.Panel4.Controls.Add(Me.btnC4cut)
        Me.Panel4.Controls.Add(Me.btnC4JogMinus)
        Me.Panel4.Controls.Add(Me.Label12)
        Me.Panel4.Controls.Add(Me.lblC4counter)
        Me.Panel4.Controls.Add(Me.btnC4JogPlus)
        Me.Panel4.Controls.Add(Me.btnC4Start)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(1085, 122)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(344, 978)
        Me.Panel4.TabIndex = 4
        '
        'PanelCut4EM
        '
        Me.PanelCut4EM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelCut4EM.Location = New System.Drawing.Point(27, 144)
        Me.PanelCut4EM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PanelCut4EM.Name = "PanelCut4EM"
        Me.PanelCut4EM.Size = New System.Drawing.Size(293, 275)
        Me.PanelCut4EM.TabIndex = 76
        '
        'btnC4Reset
        '
        Me.btnC4Reset.BackColor = System.Drawing.Color.Transparent
        Me.btnC4Reset.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC4Reset.BorderRadius = 18
        Me.btnC4Reset.BorderThickness = 3
        Me.btnC4Reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC4Reset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC4Reset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC4Reset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC4Reset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC4Reset.FillColor = System.Drawing.Color.White
        Me.btnC4Reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4Reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4Reset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4Reset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4Reset.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC4Reset.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4Reset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC4Reset.HoverState.Image = CType(resources.GetObject("resource.Image12"), System.Drawing.Image)
        Me.btnC4Reset.Image = CType(resources.GetObject("btnC4Reset.Image"), System.Drawing.Image)
        Me.btnC4Reset.Location = New System.Drawing.Point(179, 767)
        Me.btnC4Reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC4Reset.Name = "btnC4Reset"
        Me.btnC4Reset.ShadowDecoration.BorderRadius = 18
        Me.btnC4Reset.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4Reset.ShadowDecoration.Depth = 20
        Me.btnC4Reset.ShadowDecoration.Enabled = True
        Me.btnC4Reset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC4Reset.Size = New System.Drawing.Size(139, 55)
        Me.btnC4Reset.TabIndex = 75
        Me.btnC4Reset.Text = "Reset"
        '
        'btnC4cut
        '
        Me.btnC4cut.BackColor = System.Drawing.Color.Transparent
        Me.btnC4cut.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC4cut.BorderRadius = 18
        Me.btnC4cut.BorderThickness = 3
        Me.btnC4cut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC4cut.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC4cut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC4cut.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC4cut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC4cut.FillColor = System.Drawing.Color.White
        Me.btnC4cut.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4cut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4cut.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4cut.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4cut.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC4cut.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4cut.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC4cut.HoverState.Image = CType(resources.GetObject("resource.Image13"), System.Drawing.Image)
        Me.btnC4cut.Image = CType(resources.GetObject("btnC4cut.Image"), System.Drawing.Image)
        Me.btnC4cut.ImageSize = New System.Drawing.Size(25, 25)
        Me.btnC4cut.Location = New System.Drawing.Point(17, 767)
        Me.btnC4cut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC4cut.Name = "btnC4cut"
        Me.btnC4cut.ShadowDecoration.BorderRadius = 18
        Me.btnC4cut.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4cut.ShadowDecoration.Depth = 20
        Me.btnC4cut.ShadowDecoration.Enabled = True
        Me.btnC4cut.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC4cut.Size = New System.Drawing.Size(139, 55)
        Me.btnC4cut.TabIndex = 74
        Me.btnC4cut.Text = "Cut"
        '
        'btnC4JogMinus
        '
        Me.btnC4JogMinus.BackColor = System.Drawing.Color.Transparent
        Me.btnC4JogMinus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC4JogMinus.BorderRadius = 18
        Me.btnC4JogMinus.BorderThickness = 3
        Me.btnC4JogMinus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC4JogMinus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC4JogMinus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC4JogMinus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC4JogMinus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC4JogMinus.FillColor = System.Drawing.Color.White
        Me.btnC4JogMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4JogMinus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogMinus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogMinus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogMinus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC4JogMinus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4JogMinus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC4JogMinus.HoverState.Image = CType(resources.GetObject("resource.Image14"), System.Drawing.Image)
        Me.btnC4JogMinus.Image = CType(resources.GetObject("btnC4JogMinus.Image"), System.Drawing.Image)
        Me.btnC4JogMinus.Location = New System.Drawing.Point(179, 682)
        Me.btnC4JogMinus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC4JogMinus.Name = "btnC4JogMinus"
        Me.btnC4JogMinus.ShadowDecoration.BorderRadius = 18
        Me.btnC4JogMinus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogMinus.ShadowDecoration.Depth = 20
        Me.btnC4JogMinus.ShadowDecoration.Enabled = True
        Me.btnC4JogMinus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC4JogMinus.Size = New System.Drawing.Size(139, 55)
        Me.btnC4JogMinus.TabIndex = 73
        Me.btnC4JogMinus.Text = "Jog"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial Narrow", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(85, 538)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(147, 43)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Counter:"
        '
        'lblC4counter
        '
        Me.lblC4counter.AutoSize = True
        Me.lblC4counter.BackColor = System.Drawing.Color.Transparent
        Me.lblC4counter.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblC4counter.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.lblC4counter.Location = New System.Drawing.Point(81, 578)
        Me.lblC4counter.Name = "lblC4counter"
        Me.lblC4counter.Size = New System.Drawing.Size(154, 42)
        Me.lblC4counter.TabIndex = 72
        Me.lblC4counter.Text = "123,456"
        '
        'btnC4JogPlus
        '
        Me.btnC4JogPlus.BackColor = System.Drawing.Color.Transparent
        Me.btnC4JogPlus.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnC4JogPlus.BorderRadius = 18
        Me.btnC4JogPlus.BorderThickness = 3
        Me.btnC4JogPlus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC4JogPlus.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC4JogPlus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC4JogPlus.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC4JogPlus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC4JogPlus.FillColor = System.Drawing.Color.White
        Me.btnC4JogPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4JogPlus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogPlus.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogPlus.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogPlus.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnC4JogPlus.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC4JogPlus.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnC4JogPlus.HoverState.Image = CType(resources.GetObject("resource.Image15"), System.Drawing.Image)
        Me.btnC4JogPlus.Image = CType(resources.GetObject("btnC4JogPlus.Image"), System.Drawing.Image)
        Me.btnC4JogPlus.Location = New System.Drawing.Point(17, 682)
        Me.btnC4JogPlus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC4JogPlus.Name = "btnC4JogPlus"
        Me.btnC4JogPlus.ShadowDecoration.BorderRadius = 18
        Me.btnC4JogPlus.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnC4JogPlus.ShadowDecoration.Depth = 20
        Me.btnC4JogPlus.ShadowDecoration.Enabled = True
        Me.btnC4JogPlus.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnC4JogPlus.Size = New System.Drawing.Size(139, 55)
        Me.btnC4JogPlus.TabIndex = 70
        Me.btnC4JogPlus.Text = "Jog"
        '
        'btnC4Start
        '
        Me.btnC4Start.AutoRoundedCorners = True
        Me.btnC4Start.BorderColor = System.Drawing.Color.Transparent
        Me.btnC4Start.BorderRadius = 26
        Me.btnC4Start.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnC4Start.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnC4Start.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnC4Start.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC4Start.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnC4Start.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnC4Start.FillColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnC4Start.FillColor2 = System.Drawing.Color.Green
        Me.btnC4Start.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold)
        Me.btnC4Start.ForeColor = System.Drawing.Color.Black
        Me.btnC4Start.Location = New System.Drawing.Point(93, 881)
        Me.btnC4Start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnC4Start.Name = "btnC4Start"
        Me.btnC4Start.Size = New System.Drawing.Size(167, 54)
        Me.btnC4Start.TabIndex = 53
        Me.btnC4Start.Text = "Start"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(60, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 69)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Cutter 4"
        '
        'SerialPort1
        '
        Me.SerialPort1.DataBits = 7
        Me.SerialPort1.Parity = System.IO.Ports.Parity.Even
        Me.SerialPort1.PortName = "COM7"
        Me.SerialPort1.StopBits = System.IO.Ports.StopBits.Two
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'actual_temp1_lbl
        '
        Me.actual_temp1_lbl.AutoSize = True
        Me.actual_temp1_lbl.Location = New System.Drawing.Point(42, 57)
        Me.actual_temp1_lbl.Name = "actual_temp1_lbl"
        Me.actual_temp1_lbl.Size = New System.Drawing.Size(48, 16)
        Me.actual_temp1_lbl.TabIndex = 0
        Me.actual_temp1_lbl.Text = "Label7"
        '
        'send_status_lbl
        '
        Me.send_status_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send_status_lbl.Location = New System.Drawing.Point(41, 433)
        Me.send_status_lbl.Name = "send_status_lbl"
        Me.send_status_lbl.Size = New System.Drawing.Size(293, 50)
        Me.send_status_lbl.TabIndex = 1
        Me.send_status_lbl.Text = "Status"
        Me.send_status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timetoday
        '
        Me.timetoday.AutoSize = True
        Me.timetoday.Location = New System.Drawing.Point(109, 112)
        Me.timetoday.Name = "timetoday"
        Me.timetoday.Size = New System.Drawing.Size(48, 20)
        Me.timetoday.TabIndex = 1
        Me.timetoday.Text = "Time"
        '
        'SolderCutter_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1441, 1100)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "SolderCutter_Form"
        Me.Text = "SolderCutter_Form"
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.PanelCut2EM.ResumeLayout(False)
        Me.PanelCut2EM.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnC1Start As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnC2Start As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnC3Start As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnC4Start As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents btnC1JogPlus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label6 As Label
    Friend WithEvents lblC1counter As Label
    Friend WithEvents btnC1JogMinus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC1Reset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC1cut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC2Reset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC2cut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC2JogMinus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label9 As Label
    Friend WithEvents lblC2counter As Label
    Friend WithEvents btnC2JogPlus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC3Reset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC3cut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC3JogMinus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lblC3counter As Label
    Friend WithEvents btnC3JogPlus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC4Reset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC4cut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnC4JogMinus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label12 As Label
    Friend WithEvents lblC4counter As Label
    Friend WithEvents btnC4JogPlus As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PanelCut1EM As Panel
    Friend WithEvents PanelCut2EM As Panel
    Friend WithEvents PanelCut3EM As Panel
    Friend WithEvents PanelCut4EM As Panel
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Timer1 As Timer
    Friend WithEvents actual_temp1_lbl As Label
    Friend WithEvents send_status_lbl As Label
    Friend WithEvents timetoday As Label
End Class
