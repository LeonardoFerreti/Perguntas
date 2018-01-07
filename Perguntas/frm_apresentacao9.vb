Public Class frm_apresentacao9
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao8
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If ValidaDados() Then
            Me.Hide()
            Dim frm As New frm_apresentacao10
            frm.Show()
        End If
    End Sub

    Private Function ValidaDados() As Boolean
        ValidaDados = True
        If Not TextBox1.Text.ToLower.Equals(TextBox1.Tag.ToString) Then
            ValidaDados = False
            TrataErro.SetError(TextBox1, "Escreva a palavra corretamente.")
        End If
        Return ValidaDados
    End Function
End Class