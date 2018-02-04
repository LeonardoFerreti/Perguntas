Public Class frm_apresentacao5

    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        '     Me.Hide()
        media.Ctlcontrols.stop()
        media2.Ctlcontrols.stop()

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

    Private Sub frm_apresentacao5_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao5.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao5
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao5.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao5.mp3"
        Me.media.Ctlcontrols.play()
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao5_2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao5_2
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao5_2.mp3", b)
        End If
        Me.media2.URL = Application.StartupPath + "\" + "audioApresentacao5_2.mp3"
        Me.media2.Ctlcontrols.stop()

    End Sub
End Class