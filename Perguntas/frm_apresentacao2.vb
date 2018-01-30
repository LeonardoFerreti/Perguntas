Public Class frm_apresentacao2
    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click
        '      Me.Hide()

        Dim frm As frm_apresentacao3 = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao3 Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_apresentacao3
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub frm_apresentacao2_btn_voltar_click(sender As Object, e As EventArgs) Handles Me._btn_voltar_click
        Me.Hide()
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao Then
                form.Show()
            End If
        Next

    End Sub

End Class