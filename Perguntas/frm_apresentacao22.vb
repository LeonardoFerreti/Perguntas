Public Class frm_apresentacao22
    Private Sub frm_apresentacao22_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao22.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao22_1
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao22.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao22.mp3"
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao22_2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao22
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao22_2.mp3", b)
        End If
        Me.media2.URL = Application.StartupPath + "\" + "audioApresentacao22_2.mp3"
        Me.media2.Ctlcontrols.stop()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click


        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao21 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        media.Ctlcontrols.stop()
        media2.Ctlcontrols.stop()
        Me.Hide()

        Dim frm As frm_Perguntas_Frases = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Frases Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_Frases
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub


End Class