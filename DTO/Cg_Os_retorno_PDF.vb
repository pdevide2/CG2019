Public Class Cg_os_retorno_PDF

	Dim _id_os As Integer
	Dim _item_id As Integer
	Dim _id_equipamento As Integer


    Private bytval As Byte()
    Public Property Laudo_Fornec() As Byte()
        Get
            Return bytval
        End Get
        Set(ByVal value As Byte())
            bytval = value
        End Set
    End Property


	Property Id_os() As Integer
		Get
			Return _id_os
		End Get
		Set(ByVal value As Integer)
			_id_os = value
		End Set
	End Property

	Property Item_id() As Integer
		Get
			Return _item_id
		End Get
		Set(ByVal value As Integer)
			_item_id = value
		End Set
	End Property

	Property Id_equipamento() As Integer
		Get
			Return _id_equipamento
		End Get
		Set(ByVal value As Integer)
			_id_equipamento = value
		End Set
	End Property

	

End Class
