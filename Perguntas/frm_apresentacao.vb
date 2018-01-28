Public Class frm_apresentacao
    Private Sub frm_apresentacao_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click


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

    Private Sub frm_apresentacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "video_sistema_perguntas.mp4") Then
            Dim b() As Byte = My.Resources.beijo_me_liga
            System.IO.File.WriteAllBytes(Application.StartupPath + "video_sistema_perguntas.mp4", b)
        End If

    End Sub
End Class