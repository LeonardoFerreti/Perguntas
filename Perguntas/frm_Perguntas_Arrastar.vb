Public Class frm_Perguntas_Arrastar
    Private listaConteudo As New List(Of String)
    Private listaFuncionais As New List(Of String)

    Private Sub listBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles listTodasPalavras.MouseDown, lstConteudo.MouseDown, lstFuncionais.MouseDown
        If CType(sender, ListBox).Items.Count = 0 Then
            Return
        End If
        Dim index As Integer = CType(sender, ListBox).IndexFromPoint(e.X, e.Y)
        Dim sourceStr As String = CType(sender, ListBox).Items(index).ToString()
        Dim objDragDropEff As DragDropEffects = DoDragDrop(sourceStr, DragDropEffects.All)
        If objDragDropEff = DragDropEffects.All Then
            CType(sender, ListBox).Items.RemoveAt(CType(sender, ListBox).IndexFromPoint(e.X, e.Y))
        End If
    End Sub

    Private Sub listBox_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles listTodasPalavras.DragOver, lstFuncionais.DragOver, lstConteudo.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub listBox_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles listTodasPalavras.DragDrop, lstConteudo.DragDrop, lstFuncionais.DragDrop
        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
        CType(sender, ListBox).Items.Add(str)
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        If validaDados() Then
            Me.Hide()
            Dim frm As New frm_apresentacao6
            frm.Show()
        End If
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao5
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Load(sender As Object, e As EventArgs) Handles Me.Load
        listaConteudo.AddRange({"favor", "aqui", "livro", "novo", "mesa", "bom", "tá(está)", "encontrou",
                                "acontecer", "comparecer", "repente", "favor", "certeza", "nome", "luz", "ver",
                                "três", "esperando", "tem", "liga", "menina", "menino", "avisa",
                                "amar", "atrasado", "olhar", "terminar", "verdadeiro", "amor"})

        listaFuncionais.AddRange({"a", "por", "com", "livro", "de", "que", "o", "isso", "essa", "na", "no", "te", "por", "me", "onde", "para", "ti", "na", "em", "por"})

    End Sub

    Private Function validaDados() As Boolean
        validaDados = True
        If listTodasPalavras.Items.Count > 0 Then
            validaDados = False
            TrataErro.SetError(Label1, "Arraste todas as palavras!")
        End If

        If listaConteudo.Count <> lstConteudo.Items.Count Then
            validaDados = False
            TrataErro.SetError(Label1, "Arraste todas as palavras!")
        End If

        If listaFuncionais.Count <> lstFuncionais.Items.Count Then

        End If

        Return validaDados
    End Function

End Class