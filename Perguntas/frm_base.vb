
Public Class frm_base

    Public Event _Load(sender As Object, e As EventArgs)
    Public Event _Shown(sender As Object, e As EventArgs)
    Public Event btn_avancar_click(sender As Object, e As EventArgs)
    Public Event btn_voltar_click(sender As Object, e As EventArgs)

    Private _mostra_botao_voltar As Boolean = True
    Public Property MOSTRA_BOTAO_VOLTAR() As Boolean
        Get
            Return _mostra_botao_voltar
        End Get
        Set(ByVal value As Boolean)
            _mostra_botao_voltar = value
            btnVoltar.Visible = value
        End Set
    End Property

    Private _habilita_voltar As Boolean = True
    Public Property HABILITA_VOLTAR() As Boolean
        Get
            Return _habilita_voltar
        End Get
        Set(ByVal value As Boolean)
            _habilita_voltar = value
            btnVoltar.Enabled = value
        End Set
    End Property

    Private _habilita_avancar As Boolean = True
    Public Property HABILITA_AVANCAR() As Boolean
        Get
            Return _habilita_avancar
        End Get
        Set(ByVal value As Boolean)
            _habilita_avancar = value
            btnAvancar.Enabled = value
        End Set
    End Property

    Private Sub btnAvancar_Click(sender As Object, e As EventArgs) Handles btnAvancar.Click
        RaiseEvent btn_avancar_click(sender, e)
    End Sub

    Private Sub btnVoltar_Click(sender As Object, e As EventArgs) Handles btnVoltar.Click
        RaiseEvent btn_voltar_click(sender, e)
    End Sub

    Private Sub frm_base_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MsgBox("Deseja realmente sair do sistema?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Process.GetCurrentProcess().Kill()
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub frm_base_Load(sender As Object, e As EventArgs) Handles Me.Load
        'Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        'SkinManager.AddFormToManage(Me)
        'SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        'SkinManager.ColorScheme = New ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE)
        'RaiseEvent _Load(sender, e)
    End Sub

    Private Sub frm_base_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        RaiseEvent _Shown(sender, e)
    End Sub

End Class
