﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Apresentacao12
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkList1 = New System.Windows.Forms.CheckedListBox()
        Me.chkList2 = New System.Windows.Forms.CheckedListBox()
        Me.TrataErro = New System.Windows.Forms.ErrorProvider(Me.components)

        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Perguntas.My.Resources.Resources.balao_apresentacao_13
        Me.PictureBox2.Location = New System.Drawing.Point(298, 82)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(333, 151)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Perguntas.My.Resources.Resources.imagem2
        Me.PictureBox1.Location = New System.Drawing.Point(165, 135)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 220)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(301, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(131, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Selecione as preposições:"
        '
        'chkList1
        '
        Me.chkList1.CheckOnClick = True
        Me.chkList1.FormattingEnabled = True
        Me.chkList1.Items.AddRange(New Object() {"Antônio", "veio", "de", "Goiás"})
        Me.chkList1.Location = New System.Drawing.Point(304, 266)
        Me.chkList1.Name = "chkList1"
        Me.chkList1.Size = New System.Drawing.Size(152, 79)
        Me.chkList1.TabIndex = 11
        '
        'chkList2
        '
        Me.chkList2.CheckOnClick = True
        Me.chkList2.FormattingEnabled = True
        Me.chkList2.Items.AddRange(New Object() {"Vitória", "esteve", "com", "André", "ontem"})
        Me.chkList2.Location = New System.Drawing.Point(462, 266)
        Me.chkList2.Name = "chkList2"
        Me.chkList2.Size = New System.Drawing.Size(175, 79)
        Me.chkList2.TabIndex = 13
        '
        'TrataErro
        '
        Me.TrataErro.ContainerControl = Me
        '

        'frm_Apresentacao12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 488)
        Me.BackColor = System.Drawing.Color.White

        Me.Controls.Add(Me.chkList2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkList1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frm_Apresentacao12"
        Me.Text = "Desafio: preposições"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrataErro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkList1 As CheckedListBox
    Friend WithEvents chkList2 As CheckedListBox
    Friend WithEvents TrataErro As ErrorProvider

End Class
