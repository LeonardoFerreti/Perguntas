Public Class frm_apresentacao14
    Private Sub frm_apresentacao14_Load(sender As Object, e As EventArgs) Handles Me.Load
        TextBox2.Focus()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click

        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao13 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then

            '        Me.Hide()

            Dim frm As frm_apresentacao15 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao15 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao15
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TrataErro.SetError(lblCombinacao, String.Empty)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TrataErro.SetError(lblContracao, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True

        If Not TextBox2.Texto.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(lblCombinacao, "Informe a combinação correta.")
        End If

        If Not TextBox5.Texto.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(lblContracao, "Informe a contração correta.")
        End If

        Return validaDados
    End Function


End Class