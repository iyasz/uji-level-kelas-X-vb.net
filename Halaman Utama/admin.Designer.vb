<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.tid = New System.Windows.Forms.TextBox()
        Me.tna = New System.Windows.Forms.TextBox()
        Me.tpa = New System.Windows.Forms.TextBox()
        Me.tlp = New System.Windows.Forms.TextBox()
        Me.btntbmh = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnhps = New System.Windows.Forms.Button()
        Me.btnubah = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnccl = New System.Windows.Forms.Button()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV
        '
        Me.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV.Location = New System.Drawing.Point(127, 378)
        Me.DGV.Name = "DGV"
        Me.DGV.Size = New System.Drawing.Size(555, 156)
        Me.DGV.TabIndex = 8
        '
        'tid
        '
        Me.tid.Location = New System.Drawing.Point(161, 71)
        Me.tid.Name = "tid"
        Me.tid.Size = New System.Drawing.Size(177, 20)
        Me.tid.TabIndex = 9
        '
        'tna
        '
        Me.tna.Location = New System.Drawing.Point(161, 137)
        Me.tna.Name = "tna"
        Me.tna.Size = New System.Drawing.Size(177, 20)
        Me.tna.TabIndex = 10
        '
        'tpa
        '
        Me.tpa.Location = New System.Drawing.Point(470, 71)
        Me.tpa.Name = "tpa"
        Me.tpa.Size = New System.Drawing.Size(169, 20)
        Me.tpa.TabIndex = 11
        '
        'tlp
        '
        Me.tlp.Location = New System.Drawing.Point(470, 137)
        Me.tlp.Name = "tlp"
        Me.tlp.Size = New System.Drawing.Size(169, 20)
        Me.tlp.TabIndex = 12
        '
        'btntbmh
        '
        Me.btntbmh.BackColor = System.Drawing.Color.Transparent
        Me.btntbmh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btntbmh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btntbmh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntbmh.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btntbmh.ForeColor = System.Drawing.Color.Black
        Me.btntbmh.Location = New System.Drawing.Point(298, 219)
        Me.btntbmh.Name = "btntbmh"
        Me.btntbmh.Size = New System.Drawing.Size(225, 35)
        Me.btntbmh.TabIndex = 7
        Me.btntbmh.Text = "Tambah"
        Me.btntbmh.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.Transparent
        Me.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.Black
        Me.btnsave.Location = New System.Drawing.Point(139, 260)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(227, 35)
        Me.btnsave.TabIndex = 8
        Me.btnsave.Text = "Simpan"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnhps
        '
        Me.btnhps.BackColor = System.Drawing.Color.Transparent
        Me.btnhps.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnhps.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnhps.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnhps.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnhps.ForeColor = System.Drawing.Color.Black
        Me.btnhps.Location = New System.Drawing.Point(63, 301)
        Me.btnhps.Name = "btnhps"
        Me.btnhps.Size = New System.Drawing.Size(227, 35)
        Me.btnhps.TabIndex = 9
        Me.btnhps.Text = "Hapus"
        Me.btnhps.UseVisualStyleBackColor = False
        '
        'btnubah
        '
        Me.btnubah.BackColor = System.Drawing.Color.Transparent
        Me.btnubah.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnubah.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnubah.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnubah.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnubah.ForeColor = System.Drawing.Color.Black
        Me.btnubah.Location = New System.Drawing.Point(521, 301)
        Me.btnubah.Name = "btnubah"
        Me.btnubah.Size = New System.Drawing.Size(227, 35)
        Me.btnubah.TabIndex = 10
        Me.btnubah.Text = "Ubah"
        Me.btnubah.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Transparent
        Me.btnreset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnreset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnreset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreset.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.Black
        Me.btnreset.Location = New System.Drawing.Point(455, 260)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(227, 35)
        Me.btnreset.TabIndex = 11
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnccl
        '
        Me.btnccl.BackColor = System.Drawing.Color.Transparent
        Me.btnccl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnccl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btnccl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnccl.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnccl.ForeColor = System.Drawing.Color.Black
        Me.btnccl.Location = New System.Drawing.Point(296, 301)
        Me.btnccl.Name = "btnccl"
        Me.btnccl.Size = New System.Drawing.Size(227, 35)
        Me.btnccl.TabIndex = 12
        Me.btnccl.Text = "Batal"
        Me.btnccl.UseVisualStyleBackColor = False
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(237, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(834, 568)
        Me.Controls.Add(Me.btnubah)
        Me.Controls.Add(Me.btnccl)
        Me.Controls.Add(Me.tlp)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.tpa)
        Me.Controls.Add(Me.tna)
        Me.Controls.Add(Me.btnhps)
        Me.Controls.Add(Me.tid)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.btntbmh)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "admin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "admin"
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents tid As System.Windows.Forms.TextBox
    Friend WithEvents tna As System.Windows.Forms.TextBox
    Friend WithEvents tpa As System.Windows.Forms.TextBox
    Friend WithEvents tlp As System.Windows.Forms.TextBox
    Friend WithEvents btntbmh As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnhps As System.Windows.Forms.Button
    Friend WithEvents btnubah As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnccl As System.Windows.Forms.Button
End Class
