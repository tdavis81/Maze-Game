Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Label2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label2.MouseMove
        Label2.ForeColor = Color.Lime
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If Label2.ForeColor = Color.Lime Then
            Label2.ForeColor = Color.Red
        End If
        If Label3.ForeColor = Color.Lime Then
            Label3.ForeColor = Color.Red
        End If
        If Label4.ForeColor = Color.Lime Then
            Label4.ForeColor = Color.Red
        End If
        If Label5.ForeColor = Color.Lime Then
            Label5.ForeColor = Color.Red
        End If

    End Sub

    Private Sub PictureBox2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseMove
        If Label2.ForeColor = Color.Lime Then
            Label2.ForeColor = Color.Red
        End If
        If Label3.ForeColor = Color.Lime Then
            Label3.ForeColor = Color.Red
        End If
        If Label4.ForeColor = Color.Lime Then
            Label4.ForeColor = Color.Red
        End If
        If Label5.ForeColor = Color.Lime Then
            Label5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub GroupBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles GroupBox1.MouseMove
        If Label2.ForeColor = Color.Lime Then
            Label2.ForeColor = Color.Red
        End If
        If Label3.ForeColor = Color.Lime Then
            Label3.ForeColor = Color.Red
        End If
        If Label4.ForeColor = Color.Lime Then
            Label4.ForeColor = Color.Red
        End If
        If Label5.ForeColor = Color.Lime Then
            Label5.ForeColor = Color.Red
        End If
    End Sub

    Private Sub Label4_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label4.MouseMove
        Label4.ForeColor = Color.Lime
    End Sub

    Private Sub Label3_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label3.MouseMove
        Label3.ForeColor = Color.Lime
    End Sub

    Private Sub Label5_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Label5.MouseMove
        Label5.ForeColor = Color.Lime
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click
        Form4.Show()
        Me.Hide()

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Me.Close()

    End Sub
End Class
