Public Class frm_Perguntas_Arrastar_Completar

    Private Sub listBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
        If CType(sender, ListBox).Items.Count = 0 Then
            Return
        End If
        Dim index As Integer = CType(sender, ListBox).IndexFromPoint(e.X, e.Y)
        Dim sourceStr As String = CType(sender, ListBox).Items(index).ToString()
        Dim objDragDropEff As DragDropEffects = DoDragDrop(sourceStr, DragDropEffects.All)
        If objDragDropEff = DragDropEffects.All Then
            '  CType(sender, ListBox).Items.RemoveAt(CType(sender, ListBox).IndexFromPoint(e.X, e.Y))
        End If
    End Sub

    Private Sub listBox_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TextBox4.DragOver, TextBox11.DragOver, TextBox12.DragOver, TextBox14.DragOver, TextBox9.DragOver, TextBox16.DragOver, TextBox15.DragOver, TextBox20.DragOver, TextBox18.DragOver, TextBox7.DragOver, TextBox6.DragOver, TextBox31.DragOver, TextBox28.DragOver, TextBox26.DragOver, TextBox24.DragOver, TextBox22.DragOver, TextBox21.DragOver, TextBox5.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub listBox_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TextBox4.DragDrop, TextBox11.DragDrop, TextBox12.DragDrop, TextBox14.DragDrop, TextBox9.DragDrop, TextBox16.DragDrop, TextBox15.DragDrop, TextBox20.DragDrop, TextBox18.DragDrop, TextBox7.DragDrop, TextBox6.DragDrop, TextBox31.DragDrop, TextBox28.DragDrop, TextBox26.DragDrop, TextBox24.DragDrop, TextBox22.DragDrop, TextBox21.DragDrop, TextBox5.DragDrop
        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
        CType(sender, usr_textbox).Texto = str
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao7 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me._btn_avancar_click
        If validaDados() Then
            '    Me.Hide()

            Dim frm As frm_apresentacao8 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao8 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao8
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If

    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        TrataErro.SetError(Label2, String.Empty)
        TrataErro.SetError(Label3, String.Empty)
        TrataErro.SetError(Label4, String.Empty)
        TrataErro.SetError(Label5, String.Empty)
        TrataErro.SetError(Label6, String.Empty)
        TrataErro.SetError(Label7, String.Empty)
        TrataErro.SetError(Label8, String.Empty)
        TrataErro.SetError(Label9, String.Empty)
        TrataErro.SetError(Label10, String.Empty)
        TrataErro.SetError(Label11, String.Empty)
        TENTATIVAS_TELA_ARRASTAR_COMPLETAR += 1


        If Not TextBox4.Texto.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label2, "Preencha a palavra corretamente.")
        End If

        If (Not TextBox11.Texto.ToLower.Trim.Equals(TextBox11.Tag.ToString.ToLower)) OrElse
           (Not TextBox12.Texto.ToLower.Trim.Equals(TextBox12.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label3, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If (Not TextBox14.Texto.ToLower.Trim.Equals(TextBox14.Tag.ToString.ToLower)) Or
           (Not TextBox9.Texto.ToLower.Trim.Equals(TextBox9.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label4, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If (Not TextBox16.Texto.ToLower.Trim.Equals(TextBox16.Tag.ToString.ToLower)) Or
           (Not TextBox15.Texto.ToLower.Trim.Equals(TextBox15.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label5, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If (Not TextBox20.Texto.ToLower.Trim.Equals(TextBox20.Tag.ToString.ToLower)) Or
           (Not TextBox18.Texto.ToLower.Trim.Equals(TextBox18.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label6, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If (Not TextBox7.Texto.ToLower.Trim.Equals(TextBox7.Tag.ToString.ToLower)) Or
            (Not TextBox6.Texto.ToLower.Trim.Equals(TextBox6.Tag.ToString.ToLower)) Or
           (Not TextBox5.Texto.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label7, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If Not (TextBox31.Texto.ToLower.Trim.Equals(TextBox31.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label8, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If Not (TextBox28.Texto.ToLower.Trim.Equals(TextBox28.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label9, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If (Not TextBox26.Texto.ToLower.Trim.Equals(TextBox26.Tag.ToString.ToLower)) Or
            (Not TextBox24.Texto.ToLower.Trim.Equals(TextBox24.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label10, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If

        If (Not TextBox22.Texto.ToLower.Trim.Equals(TextBox22.Tag.ToString.ToLower)) Or
            (Not TextBox21.Texto.ToLower.Trim.Equals(TextBox21.Tag.ToString.ToLower)) Then
            validaDados = False
            TrataErro.SetError(Label11, "Preencha a palavra corretamente.")
            If TENTATIVAS_TELA_ARRASTAR_COMPLETAR < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_COMPLETAR -= DIMINUIR_ERRO_TELA_ARRASTAR_COMPLETAR
            End If
        End If
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
        End If

        Return validaDados
    End Function


End Class