﻿Public Class frm_apresentacao14
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao13
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()
            Dim frm As New frm_apresentacao15
            frm.Show()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged, TextBox2.TextChanged
        TrataErro.SetError(lblCombinacao, String.Empty)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged, TextBox5.TextChanged
        TrataErro.SetError(lblContracao, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True

        If Not (TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString) OrElse
            TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(lblCombinacao, "Informe a combinação correta.")
        End If

        If Not (TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString) OrElse
            TextBox5.Text.ToLower.Trim.Equals(TextBox5.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(lblContracao, "Informe a contração correta.")
        End If

        Return validaDados
    End Function
End Class