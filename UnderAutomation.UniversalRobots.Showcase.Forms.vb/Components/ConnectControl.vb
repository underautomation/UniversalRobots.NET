Imports System
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.Rtde

Public Partial Class ConnectControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR

    Private _rtdeOutputSetup As RtdeOutputSetup
    Private _rtdeInputSetup As RtdeInputSetup


    Public Sub New(ur As UR)
        _ur = ur
        InitializeComponent()

        Dim parameters = If(Config.Current.ConnectParameters, New ConnectParameters())

        ' Use stored information or set to default
        txtIP.Text = If(parameters.IP, "192.168.0.1")
        chkPrimaryInterface.Checked = parameters.PrimaryInterface.Enable
        chkDashboard.Checked = parameters.Dashboard.Enable
        chkInterpreterMode.Checked = parameters.InterpreterMode.Enable
        chkXmlRpc.Checked = parameters.XmlRpc.Enable
        udXmlRpcPort.Value = parameters.XmlRpc.Port
        chkSsh.Checked = parameters.Ssh.EnableSsh
        chkSftp.Checked = parameters.Ssh.EnableSftp
        txtUsername.Text = parameters.Ssh.Username
        txtPassword.Text = parameters.Ssh.Password
        chkSocket.Checked = parameters.SocketCommunication.Enable
        udSocketPort.Value = parameters.SocketCommunication.Port
        chkRTDE.Checked = parameters.Rtde.Enable
        udFrequency.Value = CDec(parameters.Rtde.Frequency)
        radioV1.Checked = parameters.Rtde.Version = RtdeVersions.V1
        radioV2.Checked = parameters.Rtde.Version = RtdeVersions.V2

        _rtdeOutputSetup = parameters.Rtde.OutputSetup
        _rtdeInputSetup = parameters.Rtde.InputSetup

        UpdateRtdeIndicators()
    End Sub

#Region "IUserControl"
    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.Enabled
        End Get
    End Property

    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Connection"
        End Get
    End Property

    Public Sub OnClose() Implements IUserControl.OnClose
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
    End Sub

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        Dim connected = FeatureEnabled
        btnDisconnect.Enabled = connected
        btnConnect.Text = If(connected, "Reconnect", "Connect")
        lblConnected.Text = If(connected, "Connected", "Disconnected")
        lblConnected.ForeColor = If(connected, Color.Green, Color.Red)
    End Sub
#End Region

    Private Sub btnConnect_Click(sender As Object, e As EventArgs)
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return

        Dim parameters = New ConnectParameters()
        parameters.IP = txtIP.Text
        parameters.PrimaryInterface.Enable = chkPrimaryInterface.Checked
        parameters.Dashboard.Enable = chkDashboard.Checked
        parameters.InterpreterMode.Enable = chkInterpreterMode.Checked
        parameters.XmlRpc.Enable = chkXmlRpc.Checked
        parameters.XmlRpc.Port = CInt(udXmlRpcPort.Value)
        parameters.Ssh.EnableSsh = chkSsh.Checked
        parameters.Ssh.EnableSftp = chkSftp.Checked
        parameters.Ssh.Username = txtUsername.Text
        parameters.Ssh.Password = txtPassword.Text
        parameters.SocketCommunication.Enable = chkSocket.Checked
        parameters.SocketCommunication.Port = CInt(udSocketPort.Value)
        parameters.Rtde.Enable = chkRTDE.Checked
        parameters.Rtde.OutputSetup = _rtdeOutputSetup
        parameters.Rtde.Frequency = udFrequency.Value
        parameters.Rtde.InputSetup = _rtdeInputSetup
        parameters.Rtde.Version = If(radioV1.Checked, RtdeVersions.V1, RtdeVersions.V2)

        ' Store information
        Config.Current.ConnectParameters = parameters
        Config.Save()

        ' Connect to the robot
        _ur.Connect(parameters)
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs)
        ' Disconnect all services
        _ur.Disconnect()
    End Sub

#Region "RTDE"
    Private Sub btnRtdeOutputs_Click(sender As Object, e As EventArgs)
        Dim popup = New ConnectRtdePopupOutput("Select output RTDE data to read", _rtdeOutputSetup, RtdeClient.AllOutputsDescription.Items.OfType(Of RtdeDataDescription(Of RtdeOutputData))())
        If popup.ShowDialog() = DialogResult.OK Then
            _rtdeOutputSetup = popup.Setup
            UpdateRtdeIndicators()
        End If
    End Sub

    Private Sub btnRtdeInputs_Click(sender As Object, e As EventArgs)
        Dim popup = New ConnectRtdePopupInput("Select input RTDE data to write", _rtdeInputSetup, RtdeClient.AllInputsDescription.Items.OfType(Of RtdeDataDescription(Of RtdeInputData))())
        If popup.ShowDialog() = DialogResult.OK Then
            _rtdeInputSetup = popup.Setup
            UpdateRtdeIndicators()
        End If
    End Sub


    Private Sub lnkMaxFrequency_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        udFrequency.Value = 0
    End Sub


    Private Sub UpdateRtdeIndicators()
        lblRtdeOutputs.Text = $"{If(_rtdeOutputSetup Is Nothing, 0, _rtdeOutputSetup.Count)} data selected"
        lblRtdeInputs.Text = $"{If(_rtdeOutputSetup Is Nothing, 0, _rtdeInputSetup.Count)} data selected"
    End Sub
#End Region

    Private Sub radioV1_CheckedChanged(sender As Object, e As EventArgs)
        Dim enabled = Not radioV1.Checked
        udFrequency.Enabled = enabled
        lnkMaxFrequency.Enabled = enabled
        lblHz.Enabled = enabled
        lblFrequency.Enabled = enabled
    End Sub
End Class
