public class Player : BaseClass
{
   public Player()
   {
       //Beschermd, mag ik bij;
       getalB += 1;

       //Openbaar, mag ik bij;
       getalA += 1;

       //Prive, mag ik bij;
       //getalC += 1;
   } 

   public void TestFunctie()
   {
       string stukjeText = "Hallo";

       if (stukjeText == "Hallo")
       {
           stukjeText += "Iets erbij";

           int tempGetal = 0;
           tempGetal += 1;

           {
               int nestedtempGetal = 200;
               nestedtempGetal += 1;

               tempGetal += 1;
           }

           //nestedtempGetal bestaat niet meer;

       }

       //Bestaat hier niet meer
       //tempGetal += 1;
       void tempFunction()
       {
           //do something......
       }
   }
}