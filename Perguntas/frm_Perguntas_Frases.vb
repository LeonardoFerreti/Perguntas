Public Class frm_Perguntas_Frases
    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao22 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If ValidaDados() Then

            Me.Hide()

            Dim frm As frm_apresentacao23 = Nothing
            For Each form As frm_base In Application.OpenForms
                If TypeOf form Is frm_apresentacao23 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao23
            frm.Show()
        End If
    End Sub

    Private Function ValidaDados()
        ValidaDados = True
        TrataErro.SetError(Label21, String.Empty)
        TrataErro.SetError(Label22, String.Empty)
        TrataErro.SetError(Label23, String.Empty)
        TrataErro.SetError(Label24, String.Empty)
        TrataErro.SetError(Label25, String.Empty)
        TrataErro.SetError(Label26, String.Empty)
        TrataErro.SetError(Label27, String.Empty)
        TrataErro.SetError(Label28, String.Empty)
        TrataErro.SetError(Label29, String.Empty)
        TrataErro.SetError(Label30, String.Empty)

        If Not (TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower) OrElse
            TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower) OrElse
            TextBox3.Text.ToLower.Trim.Equals(TextBox3.Tag.ToString.ToLower) OrElse
            TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower) OrElse
            TextBox5.Text.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower) OrElse
            TextBox6.Text.ToLower.Trim.Equals(TextBox6.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label21, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox7.Text.ToLower.Trim.Equals(TextBox7.Tag.ToString.ToLower) OrElse
            TextBox8.Text.ToLower.Trim.Equals(TextBox8.Tag.ToString.ToLower) OrElse
            TextBox9.Text.ToLower.Trim.Equals(TextBox9.Tag.ToString.ToLower) OrElse
            TextBox10.Text.ToLower.Trim.Equals(TextBox10.Tag.ToString.ToLower) OrElse
            TextBox11.Text.ToLower.Trim.Equals(TextBox11.Tag.ToString.ToLower) OrElse
            TextBox12.Text.ToLower.Trim.Equals(TextBox12.Tag.ToString.ToLower) OrElse
            TextBox13.Text.ToLower.Trim.Equals(TextBox13.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label22, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox14.Text.ToLower.Trim.Equals(TextBox14.Tag.ToString.ToLower) OrElse
            TextBox15.Text.ToLower.Trim.Equals(TextBox15.Tag.ToString.ToLower) OrElse
            TextBox16.Text.ToLower.Trim.Equals(TextBox16.Tag.ToString.ToLower) OrElse
            TextBox17.Text.ToLower.Trim.Equals(TextBox17.Tag.ToString.ToLower) OrElse
            TextBox18.Text.ToLower.Trim.Equals(TextBox18.Tag.ToString.ToLower) OrElse
            TextBox19.Text.ToLower.Trim.Equals(TextBox19.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label23, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox20.Text.ToLower.Trim.Equals(TextBox20.Tag.ToString.ToLower) OrElse
            TextBox21.Text.ToLower.Trim.Equals(TextBox21.Tag.ToString.ToLower) OrElse
            TextBox22.Text.ToLower.Trim.Equals(TextBox22.Tag.ToString.ToLower) OrElse
            TextBox23.Text.ToLower.Trim.Equals(TextBox23.Tag.ToString.ToLower) OrElse
            TextBox24.Text.ToLower.Trim.Equals(TextBox24.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label24, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox25.Text.ToLower.Trim.Equals(TextBox25.Tag.ToString.ToLower) OrElse
            TextBox26.Text.ToLower.Trim.Equals(TextBox26.Tag.ToString.ToLower) OrElse
            TextBox27.Text.ToLower.Trim.Equals(TextBox27.Tag.ToString.ToLower) OrElse
            TextBox28.Text.ToLower.Trim.Equals(TextBox28.Tag.ToString.ToLower) OrElse
            TextBox29.Text.ToLower.Trim.Equals(TextBox29.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label25, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox30.Text.ToLower.Trim.Equals(TextBox30.Tag.ToString.ToLower) OrElse
            TextBox31.Text.ToLower.Trim.Equals(TextBox31.Tag.ToString.ToLower) OrElse
            TextBox32.Text.ToLower.Trim.Equals(TextBox32.Tag.ToString.ToLower) OrElse
            TextBox33.Text.ToLower.Trim.Equals(TextBox33.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label26, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox34.Text.ToLower.Trim.Equals(TextBox34.Tag.ToString.ToLower) OrElse
            TextBox35.Text.ToLower.Trim.Equals(TextBox35.Tag.ToString.ToLower) OrElse
            TextBox36.Text.ToLower.Trim.Equals(TextBox36.Tag.ToString.ToLower) OrElse
            TextBox37.Text.ToLower.Trim.Equals(TextBox37.Tag.ToString.ToLower) OrElse
            TextBox38.Text.ToLower.Trim.Equals(TextBox38.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label27, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox39.Text.ToLower.Trim.Equals(TextBox39.Tag.ToString.ToLower) OrElse
            TextBox40.Text.ToLower.Trim.Equals(TextBox40.Tag.ToString.ToLower) OrElse
            TextBox41.Text.ToLower.Trim.Equals(TextBox41.Tag.ToString.ToLower) OrElse
            TextBox42.Text.ToLower.Trim.Equals(TextBox42.Tag.ToString.ToLower) OrElse
            TextBox43.Text.ToLower.Trim.Equals(TextBox43.Tag.ToString.ToLower) OrElse
            TextBox44.Text.ToLower.Trim.Equals(TextBox44.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label28, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox45.Text.ToLower.Trim.Equals(TextBox45.Tag.ToString.ToLower) OrElse
            TextBox46.Text.ToLower.Trim.Equals(TextBox46.Tag.ToString.ToLower) OrElse
            TextBox47.Text.ToLower.Trim.Equals(TextBox47.Tag.ToString.ToLower) OrElse
            TextBox48.Text.ToLower.Trim.Equals(TextBox48.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label29, "Informe as sílabas corretamente.")
        End If

        If Not (TextBox49.Text.ToLower.Trim.Equals(TextBox49.Tag.ToString.ToLower) OrElse
            TextBox50.Text.ToLower.Trim.Equals(TextBox50.Tag.ToString.ToLower) OrElse
            TextBox51.Text.ToLower.Trim.Equals(TextBox51.Tag.ToString.ToLower) OrElse
            TextBox52.Text.ToLower.Trim.Equals(TextBox52.Tag.ToString.ToLower) OrElse
            TextBox53.Text.ToLower.Trim.Equals(TextBox53.Tag.ToString.ToLower) OrElse
            TextBox54.Text.ToLower.Trim.Equals(TextBox54.Tag.ToString.ToLower)) Then
            ValidaDados = False
            TrataErro.SetError(Label30, "Informe as sílabas corretamente.")
        End If

        Return ValidaDados
    End Function
End Class