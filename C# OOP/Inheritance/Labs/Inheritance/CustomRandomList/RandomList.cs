using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            return Console.ReadLine();
        }

    }
}
