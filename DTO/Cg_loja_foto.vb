Public Class Cg_loja_foto

    Dim _id_loja As Integer
    Private bytval As Byte()
    Dim _filetype As String

    Public Property Foto_Loja() As Byte()
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

    Property Id_Loja() As Integer
        Get
            Return _id_loja
        End Get
        Set(ByVal value As Integer)
            _id_loja = value
        End Set
    End Property

End Class
