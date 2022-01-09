using System.Windows.Forms;
using UnderAutomation.UniversalRobots;

public partial class RtdeControl : UserControl, IUserControl
{
    private UR _ur;

    public RtdeControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Real-time Data Exchange (RTDE)";

    public bool FeatureEnabled => _ur.RTDEEnabled;

    public void PeriodicUpdate()
    {
        var data = _ur.RTDEData;

        if (data is null) lstData.Items.Clear();
        else lstData.UpdateList(data.Values, x => x.Key, x => UR.RtdeOutputsDescription.Get(x.Key).Type, x => x.Value);

    }

    public void OnClose() { }
    public void OnOpen()
    {
    }


    #endregion


}