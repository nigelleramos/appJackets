Public Class jacket

    Private dblPrice As Double

    Public Function calcpriceJacket(strSize As String) As Double

        Select Case strSize
            Case "S"
                dblPrice = 29.95
            Case "M"
                dblPrice = 34.95
            Case "L"
                dblPrice = 39.95
            Case "XL"
                dblPrice = 44.95
            Case Else
                MessageBox.Show("Error")

        End Select

        Return dblPrice

    End Function


End Class
