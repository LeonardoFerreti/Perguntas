<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm
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
        Me.barra_titulo = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.control_barra = New System.Windows.Forms.TableLayoutPanel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Controle_navegacao1 = New Perguntas.controle_navegacao()
        Me.barra_titulo.SuspendLayout()
        Me.control_barra.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'barra_titulo
        '
        Me.barra_titulo.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.barra_titulo.Controls.Add(Me.Label1)
        Me.barra_titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.barra_titulo.Location = New System.Drawing.Point(0, 25)
        Me.barra_titulo.Name = "barra_titulo"
        Me.barra_titulo.Size = New System.Drawing.Size(713, 36)
        Me.barra_titulo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(77, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'control_barra
        '
        Me.control_barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(56, Byte), Integer))
        Me.control_barra.ColumnCount = 2
        Me.control_barra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.control_barra.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.control_barra.Controls.Add(Me.PictureBox1, 1, 0)
        Me.control_barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.control_barra.Location = New System.Drawing.Point(0, 0)
        Me.control_barra.Name = "control_barra"
        Me.control_barra.RowCount = 1
        Me.control_barra.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.control_barra.Size = New System.Drawing.Size(713, 25)
        Me.control_barra.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Perguntas.My.Resources.Resources.img_fechar
        Me.PictureBox1.Location = New System.Drawing.Point(692, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(18, 19)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Controle_navegacao1
        '
        Me.Controle_navegacao1.BackColor = System.Drawing.Color.Transparent
        Me.Controle_navegacao1.BTN_AVANCAR_TEXT = "AVANÇAR"
        Me.Controle_navegacao1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Controle_navegacao1.Location = New System.Drawing.Point(0, 422)
        Me.Controle_navegacao1.Name = "Controle_navegacao1"
        Me.Controle_navegacao1.Size = New System.Drawing.Size(713, 43)
        Me.Controle_navegacao1.TabIndex = 5
        Me.Controle_navegacao1.VOLTAR_VISIBLE = True
        '
        'frm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(713, 465)
        Me.ControlBox = False
        Me.Controls.Add(Me.Controle_navegacao1)
        Me.Controls.Add(Me.barra_titulo)
        Me.Controls.Add(Me.control_barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.barra_titulo.ResumeLayout(False)
        Me.barra_titulo.PerformLayout()
        Me.control_barra.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents barra_titulo As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents control_barra As TableLayoutPanel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Controle_navegacao1 As controle_navegacao
End Class
