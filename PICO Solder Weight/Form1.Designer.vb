﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtQty = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtWeight = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCutterSet = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtBareWire = New Guna.UI2.WinForms.Guna2TextBox()
        Me.txtSolderWire = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnEnable = New Guna.UI2.WinForms.Guna2Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.btnWeight = New Guna.UI2.WinForms.Guna2Button()
        Me.txtReading = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReset = New Guna.UI2.WinForms.Guna2Button()
        Me.lstResult = New System.Windows.Forms.ListBox()
        Me.cboShift = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboProcess = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.cboAssociate = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddAssociateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SerialPort2 = New System.IO.Ports.SerialPort(Me.components)
        Me.TimerErrorMsg = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txtPartNo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartNo.ForeColor = System.Drawing.Color.Silver
        Me.txtPartNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPartNo.Location = New System.Drawing.Point(64, 340)
        Me.txtPartNo.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtPartNo.Name = "txtPartNo"
        Me.txtPartNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPartNo.PlaceholderText = ""
        Me.txtPartNo.SelectedText = ""
        Me.txtPartNo.ShadowDecoration.BorderRadius = 30
        Me.txtPartNo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPartNo.ShadowDecoration.Enabled = True
        Me.txtPartNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtPartNo.Size = New System.Drawing.Size(429, 62)
        Me.txtPartNo.TabIndex = 2
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
        Me.btnNewLot.Location = New System.Drawing.Point(163, 804)
        Me.btnNewLot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnNewLot.Name = "btnNewLot"
        Me.btnNewLot.ShadowDecoration.BorderRadius = 18
        Me.btnNewLot.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnNewLot.ShadowDecoration.Depth = 20
        Me.btnNewLot.ShadowDecoration.Enabled = True
        Me.btnNewLot.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnNewLot.Size = New System.Drawing.Size(167, 69)
        Me.btnNewLot.TabIndex = 10
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
        Me.btnSave.Location = New System.Drawing.Point(401, 804)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 18
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.ShadowDecoration.Depth = 20
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnSave.Size = New System.Drawing.Size(167, 69)
        Me.btnSave.TabIndex = 11
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
        Me.txtEmployee.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployee.ForeColor = System.Drawing.Color.Silver
        Me.txtEmployee.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtEmployee.Location = New System.Drawing.Point(69, 565)
        Me.txtEmployee.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtEmployee.Name = "txtEmployee"
        Me.txtEmployee.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtEmployee.PlaceholderText = ""
        Me.txtEmployee.ReadOnly = True
        Me.txtEmployee.SelectedText = ""
        Me.txtEmployee.ShadowDecoration.BorderRadius = 30
        Me.txtEmployee.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtEmployee.ShadowDecoration.Enabled = True
        Me.txtEmployee.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtEmployee.Size = New System.Drawing.Size(429, 62)
        Me.txtEmployee.TabIndex = 4
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
        Me.txtLotNo.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNo.ForeColor = System.Drawing.Color.Silver
        Me.txtLotNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotNo.Location = New System.Drawing.Point(69, 454)
        Me.txtLotNo.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtLotNo.Name = "txtLotNo"
        Me.txtLotNo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLotNo.PlaceholderText = ""
        Me.txtLotNo.SelectedText = ""
        Me.txtLotNo.ShadowDecoration.BorderRadius = 30
        Me.txtLotNo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLotNo.ShadowDecoration.Enabled = True
        Me.txtLotNo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtLotNo.Size = New System.Drawing.Size(429, 62)
        Me.txtLotNo.TabIndex = 3
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.AutoScroll = True
        Me.Guna2CustomGradientPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CustomGradientPanel1.BorderRadius = 15
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label14)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtQty)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Button3)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Button2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Button1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label13)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtWeight)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label12)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtCutterSet)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label11)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtBareWire)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtSolderWire)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label10)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnEnable)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblDate)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.lblTime)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.btnWeight)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.txtReading)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label9)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label7)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label8)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label6)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label3)
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
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 171)
        Me.Guna2CustomGradientPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.ShadowDecoration.BorderRadius = 35
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(1416, 931)
        Me.Guna2CustomGradientPanel1.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(295, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 31)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Quantity:"
        '
        'txtQty
        '
        Me.txtQty.BackColor = System.Drawing.Color.Transparent
        Me.txtQty.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtQty.BorderRadius = 20
        Me.txtQty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtQty.DefaultText = "Enter quantity"
        Me.txtQty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtQty.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtQty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtQty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.ForeColor = System.Drawing.Color.Silver
        Me.txtQty.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtQty.Location = New System.Drawing.Point(295, 111)
        Me.txtQty.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.PlaceholderText = ""
        Me.txtQty.SelectedText = ""
        Me.txtQty.ShadowDecoration.BorderRadius = 30
        Me.txtQty.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtQty.ShadowDecoration.Enabled = True
        Me.txtQty.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtQty.Size = New System.Drawing.Size(429, 62)
        Me.txtQty.TabIndex = 0
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(915, 843)
        Me.Button3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 50)
        Me.Button3.TabIndex = 46
        Me.Button3.Text = "OCAP"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1193, 843)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 50)
        Me.Button2.TabIndex = 45
        Me.Button2.Text = "Change MG"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1037, 843)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(131, 50)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Get mg and OCAP"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(60, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(172, 31)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "Weight(mg):"
        '
        'txtWeight
        '
        Me.txtWeight.BackColor = System.Drawing.Color.Transparent
        Me.txtWeight.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtWeight.BorderRadius = 20
        Me.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtWeight.DefaultText = "Enter weight"
        Me.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtWeight.ForeColor = System.Drawing.Color.Silver
        Me.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtWeight.Location = New System.Drawing.Point(60, 224)
        Me.txtWeight.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtWeight.PlaceholderText = ""
        Me.txtWeight.SelectedText = ""
        Me.txtWeight.ShadowDecoration.BorderRadius = 30
        Me.txtWeight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtWeight.ShadowDecoration.Enabled = True
        Me.txtWeight.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtWeight.Size = New System.Drawing.Size(429, 62)
        Me.txtWeight.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(524, 309)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(204, 31)
        Me.Label12.TabIndex = 41
        Me.Label12.Text = "Cutter Setting:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Imprint MT Shadow", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(353, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 56)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Lot Details"
        '
        'txtCutterSet
        '
        Me.txtCutterSet.BackColor = System.Drawing.Color.Transparent
        Me.txtCutterSet.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtCutterSet.BorderRadius = 20
        Me.txtCutterSet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCutterSet.DefaultText = "Enter Cutter Setting"
        Me.txtCutterSet.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtCutterSet.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtCutterSet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCutterSet.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtCutterSet.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCutterSet.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCutterSet.ForeColor = System.Drawing.Color.Silver
        Me.txtCutterSet.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtCutterSet.Location = New System.Drawing.Point(531, 343)
        Me.txtCutterSet.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtCutterSet.Name = "txtCutterSet"
        Me.txtCutterSet.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCutterSet.PlaceholderText = ""
        Me.txtCutterSet.SelectedText = ""
        Me.txtCutterSet.ShadowDecoration.BorderRadius = 30
        Me.txtCutterSet.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtCutterSet.ShadowDecoration.Enabled = True
        Me.txtCutterSet.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtCutterSet.Size = New System.Drawing.Size(384, 62)
        Me.txtCutterSet.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(524, 192)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(310, 31)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Bare Wire Lot Number:"
        '
        'txtBareWire
        '
        Me.txtBareWire.BackColor = System.Drawing.Color.Transparent
        Me.txtBareWire.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtBareWire.BorderRadius = 20
        Me.txtBareWire.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtBareWire.DefaultText = "Enter Bare Wire Lot #"
        Me.txtBareWire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtBareWire.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtBareWire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBareWire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtBareWire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBareWire.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBareWire.ForeColor = System.Drawing.Color.Silver
        Me.txtBareWire.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBareWire.Location = New System.Drawing.Point(529, 224)
        Me.txtBareWire.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtBareWire.Name = "txtBareWire"
        Me.txtBareWire.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBareWire.PlaceholderText = ""
        Me.txtBareWire.SelectedText = ""
        Me.txtBareWire.ShadowDecoration.BorderRadius = 30
        Me.txtBareWire.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtBareWire.ShadowDecoration.Enabled = True
        Me.txtBareWire.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtBareWire.Size = New System.Drawing.Size(384, 62)
        Me.txtBareWire.TabIndex = 5
        '
        'txtSolderWire
        '
        Me.txtSolderWire.BackColor = System.Drawing.Color.Transparent
        Me.txtSolderWire.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSolderWire.BorderRadius = 20
        Me.txtSolderWire.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSolderWire.DefaultText = "Enter Solder Wire Part #"
        Me.txtSolderWire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtSolderWire.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtSolderWire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSolderWire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtSolderWire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSolderWire.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolderWire.ForeColor = System.Drawing.Color.Silver
        Me.txtSolderWire.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtSolderWire.Location = New System.Drawing.Point(76, 681)
        Me.txtSolderWire.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtSolderWire.Name = "txtSolderWire"
        Me.txtSolderWire.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSolderWire.PlaceholderText = ""
        Me.txtSolderWire.SelectedText = ""
        Me.txtSolderWire.ShadowDecoration.BorderRadius = 30
        Me.txtSolderWire.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtSolderWire.ShadowDecoration.Enabled = True
        Me.txtSolderWire.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtSolderWire.Size = New System.Drawing.Size(429, 62)
        Me.txtSolderWire.TabIndex = 4
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(71, 650)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(346, 31)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Solder Wire Part Number:"
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
        Me.btnEnable.Location = New System.Drawing.Point(644, 804)
        Me.btnEnable.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEnable.Name = "btnEnable"
        Me.btnEnable.ShadowDecoration.BorderRadius = 18
        Me.btnEnable.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnable.ShadowDecoration.Depth = 20
        Me.btnEnable.ShadowDecoration.Enabled = True
        Me.btnEnable.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnEnable.Size = New System.Drawing.Size(167, 69)
        Me.btnEnable.TabIndex = 12
        Me.btnEnable.Text = "Enable Save"
        Me.btnEnable.Visible = False
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(1331, 875)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(43, 18)
        Me.lblDate.TabIndex = 34
        Me.lblDate.Text = "Date"
        Me.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDate.Visible = False
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.BackColor = System.Drawing.Color.Transparent
        Me.lblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTime.Location = New System.Drawing.Point(1355, 855)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(45, 18)
        Me.lblTime.TabIndex = 33
        Me.lblTime.Text = "Time"
        Me.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTime.Visible = False
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
        Me.btnWeight.Location = New System.Drawing.Point(563, 900)
        Me.btnWeight.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnWeight.Name = "btnWeight"
        Me.btnWeight.ShadowDecoration.BorderRadius = 18
        Me.btnWeight.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnWeight.ShadowDecoration.Depth = 20
        Me.btnWeight.ShadowDecoration.Enabled = True
        Me.btnWeight.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnWeight.Size = New System.Drawing.Size(145, 55)
        Me.btnWeight.TabIndex = 7
        Me.btnWeight.Text = "Weight"
        Me.btnWeight.Visible = False
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
        Me.txtReading.Location = New System.Drawing.Point(979, 101)
        Me.txtReading.Margin = New System.Windows.Forms.Padding(5, 7, 5, 7)
        Me.txtReading.Name = "txtReading"
        Me.txtReading.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReading.PlaceholderText = ""
        Me.txtReading.ReadOnly = True
        Me.txtReading.SelectedText = ""
        Me.txtReading.ShadowDecoration.BorderRadius = 30
        Me.txtReading.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReading.ShadowDecoration.Enabled = True
        Me.txtReading.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtReading.Size = New System.Drawing.Size(376, 110)
        Me.txtReading.TabIndex = 30
        Me.txtReading.TabStop = False
        Me.txtReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(64, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(187, 31)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Part Number:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(64, 533)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 31)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Samples:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 422)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 31)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Lot Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(528, 540)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 31)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Process:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(528, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 31)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Shift:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(535, 650)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(259, 31)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Premelt Associate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Imprint MT Shadow", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1091, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 47)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Result"
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
        Me.btnReset.Location = New System.Drawing.Point(652, 804)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.ShadowDecoration.BorderRadius = 18
        Me.btnReset.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.ShadowDecoration.Depth = 20
        Me.btnReset.ShadowDecoration.Enabled = True
        Me.btnReset.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnReset.Size = New System.Drawing.Size(167, 69)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "Clear"
        '
        'lstResult
        '
        Me.lstResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.ItemHeight = 36
        Me.lstResult.Location = New System.Drawing.Point(979, 240)
        Me.lstResult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(375, 472)
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
        Me.cboShift.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboShift.ForeColor = System.Drawing.Color.Black
        Me.cboShift.IntegralHeight = False
        Me.cboShift.ItemHeight = 30
        Me.cboShift.Location = New System.Drawing.Point(529, 460)
        Me.cboShift.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.ShadowDecoration.BorderRadius = 30
        Me.cboShift.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboShift.ShadowDecoration.Enabled = True
        Me.cboShift.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboShift.Size = New System.Drawing.Size(383, 36)
        Me.cboShift.TabIndex = 7
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
        Me.cboProcess.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProcess.ForeColor = System.Drawing.Color.Black
        Me.cboProcess.FormattingEnabled = True
        Me.cboProcess.IntegralHeight = False
        Me.cboProcess.ItemHeight = 30
        Me.cboProcess.Location = New System.Drawing.Point(532, 571)
        Me.cboProcess.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProcess.MaxDropDownItems = 15
        Me.cboProcess.Name = "cboProcess"
        Me.cboProcess.ShadowDecoration.BorderRadius = 30
        Me.cboProcess.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboProcess.ShadowDecoration.Enabled = True
        Me.cboProcess.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboProcess.Size = New System.Drawing.Size(383, 36)
        Me.cboProcess.TabIndex = 8
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
        Me.cboAssociate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAssociate.ForeColor = System.Drawing.Color.Black
        Me.cboAssociate.IntegralHeight = False
        Me.cboAssociate.ItemHeight = 30
        Me.cboAssociate.Location = New System.Drawing.Point(541, 682)
        Me.cboAssociate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAssociate.Name = "cboAssociate"
        Me.cboAssociate.ShadowDecoration.BorderRadius = 30
        Me.cboAssociate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAssociate.ShadowDecoration.Enabled = True
        Me.cboAssociate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboAssociate.Size = New System.Drawing.Size(383, 36)
        Me.cboAssociate.TabIndex = 9
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
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 28)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(1416, 143)
        Me.Guna2CustomGradientPanel2.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(21, 5)
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
        Me.Label1.Location = New System.Drawing.Point(343, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(748, 75)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PICO Solder Weight to Infinity"
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
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1416, 28)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddAssociateToolStripMenuItem})
        Me.MenuToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'AddAssociateToolStripMenuItem
        '
        Me.AddAssociateToolStripMenuItem.Image = CType(resources.GetObject("AddAssociateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddAssociateToolStripMenuItem.Name = "AddAssociateToolStripMenuItem"
        Me.AddAssociateToolStripMenuItem.Size = New System.Drawing.Size(192, 26)
        Me.AddAssociateToolStripMenuItem.Text = "Add Associate"
        '
        'TimerErrorMsg
        '
        Me.TimerErrorMsg.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1416, 1102)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents btnWeight As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents btnEnable As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents txtBareWire As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents txtSolderWire As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtCutterSet As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtWeight As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddAssociateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SerialPort2 As IO.Ports.SerialPort
    Friend WithEvents TimerErrorMsg As Timer
    Friend WithEvents Label14 As Label
    Friend WithEvents txtQty As Guna.UI2.WinForms.Guna2TextBox
End Class
