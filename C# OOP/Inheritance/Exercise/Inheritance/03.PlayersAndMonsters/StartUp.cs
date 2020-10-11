using System;

namespace _03.PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Elf elf = new Elf("Gosho", 10);

            Console.WriteLine(elf.ToString());
        }
    }
}
