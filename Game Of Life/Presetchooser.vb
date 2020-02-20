Public Class Presetchooser
    Dim Grid(50, 50) As Panel
    Dim SideLength As Integer
    Dim presetchecked(50, 50) As Integer
    Dim closedproperlyinput As Boolean
    Dim preset0(50, 50) As Panel
    Dim preset1(50, 50) As Panel
    Dim preset2(50, 50) As Panel
    Dim preset3(50, 50) As Panel
    Dim preset4(50, 50) As Panel
    Dim preset5(50, 50) As Panel
    Dim smallgridlength As Integer

    Private Sub Presetchooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        smallgridlength = Me.Bounds.Height / 180
        closedproperlyinput = False
        SideLength = Me.Bounds.Height / 60
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y) = New Panel
                Grid(x, y).Location = New Point(x * SideLength, y * SideLength)
                Grid(x, y).Size = New Size(SideLength, SideLength)
                Grid(x, y).BackgroundImageLayout = ImageLayout.Zoom
                Grid(x, y).BackColor = Color.White
                Grid(x, y).BorderStyle = BorderStyle.FixedSingle
                Controls.Add(Grid(x, y))
                presetchecked(x, y) = 0
                AddHandler Grid(x, y).Click, AddressOf Grid_Select
            Next
        Next





    End Sub
    Private Sub Grid_Select(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        If presetChecked(xpos, ypos) = 0 Then
            Grid(xpos, ypos).BackColor = Color.Black
            presetchecked(xpos, ypos) = 1
        ElseIf presetChecked(xpos, ypos) = 1 Then
            Grid(xpos, ypos).BackColor = Color.White
            presetchecked(xpos, ypos) = 0
        End If


    End Sub


End Class