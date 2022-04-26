using ListaIndirizzi;

string path = "C:\\Users\\marco\\source\\repos\\ListaIndirizzi\\ListaIndirizzi\\addresses.csv";

List<Address> indirizzi = new List<Address>();

StreamReader file = new StreamReader(path);

file.ReadLine();
while (!file.EndOfStream)
{
    string riga = file.ReadLine();
    string[] informazionePerDividere = riga.Split(',');
      
    if (informazionePerDividere.Length == 6)
    {
        try
        {  
            string nome = informazionePerDividere[0];
            string cognome = informazionePerDividere[1];
            string indirizzo = informazionePerDividere[2];
            string citta = informazionePerDividere[3];
            string provincia = informazionePerDividere[4];
            string cap = informazionePerDividere[5];

            indirizzi.Add(new Address(nome, cognome, indirizzo, citta, provincia, cap));

            Console.WriteLine();
        } 
        catch(Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
    else
    {
        Console.WriteLine("Elementi inseriti non correttamente!");
    }
}

file.Close();

foreach(Address indirizzo in indirizzi)
{
    Console.WriteLine(indirizzo.ToString());
    Console.WriteLine();    
}