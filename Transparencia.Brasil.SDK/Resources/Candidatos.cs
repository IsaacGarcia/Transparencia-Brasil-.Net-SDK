using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transparencia.Brasil.SDK.Entities;
using Transparencia.Brasil.SDK.InfraStructure;

namespace Transparencia.Brasil.SDK.Resources
{
    public class Candidatos
    {
        private APIClient<IList<Candidato>> _apiClient;

        public Candidatos()
        {
            _apiClient = new APIClient<IList<Candidato>>();
        }

        public IList<Candidato> ObterTodosOsCandidatos(string estado, string cargo)
        {
            return _apiClient.Get(string.Format("/candidatos?estado={0}&cargo={1}", estado, cargo));
        }
    }
}
