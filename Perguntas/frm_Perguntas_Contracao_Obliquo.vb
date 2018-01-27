Public Class frm_Perguntas_Contracao_Obliquo
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click

        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao16 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then

            Me.Hide()

            Dim frm As frm_apresentacao17 = Nothing
            For Each form As frm_base In Application.OpenForms
                If TypeOf form Is frm_apresentacao17 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao17
            frm.Show()
        End If
    End Sub

    Private Sub frm_Perguntas_Contracao_Obliquo_Shown(sender As Object, e As EventArgs) Handles Me._Shown
        TextBox1.Focus()
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

    Private Function validaDados() As Boolean
        validaDados = True
        If Not (TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label1, "Preencha o pronome corretamente.")
        End If

        If Not (TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label2, "Preencha o pronome corretamente.")
        End If

        If Not (TextBox3.Text.ToLower.Trim.Equals(TextBox3.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label3, "Preencha o pronome corretamente.")
        End If

        If Not (TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString)) Then
            validaDados = False
            TrataErro.SetError(Label4, "Preencha o pronome corretamente.")
        End If

        Return validaDados
    End Function


End Class