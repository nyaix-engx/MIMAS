Imports System.Net
Imports System.Text
Imports Nancy.Json
Imports Newtonsoft.Json

Public Class Form2

    Public userName As String
    Public token As String

    Private Async Sub submit_button_Click(sender As Object, e As EventArgs) Handles submit_button.Click
        apiMessage.Text = "Processing..."
        Try
            Dim c As New user
            c.telephone = phoneNumber.Text
            c.pin = pin.Text
            Dim RestURL As String = "https://dee2-139-5-254-216.ngrok.io/customer/login"
            Dim client As New Http.HttpClient
            Dim JsonData As String = JsonConvert.SerializeObject(c)
            Dim RestContent As New Http.StringContent(JsonData, Encoding.UTF8, "application/json")
            Dim RestResponse As Http.HttpResponseMessage = Await client.PostAsync(RestURL, RestContent)
            If RestResponse.StatusCode.ToString = "OK" Then
                apiMessage.Text = "Successfully Authenticated"
                Dim responseBody As Object = Await RestResponse.Content.ReadAsStringAsync()
                Dim j As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)
                userName = j.customer.customerName
                token = j.token
                Me.Hide()
                Dim Dashboard As New Form4
                Dashboard.Show()
            Else
                apiMessage.Text = "Authentication Failure"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Public Class user
        Public Property telephone As Int64

        Public Property pin As Integer

    End Class

    Private Sub phoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles phoneNumber.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)

    End Sub

    Private Sub pin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pin.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)

    End Sub
End Class