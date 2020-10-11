using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony
{
    public class Smartphone : ISmartphone
    {
        public void Browse(string webSite)
        {
            for (int i = 0; i < webSite.Length; i++)
            {
                if(char.IsDigit(webSite[i]))
                {
                    throw new ArgumentException("Invalid URL!");
                }
            }

            Console.WriteLine($"Browsing: {webSite}!");
        }

        public void Call(string num)
        {
            for (int i = 0; i < num.Length; i++)
            {
                if (!char.IsDigit(num[i]))
                {
                    throw new ArgumentException("Invalid number!");
                }
            }

            Console.WriteLine($"Calling... {num}");
        }
    }
}
