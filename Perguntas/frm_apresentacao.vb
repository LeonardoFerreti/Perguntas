
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

    Private Sub frm_apresentacao_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "Apresentacao.mp3") Then
            Dim b() As Byte = My.Resources.Apresentacao
            System.IO.File.WriteAllBytes(Application.StartupPath + "Apresentacao.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "Apresentacao.mp3"
        Me.media.Ctlcontrols.play()
    End Sub
End Class