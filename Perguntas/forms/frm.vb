Public Class frm

    Public Event _btn_avancar_click(sender As Object, e As EventArgs)
    Public Event _btn_voltar_click(sender As Object, e As EventArgs)

    Private _titulo As String
    Public Property TITULO() As String
        Get
            Return _titulo
        End Get
        Set(ByVal value As String)
            _titulo = value
            Label1.Text = value
        End Set
    End Property

    Private _btn_avancar_text As String = "AVANÇAR"
    Public Property BTN_AVANCAR_TEXT() As String
        Get
            Return _btn_avancar_text
        End Get
        Set(ByVal value As String)
            _btn_avancar_text = value
            Me.Controle_navegacao1.btn_avancar.Text = value
        End Set
    End Property

    Private _btn_voltar_visible As Boolean = True
    Public Property BTN_VOLTAR_VISIBLE() As Boolean
        Get
            Return _btn_voltar_visible
        End Get
        Set(ByVal value As Boolean)
            _btn_voltar_visible = value
            Me.Controle_navegacao1.btn_voltar.Visible = value
        End Set
    End Property

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub frm_base_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Process.GetCurrentProcess().Kill()
        Else
            e.Cancel = True
        End If
    End Sub

    Private allowCoolMove As Boolean = False
    Private myCoolPoint As New Point


    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                                         Handles Me.MouseDown, barra_titulo.MouseDown, control_barra.MouseDown
        allowCoolMove = True '// enable move.
        myCoolPoint = New Point(Cursor.Position.X - Me.Location.X, Cursor.Position.Y - Me.Location.Y) '// get coordinates.
    End Sub


    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                                         Handles Me.MouseMove, barra_titulo.MouseMove, control_barra.MouseMove
        If allowCoolMove = True Then
            Me.Location = New Point(Cursor.Position.X - myCoolPoint.X, Cursor.Position.Y - myCoolPoint.Y) '// set coordinates.
        End If
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) _
                                         Handles Me.MouseUp, barra_titulo.MouseUp, control_barra.MouseUp
        allowCoolMove = False '// disable move.
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.Label1.Text = Me.Text
    End Sub

    Private Sub Controle_navegacao1__btn_avancar_click(sender As Object, e As EventArgs) Handles Controle_navegacao1._btn_avancar_click
        RaiseEvent _btn_avancar_click(sender, e)
    End Sub

    Private Sub Controle_navegacao1__btn_voltar_click(sender As Object, e As EventArgs) Handles Controle_navegacao1._btn_voltar_click
        RaiseEvent _btn_voltar_click(sender, e)
    End Sub
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using brush As New SolidBrush(BackColor)
            e.Graphics.FillRectangle(brush, ClientRectangle)
            e.Graphics.DrawRectangle(New Pen(Color.Black), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1)
        End Using
    End Sub
End Class