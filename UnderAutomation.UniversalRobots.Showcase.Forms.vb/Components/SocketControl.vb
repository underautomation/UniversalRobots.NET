Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Windows.Forms
Imports UnderAutomation.UniversalRobots
Imports UnderAutomation.UniversalRobots.SocketCommunication

Public Partial Class SocketControl
    Inherits UserControl
    Implements IUserControl
    Private _ur As UR

    Public Sub New(ur As UR)
        _ur = ur
        InitializeComponent()

        AddHandler _ur.SocketCommunication.SocketRequest, AddressOf _ur_SocketRequest
        AddHandler _ur.SocketCommunication.SocketGetVar, AddressOf _ur_SocketGetVar
        AddHandler _ur.SocketCommunication.SocketClientConnection, AddressOf _ur_SocketClientConnection
        AddHandler _ur.SocketCommunication.SocketClientDisconnection, AddressOf _ur_SocketClientDisconnection
    End Sub

    Private Sub _ur_SocketClientDisconnection(sender As Object, request As SocketClientDisconnectionEventArgs)
        Log($"Robot disconnection : {request.Client?.EndPoint}")
        UpdateList()
    End Sub

    Private Sub _ur_SocketClientConnection(sender As Object, request As SocketClientConnectionEventArgs)
        Log($"Robot connection : {request.Client?.EndPoint}")
        UpdateList()
    End Sub

    Private Sub _ur_SocketGetVar(sender As Object, request As SocketGetVarEventArgs)
        If Equals(request.Name, "var_a") Then
            request.Value = -10
        Else
            request.Value = 12
        End If
        Log($"Robot {request.Client.EndPoint} calls socket_get_var() : {request.Name}. Answer : {request.Value}")
    End Sub

    Private Sub _ur_SocketRequest(sender As Object, request As SocketRequestEventArgs)
        Log($"Robot {request.Client.EndPoint} socket message : {request.Message}")
    End Sub

    Private LogBuffer As List(Of String) = New List(Of String)()
    Private ReadOnly _lck As Object = New Object()
    Private Sub Log(message As String)
        If LogBuffer Is Nothing Then
            If InvokeRequired Then
                Invoke(New Action(Sub() Log(message)))
            Else
                AppendText(message)
            End If
        Else
            SyncLock _lck
                LogBuffer.Add(message)
            End SyncLock
        End If
    End Sub

    Private Sub AppendText(message As String)
        SyncLock _lck
            txtLog.AppendText(message)
            txtLog.AppendText(Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf)
            txtLog.ScrollToCaret()
        End SyncLock
    End Sub

#Region "IUserControl"
    Public ReadOnly Property Title As String Implements IUserControl.Title
        Get
            Return "Socket communication"
        End Get
    End Property

    Public ReadOnly Property FeatureEnabled As Boolean Implements IUserControl.FeatureEnabled
        Get
            Return _ur.SocketCommunication.Enabled
        End Get
    End Property

    Public Sub PeriodicUpdate() Implements IUserControl.PeriodicUpdate
        txtLocalIP.Text = If(_ur.PrimaryInterface.LocalEndPoint?.Address?.ToString(), "Enable primary interface to display IP")
        txtPort.Text = _ur.SocketCommunication.Port.ToString()
    End Sub

    Public Sub OnClose() Implements IUserControl.OnClose
        SyncLock _lck
            LogBuffer = New List(Of String)()
        End SyncLock
    End Sub

    Public Sub OnOpen() Implements IUserControl.OnOpen
        SyncLock _lck
            If TypeOf LogBuffer Is Object Then
                For Each message In LogBuffer
                    AppendText(message)
                Next
            End If
            LogBuffer = Nothing
        End SyncLock

        btnSend.Enabled = _ur.SocketCommunication.Enabled

        UpdateList()
    End Sub
#End Region

    Private Function GetSelectedClient() As SocketClient
        Return TryCast(lstClients.SelectedItems?.OfType(Of ListViewItem)()?.FirstOrDefault()?.Tag, SocketClient)
    End Function

    Private Sub UpdateList()
        If InvokeRequired Then
            Invoke(New Action(AddressOf UpdateList))
            Return
        End If

        Dim selected = GetSelectedClient()

        lstClients.Items.Clear()
        For Each client In _ur.SocketCommunication.ConnectedClients
            Dim itm = lstClients.Items.Add(New ListViewItem({_ur.SocketCommunication.Port.ToString(), If(client.EndPoint?.Address?.ToString(), ""), If(client.EndPoint?.Port.ToString(), "")}))
            itm.Tag = client

            itm.Selected = selected Is client
        Next

        AfterSelection()
    End Sub

    Private Sub linkSample_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim samplePath = Path.Combine(Path.Combine(Path.GetDirectoryName(GetType(MainForm).Assembly.Location), "Samples"), "socket_sample.urp")
        RevealFile(samplePath)
    End Sub

    Private Sub lstClients_SelectedIndexChanged(sender As Object, e As EventArgs)
        AfterSelection()
    End Sub

    Private Sub AfterSelection()
        Dim selected = GetSelectedClient()

        If selected Is Nothing Then
            btnSend.Text = "Send to all clients"
        Else
            btnSend.Text = $"Send to {selected.EndPoint}"
        End If
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs)
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return
        If Not FeatureEnabled Then Return

        Dim selected = GetSelectedClient()

        If selected Is Nothing Then
            _ur.SocketCommunication.SocketWrite(txtMessage.Text)
        Else
            selected.SocketWrite(txtMessage.Text)
        End If

        Log($"{btnSend.Text} : {txtMessage.Text}")
    End Sub

End Class
