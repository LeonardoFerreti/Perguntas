Public Class frm_Apresentacao12
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao11
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_apresentacao13
        frm.Show()
    End Sub
End Class