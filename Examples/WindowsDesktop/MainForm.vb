Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Text
Imports UnderAutomation.UniversalRobots
Imports System.Linq
Imports System.Text.RegularExpressions
Imports System.Threading
Imports UnderAutomation.UniversalRobots.SSH.Common
Imports System.ComponentModel

Public Class MainForm

    Shared Sub New()
        TypeDescriptor.AddAttributes(GetType(SSH.SshCommand), New ReadOnlyAttribute(True))
        TypeDescriptor.AddAttributes(GetType(SSH.Sftp.SftpFile), New ReadOnlyAttribute(True))
    End Sub


    ' instance of the UR connection
    Private WithEvents _ur As New UR()

#Region "Initialization"
    Public Sub New()
        InitializeComponent()

        ' change here if you have a valid license
        Dim license = New LicenseInfo(licenseIdentifier:=Nothing, licenseKey:=Nothing)
        txtLicense.Text = license.ToString

        ' show current license state
        licGrid.SetSelectedObject(license)

        ' fill enums
        For Each value In [Enum].GetValues(GetType(UserRoles))
            cbUserRoles.Items.Add(value)
        Next
        cbUserRoles.SelectedItem = UserRoles.Operator

        cbOperationalMode.Items.Add(OperationalModes.Automatic)
        cbOperationalMode.Items.Add(OperationalModes.Manual)
        cbOperationalMode.SelectedItem = OperationalModes.Automatic

        txtIP.Text = My.Settings.ip
        If String.IsNullOrEmpty(txtIP.Text) Then
            txtIP.Text = "192.168.0.1"
        End If
    End Sub

    ' Disconnect robot on form closing
    Protected Overrides Sub OnFormClosing(e As FormClosingEventArgs)
        MyBase.OnFormClosing(e)

        Try
            _ur.Disconnect()
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub
#End Region


#Region "Errors"
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

    Private Sub btnAck_Click(sender As Object, e As EventArgs) Handles btnAck.Click
        txtErrors.Clear()
    End Sub

#End Region


#Region "Header info"
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            ' connect to the robot
            _ur.Connect(txtIP.Text)

            My.Settings.ip = txtIP.Text
            My.Settings.Save()

            ' get IP of the local network interface connected to the robot
            txtLocalIP.Text = _ur.DataStreamingLocalEndPoint.Address.ToString()
            udXmlRpcPort.Value = 50000

            _shell = _ur.SSH?.CreateShellStream("UnderAutomation demo", 40, 100, 40, 100, 1000)

            InitializeFtp()

        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub txtIP_KeyDown(sender As Object, e As KeyEventArgs) Handles txtIP.KeyDown, txtLocalIP.KeyDown, txtXmlRpcPort.KeyDown
        If e.KeyData = Keys.Enter Then
            btnConnect_Click(sender, e)
        End If
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Try
            _ur.Disconnect()
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            _ur.Send(txtScript.Text)
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub linkDoc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkDoc.LinkClicked
        Try
            Process.Start("https://underautomation.com/universal-robots/documentation?f")
        Catch
        End Try
    End Sub

    ' refresh status labels
    Private Sub tmrConnected_Tick(sender As Object, e As EventArgs) Handles tmrConnected.Tick
        Try
            Dim dataStreamingEnabled = _ur.DataStreamingEnabled
            If dataStreamingEnabled Then
                lblConnected.Text = "Connected"
                lblConnected.ForeColor = Color.Green
            Else
                lblConnected.Text = "Disconnected"
                lblConnected.ForeColor = Color.Red
            End If

            txtIP.Enabled = Not dataStreamingEnabled
            btnConnect.Enabled = Not dataStreamingEnabled
            btnDisconnect.Enabled = dataStreamingEnabled
        Catch
        End Try

        Try
            Dim xmlRpcServerEnabled = _ur.XmlRpcServerEnabled
            If xmlRpcServerEnabled Then
                txtXmlRpcStatus.Text = "Enabled"
                txtXmlRpcStatus.ForeColor = Color.Green
            Else
                txtXmlRpcStatus.Text = "Disabled"
                txtXmlRpcStatus.ForeColor = Color.Red
            End If

            udXmlRpcPort.Enabled = Not xmlRpcServerEnabled
            btnEnableXmlRpcServer.Enabled = Not xmlRpcServerEnabled
            btnDisableXmlRpcServer.Enabled = xmlRpcServerEnabled
        Catch
        End Try

        ' blink tab icon
        tabCommands.ImageIndex = (tabCommands.ImageIndex + 1) Mod 2
    End Sub

    Private Sub tabCommands_Click(sender As Object, e As EventArgs) Handles mainTabControl.Selected
        ' stop tab icon blinking
        If mainTabControl.SelectedTab Is tabCommands Then mainTabControl.ImageList = Nothing
    End Sub
#End Region

#Region "Data streaming"
    Private Sub ur_AdditionalInfoReceived(sender As Object, e As AdditionalInfoPackageEventArgs) Handles _ur.AdditionalInfoReceived
        gridAdditionnalInfo.SetSelectedObject(e)
    End Sub

    Private Sub ur_CartesianInfoReceived(sender As Object, e As CartesianInfoPackageEventArgs) Handles _ur.CartesianInfoReceived
        gridCartesian.SetSelectedObject(e)
    End Sub

    Private Sub ur_ConfigurationDataReceived(sender As Object, e As ConfigurationDataPackageEventArgs) Handles _ur.ConfigurationDataReceived
        gridConfiguration.SetSelectedObject(e)
    End Sub

    Private Sub ur_ForceModeDataReceived(sender As Object, e As ForceModeDataPackageEventArgs) Handles _ur.ForceModeDataReceived
        gridForce.SetSelectedObject(e)
    End Sub

    Private Sub ur_JointDataReceived(sender As Object, e As JointDataPackageEventArgs) Handles _ur.JointDataReceived
        gridJointData.SetSelectedObject(e)
    End Sub

    Private Sub ur_MasterboardDataReceived(sender As Object, e As MasterboardDataPackageEventArgs) Handles _ur.MasterboardDataReceived
        gridMasterboard.SetSelectedObject(e)
    End Sub

    Private Sub ur_RobotModeDataReceived(sender As Object, e As RobotModeDataPackageEventArgs) Handles _ur.RobotModeDataReceived
        gridRobotMode.SetSelectedObject(e)
    End Sub
    Private Sub ur_ToolCommunicationInfoReceived(sender As Object, e As ToolCommunicationInfoPackageEventArgs) Handles _ur.ToolCommunicationInfoReceived
        GridToolCommunication.SetSelectedObject(e)
    End Sub

    Private Sub ur_ToolDataReceived(sender As Object, e As ToolDataPackageEventArgs) Handles _ur.ToolDataReceived
        gridTool.SetSelectedObject(e)
    End Sub
    Private Sub ur_ToolDataReceived(sender As Object, e As ToolModeInfoPackageEventArgs) Handles _ur.ToolModeInfoReceived
        gridToolModeInfo.SetSelectedObject(e)
    End Sub

    Private Sub ur_KinematicsInfoReceived(sender As Object, e As KinematicsInfoPackageEventArgs) Handles _ur.KinematicsInfoReceived
        gridKinematicsData.SetSelectedObject(e)
    End Sub
#End Region


#Region "Commands"
    Private Sub LogCommand(action As Func(Of CommandResponse), command As String)
        Try
            txtConsole.AppendText(command)
            txtConsole.AppendText("()")
            txtConsole.AppendText(vbCrLf)

            Dim response = action()

            txtConsole.SelectionBullet = True
            If response.Succeed Then
                txtConsole.SelectionColor = Color.Green
                txtConsole.AppendText("OK : ")
            Else
                txtConsole.SelectionColor = Color.Red
                txtConsole.AppendText("FAILED : ")
            End If

            txtConsole.AppendText(response.ToString)

        Catch ex As Exception
            txtConsole.SelectionColor = Color.DarkRed
            txtConsole.AppendText(ex.Message)
        End Try

        txtConsole.SelectionBullet = False
        txtConsole.SelectionColor = Color.White
        txtConsole.AppendText(vbNewLine)
        txtConsole.AppendText(vbNewLine)
        txtConsole.AppendText("> ")
        txtConsole.ScrollToCaret()

    End Sub

    Private Sub btnProgrammRunning_Click(sender As Object, e As EventArgs) Handles btnProgrammRunning.Click
        LogCommand(Function()

                       Return _ur.IsProgramRunning()

                   End Function,
                   "IsProgramRunning")
    End Sub

    Private Sub btnGetRobotMode_Click(sender As Object, e As EventArgs) Handles btnGetRobotMode.Click
        LogCommand(Function()

                       Return _ur.GetRobotMode()

                   End Function,
                   "GetRobotMode")
    End Sub

    Private Sub btnLoadProgram_Click(sender As Object, e As EventArgs) Handles btnLoadProgram.Click
        LogCommand(Function()

                       Return _ur.LoadProgram(txtProgram.Text)

                   End Function,
                   "LoadProgram")
    End Sub

    Private Sub btnPlay_Click(sender As Object, e As EventArgs) Handles btnPlay.Click
        LogCommand(Function()

                       Return _ur.Play()

                   End Function,
                   "Play")
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        LogCommand(Function()

                       Return _ur.Stop()

                   End Function,
                   "Stop")

    End Sub

    Private Sub btnPause_Click(sender As Object, e As EventArgs) Handles btnPause.Click
        LogCommand(Function()

                       Return _ur.Pause()

                   End Function,
                   "Pause")

    End Sub

    Private Sub btnShutdown_Click(sender As Object, e As EventArgs) Handles btnShutdown.Click
        LogCommand(Function()

                       Return _ur.Shutdown()

                   End Function,
                   "Shutdown")

    End Sub

    Private Sub btnGetLoadedProgram_Click(sender As Object, e As EventArgs) Handles btnGetLoadedProgram.Click
        LogCommand(Function()

                       Return _ur.GetLoadedProgram()

                   End Function,
                   "GetLoadedProgram")

    End Sub

    Private Sub btnShowPopup_Click(sender As Object, e As EventArgs) Handles btnShowPopup.Click
        LogCommand(Function()

                       Return _ur.ShowPopup(txtPopup.Text)

                   End Function,
                   "ShowPopup")

    End Sub

    Private Sub btnClosePopup_Click(sender As Object, e As EventArgs) Handles btnClosePopup.Click
        LogCommand(Function()

                       Return _ur.ClosePopup()

                   End Function,
                   "ClosePopup")

    End Sub

    Private Sub btnAddToLog_Click(sender As Object, e As EventArgs) Handles btnAddToLog.Click
        LogCommand(Function()

                       Return _ur.AddToLog(txtLog.Text)

                   End Function,
                   "AddToLog")

    End Sub

    Private Sub btnIsProgramSaved_Click(sender As Object, e As EventArgs) Handles btnIsProgramSaved.Click
        LogCommand(Function()

                       Return _ur.IsProgramSaved()

                   End Function,
                   "IsProgramSaved")

    End Sub

    Private Sub btnGetProgramState_Click(sender As Object, e As EventArgs) Handles btnGetProgramState.Click
        LogCommand(Function()

                       Return _ur.GetProgramState()

                   End Function,
                   "GetProgramState")

    End Sub

    Private Sub btnPolyscopeVersion_Click(sender As Object, e As EventArgs) Handles btnPolyscopeVersion.Click
        LogCommand(Function()

                       Return _ur.GetPolyscopeVersion()

                   End Function,
                   "GetPolyscopeVersion")

    End Sub

    Private Sub btnSetUserRole_Click(sender As Object, e As EventArgs) Handles btnSetUserRole.Click
        LogCommand(Function()

                       Return _ur.SetUserRole(CType(cbUserRoles.SelectedItem, UserRoles))

                   End Function,
                   "LoadProgram")

    End Sub

    Private Sub btnPowerOn_Click(sender As Object, e As EventArgs) Handles btnPowerOn.Click
        LogCommand(Function()

                       Return _ur.PowerOn()

                   End Function,
                   "PowerOn")

    End Sub

    Private Sub btnPowerOff_Click(sender As Object, e As EventArgs) Handles btnPowerOff.Click
        LogCommand(Function()

                       Return _ur.PowerOff()

                   End Function,
                   "PowerOff")

    End Sub

    Private Sub ReaseBrake_Click(sender As Object, e As EventArgs) Handles ReaseBrake.Click
        LogCommand(Function()

                       Return _ur.ReleaseBrake()

                   End Function,
                   "ReleaseBrake")

    End Sub

    Private Sub btnUnlockProtectiveStop_Click(sender As Object, e As EventArgs) Handles btnUnlockProtectiveStop.Click
        LogCommand(Function()

                       Return _ur.UnlockProtectiveStop()

                   End Function,
                   "UnlockProtectiveStop")

    End Sub

    Private Sub btnCloseSafetyPopup_Click(sender As Object, e As EventArgs) Handles btnCloseSafetyPopup.Click
        LogCommand(Function()

                       Return _ur.CloseSafetyPopup()

                   End Function,
                   "CloseSafetyPopup")

    End Sub

    Private Sub btnLoadInstallation_Click(sender As Object, e As EventArgs) Handles btnLoadInstallation.Click
        LogCommand(Function()

                       Return _ur.LoadInstallation(txtInstallation.Text)

                   End Function,
                   "LoadInstallation")

    End Sub

    Private Sub btnRestartSafety_Click(sender As Object, e As EventArgs) Handles btnRestartSafety.Click
        LogCommand(Function()

                       Return _ur.RestartSafety()
                   End Function,
                   "RestartSafety")

    End Sub

    Private Sub btnSafetyStatus_Click(sender As Object, e As EventArgs) Handles btnSafetyStatus.Click
        LogCommand(Function()

                       Return _ur.GetSafetyStatus()

                   End Function,
                   "GetSafetyStatus")

    End Sub

    Private Sub btnGetSerialNumber_Click(sender As Object, e As EventArgs) Handles btnGetSerialNumber.Click
        LogCommand(Function()

                       Return _ur.GetSerialNumber()

                   End Function,
                   "GetSerialNumber")

    End Sub

    Private Sub btnGetRobotModel_Click(sender As Object, e As EventArgs) Handles btnGetRobotModel.Click
        LogCommand(Function()

                       Return _ur.GetRobotModel()

                   End Function,
                   "GetRobotModel")

    End Sub

    Private Sub btnIsInRemoteControl_Click(sender As Object, e As EventArgs) Handles btnIsInRemoteControl.Click
        LogCommand(Function()

                       Return _ur.IsInRemoteControl()

                   End Function,
                   "IsInRemoteControl")

    End Sub

    Private Sub btnGetOperationalMode_Click(sender As Object, e As EventArgs) Handles btnGetOperationalMode.Click
        LogCommand(Function()

                       Return _ur.GetOperationalMode()

                   End Function,
                   "GetOperationalMode")

    End Sub

    Private Sub btnClearOIperationalMode_Click(sender As Object, e As EventArgs) Handles btnClearOIperationalMode.Click
        LogCommand(Function()

                       Return _ur.ClearOperationalMode()

                   End Function,
                   "ClearOperationalMode")

    End Sub

    Private Sub btnSetOperationalMode_Click(sender As Object, e As EventArgs) Handles btnSetOperationalMode.Click
        LogCommand(Function()

                       Return _ur.SetOperationalMode(CType(cbOperationalMode.SelectedItem, OperationalModes))

                   End Function,
                   "SetOperationalMode")

    End Sub
#End Region

#Region "XML-RPC"
    Private Sub _ur_OnXmlRpcServerRequest(sender As Object, request As XmlRpcEventArg) Handles _ur.XmlRpcServerRequest

        Dim waitHandle = New AutoResetEvent(False)

        Me.Invoke(Sub()
                      Dim dlg = New XmlRpcPopup(request, waitHandle)

                      dlg.ShowDialog()
                  End Sub)

        waitHandle.WaitOne()
    End Sub

    Private Sub btnEnableXmlRpcServer_Click(sender As Object, e As EventArgs) Handles btnEnableXmlRpcServer.Click
        Try
            _ur.EnableXmlRpcServer(CInt(udXmlRpcPort.Value))
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub btnDisableXmlRpcServer_Click(sender As Object, e As EventArgs) Handles btnDisableXmlRpcServer.Click
        Try
            _ur.DisableXmlRpcServer()
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub udXmlRpcPort_ValueChanged(sender As Object, e As EventArgs) Handles udXmlRpcPort.ValueChanged
        txtXmlRpcPort.Text = udXmlRpcPort.Value.ToString
    End Sub

    Private Sub linkXmlRpcSample_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles linkXmlRpcSample.LinkClicked
        Dim samplePath = Path.Combine(Path.GetDirectoryName(GetType(MainForm).Assembly.Location), "Samples", "xml_rpc_sample.urp")
        Process.Start("explorer.exe", $"/select,""{samplePath}""")
    End Sub
#End Region

#Region "Tools"
    ' convert poses types
    Private Sub radioRPYToRotationVector_CheckedChanged(sender As Object, e As EventArgs) Handles radioRPYToRotationVector.CheckedChanged, udRx.ValueChanged, udRy.ValueChanged, udRz.ValueChanged

        Dim inPose = New Pose(0, 0, 0, udRx.Value, udRy.Value, udRz.Value)

        Dim outPose As Pose = Nothing

        If radioRPYToRotationVector.Checked Then

            ' Convert from RPY to Rotation vector
            outPose = inPose.FromRPYToRotationVector

            txtIn.Text = "RPY"
            txtOut.Text = "Rotation Vector"
        Else

            ' Convert from Rotation vector to RPY
            outPose = inPose.FromRotationVectorToRPY

            txtIn.Text = "Rotation Vector"
            txtOut.Text = "RPY"
        End If

        txtRx.Text = $"{outPose.Rx} rad"
        txtRy.Text = $"{outPose.Ry} rad"
        txtRz.Text = $"{outPose.Rz} rad"
    End Sub



#End Region


#Region "SSH"
    Private WithEvents _shell As SSH.ShellStream

    Private Sub _shell_DataReceived(sender As Object, e As ShellDataEventArgs) Handles _shell.DataReceived
        If txtShellHistory.InvokeRequired Then
            txtShellHistory.Invoke(Sub() shell_DataReceived(e))
        Else
            shell_DataReceived(e)
        End If
    End Sub

    ''' Display received SSH data
    Private Sub shell_DataReceived(e As ShellDataEventArgs)
        Dim rawData = Encoding.UTF8.GetString(e.Data)

        ' remove ANSI data from answer (for example color infos)
        Dim data = Regex.Replace(rawData, "(\x9B|\x1B\[)[0-?]*[ -\/]*[@-~]", "")

        txtShellHistory.AppendText(data)

        txtShellHistory.ScrollToCaret()
    End Sub

    Private Sub _shell_ErrorOccurred(sender As Object, e As ExceptionEventArgs) Handles _shell.ErrorOccurred
        If txtShellHistory.InvokeRequired Then
            txtShellHistory.Invoke(Sub() shell_ErrorOccurred(e.Exception.Message))
        Else
            shell_ErrorOccurred(e.Exception.Message)
        End If
    End Sub

    Private Sub shell_ErrorOccurred(message As String)
        txtShellHistory.AppendText(vbNewLine & vbNewLine & " --- ERROR ---" & vbNewLine & message & vbNewLine & vbNewLine)
    End Sub

    ' Send command line in shell
    Private Sub btnSendShell_Click(sender As Object, e As EventArgs) Handles btnSendShell.Click, txtShellCommand.KeyDown
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return

        If String.IsNullOrEmpty(txtShellCommand.Text) Then Return

        _shell.WriteLine(txtShellCommand.Text)

        txtShellCommand.Text = ""
    End Sub

    Private Sub btnSSHSend_Click(sender As Object, e As EventArgs) Handles btnSSHSend.Click, txtSSHCommand.KeyDown
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return

        If String.IsNullOrEmpty(txtSSHCommand.Text) Then Return


        Dim command = _ur.SSH.CreateCommand(txtSSHCommand.Text)

        command.Execute()

        gridSSHResult.SelectedObject = command
    End Sub

#End Region


#Region "SFTP"

    Public Sub InitializeFtp()
        FillList("/")
    End Sub

    Private Sub FillList(path As String)
        lstFolder.Items.Clear()


        If Not _ur.SftpEnabled Then
            Return
        End If

        Try
            path = path.Replace("\", "/")
            If Not path.EndsWith("/") Then path = path & "/"

            txtPath.Text = path

            Dim files = _ur.SFTP.ListDirectory(path)

            For Each file In files

                ' do not display special folders
                If file.Name = "." OrElse file.Name = ".." Then Continue For

                Dim itm = lstFolder.Items.Add(file.Name)

                itm.Tag = file

                If file.IsDirectory Then
                    itm.ImageKey = "folder"
                ElseIf file.IsSymbolicLink Then
                    itm.ImageKey = "symbolicLink"
                Else
                    itm.ImageKey = "file"
                End If
            Next
        Catch ex As Exception
            HandleEx(ex)
        End Try

    End Sub


    Private Sub lstFolder_ItemActivate(sender As Object, e As EventArgs) Handles lstFolder.ItemActivate
        Dim file = TryCast(lstFolder.SelectedItems?.OfType(Of ListViewItem)?.FirstOrDefault?.Tag, SSH.Sftp.SftpFile)

        If file Is Nothing OrElse (Not file.IsDirectory AndAlso Not file.IsSymbolicLink) Then Return

        FillList(file.FullName)
    End Sub

    Private Sub lstFolder_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles lstFolder.ItemSelectionChanged
        gridFile.SelectedObject = e.Item?.Tag
    End Sub
    Private Sub lstFolder_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstFolder.SelectedIndexChanged
        If lstFolder.SelectedItems.Count = 0 Then gridFile.SelectedObject = Nothing
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Dim p = GetPath().TrimEnd("/"c)
        If p = "" Then Return
        FillList(Path.GetDirectoryName(p))
    End Sub

    Private Sub btnOpenPath_Click(sender As Object, e As EventArgs) Handles btnOpenPath.Click, btnRefresh.Click, txtPath.KeyDown
        If TypeOf e Is KeyEventArgs AndAlso CType(e, KeyEventArgs).KeyCode <> Keys.Enter Then Return
        ReloadList()
    End Sub

    Private Sub ReloadList()
        FillList(GetPath())
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If Not _ur.SftpEnabled Then Return

        Try
            For Each itm In lstFolder.SelectedItems.OfType(Of ListViewItem)
                Dim file = TryCast(itm.Tag, SSH.Sftp.SftpFile)

                If file Is Nothing Then Return

                _ur.SFTP.Delete(file.FullName)
                Thread.Sleep(500)
                ReloadList()
            Next
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        Try
            lstFolder.SelectedItems?.OfType(Of ListViewItem)?.FirstOrDefault?.BeginEdit()
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If Not _ur.SftpEnabled Then Return

        Try
            If dlgOpen.ShowDialog() <> DialogResult.OK Then Return


            Using selectedFile = File.OpenRead(dlgOpen.FileName)
                _ur.SFTP.UploadFile(selectedFile, GetPath() & Path.GetFileName(dlgOpen.FileName).Replace("\", "/"))
            End Using

            Thread.Sleep(500)
            ReloadList()
            SelectFile(Path.GetFileName(dlgOpen.FileName))
        Catch ex As Exception
            HandleEx(ex)
        End Try
    End Sub

    Private Function GetPath() As String
        If Not txtPath.Text.EndsWith("/") Then Return txtPath.Text & "/"
        Return txtPath.Text
    End Function

    Private Sub SelectFile(name As String)
        Dim itm = lstFolder.Items.OfType(Of ListViewItem).FirstOrDefault(Function(x) String.Equals(x.Text, name, StringComparison.InvariantCultureIgnoreCase))
        If itm IsNot Nothing Then itm.Selected = True
    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        If Not _ur.SftpEnabled Then Return
        Try
            Dim file = TryCast(lstFolder.SelectedItems.OfType(Of ListViewItem)?.FirstOrDefault?.Tag, SSH.Sftp.SftpFile)

            If file Is Nothing Then Return

            dlgSave.FileName = Path.GetFileName(file.FullName).Replace("\", "/")

            If dlgSave.ShowDialog() <> DialogResult.OK Then Return

            Using selectedFile = IO.File.Open(dlgSave.FileName, FileMode.OpenOrCreate)
                _ur.SFTP.DownloadFile(file.FullName, selectedFile)
            End Using
        Catch ex As Exception
            HandleEx(ex)
        End Try

    End Sub

    Private Sub lstFolder_AfterLabelEdit(sender As Object, e As LabelEditEventArgs) Handles lstFolder.AfterLabelEdit
        If Not _ur.SftpEnabled Then Return

        Try
            Dim file = TryCast(lstFolder.Items(e.Item).Tag, SSH.Sftp.SftpFile)

            If file Is Nothing Then Return

            _ur.SFTP.RenameFile(file.FullName, Path.GetDirectoryName(file.FullName).Replace("\", "/") & "/" & e.Label)

            Thread.Sleep(500)
            ReloadList()
            SelectFile(e.Label)
        Catch ex As Exception
            e.CancelEdit = True
            HandleEx(ex)
        End Try
    End Sub

#End Region


End Class
