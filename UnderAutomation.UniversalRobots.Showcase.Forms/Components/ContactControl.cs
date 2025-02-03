using System.Net;
using System.Text;
using System.Windows.Forms;

public partial class ContactControl : UserControl, IUserControl
{

    public ContactControl()
    {
        InitializeComponent();

        setEmailAnimation();
    }

    #region IUserControl
    public string Title => "Need help ?";

    public bool FeatureEnabled => true;

    public void PeriodicUpdate() { }

    public void OnClose() { }

    public void OnOpen() { setEmailAnimation(); }


    #endregion

    public void SetMessage(string message)
    {
        txtMessage.Text = message;
    }

    private void btnSend_Click(object sender, System.EventArgs e)
    {
    /*    var payloadObject = new { email = txtEmail.Text, subject = "Universal Robots Desktop showcase", message = txtMessage.Text };
        string payload = new JavaScriptSerializer().Serialize(payloadObject);

        using (WebClient client = new WebClient())
        {
            client.Headers[HttpRequestHeader.ContentType] = "application/json";
            client.Encoding = Encoding.UTF8; 
            ServicePointManager.SecurityProtocol = (SecurityProtocolType)0x00000C00; // TLS 1.2

            byte[] data = Encoding.UTF8.GetBytes(payload);

            try
            {
                 client.UploadData("https://formspree.io/f/mleawvqb", "POST", data);
                MessageBox.Show("Message sent ! ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (WebException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
    }

    private void txtEmail_TextChanged(object sender, System.EventArgs e)
    {
        setEmailAnimation();
    }

    private void setEmailAnimation()
    {
        if (chkAnonymous.Checked || (txtEmail.Text.Contains("@") && txtEmail.Text.Contains(".")))
        {
            emailErrorProvider.Clear();
            btnSend.Enabled = true;
        }
        else
        {
            emailErrorProvider.SetError(txtEmail, "please provide an email to get an answer");
            btnSend.Enabled = false;
        }
    }

    private void chkAnonymous_CheckedChanged(object sender, System.EventArgs e)
    {
        if (chkAnonymous.Checked) txtEmail.Text = "";
        txtEmail.Enabled = !chkAnonymous.Checked;
        setEmailAnimation();
    }
}
