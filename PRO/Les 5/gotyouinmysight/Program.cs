using System;
using yolo;

namespace gotyouinmysight
{
    class Program
    {
        static void Main(string[] args)
        {
            variableinclass xyz = new variableinclass();
            variableinclassinnamespace abc = new variableinclassinnamespace();
            abc.tijdelijk();
            Console.WriteLine("variabele in class: " + xyz.variabeleA);
            Console.WriteLine("Variabele in class in andere namespace: " + abc.variabeleB);
        }
    }
}
