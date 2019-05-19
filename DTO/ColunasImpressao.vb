Public Class ColunasImpressao

    Public Sub New(ByVal _status As Boolean, ByVal _valor As String)
        Me.Selecionado = _status
        Me.Coluna = _valor
    End Sub

    Private _selecionado As Boolean
    Public Property Selecionado() As Boolean
        Get
            Return _selecionado
        End Get
        Set(ByVal value As Boolean)
            _selecionado = value
        End Set
    End Property

    Private _nomeColuna As String
    Public Property Coluna() As String
        Get
            Return _nomeColuna
        End Get
        Set(ByVal value As String)
            _nomeColuna = value
        End Set
    End Property
End Class
