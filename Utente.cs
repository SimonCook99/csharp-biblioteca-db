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
        private string password;
        public string numeroTelefonico;


        public Utente(string nome, string cognome, string email, string password, string numeroTelefonico){
            this.nome = nome;
            this.cognome = cognome;
            this.email = email;
            this.password = password;
            this.numeroTelefonico = numeroTelefonico;
        }

        
    }
}
