Public Class Form1
    Dim Grid(50, 50) As Button
    Dim Cells(50, 50) As Integer
    Dim SideLength As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SideLength = Me.Bounds.Height / 60
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y) = New Button
                Grid(x, y).Location = New Point(x * SideLength, y * SideLength)
                Grid(x, y).Size = New Size(SideLength, SideLength)
                Grid(x, y).FlatStyle = FlatStyle.Flat
                Grid(x, y).BackgroundImageLayout = ImageLayout.Zoom
                Grid(x, y).BackColor = Color.White
                Controls.Add(Grid(x, y))
                AddHandler Grid(x, y).Click, AddressOf Grid_Select
            Next
        Next

    End Sub
End Class
