using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transparencia.Brasil.SDK.Entities
{
    public class Candidato
    {
        public string id { get; set; }
        public string apelido { get; set; }
        public string nome { get; set; }
        public string numero { get; set; }
        public string titulo { get; set; }
        public string CPF { get; set; }
        public string matricula { get; set; }
        public string cargo { get; set; }
        public string estado { get; set; }
        public string partido { get; set; }
        public string idade { get; set; }
        public string instrucao { get; set; }
        public string ocupacao { get; set; }
        public string miniBio { get; set; }
        public string cargos { get; set; }
        public string previsao { get; set; }
        public string bancadas { get; set; }
        public string processos { get; set; }
        public string casaAtual { get; set; }
        public bool reeleicao { get; set; }
        public string foto { get; set; }
    }
}
