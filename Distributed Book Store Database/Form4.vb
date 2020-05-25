Public Class Form4
    Dim ButtonClicked As String
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ButtonClicked = Button8.Text
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ButtonClicked = Button7.Text
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Site " & Form1.Base & ": Stock"
        'TODO: This line of code loads data into the 'Site3DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter2.Fill(Me.Site3DataSet.stock)
        'TODO: This line of code loads data into the 'Site2DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter1.Fill(Me.Site2DataSet.stock)
        'TODO: This line of code loads data into the 'Site1DataSet.stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.Site1DataSet.stock)
        If Form1.Base = 1 Then
            Me.DataGridView1.DataSource = Site1DataSet
            Me.DataGridView1.DataMember = StockBindingSource.DataMember
        ElseIf Form1.Base = 2 Then
            Me.DataGridView1.DataSource = Site2DataSet
            Me.DataGridView1.DataMember = StockBindingSource1.DataMember
        ElseIf Form1.Base = 3 Then
            Me.DataGridView1.DataSource = Site3DataSet
            Me.DataGridView1.DataMember = StockBindingSource2.DataMember
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.ReadOnly = True
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.ReadOnly = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.ReadOnly = True
        Try
            If Form1.Base = 1 Then
                StockTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text)
                MessageBox.Show("Data inserted!", "Message")
                Me.Site1DataSet.stock.AcceptChanges()
                Me.StockTableAdapter.Fill(Me.Site1DataSet.stock)
            ElseIf Form1.Base = 2 Then
                StockTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text)
                MessageBox.Show("Data inserted!", "Message")
                Me.Site2DataSet.stock.AcceptChanges()
                Me.StockTableAdapter1.Fill(Me.Site2DataSet.stock)
            ElseIf Form1.Base = 3 Then
                StockTableAdapter2.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text)
                MessageBox.Show("Data inserted!", "Message")
                Me.Site3DataSet.stock.AcceptChanges()
                Me.StockTableAdapter2.Fill(Me.Site3DataSet.stock)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
    End Sub

    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ButtonClicked = "OK" Then
            Form1.Show()
        Else
            Form3.Show()
        End If
    End Sub
End Class