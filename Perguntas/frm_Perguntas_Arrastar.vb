Public Class frm_Perguntas_Arrastar

    Private Sub listBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ListBox1.MouseDown
        If ListBox1.Items.Count = 0 Then
            Return
        End If

        Dim index As Integer = ListBox1.IndexFromPoint(e.X, e.Y)
        Dim s As String = ListBox1.Items(index).ToString()
        Dim dde1 As DragDropEffects = DoDragDrop(s, DragDropEffects.All)

        If dde1 = DragDropEffects.All Then
            ListBox1.Items.RemoveAt(ListBox1.IndexFromPoint(e.X, e.Y))
        End If
    End Sub

    Private Sub listBox2_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles ListBox2.DragOver, ListBox2.DragOver
        e.Effect = DragDropEffects.All
    End Sub
    Private Sub listBox2_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles ListBox2.DragDrop, ListBox3.DragDrop
        If e.Data.GetDataPresent(DataFormats.StringFormat) Then
            Dim str As String = DirectCast(e.Data.GetData(DataFormats.StringFormat), String)

            ListBox2.Items.Add(str)
        End If
    End Sub

End Class