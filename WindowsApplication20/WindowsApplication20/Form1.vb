Public Class form1


    Dim sqlnya, jk, gender As String
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM table1", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "table1")
       
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            jk = RadioButton1.Text
            gender = ("Laki-laki")
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            jk = RadioButton2.Text
            gender = ("Perempuan")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        sqlnya = "insert into table1 (nis,nama,jk) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & jk & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form2.TextBox2.Text = TextBox1.Text
        Form2.TextBox3.Text = TextBox2.Text
        Form2.TextBox4.Text = gender
        Me.Hide()
        Form2.Show()

    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sqlnya = "delete from table1 where nis='" & TextBox1.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terhapus")
        Call panggildata()
    End Sub

   
End Class
