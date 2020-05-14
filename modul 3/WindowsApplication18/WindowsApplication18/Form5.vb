Public Class Form5

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("JANUARI")
        ComboBox1.Items.Add("FEBRUARI")
        ComboBox1.Items.Add("MARET")
        ComboBox1.Items.Add("APRIL")
        ComboBox1.Items.Add("MEI")
        ComboBox1.Items.Add("JUNI")
        ComboBox1.Items.Add("JULI")
        ComboBox1.Items.Add("AGUSTUS")
        ComboBox1.Items.Add("SEPTEMBER")
        ComboBox1.Items.Add("OKTOBER")
        ComboBox1.Items.Add("NOVEMBER")
        ComboBox1.Items.Add("DESEMBER")
        ComboBox2.Items.Add("1998")
        ComboBox2.Items.Add("1999")
        ComboBox2.Items.Add("2000")
        ComboBox2.Items.Add("2001")
        ComboBox2.Items.Add("2002")
    End Sub
    Dim JK As String

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            JK = RadioButton1.Text
        Else
            JK = RadioButton2.Text
        End If
        MsgBox("Nama :" & TextBox1.Text & vbCrLf & "Tanggal Lahir :" & TextBox2.Text & "_" & ComboBox1.Text & "_" & ComboBox2.Text & vbCrLf & "Jenis Kelamin :)" & JK & vbCrLf & "Alamat :" & TextBox3.Text)
    End Sub

    Private Sub Form5_MenuStart(sender As Object, e As EventArgs) Handles Me.MenuStart

    End Sub
End Class