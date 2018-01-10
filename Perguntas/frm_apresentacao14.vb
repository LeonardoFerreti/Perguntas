Public Class frm_apresentacao14
    Private Sub frm_apresentacao14_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox1.Focus()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click

        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao13 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then

            Me.Hide()

            Dim frm As frm_apresentacao15 = Nothing
            For Each form As frm_base In Application.OpenForms
                If TypeOf form Is frm_apresentacao15 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao15
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

        If Not (TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower) OrElse
            TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(lblCombinacao, "Informe a combinação correta.")
        End If

        If Not (TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower) OrElse
            TextBox5.Text.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(lblContracao, "Informe a contração correta.")
        End If

        Return validaDados
    End Function


End Class