using System;

namespace CustomRandomList
{
    public class Program
    {
        static void Main(string[] args)
        {
            RandomList list = new RandomList();

            list.Add(list.RandomString());
            list.Remove(list.RandomString());
        }
    }
}
