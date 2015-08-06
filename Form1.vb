
Public Class Form1
    Dim ws As New WebReference.InfoCenterWebService
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
 MsgBox(ex.ToString)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim Watch As New Stopwatch
            'Dim iStart As Integer = 0
            'Dim iEnd As Integer = 0
            Watch.Start()
            lblStartTime.Text = Now.ToString("HH:mm:ss:ffff")
            'iStart = Now.ToString("ffff")
            lblRessult.Text = ws.GetCurrentVer()
            lblEndTime.Text = Now.ToString("HH:mm:ss:ffff")
            'iEnd = Now.ToString("ffff")
            Watch.Stop()
            lblWestTime.Text = Watch.ElapsedMilliseconds

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Watch As New Stopwatch
            'Dim iStart As Integer = 0
            'Dim iEnd As Integer = 0
            Dim ds As New DataSet
            Watch.Start()
            lblStartTime.Text = Now.ToString("HH:mm:ss:ffff")
            'iStart = Now.ToString("ffff")
            ds = ws.GetActivityDataListAll
            DataGridView1.DataSource = ds.Tables(0)
            lblEndTime.Text = Now.ToString("HH:mm:ss:ffff")
            'iEnd = Now.ToString("ffff")
            Watch.Stop()
            lblWestTime.Text = Watch.ElapsedMilliseconds
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            Dim o As New wsService.UserWS
            Dim s As String
            s = o.getUserInfo("123123", "sss")
            MsgBox(s)
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
