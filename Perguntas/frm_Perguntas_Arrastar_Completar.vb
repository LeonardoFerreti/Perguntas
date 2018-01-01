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

    Private Sub listBox_DragOver(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragOver, TextBox2.DragOver, TextBox4.DragOver, TextBox11.DragOver, TextBox12.DragOver, TextBox14.DragOver, TextBox9.DragOver, TextBox16.DragOver, TextBox15.DragOver, TextBox20.DragOver, TextBox18.DragOver, TextBox7.DragOver, TextBox6.DragOver, TextBox31.DragOver, TextBox28.DragOver, TextBox26.DragOver, TextBox24.DragOver, TextBox22.DragOver, TextBox21.DragOver, TextBox5.DragOver
        e.Effect = DragDropEffects.All
    End Sub

    Private Sub listBox_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles TextBox1.DragDrop, TextBox2.DragDrop, TextBox4.DragDrop, TextBox11.DragDrop, TextBox12.DragDrop, TextBox14.DragDrop, TextBox9.DragDrop, TextBox16.DragDrop, TextBox15.DragDrop, TextBox20.DragDrop, TextBox18.DragDrop, TextBox7.DragDrop, TextBox6.DragDrop, TextBox31.DragDrop, TextBox28.DragDrop, TextBox26.DragDrop, TextBox24.DragDrop, TextBox22.DragDrop, TextBox21.DragDrop, TextBox5.DragDrop
        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))
        CType(sender, TextBox).Text = str
    End Sub

    Private Sub frm_Perguntas_Arrastar_btn_voltar_click(sender As Object, e As EventArgs) Handles Me.btn_voltar_click
        Me.Close()
        Dim frm As New frm_apresentacao7
        frm.Show()
    End Sub

    Private Sub frm_Perguntas_Arrastar_Completar_btn_avancar_click(sender As Object, e As EventArgs) Handles Me.btn_avancar_click
        Me.Hide()
        Dim frm As New frm_apresentacao8
        frm.Show()
    End Sub
End Class