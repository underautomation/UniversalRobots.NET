Imports System
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots.Common

Public Partial Class ToolsControl
    Inherits UserControl
    Implements IUserControl
    Public Sub New()
        InitializeComponent()
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Convert position types"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return True
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
    End Sub
    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub
    Public Sub OnOpen() Implements IUserControl.OnOpen
    End Sub
#End Region

    Private Sub ValueChanged(sender As Object, e As EventArgs)
        Dim inPose = New Pose(0, 0, 0, udRx.Value, udRy.Value, udRz.Value)

        Dim outPose As Pose

        If radioRPYToRotationVector.Checked Then
            ' Convert from RPY to Rotation vector
            outPose = inPose.FromRPYToRotationVector()

            txtIn.Text = "RPY"
            txtOut.Text = "Rotation Vector"
        Else
            ' Convert from Rotation vector to RPY
            outPose = inPose.FromRotationVectorToRPY()

            txtIn.Text = "Rotation Vector"
            txtOut.Text = "RPY"
        End If

        txtRx.Text = $"{outPose.Rx} rad"
        txtRy.Text = $"{outPose.Ry} rad"
        txtRz.Text = $"{outPose.Rz} rad"
    End Sub
End Class
