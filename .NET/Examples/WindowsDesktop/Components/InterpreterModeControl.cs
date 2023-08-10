using System;
using System.Drawing;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.InterpreterMode;

public partial class InterpreterModeControl : UserControl, IUserControl
{
    UR _ur;
    public InterpreterModeControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Interpreter mode";

    public bool FeatureEnabled => _ur.InterpreterMode.Connected;

    public void PeriodicUpdate()
    {
        pnlMain.Enabled = FeatureEnabled;
    }

    public void OnClose() { }

    public void OnOpen() { }
    #endregion

    // Append command response to the console text area
    private void Log(CommandResponse response)
    {
        txtConsole.AppendText(response.Command);
        if (response.Status == CommandResponseStatus.Error)
        {
            txtConsole.SelectionColor = Color.Red;
        }
        else if (response.Status == CommandResponseStatus.Discard)
        {
            txtConsole.SelectionColor = Color.Orange;
        }
        else
        {
            txtConsole.SelectionColor = Color.Green;
        }
        
        txtConsole.AppendText("\r\n  Status: ");
        txtConsole.AppendText(response.Status.ToString());
        if (response.Status != CommandResponseStatus.Error)
        {
            txtConsole.AppendText("\r\n  Id: ");
            txtConsole.AppendText(response.Id.ToString());
        }
        txtConsole.AppendText("\r\n  Body: ");
        txtConsole.AppendText(response.Body);

        txtConsole.SelectionColor = Color.White;
        txtConsole.AppendText("\r\n\r\n> ");
        txtConsole.ScrollToCaret();
    }


    private void btnSendCommand_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.ExecuteCommand(txtCommand.Text);
        Log(response);
    }

    private void btnEndInterpreter_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.EndInterpreter();
        Log(response);
    }

    private void btnClearInterpreter_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.ClearInterpreter();
        Log(response);
    }

    private void btnAbort_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.Abort();
        Log(response);
    }

    private void btnSkipBuffer_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.SkipBuffer();
        Log(response);
    }

    private void btnLastExecuted_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.StateLastExecuted();
        Log(response);
    }

    private void btnLastInterpreted_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.StateLastInterpreted();
        Log(response);
    }

    private void btnLastCleared_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.StateLastCleared();
        Log(response);
    }

    private void btnLastUnexecuted_Click(object sender, EventArgs e)
    {
        var response = _ur.InterpreterMode.StateLastUnexecuted();
        Log(response);
    }
}
