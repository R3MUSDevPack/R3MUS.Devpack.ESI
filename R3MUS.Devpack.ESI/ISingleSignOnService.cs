using System.Collections.Generic;
using System.Threading.Tasks;

namespace R3MUS.Devpack.ESI
{
    public interface ISingleSignOnService
    {
        Task<string> Listen(string listenUrl);
        string SignOn(string redirectURI, string clientId, List<string> scopes);
    }
}