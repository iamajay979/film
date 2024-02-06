Module Main


    Public CurrentForm As System.Windows.Forms.Form

    Public Reg_ID As Integer            ' Registered Customer ID , If  0 Customer is Not registered
    Public OrdersNum As Integer         ' Number Of Orders
    Public OrderPrice As Integer        ' Order's Price

    Public AfterOrderRegistering As Boolean

    Public WithEvents Cn As New OleDb.OleDbConnection() ' Connection To MyMovies.Mdb

    Public SrcResultID(50) As Integer                  ' A Array For Storing MovieID s Or ActorID s Of Search Result
    Public SelectedIndexes(20) As Integer              ' Array For Storing Selected Indexes in lbSrcResult  ListBox


End Module