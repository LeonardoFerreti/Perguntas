﻿Public Class frm_Perguntas_Musica

    Private arquivo As String = Application.StartupPath + "video_sistema_perguntas.mp4"

    Private Sub frm_Perguntas_Musica_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click
        If validaDados() Then
            '    Me.Hide()
            Me.media.Ctlcontrols.stop()

            Dim frm As frm_resultado = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_resultado Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_resultado
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If
    End Sub

    Private Sub frm_Perguntas_Musica_btn_voltar_click(sender As Object, e As EventArgs) Handles Me._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao24 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Musica_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not IO.File.Exists(Application.StartupPath + "\" + "video_sistema_perguntas.mp4") Then
            Dim b() As Byte = My.Resources.beijo_me_liga
            System.IO.File.WriteAllBytes(Application.StartupPath + "\" + "video_sistema_perguntas.mp4", b)
        End If
        Me.media.URL = Application.StartupPath + "\" + "video_sistema_perguntas.mp4"
        Me.media.Ctlcontrols.play()
    End Sub

    Private Sub frm_Perguntas_Musica_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.Cursor = Cursors.Default
        TextBox1.Focus()
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
        TrataErro.SetError(Label16, String.Empty)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TrataErro.SetError(Label17, String.Empty)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TrataErro.SetError(Label18, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        TENTATIVAS_TELA_MUSICA += 1

        If Not TextBox1.Texto.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label12, "palavra incorreta!")
        End If
        If Not TextBox2.Texto.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label13, "palavra incorreta!")
        End If
        If Not TextBox3.Texto.ToLower.Trim.Equals(TextBox3.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label14, "palavra incorreta!")
        End If
        If Not TextBox4.Texto.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label15, "palavra incorreta!")
        End If
        If Not TextBox5.Texto.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label16, "palavra incorreta!")
        End If
        If Not TextBox6.Texto.ToLower.Trim.Equals(TextBox6.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label17, "palavra incorreta!")
        End If
        If Not TextBox7.Texto.ToLower.Trim.Equals(TextBox7.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label18, "palavra incorreta!")
        End If
        If Not Textbox8.Texto.ToLower.Trim.Equals(Textbox8.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label19, "palavra incorreta!")
        End If
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
            If TENTATIVAS_TELA_MUSICA < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_MUSICA -= DIMINUIR_ERRO_TELA_MUSICA
            End If
        End If

        Return validaDados
    End Function


End Class