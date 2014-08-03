using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.InfraStructure
{
    public class APIClientFactory<T>
    {
        public static T Get(string templateUri)
        {
            return new APIClient<T>().Get(templateUri);
        }
    }
}
