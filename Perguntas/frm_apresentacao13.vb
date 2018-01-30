Public Class frm_apresentacao13


    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click


        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Apresentacao12 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        '     Me.Hide()

        Dim frm As frm_apresentacao14 = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao14 Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_apresentacao14
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub


End Class