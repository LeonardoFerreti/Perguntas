Public Class frm_Perguntas_Arrastar
    Private listaConteudo As New List(Of String)
    Private listaFuncionais As New List(Of String)

    Private Sub listBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles listTodasPalavras.MouseDown, lstConteudo.MouseDown, lstFuncionais.MouseDown
        Try
            If CType(sender, ListBox).Items.Count = 0 Then
                Return
            End If
            Dim index As Integer = CType(sender, ListBox).IndexFromPoint(e.X, e.Y)

            Dim sourceStr As String = CType(sender, ListBox).Items(index).ToString()
            Dim objDragDropEff As DragDropEffects = DoDragDrop(sourceStr, DragDropEffects.All)
            If objDragDropEff = DragDropEffects.All Then
                CType(sender, ListBox).Items.RemoveAt(CType(sender, ListBox).IndexFromPoint(e.X, e.Y))
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub listBox_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles listTodasPalavras.DragOver, lstFuncionais.DragOver, lstConteudo.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub listBox_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles listTodasPalavras.DragDrop, lstConteudo.DragDrop, lstFuncionais.DragDrop
        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
        CType(sender, ListBox).Items.Add(str)
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_avancar_click(sender As Object, e As EventArgs) Handles ME._btn_avancar_click
        If validaDados() Then

            '    Me.Hide()

            Dim frm As frm_apresentacao6 = Nothing
            For Each form As Control In Application.OpenForms
                If TypeOf form Is frm_apresentacao6 Then
                    frm = form
                End If
            Next

            If IsNothing(frm) Then frm = New frm_apresentacao6
            Me.Hide()
            frm.Show()
            frm.Focus()
        End If
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles ME._btn_voltar_click
        Me.Hide()

        For Each form As Control In Application.OpenForms
            If TypeOf form Is frm_apresentacao5 Then
                form.Show()
            End If
        Next
    End Sub

    Private Sub frm_Perguntas_Arrastar_Load(sender As Object, e As EventArgs) Handles Me.Load

        listaConteudo.AddRange({"favor", "aqui", "livro", "novo", "mesa", "bom", "tá(está)", "encontrou",
                                "acontecer", "comparecer", "repente", "apontador", "amor", "certeza", "nome", "luz", "ver", "três", "esperando", "tem", "liga", "menina", "menino", "avisa",
                                "amar", "atrasado", "olhar", "terminar", "verdadeiro"})

        listaFuncionais.AddRange({"a", "por", "com", "de", "que", "o", "isso", "essa", "na", "no", "te", "me", "onde", "para", "ti", "em"})

    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        TrataErro.SetError(Label4, String.Empty)
        TrataErro.SetError(Label2, String.Empty)
        TrataErro.SetError(Label3, String.Empty)
        TENTATIVAS_TELA_ARRASTAR_PALAVRAS += 1

        If listTodasPalavras.Items.Count > 0 Then
            ' validaDados = False
            TrataErro.SetError(Label4, "Arraste todas as palavras!")
            Return False
        End If

        If listaConteudo.Count <> lstConteudo.Items.Count Then
            '   validaDados = False
            TrataErro.SetError(Label2, "Arraste todas as palavras!")
            Return False
        End If

        If listaFuncionais.Count <> lstFuncionais.Items.Count Then
            TrataErro.SetError(Label3, "Arraste todas as palavras!")
            Return False
        End If

        For Each item As String In lstConteudo.Items
            If Not listaConteudo.Contains(item) Then
                TrataErro.SetError(Label2, "Selecione as palavras de conteúdo corretas!")
                Return False
            End If
        Next

        For Each item As String In lstFuncionais.Items
            If Not listaFuncionais.Contains(item) Then
                TrataErro.SetError(Label3, "Selecione as palavras funcionais corretas!")
                Return False
            End If
        Next
        If Not validaDados Then
            System.Media.SystemSounds.Exclamation.Play()
            If TENTATIVAS_TELA_ARRASTAR_PALAVRAS < NUMERO_MAXIMO_TENTATIVAS_COM_PERDA Then
                PONTUACAO_TELA_ARRASTAR_PALAVRAS -= DIMINUIR_ERRO_TELA_ARRASTAR_PALAVRAS
            End If
        End If

        Return validaDados
    End Function

End Class