using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.InfraStructure
{
    public class SDKConfiguration
    {
        private string _host;
        private string _enviroment;
        private string _version;

        public string AppToken { private set; get; }
        public string APIBaseAdress { private set; get; }

        public SDKConfiguration()
        {
            Configure();

            BuildAPIBaseAdress();
        }

        private void SetHost()
        {
            _host = ConfigurationManager.AppSettings["Host"];

            if (string.IsNullOrEmpty(_host))
                throw new TransparenciaBrasilException("Configuração inválida: Host não informado. Informe a chave host na seção AppSettings. Exemplo: https://api.transparencia.org.br");
        }

        private void SetEnviroment()
        {
            _enviroment = ConfigurationManager.AppSettings["enviroment"];

            if (string.IsNullOrEmpty(_enviroment))
                throw new TransparenciaBrasilException("Configuração inválida: ambiente não informado. Informe a chave enviroment na seção AppSettings. Exemplo: Sand Box ou Api");
        }

        private void SetVersion()
        {
            _version = ConfigurationManager.AppSettings["version"];

            if (string.IsNullOrEmpty(_version))
                throw new TransparenciaBrasilException("Configuração inválida: versão não informada. Informe a chave version na seção AppSettings. Exemplo: v1, v2");
        }

        private void SetAppToken()
        {
            AppToken = ConfigurationManager.AppSettings["AppToken"];

            if (string.IsNullOrEmpty(AppToken))
                throw new TransparenciaBrasilException("Configuração inválida: Token não informado!. Informe a chave appToken na seção AppSettings. ");
        }

        private void Configure()
        {
            SetHost();
            SetEnviroment();
            SetVersion();
            SetAppToken();
        }

        private void BuildAPIBaseAdress()
        {
            APIBaseAdress = string.Concat(_host, _enviroment, _version);
        }
    }
}
