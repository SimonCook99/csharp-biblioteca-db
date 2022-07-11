using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Sistema{
        public List<Utente> utentiRegistrati = new List<Utente>{
            new Utente("test", "prova", "test.prova@pippo.it", "0000000", "3548754196"),
            new Utente("prova2", "ciao", "ciao.blabla@pippo.it", "000000", "15748475541")
        };

        public List<Documento> documentiPresenti = new List<Documento> {
            new Libro("Moby Dick", 1857, "romanzo", true, 21, "bho", "bho2", 97888123, 1200),
            new DVD("test", 1921, "musica jazz", true, 115, "Led", "zeppelin", 4568478, 3)
        };

        public List<Utente> getUtentiRegistrati(){
            return this.utentiRegistrati;
        }

        public void registraNuovoUtente(Utente nuovoUtente){
            bool utenteValido = nuovoUtente.nome != null && nuovoUtente.cognome != null && nuovoUtente.email != null && nuovoUtente.numeroTelefonico != null;

            if (utenteValido){
                this.utentiRegistrati.Add(nuovoUtente);
                Console.WriteLine("Complimenti, hai creato il tuo utente");
            }
        }

        public void effettuaLogin(string email){
            foreach (Utente user in this.utentiRegistrati){
                if (user.email == email){
                    Console.WriteLine("Hai fatto l'accesso come " + user.nome);
                    return;
                }
                else{
                    Console.WriteLine("Utente non trovato");
                }
            }
        }

        public void effettuaPrestito(Utente utente, Documento item){
            if (this.utentiRegistrati.Contains(utente)){
                if(item.disponibilità == true){
                    Console.WriteLine("Utente autorizzato, hai effettuato il prestito di:" + item.titolo);
                    item.disponibilità = false;
                }
                else{
                    Console.WriteLine("Il documento scelto non è attualmente disponibile :(, puoi prendere un altro documento");
                }
            }
            else{
                Console.WriteLine("Non sei autorizzato a effettuare un prestito, prova con un altro utente");
            }
        }

        public void ricercaDocumento(int codice){
            foreach(Documento documento in documentiPresenti){
                /*Console.WriteLine(documento.GetType() == new Libro("",0,"",true,0,"","",0,0).GetType())*/;
                //bool test = documento.GetType() == "csharp_biblioteca.Libro";
                //Console.WriteLine(test);
                //if(documento.GetType() == new Libro("", 0, "", true, 0, "", "", 0, 0).GetType(){
                //    if(documento.)
                //}
            }
        }

        public Documento ricercaDocumento(string nome){
            foreach (Documento documento in documentiPresenti){
                if(documento.titolo == nome){
                    return documento;
                }
            }
            Console.WriteLine("Spiacente, non ho trovato nessun elemento con questo titolo");
            return null;
        }
    }

    
}
