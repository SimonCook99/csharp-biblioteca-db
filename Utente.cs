using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Utente{
        public string nome;
        public string cognome;
        public string email;
        public string password;


        public Utente(string nome, string cognome, string email, string password){
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.password = password;
        }

        
    }
}
