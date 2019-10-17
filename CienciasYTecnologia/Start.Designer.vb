<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.StartSkin = New CienciasYTecnologia.FormSkin()
        Me.StartB = New CienciasYTecnologia.FlatButton()
        Me.SaveScoreCB = New CienciasYTecnologia.FlatCheckBox()
        Me.FlatLabel2 = New CienciasYTecnologia.FlatLabel()
        Me.UsernameTB = New CienciasYTecnologia.FlatTextBox()
        Me.FlatLabel1 = New CienciasYTecnologia.FlatLabel()
        Me.FlatMini1 = New CienciasYTecnologia.FlatMini()
        Me.FlatClose1 = New CienciasYTecnologia.FlatClose()
        Me.StartSkin.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartSkin
        '
        Me.StartSkin.BackColor = System.Drawing.Color.White
        Me.StartSkin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.StartSkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.StartSkin.Controls.Add(Me.StartB)
        Me.StartSkin.Controls.Add(Me.SaveScoreCB)
        Me.StartSkin.Controls.Add(Me.FlatLabel2)
        Me.StartSkin.Controls.Add(Me.UsernameTB)
        Me.StartSkin.Controls.Add(Me.FlatLabel1)
        Me.StartSkin.Controls.Add(Me.FlatMini1)
        Me.StartSkin.Controls.Add(Me.FlatClose1)
        Me.StartSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StartSkin.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StartSkin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StartSkin.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.StartSkin.HeaderMaximize = False
        Me.StartSkin.Location = New System.Drawing.Point(0, 0)
        Me.StartSkin.Name = "StartSkin"
        Me.StartSkin.Size = New System.Drawing.Size(284, 244)
        Me.StartSkin.TabIndex = 0
        Me.StartSkin.Text = "Inicio"
        '
        'StartB
        '
        Me.StartB.BackColor = System.Drawing.Color.Transparent
        Me.StartB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.StartB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.StartB.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.StartB.Location = New System.Drawing.Point(15, 197)
        Me.StartB.Name = "StartB"
        Me.StartB.Rounded = False
        Me.StartB.Size = New System.Drawing.Size(259, 32)
        Me.StartB.TabIndex = 6
        Me.StartB.Text = "Iniciar"
        Me.StartB.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'SaveScoreCB
        '
        Me.SaveScoreCB.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.SaveScoreCB.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.SaveScoreCB.BorderColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.SaveScoreCB.Checked = True
        Me.SaveScoreCB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SaveScoreCB.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.SaveScoreCB.Location = New System.Drawing.Point(16, 168)
        Me.SaveScoreCB.Name = "SaveScoreCB"
        Me.SaveScoreCB.Options = CienciasYTecnologia.FlatCheckBox._Options.Style1
        Me.SaveScoreCB.Size = New System.Drawing.Size(258, 22)
        Me.SaveScoreCB.TabIndex = 5
        Me.SaveScoreCB.Text = "Guarda Puntuación"
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(67, 62)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(153, 37)
        Me.FlatLabel2.TabIndex = 4
        Me.FlatLabel2.Text = "Bienvenido"
        '
        'UsernameTB
        '
        Me.UsernameTB.BackColor = System.Drawing.Color.Transparent
        Me.UsernameTB.Location = New System.Drawing.Point(15, 132)
        Me.UsernameTB.MaxLength = 32767
        Me.UsernameTB.Multiline = False
        Me.UsernameTB.Name = "UsernameTB"
        Me.UsernameTB.ReadOnly = False
        Me.UsernameTB.Size = New System.Drawing.Size(259, 29)
        Me.UsernameTB.TabIndex = 3
        Me.UsernameTB.Text = "Visitante"
        Me.UsernameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.UsernameTB.TextColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.UsernameTB.UseSystemPasswordChar = False
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(12, 108)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(68, 21)
        Me.FlatLabel1.TabIndex = 2
        Me.FlatLabel1.Text = "Nombre"
        '
        'FlatMini1
        '
        Me.FlatMini1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatMini1.BackColor = System.Drawing.Color.White
        Me.FlatMini1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.FlatMini1.Font = New System.Drawing.Font("Marlett", 12.0!)
        Me.FlatMini1.Location = New System.Drawing.Point(230, 13)
        Me.FlatMini1.Name = "FlatMini1"
        Me.FlatMini1.Size = New System.Drawing.Size(18, 18)
        Me.FlatMini1.TabIndex = 1
        Me.FlatMini1.Text = "FlatMini1"
        Me.FlatMini1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(254, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 0
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 244)
        Me.Controls.Add(Me.StartSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.StartSkin.ResumeLayout(False)
        Me.StartSkin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StartSkin As FormSkin
    Friend WithEvents FlatMini1 As FlatMini
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents UsernameTB As FlatTextBox
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents StartB As FlatButton
    Friend WithEvents SaveScoreCB As FlatCheckBox
    Friend WithEvents FlatLabel2 As FlatLabel
End Class
