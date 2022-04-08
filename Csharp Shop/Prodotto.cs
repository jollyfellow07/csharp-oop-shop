using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Shop
{
    internal class Prodotto
    {
        private int codice;
        private string name;
        private string descrizione;
        private double prezzo;
        private double iva;

        public Prodotto(string name, string descrizione, double prezzo, double iva)
        {
            
            this.name = name;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
        }
        
        public int GetCodice()
        {
            
            codice = numeroRandomCodice();
            Console.Write("il codice prodotto è: " + codice);
            return codice;
        }
        public string GetDescrizione()
        { 
            return descrizione;
        }

        public int numeroRandomCodice()
        { 
            Random codiceRandom = new Random();
            return (int)codiceRandom.Next(50);
        }
             
    }
}
