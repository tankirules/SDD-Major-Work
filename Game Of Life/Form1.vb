Imports System.IO
Imports System.Text

Public Class Form1

    Dim Grid(50, 50) As Panel
    Public Checked(50, 50) As Integer
    Dim SideLength As Integer
    Dim TempGrid(50, 50) As Integer
    Dim Started As Boolean
    Dim Outofbounds As Boolean
    Dim Username As String
    Dim password As String
    Dim uncheckedcolor, checkedcolor As Color
    Dim Timesupdated As Integer
    Dim isdown As Boolean
    Public puttinginpreset As Boolean
    Public closedproperlyinput As Boolean
    Dim outofboundssettingpreset As Boolean
    Public presetcoordslist As New List(Of Presetchooser.coords)
    Dim oldcoords As New List(Of Presetchooser.coords)
    Dim tempcoord As Presetchooser.coords
    Dim music As Boolean
    Dim musicchoice As Integer
    Dim firststart As Boolean
    Public checkedgridbeforesettingpreset As New List(Of Presetchooser.coords)
    Dim listofusernames As New List(Of String)
    Dim listofbuttons As New List(Of Button)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists(Presetchooser.Path) Then
        Else
            My.Computer.FileSystem.CreateDirectory("C:\Gameoflife")
            Dim fs As FileStream = File.Create(Presetchooser.Path)
        End If
        listofbuttons.Add(btnstartstop)
        listofbuttons.Add(btnmusic)
        listofbuttons.Add(btnreset)
        listofbuttons.Add(btnpreset)
        listofbuttons.Add(btnopen)
        listofbuttons.Add(btnsave)
        listofbuttons.Add(btnchangemusic)
        listofbuttons.Add(btncancelpresetplacement)
        listofbuttons.Add(Button3)
        listofbuttons.Add(Button1)
        For Each button In listofbuttons
            button.FlatAppearance.MouseOverBackColor = Color.Transparent
        Next



        lstboxsorted.HorizontalScrollbar = True
        Button3.Hide()
        btncancelpresetplacement.Hide()
        musicchoice = 0
        music = True
        firststart = True
        puttinginpreset = False
        isdown = False
        closedproperlyinput = False
        My.Computer.Audio.Play(My.Resources.weregilded, AudioPlayMode.BackgroundLoop)
        Timesupdated = 0
        Tickspeedcalculator.Start()
        uncheckedcolor = Color.White
        checkedcolor = Color.Black
        Started = False
        SideLength = Me.Bounds.Height / 60
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y) = New Panel
                Grid(x, y).Location = New Point(x * SideLength, y * SideLength)
                Grid(x, y).Size = New Size(SideLength, SideLength)

                Grid(x, y).BackgroundImageLayout = ImageLayout.Zoom
                Grid(x, y).BackColor = uncheckedcolor
                Grid(x, y).BorderStyle = BorderStyle.FixedSingle
                Controls.Add(Grid(x, y))
                Checked(x, y) = 0
                TempGrid(x, y) = 0
                '0 Is Not checked, 1 Is checked - Set all squares To Not be checked
                AddHandler Grid(x, y).Click, AddressOf Grid_Select
                AddHandler Grid(x, y).MouseEnter, AddressOf Mouse_Enter
                AddHandler Grid(x, y).MouseDown, AddressOf Mouse_Down
            Next
        Next

    End Sub
    Private Sub Mouse_Down(sender As Object, e As MouseEventArgs)
        If e.Button = MouseButtons.Right Then
            If isdown = False Then
                isdown = True
            ElseIf isdown = True Then
                isdown = False
            End If
        End If
    End Sub
    Private Sub Grid_Select(sender As Object, e As EventArgs)
        Dim msgoutofbounds As Boolean
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        msgoutofbounds = False
        If puttinginpreset = True Then

            Grid(xpos, ypos).BackColor = Color.Black
            Checked(xpos, ypos) = 1
            For i = 0 To presetcoordslist.Count() - 1
                tempcoord = presetcoordslist(i)
                Try
                    Grid(xpos + tempcoord.xcoord, ypos + tempcoord.ycoord).BackColor = Color.Black
                    Checked(xpos + tempcoord.xcoord, ypos + tempcoord.ycoord) = 1
                Catch ex As Exception
                    outofboundssettingpreset = True

                    If msgoutofbounds = False Then
                        msgoutofbounds = True
                        MsgBox("Warning! Some cells may be out of bounds!")
                    End If

                End Try
            Next
            puttinginpreset = False
            Button3.Hide()
            btncancelpresetplacement.Hide()
            oldcoords.Clear()
        ElseIf isdown = True Then


        Else
            If Checked(xpos, ypos) = 0 Then
                Grid(xpos, ypos).BackColor = checkedcolor
                Checked(xpos, ypos) = 1
            ElseIf Checked(xpos, ypos) = 1 Then
                Grid(xpos, ypos).BackColor = uncheckedcolor
                Checked(xpos, ypos) = 0
            End If
        End If



    End Sub
    Private Sub Mouse_Enter(sender As Object, e As EventArgs)
        Dim xpos, ypos As Integer
        xpos = CInt(sender.location.x) / SideLength
        ypos = CInt(sender.location.y) / SideLength
        If puttinginpreset = True Then
            btnstartstop.Text = "Start"
            updatetimer.Stop()

            Dim tempoldcoord As Presetchooser.coords
            If firststart = True Then
                firststart = False
            ElseIf firststart = False Then
                For Each coord As Presetchooser.coords In oldcoords
                    Grid(coord.xcoord, coord.ycoord).BackColor = Color.White
                Next
            End If

            oldcoords.Clear()
            outofboundssettingpreset = False

            tempcoord.xcoord = xpos
            tempcoord.ycoord = ypos
            oldcoords.Add(tempcoord)

            Button3.Show()
            btncancelpresetplacement.Show()

            For i = 0 To checkedgridbeforesettingpreset.Count() - 1
                tempcoord = checkedgridbeforesettingpreset(i)
                Grid(tempcoord.xcoord, tempcoord.ycoord).BackColor = Color.Black
                Checked(tempcoord.xcoord, tempcoord.ycoord) = 1
            Next
            Grid(xpos, ypos).BackColor = Color.Yellow
            For i = 0 To presetcoordslist.Count() - 1
                tempcoord = presetcoordslist(i)
                Try
                    Grid(xpos + tempcoord.xcoord, ypos + tempcoord.ycoord).BackColor = Color.FromArgb(255, 34, 139, 34)
                    tempoldcoord.xcoord = xpos + tempcoord.xcoord
                    tempoldcoord.ycoord = ypos + tempcoord.ycoord
                    oldcoords.Add(tempoldcoord)
                Catch ex As Exception
                    outofboundssettingpreset = True
                End Try
            Next

            If outofboundssettingpreset = True Then
                For i = 0 To oldcoords.Count() - 1
                    Grid(oldcoords(i).xcoord, oldcoords(i).ycoord).BackColor = Color.Red
                Next
            End If

        ElseIf isdown Then
            Grid(xpos, ypos).BackColor = checkedcolor
            Checked(xpos, ypos) = 1
        End If

    End Sub

    Private Sub btnstartstop_Click(sender As Object, e As EventArgs) Handles btnstartstop.Click
        If puttinginpreset = True Then
            MsgBox("Place or cancel your preset before starting the timer!")
        Else
            If Started = False Then
                btnstartstop.Text = "Stop"
                Started = True
                updatetimer.Start()
            ElseIf Started = True Then
                btnstartstop.Text = "Start"
                Started = False
                updatetimer.Stop()
            End If
        End If

    End Sub
    Private Sub resetgrid()
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = uncheckedcolor
                Checked(x, y) = 0
                TempGrid(x, y) = 0
            Next
        Next
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        resetgrid()
    End Sub

    Private Sub updatetimer_Tick(sender As Object, e As EventArgs) Handles updatetimer.Tick
        Timesupdated = Timesupdated + 1
        Dim neighbours As Integer

        For x = 1 To 50
            For y = 1 To 50
                neighbours = 0
                If Checked(x, y) = 0 Then
                    Checkneighbours(x, y, neighbours)

                    If neighbours = 3 Then
                        TempGrid(x, y) = 1
                        'Console.WriteLine("Dead Cell Regenerated at :" + CStr(x) + " " + CStr(y))
                    End If
                ElseIf Checked(x, y) = 1 Then
                    Checkneighbours(x, y, neighbours)
                    'Console.WriteLine("checking live cell")
                    'Console.WriteLine("neighbours:" + CStr(neighbours))
                    If neighbours < 2 And neighbours >= 0 Then
                        TempGrid(x, y) = 0
                        'Console.WriteLine("Live Cell Killed at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours = 2 Or neighbours = 3 Then
                        TempGrid(x, y) = 1
                        'Console.WriteLine("Live Cell living at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours > 3 Then
                        TempGrid(x, y) = 0
                        'Console.WriteLine("Live Cell overpopulated at :" + CStr(x) + " " + CStr(y))
                    ElseIf neighbours < 0 Then
                        TempGrid(x, y) = 0
                    End If
                End If
            Next
        Next

        For x = 1 To 50
            For y = 1 To 50
                If TempGrid(x, y) = 0 Then
                    Checked(x, y) = 0
                    Grid(x, y).BackColor = uncheckedcolor
                ElseIf TempGrid(x, y) = 1 Then
                    Checked(x, y) = 1
                    Grid(x, y).BackColor = checkedcolor
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
            neighbours = -100
        Else
            neighbours = Checked(x - 1, y + 1) + Checked(x, y + 1) +
            Checked(x + 1, y + 1) + Checked(x - 1, y) + Checked(x + 1, y) +
            Checked(x - 1, y - 1) + Checked(x, y - 1) + Checked(x + 1, y - 1)

        End If

    End Sub

    Private Sub Speedcontrol_Scroll(sender As Object, e As EventArgs) Handles Speedcontrol.Scroll
        updatetimer.Interval = Speedcontrol.Value
        lbltimebetween.Text = Speedcontrol.Value
    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        updatetimer.Stop()
        btnstartstop.Text = "Start"
        Dim UPD As New InputUPDForm
        Dim tempx, tempy As String
        If UPD.ShowDialog(Me) <> DialogResult.Cancel And UPD.ClosedproperlyInput = True Then
            Username = UPD.txtusername.Text
            password = UPD.txtpassword.Text
            Dim SaveFile As New SaveFileDialog With {
            .Title = "Save Current board State",
            .Filter = "Grid State File|*.gsf|All files|*.*",
            .FileName = "Board_State"
        }
            If SaveFile.ShowDialog() <> DialogResult.Cancel Then
                Using FS As New IO.StreamWriter(SaveFile.FileName)
                    FS.WriteLine("Username:" + Username)
                    FS.WriteLine("Password:" + password)
                    For x = 1 To 50
                        For y = 1 To 50
                            If Checked(x, y) = 1 Then
                                If CStr(x).Length = 1 Then
                                    tempx = "0" + CStr(x)
                                Else
                                    tempx = x
                                End If
                                If CStr(y).Length = 1 Then
                                    tempy = "0" + CStr(y)
                                Else
                                    tempy = y
                                End If
                                FS.WriteLine(tempx + "," + tempy)
                            End If
                        Next
                    Next
                End Using
            End If
        Else
            MsgBox("Exporting Grid State Canceled")
        End If
    End Sub

    Private Sub btnopen_Click(sender As Object, e As EventArgs) Handles btnopen.Click
        updatetimer.Stop()
        btnstartstop.Text = "Start"
        For x = 1 To 50
            For y = 1 To 50
                TempGrid(x, y) = Checked(x, y)
                Checked(x, y) = 0
                Grid(x, y).BackColor = uncheckedcolor
            Next
        Next
        Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim strFileName As String
        Dim valid As Boolean
        Dim tempstring As String
        Dim tempx, tempy As String
        Dim loadedu, loadedp As String
        Dim enteredu, enteredp As String
        Dim UPD As New ValidateUPDForm
        Dim result As DialogResult
        Dim coordsvalid As Boolean
        valid = False
        tempx = ""
        tempy = ""
        fd.Title = "Load Saved Grid State"
        fd.InitialDirectory = "C:\"
        fd.Filter = "Grid State File|*.gsf|All files|*.*"
        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
            Dim loadedfile() As String = IO.File.ReadAllLines(strFileName)
            If loadedfile(0).Contains("Username:") And loadedfile(1).Contains("Password:") Then
                result = UPD.ShowDialog(Me)
                If result = Windows.Forms.DialogResult.OK And UPD.Closedproperlyvalidate = True Then
                    enteredu = UPD.txtusername.Text
                    enteredp = UPD.txtpassword.Text
                    loadedu = loadedfile(0)
                    loadedu = loadedu.Remove(0, 9)
                    loadedp = loadedfile(1)
                    loadedp = loadedp.Remove(0, 9)
                    If enteredu = loadedu And enteredp = loadedp Then
                        valid = True
                        For i = 2 To loadedfile.Length - 1
                            coordsvalid = True
                            tempx = ""
                            tempy = ""
                            tempstring = loadedfile(i)
                            If tempstring(2) <> "," Or tempstring.Length <> 5 Then
                                MsgBox("Loaded file has invalid coordinate format!")
                                valid = False
                                Exit For
                            Else
                                For h = 0 To 1
                                    If IsNumeric(tempstring(h)) = False Then
                                        coordsvalid = False
                                    End If
                                    tempx = tempx + tempstring(h)
                                Next
                                For g = 3 To 4
                                    If IsNumeric(tempstring(g)) = False Then
                                        coordsvalid = False
                                    End If
                                    tempy = tempy + tempstring(g)
                                Next
                                If coordsvalid = False Then
                                    valid = False
                                    MsgBox("Invalid coordinates! Loading Stopped!")
                                    Exit For
                                End If
                                If CInt(tempx) < 0 Or CInt(tempx) > 50 Or CInt(tempy) < 0 Or CInt(tempy) > 50 Then
                                    valid = False
                                    MsgBox("Coordinates out of range!")
                                    Exit For
                                End If

                                Checked(CInt(tempx), CInt(tempy)) = 1
                                Grid(CInt(tempx), CInt(tempy)).BackColor = checkedcolor
                            End If
                        Next
                    Else
                        MsgBox("Username/Password Incorrect!")
                        For x = 1 To 50
                            For y = 1 To 50
                                Checked(x, y) = TempGrid(x, y)
                                If Checked(x, y) = 1 Then
                                    Grid(x, y).BackColor = checkedcolor
                                End If
                            Next
                        Next
                    End If
                Else
                    MsgBox("Save file not loaded!")

                End If

            Else
                MsgBox("Loaded file has invalid Username/Password format!")

                valid = False
            End If
        End If
        If coordsvalid = False Or valid = False Then
            For x = 1 To 50
                For y = 1 To 50
                    Checked(x, y) = 0
                    Checked(x, y) = TempGrid(x, y)
                    If Checked(x, y) = 1 Then
                        Grid(x, y).BackColor = checkedcolor
                    Else
                        Grid(x, y).BackColor = uncheckedcolor
                    End If
                Next
            Next
        End If

        If valid = True Then
            listofusernames.Add(loadedu + "         at: " + strFileName)
            lstboxsorted.Items.Clear()
            listofusernames.Sort()
            For i = 0 To listofusernames.Count() - 1
                lstboxsorted.Items.Add("Username: " + listofusernames(i))
            Next
        End If



    End Sub


    Private Sub Tickspeedcalculator_Tick(sender As Object, e As EventArgs) Handles Tickspeedcalculator.Tick
        lbltickspeed.Text = CStr(Timesupdated)
        Timesupdated = 0
    End Sub

    Private Sub btnmusic_Click(sender As Object, e As EventArgs) Handles btnmusic.Click
        If music = True Then
            music = False
            lblmusicname.Text = "Music Stopped"
            btnmusic.BackgroundImage = My.Resources.nomusic
            My.Computer.Audio.Stop()
        ElseIf music = False Then
            music = True
            btnmusic.BackgroundImage = My.Resources.music
            If musicchoice = 0 Then
                My.Computer.Audio.Play(My.Resources.weregilded, AudioPlayMode.BackgroundLoop)
                lblmusicname.Text = "Now Playing: Weregilded"
            ElseIf musicchoice = 1 Then
                My.Computer.Audio.Play(My.Resources.chaser, AudioPlayMode.BackgroundLoop)
                lblmusicname.Text = "Now Playing: Chaser"
            End If

        End If
    End Sub

    Private Sub btnchangemusic_Click(sender As Object, e As EventArgs) Handles btnchangemusic.Click
        If musicchoice = 0 Then
            musicchoice = 1
            If music = True Then
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.chaser, AudioPlayMode.BackgroundLoop)
                lblmusicname.Text = "Now Playing: Chaser"
            End If
        ElseIf musicchoice = 1 Then
            musicchoice = 0
            If music = True Then
                My.Computer.Audio.Stop()
                My.Computer.Audio.Play(My.Resources.weregilded, AudioPlayMode.BackgroundLoop)
                lblmusicname.Text = "Now Playing: Weregilded"
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        btnpreset.PerformClick()
    End Sub

    Private Sub btncancelpresetplacement_Click(sender As Object, e As EventArgs) Handles btncancelpresetplacement.Click
        puttinginpreset = False
        Button3.Hide()
        btncancelpresetplacement.Hide()
        For x = 1 To 50
            For y = 1 To 50
                If Checked(x, y) = 0 Then
                    Grid(x, y).BackColor = uncheckedcolor
                Else
                    Grid(x, y).BackColor = checkedcolor
                End If
            Next
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        btncancelpresetplacement.PerformClick()
        Button3.Hide()
        btncancelpresetplacement.Hide()

    End Sub

    Private Sub btnpreset_Click(sender As Object, e As EventArgs) Handles btnpreset.Click
        Presetchooser.Show()
    End Sub
    Private Sub btnchangemusic_MouseEnter(sender As Object, e As EventArgs) Handles btnchangemusic.MouseEnter
        btnchangemusic.Font = New Font(btnchangemusic.Font.FontFamily, btnchangemusic.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub btnchangemusic_MouseLeave(sender As Object, e As EventArgs) Handles btnchangemusic.MouseLeave
        btnchangemusic.Font = New Font(btnchangemusic.Font.FontFamily, btnchangemusic.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub btnstartstop_MouseEnter(sender As Object, e As EventArgs) Handles btnstartstop.MouseEnter
        btnstartstop.Font = New Font(btnstartstop.Font.FontFamily, btnstartstop.Font.Size + 2, FontStyle.Bold)
    End Sub
    Private Sub btnstartstop_MouseLeave(sender As Object, e As EventArgs) Handles btnstartstop.MouseLeave
        btnstartstop.Font = New Font(btnstartstop.Font.FontFamily, btnstartstop.Font.Size - 2, FontStyle.Regular)
    End Sub
    Private Sub btnsave_MouseEnter(sender As Object, e As EventArgs) Handles btnsave.MouseEnter
        btnsave.Font = New Font(btnsave.Font.FontFamily, btnsave.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub btnsave_MouseLeave(sender As Object, e As EventArgs) Handles btnsave.MouseLeave
        btnsave.Font = New Font(btnsave.Font.FontFamily, btnsave.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub btnopen_MouseEnter(sender As Object, e As EventArgs) Handles btnopen.MouseEnter
        btnopen.Font = New Font(btnopen.Font.FontFamily, btnopen.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub btnopen_MouseLeave(sender As Object, e As EventArgs) Handles btnopen.MouseLeave
        btnopen.Font = New Font(btnopen.Font.FontFamily, btnopen.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub btnreset_MouseEnter(sender As Object, e As EventArgs) Handles btnreset.MouseEnter
        btnreset.Font = New Font(btnreset.Font.FontFamily, btnreset.Font.Size + 2, FontStyle.Bold)
    End Sub
    Private Sub btnreset_MouseLeave(sender As Object, e As EventArgs) Handles btnreset.MouseLeave
        btnreset.Font = New Font(btnreset.Font.FontFamily, btnreset.Font.Size - 2, FontStyle.Regular)
    End Sub
    Private Sub btncancelpresetplacement_MouseEnter(sender As Object, e As EventArgs) Handles btncancelpresetplacement.MouseEnter
        btncancelpresetplacement.Font = New Font(btncancelpresetplacement.Font.FontFamily, btncancelpresetplacement.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub btncancelpresetplacement_MouseLeave(sender As Object, e As EventArgs) Handles btncancelpresetplacement.MouseLeave
        btncancelpresetplacement.Font = New Font(btncancelpresetplacement.Font.FontFamily, btncancelpresetplacement.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Button1.Font = New Font(Button1.Font.FontFamily, Button1.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Button1.Font = New Font(Button1.Font.FontFamily, Button1.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub button3_MouseEnter(sender As Object, e As EventArgs) Handles Button3.MouseEnter
        Button3.Font = New Font(Button3.Font.FontFamily, Button3.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.Font = New Font(Button3.Font.FontFamily, Button3.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub btnpreset_MouseEnter(sender As Object, e As EventArgs) Handles btnpreset.MouseEnter
        btnpreset.Font = New Font(btnpreset.Font.FontFamily, btnpreset.Font.Size + 3, FontStyle.Bold)
    End Sub
    Private Sub btnpreset_MouseLeave(sender As Object, e As EventArgs) Handles btnpreset.MouseLeave
        btnpreset.Font = New Font(btnpreset.Font.FontFamily, btnpreset.Font.Size - 3, FontStyle.Regular)
    End Sub
    Private Sub btnmusic_MouseEnter(sender As Object, e As EventArgs) Handles btnmusic.MouseEnter
        btnmusic.Size = New Size(80, 80)
    End Sub
    Private Sub btnmusic_MouseLeave(sender As Object, e As EventArgs) Handles btnmusic.MouseLeave
        btnmusic.Size = New Size(64, 64)
    End Sub
End Class
