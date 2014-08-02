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
        public IList<Candidato> Todos(string estado, string cargo)
        {
            APIClient<IList<Candidato>> apiClient = new APIClient<IList<Candidato>>();

            return apiClient.Get(string.Format("/candidatos?estado={0}&cargo={1}", estado, cargo));
        }

        public Candidato PorId(int id)
        {
            APIClient<Candidato> apiClient = new APIClient<Candidato>();

            return apiClient.Get(string.Format("/candidatos/{0}", id));
        }

        public IList<Bem> Bens(int id)
        {
            APIClient<IList<Bem>> apiClient = new APIClient<IList<Bem>>();

            return apiClient.Get(string.Format("/candidatos/{0}/bens", id));
        }

        public IList<Doacao> Doadores(int id)
        {
            APIClient<IList<Doacao>> apiClient = new APIClient<IList<Doacao>>();

            return apiClient.Get(string.Format("/candidatos/{0}/doadores", id));
        }

        public IList<Candidaturas> Candidaturas(int id)
        {
            APIClient<IList<Candidaturas>> apiClient = new APIClient<IList<Candidaturas>>();

            return apiClient.Get(string.Format("/candidatos/{0}/candidaturas", id));
        }

    }
}
