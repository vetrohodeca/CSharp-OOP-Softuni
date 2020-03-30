using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            DarkKnight darkKnight = new DarkKnight("Gosho", 8);
            Console.WriteLine(darkKnight.Username);
            Console.WriteLine(darkKnight);
        }
    }
}
