Public Class controle_navegacao
    Event _btn_avancar_click(sender As Object, e As EventArgs)
    Event _btn_voltar_click(sender As Object, e As EventArgs)


    Private _btn_avancar_text As String = "AVANÇAR"
    Public Property BTN_AVANCAR_TEXT() As String
        Get
            Return _btn_avancar_text
        End Get
        Set(ByVal value As String)
            _btn_avancar_text = value
        End Set
    End Property

    Private _voltar_visible As Boolean = True
    Public Property VOLTAR_VISIBLE() As Boolean
        Get
            Return _voltar_visible
        End Get
        Set(ByVal value As Boolean)
            _voltar_visible = value
        End Set
    End Property


    Private Sub btn_avancar_Click_1(sender As Object, e As EventArgs) Handles btn_avancar.Click
        RaiseEvent _btn_avancar_click(sender, e)
    End Sub

    Private Sub btn_voltar_Click_1(sender As Object, e As EventArgs) Handles btn_voltar.Click
        RaiseEvent _btn_voltar_click(sender, e)
    End Sub
End Class
