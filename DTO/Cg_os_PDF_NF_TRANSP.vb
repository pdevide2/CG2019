Public Class Cg_os_PDF_NF_TRANSP

	Dim _id_os As Integer


    Private bytval As Byte()
    Public Property PDF_NF_TRANSP() As Byte()
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


End Class
