Public Class frm_apresentacao3
    Private Sub chkList_Click(sender As Object, e As EventArgs) Handles chkList.Click
        TrataErro.SetError(Label1, String.Empty)
    End Sub

    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If validaDados() Then

            '  Me.Hide()

            Dim frm As frm_apresentacao4 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao4 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao4
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If

    End Sub

    Private Sub frm_apresentacao3_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao2 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_apresentacao3_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "audioApresentacao3.mp3") Then
            Dim b() As Byte = My.Resources.audioApresentacao3
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "audioApresentacao3.mp3", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "audioApresentacao3.mp3"

    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        If chkList.CheckedItems.Count = 0 Then
            TrataErro.SetError(Label1, "Selecione uma palavra!")
            validaDados = False
        ElseIf chkList.CheckedItems.Count <> 3 Then
            TrataErro.SetError(Label1, "Selecione as palavras corretas!")
            validaDados = False
        Else
            If Not (chkList.CheckedItems(0).ToString.Equals("meninos") AndAlso
               chkList.CheckedItems(1).ToString.Equals("brincavam") AndAlso
               chkList.CheckedItems(2).ToString.Equals("bola")) Then
                TrataErro.SetError(Label1, "Selecione as palavras corretas!")
                validaDados = False
            End If
        End If
        If Not validaDados Then
            System.Media.SystemSounds.Asterisk.Play()
        End If

        Return validaDados
    End Function

End Class