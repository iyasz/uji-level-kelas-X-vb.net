Imports System.Data.Odbc
Public Class login

    Sub txkosong()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Sub bukapilih()
        Form1.bp.Enabled = True
    End Sub

    Sub tutupbtn()
        Form1.Button1.Hide()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnShow.Hide()
        TextBox2.UseSystemPasswordChar = True
        TextBox1.Text = "yxe"
        TextBox2.Text = "wangy"
    End Sub

    Private Sub btncc_Click(sender As Object, e As EventArgs) Handles btncc.Click
        Me.Close()
        Call txkosong()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New OdbcCommand("Select * From tbladm where namaadm='" & TextBox1.Text & "' and passw='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            berhasil.Show()

            Call bukapilih()
            Call tutupbtn()
            Form1.Button2.Show()
            berhasil.Label2.Text = Rd!namaadm
            Call txkosong()
        Else
            MsgBox("Nama Admin Atau Password Anda Salah!")
        End If
    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click
        btnShow.Show()
        btnHide.Hide()
        TextBox2.UseSystemPasswordChar = False
    End Sub

    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        btnHide.Show()
        btnShow.Hide()
        TextBox2.UseSystemPasswordChar = True

    End Sub
End Class