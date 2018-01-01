Public Class frm_apresentacao7
    Private Sub frm_apresentacao7_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_Perguntas_Arrastar_Completar
        frm.Show()
    End Sub

    Private Sub frm_apresentacao7_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Hide()
        Dim frm As New frm_apresentacao6
        frm.Show()
    End Sub
End Class