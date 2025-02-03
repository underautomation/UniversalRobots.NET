Imports System
Imports System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.XmlRpc

Public Partial Class XmlRpcControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR

    Public Sub New(ur As UR)
        _ur = ur
        InitializeComponent()

        AddHandler _ur.XmlRpc.XmlRpcServerRequest, AddressOf _ur_OnXmlRpcServerRequest
    End Sub

    ' Handle a new XML-RPC request
    Private Sub _ur_OnXmlRpcServerRequest(sender As Object, request As XmlRpcEventArg)
        Dim waitHandle = New AutoResetEvent(False)

        ' Open dialog in main thread
        MainForm.InvokeOnMainForm(New Action(Sub()
                                                 Dim dlg = New XmlRpcPopup(request, waitHandle)

                                                 dlg.ShowDialog(MainForm.Instance)
                                             End Sub))

        ' Wait dialog to close
        waitHandle.WaitOne()
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Remote procedure call (XML-RPC)"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.XmlRpc.Enabled
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        txtLocalIP.Text = If(_ur.PrimaryInterface.LocalEndPoint?.Address?.ToString(), "Enable primary interface to display IP")
        txtXmlRpcPort.Text = _ur.XmlRpc.Port.ToString()
    End Sub
    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub
    Public Sub OnOpen() Implements IUserControl.OnOpen
    End Sub
#End Region

    ' Open sample in explorer
    Private Sub linkXmlRpcSample_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim samplePath = Path.Combine(Path.Combine(Path.GetDirectoryName(GetType(MainForm).Assembly.Location), "Samples"), "xml_rpc_sample.urp")
        RevealFile(samplePath)
    End Sub
End Class
