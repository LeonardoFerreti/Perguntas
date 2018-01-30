Public Class frm_apresentacao5

    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        '     Me.Hide()

        Dim frm As frm_Perguntas_Arrastar = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Arrastar Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_Arrastar
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub frm_apresentacao3_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao4 Then
                form.Show()
            End If
        Next
    End Sub

End Class