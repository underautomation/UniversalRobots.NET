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
}
