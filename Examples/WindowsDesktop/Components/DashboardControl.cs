using System;
using System.Drawing;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.Dashboard;

public partial class DashboardControl : UserControl, IUserControl
{
    UR _ur;
    public DashboardControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();

        // fill enum combos
        foreach (var value in Enum.GetValues(typeof(UserRoles))) cbUserRoles.Items.Add(value);
        cbUserRoles.SelectedItem = UserRoles.Operator;
        foreach (var value in Enum.GetValues(typeof(OperationalModes))) cbOperationalMode.Items.Add(value);
        cbOperationalMode.SelectedItem = OperationalModes.Automatic;
    }

    #region IUserControl
    public string Title => "Dashboard (Remote send commands)";

    public bool FeatureEnabled => !string.IsNullOrEmpty(_ur.Dashboard.IP);

    public void PeriodicUpdate()
    {
        pnlMain.Enabled = FeatureEnabled;
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    // Append command response to the console text area
    private void Log(CommandResponse response, string command, string messageBefore=null, string messageAfter=null)
    {
        txtConsole.AppendText(command);
        txtConsole.AppendText("()\r\n");

        txtConsole.SelectionBullet = true;
        if (response.Succeed)
        {
            txtConsole.SelectionColor = Color.Green;
            txtConsole.AppendText("OK : ");
        }
        else
        {
            txtConsole.SelectionColor = Color.Red;
            txtConsole.AppendText("FAILED : ");
        }

        if(messageBefore != null) txtConsole.AppendText(messageBefore);
        txtConsole.AppendText(response.ToString() ?? "");
        if (messageAfter != null) txtConsole.AppendText(messageAfter);


        txtConsole.SelectionBullet = false;
        txtConsole.SelectionColor = Color.White;
        txtConsole.AppendText("\r\n\r\n> ");
        txtConsole.ScrollToCaret();
    }

    #region Command clicks
    private void btnGetRobotMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetRobotMode();
        Log(response, "GetRobotMode");
    }

    private void btnPowerOn_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.PowerOn();
        Log(response, "PowerOn");
    }

    private void btnPowerOff_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.PowerOff();
        Log(response, "PowerOff");
    }

    private void ReaseBrake_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.ReleaseBrake();
        Log(response, "ReleaseBrake");
    }

    private void btnUnlockProtectiveStop_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.UnlockProtectiveStop();
        Log(response, "UnlockProtectiveStop");
    }

    private void btnShutdown_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.Shutdown();
        Log(response, "Shutdown");
    }

    private void btnLoadProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.LoadProgram(txtProgram.Text);
        Log(response, "LoadProgram");

        Config.Current.LoadProgram = txtProgram.Text;
        Config.Save();
    }

    private void btnGetLoadedProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetLoadedProgram();
        Log(response, "GetLoadedProgram");
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.Play();
        Log(response, "Play");
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.Stop();
        Log(response, "Stop");
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.Pause();
        Log(response, "Pause");
    }

    private void btnProgrammRunning_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.IsProgramRunning();
        Log(response, "IsProgramRunning");
    }

    private void btnGetProgramState_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetProgramState();
        Log(response, "GetProgramState");
    }

    private void btnIsProgramSaved_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.IsProgramSaved();
        Log(response, "IsProgramSaved");
    }

    private void btnShowPopup_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.ShowPopup(txtPopup.Text);
        Log(response, "ShowPopup");

        Config.Current.ShowPopup = txtPopup.Text;
        Config.Save();
    }

    private void btnClosePopup_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.ClosePopup();
        Log(response, "ClosePopup");
    }

    private void btnAddToLog_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.AddToLog(txtLog.Text);
        Log(response, "AddToLog");

        Config.Current.AddToLog = txtLog.Text;
        Config.Save();
    }

    private void btnPolyscopeVersion_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetPolyscopeVersion();
        Log(response, "GetPolyscopeVersion");
    }

    private void btnLoadInstallation_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.LoadInstallation(txtInstallation.Text);
        Log(response, "LoadInstallation");

        Config.Current.LoadInstallation = txtInstallation.Text;
        Config.Save();
    }

    private void btnGetSerialNumber_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetSerialNumber();
        Log(response, "GetSerialNumber");
    }

    private void btnGetRobotModel_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetRobotModel();
        Log(response, "GetRobotModel");
    }

    private void btnGetOperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetOperationalMode();
        Log(response, "GetOperationalMode");
    }

    private void btnClearOIperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.ClearOperationalMode();
        Log(response, "ClearOperationalMode");
    }

    private void btnSetOperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.SetOperationalMode((OperationalModes)cbOperationalMode.SelectedItem);
        Log(response, "SetOperationalMode");
    }

    private void btnSetUserRole_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.SetUserRole((UserRoles)cbUserRoles.SelectedItem);
        Log(response, "SetUserRole");
    }

    private void btnIsInRemoteControl_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.IsInRemoteControl();
        Log(response, "IsInRemoteControl");
    }

    private void btnSafetyStatus_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetSafetyStatus();
        Log(response, "GetSafetyStatus");
    }

    private void btnCloseSafetyPopup_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.CloseSafetyPopup();
        Log(response, "CloseSafetyPopup");
    }

    private void btnRestartSafety_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.RestartSafety();
        Log(response, "RestartSafety");
    }

    private void txtSendCustomCommand_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.SendCustomDashboardCommand(txtCustomCommand.Text);
        Log(response, "SendCustomDashboardCommand");
    }

    private void btnGetVariableValue_Click(object sender, EventArgs e)
    {
        var response = _ur.Dashboard.GetVariable(txtVariableName.Text);
        if(response.Value.Type == GlobalVariableTypes.None)
        {
            Log(response, "GetVariableValue", $"Variable {txtVariableName.Text} is not declared. ");
        }
        else
        {
            Log(response, "GetVariableValue", response.Succeed ? $"{response.Value.Type} {response.Value.Name} = " : "");
        }
    }
    #endregion

}
