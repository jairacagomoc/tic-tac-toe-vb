Public Class Form1
    Dim random As Integer = 0
    Dim playerX As Integer = 0
    Dim playerO As Integer = 0
    Dim isXorO As Boolean

    Private Sub disAbler()
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False
        b_9.Enabled = False
    End Sub
    Private Sub score_X()
        If (b1.Text = "X" And b2.Text = "X" And b3.Text = "X") Then
            b1.BackColor = Color.IndianRed
            b2.BackColor = Color.IndianRed
            b3.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b1.Text = "X" And b4.Text = "X" And b7.Text = "X") Then
            b1.BackColor = Color.IndianRed
            b4.BackColor = Color.IndianRed
            b7.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b1.Text = "X" And b5.Text = "X" And b7.Text = "X") Then
            b1.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b7.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b1.Text = "X" And b5.Text = "X" And b_9.Text = "X") Then
            b1.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b_9.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b2.Text = "X" And b5.Text = "X" And b8.Text = "X") Then
            b2.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b8.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b3.Text = "X" And b6.Text = "X" And b_9.Text = "X") Then
            b3.BackColor = Color.IndianRed
            b6.BackColor = Color.IndianRed
            b_9.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b4.Text = "X" And b5.Text = "X" And b6.Text = "X") Then
            b4.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b6.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        ElseIf (b7.Text = "X" And b8.Text = "X" And b_9.Text = "X") Then
            b7.BackColor = Color.IndianRed
            b8.BackColor = Color.IndianRed
            b_9.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER X !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerX += 1
            scoreX.Text = playerX
        End If
    End Sub
    Private Sub score_O()
        If (b1.Text = "O" And b2.Text = "O" And b3.Text = "O") Then
            b1.BackColor = Color.IndianRed
            b2.BackColor = Color.IndianRed
            b3.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b1.Text = "O" And b4.Text = "O" And b7.Text = "O") Then
            b1.BackColor = Color.IndianRed
            b4.BackColor = Color.IndianRed
            b7.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b1.Text = "O" And b5.Text = "O" And b_9.Text = "O") Then
            b1.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b_9.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b1.Text = "O" And b5.Text = "O" And b7.Text = "O") Then
            b1.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b7.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b2.Text = "O" And b5.Text = "O" And b8.Text = "O") Then
            b2.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b8.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b3.Text = "O" And b6.Text = "O" And b_9.Text = "O") Then
            b3.BackColor = Color.IndianRed
            b6.BackColor = Color.IndianRed
            b_9.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b4.Text = "O" And b5.Text = "O" And b6.Text = "O") Then
            b4.BackColor = Color.IndianRed
            b5.BackColor = Color.IndianRed
            b6.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        ElseIf (b7.Text = "O" And b8.Text = "O" And b_9.Text = "O") Then
            b7.BackColor = Color.IndianRed
            b8.BackColor = Color.IndianRed
            b_9.BackColor = Color.IndianRed
            disAbler()
            MessageBox.Show("THE WINNER IS PLAYER O !!!", "TIC-TAC-TOE", MessageBoxButtons.OK, MessageBoxIcon.Information)
            playerO += 1
            scoreO.Text = playerO
        End If

    End Sub
    Private Sub newgame_()
        random = 0

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b_9.Enabled = True

        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b_9.Text = ""

        b1.BackColor = Color.Transparent
        b2.BackColor = Color.Transparent
        b3.BackColor = Color.Transparent
        b4.BackColor = Color.Transparent
        b5.BackColor = Color.Transparent
        b6.BackColor = Color.Transparent
        b7.BackColor = Color.Transparent
        b8.BackColor = Color.Transparent
        b_9.BackColor = Color.Transparent
    End Sub
    Private Sub reset_()
        random = 0
        playerO = 0
        playerX = 0

        scoreX.Text = playerX
        scoreO.Text = playerO

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b_9.Enabled = True

        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        b4.Text = ""
        b5.Text = ""
        b6.Text = ""
        b7.Text = ""
        b8.Text = ""
        b_9.Text = ""

        b1.BackColor = Color.Black
        b2.BackColor = Color.Black
        b3.BackColor = Color.Black
        b4.BackColor = Color.Black
        b5.BackColor = Color.Black
        b6.BackColor = Color.Black
        b7.BackColor = Color.Black
        b8.BackColor = Color.Black
        b_9.BackColor = Color.Black
    End Sub
    Private Sub exit_()
        Application.Exit()
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub b1_Click(sender As Object, e As EventArgs) Handles b1.Click
        random += 1
        If random Mod 2 = 0 Then
            b1.Text = "O"
            b1.Enabled = False
            isXorO = False
            score_O()
        Else
            b1.Text = "X"
            b1.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b2_Click(sender As Object, e As EventArgs) Handles b2.Click
        random += 1
        If random Mod 2 = 0 Then
            b2.Text = "O"
            b2.Enabled = False
            isXorO = False
            score_O()
        Else
            b2.Text = "X"
            b2.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b3_Click(sender As Object, e As EventArgs) Handles b3.Click
        random += 1
        If random Mod 2 = 0 Then
            b3.Text = "O"
            b3.Enabled = False
            isXorO = False
            score_O()
        Else
            b3.Text = "X"
            b3.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b4_Click(sender As Object, e As EventArgs) Handles b4.Click
        random += 1
        If random Mod 2 = 0 Then
            b4.Text = "O"
            b4.Enabled = False
            isXorO = False
            score_O()
        Else
            b4.Text = "X"
            b4.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b5_Click(sender As Object, e As EventArgs) Handles b5.Click
        random += 1
        If random Mod 2 = 0 Then
            b5.Text = "O"
            b5.Enabled = False
            isXorO = False
            score_O()
        Else
            b5.Text = "X"
            b5.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b6_Click(sender As Object, e As EventArgs) Handles b6.Click
        random += 1
        If random Mod 2 = 0 Then
            b6.Text = "O"
            b6.Enabled = False
            isXorO = False
            score_O()
        Else
            b6.Text = "X"
            b6.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b7_Click(sender As Object, e As EventArgs) Handles b7.Click
        random += 1
        If random Mod 2 = 0 Then
            b7.Text = "O"
            b7.Enabled = False
            isXorO = False
            score_O()
        Else
            b7.Text = "X"
            b7.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b8_Click(sender As Object, e As EventArgs) Handles b8.Click
        random += 1
        If random Mod 2 = 0 Then
            b8.Text = "O"
            b8.Enabled = False
            isXorO = False
            score_O()
        Else
            b8.Text = "X"
            b8.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub b_9_Click(sender As Object, e As EventArgs) Handles b_9.Click
        random += 1
        If random Mod 2 = 0 Then
            b_9.Text = "O"
            b_9.Enabled = False
            isXorO = False
            score_O()
        Else
            b_9.Text = "X"
            b_9.Enabled = False
            isXorO = True
            score_X()
        End If
    End Sub

    Private Sub newgame_Click(sender As Object, e As EventArgs) Handles newgame.Click
        MessageBox.Show("New Game!!!")
        newgame_()
    End Sub

    Private Sub reset_Click(sender As Object, e As EventArgs) Handles reset.Click
        MessageBox.Show("GAME RESET!!!")
        reset_()
    End Sub

    Private Sub exitgame_Click(sender As Object, e As EventArgs) Handles exitgame.Click
        Dim GameExit As DialogResult = MessageBox.Show("Are you sure you want to exit the game?", "TIC TAC TOE",
                                                         MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        If GameExit = DialogResult.Yes Then
            exit_()
        End If
    End Sub
End Class
