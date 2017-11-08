Public Class frm_apresentacao2
    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_apresentacao3
        frm.Show()
    End Sub

    Private Sub frm_apresentacao2_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao
        frm.Show()
    End Sub
End Class