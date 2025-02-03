Imports System.Windows.Forms

Public Partial Class ConnectRtdePopupBase
    Inherits Form

    Public Sub New(text As String)
        InitializeComponent()
        Me.Text = text
    End Sub



    Protected Overridable Sub tree_AfterCheck(sender As Object, e As TreeViewEventArgs)
    End Sub
End Class
