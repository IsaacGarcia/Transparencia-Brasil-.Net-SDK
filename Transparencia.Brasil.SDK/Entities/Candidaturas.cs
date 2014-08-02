using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.Entities
{
    public class Candidaturas
    {
        public string anoEleitoral { get; set; }
        public string cargo { get; set; }
        public string partidoSigla { get; set; }
        public string municipio { get; set; }
        public string estadoSigla { get; set; }
        public string resultado { get; set; }
        public string votosObtidos { get; set; }
        public string recursosFinanceiros { get; set; }
    }
}
