Public Class Form1

    Private Sub TampilBuku()
        txtKode_Buku.Text = oBook.kode_buku
        txtJudul_Buku.Text = oBook.judul_buku
        txtPenulis_Buku.Text = oBook.penulis_buku
        txtPenerbit_Buku.Text = oBook.penerbit_buku
        txtTahun_Penerbit.Text = oBook.tahun_penerbit
        txtStok.Text = oBook.stok
    End Sub

    Private Sub Reload()
        oBook.GetAllData(DataGridView1)
    End Sub

    Private Sub SimpanDataBuku()
        oBook.kode_buku = txtKode_Buku.Text
        oBook.judul_buku = txtJudul_Buku.Text
        oBook.penulis_buku = txtPenulis_Buku.Text
        oBook.penerbit_buku = txtPenerbit_Buku.Text
        oBook.tahun_penerbit = txtTahun_Penerbit.Text
        oBook.stok = txtStok.Text
        oBook.Simpan()
        Reload()
        If (oBook.InsertState = True) Then
            MessageBox.Show("Data Berhasil Disimpan")
        ElseIf (oBook.UpdateState = True) Then
            MessageBox.Show("Data berhasil diubah")
        Else
            MessageBox.Show("Data gagal disimpan")
        End If
    End Sub

    Private Sub ClearEntry()
        txtKode_Buku.Clear()
        txtJudul_Buku.Clear()
        txtPenulis_Buku.Clear()
        txtPenerbit_Buku.Clear()
        txtTahun_Penerbit.Clear()
        txtStok.Clear()
        txtKode_Buku.Focus()
    End Sub



    Private Sub Hapus()
        If (newBook = False And txtKode_Buku.Text <> "") Then
            oBook.Hapus(txtKode_Buku.Text)
            ClearEntry()
            Reload()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reload()
    End Sub

    Private Sub inputKodeBuku_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtKode_Buku.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            oBook.CariBuku(txtKode_Buku.Text)
            If (newBook = False) Then
                TampilBuku()
            Else
                MessageBox.Show("Data tidak ditemukan")
            End If
        End If
    End Sub


    Private Sub buttonDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonDelete.Click
        Dim jawab As Integer
        jawab = MessageBox.Show("Apakah Data akan dihapus", "Confirm", MessageBoxButtons.YesNo)
        If (jawab = vbYes) Then
            Hapus()
        Else
            MessageBox.Show("Data batal dihapus")
        End If
    End Sub

    Private Sub buttonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonClear.Click
        ClearEntry()
    End Sub

    Private Sub buttonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonSave.Click
        If (txtKode_Buku.Text <> "" And txtJudul_Buku.Text <> "") Then
            SimpanDataBuku()
            ClearEntry()
            Reload()

        Else
            MessageBox.Show("Kode Buku dan Nama Buku tidak boleh kosong!")
        End If
    End Sub

End Class
