using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transparencia.Brasil.SDK.Entities;
using Transparencia.Brasil.SDK.InfraStructure;

namespace Transparencia.Brasil.SDK.Resources
{
    public class Excelencias
    {
        public IList<Excelencia> Todas(string casa)
        {
            return APIClientFactory<IList<Excelencia>>.Get(string.Format("/excelencias?casa={0}", casa));
        }

        public Excelencia PorId(int id)
        {
            return APIClientFactory<Excelencia>.Get(string.Format("/excelencias/{0}", id));
        }

        public IList<Bem> Bens(int id)
        {
            return APIClientFactory<IList<Bem>>.Get(string.Format("/excelencias/{0}/bens", id));
        }
    }
}
