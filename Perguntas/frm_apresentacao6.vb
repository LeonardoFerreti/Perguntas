Public Class frm_apresentacao6
    Private Sub frm_Perguntas_Arrastar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_apresentacao7
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_Perguntas_Arrastar
        frm.Show()
    End Sub
End Class