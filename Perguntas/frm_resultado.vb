Public Class frm_resultado

    Private Sub frm_resultado_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Application.Exit()
    End Sub

    Private Sub frm_resultado_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.btn_avancar.Text = "Concluir"
    End Sub

End Class