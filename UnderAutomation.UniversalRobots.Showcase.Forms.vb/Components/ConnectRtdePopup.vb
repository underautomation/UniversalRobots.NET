Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots.Rtde
Imports UnderAutomation.UniversalRobots.Rtde.Internal





Public Class ConnectRtdePopupInput
    Inherits ConnectRtdePopupBase
    Public Sub New(text As String, rtde As RtdeInputSetup, allData As IEnumerable(Of RtdeDataDescription(Of RtdeInputData)))
        MyBase.New(text)
        Dim parentNode = tree.Nodes.Add("All data")

        For Each d In allData
            If d.IsArray Then
                Dim node = parentNode.Nodes.Add(d.Name)
                For i As Integer = d.LowerIndex To d.LowerIndex + d.ArraySize - 1
                    Me.AddTreeNode(node, New RtdeInputSetupItem() With {
                        .Data = d.Data,
                        .Index = i
                    }, rtde)
                Next
            Else
                Me.AddTreeNode(parentNode, New RtdeInputSetupItem() With {
                    .Data = d.Data
                }, rtde)
            End If
        Next

        ' Expand parent node
        parentNode.Expand()


        For Each node As TreeNode In parentNode.Nodes
            If node.Nodes.OfType(Of TreeNode)().Any(Function(n) n.Checked) Then node.Expand() ' Expand only nodes that have checked children
            If node.Nodes.Count > 0 AndAlso node.Nodes.OfType(Of TreeNode)().All(Function(n) n.Checked) Then node.Checked = True ' check node if all its sub node are checked
        Next
        If parentNode.Nodes.OfType(Of TreeNode)().All(Function(n) n.Checked) Then parentNode.Checked = True
    End Sub

    Public ReadOnly Property Setup As RtdeInputSetup = New RtdeInputSetup()

    Private Sub AddTreeNode(parent As TreeNode, tag As RtdeInputSetupItem, originalConfiguration As RtdeInputSetup)
        Dim node = parent.Nodes.Add($"{tag.Name} ({tag.Type})")
        node.Tag = tag
        node.ToolTipText = tag.Description.Description
        node.Checked = originalConfiguration.Contains(tag.Data, tag.Index)
    End Sub

    Protected Overrides Sub tree_AfterCheck(sender As Object, e As TreeViewEventArgs)
        If e.Node Is Nothing Then Return

        Dim tag = TryCast(e.Node.Tag, RtdeInputSetupItem)

        If tag Is Nothing Then
            For Each node As TreeNode In e.Node.Nodes
                If node.Checked <> e.Node.Checked Then node.Checked = e.Node.Checked
            Next
        Else
            If e.Node.Checked Then
                Setup.Add(tag)
            Else
                Setup.Remove(tag)
            End If
        End If
    End Sub

End Class


Public Class ConnectRtdePopupOutput
    Inherits ConnectRtdePopupBase
    Public Sub New(text As String, rtde As RtdeOutputSetup, allData As IEnumerable(Of RtdeDataDescription(Of RtdeOutputData)))
        MyBase.New(text)
        Dim parentNode = tree.Nodes.Add("All data")

        For Each d In allData
            If d.IsArray Then
                Dim node = parentNode.Nodes.Add(d.Name)
                For i As Integer = d.LowerIndex To d.LowerIndex + d.ArraySize - 1
                    Me.AddTreeNode(node, New RtdeOutputSetupItem With {
                        .Data = d.Data,
                        .Index = i
                    }, rtde)
                Next
            Else
                Me.AddTreeNode(parentNode, New RtdeOutputSetupItem With {
                    .Data = d.Data
                }, rtde)
            End If
        Next

        ' Expand parent node
        parentNode.Expand()


        For Each node As TreeNode In parentNode.Nodes
            If node.Nodes.OfType(Of TreeNode)().Any(Function(n) n.Checked) Then node.Expand() ' Expand only nodes that have checked children
            If node.Nodes.Count > 0 AndAlso node.Nodes.OfType(Of TreeNode)().All(Function(n) n.Checked) Then node.Checked = True ' check node if all its sub node are checked
        Next
        If parentNode.Nodes.OfType(Of TreeNode)().All(Function(n) n.Checked) Then parentNode.Checked = True
    End Sub


    Public ReadOnly Property Setup As RtdeOutputSetup = New RtdeOutputSetup()

    Private Sub AddTreeNode(parent As TreeNode, tag As RtdeOutputSetupItem, originalConfiguration As RtdeOutputSetup)
        Dim node = parent.Nodes.Add($"{tag.Name} ({tag.Type})")
        node.Tag = tag
        node.ToolTipText = tag.Description.Description
        node.Checked = originalConfiguration.Contains(tag.Data, tag.Index)
    End Sub


    Protected Overrides Sub tree_AfterCheck(sender As Object, e As TreeViewEventArgs)
        If e.Node Is Nothing Then Return

        Dim tag = TryCast(e.Node.Tag, RtdeOutputSetupItem)

        If tag Is Nothing Then
            For Each node As TreeNode In e.Node.Nodes
                If node.Checked <> e.Node.Checked Then node.Checked = e.Node.Checked
            Next
        Else
            If e.Node.Checked Then
                Setup.Add(tag)
            Else
                Setup.Remove(tag)
            End If
        End If
    End Sub

End Class
