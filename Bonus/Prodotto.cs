namespace Bonus
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

        /*bonus*/
        public string padleft()
        {
            
            string strvalue = Convert.ToString(codice).PadLeft(8,'0');
            return strvalue;
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
            Console.WriteLine("\n**************PRODOTTO***************");
            Console.WriteLine("Il nome del prodotto è: " + name);
            Console.WriteLine("La descrizione del mio prodotto: " + descrizione);
            Console.WriteLine("il codice è: " + padleft());
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




    }
}
