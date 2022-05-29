Imports System.Data.Odbc
Public Class siswa

    Sub tampildgv()
        koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tblsiswa", Conn)
        ds = New DataSet
        Da.Fill(Ds, "tblsiswa")
        Me.DGV.DataSource = (Ds.Tables("tblsiswa"))
    End Sub

    Sub kosongkan()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub siswa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildgv()
        Koneksi()
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Laki Laki")
        ComboBox1.Items.Add("Perempuan")
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        TextBox1.Text = DGV.Item(0, i).Value
        TextBox2.Text = DGV.Item(1, i).Value
        ComboBox1.Text = DGV.Item(3, i).Value
        TextBox3.Text = DGV.Item(4, i).Value
        TextBox4.Text = DGV.Item(5, i).Value
        TextBox5.Text = DGV.Item(6, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or DateTimePicker1.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("ISI SEMUA DATA DENGAN LENGKAP!")
        Else


            Koneksi()
            sql1 = "INSERT into tblsiswa values (" + "'" & TextBox1.Text & "', " + "'" & TextBox2.Text & "', " + "'" & DateTimePicker1.Text & "', " + "'" & ComboBox1.Text & "', " + "'" & TextBox3.Text & "', " + "'" & TextBox4.Text & "', " + "'" & TextBox5.Text & "')"
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()
            Conn.Close()
            DGV.Refresh()

            kosongkan()
            tampildgv()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or DateTimePicker1.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("PILIH DATA YANG INGIN DI HAPUS!")
        Else
            Koneksi()
            sql1 = "DELETE from tblsiswa WHERE nis = '" & TextBox1.Text & "' ;"
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()
            DGV.Refresh()

            tampildgv()
            kosongkan()
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or DateTimePicker1.Text = "" Or ComboBox1.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("PILIH DATA YANG INGIN DI UBAH!")
        Else
            Koneksi()
            sql1 = "UPDATE tblsiswa SET nis = '" & TextBox1.Text & "', namawa = '" & TextBox2.Text & "', tahun = '" & DateTimePicker1.Text & "', jenis_kelamin = '" & ComboBox1.Text & "', alamat = '" & TextBox3.Text & "', wali = '" & TextBox4.Text & "', no_telp = '" & TextBox5.Text & "' where nis = '" & TextBox1.Text & "'; "
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()

            tampildgv()
            kosongkan()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kosongkan()
    End Sub
End Class