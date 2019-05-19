Imports System.Windows.Forms

Public Class WaitWindow
    Private _tempo As Integer
    Public Property Tempo() As Integer
        Get
            Return _tempo
        End Get
        Set(ByVal value As Integer)
            _tempo = value
        End Set
    End Property

    Private _mensagem As String
    Public Property Mensagem() As String
        Get
            Return _mensagem
        End Get
        Set(ByVal value As String)
            _mensagem = value
        End Set
    End Property


    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub WaitWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Inicio()
    End Sub
    Sub New(ByVal _msg As String, _time As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.Mensagem = _msg
        Me.Tempo = IIf(_time = 0, 1000, _time)
        Timer1.Interval = Me.Tempo * 1000 'Tempo em segundos, exemplo Me.tempo = 2 entao 2*1000 = 2000 milisegundos
        Timer1.Enabled = True
    End Sub

    Private Sub Inicio()

        Label1.Text = Me.Mensagem

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class
