Public Class frm_apresentacao6
    Private Sub frm_apresentacao6_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao6.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao6
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao6.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao6.mp3"
        Me.media.Ctlcontrols.play()

        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao6_2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao6_2
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao6_2.mp3", b)
        End If
        Me.media2.URL = Application.StartupPath + "\" + "audioApresentacao6_2.mp3"
        Me.media2.Ctlcontrols.stop()

    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        '  Me.Hide()

        Dim frm As frm_apresentacao7 = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao7 Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_apresentacao7
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Arrastar Then
                form.Show()
            End If
        Next
    End Sub

End Class