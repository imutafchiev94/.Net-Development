    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace _07.TheV_Logger
    {
        class Program
        {
            static void Main(string[] args)
            {
                var input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                var vloggers = new List<Vlogger>();

                while(input[0] != "Statistics")
                {
                    if(input.Length == 4)
                    {
                        if(vloggers.Find(v => v.Name == input[0]) == null)
                        {
                            var vlogger = new Vlogger();
                            vlogger.Name = input[0];
                            vlogger.Followers = new List<Vlogger>();
                            vlogger.Following = 0;

                            vloggers.Add(vlogger);
                        }
                    }
                    else if(input.Length == 3)
                    {
                        var firstVlogger = vloggers.Find(v => v.Name == input[0]);
                        var secondVlogger = vloggers.Find(v => v.Name == input[2]);

                        if ( firstVlogger != null &&  secondVlogger != null && firstVlogger.Name != secondVlogger.Name)
                        {
                            if(secondVlogger.Followers.FirstOrDefault(x => x.Name == firstVlogger.Name) == null)
                            {
                                secondVlogger.Followers.Add(firstVlogger);
                                firstVlogger.Following++;
                            }
                        }
                    }


                    input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                }

                Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

                int count = 1;

                foreach (var vlog in vloggers.OrderByDescending(x => x.Followers.Count).ThenBy(x => x.Following))
                {
                    if(count == 1)
                    {
                        Console.WriteLine($"{count}. {vlog.Name} : {vlog.Followers.Count} followers, {vlog.Following} following");
                        foreach (var followers in vlog.Followers.OrderBy(x => x.Name))
                        {
                            Console.WriteLine($"*  {followers.Name}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{count}. {vlog.Name} : {vlog.Followers.Count} followers, {vlog.Following} following");
                    }

                    count++;
                }
            }
        }
    

        public class Vlogger
        {

            public Vlogger()
            {
                this.Followers = new List<Vlogger>();
            }

            public string Name { get; set; }

            public List<Vlogger> Followers { get; set; }

            public int Following { get; set; }
        }
    }
