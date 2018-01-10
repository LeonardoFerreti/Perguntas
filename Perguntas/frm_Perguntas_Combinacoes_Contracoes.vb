Public Class frm_Perguntas_Combinacoes_Contracoes
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click

        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao15 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()

            Dim frm As frm_apresentacao16 = Nothing
            For Each form As frm_base In Application.OpenForms
                If TypeOf form Is frm_apresentacao16 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao16
            frm.Show()
        End If

    End Sub

    Private Function validaDados() As Boolean
        validaDados = True

        If Not (TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label1, "Reescreva corretamente a combinação.")
        End If

        If Not (TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label2, "Reescreva corretamente a combinação.")
        End If

        If Not (TextBox3.Text.ToLower.Trim.Equals(TextBox3.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label3, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label4, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox5.Text.ToLower.Trim.Equals(TextBox5.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label5, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox6.Text.ToLower.Trim.Equals(TextBox6.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label6, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox7.Text.ToLower.Trim.Equals(TextBox7.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label7, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox8.Text.ToLower.Trim.Equals(TextBox8.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label8, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox9.Text.ToLower.Trim.Equals(TextBox9.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label9, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox10.Text.ToLower.Trim.Equals(TextBox10.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label10, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox11.Text.ToLower.Trim.Equals(TextBox11.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label11, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox12.Text.ToLower.Trim.Equals(TextBox12.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label12, "Reescreva corretamente a contração.")
        End If

        If Not (TextBox13.Text.ToLower.Trim.Equals(TextBox13.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label13, "Reescreva corretamente a contração.")
        End If

        Return validaDados
    End Function


End Class