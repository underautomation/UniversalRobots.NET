using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using UnderAutomation.UniversalRobots;

public partial class LogControl : UserControl, IUserControl
{
    public LogControl()
    {
       InitializeComponent();
    }

    #region IUserControl
    public string Title => "Logs";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate()
    {
    }

    public void OnClose() { }
    public void OnOpen()
    {
        txtLog.Text = string.Join("\r\n\r\n", MainForm.Instance.Errors.ToArray());
    }
    #endregion


}