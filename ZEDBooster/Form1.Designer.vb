<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MemoriaRamX = New System.Windows.Forms.Timer(Me.components)
        Me.imgIcons = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FormSkin1 = New ZEDBooster.FormSkin()
        Me.FlatMini1 = New ZEDBooster.FlatMini()
        Me.FlatClose1 = New ZEDBooster.FlatClose()
        Me.UsoCPU_Label = New ZEDBooster.FlatLabel()
        Me.Label1 = New ZEDBooster.FlatLabel()
        Me.FlatLabel1 = New ZEDBooster.FlatLabel()
        Me.FlatButton2 = New ZEDBooster.FlatButton()
        Me.UsoMemoriaVirtual_Label = New ZEDBooster.FlatLabel()
        Me.UsoMemoriaFisica_Label = New ZEDBooster.FlatLabel()
        Me.Label6 = New ZEDBooster.FlatLabel()
        Me.ProgressBar1 = New ZEDBooster.FlatProgressBar()
        Me.FlatButton1 = New ZEDBooster.FlatButton()
        Me.UsoMemoriaVirtual_Progress = New ZEDBooster.FlatProgressBar()
        Me.UsoMemoriaFisica_Progress = New ZEDBooster.FlatProgressBar()
        Me.lwProcs = New System.Windows.Forms.ListView()
        Me.coluna5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FlatToggle1 = New ZEDBooster.FlatToggle()
        Me.FlatStatusBar1 = New ZEDBooster.FlatStatusBar()
        Me.FormSkin1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MemoriaRamX
        '
        Me.MemoriaRamX.Enabled = True
        Me.MemoriaRamX.Interval = 1000
        '
        'imgIcons
        '
        Me.imgIcons.ImageStream = CType(resources.GetObject("imgIcons.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgIcons.TransparentColor = System.Drawing.Color.Transparent
        Me.imgIcons.Images.SetKeyName(0, "application-128.png")
        '
        'Timer1
        '
        '
        'FormSkin1
        '
        Me.FormSkin1.BackColor = System.Drawing.Color.White
        Me.FormSkin1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FormSkin1.Controls.Add(Me.FlatMini1)
        Me.FormSkin1.Controls.Add(Me.FlatClose1)
        Me.FormSkin1.Controls.Add(Me.UsoCPU_Label)
        Me.FormSkin1.Controls.Add(Me.Label1)
        Me.FormSkin1.Controls.Add(Me.FlatLabel1)
        Me.FormSkin1.Controls.Add(Me.FlatButton2)
        Me.FormSkin1.Controls.Add(Me.UsoMemoriaVirtual_Label)
        Me.FormSkin1.Controls.Add(Me.UsoMemoriaFisica_Label)
        Me.FormSkin1.Controls.Add(Me.Label6)
        Me.FormSkin1.Controls.Add(Me.ProgressBar1)
        Me.FormSkin1.Controls.Add(Me.FlatButton1)
        Me.FormSkin1.Controls.Add(Me.UsoMemoriaVirtual_Progress)
        Me.FormSkin1.Controls.Add(Me.UsoMemoriaFisica_Progress)
        Me.FormSkin1.Controls.Add(Me.lwProcs)
        Me.FormSkin1.Controls.Add(Me.FlatToggle1)
        Me.FormSkin1.Controls.Add(Me.FlatStatusBar1)
        Me.FormSkin1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FormSkin1.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FormSkin1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormSkin1.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FormSkin1.HeaderMaximize = False
        Me.FormSkin1.Location = New System.Drawing.Point(0, 0)
        Me.FormSkin1.Name = "FormSkin1"
        Me.FormSkin1.Size = New System.Drawing.Size(743, 477)
        Me.FormSkin1.TabIndex = 0
        Me.FormSkin1.Text = "ZedBosster"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(689, 4)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 16
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(713, 4)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 15
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(220, Byte), Integer))
        '
        'UsoCPU_Label
        '
        Me.UsoCPU_Label.AutoSize = True
        Me.UsoCPU_Label.BackColor = System.Drawing.Color.Transparent
        Me.UsoCPU_Label.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UsoCPU_Label.ForeColor = System.Drawing.Color.White
        Me.UsoCPU_Label.Location = New System.Drawing.Point(488, 41)
        Me.UsoCPU_Label.Name = "UsoCPU_Label"
        Me.UsoCPU_Label.Size = New System.Drawing.Size(67, 13)
        Me.UsoCPU_Label.TabIndex = 14
        Me.UsoCPU_Label.Text = "CPU && RAM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(488, 145)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "000"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.Aqua
        Me.FlatLabel1.Location = New System.Drawing.Point(283, 9)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(79, 13)
        Me.FlatLabel1.TabIndex = 12
        Me.FlatLabel1.Text = "Strensh Mode"
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(12, 125)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(109, 42)
        Me.FlatButton2.TabIndex = 11
        Me.FlatButton2.Text = "Atualizar list"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'UsoMemoriaVirtual_Label
        '
        Me.UsoMemoriaVirtual_Label.AutoSize = True
        Me.UsoMemoriaVirtual_Label.BackColor = System.Drawing.Color.Transparent
        Me.UsoMemoriaVirtual_Label.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UsoMemoriaVirtual_Label.ForeColor = System.Drawing.Color.White
        Me.UsoMemoriaVirtual_Label.Location = New System.Drawing.Point(190, 109)
        Me.UsoMemoriaVirtual_Label.Name = "UsoMemoriaVirtual_Label"
        Me.UsoMemoriaVirtual_Label.Size = New System.Drawing.Size(25, 13)
        Me.UsoMemoriaVirtual_Label.TabIndex = 10
        Me.UsoMemoriaVirtual_Label.Text = "000"
        '
        'UsoMemoriaFisica_Label
        '
        Me.UsoMemoriaFisica_Label.AutoSize = True
        Me.UsoMemoriaFisica_Label.BackColor = System.Drawing.Color.Transparent
        Me.UsoMemoriaFisica_Label.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.UsoMemoriaFisica_Label.ForeColor = System.Drawing.Color.White
        Me.UsoMemoriaFisica_Label.Location = New System.Drawing.Point(190, 41)
        Me.UsoMemoriaFisica_Label.Name = "UsoMemoriaFisica_Label"
        Me.UsoMemoriaFisica_Label.Size = New System.Drawing.Size(25, 13)
        Me.UsoMemoriaFisica_Label.TabIndex = 9
        Me.UsoMemoriaFisica_Label.Text = "000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(692, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "000"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(491, 57)
        Me.ProgressBar1.Maximum = 100
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.ProgressBar1.Size = New System.Drawing.Size(226, 42)
        Me.ProgressBar1.TabIndex = 7
        Me.ProgressBar1.Text = "FlatProgressBar1"
        Me.ProgressBar1.Value = 0
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 57)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(109, 42)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "Booster PC"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'UsoMemoriaVirtual_Progress
        '
        Me.UsoMemoriaVirtual_Progress.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UsoMemoriaVirtual_Progress.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UsoMemoriaVirtual_Progress.Location = New System.Drawing.Point(193, 125)
        Me.UsoMemoriaVirtual_Progress.Maximum = 1000
        Me.UsoMemoriaVirtual_Progress.Name = "UsoMemoriaVirtual_Progress"
        Me.UsoMemoriaVirtual_Progress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UsoMemoriaVirtual_Progress.Size = New System.Drawing.Size(261, 42)
        Me.UsoMemoriaVirtual_Progress.TabIndex = 4
        Me.UsoMemoriaVirtual_Progress.Text = "FlatProgressBar1"
        Me.UsoMemoriaVirtual_Progress.Value = 0
        '
        'UsoMemoriaFisica_Progress
        '
        Me.UsoMemoriaFisica_Progress.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.UsoMemoriaFisica_Progress.DarkerProgress = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UsoMemoriaFisica_Progress.Location = New System.Drawing.Point(193, 57)
        Me.UsoMemoriaFisica_Progress.Maximum = 1000
        Me.UsoMemoriaFisica_Progress.Name = "UsoMemoriaFisica_Progress"
        Me.UsoMemoriaFisica_Progress.ProgressColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.UsoMemoriaFisica_Progress.Size = New System.Drawing.Size(261, 42)
        Me.UsoMemoriaFisica_Progress.TabIndex = 3
        Me.UsoMemoriaFisica_Progress.Text = "FlatProgressBar1"
        Me.UsoMemoriaFisica_Progress.Value = 0
        '
        'lwProcs
        '
        Me.lwProcs.BackColor = System.Drawing.Color.White
        Me.lwProcs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.coluna5, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lwProcs.FullRowSelect = True
        Me.lwProcs.GridLines = True
        Me.lwProcs.Location = New System.Drawing.Point(12, 204)
        Me.lwProcs.Name = "lwProcs"
        Me.lwProcs.Size = New System.Drawing.Size(719, 244)
        Me.lwProcs.TabIndex = 2
        Me.lwProcs.UseCompatibleStateImageBehavior = False
        Me.lwProcs.View = System.Windows.Forms.View.Details
        '
        'coluna5
        '
        Me.coluna5.Text = "ID"
        Me.coluna5.Width = 66
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Process"
        Me.ColumnHeader1.Width = 97
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Caption"
        Me.ColumnHeader2.Width = 294
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Memory"
        Me.ColumnHeader3.Width = 119
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Diferencial"
        Me.ColumnHeader4.Width = 118
        '
        'FlatToggle1
        '
        Me.FlatToggle1.BackColor = System.Drawing.Color.Transparent
        Me.FlatToggle1.Checked = True
        Me.FlatToggle1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatToggle1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.FlatToggle1.Location = New System.Drawing.Point(378, 3)
        Me.FlatToggle1.Name = "FlatToggle1"
        Me.FlatToggle1.Options = ZEDBooster.FlatToggle._Options.Style1
        Me.FlatToggle1.Size = New System.Drawing.Size(76, 33)
        Me.FlatToggle1.TabIndex = 1
        Me.FlatToggle1.Text = "FlatToggle1"
        '
        'FlatStatusBar1
        '
        Me.FlatStatusBar1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.FlatStatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlatStatusBar1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatStatusBar1.ForeColor = System.Drawing.Color.White
        Me.FlatStatusBar1.Location = New System.Drawing.Point(0, 454)
        Me.FlatStatusBar1.Name = "FlatStatusBar1"
        Me.FlatStatusBar1.RectColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(220, Byte), Integer))
        Me.FlatStatusBar1.ShowTimeDate = False
        Me.FlatStatusBar1.Size = New System.Drawing.Size(743, 23)
        Me.FlatStatusBar1.TabIndex = 0
        Me.FlatStatusBar1.Text = "FlatStatusBar1"
        Me.FlatStatusBar1.TextColor = System.Drawing.Color.White
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 477)
        Me.Controls.Add(Me.FormSkin1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.FormSkin1.ResumeLayout(False)
        Me.FormSkin1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents FormSkin1 As ZEDBooster.FormSkin
    Friend WithEvents FlatToggle1 As ZEDBooster.FlatToggle
    Friend WithEvents FlatStatusBar1 As ZEDBooster.FlatStatusBar
    Friend WithEvents MemoriaRamX As System.Windows.Forms.Timer
    Friend WithEvents imgIcons As System.Windows.Forms.ImageList
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents FlatLabel1 As ZEDBooster.FlatLabel
    Friend WithEvents FlatMini1 As ZEDBooster.FlatMini
    Friend WithEvents FlatClose1 As ZEDBooster.FlatClose
    Friend WithEvents UsoCPU_Label As ZEDBooster.FlatLabel
    Friend WithEvents Label1 As ZEDBooster.FlatLabel
    Friend WithEvents FlatButton2 As ZEDBooster.FlatButton
    Friend WithEvents UsoMemoriaVirtual_Label As ZEDBooster.FlatLabel
    Friend WithEvents UsoMemoriaFisica_Label As ZEDBooster.FlatLabel
    Friend WithEvents Label6 As ZEDBooster.FlatLabel
    Friend WithEvents ProgressBar1 As ZEDBooster.FlatProgressBar
    Friend WithEvents FlatButton1 As ZEDBooster.FlatButton
    Friend WithEvents UsoMemoriaVirtual_Progress As ZEDBooster.FlatProgressBar
    Friend WithEvents UsoMemoriaFisica_Progress As ZEDBooster.FlatProgressBar
    Friend WithEvents lwProcs As System.Windows.Forms.ListView
    Friend WithEvents coluna5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader

End Class
