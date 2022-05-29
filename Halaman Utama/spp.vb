Imports System.Data.Odbc
Public Class spp

    Sub tampildgv()
        koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tblspp", Conn)
        ds = New DataSet
        Da.Fill(Ds, "tblspp")
        Me.DGV.DataSource = (Ds.Tables("tblspp"))
    End Sub

    Sub munculnis()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New OdbcCommand("select * from tblsiswa", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub


    Sub munculidadm()
        Call Koneksi()
        ComboBox2.Items.Clear()
        Cmd = New OdbcCommand("select * from tbladm", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox2.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Sub kosongkan()
        TextBox1.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        ComboBox1.Text = ""
        TextBox5.Clear()
        TextBox6.Clear()
        ComboBox2.Text = ""
    End Sub

    Private Sub spp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampildgv()
        Koneksi()
        munculnis()
        munculidadm()
    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        TextBox1.Text = DGV.Item(0, i).Value
        TextBox3.Text = DGV.Item(2, i).Value
        ComboBox1.Text = DGV.Item(3, i).Value
        TextBox5.Text = DGV.Item(4, i).Value
        TextBox6.Text = DGV.Item(5, i).Value
        ComboBox2.Text = DGV.Item(6, i).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or DateTimePicker1.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("ISI SEMUA DATA DENGAN LENGKAP!")
        Else
            Koneksi()
            sql1 = "INSERT into tblspp values (" + "'" & TextBox1.Text & "', " + "'" & DateTimePicker1.Text & "', " + "'" & TextBox3.Text & "', " + "'" & ComboBox1.Text & "', " + "'" & TextBox5.Text & "', " + "'" & TextBox6.Text & "', " + "'" & ComboBox2.Text & "')"
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()
            Conn.Close()
            DGV.Refresh()

            kosongkan()
            tampildgv()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or DateTimePicker1.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("PILIH DATA YANG INGIN DI HAPUS!")
        Else
            Koneksi()
            sql1 = "DELETE from tblspp WHERE no_kw = '" & TextBox1.Text & "' ;"
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()
            DGV.Refresh()

            tampildgv()
            kosongkan()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or DateTimePicker1.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox5.Text = "" Or TextBox6.Text = "" Or ComboBox2.Text = "" Then
            MsgBox("PILIH DATA YANG INGIN DI UBAH!")
        Else
            Koneksi()
            sql1 = "UPDATE tblspp SET no_kw = '" & TextBox1.Text & "', tgl_kw = '" & DateTimePicker1.Text & "', bulan = '" & TextBox3.Text & "', nis = '" & ComboBox1.Text & "', jumlah = '" & TextBox5.Text & "', keterangan = '" & TextBox6.Text & "', id_adm = '" & ComboBox2.Text & "' where no_kw = '" & TextBox1.Text & "'; "
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()

            tampildgv()
            kosongkan()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        kosongkan()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class