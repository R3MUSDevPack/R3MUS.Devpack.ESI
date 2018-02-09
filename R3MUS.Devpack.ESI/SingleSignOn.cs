using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Infrastructure;
using R3MUS.Devpack.ESI.Models.Verification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Mvc;

namespace R3MUS.Devpack.ESI
{
    public class SingleSignOn
	{
		public static ActionResult SignOn(string redirectURI, string clientId, List<string> scopes )
		{
            return new RedirectResult(
                string.Concat(
                    string.Format(
                        Resources.AuthorisationUrlFormat, 
                        Resources.Authorise),
                    Resources.Question,
                    Resources.ResponseTypeModifier,
                    Resources.Ampersand,
                    string.Format(Resources.RedirectURIFormat, redirectURI),
                    Resources.Ampersand,
                    string.Format(Resources.ClientIdFormat, clientId),
                    Resources.Ampersand,
                    new ScopeBuilder(scopes).Build(),
                    Resources.Ampersand,
                    Guid.NewGuid().ToString()
                ));
        }

        public static string GetAuthorisationCode(Uri requestUri)
        {
            return requestUri.Query.Split(new string[] { "=" }, StringSplitOptions.None).Last();
        }

        public static TokenResponse GetTokensFromAuthenticationToken(string clientId, string applicationKey, string token)
        {
            TokenResponse result = new TokenResponse();

            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat(clientId, ":", applicationKey)));

            var client = new HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri(string.Format(Resources.AuthorisationUrlFormat, Resources.Token)),
                Method = HttpMethod.Post
            };
            requestMessage.Headers.Add("Authorization", string.Concat("Basic ", encoded));
            requestMessage.Headers.Add("host", Resources.BaseHostName);
            requestMessage.Content = new StringContent(string.Concat("grant_type=authorization_code&code=", token));
            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var task = client.SendAsync(requestMessage)
                            .ContinueWith((taskWithMessage) =>
                            {
                                var response = taskWithMessage.Result;
                                var jsonTask = response.Content.ReadAsStringAsync();
                                result = jsonTask.Result.Deserialize<TokenResponse>();
                            });
            task.Wait();

            return result;
        }

        public static TokenResponse GetTokensFromRefreshToken(string clientId, string applicationKey, string token)
        {
            TokenResponse result = new TokenResponse();

            var encoded = Convert.ToBase64String(Encoding.UTF8.GetBytes(string.Concat(clientId, ":", applicationKey)));

            var client = new HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri(string.Format(Resources.AuthorisationUrlFormat, Resources.Token)),
                Method = HttpMethod.Post
            };
            requestMessage.Headers.Add("Authorization", string.Concat("Basic ", encoded));
            requestMessage.Headers.Add("host", Resources.BaseHostName);
            requestMessage.Content = new StringContent(string.Concat("grant_type=refresh_token&refresh_token=", token));
            requestMessage.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/x-www-form-urlencoded");

            var task = client.SendAsync(requestMessage)
                            .ContinueWith((taskWithMessage) =>
                            {
                                var response = taskWithMessage.Result;
                                var jsonTask = response.Content.ReadAsStringAsync();
                                result = jsonTask.Result.Deserialize<TokenResponse>();
                            });
            task.Wait();

            return result;
        }

        public static long GetCharacterIdForToken(string token)
        {
            long result = 0;
            var client = new HttpClient();
            var requestMessage = new HttpRequestMessage()
            {
                RequestUri = new Uri(string.Format(Resources.AuthorisationUrlFormat, Resources.Verify)),
                Method = HttpMethod.Get
            };
            requestMessage.Headers.Add("Authorization", string.Concat("Bearer ", token));
            requestMessage.Headers.Add("host", Resources.BaseHostName);

            var task = client.SendAsync(requestMessage)
                .ContinueWith((taskWithMessage) =>
                {
                    var response = taskWithMessage.Result;
                    var jsonTask = response.Content.ReadAsStringAsync();
                    result = jsonTask.Result.Deserialize<Summary>().CharacterID;

                });
            task.Wait();

            return result;
        }
	}
}
