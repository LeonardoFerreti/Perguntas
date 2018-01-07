Public Class frm_Perguntas_Reescrever_Frases
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao23
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()
            Dim frm As New frm_apresentacao24
            frm.Show()
        End If
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True

        If Not (TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label1, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label2, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox3.Text.ToLower.Trim.Equals(TextBox3.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label3, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label4, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox5.Text.ToLower.Trim.Equals(TextBox5.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label5, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox6.Text.ToLower.Trim.Equals(TextBox6.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label6, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox7.Text.ToLower.Trim.Equals(TextBox7.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label7, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox8.Text.ToLower.Trim.Equals(TextBox8.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label8, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox9.Text.ToLower.Trim.Equals(TextBox9.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label9, "Reescreva corretamente a frase abaixo.")
        End If

        If Not (TextBox10.Text.ToLower.Trim.Equals(TextBox10.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label10, "Reescreva corretamente a frase abaixo.")
        End If

        Return validaDados
    End Function
End Class