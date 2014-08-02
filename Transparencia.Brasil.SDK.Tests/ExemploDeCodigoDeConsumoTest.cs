using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net.Http.Headers;
using System.Collections.Generic;
using Transparencia.Brasil.SDK.Entities;
using System.Net.Http;

namespace Transparencia.Brasil.SDK.Tests
{
    [TestClass]
    public class ExemploDeConsumoTest
    {
        [TestMethod]
        public void exemplo_de_codigo_test()
        {
            //Classe de suporte a consumo de HTTP namespace System.Net.Http
            HttpClient client = new HttpClient();

            //Adicionando no Header o token e o media type JSON
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("App-Token", "tVKugWcoOJLt ");

            //fazendo a requisição
            HttpResponseMessage response = client.GetAsync("http://api.transparencia.org.br/api/v1/candidatos/1682111").Result;

            //Conferindo código 200 de sucesso
            if (response.IsSuccessStatusCode)
            {
                //Parse de JSON para o objeto Candidato
                var candidato = response.Content.ReadAsAsync<Candidato>().Result;
            }
            else
                //Exibindo a exceção com o código Http respectivo.
                throw new Exception(string.Concat(response.StatusCode.ToString(), " - ", response.ReasonPhrase));
        }
    }
}
