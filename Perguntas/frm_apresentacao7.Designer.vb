<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apresentacao7
     Inherits frm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_apresentacao7))
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.media = New AxWMPLib.AxWindowsMediaPlayer()
        Me.media2 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.media, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.media2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Perguntas.My.Resources.Resources.balao9
        Me.PictureBox4.Location = New System.Drawing.Point(569, 199)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(185, 107)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Perguntas.My.Resources.Resources.balao8
        Me.PictureBox2.Location = New System.Drawing.Point(185, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(261, 107)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perguntas.My.Resources.Resources.imagem1
        Me.PictureBox1.Location = New System.Drawing.Point(46, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Perguntas.My.Resources.Resources.imagem3
        Me.PictureBox3.Location = New System.Drawing.Point(433, 199)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(130, 212)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 10
        Me.PictureBox3.TabStop = False
        '
        'media
        '
        Me.media.Enabled = True
        Me.media.Location = New System.Drawing.Point(174, 199)
        Me.media.Name = "media"
        Me.media.OcxState = CType(resources.GetObject("media.OcxState"), System.Windows.Forms.AxHost.State)
        Me.media.Size = New System.Drawing.Size(272, 45)
        Me.media.TabIndex = 37
        Me.media.TabStop = False
        '
        'media2
        '
        Me.media2.Enabled = True
        Me.media2.Location = New System.Drawing.Point(559, 303)
        Me.media2.Name = "media2"
        Me.media2.OcxState = CType(resources.GetObject("media2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.media2.Size = New System.Drawing.Size(213, 45)
        Me.media2.TabIndex = 38
        Me.media2.TabStop = False
        '
        'frm_apresentacao7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 488)
        Me.Controls.Add(Me.media2)
        Me.Controls.Add(Me.media)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_apresentacao7"
        Me.Text = "Desafio: formar palavras"
        Me.Controls.SetChildIndex(Me.PictureBox4, 0)
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.PictureBox3, 0)
        Me.Controls.SetChildIndex(Me.media, 0)
        Me.Controls.SetChildIndex(Me.media2, 0)
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.media, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.media2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents media As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents media2 As AxWMPLib.AxWindowsMediaPlayer
End Class
