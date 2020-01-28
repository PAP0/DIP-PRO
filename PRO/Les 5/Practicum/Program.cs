using System;

using HulpClasses;
using HulpClasses.MeerClasses;

namespace Practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();

            //Openbaar, mag ik bij;
            myPlayer.getalA += 1;

            //Beschermt, mag ik hier niet bij;
            //myPlayer.getalB += 1;

            //Openbaar, aleen via blauwdruk (class)
            BaseClass.staticText += "Lmao xD xD";
            Player.staticText += "Another lmao";

            //Static kan niet via instantie worden benaderd;
            //myPlayer.staticText += "You can't";

            HulpClassA test = new HulpClassA();
            HulpClassB test2 = new HulpClassB();

            HulpClassX nogeen = new HulpClassX();
        }
    }
}
