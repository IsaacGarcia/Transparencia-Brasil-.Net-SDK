using System;
using System.Collections;
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
            return APIClientFactory<IList<Candidato>>.Get(string.Format("/candidatos?estado={0}&cargo={1}", estado, cargo));
        }

        public Candidato PorId(int id)
        {
            return APIClientFactory<Candidato>.Get(string.Format("/candidatos/{0}", id));
        }

        public IList<Bem> Bens(int id)
        {
            return APIClientFactory<IList<Bem>>.Get(string.Format("/candidatos/{0}/bens", id));
        }

        public IList<Doacao> Doadores(int id)
        {
            return APIClientFactory<IList<Doacao>>.Get(string.Format("/candidatos/{0}/doadores", id));
        }

        public IList<Candidaturas> Candidaturas(int id)
        {
            return APIClientFactory<IList<Candidaturas>>.Get(string.Format("/candidatos/{0}/candidaturas", id));
        }

        public IList<Estatisticas> Estatisticas(int id)
        {
            return APIClientFactory<IList<Estatisticas>>.Get(string.Format("/candidatos/{0}/estatisticas", id));
        }
    }
}
