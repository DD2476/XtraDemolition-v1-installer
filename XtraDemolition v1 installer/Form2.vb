Public Class Form2

    Private WithEvents tmr As New Timer With {.Interval = 1}
    Dim angle As Integer = 135
    Dim currentScreen As Screen
    Dim Random As New Random

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DoubleBuffered = True
        currentScreen = Screen.AllScreens.First(Function(s) s.Bounds.Contains(Me.Location))
        tmr.Start()
        Me.TransparencyKey = SystemColors.Control
        Me.Location = New Point(Random.Next(0, My.Computer.Screen.WorkingArea.Width - Me.Width), Random.Next(0, My.Computer.Screen.WorkingArea.Height - Me.Height))
    End Sub

    Private Sub tmr_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles tmr.Tick
        Dim angleRadians As Single = CSng(Math.PI * (angle Mod 360) / 180)
        'Calculate X2 and Y2
        Dim pointX2 As Integer = CInt(Me.Location.X - Math.Sin(angleRadians) * 10)
        Dim pointY2 As Integer = CInt(Me.Location.Y + Math.Cos(angleRadians) * 10)
        Me.Location = New Point(pointX2, pointY2)
        Dim p1 As Point = New Point(Me.Location.X - currentScreen.Bounds.Left, Me.Location.Y - currentScreen.Bounds.Top)
        Dim p2 As Point = New Point(Me.Right - currentScreen.Bounds.Left, Me.Bottom - currentScreen.Bounds.Top)
        If (p1.X < 0 Or p1.Y < 0 _
            Or p2.Y > currentScreen.Bounds.Height Or p2.X > currentScreen.Bounds.Width) Then
            angle += 90
        End If
    End Sub
End Class