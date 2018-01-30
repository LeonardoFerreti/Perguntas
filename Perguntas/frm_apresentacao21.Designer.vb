<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apresentacao21
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New Perguntas.usr_textbox()
        Me.TrataErro = New System.Windows.Forms.ErrorProvider(Me.components)

        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Perguntas.My.Resources.Resources.balao5
        Me.PictureBox2.Location = New System.Drawing.Point(172, 123)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(304, 94)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perguntas.My.Resources.Resources.imagem1
        Me.PictureBox1.Location = New System.Drawing.Point(495, 179)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(148, 155)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(172, 312)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 22)
        Me.TextBox1.somenteLeitura = False
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Tag = "a minha casa foi pintada"
        Me.TextBox1.Texto = ""
        Me.TextBox1.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox1.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'TrataErro
        '
        Me.TrataErro.ContainerControl = Me
        '
        'btn_avancar
        '
        ' Me.btn_avancar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '  Me.btn_avancar.AutoSize = True

        ' Me.btn_avancar.Location = New System.Drawing.Point(702, 444)
        ' Me.btn_avancar.Name = "btn_avancar"

        '  Me.btn_avancar.Size = New System.Drawing.Size(85, 36)
        '   Me.btn_avancar.TabIndex = 25
        '  Me.btn_avancar.Text = "Avançar"

        '
        'btn_voltar
        '
        'Me.btn_voltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        'Me.btn_voltar.AutoSize = True

        'Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand

        'Me.btn_voltar.Location = New System.Drawing.Point(9, 444)

        'Me.btn_voltar.Name = "btn_voltar"

        'Me.btn_voltar.Size = New System.Drawing.Size(73, 36)
        'Me.btn_voltar.TabIndex = 24
        'Me.btn_voltar.Text = "Voltar"

        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.White

        Me.label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.label1.Location = New System.Drawing.Point(168, 291)

        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(164, 19)
        Me.label1.TabIndex = 28
        Me.label1.Text = "Escreva a frase abaixo:"
        '
        'frm_apresentacao21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 488)
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.label1)
        'Me.Controls.Add(Me.btn_avancar)
        'Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_apresentacao21"
        Me.Text = "Desafio: formar frase"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox1 As usr_textbox
    Friend WithEvents TrataErro As ErrorProvider
    'Friend WithEvents btn_avancar As System.Windows.Forms.Label
    ' Friend WithEvents btn_voltar As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
End Class
