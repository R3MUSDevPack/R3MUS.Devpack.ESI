using Gecko;
using System.Windows.Forms;

namespace R3MUS.Devpack.ESI.Forms
{
    public partial class TokenAccessForm : Form
    {
        public TokenAccessForm(string url)
        {
            Xpcom.Initialize("Firefox");
            var geckoWebBrowser = new GeckoWebBrowser { Dock = DockStyle.Fill };
            this.Controls.Add(geckoWebBrowser);
            geckoWebBrowser.Navigate(url);
            this.Show();
        }
    }
}
