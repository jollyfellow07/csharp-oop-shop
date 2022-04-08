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

        public double GetPrezzo()
        { 
            return prezzo;
        }

        public int GetCodice()
        {

            codice = numeroRandomCodice();
            return codice;
        }
     

        public int numeroRandomCodice()
        {
            Random codiceRandom = new Random();
            return (int)codiceRandom.Next(1000000000);
        }
        public void stampa()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n**************"+ codice+ "-" + name +  "***************");
            Console.WriteLine("Il nome del prodotto è: " + name);
            Console.WriteLine("il codice è: " + codice );
            Console.WriteLine("il prezzo senza iva è: " +  prezzo + "€");
            Console.WriteLine("L'iva del prodotto è: " + iva + "%");
            Console.WriteLine("Il prezzo del prodotto con iva è: " + CalcoloPrezzoConIva() + "€");
            Console.WriteLine("\n**************************************");
        }

        public double CalcoloPrezzoConIva()
        {
            double prezzoFinale;
            if (iva == 22)
            {
                prezzoFinale = prezzo * 1.22;
               
            }
            else if (iva == 5)
            {
                prezzoFinale = prezzo * 1.05;
                
            }  else
            {
                prezzoFinale = prezzo * 1.10;
            }
           prezzoFinale = Math.Round(prezzoFinale, 2);         
            return prezzoFinale;
        }
        

            
             
    }
}
