Public Class usr_textbox
    Event _textbox_keyDown(sender As Object, e As KeyEventArgs)


    Private _tabulacao_automatica As Boolean = True
    Public Property TABULACAO_AUTOMATICA() As Boolean
        Get
            Return _tabulacao_automatica
        End Get
        Set(ByVal value As Boolean)
            _tabulacao_automatica = value
        End Set
    End Property

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
        txt.BackColor = Color.FromArgb(243, 244, 182)
    End Sub

    Private Sub usr_textbox_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown, txt.KeyDown
        If _tabulacao_automatica Then
            If e.KeyCode = Keys.Enter Then
                SendKeys.Send("{TAB}")
            End If
        End If
        RaiseEvent _textbox_keyDown(sender, e)
    End Sub

    Private Sub usr_textbox_LostFocus(sender As Object, e As EventArgs) Handles Me.LostFocus, txt.LostFocus
        Me.BackColor = Color.White
        txt.BackColor = Color.White
    End Sub

End Class
