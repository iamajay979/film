Public Class frmAdminMain
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
    Friend WithEvents btnMovie As System.Windows.Forms.Button
    Friend WithEvents btnVideo As System.Windows.Forms.Button
    Friend WithEvents btnActor As System.Windows.Forms.Button
    Friend WithEvents btnDirector As System.Windows.Forms.Button
    Friend WithEvents btnProducer As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDailySale As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnMovie = New System.Windows.Forms.Button()
        Me.btnVideo = New System.Windows.Forms.Button()
        Me.btnActor = New System.Windows.Forms.Button()
        Me.btnDirector = New System.Windows.Forms.Button()
        Me.btnProducer = New System.Windows.Forms.Button()
        Me.btnDailySale = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMovie
        '
        Me.btnMovie.Location = New System.Drawing.Point(152, 64)
        Me.btnMovie.Name = "btnMovie"
        Me.btnMovie.Size = New System.Drawing.Size(112, 24)
        Me.btnMovie.TabIndex = 0
        Me.btnMovie.Text = "Insert &Movie"
        '
        'btnVideo
        '
        Me.btnVideo.Location = New System.Drawing.Point(152, 104)
        Me.btnVideo.Name = "btnVideo"
        Me.btnVideo.Size = New System.Drawing.Size(112, 24)
        Me.btnVideo.TabIndex = 1
        Me.btnVideo.Text = "Insert &Video"
        '
        'btnActor
        '
        Me.btnActor.Location = New System.Drawing.Point(152, 144)
        Me.btnActor.Name = "btnActor"
        Me.btnActor.Size = New System.Drawing.Size(112, 24)
        Me.btnActor.TabIndex = 2
        Me.btnActor.Text = "Insert &Actor"
        '
        'btnDirector
        '
        Me.btnDirector.Location = New System.Drawing.Point(152, 184)
        Me.btnDirector.Name = "btnDirector"
        Me.btnDirector.Size = New System.Drawing.Size(112, 24)
        Me.btnDirector.TabIndex = 3
        Me.btnDirector.Text = "Insert &Director"
        '
        'btnProducer
        '
        Me.btnProducer.Location = New System.Drawing.Point(152, 224)
        Me.btnProducer.Name = "btnProducer"
        Me.btnProducer.Size = New System.Drawing.Size(112, 24)
        Me.btnProducer.TabIndex = 4
        Me.btnProducer.Text = "Insert &Producer"
        '
        'btnDailySale
        '
        Me.btnDailySale.Location = New System.Drawing.Point(24, 64)
        Me.btnDailySale.Name = "btnDailySale"
        Me.btnDailySale.Size = New System.Drawing.Size(88, 24)
        Me.btnDailySale.TabIndex = 5
        Me.btnDailySale.Text = "Daily &Sales"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Insert"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Reports"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(104, 272)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 24)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "&Exit"
        '
        'frmAdminMain
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(288, 309)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.Label2, Me.Label1, Me.btnDailySale, Me.btnProducer, Me.btnDirector, Me.btnActor, Me.btnVideo, Me.btnMovie})
        Me.Name = "frmAdminMain"
        Me.Text = "Admin Module"
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub btnMovie_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMovie.Click

        Me.Hide()
        CurrentForm = New frmInsertMovie()
        CurrentForm.Show()

    End Sub




    Private Sub btnVideo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVideo.Click

        Me.Hide()
        CurrentForm = New frmInsertVideo()
        CurrentForm.Show()

    End Sub


    Private Sub btnActor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActor.Click

        Me.Hide()
        CurrentForm = New frmInsertActor()
        CurrentForm.Show()

    End Sub

    Private Sub btnDirector_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDirector.Click

        Me.Hide()
        CurrentForm = New frmInsertDirector()
        CurrentForm.Show()

    End Sub

    Private Sub btnProducer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducer.Click

        Me.Hide()
        CurrentForm = New frmInsertProducer()
        CurrentForm.Show()

    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

        End

    End Sub

    Private Sub btnDailySale_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDailySale.Click

        Me.Hide()
        CurrentForm = New frmDailySale()
        CurrentForm.Show()

    End Sub
End Class
