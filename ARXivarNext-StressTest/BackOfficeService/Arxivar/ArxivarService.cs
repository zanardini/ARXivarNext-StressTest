using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackOfficeService.Arxivar
{
    public class ArxivarService : IArxivarService
    {
        private readonly string _url;
        private readonly string _username;
        private readonly string _password;
        private readonly string _clientId;
        private readonly string _clientSecret;

        private string _authToken;
        private string _refreshToken;

        private DateTime _expireDateTime;

        public ArxivarService(string url, string username, string password, string clientId, string clientSecret)
        {
            _url = url;
            _username = username;
            _password = password;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        private void ReLogin()
        {
            IO.Swagger.Model.AuthenticationTokenRequestDTO arxLogonRequest = new IO.Swagger.Model.AuthenticationTokenRequestDTO(_username, _password, _clientId, _clientSecret);
            var authApi = new IO.Swagger.Api.AuthenticationApi(_url);
            var resultToken = authApi.AuthenticationGetToken(arxLogonRequest);
            _expireDateTime = DateTime.Now.AddSeconds(resultToken.ExpiresIn == null ? 60 * 10 : resultToken.ExpiresIn.Value).AddMinutes(-10);
            _authToken = resultToken.AccessToken;
            _refreshToken = resultToken.RefreshToken;
        }

        public IO.Swagger.Client.Configuration Configuration
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_authToken) || DateTime.Now >= _expireDateTime)
                    ReLogin();

                return new IO.Swagger.Client.Configuration()
                {
                    BasePath = _url,
                    ApiKey = new Dictionary<string, string>() { { "Authorization", _authToken } },
                    ApiKeyPrefix = new Dictionary<string, string>() { { "Authorization", "Bearer" } }
                };
            }
        }


    }
}
