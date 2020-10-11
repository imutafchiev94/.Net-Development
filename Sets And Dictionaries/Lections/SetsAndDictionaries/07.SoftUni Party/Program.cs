using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularGuests = new HashSet<string>();

            var VIPGuests = new HashSet<string>();

            Regex regex = new Regex(@"[0-9]");

            var input = Console.ReadLine();

            while(input != "PARTY")
            {
                string firstSymbol = input[0].ToString();

                if(regex.IsMatch(firstSymbol))
                {
                    VIPGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "END")
            {
                if (VIPGuests.Contains(input))
                {
                    VIPGuests.Remove(input);
                }
                else if(regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }

                input = Console.ReadLine();
            }

            var count = VIPGuests.Count + regularGuests.Count;

            Console.WriteLine(count);

            if(VIPGuests.Count > 0)
            {
                foreach (var guest in VIPGuests)
                {
                    Console.WriteLine(guest);
                }
            }
            if(regularGuests.Count > 0)
            {
                foreach (var guest in regularGuests)
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}
