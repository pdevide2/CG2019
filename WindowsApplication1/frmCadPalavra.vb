Public Class frmCadPalavra
    Private _Id_user As Integer
    Public Property Id_user() As Integer
        Get
            Return _Id_user
        End Get
        Set(ByVal value As Integer)
            _Id_user = value
        End Set
    End Property

    Public Sub New(ByVal _id_usuario As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        Me.Id_user = _id_usuario
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidaCampos() Then
            Dim intOpt As Byte = 0
            If opt1.Checked = True Then
                intOpt = 1

            ElseIf opt2.Checked = True Then
                intOpt = 2

            ElseIf opt3.Checked = True Then
                intOpt = 3

            ElseIf opt4.Checked = True Then
                intOpt = 4

            ElseIf opt5.Checked = True Then
                intOpt = 5

            End If
            Gravar(intOpt)
            Me.Close()
        End If
    End Sub

    Private Function ValidaCampos() As Boolean
        Dim blnRetorno As Boolean = True
        Try

            If opt1.Checked = False And opt2.Checked = False _
                And opt3.Checked = False And opt4.Checked = False _
                And opt5.Checked = False Then
                blnRetorno = False
                Throw New Exception("Obrigatório selecionar uma pergunta")
            End If
            If String.IsNullOrEmpty(txtResposta.Text) Then
                blnRetorno = False
                Throw New Exception("Obrigatório preencher a resposta")
            End If
        Catch ex As Exception
            blnRetorno = False
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return blnRetorno
    End Function

    Private Sub Gravar(ByVal intOpt As Byte)
        Try
            Dim sqlEmpty As String, sql As String = ""
            sqlEmpty = "update CG_USUARIO SET PALAVRA_CHAVE = '{0}', ID_PERGUNTA = {1} WHERE ID_USUARIO={2}"

            sql = sqlEmpty
            sql = String.Format(sql, txtResposta.Text.ToString, intOpt, Me.Id_user)

            Dim bllGlobal As New BLL.GlobalBLL
            bllGlobal.GravarGenericoBLL(sql)
            MessageBox.Show("Gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class