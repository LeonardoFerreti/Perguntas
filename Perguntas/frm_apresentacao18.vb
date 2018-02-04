Public Class frm_apresentacao18
    Private Sub frm_apresentacao18_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao18.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao18
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao18.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao18.mp3"
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao18_2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao18_2
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao18_2.mp3", b)
        End If
        Me.media2.URL = Application.StartupPath + "\" + "audioApresentacao18_2.mp3"
        Me.media2.Ctlcontrols.stop()

    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao17 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        media.Ctlcontrols.stop()
        media2.Ctlcontrols.stop()
        ' Me.Hide()

        Dim frm As frm_Perguntas_alteracao_verbo = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_alteracao_verbo Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_alteracao_verbo
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub


End Class