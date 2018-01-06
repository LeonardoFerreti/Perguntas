Public Class frm_apresentacao15
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao14
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        'Dim frm As New frm_apresentacao16
        Dim frm As New frm_Perguntas_Combinacoes_Contracoes
        frm.Show()
    End Sub
End Class