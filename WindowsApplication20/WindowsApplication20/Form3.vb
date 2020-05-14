Public Class Form3

    Dim sqlnya As String
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM table1", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "table1")
        DataGridView1.DataSource = DS.Tables("table1")
        DataGridView1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
    End Sub
    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        form1.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM table1 where nama like '%" & TextBox1.Text & "%'", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "table1")
        DataGridView1.DataSource = DS.Tables("table1")
    End Sub
End Class