Public Class frmWelcome
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents txtCustID As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(112, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Welcome To MyMovies"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSubmit, Me.txtCustID, Me.Label2})
        Me.GroupBox1.Location = New System.Drawing.Point(32, 64)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 112)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registered Customer"
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(96, 72)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 24)
        Me.btnSubmit.TabIndex = 2
        Me.btnSubmit.Text = "S&ubmit"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(128, 28)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(152, 20)
        Me.txtCustID.TabIndex = 1
        Me.txtCustID.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Customer ID :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSearch, Me.btnRegister, Me.Label4, Me.Label3})
        Me.GroupBox2.Location = New System.Drawing.Point(32, 192)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(312, 128)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "New Customer"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(184, 72)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(96, 24)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "&Search"
        '
        'btnRegister
        '
        Me.btnRegister.Location = New System.Drawing.Point(184, 24)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(96, 24)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "&Register"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(168, 16)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Continue Without Registration :"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To Register :"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(136, 336)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(112, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "&Exit"
        '
        'frmWelcome
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(376, 373)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox1, Me.Label1, Me.btnExit})
        Me.Name = "frmWelcome"
        Me.Text = "Welcome"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim WithEvents Com1 As New OleDb.OleDbCommand()

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        End

    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Me.Hide()
        CurrentForm = New frmSearch()
        CurrentForm.Show()

    End Sub


    Private Sub frmWelcome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cn.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\MyMovies.mdb;Mode=ReadWrite;Persist Security Info=False"

        ' ToDo : Change Mdb Path Later

        ' Resetting Public Variables

        Reg_ID = 0
        OrdersNum = 0
        OrderPrice = 0
        AfterOrderRegistering = False
        SrcResultID.Clear(SrcResultID, 0, 50)
        SelectedIndexes.Clear(SelectedIndexes, 0, 20)


        Com1.Connection = Cn
        Com1.CommandType = CommandType.Text
        Com1.CommandText = "Select CustID From Customer Where CustID=?"


    End Sub


    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click


        If (txtCustID.Text.Trim = "") Then
            MsgBox("Please Enter Your Customer ID")
            Exit Sub

        Else
            ' TextBox in Not Empty
            Cn.Open()

            Com1.Parameters.Add("CustID", Data.OleDb.OleDbType.Integer)
            Com1.Parameters("CustID").Value = txtCustID.Text

            Dim nResult As Integer = 0
            nResult = Com1.ExecuteScalar

            Cn.Close()


            If (nResult = 0) Then

                MsgBox("Your Customer ID is not Registered In Our Database" & vbCrLf & "Please Register Using Register Button")

            Else       'Customer is Registered

                ' Now nResult Contains The Submitted Customer's ID
                MsgBox("Customer " & txtCustID.Text & " Submitted ")

                Reg_ID = nResult
                Me.Hide()
                CurrentForm = New frmSearch()
                CurrentForm.Show()

            End If ' End If for  If (nResult =0 ... )

        End If  ' End if For If (txtCustID.Text.... ) .... Else ...

    End Sub

    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        'Me.Hide()

        Me.Hide()
        CurrentForm = New frmRegister()
        CurrentForm.Show()


    End Sub

End Class