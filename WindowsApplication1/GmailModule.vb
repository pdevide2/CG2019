Imports System.Net.Mail
Imports System.Net.Mime

Module GmailModule
    Dim mail As New MailMessage()
    Dim path As String

    Public Function EnviarGMail(_email_destino As String, _email_titulo As String, _
                                _email_assunto As String, ByVal listaAnexos As Array) As Boolean
        Dim llOK As Boolean = True
        Dim SmtpServer As New SmtpClient()
        Dim _email_address As String = My.Settings.EMAIL_ADMIN
        Dim _email_pwd As String = My.Settings.EMAIL_ADMIN_PWD
        SmtpServer.Credentials = New Net.NetworkCredential(_email_address, _email_pwd)
        SmtpServer.Port = 587
        SmtpServer.Host = "smtp.gmail.com"
        SmtpServer.EnableSsl = True
        mail = New MailMessage()
        path = My.Settings.DIRHOME & "CG\CG\Image\SmallLogoSR.PNG"
        Dim addr() As String = _email_destino.Split(",")

        Try
            mail.From = New MailAddress(_email_address, "Administrador Sistema CG", System.Text.Encoding.UTF8)
            Dim i As Byte
            For i = 0 To addr.Length - 1
                mail.To.Add(addr(i))
            Next
            mail.Subject = _email_titulo
            'mail.Body = txtAssunto.Text
            'If lstAnexos.Items.Count <> 0 Then
            '    For i = 0 To lstAnexos.Items.Count - 1
            '        mail.Attachments.Add(New Attachment(lstAnexos.Items.Item(i)))
            '    Next
            'End If

            Dim blnTemAnexo As Boolean = True
            'Declarar o array de Anexos com a Seguinte sintaxe:
            'Dim arrayFiles() As String = {""}
            '----------------------------------------------------
            'Caso ele seja utilizado (populado), a variavel blnTemAnexo será True
            'Senão, permanece o valor default que é "" (empty)
            'Pode ter vários anexos
            If UBound(listaAnexos) = 0 And String.IsNullOrEmpty(listaAnexos(0)) Then
                'Se entrar aqui, o anexo não foi selecionado
                blnTemAnexo = False
            End If

            If blnTemAnexo Then
                For i = 0 To UBound(listaAnexos) Step 1

                    mail.Attachments.Add(New Attachment(listaAnexos(i)))

                Next
            End If


            If path <> Nothing Then
                Dim logo As New LinkedResource(path)
                logo.ContentId = "Logo"
                Dim htmlview As String
                htmlview = "<html><body><table border=2><tr width=100%><td><img src=cid:Logo alt=companyname /></td><td>Sistema CG</td></tr></table><hr/></body></html>"
                Dim alternateView1 As AlternateView = AlternateView.CreateAlternateViewFromString(htmlview + _email_assunto, Nothing, MediaTypeNames.Text.Html)
                alternateView1.LinkedResources.Add(logo)

                mail.AlternateViews.Add(alternateView1)
            End If

            mail.IsBodyHtml = True
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure
            'mail.ReplyTo = New MailAddress(_email_address)
            mail.ReplyToList.Add(New MailAddress(_email_address))
            SmtpServer.Send(mail)
        Catch ex As Exception
            llOK = False
            MessageBox.Show(ex.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Return llOK
    End Function
End Module
