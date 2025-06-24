Public Class MainForm
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub caesarBtn_Click(sender As Object, e As EventArgs) Handles caesarBtn.Click
        Me.Hide()
        Dim caesarForm As New CaesarCipherForm()
        caesarForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub decimationBtn_Click(sender As Object, e As EventArgs) Handles decimationBtn.Click
        Me.Hide()
        Dim decimationForm As New DecimationCipherForm()
        decimationForm.ShowDialog()
        Me.Show()
    End Sub

    Private Sub knapsackBtn_Click(sender As Object, e As EventArgs) Handles knapsackBtn.Click
        Me.Hide()
        Dim knapsackForm As New KnapsackForm()
        knapsackForm.ShowDialog()
        Me.Show()
    End Sub
End Class
