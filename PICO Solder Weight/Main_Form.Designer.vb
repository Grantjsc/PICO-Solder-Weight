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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelMain.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.ForestGreen
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
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(196, 956)
        Me.Panel1.TabIndex = 0
        '
        'PanelSC
        '
        Me.PanelSC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSC.Location = New System.Drawing.Point(0, 294)
        Me.PanelSC.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSC.Name = "PanelSC"
        Me.PanelSC.Size = New System.Drawing.Size(8, 37)
        Me.PanelSC.TabIndex = 36
        Me.PanelSC.Visible = False
        '
        'PanelSW
        '
        Me.PanelSW.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PanelSW.Location = New System.Drawing.Point(0, 258)
        Me.PanelSW.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelSW.Name = "PanelSW"
        Me.PanelSW.Size = New System.Drawing.Size(8, 37)
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
        Me.btnSolderCutter.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolderCutter.ForeColor = System.Drawing.Color.White
        Me.btnSolderCutter.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnSolderCutter.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSolderCutter.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSolderCutter.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnSolderCutter.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSolderCutter.Location = New System.Drawing.Point(0, 295)
        Me.btnSolderCutter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSolderCutter.Name = "btnSolderCutter"
        Me.btnSolderCutter.Size = New System.Drawing.Size(196, 37)
        Me.btnSolderCutter.TabIndex = 37
        Me.btnSolderCutter.Text = "Solder Cutter"
        '
        'btnSolderWeight
        '
        Me.btnSolderWeight.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSolderWeight.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSolderWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSolderWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSolderWeight.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnSolderWeight.FillColor = System.Drawing.Color.Transparent
        Me.btnSolderWeight.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSolderWeight.ForeColor = System.Drawing.Color.White
        Me.btnSolderWeight.HoverState.FillColor = System.Drawing.SystemColors.Control
        Me.btnSolderWeight.HoverState.ForeColor = System.Drawing.Color.Black
        Me.btnSolderWeight.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.btnSolderWeight.ImageOffset = New System.Drawing.Point(5, 0)
        Me.btnSolderWeight.ImageSize = New System.Drawing.Size(35, 35)
        Me.btnSolderWeight.Location = New System.Drawing.Point(0, 258)
        Me.btnSolderWeight.Margin = New System.Windows.Forms.Padding(2)
        Me.btnSolderWeight.Name = "btnSolderWeight"
        Me.btnSolderWeight.Size = New System.Drawing.Size(196, 37)
        Me.btnSolderWeight.TabIndex = 35
        Me.btnSolderWeight.Text = "Solder Weight"
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 168)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(196, 90)
        Me.Panel2.TabIndex = 0
        '
        'lblCR
        '
        Me.lblCR.AutoSize = True
        Me.lblCR.BackColor = System.Drawing.Color.Transparent
        Me.lblCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCR.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCR.Location = New System.Drawing.Point(27, 938)
        Me.lblCR.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCR.Name = "lblCR"
        Me.lblCR.Size = New System.Drawing.Size(124, 9)
        Me.lblCR.TabIndex = 34
        Me.lblCR.Text = "© LF Philipines - TSG 2023"
        '
        'lblfooter
        '
        Me.lblfooter.AutoSize = True
        Me.lblfooter.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblfooter.Location = New System.Drawing.Point(27, 929)
        Me.lblfooter.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter.Name = "lblfooter"
        Me.lblfooter.Size = New System.Drawing.Size(145, 9)
        Me.lblfooter.TabIndex = 33
        Me.lblfooter.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 168)
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
        Me.PanelMain.Location = New System.Drawing.Point(196, 0)
        Me.PanelMain.Margin = New System.Windows.Forms.Padding(2)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(1081, 956)
        Me.PanelMain.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(352, 305)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(370, 103)
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
        Me.Label1.Location = New System.Drawing.Point(197, 435)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(697, 50)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PICO Solder Weight Closed Loop" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Main_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1277, 956)
        Me.Controls.Add(Me.PanelMain)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
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
End Class
