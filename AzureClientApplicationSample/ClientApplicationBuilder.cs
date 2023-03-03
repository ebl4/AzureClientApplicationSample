using Microsoft.Identity.Client;

namespace AzureClientApplicationSample
{
    public class ClientApplicationBuilder
    {
        private readonly string _clientSecret;
        private readonly string _clientId;

        public ClientApplicationBuilder(string clientSecret, string clientId)
        {
            _clientSecret = clientSecret;
            _clientId = clientId;
        }

        public void InitializeConfidentialClientApplication()
        {
            string redirectUri = "https://myapp.azurewebsites.net";
            var app = ConfidentialClientApplicationBuilder.Create(_clientId)
                .WithClientSecret(_clientSecret)
                .WithRedirectUri(redirectUri)
                .Build();
        }
        
        public void InitializePublicClientApplication()
        {
            var app = PublicClientApplicationBuilder.Create(_clientId).Build();
        }
    }
}
