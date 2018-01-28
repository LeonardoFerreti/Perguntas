<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_base
    Inherits MetroFramework.Forms.MetroForm

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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_avancar = New MetroFramework.Controls.MetroButton()
        Me.btn_voltar = New MetroFramework.Controls.MetroButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btn_avancar)
        Me.Panel1.Controls.Add(Me.btn_voltar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(20, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(539, 38)
        Me.Panel1.TabIndex = 0
        '
        'btn_avancar
        '
        Me.btn_avancar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_avancar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btn_avancar.Location = New System.Drawing.Point(423, 0)
        Me.btn_avancar.Name = "btn_avancar"
        Me.btn_avancar.Size = New System.Drawing.Size(116, 38)
        Me.btn_avancar.TabIndex = 1
        Me.btn_avancar.Text = "Avançar"
        Me.btn_avancar.UseSelectable = True
        '
        'btn_voltar
        '
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Dock = System.Windows.Forms.DockStyle.Left
        Me.btn_voltar.Location = New System.Drawing.Point(0, 0)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(125, 38)
        Me.btn_voltar.TabIndex = 2
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.UseSelectable = True
        '
        'frm_base
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 394)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_base"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_avancar As MetroFramework.Controls.MetroButton
    Friend WithEvents btn_voltar As MetroFramework.Controls.MetroButton
End Class
