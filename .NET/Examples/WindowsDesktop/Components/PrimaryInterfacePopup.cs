using System;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.PrimaryInterface;
using UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties;

public partial class PrimaryInterfacePopup : Form
{
    private UR _ur;

    private RequestedTypes _type;
    private uint _id;

    public PrimaryInterfacePopup(UR ur, string title, string message, bool warning, bool error, RequestedTypes type, uint id)
    {
        InitializeComponent();

        this.Text = title;
        lblMessage.Text = message;
        _ur = ur;

        txtAnswer.Visible = type != RequestedTypes.None;
        _type = type;

        _id = id;

        if (warning) img.BackgroundImage = Resources.warning;
        else if (error) img.BackgroundImage = Resources.error;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        _ur.Dashboard.ClosePopup();
        if (_type != RequestedTypes.None)
        {
            _ur.PrimaryInterface.Commands.ReplyPopup(_id, txtAnswer.Text, _type);
        }
        this.Close();
    }

    private void PrimaryInterfacePopup_Shown(object sender, EventArgs e)
    {
        this.Size = new System.Drawing.Size(450, 200);
    }
}
