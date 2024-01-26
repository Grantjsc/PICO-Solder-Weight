<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OCAP_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OCAP_Form))
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAlarm = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAssociate = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboMachine = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboTest = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPartNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboRootCause = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtOtherRC = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtOthersA = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboAction = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.btnSave = New Guna.UI2.WinForms.Guna2Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLotNum = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(1300, 143)
        Me.Guna2CustomGradientPanel2.TabIndex = 8
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
        Me.Label1.Location = New System.Drawing.Point(585, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 75)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "OCAP Form"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 222)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 31)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "Alarm:"
        '
        'txtAlarm
        '
        Me.txtAlarm.BackColor = System.Drawing.Color.Transparent
        Me.txtAlarm.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAlarm.BorderRadius = 20
        Me.txtAlarm.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAlarm.DefaultText = ""
        Me.txtAlarm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAlarm.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAlarm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAlarm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAlarm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAlarm.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlarm.ForeColor = System.Drawing.Color.Black
        Me.txtAlarm.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAlarm.Location = New System.Drawing.Point(120, 255)
        Me.txtAlarm.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtAlarm.Name = "txtAlarm"
        Me.txtAlarm.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAlarm.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAlarm.PlaceholderText = ""
        Me.txtAlarm.ReadOnly = True
        Me.txtAlarm.SelectedText = ""
        Me.txtAlarm.ShadowDecoration.BorderRadius = 30
        Me.txtAlarm.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAlarm.ShadowDecoration.Enabled = True
        Me.txtAlarm.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtAlarm.Size = New System.Drawing.Size(429, 62)
        Me.txtAlarm.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 31)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Associate:"
        '
        'txtAssociate
        '
        Me.txtAssociate.BackColor = System.Drawing.Color.Transparent
        Me.txtAssociate.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAssociate.BorderRadius = 20
        Me.txtAssociate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtAssociate.DefaultText = ""
        Me.txtAssociate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtAssociate.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtAssociate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssociate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtAssociate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssociate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAssociate.ForeColor = System.Drawing.Color.Black
        Me.txtAssociate.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtAssociate.Location = New System.Drawing.Point(120, 382)
        Me.txtAssociate.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtAssociate.Name = "txtAssociate"
        Me.txtAssociate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAssociate.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtAssociate.PlaceholderText = ""
        Me.txtAssociate.ReadOnly = True
        Me.txtAssociate.SelectedText = ""
        Me.txtAssociate.ShadowDecoration.BorderRadius = 30
        Me.txtAssociate.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtAssociate.ShadowDecoration.Enabled = True
        Me.txtAssociate.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtAssociate.Size = New System.Drawing.Size(429, 62)
        Me.txtAssociate.TabIndex = 51
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(120, 484)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 31)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Machine:"
        '
        'cboMachine
        '
        Me.cboMachine.BackColor = System.Drawing.Color.Transparent
        Me.cboMachine.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboMachine.BorderRadius = 15
        Me.cboMachine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboMachine.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboMachine.DropDownHeight = 100
        Me.cboMachine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMachine.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboMachine.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboMachine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboMachine.ForeColor = System.Drawing.Color.Black
        Me.cboMachine.IntegralHeight = False
        Me.cboMachine.ItemHeight = 30
        Me.cboMachine.Items.AddRange(New Object() {"Head 1", "Head 2", "Head 3", "Head 4"})
        Me.cboMachine.Location = New System.Drawing.Point(121, 516)
        Me.cboMachine.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboMachine.Name = "cboMachine"
        Me.cboMachine.ShadowDecoration.BorderRadius = 30
        Me.cboMachine.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboMachine.ShadowDecoration.Enabled = True
        Me.cboMachine.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboMachine.Size = New System.Drawing.Size(428, 36)
        Me.cboMachine.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(735, 223)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 31)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Test:"
        '
        'cboTest
        '
        Me.cboTest.BackColor = System.Drawing.Color.Transparent
        Me.cboTest.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboTest.BorderRadius = 15
        Me.cboTest.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboTest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboTest.DropDownHeight = 100
        Me.cboTest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTest.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboTest.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboTest.ForeColor = System.Drawing.Color.Black
        Me.cboTest.IntegralHeight = False
        Me.cboTest.ItemHeight = 30
        Me.cboTest.Items.AddRange(New Object() {"Solder Weight - Bottom (Pico)", "Solder Weight - (Pico)"})
        Me.cboTest.Location = New System.Drawing.Point(736, 255)
        Me.cboTest.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboTest.Name = "cboTest"
        Me.cboTest.ShadowDecoration.BorderRadius = 30
        Me.cboTest.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboTest.ShadowDecoration.Enabled = True
        Me.cboTest.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboTest.Size = New System.Drawing.Size(428, 36)
        Me.cboTest.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(120, 597)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 31)
        Me.Label4.TabIndex = 58
        Me.Label4.Text = "Part Number:"
        '
        'txtPartNum
        '
        Me.txtPartNum.BackColor = System.Drawing.Color.Transparent
        Me.txtPartNum.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPartNum.BorderRadius = 20
        Me.txtPartNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPartNum.DefaultText = ""
        Me.txtPartNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtPartNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtPartNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPartNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtPartNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPartNum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPartNum.ForeColor = System.Drawing.Color.Black
        Me.txtPartNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtPartNum.Location = New System.Drawing.Point(120, 630)
        Me.txtPartNum.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtPartNum.Name = "txtPartNum"
        Me.txtPartNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPartNum.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtPartNum.PlaceholderText = ""
        Me.txtPartNum.ReadOnly = True
        Me.txtPartNum.SelectedText = ""
        Me.txtPartNum.ShadowDecoration.BorderRadius = 30
        Me.txtPartNum.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPartNum.ShadowDecoration.Enabled = True
        Me.txtPartNum.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtPartNum.Size = New System.Drawing.Size(429, 62)
        Me.txtPartNum.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(735, 360)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(177, 31)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Root Cause:"
        '
        'cboRootCause
        '
        Me.cboRootCause.BackColor = System.Drawing.Color.Transparent
        Me.cboRootCause.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboRootCause.BorderRadius = 15
        Me.cboRootCause.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboRootCause.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboRootCause.DropDownHeight = 100
        Me.cboRootCause.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRootCause.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboRootCause.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboRootCause.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboRootCause.ForeColor = System.Drawing.Color.Black
        Me.cboRootCause.IntegralHeight = False
        Me.cboRootCause.ItemHeight = 30
        Me.cboRootCause.Items.AddRange(New Object() {"1. Wrong Encode", "2. MeasurementEquipment Problem", "3. Wrong Solder Part Number", "4. Others (Input root Cause):"})
        Me.cboRootCause.Location = New System.Drawing.Point(736, 392)
        Me.cboRootCause.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboRootCause.Name = "cboRootCause"
        Me.cboRootCause.ShadowDecoration.BorderRadius = 30
        Me.cboRootCause.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboRootCause.ShadowDecoration.Enabled = True
        Me.cboRootCause.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboRootCause.Size = New System.Drawing.Size(564, 36)
        Me.cboRootCause.TabIndex = 2
        '
        'txtOtherRC
        '
        Me.txtOtherRC.BackColor = System.Drawing.Color.Transparent
        Me.txtOtherRC.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOtherRC.BorderRadius = 20
        Me.txtOtherRC.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOtherRC.DefaultText = ""
        Me.txtOtherRC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOtherRC.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOtherRC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOtherRC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOtherRC.Enabled = False
        Me.txtOtherRC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOtherRC.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherRC.ForeColor = System.Drawing.Color.Black
        Me.txtOtherRC.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOtherRC.Location = New System.Drawing.Point(893, 448)
        Me.txtOtherRC.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtOtherRC.Name = "txtOtherRC"
        Me.txtOtherRC.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOtherRC.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtOtherRC.PlaceholderText = ""
        Me.txtOtherRC.SelectedText = ""
        Me.txtOtherRC.ShadowDecoration.BorderRadius = 30
        Me.txtOtherRC.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOtherRC.ShadowDecoration.Enabled = True
        Me.txtOtherRC.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtOtherRC.Size = New System.Drawing.Size(445, 57)
        Me.txtOtherRC.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(773, 464)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 31)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Others:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(773, 673)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(111, 31)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "Others:"
        '
        'txtOthersA
        '
        Me.txtOthersA.BackColor = System.Drawing.Color.Transparent
        Me.txtOthersA.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOthersA.BorderRadius = 20
        Me.txtOthersA.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtOthersA.DefaultText = ""
        Me.txtOthersA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtOthersA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtOthersA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOthersA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtOthersA.Enabled = False
        Me.txtOthersA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOthersA.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOthersA.ForeColor = System.Drawing.Color.Black
        Me.txtOthersA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtOthersA.Location = New System.Drawing.Point(893, 657)
        Me.txtOthersA.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.txtOthersA.Name = "txtOthersA"
        Me.txtOthersA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtOthersA.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtOthersA.PlaceholderText = ""
        Me.txtOthersA.SelectedText = ""
        Me.txtOthersA.ShadowDecoration.BorderRadius = 30
        Me.txtOthersA.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtOthersA.ShadowDecoration.Enabled = True
        Me.txtOthersA.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtOthersA.Size = New System.Drawing.Size(445, 57)
        Me.txtOthersA.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(735, 564)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 31)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "Action:"
        '
        'cboAction
        '
        Me.cboAction.BackColor = System.Drawing.Color.Transparent
        Me.cboAction.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboAction.BorderRadius = 15
        Me.cboAction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboAction.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cboAction.DropDownHeight = 100
        Me.cboAction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAction.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cboAction.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.cboAction.ForeColor = System.Drawing.Color.Black
        Me.cboAction.IntegralHeight = False
        Me.cboAction.ItemHeight = 30
        Me.cboAction.Items.AddRange(New Object() {"1. Call PE/ QA to edit the data", "2.a Clean the surface", "2.b Call Calibration-fix machine", "3.a Stop Production", "3.b Adjust Solder Cutter mc", "4. Inform PE/Tech (Update Note)", "5. Others ( Input Action):"})
        Me.cboAction.Location = New System.Drawing.Point(736, 596)
        Me.cboAction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboAction.Name = "cboAction"
        Me.cboAction.ShadowDecoration.BorderRadius = 30
        Me.cboAction.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cboAction.ShadowDecoration.Enabled = True
        Me.cboAction.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.cboAction.Size = New System.Drawing.Size(564, 36)
        Me.cboAction.TabIndex = 3
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
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.HoverState.FillColor = System.Drawing.Color.RoyalBlue
        Me.btnSave.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnSave.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnSave.Location = New System.Drawing.Point(584, 895)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.ShadowDecoration.BorderRadius = 18
        Me.btnSave.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSave.ShadowDecoration.Depth = 20
        Me.btnSave.ShadowDecoration.Enabled = True
        Me.btnSave.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnSave.Size = New System.Drawing.Size(167, 69)
        Me.btnSave.TabIndex = 4
        Me.btnSave.Text = "Save"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(120, 724)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(174, 31)
        Me.Label10.TabIndex = 68
        Me.Label10.Text = "Lot Number:"
        '
        'txtLotNum
        '
        Me.txtLotNum.BackColor = System.Drawing.Color.Transparent
        Me.txtLotNum.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtLotNum.BorderRadius = 20
        Me.txtLotNum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtLotNum.DefaultText = ""
        Me.txtLotNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtLotNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtLotNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLotNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtLotNum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotNum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLotNum.ForeColor = System.Drawing.Color.Black
        Me.txtLotNum.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtLotNum.Location = New System.Drawing.Point(120, 757)
        Me.txtLotNum.Margin = New System.Windows.Forms.Padding(8, 9, 8, 9)
        Me.txtLotNum.Name = "txtLotNum"
        Me.txtLotNum.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLotNum.PlaceholderForeColor = System.Drawing.Color.Black
        Me.txtLotNum.PlaceholderText = ""
        Me.txtLotNum.ReadOnly = True
        Me.txtLotNum.SelectedText = ""
        Me.txtLotNum.ShadowDecoration.BorderRadius = 30
        Me.txtLotNum.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtLotNum.ShadowDecoration.Enabled = True
        Me.txtLotNum.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0)
        Me.txtLotNum.Size = New System.Drawing.Size(429, 62)
        Me.txtLotNum.TabIndex = 67
        '
        'OCAP_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 1044)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtLotNum)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtOthersA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cboAction)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtOtherRC)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cboRootCause)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPartNum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboTest)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cboMachine)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAssociate)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtAlarm)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "OCAP_Form"
        Me.Text = "x"
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtAlarm As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAssociate As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboMachine As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cboTest As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPartNum As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cboRootCause As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtOtherRC As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtOthersA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cboAction As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label10 As Label
    Friend WithEvents txtLotNum As Guna.UI2.WinForms.Guna2TextBox
End Class
