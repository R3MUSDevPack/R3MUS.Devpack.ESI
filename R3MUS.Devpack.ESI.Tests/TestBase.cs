using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models.Shared;
using R3MUS.Devpack.ESI.Tests.Properties;
using System;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Tests
{
    public class TestBase
    {
        protected string _accessToken;
        protected string _authHeader;

        protected IFixture Fixture;

        [TestInitialize]
        public void TestInitialise()
        {
            Fixture = new Fixture();

            var headers = new Dictionary<string, string>();
            headers.Add("Content-Type", "application/json");

            _authHeader = string.Concat("Basic ", Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes("")));

            headers.Add("Authorization", _authHeader);

            var response = Web.Post<RefreshTokenResponseModel>(string.Format(Resources.AuthorisationUrlFormat, Resources.Token), headers,
                new RefreshTokenRequestModel() { GrantType = "refresh_token", RefreshToken = Settings.Default.RefreshToken }
                );
            _accessToken = response.AccessToken;
        }
    }
}
