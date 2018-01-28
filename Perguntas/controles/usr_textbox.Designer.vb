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
        Me.txt = New MetroFramework.Controls.MetroTextBox()
        Me.SuspendLayout()
        '
        'txt
        '
        '
        '
        '
        Me.txt.CustomButton.Image = Nothing
        Me.txt.CustomButton.Location = New System.Drawing.Point(90, 2)
        Me.txt.CustomButton.Name = ""
        Me.txt.CustomButton.Size = New System.Drawing.Size(19, 19)
        Me.txt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txt.CustomButton.TabIndex = 1
        Me.txt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txt.CustomButton.UseSelectable = True
        Me.txt.CustomButton.UseVisualStyleBackColor = False
        Me.txt.CustomButton.Visible = False
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
        Me.txt.Theme = MetroFramework.MetroThemeStyle.Dark
        Me.txt.UseCustomBackColor = True
        Me.txt.UseCustomForeColor = True
        Me.txt.UseSelectable = True
        Me.txt.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txt.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
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

    Friend WithEvents txt As MetroTextBox
End Class
