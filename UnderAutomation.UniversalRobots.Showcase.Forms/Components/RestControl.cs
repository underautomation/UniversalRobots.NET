using System.Text;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.Dashboard;
using UnderAutomation.UniversalRobots.Rest;

public partial class RestControl : UserControl, IUserControl
{
    UR _ur;
    public RestControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();
    }

    #region IUserControl
    public string Title => "REST (PolyscopeX)";

    public bool FeatureEnabled => !string.IsNullOrEmpty(_ur.Rest.IP);

    public void PeriodicUpdate()
    {
        pnlMain.Enabled = FeatureEnabled;
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    // Append command response to the console text area
    private void Log(RestApiResponse response, string command, string messageBefore = null, string messageAfter = null)
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

        if (messageBefore != null) txtConsole.AppendText(messageBefore);
        txtConsole.AppendText(response.ToString() ?? "");
        if (messageAfter != null) txtConsole.AppendText(messageAfter);


        txtConsole.SelectionBullet = false;
        txtConsole.SelectionColor = Color.White;
        txtConsole.AppendText("\r\n\r\n> ");
        txtConsole.ScrollToCaret();
    }

    private void btnPowerOn_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.PowerOn();
        Log(response, "PowerOn");
    }

    private void btnPowerOff_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.PowerOff();
        Log(response, "PowerOff");
    }

    private void btnBrakeRelease_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.BrakeRelease();
        Log(response, "BrakeRelease");
    }

    private void btnUnlockProtectiveStop_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.UnlockProtectiveStop();
        Log(response, "UnlockProtectiveStop");
    }

    private void btnRestartSafety_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.RestartSafety();
        Log(response, "RestartSafety");
    }

    private void btnLoadProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.LoadProgram(txtLoadProgram.Text);
        Log(response, "LoadProgram");
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.Play();
        Log(response, "Play");
    }

    private void btnPause_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.Pause();
        Log(response, "Pause");
    }

    private void btnStop_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.Stop();
        Log(response, "Stop");
    }

    private void btnResume_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.Resume();
        Log(response, "Resume");
    }

    private void btnGetProgramState_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetProgramState();
        Log(response, "GetProgramState");
    }

    private void btnGetLoadedProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetLoadedProgram();
        Log(response, "GetLoadedProgram");
    }

    private void btnGetRobotMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetRobotMode();
        Log(response, "GetRobotMode");
    }

    private void btnGetSafetyMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetSafetyMode();
        Log(response, "GetSafetyMode");
    }

    private void btnGetOperationalMode_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetOperationalMode();
        Log(response, "GetOperationalMode");
    }

    private void btnIsInRemoteControl_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.IsInRemoteControl();
        Log(response, "IsInRemoteControl");
    }

    private void btnGetPolyscopeVersion_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetPolyscopeVersion();
        Log(response, "GetPolyscopeVersion");
    }

    private void btnGetRobotApiVersion_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetRobotApiVersion();
        Log(response, "GetRobotApiVersion");
    }

    private void btnShowPopup_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.ShowPopup(txtPopup.Text);
        Log(response, "ShowPopup");
    }

    private void btnShowPopupWithTitle_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.ShowPopupWithTitle("SDK", txtPopup.Text);
        Log(response, "ShowPopupWithTitle");
    }

    private void btnClosePopup_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.ClosePopup();
        Log(response, "ClosePopup");
    }

    private void btnCloseSafetyPopup_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.CloseSafetyPopup();
        Log(response, "CloseSafetyPopup");
    }

    private void btnGetPrograms_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.GetPrograms();

        var text = new StringBuilder();
        text.AppendLine($"{response.Value?.Length ?? 0} program(s)");
        foreach (var program in response.Value ?? Array.Empty<RestProgramInfo>())
        {
            text.AppendLine($"- {program.Name}");
            text.AppendLine($"    Description : {program.Description}");
            text.AppendLine($"    State : {program.ProgramState}");
            text.AppendLine($"    Created : {FormatDate(program.CreatedDate)}");
            text.AppendLine($"    Last modified : {FormatDate(program.LastModifiedDate)}");
            text.AppendLine($"    Last saved : {FormatDate(program.LastSavedDate)}");
        }

        Log(response, "GetPrograms", text.ToString());
    }

    // Program dates are in milliseconds since 1970-01-01 UTC, 0 when the robot gives none
    private static string FormatDate(long milliseconds)
    {
        return milliseconds == 0 ? "-" : DateTimeOffset.FromUnixTimeMilliseconds(milliseconds).LocalDateTime.ToString("yyyy-MM-dd HH:mm:ss");
    }

    private void btnUploadProgramFile_Click(object sender, EventArgs e)
    {
        if (openProgramDialog.ShowDialog() != DialogResult.OK) return;
        var response = _ur.Rest.UploadProgramFile(openProgramDialog.FileName);
        Log(response, "UploadProgramFile");
    }

    private void btnUpdateProgramFile_Click(object sender, EventArgs e)
    {
        if (openProgramDialog.ShowDialog() != DialogResult.OK) return;
        var response = _ur.Rest.UpdateProgramFile(openProgramDialog.FileName);
        Log(response, "UpdateProgramFile");
    }

    private void btnDownloadProgram_Click(object sender, EventArgs e)
    {
        var response = _ur.Rest.DownloadProgram(txtProgram.Text);
        Log(response, "DownloadProgram", $"{response.Value?.Length ?? 0} character(s). ");
    }

    private void btnDownloadProgramToFile_Click(object sender, EventArgs e)
    {
        saveProgramDialog.FileName = txtProgram.Text;
        if (saveProgramDialog.ShowDialog() != DialogResult.OK) return;
        var response = _ur.Rest.DownloadProgramToFile(txtProgram.Text, saveProgramDialog.FileName);
        Log(response, "DownloadProgramToFile");
    }

}
