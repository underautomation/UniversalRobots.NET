Imports System
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Windows.Forms

Public Module ScreenshotsGenerator
    Public Sub Generate(frm As MainForm)
        Dim dir = New DirectoryInfo(Path.Combine(Path.GetDirectoryName(GetType(ScreenshotsGenerator).Assembly.Location), "WinformsScreenshots"))

        If dir.Exists Then dir.Delete(True)
        dir.Create()

        For Each node As TreeNode In frm.leftTreeView.Nodes
            frm.leftTreeView.SelectedNode = node
            frm.SelectNode(node)

            Dim bm = New Bitmap(frm.Width, frm.Height)
            frm.DrawToBitmap(bm, New Rectangle(0, 0, bm.Width, bm.Height))
            bm.Save(Path.Combine(dir.FullName, node.Tag.GetType().Name.Split({"Control"}, StringSplitOptions.RemoveEmptyEntries)(0) & ".jpg"), ImageFormat.Jpeg)
        Next

        OpenDirectory(dir.FullName)
    End Sub
End Module
