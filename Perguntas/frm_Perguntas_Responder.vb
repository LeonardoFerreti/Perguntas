Public Class frm_Perguntas_Responder
    Private listaPalavras As New List(Of String)

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao10 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click
        If validaDados() Then
            'Me.Hide()

            Dim frm As frm_apresentacao11 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao11 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao11
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If

    End Sub

    Private Sub frm_Perguntas_Responder_Load(sender As Object, e As EventArgs) Handles Me.Load

        listaPalavras.AddRange({"paralelo", "maltratado", "chapeuzinho", "verdadeiro", "maldade", "pontapé", "casamento", "bondoso", "felizmente", "terminando"})
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        TrataErro.SetError(Label1, String.Empty)
        TENTATIVAS_TELA_RESPONDER_PERGUNTAS += 1

        For Each control As Control In GroupBox1.Controls
            If TypeOf control Is usr_textbox Then
                If CType(control, usr_textbox).Texto.Equals(String.Empty) Then
                    TrataErro.SetError(Label1, "Preencha todos os campos disponíveis")
                    Return False
                End If
            End If
        Next

        For Each control As Control In GroupBox1.Controls
            If TypeOf control Is usr_textbox Then
                If Not (listaPalavras.Contains(CType(control, usr_textbox).Texto.ToLower.Trim)) Then
                    TrataErro.SetError(Label1, "Verifique as palavras informadas.")
                    Return False
                End If
            End If
        Next
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
            If TENTATIVAS_TELA_RESPONDER_PERGUNTAS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_RESPONDER_PERGUNTAS -= DIMINUIR_ERRO_TELA_RESPONDER_PERGUNTAS
            End If
        End If

        Return validaDados
    End Function


End Class