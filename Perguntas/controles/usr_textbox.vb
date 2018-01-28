Public Class usr_textbox

    Private _backColor As Drawing.Color = Color.White
    Public Property TEXTO_BACKCOLOR() As Drawing.Color
        Get
            Return _backColor
        End Get
        Set(ByVal value As Drawing.Color)
            _backColor = value
            txt.BackColor = value
        End Set
    End Property

    Private _foreColor As Drawing.Color = Color.Black
    Public Property TEXTO_FORECOLOR() As Drawing.Color
        Get
            Return _foreColor
        End Get
        Set(ByVal value As Drawing.Color)
            _foreColor = value
            txt.ForeColor = value
        End Set
    End Property

    Private _readonly As Boolean = False
    Public Property somenteLeitura As Boolean
        Get
            Return _readonly
        End Get
        Set(ByVal value As Boolean)
            _readonly = value
            txt.ReadOnly = value
        End Set
    End Property

    Private _text_align As ContentAlignment
    Public Property TextAlign() As ContentAlignment
        Get
            Return _text_align
        End Get
        Set(ByVal value As ContentAlignment)
            _text_align = value
            txt.TextAlign = value
        End Set
    End Property


    Public Property Texto() As String
        Get
            Return txt.Text
        End Get
        Set(value As String)
            txt.Text = value
        End Set
    End Property

    Private Sub usr_textbox_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus, txt.GotFocus
        Me.BackColor = Color.FromArgb(243, 244, 182)
    End Sub

    Private Sub usr_textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, txt.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub usr_textbox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus, txt.LostFocus
        Me.BackColor = Color.White
    End Sub

End Class
