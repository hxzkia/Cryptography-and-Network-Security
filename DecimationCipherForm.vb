Public Class DecimationCipherForm
    Private Sub DecimationCipherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub keyCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles keyCB.SelectedIndexChanged
        UpdateResult()
    End Sub

    Private Sub encryptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles encryptBtn.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub decryptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles decryptBtn.CheckedChanged
        UpdateResult()
    End Sub


    Private Sub UpdateResult()
        If keyCB.SelectedItem Is Nothing Then
            resultTB.Text = "Choose a key!"
            Return
        End If

        Dim inputText As String = transformTB.Text
        Dim key As Integer = CInt(keyCB.SelectedItem)
        Dim output As String = ""

        If encryptBtn.Checked Then
            output = DecimationEncrypt(inputText, key)
        Else
            output = DecimationDecrypt(inputText, key)
        End If

        resultTB.Text = output
    End Sub

    Private Function DecimationEncrypt(text As String, key As Integer) As String
        Dim result As String = ""
        Dim explanation As String = ""

        For Each character As Char In text
            If Char.IsLetter(character) Then
                Dim asciiStart As Integer = If(Char.IsUpper(character), Asc("A"c), Asc("a"c))
                Dim position As Integer = Asc(character) - asciiStart
                Dim newPosition As Integer = (key * position) Mod 26
                Dim encryptedChar As Char = Chr(asciiStart + newPosition)

                explanation &= $"{character} -> {encryptedChar} (E({position}) = {key} * {position} mod 26 = {newPosition}){Environment.NewLine}"
                result &= encryptedChar
            Else
                result &= character
            End If
        Next

        explanation &= Environment.NewLine & result
        Return explanation
    End Function

    Private Function DecimationDecrypt(text As String, key As Integer) As String
        Dim result As String = ""
        Dim explanation As String = ""

        Dim inverseKey As Integer = ModularInverse(key, 26)

        If inverseKey = -1 Then
            Return $"Key {key} has no modular inverse mod 26. Cannot decrypt."
        End If

        For Each character As Char In text
            If Char.IsLetter(character) Then
                Dim asciiStart As Integer = If(Char.IsUpper(character), Asc("A"c), Asc("a"c))
                Dim position As Integer = Asc(character) - asciiStart
                Dim originalPosition As Integer = (inverseKey * position) Mod 26
                Dim decryptedChar As Char = Chr(asciiStart + originalPosition)

                explanation &= $"{character} -> {decryptedChar} (D({position}) = {inverseKey} * {position} mod 26 = {originalPosition}){Environment.NewLine}"
                result &= decryptedChar
            Else
                result &= character
            End If
        Next

        explanation &= Environment.NewLine & result
        Return explanation
    End Function


    Private Function ModularInverse(a As Integer, modBase As Integer) As Integer
        For x As Integer = 1 To modBase - 1
            If (a * x) Mod modBase = 1 Then
                Return x
            End If
        Next
        Return -1
    End Function

End Class