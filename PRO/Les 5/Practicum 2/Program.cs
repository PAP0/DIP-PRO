using System;
using yolo;

namespace Practicum_2 
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassA instantieX = new ClassA();

            instantieX.stukTekst += "Nog iets";
            instantieX.LaatWatZien();

            Console.WriteLine("variabele in class: " + instantieX.stukTekst);
             Console.WriteLine("variabele in class in andere namespace: " + instantieX.stukTekst);
            Console.WriteLine("tijdelijke variabele in functie in namespace: " + ClassA.LaatWatZien);

            ClassB instantieY = new ClassB();

            instantieY.LaatWatZien();

            ClassB.statischeIntOpenbaar += 432;

            
        
        }
    }
}
