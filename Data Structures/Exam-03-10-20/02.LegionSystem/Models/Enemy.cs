﻿using System.Linq;

namespace _02.LegionSystem.Models
{
    using System;
    using _02.LegionSystem.Interfaces;

    public class Enemy : IEnemy
    {
        public Enemy(int attackSpeed, int health)
        {
            this.AttackSpeed = attackSpeed;
            this.Health = health;
        }

        public int AttackSpeed { get; set; }

        public int Health { get; set; }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            IEnemy otherEnemy = obj as IEnemy;
            if (otherEnemy != null)
            {
                if (this.AttackSpeed > otherEnemy.AttackSpeed)
                    return 1;
                else if (this.AttackSpeed < otherEnemy.AttackSpeed)
                    return -1;
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new ArgumentException();
            }
        }
    }
}
