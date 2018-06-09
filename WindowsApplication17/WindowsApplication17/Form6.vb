Public Class Form6
    Dim input
    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Form6_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            PictureBox1.Top = PictureBox1.Top - 5
        End If
        If e.KeyCode = Keys.Down Then
            PictureBox1.Top = PictureBox1.Top + 5
        End If
        If e.KeyCode = Keys.Left Then
            PictureBox1.Left = PictureBox1.Left - 5
        End If
        If e.KeyCode = Keys.Right Then
            PictureBox1.Left = PictureBox1.Left + 5
        End If
        Call WallBound()

    End Sub

    Private Sub WallBound()
        If PictureBox1.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            Call Code()


        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Call Code()
        End If
     

        If PictureBox1.Bounds.IntersectsWith(Label2.Bounds) Then
            MessageBox.Show("You Have Won The Game!", "Level 3 Completed")
            input = InputBox("Please Enter Your Name!")
            MsgBox("Thanks for Playin " & "Input")
            Form1.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Code()
        PictureBox1.Top = 66
        PictureBox1.Left = 19

    End Sub
End Class