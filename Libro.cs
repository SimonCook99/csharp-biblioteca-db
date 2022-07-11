using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Libro : Documento{
        public int ISBN;

        public int numeroPagine;

        public Libro(string titolo, int anno, string settore, bool disponibilità, int numeroScaffale, string nomeAutore, string cognomeAutore, int ISBN, int numeroPagine) : base(titolo, anno, settore, disponibilità, numeroScaffale, nomeAutore, cognomeAutore){
            this.ISBN = ISBN;
            this.numeroPagine = numeroPagine;
        }
    }
}
