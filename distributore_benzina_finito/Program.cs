using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using distributore_benzina_finito;

namespace distributorre_di_benzina
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                distributore_benzina distributore = new distributore_benzina("dkjfh2", "via caio", 100);//INFORMAZIONI inserite nel custrottore 
                int c = 0;
                Console.WriteLine("scegliere opzione");
                do
                {
                    Console.WriteLine("1-caricare soldi");
                    Console.WriteLine("2-impostare prezzo al litro");
                    Console.WriteLine("3-riempire il distrributore");
                    Console.WriteLine("4-erogare benzina");
                    Console.WriteLine("5-confrontare due distributori");

                    c = int.Parse(Console.ReadLine());
                    if (c == 1)
                    {
                        int soldi;
                        Console.WriteLine("inserisci soldi");
                        soldi = int.Parse(Console.ReadLine());
                        bool controllo = true;
                        while (controllo == true)
                        {
                            int a;
                            Console.WriteLine("vuoi inserire altri soldi ? 1=si 2=no");
                            a = int.Parse(Console.ReadLine());
                            if (a == 1)
                            {
                                int b = int.Parse(Console.ReadLine());
                                soldi = soldi + b;
                                b = 0;
                            }
                            if (a == 2)
                            {
                                distributore.AggiungiDenaro(soldi);//passo i dati nella funzione nella classe
                                controllo = false;
                            }
                            Console.WriteLine(distributore.Denaro_caricato);// per avviare il programma schiaccia ctrl+f5 se no termina subito 
                        }

                    }
                    if (c == 2)
                    {
                        Console.WriteLine("immettere il prezzo al litro");
                        distributore.Prezzo_litro = int.Parse(Console.ReadLine());
                        Console.WriteLine("il prezzo al litro è di " + distributore.Prezzo_litro);

                    }
                    if (c == 3)
                    {
                        Console.WriteLine("di quanto vuoi riempire il distributore ?");
                        int litri = 0;
                        litri = int.Parse(Console.ReadLine());
                        distributore.ControlloRiempireDistributore(litri);


                    }
                    if (c == 4)
                    {
                        Console.WriteLine("quanti litri di benzina vuoi prelevare?");
                        int benzina_erogata = int.Parse(Console.ReadLine());
                        //int benzina_erogata = distributore.Denaro_caricato / distributore.Prezzo_litro;
                        distributore.ControlloLivelloBenzinaErogazione(benzina_erogata);



                    }

                    if (c == 5)
                    {
                        distributore_benzina distributore2 = new distributore_benzina("dkjfh2", "via caio", 100);
                        Console.WriteLine("inserisci costo benzina al litro del distributore2");
                        distributore2.Prezzo_litro = int.Parse(Console.ReadLine());
                        distributore2 = distributore2.confrontaDistributorMinore(distributore);
                        Console.WriteLine(distributore2.Prezzo_litro);



                    }
                } while (c >= 1 && c <= 5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}