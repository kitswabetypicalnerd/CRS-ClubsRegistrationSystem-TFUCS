Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        Timer3.Enabled = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Panel2.Height <= 48 Then
            Timer1.Start()
            Timer2.Stop()
        ElseIf Panel2.Height <= 161 Then
            Timer2.Start()
            Timer1.Stop()


        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If Panel2.Height >= 161 Then
            Timer2.Stop()
            Panel2.Height = 161
        Else
            Panel2.Height += (161 - Panel2.Height) / 5
        End If



    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If Panel2.Height <= 48 Then
            Timer2.Stop()
            Panel2.Height = 46
        Else
            Panel2.Height += (30 - Panel2.Height) / 5
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label3.Text = Date.Now.ToString("dd - MM - yyyy hh : mm : ss")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.Close()
    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) 








    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) 



    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) 

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
