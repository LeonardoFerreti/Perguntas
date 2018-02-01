<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controle_navegacao
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.btn_avancar = New System.Windows.Forms.Button()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_avancar
        '
        Me.btn_avancar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_avancar.AutoSize = True
        Me.btn_avancar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_avancar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_avancar.FlatAppearance.BorderSize = 0
        Me.btn_avancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_avancar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_avancar.ForeColor = System.Drawing.Color.White
        Me.btn_avancar.Location = New System.Drawing.Point(256, 3)
        Me.btn_avancar.Name = "btn_avancar"
        Me.btn_avancar.Size = New System.Drawing.Size(95, 37)
        Me.btn_avancar.TabIndex = 0
        Me.btn_avancar.Text = "AVANÇAR"
        Me.btn_avancar.UseVisualStyleBackColor = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_voltar.AutoSize = True
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.FlatAppearance.BorderSize = 0
        Me.btn_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_voltar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_voltar.ForeColor = System.Drawing.Color.White
        Me.btn_voltar.Location = New System.Drawing.Point(3, 3)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(90, 37)
        Me.btn_voltar.TabIndex = 1
        Me.btn_voltar.Text = "VOLTAR"
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'controle_navegacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.btn_avancar)
        Me.Controls.Add(Me.btn_voltar)
        Me.Name = "controle_navegacao"
        Me.Size = New System.Drawing.Size(354, 43)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_avancar As Button
    Friend WithEvents btn_voltar As Button
End Class
