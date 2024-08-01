Public Class Form1
    Private Sub BtnOk_Click(sender As Object, e As EventArgs) Handles BtnOk.Click
        Dim Height As Int32 = NudHeightInCm.Value

        MessageBox.Show($"Your height is {Height} cm!")
    End Sub
End Class
