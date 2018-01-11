Public Class Form1

    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        Dim VP() As String = IO.File.ReadAllLines("VPres.txt")
        Dim Prez() As String = IO.File.ReadAllLines("USPres.txt")

        Dim union() As String = Prez.Union(VP).ToArray
        Dim intersect() As String = Prez.Intersect(VP).ToArray
        Dim final() As String = union.Except(intersect).ToArray



        IO.File.WriteAllLines("Output.txt", final)
        MessageBox.Show(final.Count & " presidents or vice presidents (but not both)", "File Created")

    End Sub
End Class
