Public Class frmInsertMovie
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet11 As MyMoviesAdmin.DataSet1
    Friend WithEvents Cn As System.Data.OleDb.OleDbConnection
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.Cn = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSet11 = New MyMoviesAdmin.DataSet1()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Movie Title : "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Director ID : "
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(32, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Producer ID : "
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Duration : "
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(32, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Description : "
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Category : "
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(32, 216)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Release Year : "
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(40, 256)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(80, 24)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "&Submit"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(160, 256)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "&Cancel"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(120, 18)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(104, 20)
        Me.TextBox2.TabIndex = 11
        Me.TextBox2.Text = ""
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(120, 50)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(104, 20)
        Me.TextBox3.TabIndex = 12
        Me.TextBox3.Text = ""
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(120, 82)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(104, 20)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = ""
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(120, 114)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(104, 20)
        Me.TextBox5.TabIndex = 14
        Me.TextBox5.Text = ""
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(120, 146)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(104, 20)
        Me.TextBox6.TabIndex = 15
        Me.TextBox6.Text = ""
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(120, 178)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(104, 20)
        Me.TextBox7.TabIndex = 16
        Me.TextBox7.Text = ""
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(120, 210)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(104, 20)
        Me.TextBox8.TabIndex = 17
        Me.TextBox8.Text = ""
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT Category, Description, DirID, Duration, MovID, MovTitle, ProdID, ReleaseYe" & _
        "ar FROM Movie"
        Me.OleDbSelectCommand1.Connection = Me.Cn
        '
        'Cn
        '
        Me.Cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\MyMovie" & _
        "s.mdb;Mode=ReadWrite|Share Deny None;Extended Properties="""";Jet OLEDB:System dat" & _
        "abase="""";Jet OLEDB:Registry Path="""";Jet OLEDB:Database Password="""";Jet OLEDB:Eng" & _
        "ine Type=5;Jet OLEDB:Database Locking Mode=1;Jet OLEDB:Global Partial Bulk Ops=2" & _
        ";Jet OLEDB:Global Bulk Transactions=1;Jet OLEDB:New Database Password="""";Jet OLE" & _
        "DB:Create System Database=False;Jet OLEDB:Encrypt Database=False;Jet OLEDB:Don't" & _
        " Copy Locale on Compact=False;Jet OLEDB:Compact Without Replica Repair=False;Jet" & _
        " OLEDB:SFP=False"
        '
        'OleDbInsertCommand1
        '
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Movie(Category, Description, DirID, Duration, MovTitle, ProdID, Relea" & _
        "seYear) VALUES (?, ?, ?, ?, ?, ?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.Cn
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 20, "Category"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 100, "Description"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DirID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "DirID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Duration", System.Data.OleDb.OleDbType.VarWChar, 10, "Duration"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MovTitle", System.Data.OleDb.OleDbType.VarWChar, 50, "MovTitle"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProdID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ProdID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReleaseYear", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReleaseYear", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Movie SET Category = ?, Description = ?, DirID = ?, Duration = ?, MovTitle" & _
        " = ?, ProdID = ?, ReleaseYear = ? WHERE (MovID = ?) AND (Category = ? OR ? IS NU" & _
        "LL AND Category IS NULL) AND (Description = ? OR ? IS NULL AND Description IS NU" & _
        "LL) AND (DirID = ? OR ? IS NULL AND DirID IS NULL) AND (Duration = ? OR ? IS NUL" & _
        "L AND Duration IS NULL) AND (MovTitle = ? OR ? IS NULL AND MovTitle IS NULL) AND" & _
        " (ProdID = ? OR ? IS NULL AND ProdID IS NULL) AND (ReleaseYear = ? OR ? IS NULL " & _
        "AND ReleaseYear IS NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.Cn
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Category", System.Data.OleDb.OleDbType.VarWChar, 20, "Category"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Description", System.Data.OleDb.OleDbType.VarWChar, 100, "Description"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("DirID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "DirID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Duration", System.Data.OleDb.OleDbType.VarWChar, 10, "Duration"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("MovTitle", System.Data.OleDb.OleDbType.VarWChar, 50, "MovTitle"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ProdID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ProdID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("ReleaseYear", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReleaseYear", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MovID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "MovID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DirID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "DirID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DirID1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "DirID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Duration", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Duration", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Duration1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Duration", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MovTitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MovTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MovTitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MovTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ProdID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdID1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ProdID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseYear", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReleaseYear", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseYear1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReleaseYear", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Movie WHERE (MovID = ?) AND (Category = ? OR ? IS NULL AND Category I" & _
        "S NULL) AND (Description = ? OR ? IS NULL AND Description IS NULL) AND (DirID = " & _
        "? OR ? IS NULL AND DirID IS NULL) AND (Duration = ? OR ? IS NULL AND Duration IS" & _
        " NULL) AND (MovTitle = ? OR ? IS NULL AND MovTitle IS NULL) AND (ProdID = ? OR ?" & _
        " IS NULL AND ProdID IS NULL) AND (ReleaseYear = ? OR ? IS NULL AND ReleaseYear I" & _
        "S NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.Cn
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MovID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "MovID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Category1", System.Data.OleDb.OleDbType.VarWChar, 20, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Category", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Description1", System.Data.OleDb.OleDbType.VarWChar, 100, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Description", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DirID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "DirID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_DirID1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "DirID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Duration", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Duration", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Duration1", System.Data.OleDb.OleDbType.VarWChar, 10, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Duration", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MovTitle", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MovTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_MovTitle1", System.Data.OleDb.OleDbType.VarWChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MovTitle", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ProdID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ProdID1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ProdID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseYear", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReleaseYear", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_ReleaseYear1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "ReleaseYear", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Movie", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("MovTitle", "MovTitle"), New System.Data.Common.DataColumnMapping("DirID", "DirID"), New System.Data.Common.DataColumnMapping("ProdID", "ProdID"), New System.Data.Common.DataColumnMapping("Duration", "Duration"), New System.Data.Common.DataColumnMapping("Description", "Description"), New System.Data.Common.DataColumnMapping("Category", "Category"), New System.Data.Common.DataColumnMapping("ReleaseYear", "ReleaseYear"), New System.Data.Common.DataColumnMapping("MovID", "MovID")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet11.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'frmInsertMovie
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 301)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TextBox8, Me.TextBox7, Me.TextBox6, Me.TextBox5, Me.TextBox4, Me.TextBox3, Me.TextBox2, Me.btnCancel, Me.btnSubmit, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2})
        Me.Name = "frmInsertMovie"
        Me.Text = "Insert Movie Info"
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim ComDirectorExist As New OleDb.OleDbCommand() 'Checks If The Entered DirectorID Exists In The DataBase Or Not
    Dim ComProducerExist As New OleDb.OleDbCommand() 'Checks If The Entered ProducerID Exists In The DataBase Or Not
    Dim ComMovieExist As New OleDb.OleDbCommand()    'Checks If The Entered MovieTitle Exists In The DataBase Or Not


    Private Sub frmInsertMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Filling The DataSet
        OleDbDataAdapter1.Fill(DataSet11)

        'ComDirectorExist Config
        ComDirectorExist.Connection = Cn
        ComDirectorExist.CommandType = CommandType.Text
        ComDirectorExist.CommandText = "Select Count(*) from Director Where DirID=?"


        'ComProducerExist Config
        ComProducerExist.Connection = Cn
        ComProducerExist.CommandType = CommandType.Text
        ComProducerExist.CommandText = "Select Count(*) from Producer Where ProdID=?"


        'ComMovieExist
        ComMovieExist.Connection = Cn
        ComMovieExist.CommandType = CommandType.Text
        ComMovieExist.CommandText = "Select Count(*) From Movie Where MovTitle=?"


    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        Dim Ctrl As Control

        'Testing If The Controls Are Empty Or Not
        For Each Ctrl In Controls

            If (TypeOf Ctrl Is TextBox) Then

                If Ctrl.Text.Trim = "" Then

                    MsgBox("Please Enter The Data Completely")
                    Exit Sub

                End If

            End If

        Next


        'ComDirectorExist Value
        ComDirectorExist.Parameters.Add("DirID", System.Data.OleDb.OleDbType.Integer)
        ComDirectorExist.Parameters("DirID").Value = TextBox3.Text


        'ComProducerExist Value
        ComProducerExist.Parameters.Add("ProdID", System.Data.OleDb.OleDbType.Integer)
        ComProducerExist.Parameters("ProdID").Value = TextBox4.Text


        'ComMovieExist Value
        ComMovieExist.Parameters.Add("MovTitle", System.Data.OleDb.OleDbType.Variant)
        ComMovieExist.Parameters("MovTitle").Value = TextBox2.Text

        Cn.Open()

        Dim nres As Integer

        nres = ComMovieExist.ExecuteScalar

        If (ComMovieExist.ExecuteScalar <> 0) Then  'MovTitle Exists

            MsgBox("This Movie Title Exists In The DataBase Please Enter Another One")
            Exit Sub

        End If


        If (ComProducerExist.ExecuteScalar = 0) Then   'ProdID Doesn't Exist In The DataBase

            MsgBox("The ProducerID You Have Entered Doesn't Exist in The DataBase" & vbCrLf & " Please Enter Another One")
            Exit Sub

        End If


        If (ComDirectorExist.ExecuteScalar = 0) Then 'DirectorID Doesn't Exist In The DataBase

            MsgBox("The DirectorID You Have Entered Doesn't Exist in The DataBase" & vbCrLf & " Please Enter Another One")
            Exit Sub

        End If

        'The Data is Correct 
        'Starting to Submit

        Dim dRowInsertMovie As DataRow = DataSet11.Movie.NewRow

        Try

            dRowInsertMovie("MovTitle") = TextBox2.Text
            dRowInsertMovie("DirID") = TextBox3.Text
            dRowInsertMovie("ProdID") = TextBox4.Text
            dRowInsertMovie("Duration") = TextBox5.Text
            dRowInsertMovie("Description") = TextBox6.Text
            dRowInsertMovie("Category") = TextBox7.Text
            dRowInsertMovie("ReleaseYear") = TextBox8.Text

            DataSet11.Tables("Movie").Rows.Add(dRowInsertMovie)

        Catch
            ' Error Occured,Roll Back
            MsgBox("Please Enter The Data Completely")
            Exit Sub

        End Try

        'UpDating The Data Source
        OleDbDataAdapter1.Update(DataSet11)
        MsgBox("Data Was Added To The DataBase SuccessFully")

        Cn.Close()

        Me.Hide()
        CurrentForm = New frmAdminMain()
        CurrentForm.Show()

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Hide()
        CurrentForm = New frmAdminMain()
        CurrentForm.Show()

    End Sub
End Class
