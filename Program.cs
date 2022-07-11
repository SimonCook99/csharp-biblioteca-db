//una serie di istanze per "popolare" il nostro "fake db"
// 2 o 3 utenti -> registrati
// 2 o 3 libri --> tutti disponibili
// Gli utenti si possono registrare specificando i dati ...

using csharp_biblioteca;

Sistema s = new Sistema();

Console.WriteLine("Benvenuto nella nostra biblioteca online. Seleziona un opzione: ");
Console.WriteLine("1: registrati");
Console.WriteLine("2: login");

int opzione = int.Parse(Console.ReadLine());
switch (opzione){
    case 1: //registrazione nuovo utente
        Console.WriteLine("Crea ora il tuo nuovo utente. Inserisci il tuo nome");
        string nome = Console.ReadLine();
        Console.WriteLine("Inserisci il tuo cognome");
        string cognome = Console.ReadLine();
        Console.WriteLine("Inserisci la tua email");
        string email = Console.ReadLine();
        Console.WriteLine("Inserisci la tua password");
        string password = Console.ReadLine();

        Utente nuovo = new Utente(nome, cognome, email, password);
        s.registraNuovoUtente(nuovo);
        break;
    case 2: //login
        Console.WriteLine("Inserisci la tua email: ");
        string emailLogin = Console.ReadLine();
        Console.WriteLine("Inserisci la tua password: ");
        string passwordLogin = Console.ReadLine();

        s.effettuaLogin(emailLogin, passwordLogin);
        break;
}

//se l'utente ha fatto login...
if (Sistema.loginEffettuato){

    Console.WriteLine("Benvenuto utente registrato, cosa vuoi fare?");
    Console.WriteLine("1: cerca titolo libro");
    Console.WriteLine("2: cerca codice identificativo");

    int opzioneUtenteLoggato = int.Parse(Console.ReadLine());

    switch (opzioneUtenteLoggato){
        case 1:
            Console.WriteLine("Inserisci il titolo del libro che vuoi cercare");
            string titoloLibro = Console.ReadLine();
            //Documento libro = s.ricercaDocumento(titoloLibro);
            //if (libro != null){
            //    Console.WriteLine($"Risultato trovato: {libro.titolo} del {libro.anno} scritto da {libro.nomeAutore} {libro.cognomeAutore}");
            //    if (libro.disponibilità == true) 
            //        Console.WriteLine("Attualmente disponibile");
            //    else
            //        Console.WriteLine("Attualmente non disponibile");
            //}
            break;
        case 2:

            break;
    }
}



// Biblioteca online
// 1. Cerca libri
// 2. Cerca dvd



// Menu libro (titolo)
// 1. visualizza dettagli libro
// 2. richiedi prestito
// 3. restitutisci


// tutti i menu hanno esci o torna indietro
