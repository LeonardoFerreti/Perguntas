<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apresentacao20
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
        Me.TextBox2 = New Perguntas.usr_textbox()
        Me.TextBox3 = New Perguntas.usr_textbox()
        Me.TextBox4 = New Perguntas.usr_textbox()
        Me.TextBox5 = New Perguntas.usr_textbox()
        Me.TrataErro = New System.Windows.Forms.ErrorProvider(Me.components)

        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Perguntas.My.Resources.Resources.balao_apresentacao_22
        Me.PictureBox2.Location = New System.Drawing.Point(185, 84)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(349, 152)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perguntas.My.Resources.Resources.imagem2
        Me.PictureBox1.Location = New System.Drawing.Point(540, 144)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(188, 256)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 22)
        Me.TextBox1.somenteLeitura = False
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Tag = "a"
        Me.TextBox1.Texto = ""
        Me.TextBox1.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox1.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(223, 287)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 22)
        Me.TextBox2.somenteLeitura = False
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Tag = "casa"
        Me.TextBox2.Texto = ""
        Me.TextBox2.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox2.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.ForeColor = System.Drawing.Color.Black
        Me.TextBox3.Location = New System.Drawing.Point(288, 317)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 22)
        Me.TextBox3.somenteLeitura = False
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Tag = "minha"
        Me.TextBox3.Texto = ""
        Me.TextBox3.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox3.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.ForeColor = System.Drawing.Color.Black
        Me.TextBox4.Location = New System.Drawing.Point(194, 347)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(95, 22)
        Me.TextBox4.somenteLeitura = False
        Me.TextBox4.TabIndex = 5
        Me.TextBox4.Tag = "foi"
        Me.TextBox4.Texto = ""
        Me.TextBox4.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox4.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(309, 347)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(93, 22)
        Me.TextBox5.somenteLeitura = False
        Me.TextBox5.TabIndex = 6
        Me.TextBox5.Tag = "pintada"
        Me.TextBox5.Texto = ""
        Me.TextBox5.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox5.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'TrataErro
        '
        Me.TrataErro.ContainerControl = Me
        '

        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White

        Me.Label1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(131, 258)

        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 19)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Artigo:"
        '
        'MaterialLabel1
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White

        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(131, 289)

        Me.Label2.Name = "MaterialLabel1"
        Me.Label2.Size = New System.Drawing.Size(89, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Substantivo:"
        '
        'MaterialLabel2
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White

        Me.Label3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(131, 317)

        Me.Label3.Name = "MaterialLabel2"
        Me.Label3.Size = New System.Drawing.Size(155, 19)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Pronome possessivo:"
        '
        'MaterialLabel3
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White

        Me.Label4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(131, 349)

        Me.Label4.Name = "MaterialLabel3"
        Me.Label4.Size = New System.Drawing.Size(61, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Verbos:"
        '
        'MaterialLabel4
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White

        Me.Label5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(290, 349)

        Me.Label5.Name = "MaterialLabel4"
        Me.Label5.Size = New System.Drawing.Size(17, 19)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "e"
        '
        'frm_apresentacao20
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 488)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.BackColor = System.Drawing.Color.White

        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_apresentacao20"
        Me.Text = "Desafio: classe gramatical"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TrataErro As ErrorProvider
    Friend WithEvents TextBox1 As usr_textbox
    Friend WithEvents TextBox2 As usr_textbox
    Friend WithEvents TextBox3 As usr_textbox
    Friend WithEvents TextBox4 As usr_textbox
    Friend WithEvents TextBox5 As usr_textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
