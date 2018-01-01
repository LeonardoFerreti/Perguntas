Public Class frm_Perguntas_Arrastar

    Private Sub listBox_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown, ListBox2.MouseDown, ListBox3.MouseDown
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

    Private Sub listBox_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragOver, ListBox2.DragOver, ListBox3.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub listBox_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop, ListBox2.DragDrop, ListBox3.DragDrop
        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
        CType(sender, ListBox).Items.Add(str)
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_apresentacao6
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao5
        frm.Show()
    End Sub
End Class