//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)
//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio
//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.

//per la modifica utente, non complichiamoci la vita, facciamo una interazione semplice tipo:
//vengono chiesti all’utente tutti i campi del cliente
//se viene premuto invio senza dati significa che il campo specifico non verrà modificato
//se invece viene scritto un valore allora andremo a modificare il campo con il nuovo valore


Banca intesa = new Banca("Intesa san Paolo");


Console.WriteLine("Sistema amministrazione banca " + intesa.Nome);


//SCELTA FUNZIONE

Console.WriteLine("1 - Creazione nuovo prestito");
Console.WriteLine("2 - Aggiunta utente");
Console.WriteLine("3 - Modifica utente");

int sceltaUser = Convert.ToInt32(Console.ReadLine());

//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito

if (sceltaUser == 1)
{
    Console.WriteLine("Creazione di un nuovo prestito");
    Console.WriteLine();
    Console.WriteLine("Inserisci il codice fiscale:");
    string codiceFiscale = Console.ReadLine();

    Cliente esistente = intesa.RicercaCliente(codiceFiscale);

    if (esistente == null)
    {
        Console.WriteLine("errore: Cliente non trovato!");
    }
    else
    {

        Console.WriteLine("Ammontare del prestito: ");
        int ammontarePrestito = Convert.ToInt32(Console.ReadLine());
        Prestito nuovoPrestito = new Prestito(0, ammontarePrestito, 0, new DateOnly(), esistente);

        intesa.AggiungiPrestito(nuovoPrestito);


        Console.WriteLine(nuovoPrestito);

    }
}


else if (sceltaUser == 2)
//aggiunta di un utente
//2. chiedo all'utente di inserire i suoi dati


{
    Console.WriteLine("Inserisci il codice fiscale:");
    string codiceFiscale = Console.ReadLine();
    Console.WriteLine("Inserisci il nome:");
    string nome = Console.ReadLine();
    Console.WriteLine("Inserisci il cognome:");
    string cognome = Console.ReadLine();
    Console.WriteLine("Inserisci lo stipendio:");
    int stipendio = Convert.ToInt32(Console.ReadLine());
    bool aggiunta = intesa.AggiungiCliente(nome, cognome, codiceFiscale, stipendio);
    if (aggiunta)
        Console.WriteLine("Utente inserito nel database.");
    else
        Console.WriteLine("Errore nel processo!");
}

else if (sceltaUser == 3)

//modifica di un utente
//3. chiedo all'utente di inserire il suo nome per la modifica
{

    Console.WriteLine("Inserisci il codice fiscale:");
    string codiceFiscale = Console.ReadLine();
    Cliente cliente = intesa.RicercaCliente(codiceFiscale);
    if (cliente == null)
        Console.WriteLine("Errore utente non trovato");
    else
    {
        Console.WriteLine("Modifica dei dati utente:");
        Console.WriteLine("Inserisci il nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Inserisci il cognome:");
        string cognome = Console.ReadLine();
        Console.WriteLine("Inserisci lo stipendio:");
        int stipendio = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Inserisci il codice fiscale:");
        string nuovoCF = Console.ReadLine();
        Cliente modifica = intesa.ModificaCliente(nome, cognome, codiceFiscale, stipendio, nuovoCF);
        if (modifica != null)
            Console.WriteLine("Nuovo codice fiscale dell'utente: " + modifica.CodiceFiscale);
        else
            Console.WriteLine("Errore durante la modifica");
    }
}