Public Class Form2

    Private Sub CloseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub CloseToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseToolStripMenuItem1.Click
        Me.Close()
    End Sub

    Private Sub Form2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Up Then
            PictureBox2.Top = PictureBox2.Top - 5
        End If
        If e.KeyCode = Keys.Down Then
            PictureBox2.Top = PictureBox2.Top + 5
        End If
        If e.KeyCode = Keys.Left Then
            PictureBox2.Left = PictureBox2.Left - 5
        End If
        If e.KeyCode = Keys.Right Then
            PictureBox2.Left = PictureBox2.Left + 5
        End If
        Call WallBound()

    End Sub

    Private Sub WallBound()
        If PictureBox2.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            Call Code()
            Call Lives()

        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox6.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox8.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox9.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox10.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox17.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox20.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox22.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox23.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox24.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox25.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox26.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox27.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox28.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox29.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox30.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox31.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox32.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox33.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox34.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox35.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox36.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox37.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox39.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox40.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox41.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox42.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox43.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox44.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox45.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox46.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox47.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox48.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox49.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox50.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox51.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox52.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox53.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox54.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox55.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox56.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox57.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox58.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox59.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox60.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox61.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox62.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox63.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox64.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox65.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox66.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox67.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox68.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox69.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox70.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox71.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox72.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox73.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox74.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox75.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox76.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox77.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox78.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox79.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox80.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox81.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox82.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox83.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox84.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox85.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox86.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox87.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox88.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox89.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox90.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox91.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox92.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox93.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox94.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox95.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox96.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox97.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox98.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox99.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox100.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox101.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox102.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox103.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox104.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox105.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox106.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox107.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox108.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox109.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox110.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox111.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox112.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox113.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox114.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox115.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox116.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox117.Bounds) Then
            Call Code()
        End If
        If PictureBox2.Bounds.IntersectsWith(PictureBox118.Bounds) Then
            Call Code()
        End If


        If PictureBox2.Bounds.IntersectsWith(Label2.Bounds) Then
            MessageBox.Show("Continue to level 3", "Level 2 Completed")
            form6.show()
            Me.Hide()
        End If
    End Sub

    Private Sub Code()
        PictureBox2.Top = 112
        PictureBox2.Left = 27

    End Sub

    Private Sub Lives()
        PictureBox1.Visible = False
        PictureBox119.Visible = True
        PictureBox120.Visible = True
    End Sub
    Private Sub Lives2()
        PictureBox1.Visible = False
        PictureBox119.Visible = False
        PictureBox120.Visible = True
    End Sub
    Private Sub Lives3()
        PictureBox1.Visible = False
        PictureBox119.Visible = False
        PictureBox120.Visible = False
    End Sub
End Class
