<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.VbconnectionfinalDataSet = New Clubs_Registration_System.vbconnectionfinalDataSet()
        Me.Tbl1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl1TableAdapter = New Clubs_Registration_System.vbconnectionfinalDataSetTableAdapters.tbl1TableAdapter()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MiddlenameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BirthdayDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhonenumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VbconnectionfinalDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tbl1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(39, Byte), Integer), CType(CType(174, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1924, 92)
        Me.Panel1.TabIndex = 21
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(36, Byte), Integer))
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.White
        Me.Button5.Location = New System.Drawing.Point(42, 11)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(123, 67)
        Me.Button5.TabIndex = 18
        Me.Button5.Text = "Back"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1203, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(600, 38)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "EXPORT TO EXCEL (JOURNALISM CLUB LIST)"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.MiddlenameDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.BirthdayDataGridViewTextBoxColumn, Me.PhonenumDataGridViewTextBoxColumn, Me.GlDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Tbl1BindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(478, 150)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1178, 630)
        Me.DataGridView1.TabIndex = 66
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1333, 857)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(323, 93)
        Me.Button1.TabIndex = 67
        Me.Button1.Text = "CONFIRM EXPORT "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'VbconnectionfinalDataSet
        '
        Me.VbconnectionfinalDataSet.DataSetName = "vbconnectionfinalDataSet"
        Me.VbconnectionfinalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl1BindingSource
        '
        Me.Tbl1BindingSource.DataMember = "tbl1"
        Me.Tbl1BindingSource.DataSource = Me.VbconnectionfinalDataSet
        '
        'Tbl1TableAdapter
        '
        Me.Tbl1TableAdapter.ClearBeforeFill = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "lastname"
        Me.LastnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.Width = 125
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "firstname"
        Me.FirstnameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.Width = 125
        '
        'MiddlenameDataGridViewTextBoxColumn
        '
        Me.MiddlenameDataGridViewTextBoxColumn.DataPropertyName = "middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.HeaderText = "middlename"
        Me.MiddlenameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.MiddlenameDataGridViewTextBoxColumn.Name = "MiddlenameDataGridViewTextBoxColumn"
        Me.MiddlenameDataGridViewTextBoxColumn.Width = 125
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "age"
        Me.AgeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        Me.AgeDataGridViewTextBoxColumn.Width = 125
        '
        'BirthdayDataGridViewTextBoxColumn
        '
        Me.BirthdayDataGridViewTextBoxColumn.DataPropertyName = "birthday"
        Me.BirthdayDataGridViewTextBoxColumn.HeaderText = "birthday"
        Me.BirthdayDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.BirthdayDataGridViewTextBoxColumn.Name = "BirthdayDataGridViewTextBoxColumn"
        Me.BirthdayDataGridViewTextBoxColumn.Width = 125
        '
        'PhonenumDataGridViewTextBoxColumn
        '
        Me.PhonenumDataGridViewTextBoxColumn.DataPropertyName = "phonenum"
        Me.PhonenumDataGridViewTextBoxColumn.HeaderText = "phonenum"
        Me.PhonenumDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.PhonenumDataGridViewTextBoxColumn.Name = "PhonenumDataGridViewTextBoxColumn"
        Me.PhonenumDataGridViewTextBoxColumn.Width = 125
        '
        'GlDataGridViewTextBoxColumn
        '
        Me.GlDataGridViewTextBoxColumn.DataPropertyName = "gl"
        Me.GlDataGridViewTextBoxColumn.HeaderText = "gl"
        Me.GlDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GlDataGridViewTextBoxColumn.Name = "GlDataGridViewTextBoxColumn"
        Me.GlDataGridViewTextBoxColumn.Width = 125
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 125
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1924, 1102)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VbconnectionfinalDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tbl1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents VbconnectionfinalDataSet As vbconnectionfinalDataSet
    Friend WithEvents Tbl1BindingSource As BindingSource
    Friend WithEvents Tbl1TableAdapter As vbconnectionfinalDataSetTableAdapters.tbl1TableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MiddlenameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BirthdayDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhonenumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GlDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
