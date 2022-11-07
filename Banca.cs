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


///


//aggiunta di un prestito
// 1. chiedo all'utente di cercare il cliente su cui si vuole creare un prestito


//Per la banca deve essere possibile:
//-aggiungere, modificare e ricercare un cliente dato il codice fiscale.
//- aggiungere un prestito.
//- effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//- sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//- sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.

//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano
//in un formato di tipo stringa a piacere.

//**Bonus:**

//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.

//La banca è caratterizzata da
//- un nome
//- un insieme di clienti (una lista)
//-un insieme di prestiti concessi ai clienti (una lista)
public class Banca
{
    public string Nome { get; set; }
    List<Cliente> Clienti { get; set; }
    List<Prestito> Prestiti { get; set; }

    public Banca(string Nome)
    {
        Nome = Nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();

        Cliente Cliente1 = new Cliente("Paolo", "Rossi", "PLRSS4848383", 1000);
        Cliente Cliente2 = new Cliente("Marco", "Bianchi", "MRCBNCH3382821", 1200);
        Clienti.Add(Cliente1);
        Clienti.Add(Cliente2);
    }

    public bool AggiungiCliente(Cliente cliente)
    {
        //if (
        //   cliente.Nome == null || cliente.Nome == "" ||
        //   cliente.Cognome == null || cliente.Cognome == "" ||
        //   codiceFiscale == null || codiceFiscale == "" ||
        //   stipendio < 0
        //   )
        //{
        //    return false;
        //}

        return false;
    }
    public bool AggiungiCliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {

        if (
            nome == null || nome == "" ||
            cognome == null || cognome == "" ||
            codiceFiscale == null || codiceFiscale == "" ||
            stipendio < 0
            )
        {
            return false;
        }

        Cliente esistente = RicercaCliente(codiceFiscale);

        //se il cliente esiste l'istanza sarà diversa dal null
        if (esistente != null)
            return false;

        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
        Clienti.Add(cliente);

        return true;
    }


    // Ricerca Cliente //

    public Cliente RicercaCliente(string codiceFiscale)
    {

        foreach (Cliente cliente in Clienti)
        {
            if (cliente.CodiceFiscale == codiceFiscale)
                return cliente;
        }

        return null;
    }


    // Modifica Cliente //

    public Cliente ModificaCliente(string nome, string cognome, string codiceFiscale, int stipendio, string nuovoCodiceFiscale)
    {
        Cliente cliente = RicercaCliente(codiceFiscale);

        if (cliente.CodiceFiscale != "")
        {
            if (codiceFiscale == nuovoCodiceFiscale)
                cliente.CodiceFiscale = codiceFiscale;
            else
                cliente.CodiceFiscale = nuovoCodiceFiscale;

            cliente.Stipendio = stipendio;
            cliente.Nome = nome;
            cliente.Cognome = cognome;

            return cliente;
        }
        else
        {
            return null;

        }


    }


    public List<Prestito> RicercaPrestito(string codiceFiscale)
    {
        List<Prestito> trovati = new List<Prestito>();



        return trovati;
    }

    public int AmmontareTotalePrestitiCliente(string codiceFiscale)
    {
        int ammontare = 0; //metterò il conteggio

        //conteggio...

        return ammontare;
    }

    public int RateMancantiCliente(string codiceFiscale)
    {
        int rateMancanti = 0; //metterò il conteggio

        //conteggio...

        return rateMancanti;
    }

    public void StampaProspettoClienti()
    {
        //stampare per tutti i clienti
    }

    public void StampaProspettoPrestiti()
    {
        //stampa per tutti i prestiti
    }


    // Aggiungi Prestito

    public void AggiungiPrestito(Prestito nuovoPrestito)
    {
        Prestiti.Add(nuovoPrestito);
        
    }

}