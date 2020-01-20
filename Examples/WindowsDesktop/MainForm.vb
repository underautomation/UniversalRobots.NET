Imports UnderAutomation.UniversalRobots

Public Class MainForm
    Private WithEvents _interface As New UR()

    Public Sub New()
        InitializeComponent()

        ' change here if you have a valid license
        Dim license = New LicenseInfo(licenseIdentifier:=Nothing, licenseKey:=Nothing)
        txtLicense.Text = license.ToString

        licGrid.SetSelectedObject(license)

    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            _interface.Connect(txtIP.Text)
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Try
            _interface.Disconnect()
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub tmrConnected_Tick(sender As Object, e As EventArgs) Handles tmrConnected.Tick
        Try
            If _interface.Connected Then
                lblConnected.Text = "Connected"
                lblConnected.ForeColor = Color.Green
            Else
                lblConnected.Text = "Disconnected"
                lblConnected.ForeColor = Color.Red
            End If
        Catch
        End Try
    End Sub

    Private Sub _interface_InternalErrorOccured(sender As Object, e As InternalErrorEventArgs) Handles _interface.InternalErrorOccured
        HandleEx(e.ToString())
    End Sub

    Private Sub _interface_AdditionalInfoReceived(sender As Object, e As AdditionalInfoPackageEventArgs) Handles _interface.AdditionalInfoReceived
        gridAdditionnalInfo.SetSelectedObject(e)
    End Sub

    Private Sub _interface_CartesianInfoReceived(sender As Object, e As CartesianInfoPackageEventArgs) Handles _interface.CartesianInfoReceived
        gridCartesian.SetSelectedObject(e)
    End Sub

    Private Sub _interface_ConfigurationDataReceived(sender As Object, e As ConfigurationDataPackageEventArgs) Handles _interface.ConfigurationDataReceived
        gridConfiguration.SetSelectedObject(e)
    End Sub

    Private Sub _interface_ForceModeDataReceived(sender As Object, e As ForceModeDataPackageEventArgs) Handles _interface.ForceModeDataReceived
        gridForce.SetSelectedObject(e)
    End Sub

    Private Sub _interface_JointDataReceived(sender As Object, e As JointDataPackageEventArgs) Handles _interface.JointDataReceived
        gridJointData.SetSelectedObject(e)
    End Sub

    Private Sub _interface_MasterboardDataReceived(sender As Object, e As MasterboardDataPackageEventArgs) Handles _interface.MasterboardDataReceived
        gridMasterboard.SetSelectedObject(e)
    End Sub

    Private Sub _interface_RobotModeDataReceived(sender As Object, e As RobotModeDataPackageEventArgs) Handles _interface.RobotModeDataReceived
        gridRobotMode.SetSelectedObject(e)
    End Sub
    Private Sub _interface_ToolCommunicationInfoReceived(sender As Object, e As ToolCommunicationInfoPackageEventArgs) Handles _interface.ToolCommunicationInfoReceived
        GridToolCommunication.SetSelectedObject(e)
    End Sub

    Private Sub _interface_ToolDataReceived(sender As Object, e As ToolDataPackageEventArgs) Handles _interface.ToolDataReceived
        gridTool.SetSelectedObject(e)
    End Sub
    Private Sub _interface_ToolDataReceived(sender As Object, e As ToolModeInfoPackageEventArgs) Handles _interface.ToolModeInfoReceived
        gridToolModeInfo.SetSelectedObject(e)
    End Sub

    Private Sub _interface_KinematicsInfoReceived(sender As Object, e As KinematicsInfoPackageEventArgs) Handles _interface.KinematicsInfoReceived
        gridKinematicsData.SetSelectedObject(e)
    End Sub

    Private Sub btnAck_Click(sender As Object, e As EventArgs) Handles btnAck.Click
        txtErrors.Clear()
    End Sub

    Private Sub HandleEx(message As String)
        If InvokeRequired Then
            Invoke(Sub() HandleEx(message))
        Else
            txtErrors.AppendText(message)
            txtErrors.AppendText(vbNewLine)
            txtErrors.AppendText(vbNewLine)
            txtErrors.ScrollToCaret()
        End If
    End Sub
    Private Sub HandleEx(ex As Exception)
        HandleEx(ex.Message)
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            _interface.Send(txtScript.Text)
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub linkDoc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDoc.LinkClicked
        Try
            Process.Start("https://underautomation.github.io/documentation?fromDesktopWinforms")
        Catch
        End Try
    End Sub
End Class
