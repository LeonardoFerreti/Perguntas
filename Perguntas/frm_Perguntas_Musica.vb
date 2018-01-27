Public Class frm_Perguntas_Musica

    Private arquivo As String = System.IO.Path.GetTempPath() + "video_sistema_perguntas.mp4"

    Private Sub frm_Perguntas_Musica_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()

            Dim frm As frm_resultado = Nothing
            For Each form As frm_base In Application.OpenForms
                If TypeOf form Is frm_resultado Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_resultado
            frm.Show()
        End If
    End Sub

    Private Sub frm_Perguntas_Musica_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Hide()

        For Each form As frm_base In Application.OpenForms
            If TypeOf form Is frm_apresentacao24 Then
                form.Show()
            End If
        Next
    End Sub

    ''Private Sub frm_Perguntas_Musica_Load(sender As Object, e As EventArgs) Handles Me.Load
    ''    Me.Cursor = Cursors.AppStarting
    ''    Dim b() As Byte = My.Resources.beijo_me_liga
    ''    System.IO.File.WriteAllBytes(arquivo, b)
    ''    Me.media.URL = arquivo
    ''    Me.media.Ctlcontrols.play()
    ''End Sub

    ''Private Sub frm_Perguntas_Musica_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    ''    Me.Cursor = Cursors.Default
    ''    TextBox1.Focus()
    ''End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TrataErro.SetError(Label12, String.Empty)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TrataErro.SetError(Label13, String.Empty)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        TrataErro.SetError(Label14, String.Empty)
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        TrataErro.SetError(Label15, String.Empty)
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TrataErro.SetError(Label16, String.Empty)
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        TrataErro.SetError(Label17, String.Empty)
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        TrataErro.SetError(Label18, String.Empty)
    End Sub

    Private Function validaDados() As Boolean
        validaDados = True

        If Not TextBox1.Text.ToLower.Trim.Equals(TextBox1.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label12, "palavra incorreta!")
        End If
        If Not TextBox2.Text.ToLower.Trim.Equals(TextBox2.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label13, "palavra incorreta!")
        End If
        If Not TextBox3.Text.ToLower.Trim.Equals(TextBox3.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label14, "palavra incorreta!")
        End If
        If Not TextBox4.Text.ToLower.Trim.Equals(TextBox4.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label15, "palavra incorreta!")
        End If
        If Not TextBox5.Text.ToLower.Trim.Equals(TextBox5.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label16, "palavra incorreta!")
        End If
        If Not TextBox6.Text.ToLower.Trim.Equals(TextBox6.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label17, "palavra incorreta!")
        End If
        If Not TextBox7.Text.ToLower.Trim.Equals(TextBox7.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label18, "palavra incorreta!")
        End If
        If Not Textbox8.Text.ToLower.Trim.Equals(Textbox8.Tag.ToString.ToLower) Then
            validaDados = False
            TrataErro.SetError(Label19, "palavra incorreta!")
        End If
        Return validaDados
    End Function


End Class