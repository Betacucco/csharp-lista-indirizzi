using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class Address
    {
        private string nome;
        private string cognome;
        private string indirizzo;
        private string citta;
        private string provincia;
        private string cap;

        public Address(string nome, string cognome, string indirizzo, string citta, string provincia, string cap)
        {
            ControlloElementi(nome);
            this.nome = nome;
            ControlloElementi(cognome);
            this.cognome = cognome;
            ControlloElementi(indirizzo);
            this.indirizzo = indirizzo;
            ControlloElementi(citta);
            this.citta = citta;
            ControlloElementi(provincia);
            this.provincia = provincia;
            ControlloElementi(cap);
            this.cap = cap;
        }

        //--------------GETTERS--------
        public string GetNome()
        {
            return nome;
        }

        public string GetCognome()
        {
            return cognome;
        }

        public string GetIndirizzo()
        {
            return indirizzo;
        }

        public string GetCitta()
        {
            return citta;
        }

        public string GetProvincia()
        {
            return provincia;
        }

        public string GetCap()
        {
            return cap;
        }
        //----------------------------------


        //----------SETTER--------------
        public void SetCap(string cap)
        {
            bool canConvert = int.TryParse(cap, out int val);
            if(canConvert == true && cap.Length == 5)
            {
                this.cap = cap;
            } 
            else
            {
                throw new Exception("Non hai inserito numeri");
            }
        }

        //Controllo se sono stringhe null
        private static void ControlloElementi(string controllo)
        {
            if (controllo == "")
            {
                throw new Exception("Elemento non inserito");
            } 
        }

        //Override metodo toString per stampare gli elementi del file
        public override string ToString()
        {
            string rapresentazioneInStringa = "------- Informazioni Personali -------\n";
            rapresentazioneInStringa += "Nome:\t" + this.nome + "\n";
            rapresentazioneInStringa += "Cognome:\t" + this.cognome + "\n";
            rapresentazioneInStringa += "Indirizzo:\t" + this.indirizzo + "\n";
            rapresentazioneInStringa += "Citta:\t" + this.citta + "\n";
            rapresentazioneInStringa += "Provincia:\t" + this.provincia + "\n";
            rapresentazioneInStringa += "CAP:\t" + this.cap + "\n";
            rapresentazioneInStringa += "---------------------";
            return rapresentazioneInStringa;
        }

    }
}
