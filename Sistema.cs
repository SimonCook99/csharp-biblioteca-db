using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_biblioteca
{
    public class Sistema{

        public string connection = "Data Source=localhost;Initial Catalog=db-biblioteca;Integrated Security=True";

        public static bool loginEffettuato = false;

        public void registraNuovoUtente(Utente nuovoUtente){

            using (SqlConnection con = new SqlConnection(connection)){
                try{
                    con.Open();

                    string query = "INSERT INTO Users (name, surname, email, password) VALUES (@Name, @Surname, @Email, @Password)";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", nuovoUtente.nome));
                    cmd.Parameters.Add(new SqlParameter("@Surname", nuovoUtente.cognome));
                    cmd.Parameters.Add(new SqlParameter("@Email", nuovoUtente.email));
                    cmd.Parameters.Add(new SqlParameter("@Password", nuovoUtente.password));

                    int rows = cmd.ExecuteNonQuery();
                    Console.WriteLine("Registrazione effettuata correttamente");
                    
                    loginEffettuato = true;
                }catch(Exception e){
                    Console.WriteLine(e.Message);
                }
            }

        }

        public void effettuaLogin(string email, string password){

            using (SqlConnection con = new SqlConnection(connection)){
                try{
                    con.Open();

                    string query = " SELECT * FROM Users WHERE email=@Email AND password=@Password";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(new SqlParameter("@Email", email));
                        cmd.Parameters.Add(new SqlParameter("@Password", password));
                        using (SqlDataReader reader = cmd.ExecuteReader()){
                            if (reader.HasRows)
                            {
                                Console.WriteLine("Login effettuato correttamente!");
                                loginEffettuato = true;
                            }
                            else
                            {
                                Console.WriteLine("Spiacenti, non abbiamo trovato un utente con queste credenziali");
                            }
                        }

                    }
                }catch (Exception e){
                    Console.WriteLine(e.Message);
                }
            }
        }

        public void effettuaPrestito(Utente utente, Documento item){
            //if (this.utentiRegistrati.Contains(utente)){
            //    if(item.disponibilità == true){
            //        Console.WriteLine("Utente autorizzato, hai effettuato il prestito di:" + item.titolo);
            //        item.disponibilità = false;
            //    }
            //    else{
            //        Console.WriteLine("Il documento scelto non è attualmente disponibile :(, puoi prendere un altro documento");
            //    }
            //}
            //else{
            //    Console.WriteLine("Non sei autorizzato a effettuare un prestito, prova con un altro utente");
            //}
        }

        public void ricercaDocumento(int codice){
            //foreach(Documento documento in documentiPresenti){
                /*Console.WriteLine(documento.GetType() == new Libro("",0,"",true,0,"","",0,0).GetType())*/;
                //bool test = documento.GetType() == "csharp_biblioteca.Libro";
                //Console.WriteLine(test);
                //if(documento.GetType() == new Libro("", 0, "", true, 0, "", "", 0, 0).GetType(){
                //    if(documento.)
                //}
            //}
        }

        //public Documento ricercaDocumento(string nome){
            //foreach (Documento documento in documentiPresenti){
            //    if(documento.titolo == nome){
            //        return documento;
            //    }
            //}
            //Console.WriteLine("Spiacente, non ho trovato nessun elemento con questo titolo");
            //return null;
        //}
    }

    
}
