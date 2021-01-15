Public Class Book
    Dim strsql As String
    Dim info As String
    Private _id_buku As Integer
    Private _kode_buku As String
    Private _judul_buku As String
    Private _penulis_buku As String
    Private _penerbit_buku As String
    Private _tahun_penerbit As String
    Private _stok As Integer
    Public InsertState As Boolean = False
    Public UpdateState As Boolean = False
    Public DeleteState As Boolean = False

    Public Property kode_buku()
        Get
            Return _kode_buku
        End Get
        Set(ByVal value)
            _kode_buku = value
        End Set
    End Property

    Public Property judul_buku()
        Get
            Return _judul_buku
        End Get
        Set(ByVal value)
            _judul_buku = value
        End Set
    End Property

    Public Property penulis_buku()
        Get
            Return _penulis_buku
        End Get
        Set(ByVal value)
            _penulis_buku = value
        End Set
    End Property

    Public Property penerbit_buku()
        Get
            Return _penerbit_buku
        End Get
        Set(ByVal value)
            _penerbit_buku = value
        End Set
    End Property

    Public Property tahun_penerbit()
        Get
            Return _tahun_penerbit
        End Get
        Set(ByVal value)
            _tahun_penerbit = value
        End Set
    End Property

    Public Property stok()
        Get
            Return _stok
        End Get
        Set(ByVal value)
            _stok = value
        End Set
    End Property


    Public Sub Simpan()
        DBConnect()
        If (newBook = True) Then
            strsql = "insert into bookdatabase(kode_buku, judul_buku, penulis_buku, penerbit_buku, tahun_penerbit, stok) values ('" & _kode_buku & "','" & _judul_buku & "','" & _penulis_buku & "','" & _penerbit_buku & "','" & _tahun_penerbit & "','" & _stok & "')"
            info = "INSERT"
        Else
            strsql = "update bookdatabase set kode_buku='" & _kode_buku & "', nama_book='" & _judul_buku & "' where kode_book='" & _kode_buku & "'"
            info = "UPDATE"
        End If
        mycommand.Connection = conn
        mycommand.CommandText = strsql

        Try
            mycommand.ExecuteNonQuery()
        Catch ex As Exception
            If (info = "INSERT") Then
                InsertState = False
            ElseIf (info = "UPDATE") Then
                UpdateState = False
            Else

            End If
        Finally
            If (info = "INSERT") Then
                InsertState = True
            ElseIf (info = "UPDATE") Then
                UpdateState = True
            Else

            End If
        End Try
        DBDisconnect()
    End Sub

    Public Sub CariBuku(ByVal skode_buku As String)
        DBConnect()
        strsql = "select * from bookdatabase where kode_buku='" & skode_buku & "'"
        mycommand.Connection = conn
        mycommand.CommandText = strsql
        Try
            DR = mycommand.ExecuteReader
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        If (DR.HasRows = True) Then
            newBook = False
            DR.Read()
            kode_buku = Convert.ToString((DR("kode_buku")))
            judul_buku = Convert.ToString((DR("judul_buku")))
            penulis_buku = Convert.ToString((DR("penulis_buku")))
            penerbit_buku = Convert.ToString((DR("penerbit_buku")))
            tahun_penerbit = Convert.ToString((DR("tahun_penerbit")))
            stok = Convert.ToString((DR("stok")))
        Else
            newBook = True
        End If
        DBDisconnect()
    End Sub

    Public Sub Hapus(ByVal skode_buku As String)
        DBConnect()
        strsql = "delete from bookdatabase where kode_buku='" & skode_buku & "'"
        info = "DELETE"
        mycommand.Connection = conn
        mycommand.CommandText = strsql
        Try
            mycommand.ExecuteNonQuery()
            DeleteState = True
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
        DBDisconnect()
    End Sub

    Public Sub GetAllData(ByVal dg As DataGridView)
        Try
            DBConnect()
            strsql = "select * from bookdatabase"
            mycommand.Connection = conn
            mycommand.CommandText = strsql
            mydata.Clear()
            myadapter.SelectCommand = mycommand
            myadapter.Fill(mydata)
            With dg
                .DataSource = mydata
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .ReadOnly = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            DBDisconnect()
        End Try
    End Sub
End Class
