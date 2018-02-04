Public Class frm_apresentacao13
    Private Sub frm_apresentacao13_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao13.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao13
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao13.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao13.mp3"

    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click


        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Apresentacao12 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        media.Ctlcontrols.stop()

        '     Me.Hide()

        Dim frm As frm_apresentacao14 = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao14 Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_apresentacao14
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub


End Class