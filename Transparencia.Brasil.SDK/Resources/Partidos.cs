using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transparencia.Brasil.SDK.Entities;
using Transparencia.Brasil.SDK.InfraStructure;

namespace Transparencia.Brasil.SDK.Resources
{
    public class Partidos
    {
        public IList<Partido> Todos()
        {
            APIClient<IList<Partido>> apiClient = new APIClient<IList<Partido>>();

            return apiClient.Get("/partidos");
        }
    }
}
