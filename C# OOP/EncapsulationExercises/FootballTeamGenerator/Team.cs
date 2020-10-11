using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {

        private string name;

        private List<Player> players;

        public Team(string name)
        {
            this.Name = name;

            this.players = new List<Player>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }

                this.name = value;
            }
        }

        public IReadOnlyCollection<Player> Players
        {
            get
            {
                return this.players.AsReadOnly();
            }
        }

        private int rating
        {
            get
            {
                double allStats = 0;

                foreach(var player in this.players)
                {
                    allStats += CalculatePlayerStats(player);
                }

                double stat = Math.Round(allStats / this.players.Count);

                return int.Parse(stat.ToString());
            }
        }


        private int CalculatePlayerStats(Player player)
        {
            double stats = 0;

            stats = player.Endurance + player.Sprint + player.Dribble + player.Passing + player.Shooting;

            var totalStats = Math.Round(stats / 5);
            return int.Parse(totalStats.ToString());
        }

        public void AddPlayer(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            Player player = new Player(name, endurance, sprint, dribble, passing, shooting);

            this.players.Add(player);
        }

        public void RemovePlayer(string name)
        {
            var player = this.players.FirstOrDefault(p => p.Name == name);

            if(player == null)
            {
                Console.WriteLine($"Player {name} is not in {this.name} team.");
            }

            else
            {
                this.players.Remove(player);
            }
        }

        public void Rating()
        {
            if (this.players.Count > 0)
            {
                Console.WriteLine($"{this.name} - {this.rating}");
            }
            else
            {
                Console.WriteLine($"{this.name} - {0}");
            }
        }
    }
}
