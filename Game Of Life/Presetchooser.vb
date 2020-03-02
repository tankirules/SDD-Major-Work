Public Class Presetchooser
    Dim Grid(50, 50) As Panel
    Dim SideLength As Integer
    Dim presetchecked(50, 50) As Integer
    Dim closedproperlyinput As Boolean
    Dim preset6(50, 50) As Integer
    Dim preset1(50, 50) As Integer
    Dim preset2(50, 50) As Integer
    Dim preset3(50, 50) As Integer
    Dim preset4(50, 50) As Integer
    Dim preset5(50, 50) As Integer

    Dim cpreset1, cpreset2, cpreset3, cpreset4, cpreset5, cpreset6 As Boolean
    Dim centerbeingset As Boolean
    Dim radiobuttonlist As New List(Of RadioButton)
    Dim presetlist As New List(Of Array)

    Private Sub Presetchooser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        radiobuttonlist.Add(rbtnpreset1)
        radiobuttonlist.Add(rbtnpreset2)
        radiobuttonlist.Add(rbtnpreset3)
        radiobuttonlist.Add(rbtnpreset4)
        radiobuttonlist.Add(rbtnpreset5)
        radiobuttonlist.Add(rbtnpreset6)
        presetlist.Add(preset1)
        presetlist.Add(preset2)
        presetlist.Add(preset3)
        presetlist.Add(preset4)
        presetlist.Add(preset5)
        presetlist.Add(preset6)

        Dim arrayofpresests(6) As Integer
        Dim presetcountload As Integer
        presetcountload = 0
        centerbeingset = False
        cpreset1 = False
        cpreset2 = False
        cpreset3 = False
        cpreset4 = False
        cpreset5 = False
        cpreset6 = False
        Dim loadedfile() As String = IO.File.ReadAllLines("C:\Gameoflife\presets.txt")
        Dim presetlinelist As New List(Of Integer)
        Dim templist As New List(Of String)
        For i = 0 To loadedfile.Length - 1
            Console.WriteLine("Loaded file line: " + CStr(i) + " is " + loadedfile(i))
        Next

        If loadedfile(0).Contains("P1") Then
            presetlinelist.Add(0)
            presetcountload += 1
            Console.WriteLine("P1 exists!")
            For i = 1 To (loadedfile.Length() - 1)

                Console.WriteLine(loadedfile.Length())
                If loadedfile(i).Contains("P2") Then
                    If presetcountload = 1 Then
                        presetlinelist.Add(i)
                        presetcountload += 1
                        Console.WriteLine("P2 exists!")
                    Else
                        MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                        Console.WriteLine("Corrupt 2")
                        Exit For
                    End If
                End If
                If loadedfile(i).Contains("P3") Then
                    If presetcountload = 2 Then
                        presetlinelist.Add(i)
                        presetcountload += 1
                        Console.WriteLine("P3 exists!")
                    Else
                        MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                        Console.WriteLine("Corrupt 3")
                        Exit For
                    End If
                End If
                If loadedfile(i).Contains("P4") Then
                    If presetcountload = 3 Then
                        presetlinelist.Add(i)
                        presetcountload += 1
                        Console.WriteLine("P4 exists!")
                    Else
                        MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                        Console.WriteLine("Corrupt 4")
                        Exit For
                    End If
                End If
                If loadedfile(i).Contains("P5") Then
                    If presetcountload = 4 Then
                        presetlinelist.Add(i)
                        presetcountload += 1
                        Console.WriteLine("P5 exists!")
                    Else
                        MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                        Console.WriteLine("Corrupt 5")
                        Exit For
                    End If
                End If
                If loadedfile(i).Contains("P6") Then
                    If presetcountload = 5 Then
                        presetlinelist.Add(i)
                        presetcountload += 1
                        Console.WriteLine("P6 exists!")
                    Else
                        MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                        Console.WriteLine("Corrupt 6")
                        Exit For
                    End If
                End If
            Next
            If presetcountload = 6 Then
                Console.WriteLine("Loading successful! Loaded 6 presets")
            Else
                MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                Console.WriteLine(CStr(presetcountload))
                Console.WriteLine("at the end presetcountload wasnt 6")
            End If
        Else
            MsgBox("Preset lines in file corrupt! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
            Console.WriteLine("Corrupt because first line isn't P1")
            'if first line isn't P1
        End If



        For i = 0 To presetlinelist(0) - 1
            templist.Add(loadedfile(i))
        Next
        Dim ptemp1 As Object = templist.ToArray
        For i = 0 To ptemp1.length - 1
            ptemp1(i) = CStr(ptemp1(i))
        Next
        'put everything related to preset1 into array
        templist.Clear()

        For i = presetlinelist(1) To presetlinelist(2) - 1
            templist.Add(loadedfile(i))
        Next
        Dim ptemp2 As Object = templist.ToArray
        For i = 0 To ptemp2.length - 1
            ptemp2(i) = CStr(ptemp2(i))
        Next
        'put everything related to preset2 into array
        templist.Clear()

        For i = presetlinelist(2) To presetlinelist(3) - 1
            templist.Add(loadedfile(i))
        Next
        Dim ptemp3 As Object = templist.ToArray
        For i = 0 To ptemp3.length - 1
            ptemp3(i) = CStr(ptemp3(i))
        Next
        'put everything related to preset3 into array
        templist.Clear()

        For i = presetlinelist(3) To presetlinelist(4) - 1
            templist.Add(loadedfile(i))
        Next
        Dim ptemp4 As Object = templist.ToArray
        For i = 0 To ptemp4.length - 1
            ptemp4(i) = CStr(ptemp4(i))
        Next
        'put everything related topreset 4 into array
        templist.Clear()
        For i = presetlinelist(4) To presetlinelist(5) - 1
            templist.Add(loadedfile(i))
        Next
        Dim ptemp5 As Object = templist.ToArray
        For i = 0 To ptemp5.length - 1
            ptemp5(i) = CStr(ptemp5(i))
        Next
        templist.Clear()
        'put everything related to preset 5 into array
        For i = presetlinelist(5) To loadedfile.Length() - 1
            templist.Add(loadedfile(i))
        Next
        Dim ptemp6 As Object = templist.ToArray
        For i = 0 To ptemp6.length - 1
            ptemp6(i) = CStr(ptemp6(i))
        Next
        templist.Clear()
        Dim centercheck As String
        Dim ptemplist As New List(Of Array)
        ptemplist.Add(ptemp1)
        ptemplist.Add(ptemp2)
        ptemplist.Add(ptemp3)
        ptemplist.Add(ptemp4)
        ptemplist.Add(ptemp5)
        ptemplist.Add(ptemp6)

        For Each ptemparray As Array In ptemplist
            centercheck = ""
            If ptemparray.Length > 1 Then
                centercheck = ptemparray(1)
                If ptemparray(0) <> "c" Then
                    MsgBox("Center coordinates corrupt/do not exist! Recommend deleting C:\Gameoflife\presets.txt and restarting program!")
                End If
            End If
        Next
        For Each ptemparray As Array In ptemplist
            Dim tempx, tempy As String
            tempx = ""
            tempy = ""
            If ptemparray.Length > 1 Then

            End If
            If ptemparray.Length > 2 Then

            End If
        Next



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
        If centerbeingset = True Then
            If rbtnpreset1.Checked And cpreset1 = True Then
                centeralreadyset()
            ElseIf rbtnpreset2.Checked And cpreset2 = True Then
                centeralreadyset()
            ElseIf rbtnpreset3.Checked And cpreset3 = True Then
                centeralreadyset()
            ElseIf rbtnpreset4.Checked And cpreset4 = True Then
                centeralreadyset()
            ElseIf rbtnpreset5.Checked And cpreset5 = True Then
                centeralreadyset()
            ElseIf rbtnpreset6.Checked And cpreset6 = True Then
                centeralreadyset()

            Else
                Grid(xpos, ypos).BackColor = Color.Yellow
                presetchecked(xpos, ypos) = 2
                centerbeingset = False
                MsgBox("Center set!")
                btncenter.Text = "Set Center"
                If rbtnpreset1.Checked = True Then
                    cpreset1 = True
                ElseIf rbtnpreset2.Checked = True Then
                    cpreset2 = True
                ElseIf rbtnpreset3.Checked = True Then
                    cpreset3 = True
                ElseIf rbtnpreset4.Checked = True Then
                    cpreset4 = True
                ElseIf rbtnpreset5.Checked = True Then
                    cpreset5 = True
                ElseIf rbtnpreset6.Checked = True Then
                    cpreset6 = True



                End If


            End If
        Else
            If presetchecked(xpos, ypos) = 0 Then
                Grid(xpos, ypos).BackColor = Color.Black
                presetchecked(xpos, ypos) = 1
            ElseIf presetchecked(xpos, ypos) = 1 Then
                Grid(xpos, ypos).BackColor = Color.White
                presetchecked(xpos, ypos) = 0
            End If
        End If


    End Sub

    Private Sub btneditname_Click(sender As Object, e As EventArgs) Handles btneditname.Click
        For Each button In radiobuttonlist
            If button.Checked = True Then
                button.Text = InputBox("Enter name to change to ")
            End If
        Next

    End Sub
    Private Sub btnresetgrid_Click(sender As Object, e As EventArgs) Handles btnresetgrid.Click
        cleargrid()
        For x = 1 To 50
            For y = 1 To 50
                presetchecked(x, y) = 0
            Next
        Next
    End Sub

    Private Sub btnsavepreset_Click(sender As Object, e As EventArgs) Handles btnsavepreset.Click
        If rbtnpreset1.Checked = True And cpreset1 = True Then
            savepresettopreset()
        ElseIf rbtnpreset2.Checked = True And cpreset2 = True Then
            savepresettopreset()
        ElseIf rbtnpreset3.Checked = True And cpreset3 = True Then
            savepresettopreset()
        ElseIf rbtnpreset4.Checked = True And cpreset4 = True Then
            savepresettopreset()
        ElseIf rbtnpreset5.Checked = True And cpreset5 = True Then
            savepresettopreset()
        ElseIf rbtnpreset6.Checked = True And cpreset6 = True Then
            savepresettopreset()
        Else
            MsgBox("You have not set a center!")

        End If

    End Sub

    Private Sub rbtnpreset1_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset1.CheckedChanged
        cleargrid()
        If rbtnpreset1.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset1(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset1(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset2_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset2.CheckedChanged
        cleargrid()
        If rbtnpreset2.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset2(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset2(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset3_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset3.CheckedChanged
        cleargrid()
        If rbtnpreset3.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset3(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset4_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset4.CheckedChanged
        cleargrid()
        If rbtnpreset4.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset4(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset4(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset5_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset5.CheckedChanged
        cleargrid()
        If rbtnpreset5.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset5(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset5(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub rbtnpreset6_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnpreset6.CheckedChanged
        cleargrid()
        If rbtnpreset6.Checked Then
            For x = 1 To 50
                For y = 1 To 50
                    If preset6(x, y) = 1 Then
                        Grid(x, y).BackColor = Color.Black
                        presetchecked(x, y) = 1
                    ElseIf preset6(x, y) = 2 Then

                        Grid(x, y).BackColor = Color.Yellow
                        presetchecked(x, y) = 2
                    End If
                Next
            Next
        End If
    End Sub
    Private Sub cleargrid()
        For x = 1 To 50
            For y = 1 To 50
                Grid(x, y).BackColor = Color.White
                presetchecked(x, y) = 0
            Next
        Next
    End Sub
    Private Sub btncenter_Click(sender As Object, e As EventArgs) Handles btncenter.Click
        If centerbeingset = False Then
            btncenter.Text = "Cancel"
            centerbeingset = True
        ElseIf centerbeingset = True Then
            centerbeingset = False
            btncenter.Text = "Set Center"
        End If

    End Sub
    Private Sub savepresettopreset()
        Dim temppreset(50, 50) As Integer
        Dim buttonindex As Integer
        buttonindex = 0
        Array.Clear(temppreset, 0, temppreset.Length)
        For x = 1 To 50
            For y = 1 To 50
                If presetchecked(x, y) = 1 Then
                    For Each button In radiobuttonlist
                        If button.Checked = True Then
                            buttonindex = radiobuttonlist.IndexOf(button)
                            temppreset(x, y) = 1
                        End If
                    Next
                End If
                If presetchecked(x, y) = 2 Then
                    For Each button In radiobuttonlist
                        If button.Checked = True Then
                            buttonindex = radiobuttonlist.IndexOf(button)
                            temppreset(x, y) = 2
                        End If
                    Next
                End If
                'If presetchecked(x, y) = 1 Then
                '    If rbtnpreset1.Checked = True Then
                '        preset1(x, y) = 1
                '    ElseIf rbtnpreset2.Checked = True Then
                '        preset2(x, y) = 1
                '    ElseIf rbtnpreset3.Checked = True Then
                '        preset3(x, y) = 1
                '    ElseIf rbtnpreset4.Checked = True Then
                '        preset4(x, y) = 1
                '    ElseIf rbtnpreset5.Checked = True Then
                '        preset5(x, y) = 1
                '    ElseIf rbtnpreset6.Checked = True Then
                '        preset6(x, y) = 1

                '    End If
                'End If
                'If presetchecked(x, y) = 2 Then
                '    If rbtnpreset1.Checked = True Then
                '        preset1(x, y) = 2
                '    ElseIf rbtnpreset2.Checked = True Then
                '        preset2(x, y) = 2
                '    ElseIf rbtnpreset3.Checked = True Then
                '        preset3(x, y) = 2
                '    ElseIf rbtnpreset4.Checked = True Then
                '        preset4(x, y) = 2
                '    ElseIf rbtnpreset5.Checked = True Then
                '        preset5(x, y) = 2
                '    ElseIf rbtnpreset6.Checked = True Then
                '        preset6(x, y) = 2

                '    End If
                'End If
            Next
        Next
        For Each array In presetlist
            If presetlist.IndexOf(array) = buttonindex Then
                Array.Copy(temppreset, array, array.Length)
            End If
        Next

    End Sub
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim tempx, tempy As String
        Using FS As New IO.StreamWriter("C:\Gameoflife\presets.txt")
            'save preset1
            FS.WriteLine("P1" + rbtnpreset1.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset1(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset1(x, y) = 1 Then
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
            'save preset 2
            FS.WriteLine("P2" + rbtnpreset2.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset2(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset2(x, y) = 1 Then
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
            'save preset3
            FS.WriteLine("P3" + rbtnpreset3.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 1 Then
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
            'save preset 4
            FS.WriteLine("P4" + rbtnpreset4.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset3(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset4(x, y) = 1 Then
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
            'save preset 5
            FS.WriteLine("P5" + rbtnpreset5.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset5(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset5(x, y) = 1 Then
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
            'save preset 6
            FS.WriteLine("P6" + rbtnpreset6.Text)
            For x = 1 To 50
                For y = 1 To 50
                    If preset6(x, y) = 2 Then
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
                        FS.WriteLine("c" + tempx + "," + tempy)
                        Exit For
                    End If
                Next
            Next
            For x = 1 To 50
                For y = 1 To 50
                    If preset6(x, y) = 1 Then
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
    End Sub
    Private Sub centeralreadyset()
        btncenter.Text = "Set Center"
        centerbeingset = False
        MsgBox("You have already set a center for this preset!")
    End Sub
End Class