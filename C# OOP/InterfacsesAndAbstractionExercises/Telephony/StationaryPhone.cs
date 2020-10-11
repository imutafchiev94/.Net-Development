using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class StationaryPhone : IStationaryPhone
    {
        public void Dialing(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i]))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }

            Console.WriteLine($"Dialing... {num}");
        }
    }
}
