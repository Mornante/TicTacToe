Public Class PlayervsPlayer
    Dim X_or_O As String
    Dim RoundWinner As String = ""
    Dim XCounter As Double
    Dim OCounter As Double
    Private Sub PlayervsPlayer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'take away all the useless information when a new game has begun
        Try
            Label6.Visible = False
            Label7.Visible = False
            Label8.Visible = False
            Label9.Visible = False
            Label10.Visible = False
            Label14.Visible = False
            Label15.Visible = False

            Button12.Visible = False
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox1.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox5.Checked = False
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox7.Checked = False

        X_or_O = "X"
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        'deselect all the other checkboxes when this one is checked
        CheckBox6.Checked = False

        X_or_O = "O"
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        'reload the game 
        Try
            Me.Controls.Clear()
            InitializeComponent()
            PlayervsPlayer_Load(e, e)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'when you want to return to the previous page
        Try
            Me.Close()
            HomePage.Show()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'when this section is clicked
        Try
            If Button2.Text = "" Then
                Call Turn()
                Button2.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        'when this section is clicked
        Try
            If Button3.Text = "" Then
                Call Turn()
                Button3.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'when this section is clicked
        Try
            If Button4.Text = "" Then
                Call Turn()
                Button4.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        'when this section is clicked
        Try
            If Button7.Text = "" Then
                Call Turn()
                Button7.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        'when this section is clicked
        Try
            If Button6.Text = "" Then
                Call Turn()
                Button6.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'when this section is clicked
        Try
            If Button5.Text = "" Then
                Call Turn()
                Button5.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        'when this section is clicked
        Try
            If Button10.Text = "" Then
                Call Turn()
                Button10.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        'when this section is clicked
        Try
            If Button9.Text = "" Then
                Call Turn()
                Button9.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'when this section is clicked
        Try
            If Button8.Text = "" Then
                Call Turn()
                Button8.Text = X_or_O
                Call Winner()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'To make sure all the details are entered before the game starts
        Try
            If TextBox1.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Please Enter Both Players Names!")
            ElseIf CheckBox6.Checked = False And CheckBox7.Checked = False Then
                MsgBox("Please Select who will start!")
            ElseIf CheckBox1.Checked = False Xor CheckBox2.Checked = False Xor CheckBox3.Checked = False Xor CheckBox4.Checked = False Xor CheckBox5.Checked = False Then
                MsgBox("Please select how many rounds the game will be!")
            Else
                'if all the settigs are Correct the game will start
                Call GameStart()
                Button11.Visible = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub GameStart()
        'clear all the buttons value for when the game starts
        Try
            Button2.Text = ""
            Button3.Text = ""
            Button4.Text = ""
            Button5.Text = ""
            Button6.Text = ""
            Button7.Text = ""
            Button8.Text = ""
            Button9.Text = ""
            Button10.Text = ""
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'what round to display on the scoreboard depending on what the settings are
        Try
            If CheckBox1.Checked = True Then
                Label6.Visible = True

                Label14.Visible = True
                Label15.Visible = True
            ElseIf CheckBox2.Checked = True Then
                Label6.Visible = True
                Label7.Visible = True

                Label14.Visible = True
                Label15.Visible = True
            ElseIf CheckBox3.Checked = True Then
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True

                Label14.Visible = True
                Label15.Visible = True
            ElseIf CheckBox4.Checked = True Then
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True

                Label14.Visible = True
                Label15.Visible = True
            ElseIf CheckBox5.Checked = True Then
                Label6.Visible = True
                Label7.Visible = True
                Label8.Visible = True
                Label9.Visible = True
                Label10.Visible = True

                Label14.Visible = True
                Label15.Visible = True
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'to call the function for the game to start
        Try
            Call Turn()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Winner()
        'determine when a round has been won
        Try
            'if X has won
            If Button2.Text = "X" And Button3.Text = "X" And Button4.Text = "X" Then
                Button2.BackColor = Drawing.Color.Red
                Button3.BackColor = Drawing.Color.Red
                Button4.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button5.Text = "X" And Button6.Text = "X" And Button7.Text = "X" Then
                Button5.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button7.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button8.Text = "X" And Button9.Text = "X" And Button10.Text = "X" Then
                Button8.BackColor = Drawing.Color.Red
                Button9.BackColor = Drawing.Color.Red
                Button10.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button2.Text = "X" And Button7.Text = "X" And Button10.Text = "X" Then
                Button2.BackColor = Drawing.Color.Red
                Button7.BackColor = Drawing.Color.Red
                Button10.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button3.Text = "X" And Button6.Text = "X" And Button9.Text = "X" Then
                Button3.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button9.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button4.Text = "X" And Button5.Text = "X" And Button8.Text = "X" Then
                Button4.BackColor = Drawing.Color.Red
                Button5.BackColor = Drawing.Color.Red
                Button8.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button2.Text = "X" And Button6.Text = "X" And Button8.Text = "X" Then
                Button2.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button8.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()
            ElseIf Button4.Text = "X" And Button6.Text = "X" And Button10.Text = "X" Then
                Button4.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button10.BackColor = Drawing.Color.Red
                Label1.Text = TextBox1.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox1.Text
                XCounter = XCounter + 1
                Call rounds()

                'if O has won
            ElseIf Button2.Text = "O" And Button3.Text = "O" And Button4.Text = "O" Then
                Button2.BackColor = Drawing.Color.Red
                Button3.BackColor = Drawing.Color.Red
                Button4.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button5.Text = "O" And Button6.Text = "O" And Button7.Text = "O" Then
                Button5.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button7.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button8.Text = "O" And Button9.Text = "O" And Button10.Text = "O" Then
                Button8.BackColor = Drawing.Color.Red
                Button9.BackColor = Drawing.Color.Red
                Button10.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button2.Text = "O" And Button7.Text = "O" And Button10.Text = "O" Then
                Button2.BackColor = Drawing.Color.Red
                Button7.BackColor = Drawing.Color.Red
                Button10.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button3.Text = "O" And Button6.Text = "O" And Button9.Text = "O" Then
                Button3.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button9.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button4.Text = "O" And Button5.Text = "O" And Button8.Text = "O" Then
                Button4.BackColor = Drawing.Color.Red
                Button5.BackColor = Drawing.Color.Red
                Button8.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button2.Text = "O" And Button6.Text = "O" And Button8.Text = "O" Then
                Button2.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button8.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            ElseIf Button4.Text = "O" And Button6.Text = "O" And Button10.Text = "O" Then
                Button4.BackColor = Drawing.Color.Red
                Button6.BackColor = Drawing.Color.Red
                Button10.BackColor = Drawing.Color.Red
                Label1.Text = TextBox2.Text & " has Won the round"
                Button12.Visible = True
                RoundWinner = TextBox2.Text
                OCounter = OCounter + 1
                Call rounds()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub Turn()
        'to set the current player in the 'Turn' function
        Try
            Label1.Text = X_or_O & " 's turn to play"
            If X_or_O = "X" Then
                X_or_O = "O"
            ElseIf X_or_O = "O" Then
                X_or_O = "X"
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'when the next round starts game restarts
        Try
            'take the button away and display it when a round is done
            Button12.Visible = False

            'clear the previous round values
            Button2.Text = ""
            Button3.Text = ""
            Button4.Text = ""
            Button5.Text = ""
            Button6.Text = ""
            Button7.Text = ""
            Button8.Text = ""
            Button9.Text = ""
            Button10.Text = ""

            'return all buttons original colour
            Button2.BackColor = Drawing.Color.White
            Button3.BackColor = Drawing.Color.White
            Button4.BackColor = Drawing.Color.White
            Button5.BackColor = Drawing.Color.White
            Button6.BackColor = Drawing.Color.White
            Button7.BackColor = Drawing.Color.White
            Button8.BackColor = Drawing.Color.White
            Button9.BackColor = Drawing.Color.White
            Button10.BackColor = Drawing.Color.White

            'display whos turn it is to start
            Call Turn()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Public Sub rounds()
        'display winner of the round on the scoreboard
        Try
            If CheckBox1.Checked = True Then
                If Label6.Text = "Round 1          |       No Winner" Then
                    Label6.Text = "Round 1          |       " & RoundWinner
                    Button12.Visible = False
                    Button13.BackColor = Drawing.Color.Red
                    Label15.Text = RoundWinner
                End If
            ElseIf CheckBox2.Checked = True Then
                If Label6.Text = "Round 1          |       No Winner" Then
                    Label6.Text = "Round 1          |       " & RoundWinner
                ElseIf Label7.Text = "Round 2          |       No Winner" Then
                    Label7.Text = "Round 2          |       " & RoundWinner
                    Button12.Visible = False
                    Button13.BackColor = Drawing.Color.Red
                    If XCounter > OCounter Then
                        Label15.Text = TextBox1.Text
                    ElseIf XCounter < OCounter Then
                        Label15.Text = TextBox2.Text
                    ElseIf XCounter = OCounter Then
                        Label15.Text = "Draw"
                    End If
                End If
            ElseIf CheckBox3.Checked = True Then
                If Label6.Text = "Round 1          |       No Winner" Then
                    Label6.Text = "Round 1          |       " & RoundWinner
                ElseIf Label7.Text = "Round 2          |       No Winner" Then
                    Label7.Text = "Round 2          |       " & RoundWinner
                ElseIf Label8.Text = "Round 3          |       No Winner" Then
                    Label8.Text = "Round 3          |       " & RoundWinner
                    Button12.Visible = False
                    Button13.BackColor = Drawing.Color.Red
                    If XCounter > OCounter Then
                        Label15.Text = TextBox1.Text
                    ElseIf XCounter < OCounter Then
                        Label15.Text = TextBox2.Text
                    ElseIf XCounter = OCounter Then
                        Label15.Text = "Draw"
                    End If
                End If
            ElseIf CheckBox4.Checked = True Then
                If Label6.Text = "Round 1          |       No Winner" Then
                    Label6.Text = "Round 1          |       " & RoundWinner
                ElseIf Label7.Text = "Round 2          |       No Winner" Then
                    Label7.Text = "Round 2          |       " & RoundWinner
                ElseIf Label8.Text = "Round 3          |       No Winner" Then
                    Label8.Text = "Round 3          |       " & RoundWinner
                ElseIf Label9.Text = "Round 4          |       No Winner" Then
                    Label9.Text = "Round 4          |       " & RoundWinner
                    Button12.Visible = False
                    Button13.BackColor = Drawing.Color.Red
                    If XCounter > OCounter Then
                        Label15.Text = TextBox1.Text
                    ElseIf XCounter < OCounter Then
                        Label15.Text = TextBox2.Text
                    ElseIf XCounter = OCounter Then
                        Label15.Text = "Draw"
                    End If
                End If
            ElseIf CheckBox5.Checked = True Then
                If Label6.Text = "Round 1          |       No Winner" Then
                    Label6.Text = "Round 1          |       " & RoundWinner
                ElseIf Label7.Text = "Round 2          |       No Winner" Then
                    Label7.Text = "Round 2          |       " & RoundWinner
                ElseIf Label8.Text = "Round 3          |       No Winner" Then
                    Label8.Text = "Round 3          |       " & RoundWinner
                ElseIf Label9.Text = "Round 4          |       No Winner" Then
                    Label9.Text = "Round 4          |       " & RoundWinner
                ElseIf Label10.Text = "Round 5          |       No Winner" Then
                    Label10.Text = "Round 5          |       " & RoundWinner
                    Button12.Visible = False
                    Button13.BackColor = Drawing.Color.Red
                    If XCounter > OCounter Then
                        Label15.Text = TextBox1.Text
                    ElseIf XCounter < OCounter Then
                        Label15.Text = TextBox2.Text
                    ElseIf XCounter = OCounter Then
                        Label15.Text = "Draw"
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class