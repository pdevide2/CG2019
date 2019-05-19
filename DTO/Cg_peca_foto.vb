Public Class Cg_peca_foto

    Dim _id_peca As Integer
    Private bytval As Byte()
    Dim _filetype As String

    Public Property Foto_peca() As Byte()
        Get
            Return bytval
        End Get
        Set(ByVal value As Byte())
            bytval = value
        End Set
    End Property


    Property Filetype() As String
        Get
            Return _filetype
        End Get
        Set(ByVal value As String)
            _filetype = value
        End Set
    End Property

    Property Id_peca() As Integer
        Get
            Return _id_peca
        End Get
        Set(ByVal value As Integer)
            _id_peca = value
        End Set
    End Property

End Class
