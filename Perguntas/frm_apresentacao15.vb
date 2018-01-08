Public Class frm_apresentacao15
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click

        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao14 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click

        Me.Hide()

        Dim frm As frm_Perguntas_Combinacoes_Contracoes = Nothing
        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Combinacoes_Contracoes Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_Combinacoes_Contracoes
        frm.Show()
    End Sub
End Class