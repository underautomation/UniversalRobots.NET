Imports System
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.PrimaryInterface
Imports UnderAutomation.UniversalRobots.Showcase.Desktop.Properties

Public Partial Class PrimaryInterfacePopup
    Inherits Form
    Private _ur As UR

    Private _type As RequestedTypes
    Private _id As UInteger

    Public Sub New(ur As UR, title As String, message As String, warning As Boolean, [error] As Boolean, type As RequestedTypes, id As UInteger)
        InitializeComponent()

        Text = title
        lblMessage.Text = message
        _ur = ur

        txtAnswer.Visible = type <> RequestedTypes.None
        _type = type

        _id = id

        If warning Then
            img.BackgroundImage = My.Resources.warning
        ElseIf [error] Then
            img.BackgroundImage = My.Resources._error
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs)
        _ur.Dashboard.ClosePopup()
        If _type <> RequestedTypes.None Then
            _ur.PrimaryInterface.Commands.ReplyPopup(_id, txtAnswer.Text, _type)
        End If
        Close()
    End Sub

    Private Sub PrimaryInterfacePopup_Shown(sender As Object, e As EventArgs)
        Size = New Drawing.Size(450, 200)
    End Sub
End Class
