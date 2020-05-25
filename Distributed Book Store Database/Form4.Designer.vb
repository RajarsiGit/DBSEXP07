<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Site1DataSet = New Distributed_Book_Store_Database.site1DataSet()
        Me.Site2DataSet = New Distributed_Book_Store_Database.site2DataSet()
        Me.Site3DataSet = New Distributed_Book_Store_Database.site3DataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New Distributed_Book_Store_Database.site1DataSetTableAdapters.stockTableAdapter()
        Me.StockBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter1 = New Distributed_Book_Store_Database.site2DataSetTableAdapters.stockTableAdapter()
        Me.StockBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter2 = New Distributed_Book_Store_Database.site3DataSetTableAdapters.stockTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Site1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Site2DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Site3DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(537, 322)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(107, 27)
        Me.Button4.TabIndex = 48
        Me.Button4.Text = "CLEAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(301, 171)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(343, 22)
        Me.TextBox2.TabIndex = 44
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(301, 139)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 22)
        Me.TextBox1.TabIndex = 43
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(347, 322)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(107, 27)
        Me.Button3.TabIndex = 40
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(159, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 27)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "INSERT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 17)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 142)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "STORE NO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 25)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "STOCK"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(156, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "QUIANITY"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(301, 203)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(343, 22)
        Me.TextBox3.TabIndex = 45
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(537, 355)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(107, 27)
        Me.Button8.TabIndex = 52
        Me.Button8.Text = "BACK"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(159, 355)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(107, 27)
        Me.Button7.TabIndex = 51
        Me.Button7.Text = "OK"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(25, 405)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(750, 150)
        Me.DataGridView1.TabIndex = 53
        '
        'Site1DataSet
        '
        Me.Site1DataSet.DataSetName = "site1DataSet"
        Me.Site1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Site2DataSet
        '
        Me.Site2DataSet.DataSetName = "site2DataSet"
        Me.Site2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Site3DataSet
        '
        Me.Site3DataSet.DataSetName = "site3DataSet"
        Me.Site3DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "stock"
        Me.StockBindingSource.DataSource = Me.Site1DataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'StockBindingSource1
        '
        Me.StockBindingSource1.DataMember = "stock"
        Me.StockBindingSource1.DataSource = Me.Site2DataSet
        '
        'StockTableAdapter1
        '
        Me.StockTableAdapter1.ClearBeforeFill = True
        '
        'StockBindingSource2
        '
        Me.StockBindingSource2.DataMember = "stock"
        Me.StockBindingSource2.DataSource = Me.Site3DataSet
        '
        'StockTableAdapter2
        '
        Me.StockTableAdapter2.ClearBeforeFill = True
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 594)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Site1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Site2DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Site3DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Site1DataSet As site1DataSet
    Friend WithEvents Site2DataSet As site2DataSet
    Friend WithEvents Site3DataSet As site3DataSet
    Friend WithEvents StockBindingSource As BindingSource
    Friend WithEvents StockTableAdapter As site1DataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockBindingSource1 As BindingSource
    Friend WithEvents StockTableAdapter1 As site2DataSetTableAdapters.stockTableAdapter
    Friend WithEvents StockBindingSource2 As BindingSource
    Friend WithEvents StockTableAdapter2 As site3DataSetTableAdapters.stockTableAdapter
End Class
