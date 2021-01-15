<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.buttonDelete = New System.Windows.Forms.Button()
        Me.buttonClear = New System.Windows.Forms.Button()
        Me.buttonSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtJudul_Buku = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtKode_Buku = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPenerbit_Buku = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTahun_Penerbit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.txtPenulis_Buku = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'buttonDelete
        '
        Me.buttonDelete.BackColor = System.Drawing.Color.Red
        Me.buttonDelete.FlatAppearance.BorderSize = 0
        Me.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonDelete.ForeColor = System.Drawing.Color.White
        Me.buttonDelete.Location = New System.Drawing.Point(181, 497)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(75, 30)
        Me.buttonDelete.TabIndex = 17
        Me.buttonDelete.Text = "Delete"
        Me.buttonDelete.UseVisualStyleBackColor = False
        '
        'buttonClear
        '
        Me.buttonClear.BackColor = System.Drawing.Color.Yellow
        Me.buttonClear.FlatAppearance.BorderSize = 0
        Me.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonClear.Location = New System.Drawing.Point(100, 497)
        Me.buttonClear.Name = "buttonClear"
        Me.buttonClear.Size = New System.Drawing.Size(75, 30)
        Me.buttonClear.TabIndex = 16
        Me.buttonClear.Text = "Clear"
        Me.buttonClear.UseVisualStyleBackColor = False
        '
        'buttonSave
        '
        Me.buttonSave.BackColor = System.Drawing.Color.Lime
        Me.buttonSave.FlatAppearance.BorderSize = 0
        Me.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.buttonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonSave.Location = New System.Drawing.Point(19, 497)
        Me.buttonSave.Name = "buttonSave"
        Me.buttonSave.Size = New System.Drawing.Size(75, 30)
        Me.buttonSave.TabIndex = 15
        Me.buttonSave.Text = "Save"
        Me.buttonSave.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(271, 71)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(310, 518)
        Me.DataGridView1.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Judul Buku"
        '
        'txtJudul_Buku
        '
        Me.txtJudul_Buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtJudul_Buku.Location = New System.Drawing.Point(17, 155)
        Me.txtJudul_Buku.Name = "txtJudul_Buku"
        Me.txtJudul_Buku.Size = New System.Drawing.Size(227, 26)
        Me.txtJudul_Buku.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Kode Buku"
        '
        'txtKode_Buku
        '
        Me.txtKode_Buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKode_Buku.Location = New System.Drawing.Point(17, 94)
        Me.txtKode_Buku.Name = "txtKode_Buku"
        Me.txtKode_Buku.Size = New System.Drawing.Size(100, 26)
        Me.txtKode_Buku.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Inventory Buku Perpustakaan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 546)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Umar Sahid"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 563)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "190511081"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 195)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 20)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Penulis Buku"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(13, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(109, 20)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Penerbit Buku"
        '
        'txtPenerbit_Buku
        '
        Me.txtPenerbit_Buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenerbit_Buku.Location = New System.Drawing.Point(17, 283)
        Me.txtPenerbit_Buku.Name = "txtPenerbit_Buku"
        Me.txtPenerbit_Buku.Size = New System.Drawing.Size(227, 26)
        Me.txtPenerbit_Buku.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(13, 324)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Tahun Penerbit"
        '
        'txtTahun_Penerbit
        '
        Me.txtTahun_Penerbit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTahun_Penerbit.Location = New System.Drawing.Point(17, 347)
        Me.txtTahun_Penerbit.Name = "txtTahun_Penerbit"
        Me.txtTahun_Penerbit.Size = New System.Drawing.Size(227, 26)
        Me.txtTahun_Penerbit.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(13, 387)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 20)
        Me.Label9.TabIndex = 27
        Me.Label9.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStok.Location = New System.Drawing.Point(17, 410)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(227, 26)
        Me.txtStok.TabIndex = 26
        '
        'txtPenulis_Buku
        '
        Me.txtPenulis_Buku.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPenulis_Buku.Location = New System.Drawing.Point(17, 218)
        Me.txtPenulis_Buku.Name = "txtPenulis_Buku"
        Me.txtPenulis_Buku.Size = New System.Drawing.Size(227, 26)
        Me.txtPenulis_Buku.TabIndex = 28
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 601)
        Me.Controls.Add(Me.txtPenulis_Buku)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtTahun_Penerbit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPenerbit_Buku)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.buttonDelete)
        Me.Controls.Add(Me.buttonClear)
        Me.Controls.Add(Me.buttonSave)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtJudul_Buku)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtKode_Buku)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents buttonDelete As System.Windows.Forms.Button
    Friend WithEvents buttonClear As System.Windows.Forms.Button
    Friend WithEvents buttonSave As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtJudul_Buku As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtKode_Buku As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPenerbit_Buku As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTahun_Penerbit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents txtPenulis_Buku As System.Windows.Forms.TextBox

End Class
