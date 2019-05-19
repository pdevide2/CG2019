Public Class UsuarioDuplicaPerfil

    Private _user As Integer
    Public Property IdUsuario() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Public Sub New(_id_user As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.IdUsuario = _id_user

    End Sub
    Private Sub UsuarioDuplicaPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.Text = Dominio()
    End Sub

    Private Function Dominio() As String
        Return Mid(UserName(), 1, InStr(1, UserName(), "\", 0))
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtLogin.Text = Dominio() Then
            MessageBox.Show("Informe um Login de Rede Válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        DuplicarUsuario()
        Me.Close()
    End Sub

    Private Sub DuplicarUsuario()

        Dim bllglobal As New BLL.GlobalBLL
        Dim cmdsql As String

        cmdsql = "EXEC spDuplicaUsuario "
        cmdsql += "@ID_USUARIO = " & Me.IdUsuario.ToString & ", "
        cmdsql += "@NOME = '" & Trim(txtNome.Text) & "', "
        cmdsql += "@APELIDO = '" & Trim(txtApelido.Text) & "', "
        cmdsql += "@LOGIN = '" & Trim(txtLogin.Text) & "', "
        cmdsql += "@USER_INS = " & ACE_CODIGO.ToString

        Try
            bllglobal.GravarGenericoBLL(cmdsql)
            MessageBox.Show("Usuário criado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try


    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class