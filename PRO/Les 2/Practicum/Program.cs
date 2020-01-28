using System;

namespace Practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();
            Player ourPlayer = new Player("Soviet Russia");
            Player yourPlayer = new Player("Gae");

            myPlayer.Jump();
            
            yourPlayer.Shoot(69);

        }
    }
}
