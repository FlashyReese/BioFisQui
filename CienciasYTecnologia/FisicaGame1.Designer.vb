<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FisicaGame1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FisicaGame1))
        Me.GameSkin = New CienciasYTecnologia.FormSkin()
        Me.FlatLabel1 = New CienciasYTecnologia.FlatLabel()
        Me.FlatButton1 = New CienciasYTecnologia.FlatButton()
        Me.FlatClose1 = New CienciasYTecnologia.FlatClose()
        Me.PB = New System.Windows.Forms.PictureBox()
        Me.AB4 = New CienciasYTecnologia.FlatButton()
        Me.AB3 = New CienciasYTecnologia.FlatButton()
        Me.AB2 = New CienciasYTecnologia.FlatButton()
        Me.AB1 = New CienciasYTecnologia.FlatButton()
        Me.GameSkin.SuspendLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameSkin
        '
        Me.GameSkin.BackColor = System.Drawing.Color.White
        Me.GameSkin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GameSkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GameSkin.Controls.Add(Me.FlatLabel1)
        Me.GameSkin.Controls.Add(Me.FlatButton1)
        Me.GameSkin.Controls.Add(Me.FlatClose1)
        Me.GameSkin.Controls.Add(Me.PB)
        Me.GameSkin.Controls.Add(Me.AB4)
        Me.GameSkin.Controls.Add(Me.AB3)
        Me.GameSkin.Controls.Add(Me.AB2)
        Me.GameSkin.Controls.Add(Me.AB1)
        Me.GameSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameSkin.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GameSkin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GameSkin.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GameSkin.HeaderMaximize = False
        Me.GameSkin.Location = New System.Drawing.Point(0, 0)
        Me.GameSkin.Name = "GameSkin"
        Me.GameSkin.Size = New System.Drawing.Size(356, 541)
        Me.GameSkin.TabIndex = 0
        Me.GameSkin.Text = "Fisica Nivel 1"
        '
        'FlatLabel1
        '
        Me.FlatLabel1.AutoSize = True
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(14, 515)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(29, 13)
        Me.FlatLabel1.TabIndex = 7
        Me.FlatLabel1.Text = "1/10"
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(222, 497)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(126, 32)
        Me.FlatButton1.TabIndex = 6
        Me.FlatButton1.Text = "Regresar"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(329, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 5
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'PB
        '
        Me.PB.Image = Global.CienciasYTecnologia.My.Resources.Resources.sistemaesqueleto
        Me.PB.InitialImage = Global.CienciasYTecnologia.My.Resources.Resources.apendice
        Me.PB.Location = New System.Drawing.Point(14, 53)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(334, 330)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 4
        Me.PB.TabStop = False
        '
        'AB4
        '
        Me.AB4.BackColor = System.Drawing.Color.Transparent
        Me.AB4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AB4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AB4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AB4.Location = New System.Drawing.Point(184, 427)
        Me.AB4.Name = "AB4"
        Me.AB4.Rounded = False
        Me.AB4.Size = New System.Drawing.Size(164, 32)
        Me.AB4.TabIndex = 3
        Me.AB4.Text = "Answer4"
        Me.AB4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'AB3
        '
        Me.AB3.BackColor = System.Drawing.Color.Transparent
        Me.AB3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AB3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AB3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AB3.Location = New System.Drawing.Point(14, 427)
        Me.AB3.Name = "AB3"
        Me.AB3.Rounded = False
        Me.AB3.Size = New System.Drawing.Size(164, 32)
        Me.AB3.TabIndex = 2
        Me.AB3.Text = "Answer3"
        Me.AB3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'AB2
        '
        Me.AB2.BackColor = System.Drawing.Color.Transparent
        Me.AB2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AB2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AB2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AB2.Location = New System.Drawing.Point(184, 389)
        Me.AB2.Name = "AB2"
        Me.AB2.Rounded = False
        Me.AB2.Size = New System.Drawing.Size(164, 32)
        Me.AB2.TabIndex = 1
        Me.AB2.Text = "Answer2"
        Me.AB2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'AB1
        '
        Me.AB1.BackColor = System.Drawing.Color.Transparent
        Me.AB1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.AB1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AB1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.AB1.Location = New System.Drawing.Point(14, 389)
        Me.AB1.Name = "AB1"
        Me.AB1.Rounded = False
        Me.AB1.Size = New System.Drawing.Size(164, 32)
        Me.AB1.TabIndex = 0
        Me.AB1.Text = "Answer1"
        Me.AB1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FisicaGame1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 541)
        Me.Controls.Add(Me.GameSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FisicaGame1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Game"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GameSkin.ResumeLayout(False)
        Me.GameSkin.PerformLayout()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameSkin As FormSkin
    Friend WithEvents AB1 As FlatButton
    Friend WithEvents PB As PictureBox
    Friend WithEvents AB4 As FlatButton
    Friend WithEvents AB3 As FlatButton
    Friend WithEvents AB2 As FlatButton
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatLabel1 As FlatLabel
End Class
