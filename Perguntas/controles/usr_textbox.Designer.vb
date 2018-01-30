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
        Me.txt = New TextBox()
        Me.SuspendLayout()
        '
        'txt
        '
        '
        '
        '

        Me.txt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txt.ForeColor = System.Drawing.Color.Black
        Me.txt.Lines = New String(-1) {}
        Me.txt.Location = New System.Drawing.Point(0, 0)
        Me.txt.MaxLength = 32767
        Me.txt.Name = "txt"
        Me.txt.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txt.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txt.SelectedText = ""
        Me.txt.SelectionLength = 0
        Me.txt.SelectionStart = 0
        Me.txt.ShortcutsEnabled = True
        Me.txt.Size = New System.Drawing.Size(112, 24)
        Me.txt.TabIndex = 0


        '
        'usr_textbox
        '
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.txt)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "usr_textbox"
        Me.Size = New System.Drawing.Size(112, 24)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents txt As TextBox
End Class
