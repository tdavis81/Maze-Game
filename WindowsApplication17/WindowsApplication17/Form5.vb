Public Class Form5

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub
    Private Sub Form5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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
        If PictureBox1.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox30.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox31.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox32.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox33.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox34.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox35.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox36.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox37.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox39.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox40.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox41.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox42.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox43.Bounds) Then
            Call Code()
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox44.Bounds) Then
            Call Code()
        End If
      
        If PictureBox1.Bounds.IntersectsWith(Label2.Bounds) Then
            MessageBox.Show("Continue to level 2", "Level 1 Completed")
            Form2.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Code()
        PictureBox1.Top = 421
        PictureBox1.Left = 333

    End Sub
End Class