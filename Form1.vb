' ***********************************************
'                ADB Toolkit v1.0 
'                ****************
' Published by KP
' Copyright 20th April 2017, KP'S TV, inc.
' Lisence Under Apache Lisence

' Only for General Use

' ***********************************************

Imports System
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "reboot"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "reboot recovery"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "shell reboot -p"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "start-server"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "kill-server"
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        OpenFileDialog1.FileName = "Select an Apk"
        OpenFileDialog1.Filter = "Apk Files|*.apk|All Files|*.*"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim p As New Process
        p.StartInfo.FileName = "adb.exe"
        p.StartInfo.Arguments = "install -r " + TextBox1.Text
        p.StartInfo.UseShellExecute = False
        p.StartInfo.CreateNoWindow = True
        p.Start()
    End Sub
End Class
