Public Class frm_apresentacao4

    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If validaDados() Then
            '       Me.Hide()
            media.Ctlcontrols.stop()

            Dim frm As frm_apresentacao5 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao5 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao5
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If
    End Sub

    Private Sub frm_apresentacao3_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao3 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub chkList_Click(sender As Object, e As EventArgs) Handles chkList.Click
        TrataErro.SetError(Label1, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        If chkList.CheckedItems.Count = 0 Then
            TrataErro.SetError(Label1, "Selecione uma palavra!")
            validaDados = False
        ElseIf chkList.CheckedItems.Count <> 2 Then
            TrataErro.SetError(Label1, "Selecione as palavras corretas!")
            validaDados = False
        Else
            If Not (chkList.CheckedItems(0).ToString.Equals("Os") AndAlso
               chkList.CheckedItems(1).ToString.Equals("de")) Then
                TrataErro.SetError(Label1, "Selecione as palavras corretas!")
                validaDados = False
            End If
        End If
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
        End If

        Return validaDados
    End Function

    Private Sub frm_apresentacao4_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao4.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao4
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao4.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao4.mp3"
        Me.media.Ctlcontrols.play()
    End Sub

End Class