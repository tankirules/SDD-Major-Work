Public Class Form1
    Dim Grid(50, 50) As Label
    Dim Checked(50, 50, 2) As Integer
    Dim SideLength As Integer
    Dim TempGrid(50, 50, 2) As Integer
    Dim Started As Boolean
    Dim Outofbounds As Boolean
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Started = False
        SideLength = Me.Bounds.Height / 60
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y) = New Label
                Grid(x, y).Location = New Point(x * SideLength, y * SideLength)
                Grid(x, y).Size = New Size(SideLength, SideLength)
                Grid(x, y).FlatStyle = FlatStyle.Flat
                Grid(x, y).BackgroundImageLayout = ImageLayout.Zoom
                Grid(x, y).BackColor = Color.White
                Grid(x, y).BorderStyle = BorderStyle.FixedSingle
                Controls.Add(Grid(x, y))
                Checked(x, y, 1) = 0
                TempGrid(x, y, 1) = 0
                '0 Is Not checked, 1 Is checked - Set all squares To Not be checked
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
        If Checked(xpos, ypos, 1) = 0 Then
            Grid(xpos, ypos).BackColor = Color.Black
            Checked(xpos, ypos, 1) = 1
            'Console.WriteLine("checked value " + "at " + CStr(xpos) + "and " + CStr(ypos))
        ElseIf Checked(xpos, ypos, 1) = 1 Then
            Grid(xpos, ypos).BackColor = Color.White
            Checked(xpos, ypos, 1) = 0
            'Console.WriteLine("unchecked value " + "at " + CStr(xpos) + "and " + CStr(ypos))
        End If


    End Sub

    Private Sub btnstartstop_Click(sender As Object, e As EventArgs) Handles btnstartstop.Click
        If Started = False Then
            btnstartstop.Text = "Stop"
            Started = True
            updatetimer.Start()
        ElseIf Started = True Then
            btnstartstop.Text = "Start"
            Started = False
            updatetimer.Stop()
        End If
    End Sub
    Private Sub resetgrid()
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = Color.White
                Checked(x, y, 1) = 0
                TempGrid(x, y, 1) = 0
            Next
        Next
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        resetgrid()
    End Sub

    Private Sub updatetimer_Tick(sender As Object, e As EventArgs) Handles updatetimer.Tick
        Dim neighbours As Integer

        For x = 1 To 50
            For y = 1 To 50
                neighbours = 0
                If Checked(x, y, 1) = 0 Then
                    Checkneighbours(x, y, neighbours)

                    If neighbours = 3 Then
                        TempGrid(x, y, 1) = 1
                        'Console.WriteLine("Dead Cell Regenerated at :" + CStr(x) + " " + CStr(y))
                    End If
                ElseIf Checked(x, y, 1) = 1 Then
                    Checkneighbours(x, y, neighbours)
                    'Console.WriteLine("checking live cell")
                    'Console.WriteLine("neighbours:" + CStr(neighbours))
                    If neighbours < 2 Then
                        TempGrid(x, y, 1) = 0
                        'Console.WriteLine("Live Cell Killed at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours = 2 Or neighbours = 3 Then
                        TempGrid(x, y, 1) = 1
                        'Console.WriteLine("Live Cell living at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours > 3 Then
                        TempGrid(x, y, 1) = 0
                        'Console.WriteLine("Live Cell overpopulated at :" + CStr(x) + " " + CStr(y))
                    End If
                End If
            Next
        Next

        For x = 1 To 50
            For y = 1 To 50
                If TempGrid(x, y, 1) = 0 Then
                    Checked(x, y, 1) = 0
                    Grid(x, y).BackColor = Color.White
                ElseIf TempGrid(x, y, 1) = 1 Then
                    Checked(x, y, 1) = 1
                    Grid(x, y).BackColor = Color.Black
                End If
            Next
        Next



    End Sub
    Private Sub Checkneighbours(ByVal x As Integer, y As Integer, ByRef neighbours As Integer)
        'If Checked(x, y, 1) = 1 Then
        '    Console.WriteLine(CStr(x) + " " + CStr(y) + " Is checked!")
        'End If
        Outofbounds = False
        If x - 1 < 1 Or x + 1 > 50 Or y - 1 < 1 Or y + 1 > 50 Then
            Outofbounds = True
        Else
            If Checked(x - 1, y + 1, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x, y + 1, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x + 1, y + 1, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x - 1, y, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x + 1, y, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x - 1, y - 1, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x, y - 1, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
            If Checked(x + 1, y - 1, 1) = 1 Then
                neighbours = neighbours + 1
                'Console.WriteLine("Neighbour Found!")
            End If
        End If



        If neighbours > 0 Then
            'Console.WriteLine("Total Neighbours for: " + CStr(x) + " " + CStr(y) + " is " + CStr(neighbours))
        End If



    End Sub

    Private Sub Speedcontrol_Scroll(sender As Object, e As EventArgs) Handles Speedcontrol.Scroll
        updatetimer.Interval = Speedcontrol.Value
    End Sub
End Class
