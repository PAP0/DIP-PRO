using System;

namespace Practicum
{
    class Program
    {
        static void Main(string[] args)
        {
            Player myPlayer = new Player();

            Console.WriteLine("LIVES " + myPlayer.lives);
            Console.WriteLine("POINTS " + myPlayer.points);

            myPlayer.points += 130;
            Console.WriteLine("LIVES " + myPlayer.lives);
            Console.WriteLine("POINTS " + myPlayer.points);

        }
    }
}
