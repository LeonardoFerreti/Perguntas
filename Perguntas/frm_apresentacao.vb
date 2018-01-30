
Public Class frm_apresentacao
    Private Sub frm_apresentacao_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click

        Dim frm As frm_apresentacao2 = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao2 Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_apresentacao2
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub

End Class