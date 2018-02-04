<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usr_textbox
    Inherits UserControl

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
        Me.txt = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'txt
        '
        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt.ForeColor = System.Drawing.Color.Black
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(112, 22)
        Me.txt.TabIndex = 0
        '
        'usr_textbox
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txt)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "usr_textbox"
        Me.Size = New System.Drawing.Size(112, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt As TextBox
End Class
