Public Class frm_apresentacao2
    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click
        '      Me.Hide()
        media.Ctlcontrols.stop()

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

    Private Sub frm_apresentacao2_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao2
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao2.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao2.mp3"
        Me.media.Ctlcontrols.play()
    End Sub
End Class