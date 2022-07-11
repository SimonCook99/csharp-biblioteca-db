using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class DVD : Documento{
        public int numeroSeriale;

        public int durata;

        public DVD(string titolo, int anno, string settore, bool disponibilità, int numeroScaffale, string nomeAutore, string cognomeAutore, int numeroSeriale, int durata) : base(titolo, anno, settore, disponibilità, numeroScaffale, nomeAutore, cognomeAutore){
            this.numeroSeriale = numeroSeriale;
            this.durata = durata;
        }
    }
}
