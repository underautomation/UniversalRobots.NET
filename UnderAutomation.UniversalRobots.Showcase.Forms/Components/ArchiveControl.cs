using System;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using UnderAutomation.UniversalRobots;
using UnderAutomation.UniversalRobots.Files;

public partial class ArchiveControl : UserControl, IUserControl
{
    private UR _ur;

    public ArchiveControl(UR ur)
    {
        _ur = ur;

        InitializeComponent();
    }

    #region IUserControl
    public string Title => "Decompile programs and installation";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate()
    {
    }

    public void OnClose() { }
    public void OnOpen()
    {
    }
    #endregion



    private void btnOpen_Click(object sender, EventArgs e)
    {
        dlgOpen.InitialDirectory = Path.Combine(Path.GetDirectoryName(typeof(MainForm).Assembly.Location), "Samples");
        if (dlgOpen.ShowDialog() == DialogResult.OK) Decompile(dlgOpen.FileName);
    }

    public void Decompile(string fullName)
    {
        XElement xml = null;

        if (fullName.StartsWith("/"))
        {
            // download file by SFTP from robot
            using (var stream = new MemoryStream())
            {
                _ur.Sftp.DownloadFile(fullName, stream);
                stream.Position = 0;
                xml = URArchive.Load(stream);
            }
        }
        else
        {
            // load local file
            xml = URArchive.Load(fullName);
        }

        lblFile.Text = fullName;
        browser.DocumentText = "<?xml version=\"1.0\"?>\r\n" + xml.ToString();
    }
}