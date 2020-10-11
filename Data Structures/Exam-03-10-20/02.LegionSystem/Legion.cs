using System.Linq;
using NGenerics.DataStructures.Trees;

namespace _02.LegionSystem
{
    using System;
    using System.Collections.Generic;
    using _02.LegionSystem.Interfaces;

    public class Legion : IArmy
    {
        public BinarySearchTree<IEnemy, int> _Army { get; set; }

        public Legion()
        {
            this._Army = new BinarySearchTree<IEnemy, int>();
        }

        //Binary Search Tree
        public int Size => _Army.Count;

        public bool Contains(IEnemy enemy)
        {
            if (_Army.ContainsKey(enemy))
            {
                return true;
            }

            return false;
        }

        public void Create(IEnemy enemy)
        {
            this._Army.Add(enemy, enemy.AttackSpeed);
        }

        public IEnemy GetByAttackSpeed(int speed)
        {
            IEnemy enemy = null;

            foreach (var atackSpeed in _Army)
            {
                if (atackSpeed.Value == speed)
                {
                    enemy = atackSpeed.Key;
                }
            }

            return enemy;
        }

        public List<IEnemy> GetFaster(int speed)
        {
            var enemies = new List<IEnemy>();

            foreach (var enemy in _Army.Keys)
            {
                if (enemy.AttackSpeed > speed)
                {
                    enemies.Add(enemy);
                }
            }

            return enemies;

        }

        public IEnemy GetFastest()
        {
            return this._Army.Maximum.Key;
        }

        public IEnemy[] GetOrderedByHealth()
        {
            var enemies = new List<IEnemy>();

            foreach (var enemy in _Army.Keys.OrderByDescending(a => a.Health))
            {
                enemies.Add(enemy);
            }

            return enemies.ToArray();
        }

        public List<IEnemy> GetSlower(int speed)
        {
            var enemies = new List<IEnemy>();

            foreach (var enemy in _Army.Keys)
            {
                if (enemy.AttackSpeed < speed)
                {
                    enemies.Add(enemy);
                }
            }

            return enemies;
        }

        public IEnemy GetSlowest()
        {
            return this._Army.Minimum.Key;
        }

        public void ShootFastest()
        {
            if (this.Size < 1)
            {
                throw new InvalidOperationException("Legion has no enemies!");
            }

            var enemy = this._Army.Maximum.Key;

            this._Army.Remove(enemy);

        }

        public void ShootSlowest()
        {
            if (this.Size < 1)
            {
                throw new InvalidOperationException("Legion has no enemies!");
            }

            var enemy = this._Army.Minimum.Key;

            this._Army.Remove(enemy);
        }
    }
}
