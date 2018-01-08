Public Class frm_Apresentacao12
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click


        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao11 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()

            Dim frm As frm_apresentacao13 = Nothing
            For Each form As frm_base In Application.OpenForms
                If TypeOf form Is frm_apresentacao13 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao13
            frm.Show()
        End If
    End Sub

    Private Sub chkList_Click(sender As Object, e As EventArgs) Handles chkList1.Click, chkList2.Click
        TrataErro.SetError(Label1, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        If chkList1.CheckedItems.Count = 0 OrElse chkList2.CheckedItems.Count = 0 Then
            TrataErro.SetError(Label1, "Selecione as preposições")
            validaDados = False
        ElseIf chkList1.CheckedItems.Count <> 1 OrElse chkList2.CheckedItems.Count <> 1 Then
            TrataErro.SetError(Label1, "Selecione as preposições corretas!")
            validaDados = False
        Else
            If Not (chkList1.CheckedItems(0).ToString.Equals("de") AndAlso
               chkList2.CheckedItems(0).ToString.Equals("com")) Then
                TrataErro.SetError(Label1, "Selecione as preposições corretas!")
                validaDados = False
            End If
        End If
        Return validaDados
    End Function
End Class