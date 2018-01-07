Public Class frm_apresentacao21
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao20
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()
            Dim frm As New frm_apresentacao22
            frm.Show()
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TrataErro.SetError(Label1, String.Empty)
    End Sub

    Private Function ValidaDados() As Boolean
        ValidaDados = True

        If Not TextBox1.Text.ToLower.Equals(TextBox1.Tag.ToString) Then
            ValidaDados = False
            TrataErro.SetError(Label1, "Escreva a frase corretamente.")
        End If

        Return ValidaDados
    End Function
End Class