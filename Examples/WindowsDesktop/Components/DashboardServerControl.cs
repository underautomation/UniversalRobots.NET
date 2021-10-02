using System;
using System.Drawing;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class DashboardServerControl : UserControl, IUserControl
{
    UR _ur;
    public DashboardServerControl(UR ur)
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
    public string Title => "Remote commands (Dashboard Server)";

    public bool FeatureEnabled => !string.IsNullOrEmpty(_ur.IP);

    public void PeriodicUpdate()
    {
        pnlMain.Enabled = FeatureEnabled;
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    // Append command response to the console text area
    private void Log(CommandResponse response, string command)
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

        txtConsole.AppendText(response.ToString());


        txtConsole.SelectionBullet = false;
        txtConsole.SelectionColor = Color.White;
        txtConsole.AppendText("\r\n\r\n> ");
        txtConsole.ScrollToCaret();
    }

    #region Command clicks
    private void btnGetRobotMode_Click(object sender, EventArgs e)
    {
        var response = _ur.GetRobotMode();
        Log(response, "GetRobotMode");
    }

    private void btnPowerOn_Click(object sender, EventArgs e)
    {
        var response = _ur.PowerOn();
        Log(response, "PowerOn");
    }

    private void btnPowerOff_Click(object sender, EventArgs e)
    {
        var response = _ur.PowerOff();
        Log(response, "PowerOff");
    }

    private void ReaseBrake_Click(object sender, EventArgs e)
    {
        var response = _ur.ReleaseBrake();
        Log(response, "ReleaseBrake");
    }

    private void btnUnlockProtectiveStop_Click(object sender, EventArgs e)
    {
        var response = _ur.UnlockProtectiveStop();
        Log(response, "UnlockProtectiveStop");
    }

    private void btnShutdown_Click(object sender, EventArgs e)
    {
        var response = _ur.Shutdown();
        Log(response, "Shutdown");
    }

    private void btnLoadProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.LoadProgram(txtProgram.Text);
        Log(response, "LoadProgram");

        Config.Current.LoadProgram = txtProgram.Text;
        Config.Save();
    }

    private void btnGetLoadedProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.GetLoadedProgram();
        Log(response, "GetLoadedProgram");
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        var response = _ur.Play();
        Log(response, "Play");
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        var response = _ur.Stop();
        Log(response, "Stop");
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        var response = _ur.Pause();
        Log(response, "Pause");
    }

    private void btnProgrammRunning_Click(object sender, EventArgs e)
    {
        var response = _ur.IsProgramRunning();
        Log(response, "IsProgramRunning");
    }

    private void btnGetProgramState_Click(object sender, EventArgs e)
    {
        var response = _ur.GetProgramState();
        Log(response, "GetProgramState");
    }

    private void btnIsProgramSaved_Click(object sender, EventArgs e)
    {
        var response = _ur.IsProgramSaved();
        Log(response, "IsProgramSaved");
    }

    private void btnShowPopup_Click(object sender, EventArgs e)
    {
        var response = _ur.ShowPopup(txtPopup.Text);
        Log(response, "ShowPopup");

        Config.Current.ShowPopup = txtPopup.Text;
        Config.Save();
    }

    private void btnClosePopup_Click(object sender, EventArgs e)
    {
        var response = _ur.ClosePopup();
        Log(response, "ClosePopup");
    }

    private void btnAddToLog_Click(object sender, EventArgs e)
    {
        var response = _ur.AddToLog(txtLog.Text);
        Log(response, "AddToLog");

        Config.Current.AddToLog = txtLog.Text;
        Config.Save();
    }

    private void btnPolyscopeVersion_Click(object sender, EventArgs e)
    {
        var response = _ur.GetPolyscopeVersion();
        Log(response, "GetPolyscopeVersion");
    }

    private void btnLoadInstallation_Click(object sender, EventArgs e)
    {
        var response = _ur.LoadInstallation(txtInstallation.Text);
        Log(response, "LoadInstallation");

        Config.Current.LoadInstallation = txtInstallation.Text;
        Config.Save();
    }

    private void btnGetSerialNumber_Click(object sender, EventArgs e)
    {
        var response = _ur.GetSerialNumber();
        Log(response, "GetSerialNumber");
    }

    private void btnGetRobotModel_Click(object sender, EventArgs e)
    {
        var response = _ur.GetRobotModel();
        Log(response, "GetRobotModel");
    }

    private void btnGetOperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.GetOperationalMode();
        Log(response, "GetOperationalMode");
    }

    private void btnClearOIperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.ClearOperationalMode();
        Log(response, "ClearOperationalMode");
    }

    private void btnSetOperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.SetOperationalMode((OperationalModes)cbOperationalMode.SelectedItem);
        Log(response, "SetOperationalMode");
    }

    private void btnSetUserRole_Click(object sender, EventArgs e)
    {
        var response = _ur.SetUserRole((UserRoles)cbUserRoles.SelectedItem);
        Log(response, "SetUserRole");
    }

    private void btnIsInRemoteControl_Click(object sender, EventArgs e)
    {
        var response = _ur.IsInRemoteControl();
        Log(response, "IsInRemoteControl");
    }

    private void btnSafetyStatus_Click(object sender, EventArgs e)
    {
        var response = _ur.GetSafetyStatus();
        Log(response, "GetSafetyStatus");
    }

    private void btnCloseSafetyPopup_Click(object sender, EventArgs e)
    {
        var response = _ur.CloseSafetyPopup();
        Log(response, "CloseSafetyPopup");
    }

    private void btnRestartSafety_Click(object sender, EventArgs e)
    {
        var response = _ur.RestartSafety();
        Log(response, "RestartSafety");
    }
    #endregion
}
