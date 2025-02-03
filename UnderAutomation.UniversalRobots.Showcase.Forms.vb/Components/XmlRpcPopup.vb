Imports System
Imports System.Threading
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots.Common
Imports UnderAutomation.UniversalRobots.XmlRpc

' Popup opened when a XML-RPC request is received from the robot
Public Partial Class XmlRpcPopup
    Inherits Form
    Private _request As XmlRpcEventArg
    Private _waitHandle As AutoResetEvent

    Public Sub New(request As XmlRpcEventArg, waitHandle As AutoResetEvent)
        _request = request
        _waitHandle = waitHandle

        InitializeComponent()

        txtMethodName.Text = request.MethodName

        txtIp.Text = request.EndPoint?.Address?.ToString()

        ' specify the number of argument
        txtArgument.Text = txtArgument.Text.Replace("%", request.Arguments.Length.ToString())

        ' fill the argument list
        For Each arg In request.Arguments
            lstArgs.Items.Add(New ListViewItem({arg.Type.ToString(), arg.ToString()}))
        Next
    End Sub

#Region "Buttons click"
    Private Sub btnInteger_Click(sender As Object, e As EventArgs)
        _request.Answer = -12
    End Sub

    Private Sub btnDouble_Click(sender As Object, e As EventArgs)
        _request.Answer = 2.5
    End Sub

    Private Sub btnTrue_Click(sender As Object, e As EventArgs)
        _request.Answer = True
    End Sub

    Private Sub btnFalse_Click(sender As Object, e As EventArgs)
        _request.Answer = False
    End Sub

    Private Sub btnPose_Click(sender As Object, e As EventArgs)
        _request.Answer = New Pose(100, -100, 120, 0.2, 0, -0.1)
    End Sub

    Private Sub BtnString_Click(sender As Object, e As EventArgs)
        _request.Answer = "Hi Robot !"
    End Sub

    Private Sub btnArrayPoses_Click(sender As Object, e As EventArgs)
        _request.Answer = {New Pose(0, 1, 0, 0, 0, 0), New Pose(0, 0, 1, 0, 0, 0)}
    End Sub

    Private Sub btnArrayNumbers_Click(sender As Object, e As EventArgs)
        _request.Answer = New Double() {-4, 2.3, 100}
    End Sub

    Private Sub btnNothing_Click(sender As Object, e As EventArgs)
        _request.Answer = Nothing
    End Sub
#End Region

    ' all buttons have ActionResult to OK which closes the form.
    ' Set _waitHandle for the XML-RPC thread to continue
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)

        _waitHandle.Set()
    End Sub
End Class
