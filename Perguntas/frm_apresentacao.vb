Public Class frm_apresentacao
    Private Sub frm_apresentacao_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_apresentacao2
        frm.Show()

    End Sub

    Private Sub frm_apresentacao_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click

    End Sub
End Class