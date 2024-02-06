Public Class frmPlaceOrder
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblTotalAmount As System.Windows.Forms.Label
    Friend WithEvents btnPlace As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents txtCreditCard As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OleDbSelectCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand1 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbConnection1 As System.Data.OleDb.OleDbConnection
    Friend WithEvents OleDbDataAdapter1 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents OleDbSelectCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbInsertCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbUpdateCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDeleteCommand2 As System.Data.OleDb.OleDbCommand
    Friend WithEvents OleDbDataAdapter2 As System.Data.OleDb.OleDbDataAdapter
    Friend WithEvents DataSet21 As Project1.DataSet2
    Friend WithEvents DataSet31 As Project1.DataSet1
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalAmount = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnPlace = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtCreditCard = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OleDbSelectCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbConnection1 = New System.Data.OleDb.OleDbConnection()
        Me.OleDbInsertCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand1 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter1 = New System.Data.OleDb.OleDbDataAdapter()
        Me.OleDbSelectCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbInsertCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbUpdateCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDeleteCommand2 = New System.Data.OleDb.OleDbCommand()
        Me.OleDbDataAdapter2 = New System.Data.OleDb.OleDbDataAdapter()
        Me.DataSet31 = New Project1.DataSet1()
        Me.DataSet21 = New Project1.DataSet2()
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Place Order"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selected Items :"
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(24, 104)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(296, 173)
        Me.ListBox1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(128, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Amount : "
        '
        'lblTotalAmount
        '
        Me.lblTotalAmount.Location = New System.Drawing.Point(224, 288)
        Me.lblTotalAmount.Name = "lblTotalAmount"
        Me.lblTotalAmount.Size = New System.Drawing.Size(96, 16)
        Me.lblTotalAmount.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(48, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 32)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Credit Card Number"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(48, 368)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 16)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Valid Up To :"
        '
        'btnPlace
        '
        Me.btnPlace.Location = New System.Drawing.Point(64, 416)
        Me.btnPlace.Name = "btnPlace"
        Me.btnPlace.Size = New System.Drawing.Size(88, 24)
        Me.btnPlace.TabIndex = 7
        Me.btnPlace.Text = "&Place Order"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(208, 416)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(88, 24)
        Me.btnCancel.TabIndex = 8
        Me.btnCancel.Text = "&Cancel"
        '
        'txtCreditCard
        '
        Me.txtCreditCard.Location = New System.Drawing.Point(152, 320)
        Me.txtCreditCard.Name = "txtCreditCard"
        Me.txtCreditCard.Size = New System.Drawing.Size(136, 20)
        Me.txtCreditCard.TabIndex = 9
        Me.txtCreditCard.Text = ""
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(152, 360)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(192, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(296, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "MovieID      MovieTitle     VideoID    Format    Price"
        '
        'OleDbSelectCommand1
        '
        Me.OleDbSelectCommand1.CommandText = "SELECT CustID, OrderDate, OrderID, OrderValue, TotalQtyOrdered FROM Orders"
        Me.OleDbSelectCommand1.Connection = Me.OleDbConnection1
        '
        'OleDbConnection1
        '
        Me.OleDbConnection1.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Password="""";User ID=Admin;Data Source=C:\MyMovie" & _
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
        Me.OleDbInsertCommand1.CommandText = "INSERT INTO Orders(CustID, OrderDate, OrderValue, TotalQtyOrdered) VALUES (?, ?, " & _
        "?, ?)"
        Me.OleDbInsertCommand1.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderValue", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "OrderValue", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQtyOrdered", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "TotalQtyOrdered", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand1
        '
        Me.OleDbUpdateCommand1.CommandText = "UPDATE Orders SET CustID = ?, OrderDate = ?, OrderValue = ?, TotalQtyOrdered = ? " & _
        "WHERE (OrderID = ?) AND (CustID = ? OR ? IS NULL AND CustID IS NULL) AND (OrderD" & _
        "ate = ? OR ? IS NULL AND OrderDate IS NULL) AND (OrderValue = ? OR ? IS NULL AND" & _
        " OrderValue IS NULL) AND (TotalQtyOrdered = ? OR ? IS NULL AND TotalQtyOrdered I" & _
        "S NULL)"
        Me.OleDbUpdateCommand1.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("CustID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, "OrderDate"))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderValue", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "OrderValue", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("TotalQtyOrdered", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "TotalQtyOrdered", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustID1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderValue", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "OrderValue", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderValue1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "OrderValue", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQtyOrdered", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "TotalQtyOrdered", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQtyOrdered1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "TotalQtyOrdered", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand1
        '
        Me.OleDbDeleteCommand1.CommandText = "DELETE FROM Orders WHERE (OrderID = ?) AND (CustID = ? OR ? IS NULL AND CustID IS" & _
        " NULL) AND (OrderDate = ? OR ? IS NULL AND OrderDate IS NULL) AND (OrderValue = " & _
        "? OR ? IS NULL AND OrderValue IS NULL) AND (TotalQtyOrdered = ? OR ? IS NULL AND" & _
        " TotalQtyOrdered IS NULL)"
        Me.OleDbDeleteCommand1.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.Integer, 0, System.Data.ParameterDirection.Input, False, CType(10, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_CustID1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "CustID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderDate1", System.Data.OleDb.OleDbType.DBDate, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "OrderDate", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderValue", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "OrderValue", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderValue1", System.Data.OleDb.OleDbType.Currency, 0, System.Data.ParameterDirection.Input, False, CType(19, Byte), CType(0, Byte), "OrderValue", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQtyOrdered", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "TotalQtyOrdered", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand1.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_TotalQtyOrdered1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "TotalQtyOrdered", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter1
        '
        Me.OleDbDataAdapter1.DeleteCommand = Me.OleDbDeleteCommand1
        Me.OleDbDataAdapter1.InsertCommand = Me.OleDbInsertCommand1
        Me.OleDbDataAdapter1.SelectCommand = Me.OleDbSelectCommand1
        Me.OleDbDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Orders", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderDate", "OrderDate"), New System.Data.Common.DataColumnMapping("CustID", "CustID"), New System.Data.Common.DataColumnMapping("TotalQtyOrdered", "TotalQtyOrdered"), New System.Data.Common.DataColumnMapping("OrderValue", "OrderValue"), New System.Data.Common.DataColumnMapping("OrderID", "OrderID")})})
        Me.OleDbDataAdapter1.UpdateCommand = Me.OleDbUpdateCommand1
        '
        'OleDbSelectCommand2
        '
        Me.OleDbSelectCommand2.CommandText = "SELECT OrderID, Qty, VideoID FROM OrderDetails"
        Me.OleDbSelectCommand2.Connection = Me.OleDbConnection1
        '
        'OleDbInsertCommand2
        '
        Me.OleDbInsertCommand2.CommandText = "INSERT INTO OrderDetails(OrderID, Qty, VideoID) VALUES (?, ?, ?)"
        Me.OleDbInsertCommand2.Connection = Me.OleDbConnection1
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbInsertCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VideoID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "VideoID", System.Data.DataRowVersion.Current, Nothing))
        '
        'OleDbUpdateCommand2
        '
        Me.OleDbUpdateCommand2.CommandText = "UPDATE OrderDetails SET OrderID = ?, Qty = ?, VideoID = ? WHERE (OrderID = ?) AND" & _
        " (VideoID = ?) AND (Qty = ? OR ? IS NULL AND Qty IS NULL)"
        Me.OleDbUpdateCommand2.Connection = Me.OleDbConnection1
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("OrderID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Qty", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("VideoID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "VideoID", System.Data.DataRowVersion.Current, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VideoID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "VideoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Qty", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbUpdateCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Qty1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDeleteCommand2
        '
        Me.OleDbDeleteCommand2.CommandText = "DELETE FROM OrderDetails WHERE (OrderID = ?) AND (VideoID = ?) AND (Qty = ? OR ? " & _
        "IS NULL AND Qty IS NULL)"
        Me.OleDbDeleteCommand2.Connection = Me.OleDbConnection1
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_OrderID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "OrderID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_VideoID", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "VideoID", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Qty", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Original, Nothing))
        Me.OleDbDeleteCommand2.Parameters.Add(New System.Data.OleDb.OleDbParameter("Original_Qty1", System.Data.OleDb.OleDbType.SmallInt, 0, System.Data.ParameterDirection.Input, False, CType(5, Byte), CType(0, Byte), "Qty", System.Data.DataRowVersion.Original, Nothing))
        '
        'OleDbDataAdapter2
        '
        Me.OleDbDataAdapter2.DeleteCommand = Me.OleDbDeleteCommand2
        Me.OleDbDataAdapter2.InsertCommand = Me.OleDbInsertCommand2
        Me.OleDbDataAdapter2.SelectCommand = Me.OleDbSelectCommand2
        Me.OleDbDataAdapter2.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "OrderDetails", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("OrderID", "OrderID"), New System.Data.Common.DataColumnMapping("VideoID", "VideoID"), New System.Data.Common.DataColumnMapping("Qty", "Qty")})})
        Me.OleDbDataAdapter2.UpdateCommand = Me.OleDbUpdateCommand2
        '
        'DataSet31
        '
        Me.DataSet31.DataSetName = "DataSet3"
        Me.DataSet31.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet31.Namespace = "http://www.tempuri.org/DataSet1.xsd"
        '
        'DataSet21
        '
        Me.DataSet21.DataSetName = "DataSet2"
        Me.DataSet21.Locale = New System.Globalization.CultureInfo("en-US")
        Me.DataSet21.Namespace = "http://www.tempuri.org/DataSet2.xsd"
        '
        'frmPlaceOrder
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(352, 453)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.DateTimePicker1, Me.txtCreditCard, Me.btnCancel, Me.btnPlace, Me.Label5, Me.Label4, Me.lblTotalAmount, Me.Label3, Me.ListBox1, Me.Label2, Me.Label1})
        Me.Name = "frmPlaceOrder"
        Me.Text = "Place Order"
        CType(Me.DataSet31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim ComAddOrders, ComAddVideo, ComGetOrderID As New OleDb.OleDbCommand()
    Dim DrAddOrders, DrAddVideo As OleDb.OleDbDataReader
    Dim VideoIDs(20) As Integer   ' For Storing VideoIDs For Entering into OrderDetail Table


    Private Sub frmPlaceOrder_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'DataCommand For Getting MovieIDs And Titles From Movie Table        
        ComAddOrders.Connection = Cn
        ComAddOrders.CommandType = CommandType.Text
        ComAddOrders.CommandText = "Select * From Movie Where MovID=?"


        'DataCommand For Getting VideoIDs And Duration And Format From Video Table
        ComAddVideo.Connection = Cn
        ComAddVideo.CommandType = CommandType.Text
        ComAddVideo.CommandText = "Select * From Video Where MovID=?"


        'DataCommand For Getting The Newly Generated OrderID
        ComGetOrderID.Connection = Cn
        ComGetOrderID.CommandType = CommandType.Text
        ComGetOrderID.CommandText = "Select Max(OrderID) From Orders"


        OleDbDataAdapter1.Fill(DataSet31)
        OleDbDataAdapter2.Fill(DataSet21)


        OrderPrice = 0

        Dim i, k As Integer
        k = 0

        For i = 0 To OrdersNum - 1

            Cn.Open()

            ComAddOrders.Parameters.Add("MovID", System.Data.OleDb.OleDbType.Variant)
            ComAddOrders.Parameters("MovID").Value = SrcResultID(SelectedIndexes(i))

            DrAddOrders = ComAddOrders.ExecuteReader()

            While DrAddOrders.Read

                ListBox1.Items.Add(DrAddOrders.GetValue(7) & "     " & DrAddOrders.GetValue(1))

            End While

            Cn.Close()

        Next


        For i = 0 To OrdersNum - 1

            Cn.Open()

            ComAddVideo.Parameters.Add("VideoID", System.Data.OleDb.OleDbType.Variant)
            ComAddVideo.Parameters("VideoID").Value = SrcResultID(SelectedIndexes(i))

            DrAddVideo = ComAddVideo.ExecuteReader

            While DrAddVideo.Read

                ListBox1.Items.Item(k) &= "           " & DrAddVideo.GetValue(3) & "      " & DrAddVideo.GetValue(1) & "      " & DrAddVideo.GetValue(2)
                OrderPrice += DrAddVideo.GetValue(2)
                VideoIDs(k) = DrAddVideo.GetValue(3)
                k += 1

            End While

            Cn.Close()
        Next

        lblTotalAmount.Text = "$" & OrderPrice

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Me.Hide()
        CurrentForm = New frmWelcome()
        CurrentForm.Show()

    End Sub

    Private Sub btnPlace_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlace.Click

        'Check If Credit Card is Entered or Not
        If txtCreditCard.Text.Trim = "" Then

            MsgBox("Please Enter your Credit Card Number")
            Exit Sub

        End If


        ' Not Using Try ... Catch Because In This Phase The
        ' Possibility Of Error Is too Low And We Can Do
        ' Nothing About The Error Now            


        'Data Row For Adding To DataSet31
        'New Order To Be Added

        Dim dRowr As DataRow = DataSet31.Orders.NewRow

        dRowr("OrderDate") = DateString()      ' Today's Date
        dRowr("CustID") = Reg_ID               ' CustomerID
        dRowr("TotalQtyOrdered") = OrdersNum   ' TotalQtyOrdered
        dRowr("OrderValue") = OrderPrice       ' OrderValue


        'Adding New Order To The DataSet
        DataSet31.Tables("Orders").Rows.Add(dRowr)

        'Updating The Data Source
        OleDbDataAdapter1.Update(DataSet31)

        ' Getting The Newly Generated CustomerID


        'Now Updating The OrderDetails Table

        'ComGetOrderID.Parameters.Add("OrderValue", System.Data.OleDb.OleDbType.Integer)
        'ComGetOrderID.Parameters("OrderValue").Value = OrderPrice
        'ComGetOrderID.Parameters.Add("CustID", System.Data.OleDb.OleDbType.Integer)
        'ComGetOrderID.Parameters("CustID").Value = Reg_ID

        Dim j, OrID As Integer

        Cn.Open()

        OrID = ComGetOrderID.ExecuteScalar

        Cn.Close()

        For j = 1 To OrdersNum

            Dim dRowOrderDetail As DataRow = DataSet21.OrderDetails.NewRow

            dRowOrderDetail("OrderID") = OrID             'OrderID
            dRowOrderDetail("VideoID") = VideoIDs(j)      'VideoID
            dRowOrderDetail("Qty") = 1                    'Qty



            DataSet21.Tables(0).Rows.Add(dRowOrderDetail)

            'MsgBox("Duplicate Order")
            'Me.Hide()
            'CurrentForm = New frmWelcome()
            'CurrentForm.Show()
            'Exit Sub

            OleDbDataAdapter2.Update(DataSet21)

        Next


        MsgBox("Order Submitted SuccessFully")
        Me.Hide()
        CurrentForm = New frmWelcome()
        CurrentForm.Show()


    End Sub

End Class
