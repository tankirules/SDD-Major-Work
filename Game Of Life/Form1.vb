Public Class Form1
    Dim Grid(50, 50) As Button
    Dim Cells(50, 50) As Integer
    Dim SideLength As Integer
    Dim TempGrid(50, 50) As Integer
    Dim Started As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Started = False
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
    Private Sub Grid_Select(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        lblx.Text = "X Pos: " + CStr(xpos)
        lbly.Text = "Y Pos: " + CStr(ypos)
    End Sub

    Private Sub btnstartstop_Click(sender As Object, e As EventArgs) Handles btnstartstop.Click
        If Started = False Then
            btnstartstop.Text = "Stop"
            Started = True
        ElseIf Started = True Then
            btnstartstop.Text = "Start"
            Started = False
        End If
    End Sub
End Class
