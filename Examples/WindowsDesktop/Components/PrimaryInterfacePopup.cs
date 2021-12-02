using System;
using System.Windows.Forms;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Sample.WindowsDesktop.Properties;

public partial class PrimaryInterfacePopup : Form
{
    private UR _ur;

    public PrimaryInterfacePopup(UR ur, string title, string message, bool warning, bool error)
    {
        InitializeComponent();

        this.Text = title;
        lblMessage.Text = message;
        _ur = ur;

        if (warning) img.BackgroundImage = Resources.warning;
        else if (error) img.BackgroundImage = Resources.error;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        _ur?.ClosePopup();
        this.Close();
    }

    private void PrimaryInterfacePopup_Shown(object sender, EventArgs e)
    {
        this.Size = new System.Drawing.Size(450, 200);
    }
}
