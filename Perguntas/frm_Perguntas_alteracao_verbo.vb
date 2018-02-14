Public Class frm_Perguntas_alteracao_verbo
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao18 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If validaDados() Then

            '  Me.Hide()

            Dim frm As frm_apresentacao19 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao19 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao19
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TrataErro.SetError(Label12, String.Empty)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TrataErro.SetError(Label13, String.Empty)
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TrataErro.SetError(Label14, String.Empty)
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TrataErro.SetError(Label15, String.Empty)
    End Sub
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TrataErro.SetError(Label5, String.Empty)
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TrataErro.SetError(Label6, String.Empty)
    End Sub
    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TrataErro.SetError(Label7, String.Empty)
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        TrataErro.SetError(Label16, String.Empty)
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TrataErro.SetError(Label10, String.Empty)
    End Sub
    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles TextBox11.TextChanged
        TrataErro.SetError(Label11, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        TENTATIVAS_TELA_ALTERAR_VERBOS += 1

        Dim str As String = String.Empty

        str = TextBox1.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label12, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label12, String.Empty)
        End If

        str = TextBox2.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label13, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label13, String.Empty)
        End If

        str = TextBox3.Texto
        If str.EndsWith("?") Then
            str = str.Remove(str.LastIndexOf("?"))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox3.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label14, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label14, String.Empty)
        End If

        str = TextBox4.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label15, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label15, String.Empty)
        End If

        str = TextBox5.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label5, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label5, String.Empty)
        End If

        str = TextBox6.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox6.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label6, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label6, String.Empty)
        End If

        str = TextBox7.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox7.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label7, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label7, String.Empty)
        End If
        '**
        str = TextBox8.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox8.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label17, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label17, String.Empty)
        End If

        str = TextBox10.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox10.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label10, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label10, String.Empty)
        End If

        str = TextBox11.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox11.Tag.ToString.ToLower)) Then
            If TENTATIVAS_TELA_ALTERAR_VERBOS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ALTERAR_VERBOS -= DIMINUIR_ERRO_TELA_ALTERAR_VERBOS
            End If
            validaDados = False
            TrataErro.SetError(Label11, "Reescreva corretamente a frase abaixo.")
        Else
            TrataErro.SetError(Label11, String.Empty)
        End If
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
        End If

        Return validaDados
    End Function

    Private Sub frm_Perguntas_alteracao_verbo_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox1._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
        End If
    End Sub

    Private Sub TextBox2_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox2._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox3_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox3._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub TextBox4_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox4._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox8.Focus()
        End If
    End Sub
    Private Sub TextBox8_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox8._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox7.Focus()
        End If
    End Sub
    Private Sub TextBox7_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox7._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox6.Focus()
        End If
    End Sub
    Private Sub TextBox6_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox6._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Focus()
        End If
    End Sub
    Private Sub TextBox5_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox5._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox11.Focus()
        End If
    End Sub

    Private Sub TextBox11_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox11._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            TextBox10.Focus()
        End If
    End Sub

    Private Sub TextBox10_textbox_keyDown(sender As Object, e As KeyEventArgs) Handles TextBox10._textbox_keyDown
        If e.KeyCode = Keys.Enter Then
            Controle_navegacao1.btn_avancar.Focus()
        End If
    End Sub

End Class