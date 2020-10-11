using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Core
{
    public class Controller : IController
    {

        private IPlayer mainPlayer => new MainPlayer();

        private List<IPlayer> civilPlayers;

        private Queue<IGun> guns;

        INeighbourhood neighbourhood = new GangNeighbourhood();

        public Controller()
        {
            this.civilPlayers = new List<IPlayer>();
            this.guns = new Queue<IGun>();
        }

        public string AddGun(string type, string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or a white space!");
            }
            if (type != "Pistol" && type != "Rifle")
            {
                throw new ArgumentException("Invalid gun type!");
            }
            else
            {
                if(type == "Pistol")
                {
                    var gun = new Pistol(name);
                    this.guns.Enqueue(gun);
                }
                else
                {
                    var gun = new Rifle(name);
                    this.guns.Enqueue(gun);
                }
            }
            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            if(guns.Count == 0)
            {
                throw new ArgumentException("There are no guns in the queue!");
            }
            if(name == "Vercetti")
            {
                var gun = guns.Dequeue();
                this.mainPlayer.GunRepository.Add(gun);
                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }
            else
            {
                var player = civilPlayers.FirstOrDefault(p => p.Name == name);
                if(player == null)
                {
                    throw new ArgumentException("Civil player with that name doesn't exists!");
                }
                else
                {
                    var gun = guns.Dequeue();
                    player.GunRepository.Add(gun);
                    return $"Successfully added {gun.Name} to the Civil Player: {player.Name}";
                }
            }
        }

        public string AddPlayer(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Player's name cannot be null or a whitespace!");
            }
            CivilPlayer player = new CivilPlayer(name);
            this.civilPlayers.Add(player);
            return $"Successfully added civil player: {name}!";
        }

        public string Fight()
        {
            neighbourhood.Action(mainPlayer, civilPlayers);

            var deadCivils = this.civilPlayers.Where(p => p.IsAlive == false);
            var aliveCivils = this.civilPlayers.Where(p => p.IsAlive == true);

            if(deadCivils.Count() == 0 && mainPlayer.LifePoints == 100)
            {
                return "Everything is okay!";
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("A fight happened:");
                sb.AppendLine($"Tommy live points: {this.mainPlayer.LifePoints}!");
                sb.AppendLine($"Tommy has killed: {deadCivils.Count()} players!");
                sb.Append($"Left Civil Players: {aliveCivils.Count()}!");

                return sb.ToString();
            }
        }
    }
}
