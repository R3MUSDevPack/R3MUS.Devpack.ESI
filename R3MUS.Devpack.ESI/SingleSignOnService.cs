using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace R3MUS.Devpack.ESI
{
    public partial class SingleSignOnService : ISingleSignOnService
    {
        public string SignOn(string redirectURI, string clientId, List<string> scopes)
        {
            var t = Task.Run(() => Listen(redirectURI));

            DoSingleSignOn(SingleSignOn.GetUrl(redirectURI, clientId, scopes));

            return t.Result;
        }

        private void DoSingleSignOn(string url)
        {
            Process.Start(url);
        }

        public async Task<string> Listen(string listenUrl)
        {
            var listener = new HttpListener();
            listener.Prefixes.Add(listenUrl);

            var result = string.Empty;

            var listen = true;
            try
            {
                listener.Start();

                while (listen)
                {
                    var context = await listener.GetContextAsync();

                    result = context.Request.Url.Query.Replace("?code=", string.Empty);

                    var response = context.Response;
                    using (var stream = response.OutputStream)
                    {
                        var bytes = Encoding.ASCII.GetBytes("You may now close this window");
                        stream.Write(bytes, 0, bytes.Length);
                    }

                    listen = false;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);
            }
            return result;
        }

    }
}
