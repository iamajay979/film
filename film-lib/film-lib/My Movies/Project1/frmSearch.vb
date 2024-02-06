Public Class frmSearch
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSearch As System.Windows.Forms.TextBox
    Friend WithEvents cboxCat As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lbSrcResult As System.Windows.Forms.ListBox
    Friend WithEvents btnPlaceOrder As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.cboxCat = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbSrcResult = New System.Windows.Forms.ListBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(136, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Search Text :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Browse By :"
        '
        'txtSearch
        '
        Me.txtSearch.Location = New System.Drawing.Point(112, 50)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(120, 20)
        Me.txtSearch.TabIndex = 3
        Me.txtSearch.Text = ""
        '
        'cboxCat
        '
        Me.cboxCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxCat.Items.AddRange(New Object() {"Movie Category", "Actor's Last Name"})
        Me.cboxCat.Location = New System.Drawing.Point(112, 90)
        Me.cboxCat.Name = "cboxCat"
        Me.cboxCat.Size = New System.Drawing.Size(120, 21)
        Me.cboxCat.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(240, 90)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(88, 24)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "&Search"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Search Result :"
        '
        'lbSrcResult
        '
        Me.lbSrcResult.Location = New System.Drawing.Point(32, 192)
        Me.lbSrcResult.Name = "lbSrcResult"
        Me.lbSrcResult.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lbSrcResult.Size = New System.Drawing.Size(368, 160)
        Me.lbSrcResult.TabIndex = 7
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(40, 368)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(88, 24)
        Me.btnPlaceOrder.TabIndex = 8
        Me.btnPlaceOrder.Text = "&Place Order"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 368)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 24)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "&Exit"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(400, 16)
        Me.Label5.TabIndex = 10
        '
        'frmSearch
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(448, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.btnExit, Me.btnPlaceOrder, Me.lbSrcResult, Me.Label4, Me.btnSearch, Me.cboxCat, Me.txtSearch, Me.Label3, Me.Label2, Me.Label1})
        Me.Name = "frmSearch"
        Me.Text = "Search"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim ComCat As New OleDb.OleDbCommand()        'Command For Searching By Category
    Dim ComActor As New OleDb.OleDbCommand()      'Command For Searching By Actor's Last Name 
    Dim ComActorMovie As New OleDb.OleDbCommand() 'Command For Searching By ActorIDFound in ActorMovieTable
    Dim ComMovie As New OleDb.OleDbCommand()      'Command For Searching The MovIDs Found By ComActorMovie
    Dim DrResult As OleDb.OleDbDataReader         'Data Reader Object  
    Dim Dr2 As OleDb.OleDbDataReader
    Dim Cn2 As New OleDb.OleDbConnection()        'A New Connection to The MyMovies.mdb for Use with Dr2

    Private Sub frmSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cn2.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\MyMovies.mdb;Mode=ReadWrite;Persist Security Info=False"

        'Command Objects
        ComCat.Connection = Cn
        ComCat.CommandType = CommandType.Text
        ComCat.CommandText = "Select * From Movie Where Category=?"

        ComActor.Connection = Cn
        ComActor.CommandType = CommandType.Text
        ComActor.CommandText = "Select ActorID From Actor Where LastName=?"

        ComActorMovie.Connection = Cn
        ComActorMovie.CommandType = CommandType.Text
        ComActorMovie.CommandText = "Select MovID From ActorMovie Where ActorID=?"

        ComMovie.Connection = Cn2
        ComMovie.CommandType = CommandType.Text
        ComMovie.CommandText = "Select * From Movie Where MovID=?"


    End Sub



    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        Me.Hide()
        CurrentForm = New frmWelcome()
        CurrentForm.Show()


    End Sub



    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim i As Integer = 0

        'Clearing The Array SrcResultID
        SrcResultID.Clear(SrcResultID, 0, 50)

        'Clearing The Array SelectedIndexes
        SelectedIndexes.Clear(SelectedIndexes, 0, 20)

        'Check If TextBox is Empty
        If (txtSearch.Text.Trim = "") Then

            MsgBox("Please Enter Your Search Text In The TextBox", MsgBoxStyle.OKOnly, "")
            txtSearch.Focus()
            Exit Sub

        End If

        ' Searching


        If cboxCat.SelectedIndex = 0 Then ' Category Selected

            ComCat.Parameters.Add("Category", Data.OleDb.OleDbType.Variant)
            ComCat.Parameters("Category").Value = txtSearch.Text

            Cn.Open()
            DrResult = ComCat.ExecuteReader()


            With DrResult
                While .Read

                    'Adding Search Result To The ListBox
                    lbSrcResult.Items.Add("    " & .GetValue(7) & "              " & .GetValue(0) & "          " & .GetValue(3) & "     " & .GetValue(6) & "     " & .GetValue(4))
                    SrcResultID(i) = (.GetValue(7))
                    i += 1

                End While
            End With

            Cn.Close()

            Label5.Text = "  MovieID     MovieTitle      Duration    ReleaseYear     Description"


        End If


        If cboxCat.SelectedIndex = 1 Then ' Actor's LastName Selected

            ComActor.Parameters.Add("LastName", Data.OleDb.OleDbType.Variant)
            ComActor.Parameters("LastName").Value = txtSearch.Text

            Dim nActorResultID As Integer ' Found ActorID

            Cn.Open()
            nActorResultID = ComActor.ExecuteScalar


            ComActorMovie.Parameters.Add("ActorID", Data.OleDb.OleDbType.Integer)
            ComActorMovie.Parameters("ActorID").Value = nActorResultID

            DrResult = ComActorMovie.ExecuteReader 'Getting MovIDs InWhich This Actor Has Role



            While DrResult.Read

                ComMovie.Parameters.Add("MovID", Data.OleDb.OleDbType.Variant)
                ComMovie.Parameters("MovID").Value = DrResult.GetValue(0)

                Cn2.Open()

                Dr2 = ComMovie.ExecuteReader


                While Dr2.Read

                    lbSrcResult.Items.Add("    " & Dr2.GetValue(7) & "              " & Dr2.GetValue(0) & "      " & Dr2.GetValue(3) & "        " & Dr2.GetValue(5) & "      " & Dr2.GetValue(6) & "     " & Dr2.GetValue(4))
                    SrcResultID(i) = Dr2.GetValue(7)
                    i += 1

                End While

                Cn2.Close()

            End While

            Label5.Text = "MovieID     Movie Title    Duration     Category     ReleaseYear     Description"

            Cn.Close()

        End If


    End Sub


    Private Sub btnPlaceOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlaceOrder.Click

        Dim i As Integer

        ' Adding Selected Indexes To Collection SelectedItemsIndex

        For i = 0 To lbSrcResult.SelectedIndices.Count() - 1

            SelectedIndexes(i) = lbSrcResult.SelectedIndices(i)

        Next

        OrdersNum = lbSrcResult.SelectedItems.Count()

        If Reg_ID = 0 Then 'Customer is Not Registered

            MsgBox("You Are Not Registered! Please Register")
            AfterOrderRegistering = True
            Me.Hide()
            CurrentForm = New frmRegister()
            CurrentForm.Show()


        Else   ' Customer is Registered

            Me.Hide()
            CurrentForm = New frmPlaceOrder()
            CurrentForm.Show()

        End If


        


    End Sub

End Class
