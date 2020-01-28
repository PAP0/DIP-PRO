using System;

namespace yolo
{
    public class ClassA 
    {
        public string stukTekst = "Hallo";
        protected int GetalBeschermt = 55;
        private byte getalPrive = 123;
        public void LaatWatZien()
        {
            Console.WriteLine("getalPrive: " + getalPrive);
            int getalXYZ = 21;
        }
    }

}