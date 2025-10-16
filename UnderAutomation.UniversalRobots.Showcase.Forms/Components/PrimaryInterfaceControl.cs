using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Common;
using UnderAutomation.UniversalRobots.PrimaryInterface;
using static System.Runtime.InteropServices.JavaScript.JSType;

public partial class PrimaryInterfaceControl : UserControl, IUserControl
{
    private UR _ur;

    public PrimaryInterfaceControl(UR ur)
    {
        _ur = ur;
        InitializeComponent();

        txtScript.Text = Config.Current.URScript ?? "movej([-1.5,-1.5,-2,-0.5,1.8,0],a=1.4, v=1.05, t=0, r=0)";

        _ur.PrimaryInterface.PopupMessageReceived += _ur_PopupMessageReceived;
        _ur.PrimaryInterface.RuntimeExceptionMessageReceived += _ur_RuntimeExceptionMessageReceived;
        _ur.PrimaryInterface.MasterboardDataReceived += _ur_MasterboardDataReceived;
    }

    private SafetyStatus _lastSafetyStatus = SafetyStatus.Normal;
    private void _ur_MasterboardDataReceived(object? sender, MasterboardDataPackageEventArgs e)
    {
        if (e.Safetymode != _lastSafetyStatus)
        {
            if (e.Safetymode == SafetyStatus.Normal)
            {
                MainForm.InvokeOnMainForm(new Action(() =>
                {
                    if (_popup != null && !_popup.IsDisposed)
                    {
                        _popup.Close();
                    }
                }));
            }
            else
            {
                ShowPopup("Safety fault", System.Text.RegularExpressions.Regex.Replace(e.Safetymode.ToString(), "(?<!^)([A-Z])", " $1"), false, true, RequestedTypes.None, 0, true);
            }

            _lastSafetyStatus = e.Safetymode;
        }

    }

    private void _ur_RuntimeExceptionMessageReceived(object sender, RuntimeExceptionMessageEventArgs e)
    {
        ShowPopup("Runtime exception", $"Script error line {e.ScriptLineNumber} column {e.ScriptColumnNumber}\r\n{e.RuntimeExceptionTextMessage.Replace("_", " ")}", false, true, RequestedTypes.None, 0);
    }

    private void _ur_PopupMessageReceived(object sender, PopupMessageEventArgs e)
    {
        ShowPopup(e.PopupMessageTitle, $"{e.PopupTextMessage ?? $"Enter {e.RequestedType}"}", e.Warning, e.Error, e.RequestedType, e.RequestId);
    }

    private PrimaryInterfacePopup _popup;
    private void ShowPopup(string title, string message, bool warning, bool error, RequestedTypes type, uint id, bool isSafety=false)
    {
        MainForm.InvokeOnMainForm(new Action(() =>
            {
                if(_popup != null && !_popup.IsDisposed)
                {
                    _popup.Close();
                }

                _popup = new PrimaryInterfacePopup(_ur, title, message, warning, error, type, id, isSafety);

                _popup.ShowDialog(MainForm.Instance);
            }));
    }

    #region IUserControl
    public string Title => "Primary Interface (Data streaming and script)";

    public bool FeatureEnabled => _ur.PrimaryInterface.Connected;

    public void PeriodicUpdate()
    {
        btnSendScript.Enabled = FeatureEnabled;

        // Update grid with last received values
        gridAdditionnalInfo.SetSelectedObject(_ur.PrimaryInterface.AdditionalInfo);
        gridCartesian.SetSelectedObject(_ur.PrimaryInterface.CartesianInfo);
        gridConfiguration.SetSelectedObject(_ur.PrimaryInterface.ConfigurationData);
        gridForce.SetSelectedObject(_ur.PrimaryInterface.ForceModeData);
        gridJointData.SetSelectedObject(_ur.PrimaryInterface.JointData);
        gridMasterboard.SetSelectedObject(_ur.PrimaryInterface.MasterboardData);
        gridRobotMode.SetSelectedObject(_ur.PrimaryInterface.RobotModeData);
        GridToolCommunication.SetSelectedObject(_ur.PrimaryInterface.ToolCommunicationInfo);
        gridTool.SetSelectedObject(_ur.PrimaryInterface.ToolData);
        gridToolModeInfo.SetSelectedObject(_ur.PrimaryInterface.ToolModeInfo);
        gridKinematicsData.SetSelectedObject(_ur.PrimaryInterface.KinematicsInfo);
        gridVersion.SetSelectedObject(_ur.PrimaryInterface.Version);
        gridKeyMessage.SetSelectedObject(_ur.PrimaryInterface.KeyMessage);
        gridPopupMessage.SetSelectedObject(_ur.PrimaryInterface.PopupMessage);
        gridTextMessage.SetSelectedObject(_ur.PrimaryInterface.TextMessage);
        gridRuntimeExceptionMessage.SetSelectedObject(_ur.PrimaryInterface.RuntimeExceptionMessage);
    }

    public void OnOpen()
    {
        this.VerticalScroll.Value = 0;
        this.HorizontalScroll.Value = 0;
    }

    public void OnClose() { }
    #endregion


    private void btnSendScript_Click(object sender, System.EventArgs e)
    {
        _ur.PrimaryInterface.Script.Send(txtScript.Text);

        Config.Current.URScript = txtScript.Text;
        Config.Save();
    }
}
