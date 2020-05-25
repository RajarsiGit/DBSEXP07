Public Class Form2
    Dim ButtonClicked As String
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        ButtonClicked = Button7.Text
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ButtonClicked = Button8.Text
        Me.Close()
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Site " & Form1.Base & ": Books"
        'TODO: This line of code loads data into the 'Site3DataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter2.Fill(Me.Site3DataSet.books)
        'TODO: This line of code loads data into the 'Site2DataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter1.Fill(Me.Site2DataSet.books)
        'TODO: This line of code loads data into the 'Site1DataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Site1DataSet.books)
        If Form1.Base = 1 Then
            Me.DataGridView1.DataSource = Site1DataSet
            Me.DataGridView1.DataMember = BooksBindingSource.DataMember
        ElseIf Form1.Base = 2 Then
            Me.DataGridView1.DataSource = Site2DataSet
            Me.DataGridView1.DataMember = BooksBindingSource1.DataMember
        ElseIf Form1.Base = 3 Then
            Me.DataGridView1.DataSource = Site3DataSet
            Me.DataGridView1.DataMember = BooksBindingSource2.DataMember
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.ReadOnly = True
        Try
            If Form1.Base = 1 Then
                BooksTableAdapter.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                MessageBox.Show("Data inserted!", "Message")
                Me.Site1DataSet.books.AcceptChanges()
                Me.BooksTableAdapter.Fill(Me.Site1DataSet.books)
            ElseIf Form1.Base = 2 Then
                BooksTableAdapter1.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                MessageBox.Show("Data inserted!", "Message")
                Me.Site2DataSet.books.AcceptChanges()
                Me.BooksTableAdapter1.Fill(Me.Site2DataSet.books)
            ElseIf Form1.Base = 3 Then
                BooksTableAdapter2.Insert(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                MessageBox.Show("Data inserted!", "Message")
                Me.Site3DataSet.books.AcceptChanges()
                Me.BooksTableAdapter2.Fill(Me.Site3DataSet.books)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.ReadOnly = True
        Try
            If Form1.Base = 1 Then
                BooksTableAdapter.Delete(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                MessageBox.Show("Data deleted!", "Message")
                Me.Site1DataSet.books.AcceptChanges()
                Me.BooksTableAdapter.Fill(Me.Site1DataSet.books)
            ElseIf Form1.Base = 2 Then
                BooksTableAdapter1.Delete(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                MessageBox.Show("Data deleted!", "Message")
                Me.Site2DataSet.books.AcceptChanges()
                Me.BooksTableAdapter1.Fill(Me.Site2DataSet.books)
            ElseIf Form1.Base = 3 Then
                BooksTableAdapter2.Delete(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text)
                MessageBox.Show("Data deleted!", "Message")
                Me.Site3DataSet.books.AcceptChanges()
                Me.BooksTableAdapter2.Fill(Me.Site3DataSet.books)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        DataGridView1.ReadOnly = True
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.ReadOnly = False
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If ButtonClicked = "OK" Then
            Form3.Show()
        Else
            Form1.Show()
        End If
    End Sub
End Class
