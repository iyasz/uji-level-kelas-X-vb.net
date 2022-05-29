Public Class multiplatform

    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer

    Sub switchPanel(ByVal panel As Form)
        Panel2.Controls.Clear()
        panel.TopLevel = False
        Panel2.Controls.Add(panel)
        panel.Show()

    End Sub

    Private Sub multiplatform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        switchPanel(dashboard)
        dash.Show()
        adm.Hide()
        sswa.Hide()
        pay.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dash.Show()
        adm.Hide()
        pay.Hide()
        sswa.Hide()
        switchPanel(dashboard)

    End Sub
    Private Sub Panel1_MouseDown1(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        drag = True
        mousex = Cursor.Position.X - Me.Left
        mousey = Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseMove1(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If drag Then
            Me.Top = Cursor.Position.Y - mousey
            Me.Left = Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub Panel1_MouseUp1(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        drag = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(admin)
        dash.Hide()
        pay.Hide()
        sswa.Hide()
        adm.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        switchPanel(siswa)
        pay.Hide()
        dash.Hide()
        sswa.Show()
        adm.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        switchPanel(spp)
        pay.Show()
        dash.Hide()
        sswa.Hide()
        adm.Hide()
    End Sub
End Class