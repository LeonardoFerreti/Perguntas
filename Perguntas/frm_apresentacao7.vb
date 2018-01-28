Public Class frm_apresentacao7
    Private Sub frm_apresentacao7_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click

        '   Me.Hide()
        Me.Cursor = Cursors.AppStarting

        Dim frm As frm_Perguntas_Arrastar_Completar = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Arrastar_Completar Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_Arrastar_Completar
        Me.Hide()
        Me.Cursor = Cursors.Default
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub frm_apresentacao7_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao6 Then
                form.Show()
            End If
        Next
    End Sub

End Class