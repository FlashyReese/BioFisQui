<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BiologiaGame3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BGame3))
        Me.GameSkin = New CienciasYTecnologia.FormSkin()
        Me.FlatClose1 = New CienciasYTecnologia.FlatClose()
        Me.FlatLabel1 = New CienciasYTecnologia.FlatLabel()
        Me.FlatButton4 = New CienciasYTecnologia.FlatButton()
        Me.FlatButton3 = New CienciasYTecnologia.FlatButton()
        Me.FlatButton2 = New CienciasYTecnologia.FlatButton()
        Me.FlatButton1 = New CienciasYTecnologia.FlatButton()
        Me.FlatButton5 = New CienciasYTecnologia.FlatButton()
        Me.FlatLabel2 = New CienciasYTecnologia.FlatLabel()
        Me.GameSkin.SuspendLayout()
        Me.SuspendLayout()
        '
        'GameSkin
        '
        Me.GameSkin.BackColor = System.Drawing.Color.White
        Me.GameSkin.BaseColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.GameSkin.BorderColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.GameSkin.Controls.Add(Me.FlatLabel2)
        Me.GameSkin.Controls.Add(Me.FlatButton5)
        Me.GameSkin.Controls.Add(Me.FlatClose1)
        Me.GameSkin.Controls.Add(Me.FlatLabel1)
        Me.GameSkin.Controls.Add(Me.FlatButton4)
        Me.GameSkin.Controls.Add(Me.FlatButton3)
        Me.GameSkin.Controls.Add(Me.FlatButton2)
        Me.GameSkin.Controls.Add(Me.FlatButton1)
        Me.GameSkin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GameSkin.FlatColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.GameSkin.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.GameSkin.HeaderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.GameSkin.HeaderMaximize = False
        Me.GameSkin.Location = New System.Drawing.Point(0, 0)
        Me.GameSkin.Name = "GameSkin"
        Me.GameSkin.Size = New System.Drawing.Size(567, 462)
        Me.GameSkin.TabIndex = 0
        Me.GameSkin.Text = "Biologia Nivel 3"
        '
        'FlatClose1
        '
        Me.FlatClose1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlatClose1.BackColor = System.Drawing.Color.White
        Me.FlatClose1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FlatClose1.Font = New System.Drawing.Font("Marlett", 10.0!)
        Me.FlatClose1.Location = New System.Drawing.Point(537, 13)
        Me.FlatClose1.Name = "FlatClose1"
        Me.FlatClose1.Size = New System.Drawing.Size(18, 18)
        Me.FlatClose1.TabIndex = 5
        Me.FlatClose1.Text = "FlatClose1"
        Me.FlatClose1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel1
        '
        Me.FlatLabel1.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FlatLabel1.ForeColor = System.Drawing.Color.White
        Me.FlatLabel1.Location = New System.Drawing.Point(12, 63)
        Me.FlatLabel1.Name = "FlatLabel1"
        Me.FlatLabel1.Size = New System.Drawing.Size(543, 99)
        Me.FlatLabel1.TabIndex = 4
        Me.FlatLabel1.Text = "FlatLabel1"
        '
        'FlatButton4
        '
        Me.FlatButton4.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton4.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton4.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton4.Location = New System.Drawing.Point(12, 324)
        Me.FlatButton4.Name = "FlatButton4"
        Me.FlatButton4.Rounded = False
        Me.FlatButton4.Size = New System.Drawing.Size(543, 47)
        Me.FlatButton4.TabIndex = 3
        Me.FlatButton4.Text = "FlatButton4"
        Me.FlatButton4.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton3
        '
        Me.FlatButton3.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton3.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton3.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton3.Location = New System.Drawing.Point(12, 271)
        Me.FlatButton3.Name = "FlatButton3"
        Me.FlatButton3.Rounded = False
        Me.FlatButton3.Size = New System.Drawing.Size(543, 47)
        Me.FlatButton3.TabIndex = 2
        Me.FlatButton3.Text = "FlatButton3"
        Me.FlatButton3.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton2
        '
        Me.FlatButton2.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton2.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton2.Location = New System.Drawing.Point(12, 218)
        Me.FlatButton2.Name = "FlatButton2"
        Me.FlatButton2.Rounded = False
        Me.FlatButton2.Size = New System.Drawing.Size(543, 47)
        Me.FlatButton2.TabIndex = 1
        Me.FlatButton2.Text = "FlatButton2"
        Me.FlatButton2.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton1
        '
        Me.FlatButton1.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton1.Location = New System.Drawing.Point(12, 165)
        Me.FlatButton1.Name = "FlatButton1"
        Me.FlatButton1.Rounded = False
        Me.FlatButton1.Size = New System.Drawing.Size(543, 47)
        Me.FlatButton1.TabIndex = 0
        Me.FlatButton1.Text = "FlatButton1"
        Me.FlatButton1.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatButton5
        '
        Me.FlatButton5.BackColor = System.Drawing.Color.Transparent
        Me.FlatButton5.BaseColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(168, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.FlatButton5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FlatButton5.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FlatButton5.Location = New System.Drawing.Point(449, 418)
        Me.FlatButton5.Name = "FlatButton5"
        Me.FlatButton5.Rounded = False
        Me.FlatButton5.Size = New System.Drawing.Size(106, 32)
        Me.FlatButton5.TabIndex = 6
        Me.FlatButton5.Text = "Regresar"
        Me.FlatButton5.TextColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer))
        '
        'FlatLabel2
        '
        Me.FlatLabel2.AutoSize = True
        Me.FlatLabel2.BackColor = System.Drawing.Color.Transparent
        Me.FlatLabel2.Font = New System.Drawing.Font("Segoe UI", 8.0!)
        Me.FlatLabel2.ForeColor = System.Drawing.Color.White
        Me.FlatLabel2.Location = New System.Drawing.Point(9, 437)
        Me.FlatLabel2.Name = "FlatLabel2"
        Me.FlatLabel2.Size = New System.Drawing.Size(29, 13)
        Me.FlatLabel2.TabIndex = 7
        Me.FlatLabel2.Text = "0/10"
        '
        'BGame3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 462)
        Me.Controls.Add(Me.GameSkin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BGame3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BGame3"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.GameSkin.ResumeLayout(False)
        Me.GameSkin.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GameSkin As FormSkin
    Friend WithEvents FlatButton1 As FlatButton
    Friend WithEvents FlatLabel1 As FlatLabel
    Friend WithEvents FlatButton4 As FlatButton
    Friend WithEvents FlatButton3 As FlatButton
    Friend WithEvents FlatButton2 As FlatButton
    Friend WithEvents FlatClose1 As FlatClose
    Friend WithEvents FlatLabel2 As FlatLabel
    Friend WithEvents FlatButton5 As FlatButton
End Class
