Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        CheckBox3.Enabled = True
        CheckBox4.Enabled = True
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox4.Checked = False

    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        ListBox1.Items.Add(CheckBox1.Text)
        CheckBox1.Enabled = False
    End Sub
    Private Sub CheckBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.Click
        ListBox1.Items.Add(CheckBox2.Text)
        CheckBox2.Enabled = False
    End Sub
    Private Sub CheckBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.Click
        ListBox1.Items.Add(CheckBox3.Text)
        CheckBox3.Enabled = False
    End Sub
    Private Sub CheckBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.Click
        ListBox1.Items.Add(CheckBox4.Text)
        CheckBox4.Enabled = False
    End Sub
    Private Sub CheckBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.Click
        ListBox1.Items.Add(CheckBox5.Text)
        CheckBox5.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class