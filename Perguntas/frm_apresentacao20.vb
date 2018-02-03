﻿Public Class frm_apresentacao20
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao19 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If ValidaDados() Then
            '     Me.Hide()

            Dim frm As frm_apresentacao21 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao21 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao21
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If

    End Sub

    Private Function ValidaDados() As Boolean
        ValidaDados = True
        If Not TextBox1.Texto.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower) Then
            ValidaDados = False
            TrataErro.SetError(Label1, "Informe o artigo corretamente.")
        End If
        If Not TextBox2.Texto.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower) Then
            ValidaDados = False
            TrataErro.SetError(Label2, "Informe o substantivo corretamente.")
        End If
        If Not TextBox3.Texto.ToLower.Trim.Equals(TextBox3.Tag.ToString.ToLower) Then
            ValidaDados = False
            TrataErro.SetError(Label3, "Informe o pronome corretamente.")
        End If
        If Not (TextBox4.Texto.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower) OrElse
               TextBox4.Texto.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label4, "Informe os verbos corretamente.")
        End If
        If Not (TextBox5.Texto.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower) OrElse
               TextBox5.Texto.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label4, "Informe os verbos corretamente.")
        End If
        If Not ValidaDados Then
            System.Media.SystemSounds.Exclamation.Play()
        End If

        Return ValidaDados
    End Function

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

    Private Sub frm_apresentacao20_Load(sender As Object, e As EventArgs) Handles Me.Load

        TextBox1.Focus()
    End Sub

    Private Sub frm_apresentacao20_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        TextBox1.Focus()
    End Sub


End Class