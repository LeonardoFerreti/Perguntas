Public Class frm_base

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
End Class
