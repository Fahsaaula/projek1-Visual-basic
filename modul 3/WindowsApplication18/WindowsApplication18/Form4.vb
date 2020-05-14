Public Class Form4

    Dim type, fasi As String

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.CheckedChanged
        type = RadioButton1.Text
    End Sub
    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton2.CheckedChanged
        type = RadioButton2.Text
    End Sub
    Private Sub RadioButton3_CheckedChanged(ByValsender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged
        type = RadioButton3.Text
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label2.Text = type
        If CheckBox1.Checked = True Then
            ListBox1.Items.Add(CheckBox1.Text)
        End If
        If CheckBox2.Checked = True Then
            ListBox1.Items.Add(CheckBox2.Text)
        End If
        If CheckBox3.Checked = True Then
            ListBox1.Items.Add(CheckBox3.Text)
        End If
        If CheckBox4.Checked = True Then
            ListBox1.Items.Add(CheckBox4.Text)
        End If

        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form5.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Form5.Show()
    End Sub
End Class