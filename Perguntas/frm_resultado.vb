Public Class frm_resultado

    Private Sub frm_resultado_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click
        Application.Exit()
    End Sub

    Private Sub frm_resultado_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.BTN_AVANCAR_TEXT = "CONCLUIR"

        Dim valor_total As Integer = PONTUACAO_TELA_ALTERAR_VERBOS +
        PONTUACAO_TELA_ARRASTAR_PALAVRAS +
        PONTUACAO_TELA_ARRASTAR_COMPLETAR +
        PONTUACAO_TELA_COMBINACOES_CONTRACOES +
        PONTUACAO_TELA_CONTRACAO_OBLIQUO +
        PONTUACAO_TELA_FRASES +
        PONTUACAO_TELA_MUSICA +
        PONTUACAO_TELA_REESCREVER_FRASES +
        PONTUACAO_TELA_RESPONDER_PERGUNTAS

        If valor_total > 95 Then
            lbl_resultado.Text = String.Format("{0} pontos: Excelente!", valor_total)
        ElseIf valor_total > 50 Then
            lbl_resultado.Text = String.Format("{0} pontos: Satisfatório.", valor_total)
        Else
            lbl_resultado.Text = String.Format("{0} pontos: Insatisfatório...", valor_total)
        End If

    End Sub

End Class