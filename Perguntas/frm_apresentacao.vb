Public Class frm_apresentacao
    Private Sub frm_apresentacao_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()

        Dim frm As frm_apresentacao2 = Nothing
        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao2 Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_apresentacao2
        frm.Show()
    End Sub


End Class