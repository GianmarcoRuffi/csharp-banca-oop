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





//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito


//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito


// 2. chiedo i dati del prestito
// 3. aggiungo il prestito



//inserimento cliente
//Console.WriteLine("Inserisci il codice fiscale:");
//string codiceFiscale = Console.ReadLine();

//bool esitoInserimento = intesa.AggiungiCliente("test 1", "test 1", codiceFiscale, 0);

//if (esitoInserimento)
//{
//    Console.WriteLine("Inserimento utente avvenuto con successo");
//}
//else
//{
//    Console.WriteLine("errore: Impossibile inserire l'utente");
//}
//fine inserimento cliente

//Sviluppare un’applicazione orientata agli oggetti per gestire
//i prestiti che una banca concede ai propri clienti.



//I clienti sono caratterizzati da
//- nome
//- cognome,
//- codice fiscale
//- stipendio
public class Cliente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public string CodiceFiscale { get; set; }
    public int Stipendio { get; set; }

    //qui non serve perchè è già in banca e anche in Prestito c'è la relazione con il cliente
    //public List<Prestito> Prestiti { get; set; }

    public Cliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        Nome = nome;
        Cognome = cognome;
        CodiceFiscale = codiceFiscale;
        Stipendio = stipendio;
    }
}