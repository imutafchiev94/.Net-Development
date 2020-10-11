using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contest> contests = new List<Contest>();

            List<User> users = new List<User>();

            var input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end of contests")
            {
                var name = input[0];
                var password = input[1];

                var contest = new Contest()
                {
                    Name = name,
                    Password = password
                };

                contests.Add(contest);

                input = Console.ReadLine().Split(':', StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();

            while (input[0] != "end of submissions")
            {
                var contestName = input[0];
                var password = input[1];
                var userName = input[2];
                var points = long.Parse(input[3]);

                if(contests.FirstOrDefault(c => c.Name == contestName) != null)
                {
                    if (contests.FirstOrDefault(c => c.Name == contestName).Password == password)                    
                    {
                        if(users.Count == 0)
                        {
                            var user = new User()
                            {
                                Name = userName,
                                Points = points,
                                Contests = new Dictionary<string, long>()
                            };

                            user.Contests.Add(contestName, points);

                            users.Add(user);

                            var contest = contests.FirstOrDefault(c => c.Name == contestName);

                            contest.UserNamePoints.Add(userName, points);
                        }
                        else
                        {
                            if(users.FirstOrDefault(u => u.Name == userName) == null)
                            {
                                var user = new User()
                                {
                                    Name = userName,
                                    Points = points,
                                    Contests = new Dictionary<string, long>()
                                };

                                user.Contests.Add(contestName, points);

                                users.Add(user);
                                var contest = contests.FirstOrDefault(c => c.Name == contestName);

                                contest.UserNamePoints.Add(userName, points);
                            }
                            else
                            {
                                var user = users.FirstOrDefault(u => u.Name == userName);

                                var contest = contests.FirstOrDefault(c => c.Name == contestName);

                                if (user.Contests.ContainsKey(contestName))
                                {
                                    if(contest.UserNamePoints.ContainsKey(userName))
                                    {
                                        if(contest.UserNamePoints[userName] < points)
                                        {

                                            var point = contest.UserNamePoints[userName];

                                            contest.UserNamePoints[userName] = points;

                                            user.Points += points;

                                            user.Contests[contestName] = points;
                                        }
                                    }
                                    else
                                    {
                                        contest.UserNamePoints[userName] = points;

                                        user.Contests.Add(contestName, points);
                                    }
                                }
                                else
                                {
                                    user.Contests.Add(contestName, points);
                                    user.Points += points;
                                    contest.UserNamePoints[userName] = points;
                                }
                            }
                        }
                    }
                }

                input = Console.ReadLine().Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            var count = 1;
            
            foreach (var user in users.OrderByDescending(x => x.Points))
            {
                if(count == 1)
                {
                    Console.WriteLine($"Best candidate is {user.Name} with total {user.Points} points.");
                    break;
                }
            }

            Console.WriteLine("Ranking:");

            foreach (var user in users.OrderBy(u => u.Name))
            {
                Console.WriteLine(user.Name);
                foreach (var contest in user.Contests.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }


    class User
    {
        public User()
        {
            this.Contests = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public long Points { get; set; }

        public Dictionary<string, long> Contests { get; set; }
    }

    class Contest
    {

        public Contest()
        {
            this.UserNamePoints = new Dictionary<string, long>();
        }

        public string Name { get; set; }

        public string Password { get; set; }

        public Dictionary<string, long> UserNamePoints { get; set; }
    }
}
