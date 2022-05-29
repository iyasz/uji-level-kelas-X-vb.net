Imports System.Data.Odbc
Public Class admin
        
    Sub tampildgv()
        koneksi()
        da = New OdbcDataAdapter("SELECT * FROM tbladm", conn)
        ds = New DataSet
        da.Fill(ds, "tbladm")
        Me.DGV.DataSource = (ds.Tables("tbladm"))
    End Sub

    Sub kosongkan()
        tid.Clear()
        tna.Clear()
        tpa.Clear()
        tlp.Clear()
    End Sub

    Sub aktifkan()
        tid.Enabled = True
        tna.Enabled = True
        tpa.Enabled = True
        tlp.Enabled = True

        btntbmh.Enabled = True
        btnsave.Enabled = True
        btnhps.Enabled = True
        btnubah.Enabled = True
        btnreset.Enabled = True
        btnccl.Enabled = True

    End Sub

    Sub noaktif()
        tid.Enabled = False
        tna.Enabled = False
        tpa.Enabled = False
        tlp.Enabled = False


        btnsave.Enabled = False
        btnhps.Enabled = False
        btnubah.Enabled = False
        btnreset.Enabled = False

    End Sub

    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampildgv()
        noaktif()
    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick
        Dim i As Integer
        i = DGV.CurrentRow.Index
        tid.Text = DGV.Item(0, i).Value
        tna.Text = DGV.Item(1, i).Value
        tpa.Text = DGV.Item(2, i).Value
        tlp.Text = DGV.Item(3, i).Value
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        If tid.Text = "" Or tna.Text = "" Or tpa.Text = "" Or tlp.Text = "" Then
            MsgBox("ISI SEMUA DATA DENGAN LENGKAP!")
        Else


            Koneksi()
            sql1 = "INSERT into tbladm values (" + "'" & tid.Text & "', " + "'" & tna.Text & "', " + "'" & tpa.Text & "', " + "'" & tlp.Text & "')"
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()
            Conn.Close()
            DGV.Refresh()

            noaktif()
            kosongkan()
            tampildgv()
        End If
    End Sub

    Private Sub btntbmh_Click(sender As Object, e As EventArgs) Handles btntbmh.Click
        aktifkan()
    End Sub

    Private Sub btnhps_Click(sender As Object, e As EventArgs) Handles btnhps.Click
        If tid.Text = "" Or tna.Text = "" Or tpa.Text = "" Or tlp.Text = "" Then
            MsgBox("PILIH DATA YANG INGIN DI HAPUS!")
        Else
            Koneksi()
            sql1 = "DELETE from tbladm WHERE idadm = '" & tid.Text & "' ;"
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()
            DGV.Refresh()

            tampildgv()
            kosongkan()
            noaktif()
        End If
    End Sub

    Private Sub btnubah_Click(sender As Object, e As EventArgs) Handles btnubah.Click
        If tid.Text = "" Or tna.Text = "" Or tpa.Text = "" Or tlp.Text = "" Then
            MsgBox("PILIH DATA YANG INGIN DI UBAH!")
            tid.Enabled = False

        Else
            Koneksi()
            sql1 = "UPDATE tbladm SET idadm = '" & tid.Text & "', namaadm = '" & tna.Text & "', passw = '" & tpa.Text & "', tlpadm = '" & tlp.Text & "' where idadm = '" & tid.Text & "'; "
            Cmd = New OdbcCommand(sql1, Conn)
            Cmd.ExecuteNonQuery()

            tampildgv()
            kosongkan()
            noaktif()
        End If
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        kosongkan()
    End Sub

    Private Sub btnccl_Click(sender As Object, e As EventArgs) Handles btnccl.Click
        noaktif()
        kosongkan()

    End Sub

End Class