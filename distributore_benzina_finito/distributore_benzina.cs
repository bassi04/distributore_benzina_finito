using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distributore_benzina_finito
{
    public class distributore_benzina
    {
        private string _numero_seriale;
        private string _indirizzo;
        private int _capacita_massima; // la quantita massima di benzina che può contenere il distributore 
        private int _livello_benzina; // la quantita di benzina presente in questo momento 
        private int _denaro_caricato;
        private int _prezzo_litro;

        public string Numero_seriale { get { return _numero_seriale; } private set { _numero_seriale = value; } }
        public string Indirizzo { get { return _indirizzo; } set { _indirizzo = value; } }
        public int Capacita_massima { get { return _capacita_massima; } private set { _capacita_massima = value; } }
        public int Livello_benzina { get { return _livello_benzina; } set { _livello_benzina = value; } }
        public int Denaro_caricato { get { return _denaro_caricato; } set { _denaro_caricato = value; } }
        public int Prezzo_litro
        {
            get
            {

                return _prezzo_litro;

            }
            set
            {
                _prezzo_litro = value;
            }
        }
        public distributore_benzina(string _numero_seriale, string _indirizzo, int _capacita_massima) // costruttore dove vanno dichiarate le variabili che non possono essere cambiate dal utente
        {
            this.Numero_seriale = _numero_seriale;
            this.Indirizzo = _indirizzo;
            this.Capacita_massima = _capacita_massima;


        }

        public distributore_benzina(string _numero_seriale) : this(_numero_seriale, "", 100)
        {

        }

        public void AggiungiDenaro(int soldi)
        {
            if (soldi < 0)
            {
                throw new Exception("numero negativo");
            }


            Denaro_caricato = soldi;


            ControlloDenaro(Denaro_caricato);



        }

        public void ControlloDenaro(int Denaro_caricato)
        {
            if (Denaro_caricato >= 5 && Denaro_caricato <= 100)
            {

            }
            else
            {

                throw new Exception("inserire credito maggiore di 5 ma minore di 100"); //non fa proseguire l'utente 
            }



        }

        public void ControlloRiempireDistributore(int litri)
        {
            if (litri < 0)
            {
                throw new Exception("numero negativo");
            }
            LvelloBenzinaIniziale();
            Livello_benzina = Livello_benzina + litri;

            if (Livello_benzina > Capacita_massima)
            {
                throw new Exception("il distributore si riempirebbe troppo");
            }


        }

        public void ControlloLivelloBenzinaErogazione(int benzina_erogata)
        {

            if (benzina_erogata < 0)
            {
                throw new Exception("numero negativo");
            }

            LvelloBenzinaIniziale();

            if (benzina_erogata / Prezzo_litro > Denaro_caricato / Prezzo_litro)
            {
                throw new Exception("soldi non sufficenti ");

            }


            Livello_benzina = Livello_benzina - benzina_erogata / Prezzo_litro;


            if (Livello_benzina < 0)
            {
                throw new Exception("siamo spiacenti ma il distributore non ha abbastana benzina ");

            }

            if (benzina_erogata == 0)
            {
                throw new Exception("verificare se si ha inserito il denaro e se si ha impostato il prezzo a litro ");
            }


            Console.WriteLine(Livello_benzina);

        }


        public distributore_benzina confrontaDistributorMinore(distributore_benzina b)
        {
            if (this.Prezzo_litro < b.Prezzo_litro)
            {
                return this;
            }
            return b;

        }

        public void LvelloBenzinaIniziale()
        {
            int a = 0;
            if (Livello_benzina == 0 && a == 0)
            {
                Livello_benzina = Capacita_massima;
                a = 1;
            }
            else
            {

            }
        }
        /* public int ToString()
         {
             return Prezzo_litro;
         }*/
    }
}
