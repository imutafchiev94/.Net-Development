using System;
using System.Linq;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToArray();

            var webSites = Console.ReadLine().Split().ToArray();

            ISmartphone smartphone = new Smartphone();

            IStationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                try
                {
                    if (numbers[i].Length == 10)
                    {
                        smartphone.Call(numbers[i]);
                    }
                    else if (numbers[i].Length == 7)
                    {
                        stationaryPhone.Dialing(numbers[i]);
                    }
                }

                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            for (int i = 0; i < webSites.Length; i++)
            {
                try
                {
                    smartphone.Browse(webSites[i]);
                }
                catch(ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }
            }

            if(webSites.Length == 0)
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}
