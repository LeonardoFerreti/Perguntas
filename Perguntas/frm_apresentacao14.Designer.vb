<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_apresentacao14
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_apresentacao14))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New Perguntas.usr_textbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TextBox2 = New Perguntas.usr_textbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCombinacao = New System.Windows.Forms.Label()
        Me.lblContracao = New System.Windows.Forms.Label()
        Me.TrataErro = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.media = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.media, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Perguntas.My.Resources.Resources.balao_apresentacao_15
        Me.PictureBox2.Location = New System.Drawing.Point(295, 82)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(376, 154)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perguntas.My.Resources.Resources.imagem2
        Me.PictureBox1.Location = New System.Drawing.Point(162, 189)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.White
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 104.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(306, 309)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(260, 100)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(109, 53)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(147, 43)
        Me.Panel3.TabIndex = 1
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.ForeColor = System.Drawing.Color.Black
        Me.TextBox5.Location = New System.Drawing.Point(82, 13)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(56, 22)
        Me.TextBox5.somenteLeitura = False
        Me.TextBox5.TabIndex = 5
        Me.TextBox5.Tag = "dos"
        Me.TextBox5.Texto = ""
        Me.TextBox5.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox5.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "de + os ="
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 49)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contração"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(109, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(147, 42)
        Me.Panel2.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.ForeColor = System.Drawing.Color.Black
        Me.TextBox2.Location = New System.Drawing.Point(82, 12)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(56, 22)
        Me.TextBox2.somenteLeitura = False
        Me.TextBox2.TabIndex = 1
        Me.TextBox2.Tag = "aos"
        Me.TextBox2.Texto = ""
        Me.TextBox2.TEXTO_BACKCOLOR = System.Drawing.Color.White
        Me.TextBox2.TEXTO_FORECOLOR = System.Drawing.Color.Black
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 21)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "a + os ="
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Combinação"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCombinacao
        '
        Me.lblCombinacao.AutoSize = True
        Me.lblCombinacao.Location = New System.Drawing.Point(614, 301)
        Me.lblCombinacao.Name = "lblCombinacao"
        Me.lblCombinacao.Size = New System.Drawing.Size(0, 13)
        Me.lblCombinacao.TabIndex = 14
        '
        'lblContracao
        '
        Me.lblContracao.AutoSize = True
        Me.lblContracao.Location = New System.Drawing.Point(615, 347)
        Me.lblContracao.Name = "lblContracao"
        Me.lblContracao.Size = New System.Drawing.Size(0, 13)
        Me.lblContracao.TabIndex = 15
        '
        'TrataErro
        '
        Me.TrataErro.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(302, 287)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(301, 20)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Realize a combinação e a contração abaixo:"
        '
        'media
        '
        Me.media.Enabled = True
        Me.media.Location = New System.Drawing.Point(295, 237)
        Me.media.Name = "media"
        Me.media.OcxState = CType(resources.GetObject("media.OcxState"), System.Windows.Forms.AxHost.State)
        Me.media.Size = New System.Drawing.Size(376, 45)
        Me.media.TabIndex = 37
        Me.media.TabStop = False
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(4, 1)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 48)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Combinação"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_apresentacao14
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(796, 488)
        Me.Controls.Add(Me.media)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblContracao)
        Me.Controls.Add(Me.lblCombinacao)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frm_apresentacao14"
        Me.Text = "Desafio: combinações e contrações"
        Me.Controls.SetChildIndex(Me.PictureBox1, 0)
        Me.Controls.SetChildIndex(Me.PictureBox2, 0)
        Me.Controls.SetChildIndex(Me.TableLayoutPanel1, 0)
        Me.Controls.SetChildIndex(Me.lblCombinacao, 0)
        Me.Controls.SetChildIndex(Me.lblContracao, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.media, 0)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.media, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCombinacao As Label
    Friend WithEvents lblContracao As Label
    Friend WithEvents TrataErro As ErrorProvider
    Friend WithEvents TextBox5 As usr_textbox
    Friend WithEvents TextBox2 As usr_textbox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents media As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents Label6 As Label
End Class
