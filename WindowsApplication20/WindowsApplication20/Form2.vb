Public Class Form2

    Dim tot As Integer = 0
    Dim sqlnya, hasil As String
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
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub

   
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            tot += 1
        End If
        If CheckBox3.Checked = True Then
            tot += 1
        End If
        If CheckBox5.Checked = True Then
            tot += 1
        End If
        If CheckBox7.Checked = True Then
            tot += 1
        End If
        If CheckBox9.Checked = True Then
            tot += 1
        End If
        If CheckBox11.Checked = True Then
            tot += 1
        End If
        If CheckBox13.Checked = True Then
            tot += 1
        End If
        If CheckBox15.Checked = True Then
            tot += 1
        End If
        If CheckBox17.Checked = True Then
            tot += 1
        End If
        If CheckBox19.Checked = True Then
            tot += 1
        End If
        If CheckBox21.Checked = True Then
            tot += 1
        End If
        If CheckBox23.Checked = True Then
            tot += 1
        End If
        If CheckBox25.Checked = True Then
            tot += 1
        End If
        If CheckBox27.Checked = True Then
            tot += 1
        End If
        If CheckBox29.Checked = True Then
            tot += 1
        End If
        If CheckBox31.Checked = True Then
            tot += 1
        End If
        If CheckBox33.Checked = True Then
            tot += 1
        End If
        If CheckBox35.Checked = True Then
            tot += 1
        End If
        If CheckBox37.Checked = True Then
            tot += 1
        End If
        If CheckBox39.Checked = True Then
            tot += 1
        End If
        If CheckBox41.Checked = True Then
            tot += 1
        End If
        If tot < 8 Then
            hasil = "Resiko Rendah"
            MsgBox("Anda Beresiko Rendah")
        ElseIf tot < 15 Then
            hasil = "Resiko sedang"
            MsgBox("Andan lumayan beresiko")
        ElseIf tot > 14 Then
            hasil = "Beresiko Tinggi"
            MsgBox("Resiko anda tinggi")
        End If
        sqlnya = "insert into table1 (nis,nama,jk,hasil) values('" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & hasil & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
        TextBox1.Text = tot
        TextBox5.Text = hasil
    End Sub

    
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form3.Label6.Text = TextBox3.Text
        Form3.Label7.Text = TextBox2.Text
        Form3.Label8.Text = TextBox5.Text
        Me.Hide()
        Form3.Show()
    End Sub


  
End Class