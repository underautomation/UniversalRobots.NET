Imports System
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.PrimaryInterface

Public Partial Class PrimaryInterfaceControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR

    Public Sub New(ur As UR)
        _ur = ur
        InitializeComponent()

        txtScript.Text = If(Config.Current.URScript, "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)")

        AddHandler _ur.PrimaryInterface.PopupMessageReceived, AddressOf _ur_PopupMessageReceived
        AddHandler _ur.PrimaryInterface.RuntimeExceptionMessageReceived, AddressOf _ur_RuntimeExceptionMessageReceived
    End Sub

    Private Sub _ur_RuntimeExceptionMessageReceived(sender As Object, e As RuntimeExceptionMessageEventArgs)
        ShowPopup("Runtime exception", $"Script error line {e.ScriptLineNumber} column {e.ScriptColumnNumber}
{e.RuntimeExceptionTextMessage.Replace("_", " ")}", False, True, RequestedTypes.None, 0)
    End Sub

    Private Sub _ur_PopupMessageReceived(sender As Object, e As PopupMessageEventArgs)
        ShowPopup(e.PopupMessageTitle, $"{If(e.PopupTextMessage, $"Enter {e.RequestedType}")}", e.Warning, e.Error, e.RequestedType, e.RequestId)
    End Sub

    Private Sub ShowPopup(title As String, message As String, warning As Boolean, [error] As Boolean, type As RequestedTypes, id As UInteger)
        MainForm.InvokeOnMainForm(New Action(Sub()
                                                 Dim popup = New PrimaryInterfacePopup(_ur, title, message, warning, [error], type, id)

                                                 popup.ShowDialog(MainForm.Instance)
                                             End Sub))
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Primary Interface (Data streaming and script)"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.PrimaryInterface.Connected
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        btnSendScript.Enabled = FeatureEnabled
        txtScript.Enabled = FeatureEnabled

        ' Update grid with last received values
        gridAdditionnalInfo.SetSelectedObject(_ur.PrimaryInterface.AdditionalInfo)
        gridCartesian.SetSelectedObject(_ur.PrimaryInterface.CartesianInfo)
        gridConfiguration.SetSelectedObject(_ur.PrimaryInterface.ConfigurationData)
        gridForce.SetSelectedObject(_ur.PrimaryInterface.ForceModeData)
        gridJointData.SetSelectedObject(_ur.PrimaryInterface.JointData)
        gridMasterboard.SetSelectedObject(_ur.PrimaryInterface.MasterboardData)
        gridRobotMode.SetSelectedObject(_ur.PrimaryInterface.RobotModeData)
        GridToolCommunication.SetSelectedObject(_ur.PrimaryInterface.ToolCommunicationInfo)
        gridTool.SetSelectedObject(_ur.PrimaryInterface.ToolData)
        gridToolModeInfo.SetSelectedObject(_ur.PrimaryInterface.ToolModeInfo)
        gridKinematicsData.SetSelectedObject(_ur.PrimaryInterface.KinematicsInfo)
        gridVersion.SetSelectedObject(_ur.PrimaryInterface.Version)
        gridKeyMessage.SetSelectedObject(_ur.PrimaryInterface.KeyMessage)
        gridPopupMessage.SetSelectedObject(_ur.PrimaryInterface.PopupMessage)
        gridTextMessage.SetSelectedObject(_ur.PrimaryInterface.TextMessage)
        gridRuntimeExceptionMessage.SetSelectedObject(_ur.PrimaryInterface.RuntimeExceptionMessage)
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
        VerticalScroll.Value = 0
        HorizontalScroll.Value = 0
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub
#End Region


    Private Sub btnSendScript_Click(sender As Object, e As EventArgs)
        _ur.PrimaryInterface.Script.Send(txtScript.Text)

        Config.Current.URScript = txtScript.Text
        Config.Save()
    End Sub
End Class
