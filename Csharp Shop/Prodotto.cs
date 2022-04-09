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

        /* METODO: ASSEGNO AL CODICE IL NUMERO RANDOM*/
        public int GetCodice()
        {

            codice = numeroRandomCodice();
            return codice;
        }



        /*METODO: CALCOLA NUMERO RANDOM*/
        public int numeroRandomCodice()
        {
            Random codiceRandom = new Random();
            return codiceRandom.Next(100000000);
        }

        /*STAMPA TUTTE LE CARATTERISTICHE DEL MIO PRODOTTO*/
        public void stampa()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n**************" + codice + "-" + name + "***************");
            Console.WriteLine("Il nome del prodotto è: " + name);
            Console.WriteLine("La descrizione del mio prodotto: " + descrizione);
            Console.WriteLine("il codice è: " + codice);
            Console.WriteLine("il prezzo senza iva è: " + prezzo + "€");
            Console.WriteLine("L'iva del prodotto è: " + iva + "%");
            Console.WriteLine("Il prezzo del prodotto con iva è: " + CalcoloPrezzoConIva() + "€");
            Console.WriteLine("**************************************");
        }

        /*METODO: PER CALCOLARE IL PREZZO CALCOLATO CON IVA*/

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

            }
            else
            {
                prezzoFinale = prezzo * 1.10;
            }
            prezzoFinale = Math.Round(prezzoFinale, 2);
            return prezzoFinale;
        }

        /*METODO CHE STAMPA IN UNA SOLA RIGA CODICE PRODOTTO E NOME*/
        public void articolo()
        {
            Console.WriteLine(codice + "-" + name);
        }
        /*METODO CHE STAMPA SOLO IL PREZZO*/
        public void GetPrezzo()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Il prezzo del mio articolo è " + prezzo + "€");
        }
        /*METODO CHE STAMPA SOLO L'IVA*/
        public void GetIva()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("L'IVA del mio articolo è " + iva + "%" );
        }


    }
}
