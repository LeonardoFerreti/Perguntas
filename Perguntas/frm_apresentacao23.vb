Public Class frm_apresentacao23
    Private Sub frm_apresentacao23_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao23.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao23
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao23.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao23.mp3"
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao23_2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao23_2
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao23_2.mp3", b)
        End If
        Me.media2.URL = Application.StartupPath + "\" + "audioApresentacao23_2.mp3"
        Me.media2.Ctlcontrols.stop()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Frases Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        ' Me.Hide()
        media.Ctlcontrols.stop()
        media2.Ctlcontrols.stop()
        Dim frm As frm_Perguntas_Reescrever_Frases = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Reescrever_Frases Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_Reescrever_Frases
        Me.Hide()
        frm.Show()
        frm.Focus()
    End Sub


End Class