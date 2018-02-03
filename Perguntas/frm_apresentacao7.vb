Public Class frm_apresentacao7
    Private Sub frm_apresentacao7_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click

        '   Me.Hide()
        Me.Cursor = Cursors.AppStarting

        Dim frm As frm_Perguntas_Arrastar_Completar = Nothing
        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_Perguntas_Arrastar_Completar Then
                frm = form
            End If
        Next

        If IsNothing(frm) Then frm = New frm_Perguntas_Arrastar_Completar
        Me.Hide()
        Me.Cursor = Cursors.Default
        frm.Show()
        frm.Focus()
    End Sub

    Private Sub frm_apresentacao7_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao6 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_apresentacao7_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao7.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao7
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao7.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao7.mp3"
        Me.media.Ctlcontrols.play()

        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao7_2.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao7_2
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao7_2.mp3", b)
        End If
        Me.media2.URL = Application.StartupPath + "\" + "audioApresentacao7_2.mp3"
        Me.media2.Ctlcontrols.stop()
    End Sub
End Class