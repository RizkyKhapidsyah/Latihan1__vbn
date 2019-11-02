Public Class DemoAngka
    Private Sub DemoAngka_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With Me
            .Text = "Demo Angka"
            .LabelKelipatan.Text = "Proses Dengan Kelipatan:"
            .TextKelipatan.Text = "0"
            .ButtonProses.Text = "Pr&oses"
            .MaximizeBox = False
            .MinimizeBox = False
            .FormBorderStyle = FormBorderStyle.FixedSingle
            .StartPosition = FormStartPosition.CenterScreen
        End With
    End Sub

    Private Sub ButtonProses_Click(sender As Object, e As EventArgs) Handles ButtonProses.Click
        With ListBoxHasil.Items
            .Clear()
            .Add(1 + Val(TextKelipatan.Text))
            .Add(2 - Val(TextKelipatan.Text))
            .Add(3 * Val(TextKelipatan.Text))
            .Add(4 / Val(TextKelipatan.Text))
            .Add(5 ^ Val(TextKelipatan.Text))
            ListBoxHasil.SelectedIndex = 0
        End With
    End Sub
End Class
