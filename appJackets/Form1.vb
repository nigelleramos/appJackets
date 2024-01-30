Public Class Form1
    Private Sub btnPrice_Click(sender As Object, e As EventArgs) Handles btnPrice.Click
''comment
        ''changethis into something,Nigelle


''
  ''
    ''
      ''



        
        Dim dblPrice As Double
        Dim objPrice As New jacket
        Dim strSize As String

        If radSmall.Checked Then
            strSize = "S"
        ElseIf radMedium.Checked Then
            strSize = "M"
        ElseIf radLarge.Checked Then
            strSize = "L"
        Else
            strSize = "XL"
        End If

        dblPrice = objPrice.calcpriceJacket(strSize)
        lblDisplay.Text = dblPrice.ToString("c")



    End Sub
End Class
