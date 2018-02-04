Public Class usr_panel
    Inherits Panel

    Private _cor_borda As Drawing.Color = Color.Black
    Public Property COR_BORDA() As Drawing.Color
        Get
            Return _cor_borda
        End Get
        Set(ByVal value As Drawing.Color)
            _cor_borda = value
            Me.Invalidate()
        End Set
    End Property

    Public Sub New()

        SetStyle(ControlStyles.UserPaint Or ControlStyles.ResizeRedraw Or ControlStyles.OptimizedDoubleBuffer Or ControlStyles.AllPaintingInWmPaint, True)
    End Sub

    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Using brush As New SolidBrush(BackColor)
            e.Graphics.FillRectangle(brush, ClientRectangle)
            e.Graphics.DrawRectangle(New Pen(_cor_borda), 0, 0, ClientSize.Width - 1, ClientSize.Height - 1)
        End Using
    End Sub


End Class
