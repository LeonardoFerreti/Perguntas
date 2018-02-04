Public Class frm_apresentacao9
    Private Sub frm_apresentacao9_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao9.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao9
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao9.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao9.mp3"
        Me.media.Ctlcontrols.play()

    End Sub

    Private Sub frm_apresentacao9_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao8 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If ValidaDados() Then
            media.Ctlcontrols.stop()

            '      Me.Hide()

            Dim frm As frm_apresentacao10 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao10 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao10
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If
    End Sub

    Private Function ValidaDados() As Boolean
        ValidaDados = True
        If Not TextBox1.Texto.ToLower.Equals(TextBox1.Tag.ToString) Then
            ValidaDados = False
            TrataErro.SetError(TextBox1, "Escreva a palavra corretamente.")
        End If
        If Not ValidaDados Then
            System.Media.SystemSounds.Exclamation.Play()
        End If

        Return ValidaDados
    End Function


End Class