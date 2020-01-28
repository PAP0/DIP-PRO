  
using System;

namespace As_You_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            //lengte van de lijst
            Console.Clear();
            Console.WriteLine("Hoe groot moet de lijst zijn?");
            int lijstLengte;
            lijstLengte = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            //maximum getal
            Console.WriteLine("Tot welk getal mogen de willekeurige getallen gaan?");
            int totGetal;
            totGetal = Convert.ToInt32(Console.ReadLine());
            
            Console.Clear();
            
            int[] lijstje = lijst(lijstLengte, totGetal);

            foreach (int getal in lijstje)
            {
                Console.WriteLine( getal ); 
            }



            int[] lijst(int aantal, int tot)
            {
                int[] nummers = new int[ aantal ];
                for (int i = 0; i < aantal; i++)
                {
                    Random randm = new Random();
                    int RandomNumber = randm.Next(tot);
                    nummers[ i ] = RandomNumber;
                }
                return nummers;
            }
            
        }
    }
}