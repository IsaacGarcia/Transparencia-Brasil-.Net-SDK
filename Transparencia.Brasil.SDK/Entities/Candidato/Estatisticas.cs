using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.Entities
{
    public class Estatisticas
    {
        public string faltas_plen { get; set; }
        public string media_plen { get; set; }
        public string faltas_com { get; set; }
        public string media_com { get; set; }
        public string evol { get; set; }
        public string ano_ref { get; set; }
        public string emendas { get; set; }
        public string media_emendas { get; set; }
    }
}
