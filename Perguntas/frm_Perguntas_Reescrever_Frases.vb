Public Class frm_Perguntas_Reescrever_Frases
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao23 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If validaDados() Then

            'Me.Hide()

            Dim frm As frm_apresentacao24 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao24 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao24
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TrataErro.SetError(Label1, String.Empty)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TrataErro.SetError(Label2, String.Empty)
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TrataErro.SetError(Label3, String.Empty)
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TrataErro.SetError(Label4, String.Empty)
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
        TrataErro.SetError(Label8, String.Empty)
    End Sub
    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        TrataErro.SetError(Label9, String.Empty)
    End Sub
    Private Sub TextBox10_TextChanged(sender As Object, e As EventArgs) Handles TextBox10.TextChanged
        TrataErro.SetError(Label10, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        TENTATIVAS_TELA_REESCREVER_FRASES += 1
        Dim str As String = String.Empty

        str = TextBox1.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (str.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label1, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label1, String.Empty)
        End If

        str = TextBox2.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If

        If Not (TextBox2.Texto.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label2, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label2, String.Empty)
        End If

        str = TextBox3.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox3.Texto.ToLower.Trim.Equals(TextBox3.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label3, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label3, String.Empty)
        End If

        str = TextBox4.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox4.Texto.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label4, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label4, String.Empty)
        End If

        str = TextBox5.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox5.Texto.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label5, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label5, String.Empty)
        End If

        str = TextBox6.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox6.Texto.ToLower.Trim.Equals(TextBox6.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label6, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label6, String.Empty)
        End If

        str = TextBox7.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox7.Texto.ToLower.Trim.Equals(TextBox7.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label7, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label7, String.Empty)
        End If

        str = TextBox8.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox8.Texto.ToLower.Trim.Equals(TextBox8.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label8, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label8, String.Empty)
        End If

        str = TextBox9.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox9.Texto.ToLower.Trim.Equals(TextBox9.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label9, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label9, String.Empty)
        End If

        str = TextBox10.Texto
        If str.EndsWith(".") Then
            str = str.Remove(str.LastIndexOf("."))
        End If
        If Not (TextBox10.Texto.ToLower.Trim.Equals(TextBox10.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label10, "Reescreva corretamente a frase abaixo.")
            If TENTATIVAS_TELA_REESCREVER_FRASES < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_REESCREVER_FRASES -= DIMINUIR_ERRO_TELA_REESCREVER_FRASES
            End If
        Else
            TrataErro.SetError(Label10, String.Empty)
        End If
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
        End If

        Return validaDados
    End Function


End Class