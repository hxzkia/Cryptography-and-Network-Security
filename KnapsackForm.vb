Public Class KnapsackForm
    Private Sub KnapsackCipherForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub privateKeyTB_TextChanged(sender As Object, e As EventArgs) Handles privateKeyTB.TextChanged
        UpdateResult()
    End Sub

    Private Sub nTB_TextChanged(sender As Object, e As EventArgs) Handles nTB.TextChanged
        UpdateResult()
    End Sub

    Private Sub mTB_TextChanged(sender As Object, e As EventArgs) Handles mTB.TextChanged
        UpdateResult()
    End Sub

    Private Sub encryptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles encryptBtn.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub decryptBtn_CheckedChanged(sender As Object, e As EventArgs) Handles decryptBtn.CheckedChanged
        UpdateResult()
    End Sub

    Private Sub UpdateResult()
        If String.IsNullOrWhiteSpace(transformTB.Text) OrElse
       String.IsNullOrWhiteSpace(privateKeyTB.Text) OrElse
       String.IsNullOrWhiteSpace(nTB.Text) OrElse
       String.IsNullOrWhiteSpace(mTB.Text) Then
            resultTB.Text = "Please fill in all fields."
            Return
        End If

        Dim input As String = transformTB.Text
        Dim privateKey As String = privateKeyTB.Text
        Dim n As Integer
        Dim m As Integer

        If Not Integer.TryParse(nTB.Text, n) OrElse Not Integer.TryParse(mTB.Text, m) Then
            resultTB.Text = "Invalid number in n or m."
            Return
        End If

        If encryptBtn.Checked Then
            resultTB.Text = KnapsackEncrypt(input, privateKey, n, m)
        Else
            resultTB.Text = KnapsackDecrypt(input, privateKey, n, m)
        End If
    End Sub

    Private Function KnapsackEncrypt(inputText As String, privateKeyText As String, n As Integer, m As Integer) As String
        Dim result As String = ""
        Dim explanation As String = ""

        Dim privateKey() As Integer
        Try
            privateKey = privateKeyText.Split(","c).Select(Function(s) CInt(s.Trim())).ToArray()
        Catch ex As Exception
            Return "Invalid private key format. Use comma-separated integers like: 2,3,7,14"
        End Try

        Dim keyLength As Integer = privateKey.Length
        Dim publicKey() As Integer = privateKey.Select(Function(x) (x * n) Mod m).ToArray()
        explanation &= $"Public Key: {{ {String.Join(", ", publicKey)} }}{Environment.NewLine}{Environment.NewLine}"

        For Each ch As Char In inputText
            Dim asciiValue As Integer = Asc(ch)
            Dim binary As String = Convert.ToString(asciiValue, 2).PadLeft(keyLength, "0"c)

            explanation &= $"Character: '{ch}' → ASCII: {asciiValue}{Environment.NewLine}"
            explanation &= $"Binary ({keyLength}-bit): {binary}{Environment.NewLine}"
            explanation &= $"Calculation:" & Environment.NewLine

            Dim cipherValue As Integer = 0
            For i As Integer = 0 To keyLength - 1
                Dim bit As Integer = CInt(binary(i).ToString())
                Dim product As Integer = bit * publicKey(i)
                cipherValue += product
                explanation &= $"Bit[{i}] = {bit} × PublicKey[{i}] = {publicKey(i)} → {product}{Environment.NewLine}"
            Next

            explanation &= $"Cryptogram: {cipherValue}{Environment.NewLine}{Environment.NewLine}"
            result &= cipherValue.ToString() & ", "
        Next

        explanation &= $"Cipher Text: {result.TrimEnd(","c)}"
        Return explanation
    End Function

    Private Function KnapsackDecrypt(cipherText As String, privateKeyText As String, n As Integer, m As Integer) As String
        Dim result As String = ""
        Dim explanation As String = ""

        Dim privateKey() As Integer
        Try
            privateKey = privateKeyText.Split(","c).Select(Function(s) CInt(s.Trim())).ToArray()
        Catch ex As Exception
            Return "Invalid private key format."
        End Try

        Dim keyLength As Integer = privateKey.Length
        If keyLength = 0 Then
            Return "Private key is empty."
        End If

        Dim inverse As Integer = ModularInverse(n, m)
        If inverse = -1 Then
            Return $"No modular inverse for n = {n} mod m = {m}."
        End If

        explanation &= $"Private Key: {String.Join(", ", privateKey)}{Environment.NewLine}"
        explanation &= $"Inverse of n ({n}) mod {m} = {inverse}{Environment.NewLine}{Environment.NewLine}"

        Dim values() As String = cipherText.Split(","c)

        For Each vals In values
            If String.IsNullOrWhiteSpace(vals) Then Continue For

            Dim c As Integer
            If Not Integer.TryParse(vals.Trim(), c) Then
                Return "Invalid input, make sure to separate numbers with commas."
            End If

            Dim sum As Integer = (c * inverse) Mod m
            explanation &= $"Encrypted Value: {c}{Environment.NewLine}"
            explanation &= $"Multiply by inverse: {c} * {inverse} mod {m} = {sum}{Environment.NewLine}"

            Dim binary(keyLength - 1) As Integer
            Dim remaining As Integer = sum

            For i As Integer = keyLength - 1 To 0 Step -1
                If privateKey(i) <= remaining Then
                    binary(i) = 1
                    remaining -= privateKey(i)
                Else
                    binary(i) = 0
                End If
            Next

            Dim binString As String = String.Join("", binary)
            explanation &= $"Binary: {binString}{Environment.NewLine}"

            Dim ascii As Integer = Convert.ToInt32(binString, 2)
            Dim ch As Char = Chr(ascii)
            explanation &= $"ASCII: {ascii} → Character: '{ch}'{Environment.NewLine}{Environment.NewLine}"

            result &= ch
        Next

        explanation &= $"Plain Text: {result}"
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