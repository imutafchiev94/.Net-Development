using System;
using System.Collections.Generic;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Models.Players
{
    public abstract class Player : IPlayer
    {

        private string name;

        private bool isAlive;


        private IRepository<IGun> gunRepository;
        //{
        //    get
        //    {
        //        return this.gunRepository;
        //    }
        //    set
        //    {
        //        this.gunRepository = value;
        //    }
        //}

        private int lifePoints;
        //{
        //    get
        //    {
        //        return this.lifePoints;
        //    }
        //    set
        //    {
        //        if(value < 0)
        //        {
        //            throw new ArgumentException("Player life points cannot be below zero!");
        //        }
        //        else
        //        {
        //            this.lifePoints = value;
        //        }
        //    }
        //}


        public Player(string name, int lifePoints)
        {
            this.name = name;

            this.lifePoints = lifePoints;

            this.gunRepository = new GunRepository();

        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }
        

        public bool IsAlive
        {
            get
            {
                if (this.lifePoints > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            set
            {
                if (this.lifePoints > 0)
                {
                    this.IsAlive = true;
                }
                else
                {
                    this.IsAlive = false;
                }
            }
        }

        public IRepository<IGun> GunRepository
        {
            get
            {
                return this.gunRepository;
            }
            set
            {
                this.gunRepository = value;
            }
        }


        public int LifePoints
        {
            get
            {
                return this.lifePoints;
            }
        }

        public void TakeLifePoints(int points)
        {
            if(this.LifePoints - points > 0)
            {
                this.lifePoints -= points;
            }
            else
            {
                this.lifePoints = 0;
                this.isAlive = false;
            }
        }
    }
}
