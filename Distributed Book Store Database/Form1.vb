Public Class Form1
    Public Shared Base As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Base = 1
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Base = 2
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Base = 3
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Site3DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter2.Fill(Me.Site3DataSet.stock)
        'TODO: This line of code loads data into the 'Site2DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter1.Fill(Me.Site2DataSet.stock)
        'TODO: This line of code loads data into the 'Site1DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.Site1DataSet.stock)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = StockTableAdapter.ScalarQuery()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox2.Text = StockTableAdapter1.ScalarQuery()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox3.Text = StockTableAdapter2.ScalarQuery()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox4.Text = Val(StockTableAdapter.ScalarQuery() + StockTableAdapter1.ScalarQuery() + StockTableAdapter2.ScalarQuery())
    End Sub
End Class
