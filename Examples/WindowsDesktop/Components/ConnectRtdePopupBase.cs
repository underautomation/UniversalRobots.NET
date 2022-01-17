using System.Collections.ObjectModel;
using System.Windows.Forms;

public partial class ConnectRtdePopupBase : Form
{

    public ConnectRtdePopupBase(string text)
    {
        InitializeComponent();
        this.Text = text;
    }



    protected virtual void tree_AfterCheck(object sender, TreeViewEventArgs e)
    {    }
}
