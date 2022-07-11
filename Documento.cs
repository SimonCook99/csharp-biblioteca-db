using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Documento{
        public string titolo;
        public int anno;
        public string settore;
        public bool disponibilità;
        public int numeroScaffale;
        public string nomeAutore;
        public string cognomeAutore;

        public Documento(string titolo, int anno, string settore, bool disponibilità, int numeroScaffale, string nomeAutore, string cognomeAutore){
            this.titolo = titolo;
            this.anno = anno;
            this.settore = settore;
            this.disponibilità = disponibilità;
            this.numeroScaffale = numeroScaffale;
            this.nomeAutore = nomeAutore;
            this.cognomeAutore = cognomeAutore;
        }
    }
}
