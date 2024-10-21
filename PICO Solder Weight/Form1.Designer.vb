<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtPartNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.btnNewLot = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.txtEmployee = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtLotNo = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.btnEnable = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnWeight = New Guna.UI2.WinForms.Guna2Button()
        Me.lblCR = New System.Windows.Forms.Label()
        Me.lblfooter = New System.Windows.Forms.Label()
        Me.txtReading = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.cboShift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboProcess = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboAssociate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.lblQty109 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblQty108 = New System.Windows.Forms.Label()
        Me.lblDoor_112 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.send_status_lbl = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeCOMNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAssociateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Guna2ContextMenuStrip2 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerPLC = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPartNo
        '
        Me.txtPartNo.BackColor = System.Drawing.Color.Transparent
        Me.txtPartNo.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPartNo.BorderRadius = 20
        Me.txtPartNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPartNo.DefaultText = "Enter Part Number"
        Me.txtPartNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPartNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPartNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPartNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPartNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPartNo.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartNo.ForeColor = System.Drawing.Color.Silver
        Me.txtPartNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPartNo.Location = New System.Drawing.Point(32, 84)
        Me.txtPartNo.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPartNo.PlaceholderText = ""
        Me.txtPartNo.SelectedText = ""
        Me.txtPartNo.ShadowDecoration.BorderRadius = 30
        Me.txtPartNo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPartNo.ShadowDecoration.Enabled = True
        Me.txtPartNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtPartNo.Size = New System.Drawing.Size(224, 35)
        Me.txtPartNo.TabIndex = 0
        '
        'Guna2ContextMenuStrip1
        '
        Me.Guna2ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
        Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'btnNewLot
        '
        Me.btnNewLot.BackColor = System.Drawing.Color.Transparent
        Me.btnNewLot.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnNewLot.BorderRadius = 18
        Me.btnNewLot.BorderThickness = 3
        Me.btnNewLot.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNewLot.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnNewLot.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnNewLot.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnNewLot.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnNewLot.FillColor = System.Drawing.Color.White
        Me.btnNewLot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLot.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewLot.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewLot.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewLot.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnNewLot.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewLot.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnNewLot.Image = CType(resources.GetObject("btnNewLot.Image"), System.Drawing.Image)
        Me.btnNewLot.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnNewLot.Location = New System.Drawing.Point(68, 553)
        Me.btnNewLot.Margin = New System.Windows.Forms.Padding(2)
        Me.btnNewLot.Name = "btnNewLot"
        Me.btnNewLot.ShadowDecoration.BorderRadius = 18
        Me.btnNewLot.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewLot.ShadowDecoration.Depth = 20
        Me.btnNewLot.ShadowDecoration.Enabled = True
        Me.btnNewLot.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnNewLot.Size = New System.Drawing.Size(109, 45)
        Me.btnNewLot.TabIndex = 9
        Me.btnNewLot.Text = "New Lot"
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
        Me.btnSave.Location = New System.Drawing.Point(220, 556)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 18
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.ShadowDecoration.Depth = 20
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnSave.Size = New System.Drawing.Size(109, 45)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        '
        'txtEmployee
        '
        Me.txtEmployee.BackColor = System.Drawing.Color.Transparent
        Me.txtEmployee.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtEmployee.BorderRadius = 20
        Me.txtEmployee.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtEmployee.DefaultText = "Samples"
        Me.txtEmployee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtEmployee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployee.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.ForeColor = System.Drawing.Color.Silver
        Me.txtEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployee.Location = New System.Drawing.Point(32, 247)
        Me.txtEmployee.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployee.PlaceholderText = ""
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.SelectedText = ""
        Me.txtEmployee.ShadowDecoration.BorderRadius = 30
        Me.txtEmployee.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmployee.ShadowDecoration.Enabled = True
        Me.txtEmployee.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtEmployee.Size = New System.Drawing.Size(224, 35)
        Me.txtEmployee.TabIndex = 2
        '
        'txtLotNo
        '
        Me.txtLotNo.BackColor = System.Drawing.Color.Transparent
        Me.txtLotNo.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLotNo.BorderRadius = 20
        Me.txtLotNo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLotNo.DefaultText = "Enter Lot Number"
        Me.txtLotNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLotNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLotNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLotNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLotNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotNo.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.ForeColor = System.Drawing.Color.Silver
        Me.txtLotNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotNo.Location = New System.Drawing.Point(32, 170)
        Me.txtLotNo.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLotNo.PlaceholderText = ""
        Me.txtLotNo.SelectedText = ""
        Me.txtLotNo.ShadowDecoration.BorderRadius = 30
        Me.txtLotNo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLotNo.ShadowDecoration.Enabled = True
        Me.txtLotNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.txtLotNo.Size = New System.Drawing.Size(224, 35)
        Me.txtLotNo.TabIndex = 4
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 15
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnEnable)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblTime)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnWeight)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblCR)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblfooter)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtReading)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label9)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label8)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnReset)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lstResult)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnNewLot)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnSave)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtLotNo)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtPartNo)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cboShift)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtEmployee)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cboProcess)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.cboAssociate)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.SystemColors.Control
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.SystemColors.Control
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.SystemColors.Control
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.SystemColors.Control
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 99)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 35
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(548, 652)
        Me.Guna2CustomGradientPanel1.TabIndex = 6
        '
        'btnEnable
        '
        Me.btnEnable.BackColor = System.Drawing.Color.Transparent
        Me.btnEnable.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnEnable.BorderRadius = 18
        Me.btnEnable.BorderThickness = 3
        Me.btnEnable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnable.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnEnable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnEnable.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnEnable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnEnable.FillColor = System.Drawing.Color.White
        Me.btnEnable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnable.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnable.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnable.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnEnable.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnable.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnEnable.Image = CType(resources.GetObject("btnEnable.Image"), System.Drawing.Image)
        Me.btnEnable.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnEnable.Location = New System.Drawing.Point(381, 553)
        Me.btnEnable.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.ShadowDecoration.BorderRadius = 18
        Me.btnEnable.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnable.ShadowDecoration.Depth = 20
        Me.btnEnable.ShadowDecoration.Enabled = True
        Me.btnEnable.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnEnable.Size = New System.Drawing.Size(118, 45)
        Me.btnEnable.TabIndex = 8
        Me.btnEnable.Text = "Enable Save"
        Me.btnEnable.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(427, 627)
        Me.lblDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(37, 15)
        Me.lblDate.TabIndex = 34
        Me.lblDate.Text = "Date"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(447, 609)
        Me.lblTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(39, 15)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "Time"
        '
        'btnWeight
        '
        Me.btnWeight.BackColor = System.Drawing.Color.Transparent
        Me.btnWeight.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnWeight.BorderRadius = 18
        Me.btnWeight.BorderThickness = 3
        Me.btnWeight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnWeight.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnWeight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnWeight.FillColor = System.Drawing.Color.White
        Me.btnWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeight.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeight.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnWeight.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeight.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnWeight.Image = CType(resources.GetObject("btnWeight.Image"), System.Drawing.Image)
        Me.btnWeight.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnWeight.Location = New System.Drawing.Point(191, 607)
        Me.btnWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.ShadowDecoration.BorderRadius = 18
        Me.btnWeight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeight.ShadowDecoration.Depth = 20
        Me.btnWeight.ShadowDecoration.Enabled = True
        Me.btnWeight.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnWeight.Size = New System.Drawing.Size(109, 45)
        Me.btnWeight.TabIndex = 7
        Me.btnWeight.Text = "Weight"
        Me.btnWeight.Visible = False
        '
        'lblCR
        '
        Me.lblCR.AutoSize = True
        Me.lblCR.BackColor = System.Drawing.Color.Transparent
        Me.lblCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCR.Location = New System.Drawing.Point(5, 633)
        Me.lblCR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCR.Name = "lblCR"
        Me.lblCR.Size = New System.Drawing.Size(124, 9)
        Me.lblCR.TabIndex = 32
        Me.lblCR.Text = "© LF Philipines - TSG 2023"
        '
        'lblfooter
        '
        Me.lblfooter.AutoSize = True
        Me.lblfooter.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfooter.Location = New System.Drawing.Point(5, 622)
        Me.lblfooter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(145, 9)
        Me.lblfooter.TabIndex = 31
        Me.lblfooter.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.txtReading.Location = New System.Drawing.Point(292, 55)
        Me.txtReading.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.txtReading.Name = "txtReading"
        Me.txtReading.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReading.PlaceholderText = ""
        Me.txtReading.ReadOnly = True
        Me.txtReading.SelectedText = ""
        Me.txtReading.ShadowDecoration.BorderRadius = 30
        Me.txtReading.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReading.ShadowDecoration.Enabled = True
        Me.txtReading.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtReading.Size = New System.Drawing.Size(221, 57)
        Me.txtReading.TabIndex = 30
        Me.txtReading.TabStop = False
        Me.txtReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(38, 56)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(114, 20)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Part Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 219)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Samples:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 142)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(107, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Lot Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(38, 380)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Process:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(38, 304)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Shift:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 456)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 20)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Premelt Associate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(367, 20)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 32)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Result"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(154, 32)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Lot Details"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.BorderColor = System.Drawing.Color.Red
        Me.btnReset.BorderRadius = 18
        Me.btnReset.BorderThickness = 3
        Me.btnReset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnReset.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnReset.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnReset.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnReset.FillColor = System.Drawing.Color.White
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.Color.Red
        Me.btnReset.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.HoverState.FillColor = System.Drawing.Color.Red
        Me.btnReset.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnReset.Image = CType(resources.GetObject("btnReset.Image"), System.Drawing.Image)
        Me.btnReset.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnReset.Location = New System.Drawing.Point(375, 553)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.BorderRadius = 18
        Me.btnReset.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.ShadowDecoration.Depth = 20
        Me.btnReset.ShadowDecoration.Enabled = True
        Me.btnReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnReset.Size = New System.Drawing.Size(109, 45)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Clear"
        '
        'lstResult
        '
        Me.lstResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 29
        Me.lstResult.Location = New System.Drawing.Point(292, 134)
        Me.lstResult.Margin = New System.Windows.Forms.Padding(2)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(229, 381)
        Me.lstResult.TabIndex = 19
        Me.lstResult.TabStop = False
        '
        'cboShift
        '
        Me.cboShift.BackColor = System.Drawing.Color.Transparent
        Me.cboShift.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboShift.BorderRadius = 15
        Me.cboShift.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboShift.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboShift.DropDownHeight = 100
        Me.cboShift.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboShift.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboShift.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboShift.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.ForeColor = System.Drawing.Color.Black
        Me.cboShift.IntegralHeight = False
        Me.cboShift.ItemHeight = 30
        Me.cboShift.Location = New System.Drawing.Point(32, 327)
        Me.cboShift.Margin = New System.Windows.Forms.Padding(2)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.ShadowDecoration.BorderRadius = 30
        Me.cboShift.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboShift.ShadowDecoration.Enabled = True
        Me.cboShift.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.cboShift.Size = New System.Drawing.Size(224, 36)
        Me.cboShift.TabIndex = 3
        '
        'cboProcess
        '
        Me.cboProcess.BackColor = System.Drawing.Color.Transparent
        Me.cboProcess.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboProcess.BorderRadius = 15
        Me.cboProcess.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboProcess.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboProcess.DropDownHeight = 300
        Me.cboProcess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProcess.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProcess.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboProcess.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcess.ForeColor = System.Drawing.Color.Black
        Me.cboProcess.FormattingEnabled = True
        Me.cboProcess.IntegralHeight = False
        Me.cboProcess.ItemHeight = 30
        Me.cboProcess.Location = New System.Drawing.Point(32, 412)
        Me.cboProcess.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProcess.MaxDropDownItems = 15
        Me.cboProcess.Name = "cboProcess"
        Me.cboProcess.ShadowDecoration.BorderRadius = 30
        Me.cboProcess.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboProcess.ShadowDecoration.Enabled = True
        Me.cboProcess.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.cboProcess.Size = New System.Drawing.Size(224, 36)
        Me.cboProcess.TabIndex = 1
        '
        'cboAssociate
        '
        Me.cboAssociate.BackColor = System.Drawing.Color.Transparent
        Me.cboAssociate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboAssociate.BorderRadius = 15
        Me.cboAssociate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboAssociate.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAssociate.DropDownHeight = 100
        Me.cboAssociate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssociate.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAssociate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAssociate.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssociate.ForeColor = System.Drawing.Color.Black
        Me.cboAssociate.IntegralHeight = False
        Me.cboAssociate.ItemHeight = 30
        Me.cboAssociate.Location = New System.Drawing.Point(32, 479)
        Me.cboAssociate.Margin = New System.Windows.Forms.Padding(2)
        Me.cboAssociate.Name = "cboAssociate"
        Me.cboAssociate.ShadowDecoration.BorderRadius = 30
        Me.cboAssociate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAssociate.ShadowDecoration.Enabled = True
        Me.cboAssociate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 15, 15)
        Me.cboAssociate.Size = New System.Drawing.Size(224, 36)
        Me.cboAssociate.TabIndex = 5
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.BorderRadius = 15
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lblQty109)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label11)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lblQty108)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.lblDoor_112)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label13)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.send_status_lbl)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.PictureBox1)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.MenuStrip2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.MenuStrip1)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(548, 99)
        Me.Guna2CustomGradientPanel2.TabIndex = 7
        '
        'lblQty109
        '
        Me.lblQty109.AutoSize = True
        Me.lblQty109.BackColor = System.Drawing.Color.Transparent
        Me.lblQty109.Location = New System.Drawing.Point(350, 25)
        Me.lblQty109.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQty109.Name = "lblQty109"
        Me.lblQty109.Size = New System.Drawing.Size(29, 13)
        Me.lblQty109.TabIndex = 97
        Me.lblQty109.Text = "Qty2"
        Me.lblQty109.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(278, 5)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 96
        Me.Label11.Text = "Main Counter:"
        Me.Label11.Visible = False
        '
        'lblQty108
        '
        Me.lblQty108.AutoSize = True
        Me.lblQty108.BackColor = System.Drawing.Color.Transparent
        Me.lblQty108.Location = New System.Drawing.Point(350, 5)
        Me.lblQty108.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQty108.Name = "lblQty108"
        Me.lblQty108.Size = New System.Drawing.Size(29, 13)
        Me.lblQty108.TabIndex = 95
        Me.lblQty108.Text = "Qty1"
        Me.lblQty108.Visible = False
        '
        'lblDoor_112
        '
        Me.lblDoor_112.AutoSize = True
        Me.lblDoor_112.BackColor = System.Drawing.Color.Transparent
        Me.lblDoor_112.Location = New System.Drawing.Point(494, 16)
        Me.lblDoor_112.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDoor_112.Name = "lblDoor_112"
        Me.lblDoor_112.Size = New System.Drawing.Size(31, 13)
        Me.lblDoor_112.TabIndex = 94
        Me.lblDoor_112.Text = "0000"
        Me.lblDoor_112.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(434, 16)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 93
        Me.Label13.Text = "Door Lock:"
        Me.Label13.Visible = False
        '
        'send_status_lbl
        '
        Me.send_status_lbl.BackColor = System.Drawing.Color.Transparent
        Me.send_status_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.send_status_lbl.Location = New System.Drawing.Point(98, 6)
        Me.send_status_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.send_status_lbl.Name = "send_status_lbl"
        Me.send_status_lbl.Size = New System.Drawing.Size(220, 28)
        Me.send_status_lbl.TabIndex = 86
        Me.send_status_lbl.Text = "Status"
        Me.send_status_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.send_status_lbl.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(15, 26)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 65)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(548, 24)
        Me.MenuStrip2.TabIndex = 98
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeCOMNameToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ChangeCOMNameToolStripMenuItem
        '
        Me.ChangeCOMNameToolStripMenuItem.Image = CType(resources.GetObject("ChangeCOMNameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeCOMNameToolStripMenuItem.Name = "ChangeCOMNameToolStripMenuItem"
        Me.ChangeCOMNameToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ChangeCOMNameToolStripMenuItem.Text = "Change COM name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(109, 34)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(437, 43)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PICO Solder Weight to Infinity"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(548, 24)
        Me.MenuStrip1.TabIndex = 22
        Me.MenuStrip1.Text = "MenuStrip1"
        Me.MenuStrip1.Visible = False
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAssociateToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddAssociateToolStripMenuItem
        '
        Me.AddAssociateToolStripMenuItem.Image = CType(resources.GetObject("AddAssociateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddAssociateToolStripMenuItem.Name = "AddAssociateToolStripMenuItem"
        Me.AddAssociateToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.AddAssociateToolStripMenuItem.Text = "Add Associate"
        '
        'Guna2ContextMenuStrip2
        '
        Me.Guna2ContextMenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Guna2ContextMenuStrip2.Name = "Guna2ContextMenuStrip2"
        Me.Guna2ContextMenuStrip2.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.ColorTable = Nothing
        Me.Guna2ContextMenuStrip2.RenderStyle.RoundedEdges = True
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Guna2ContextMenuStrip2.RenderStyle.SelectionForeColor = System.Drawing.Color.White
        Me.Guna2ContextMenuStrip2.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.Guna2ContextMenuStrip2.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.Guna2ContextMenuStrip2.Size = New System.Drawing.Size(61, 4)
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM3"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Timer2
        '
        '
        'SerialPort2
        '
        Me.SerialPort2.PortName = "COM4"
        '
        'TimerPLC
        '
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 751)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PICO Solder Weight"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents txtPartNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnNewLot As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtLotNo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtEmployee As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents lstResult As ListBox
    Friend WithEvents btnReset As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Guna2ContextMenuStrip2 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAssociateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label4 As Label
    Friend WithEvents cboShift As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboProcess As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents cboAssociate As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtReading As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents lblCR As Label
    Friend WithEvents lblfooter As Label
    Friend WithEvents btnWeight As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnEnable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents TimerPLC As Timer
    Friend WithEvents lblDoor_112 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents send_status_lbl As Label
    Friend WithEvents lblQty109 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lblQty108 As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ChangeCOMNameToolStripMenuItem As ToolStripMenuItem
End Class
