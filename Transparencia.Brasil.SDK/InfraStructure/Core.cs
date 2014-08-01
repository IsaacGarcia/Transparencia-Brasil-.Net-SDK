using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.InfraStructure
{
    public class Core
    {
        private HttpClient _client;
        private SDKConfiguration _config;

        public Core()
        {
            _config = new SDKConfiguration();

            BuildApiHttpClient();

            ConfigureHeaders();
        }

        public HttpResponseMessage Get(string templateUri)
        {
            HttpResponseMessage response = _client.GetAsync(templateUri).Result;

            if (response.IsSuccessStatusCode)
                return response;
            else
                throw new TransparenciaBrasilException(string.Concat(response.StatusCode.ToString(), " - ", response.ReasonPhrase));
        }

        private void BuildApiHttpClient()
        {
            _client = new HttpClient();

            _client.BaseAddress = new Uri(_config.APIBaseAdress);
        }

        private void ConfigureHeaders()
        {
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            _client.DefaultRequestHeaders.Add("App-Token", _config.AppToken);
        }
    }
}
