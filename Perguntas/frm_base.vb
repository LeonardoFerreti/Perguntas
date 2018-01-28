
Public Class frm_base

    Public Event btn_avancar_click(sender As Object, e As EventArgs)
    Public Event btn_voltar_click(sender As Object, e As EventArgs)

    Private _mostra_botao_voltar As Boolean = True
    Public Property MOSTRA_BOTAO_VOLTAR() As Boolean
        Get
            Return _mostra_botao_voltar
        End Get
        Set(ByVal value As Boolean)
            _mostra_botao_voltar = value

            btn_voltar.Visible = value
        End Set
    End Property

    Private _habilita_voltar As Boolean = True
    Public Property HABILITA_VOLTAR() As Boolean
        Get
            Return _habilita_voltar
        End Get
        Set(ByVal value As Boolean)
            _habilita_voltar = value

            btn_voltar.Enabled = value
        End Set
    End Property

    Private _habilita_avancar As Boolean = True
    Public Property HABILITA_AVANCAR() As Boolean
        Get
            Return _habilita_avancar
        End Get
        Set(ByVal value As Boolean)
            _habilita_avancar = value

            btn_avancar.Enabled = value
        End Set
    End Property

    Private Sub btnAvancar_Click(sender As Object, e As EventArgs) Handles btn_avancar.Click
        RaiseEvent btn_avancar_click(sender, e)
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        RaiseEvent btn_voltar_click(sender, e)
    End Sub

    Private Sub frm_base_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Process.GetCurrentProcess().Kill()
        Else
            e.Cancel = True
        End If
    End Sub

End Class
