

Imports System.Data.SqlClient
Public Class Form2


    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer



    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized


        con.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fevro\source\repos\Clubs Registration System\vbconnectionfinal.mdf;Integrated Security=True"



        If con.State = ConnectionState.Open Then
            con.Close()


        End If

        con.Open()



        disp_data()



    End Sub



    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "insert into tbl1 values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DateTimePicker1.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "')"
        cmd.ExecuteNonQuery()


        disp_data()


        MessageBox.Show("Recorded Successfully")




    End Sub


    Public Sub disp_data()

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from tbl1"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt







    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick


        Try
            If con.State = ConnectionState.Open Then
                con.Close()


            End If
            con.Open()

            i = Convert.ToInt32(DataGridView1.SelectedCells.Item(0).Value.ToString())

            cmd = con.CreateCommand()
            cmd.CommandType = CommandType.Text
            cmd.CommandText = "select * from tbl1 where id=" & i & ""
            cmd.ExecuteNonQuery()

            Dim dt As New DataTable()
            Dim da As New SqlDataAdapter(cmd)
            da.Fill(dt)
            Dim dr As SqlClient.SqlDataReader
            dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)


            While dr.Read
                TextBox1.Text = dr.GetString(1).ToString()
                TextBox2.Text = dr.GetString(2).ToString()

                TextBox3.Text = dr.GetString(3).ToString()
                TextBox4.Text = dr.GetString(4).ToString()
                TextBox5.Text = dr.GetString(5).ToString()
                TextBox6.Text = dr.GetString(6).ToString()
                TextBox7.Text = dr.GetString(7).ToString()

            End While




        Catch ex As Exception

        End Try




















    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If con.State = ConnectionState.Open Then
            con.Close()


        End If
        con.Open()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "update tbl1 set lastname='" + TextBox1.Text + "',firstname='" + TextBox2.Text + "',middlename='" + TextBox3.Text + "',age='" + TextBox4.Text + "',birthday='" + DateTimePicker1.Text + "',phonenum='" + TextBox5.Text + "',gradelevel='" + TextBox6.Text + "',category='" + TextBox7.Text + "' where id=" & i & ""
        cmd.ExecuteNonQuery()


        disp_data()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If con.State = ConnectionState.Open Then
            con.Close()


        End If
        con.Open()


        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "delete from tbl1 where lastname='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()



        disp_data()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        cmd = con.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "select * from tbl1 where lastname='" + TextBox1.Text + "'"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox7.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""

        TextBox7.Text = ""



    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Close()
    End Sub
End Class