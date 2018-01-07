Public Class frm_apresentacao3
    Private Sub chkList_Click(sender As Object, e As EventArgs) Handles chkList.Click
        TrataErro.SetError(Label1, String.Empty)
    End Sub

    Private Sub frm_apresentacao2_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()
            Dim frm As New frm_apresentacao4
            frm.Show()
        End If

    End Sub

    Private Sub frm_apresentacao3_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao2
        frm.Show()
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        If chkList.CheckedItems.Count = 0 Then
            TrataErro.SetError(Label1, "Selecione uma palavra!")
            validaDados = False
        ElseIf chkList.CheckedItems.Count <> 3 Then
            TrataErro.SetError(Label1, "Selecione as palavras corretas!")
            validaDados = False
        Else
            If Not (chkList.CheckedItems(0).ToString.Equals("meninos") AndAlso
               chkList.CheckedItems(1).ToString.Equals("brincavam") AndAlso
               chkList.CheckedItems(2).ToString.Equals("bola")) Then
                TrataErro.SetError(Label1, "Selecione as palavras corretas!")
                validaDados = False
            End If
        End If
            Return validaDados
    End Function

End Class