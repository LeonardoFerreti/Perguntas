Public Class frm_Perguntas_Musica

    Private arquivo As String = System.IO.Path.GetTempPath() + "video_sistema_perguntas.mp4"

    Private Sub frm_Perguntas_Musica_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim b() As Byte = My.Resources.beijo_me_liga
        System.IO.File.WriteAllBytes(arquivo, b)
        Me.media.URL = arquivo
        Me.media.Ctlcontrols.play()
    End Sub
End Class