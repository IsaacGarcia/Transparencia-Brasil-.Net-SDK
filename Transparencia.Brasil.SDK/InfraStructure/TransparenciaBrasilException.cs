using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.InfraStructure
{
    public class TransparenciaBrasilException : Exception
    {
        public TransparenciaBrasilException(string message):base(message)
        {

        }

    }
}
