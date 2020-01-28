using System;

namespace yolo
{

	public class variableinclassinnamespace
	{
		public string variabeleB = "hfaowhfouiaewhgfouiaewhg";

        public void tijdelijk()
        {
            {
                int tijdelijkevariabeleB = 69;
                Console.WriteLine("Tijdelijke variabele binnen een body { } binnen een functie: " + tijdelijkevariabeleB); 
            }
            int tijdelijkevariabeleA = 420;
            Console.WriteLine("Tijdelijke variabele in functie in namespace: " + tijdelijkevariabeleA);


        }
    }
}