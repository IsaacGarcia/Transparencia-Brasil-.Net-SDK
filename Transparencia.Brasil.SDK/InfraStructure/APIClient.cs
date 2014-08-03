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
    public class APIClient<T>
    {
        private HttpClient _client;
        private SDKConfiguration _config;

        public APIClient()
        {
            _config = new SDKConfiguration();

            BuildApiHttpClient();

            ConfigureHeaders();
        }

        public T Get(string templateUri) 
        {
            HttpResponseMessage response = _client.GetAsync(_config.APIBaseAdress + templateUri).Result;

            var result = _client.GetStringAsync(_config.APIBaseAdress + templateUri).Result;

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<T>().Result;
            }
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
