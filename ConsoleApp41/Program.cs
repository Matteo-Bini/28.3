using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp41
{
    internal class Program
    {
        static void Main(string[] args, int app)
        {
            Box box = new Box();
            Appartamenti appartamenti = new Appartamenti();
            Ville ville = new Ville();
            int b;
            
            
            Console.WriteLine("Che genere di immobile stai cercando? Premere 1 per guardare i box, 2 per guardare gli appartamenti o un qualsiasi altro numero per guardare le ville");
            try
            {
                b = int.Parse(Console.ReadLine());
            }
            catch 
            {
                Console.WriteLine("Hai inserito un input sbagliato");               
            }
            for (int controllore = 0; controllore == app; controllore++)
            {
                if (controllore == 1)
                {
                Console.WriteLine("inserisci di seguito il codice alfanumerico, l'indirizzo, il cap, la città e i metri quadrati");
                    box.codalfanum = Console.ReadLine();
                    box.indirizzo = Console.ReadLine();
                    box.cap = int.Parse(Console.ReadLine());
                    box.città = Console.ReadLine();
                    box.mq = int.Parse(Console.ReadLine());
                    box.postiauto = int.Parse(Console.ReadLine());
                    Console.WriteLine("ti aggiorneremo presto sulle offerte trovate");

                }
                else if( controllore == 2) 
                {
                    Console.WriteLine("inserisci di seguito il codice alfanumerico, l'indirizzo, il cap, la città, i metri quadrati, il numero dei vani e dei bagni");
                    appartamenti.codalfanum = Console.ReadLine();
                    appartamenti.indirizzo= Console.ReadLine();
                    appartamenti.cap = int.Parse(Console.ReadLine());
                    appartamenti.città= Console.ReadLine();
                    appartamenti.mq = int.Parse(Console.ReadLine());
                    appartamenti.vani = int.Parse(Console.ReadLine());
                    appartamenti.bagni = int.Parse(Console.ReadLine());
                    Console.WriteLine("ti aggiorneremo presto sulle offerte trovate");

                }
                else if( controllore == 3) 
                {
                    Console.WriteLine("inserisci di seguito il codice alfanumerico, l'indirizzo, il cap, la città, i metri quadrati, il numero dei vani, dei bagni e i metri quadrati del giardino");
                    ville.codalfanum = Console.ReadLine();
                    ville.indirizzo = Console.ReadLine();
                    ville.cap = int.Parse(Console.ReadLine());
                    ville.città = Console.ReadLine();
                    ville.mq = int.Parse(Console.ReadLine());
                    ville.vani = int.Parse(Console.ReadLine());
                    ville.bagni = int.Parse(Console.ReadLine());
                    ville.mqgiardino = int.Parse(Console.ReadLine());
                    Console.WriteLine("ti aggiorneremo presto sulle offerte trovate");
                }
                else
                {
                    Console.WriteLine("Non riusciamo a trovare ciò che cerchi");
                }

            }
            Console.ReadLine();
        }
    }
}
