Public Class Form1

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim firstnum As Integer
        Dim secondnum As Integer

        firstnum = txtFirstnum.Text
        secondnum = txtSecondNum.Text

        lblAdd.Text = firstnum + secondnum


    End Sub
End Class
