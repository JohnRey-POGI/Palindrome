Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnchecker.Click
        Dim r As Integer
        Dim num As Integer
        Dim temp As Integer

        If IsNumeric(txtnumber.Text) Then
            num = CInt(txtnumber.Text)
        Else
            MessageBox.Show("Please enter a valid number")
            Exit Sub
        End If

        If txtnumber.Text.Length < 3 Then
            MessageBox.Show("Please enter a value not less than 3 characters")
            Exit Sub
        End If

        Dim sum As Integer = 0
        temp = num
        While num > 0
            r = num Mod 10
            sum = (sum * 10) + r
            num /= 10
        End While

        If temp = sum Then
            MessageBox.Show(temp & " is a palindrome number")
        Else
            MessageBox.Show(temp & " is NOT a palindrome number")
        End If
    End Sub
End Class
