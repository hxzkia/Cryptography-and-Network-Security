Public Class CaesarCipherForm
    Private Sub CaesarCipherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        encryptBtn.Checked = True
    End Sub

    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles backBtn.Click
        MainForm.Show()
        Me.Close()
    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub

    Private Sub transformTB_TextChanged(sender As Object, e As EventArgs) Handles transformTB.TextChanged
        UpdateResult()
    End Sub

    Private Sub shiftBox_ValueChanged(sender As Object, e As EventArgs) Handles shiftBox.ValueChanged
        UpdateResult()
    End Sub

    Private Sub encryptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles encryptBtn.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub decryptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles decryptBtn.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub UpdateResult()
        Dim input As String = transformTB.Text
        Dim shiftAmount As Integer = CInt(shiftBox.Value)

        If encryptBtn.Checked Then
            resultTB.Text = CaesarEncrypt(input, shiftAmount)
        Else
            resultTB.Text = CaesarDecrypt(input, shiftAmount)
        End If
    End Sub

    Private Function CaesarEncrypt(text As String, shift As Integer) As String
        Dim result As String = ""
        Dim explanation As String = ""

        For Each character As Char In text
            If Char.IsLetter(character) Then
                Dim asciiStart As Integer = If(Char.IsUpper(character), Asc("A"c), Asc("a"c))
                Dim position As Integer = Asc(character) - asciiStart
                Dim newPosition As Integer = (position + shift) Mod 26
                Dim shiftedChar As Char = Chr(newPosition + asciiStart)

                explanation &= $"{character} -> {shiftedChar} (shifted by {shift}){Environment.NewLine}"
                result &= shiftedChar
            Else
                result &= character
            End If
        Next

        explanation &= $"{Environment.NewLine}{result}"
        Return explanation
    End Function

    Private Function CaesarDecrypt(text As String, shift As Integer) As String
        Return CaesarEncrypt(text, 26 - (shift Mod 26))
    End Function

End Class