Imports System.Diagnostics

Public Module Explorer
    Public Sub RevealFile(path As String)
        Process.Start("explorer.exe", $"/select,""{path}""")
    End Sub
    Public Sub OpenDirectory(path As String)
        Process.Start("explorer.exe", path)
    End Sub
End Module
