Imports System.Net
Imports System.Net.Http.Headers
Imports System.Text
Imports Nancy.Json

Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        header.Text = $"Welcome {Form2.userName}"
    End Sub


    Async Function apiCall(restUrl As String, method As String, RestContent As Object) As Task(Of Object)
        Dim client As New Http.HttpClient
        client.DefaultRequestHeaders.Authorization = New AuthenticationHeaderValue("Bearer", Form2.token)
        Dim RestResponse As Http.HttpResponseMessage

        If method = "GET" Then
            RestResponse = Await client.GetAsync(restUrl)
        ElseIf method = "POST" Then
            RestResponse = Await client.PostAsync(restUrl, RestContent)
        Else
            RestResponse = Await client.PutAsync(restUrl, RestContent)
        End If

        Return RestResponse

    End Function

    Private Async Sub getCash_Click(sender As Object, e As EventArgs) Handles getCash.Click
        balanceInfo.Text = "Fetching Information..."
        Try
            Dim res As Http.HttpResponseMessage = Await apiCall("https://dee2-139-5-254-216.ngrok.io/cash", "GET", {})
            Dim responseBody As Object = Await res.Content.ReadAsStringAsync()
            Dim resJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)
            Debug.WriteLine(resJson)
            If res.StatusCode = 200 Then
                balanceInfo.Text = $"Your cash balance is {resJson.cashBalance}€"
            Else
                balanceInfo.Text = resJson.message
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Async Sub getShare_Click(sender As Object, e As EventArgs) Handles getShare.Click
        balanceInfo.Text = "Fetching Information..."
        Try
            Dim res As Http.HttpResponseMessage = Await apiCall("https://dee2-139-5-254-216.ngrok.io/share", "GET", {})
            Dim responseBody As Object = Await res.Content.ReadAsStringAsync()
            Dim resJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)

            If res.StatusCode = 200 Then
                balanceInfo.Text = $"Your share balance is {resJson.shareBalance}€"
            Else
                balanceInfo.Text = resJson.message
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Async Sub depositMoney_Click(sender As Object, e As EventArgs) Handles depositMoney.Click
        balanceInfo.Text = ""
        Try
            If Amount.Text.ToString().Length = 0 Then
                balanceInfo.Text = "Amount field is empty"
            Else
                balanceInfo.Text = "Depositing money..."
                Dim c As New AmountObj
                c.amount = Amount.Text
                Dim JsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(c)
                Dim RestContent As New Http.StringContent(JsonData, Encoding.UTF8, "application/json")
                Dim res As Http.HttpResponseMessage = Await apiCall("https://dee2-139-5-254-216.ngrok.io/cashtransaction", "PUT", RestContent)
                Dim responseBody As Object = Await res.Content.ReadAsStringAsync()
                Dim resJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)
                If res.StatusCode = 200 Then
                    balanceInfo.Text = "Transaction Successful"
                    Amount.Text = ""
                Else
                    balanceInfo.Text = resJson.message
                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Public Class AmountObj
        Public Property amount As Int64
    End Class

    Private Sub Amount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Amount.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Asc(e.KeyChar) = 8)
    End Sub

    Private Async Sub withdrawCash_Click(sender As Object, e As EventArgs) Handles withdrawCash.Click
        balanceInfo.Text = ""
        Try
            If Amount.Text.ToString().Length = 0 Then
                balanceInfo.Text = "Amount field is empty"
            Else
                balanceInfo.Text = "Withdrawing money..."
                Dim c As New AmountObj
                c.amount = Amount.Text - (Amount.Text * 2)
                Dim JsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(c)


                Dim RestContent As New Http.StringContent(JsonData, Encoding.UTF8, "application/json")
                Dim res As Http.HttpResponseMessage = Await apiCall("https://dee2-139-5-254-216.ngrok.io/cashtransaction", "PUT", RestContent)
                Dim responseBody As Object = Await res.Content.ReadAsStringAsync()
                Dim resJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)
                If res.StatusCode = 200 Then
                    balanceInfo.Text = "Transaction Successful"
                    Amount.Text = ""
                Else
                    balanceInfo.Text = resJson.message
                End If
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub

    Private Async Sub buyShare_Click(sender As Object, e As EventArgs) Handles buyShare.Click
        balanceInfo.Text = ""
        Try
            If Amount.Text.ToString().Length = 0 Then
                balanceInfo.Text = "Amount field is empty"
            Else
                balanceInfo.Text = "Buying Share..."
                Dim c As New AmountObj
                c.amount = Amount.Text
                Dim JsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(c)
                Dim RestContent As New Http.StringContent(JsonData, Encoding.UTF8, "application/json")
                Dim res As Http.HttpResponseMessage = Await apiCall("https://dee2-139-5-254-216.ngrok.io/sharetransaction", "PUT", RestContent)
                Dim responseBody As Object = Await res.Content.ReadAsStringAsync()
                Dim resJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)
                If res.StatusCode = 200 Then
                    balanceInfo.Text = "Transaction Successful"
                    Amount.Text = ""

                Else
                    balanceInfo.Text = resJson.message
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Async Sub sellShare_Click(sender As Object, e As EventArgs) Handles sellShare.Click
        balanceInfo.Text = ""
        Try
            If Amount.Text.ToString().Length = 0 Then
                balanceInfo.Text = "Amount field is empty"
            Else
                balanceInfo.Text = "Selling share..."
                Dim c As New AmountObj
                c.amount = Amount.Text - (Amount.Text * 2)
                Dim JsonData As String = Newtonsoft.Json.JsonConvert.SerializeObject(c)
                Dim RestContent As New Http.StringContent(JsonData, Encoding.UTF8, "application/json")
                Dim res As Http.HttpResponseMessage = Await apiCall("https://dee2-139-5-254-216.ngrok.io/sharetransaction", "PUT", RestContent)
                Dim responseBody As Object = Await res.Content.ReadAsStringAsync()
                Dim resJson As Object = New JavaScriptSerializer().Deserialize(Of Object)(responseBody)
                If res.StatusCode = 200 Then
                    balanceInfo.Text = "Transaction Successful"
                    Amount.Text = ""

                Else
                    balanceInfo.Text = resJson.message
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Hide()
        Dim LoginScreen As New Form2
        Form2.token = ""
        LoginScreen.Show()
    End Sub
End Class