using System.ComponentModel.Design;
using System.Linq;

namespace _01.Inventory
{
    using _01.Inventory.Interfaces;
    using _01.Inventory.Models;
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class Inventory : IHolder
    {
        public List<IWeapon> _Weapons { get; set; }

        public Inventory()
        {
            this._Weapons = new List<IWeapon>();
        }

        public int Capacity => this._Weapons.Count;

        public void Add(IWeapon weapon)
        {
            this._Weapons.Add(weapon);
        }

        public void Clear()
        {
            this._Weapons = new List<IWeapon>();
        }

        public bool Contains(IWeapon weapon)
        {
            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i] == weapon)
                {
                    return true;
                }
            }

            return false;
        }

        public void EmptyArsenal(Category category)
        {
            var weapons = new List<IWeapon>();

            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i].Category == category)
                {
                    weapons.Add(this._Weapons[i]);
                }
            }

            foreach (var weapon in weapons)
            {
                weapon.Ammunition = 0;
            }
        }

        public bool Fire(IWeapon weapon, int ammunition)
        {
            IWeapon searchedWeapon = null;

            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i] == weapon)
                {
                    searchedWeapon = this._Weapons[i];
                }
            }

            if (searchedWeapon != null)
            {
                if (searchedWeapon.Ammunition >= ammunition)
                {
                    searchedWeapon.Ammunition -= ammunition;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }
        }

        public IWeapon GetById(int id)
        {
            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i].Id == id)
                {
                    return this._Weapons[i];
                }
            }

            return null;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < this.Capacity; i++)
            {
                yield return this._Weapons[i];
            }
        }

        public int Refill(IWeapon weapon, int ammunition)
        {
            IWeapon searchedWeapon = null;

            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i] == weapon)
                {
                    searchedWeapon = this._Weapons[i];
                }
            }

            if (searchedWeapon != null)
            {
                searchedWeapon.Ammunition += ammunition;
                if (searchedWeapon.Ammunition > searchedWeapon.MaxCapacity)
                {
                    searchedWeapon.Ammunition -= searchedWeapon.Ammunition - searchedWeapon.MaxCapacity;
                }
            }
            else
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }

            return searchedWeapon.Ammunition;
        }


        public IWeapon RemoveById(int id)
        {
            var weapon = this.GetById(id);

            this._Weapons.Remove(weapon);

            return weapon;
        }

        public int RemoveHeavy()
        {
            var heavyWeapons = new List<IWeapon>();

            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i].Category == Category.Heavy)
                {
                    heavyWeapons.Add(this._Weapons[i]);
                }
            }

            foreach (var heavyWeapon in heavyWeapons)
            {
                this._Weapons.Remove(heavyWeapon);
            }

            return heavyWeapons.Count;
        }

        public List<IWeapon> RetrieveAll()
        {
            var weapons = new List<IWeapon>();
            for (int i = 0; i < this.Capacity; i++)
            {
                weapons.Add(this._Weapons[i]);
            }

            return weapons;
        }

        public List<IWeapon> RetriveInRange(Category lower, Category upper)
        {
            var weapons = new List<IWeapon>();

            for (int i = 0; i < this.Capacity; i++)
            {
                if ((int) this._Weapons[i].Category >= (int) lower && (int) this._Weapons[i].Category <= (int) upper)
                {
                    weapons.Add(this._Weapons[i]);
                }
            }

            return weapons;
        }

        public void Swap(IWeapon firstWeapon, IWeapon secondWeapon)
        {
            //For loop from first element to last element and check if some of the elements are missing throw error
            var firstId = -1;
            var secondId = -2;

            for (int i = 0; i < this.Capacity; i++)
            {
                if (this._Weapons[i] == firstWeapon)
                {
                    firstId = i;
                }

                if (this._Weapons[i] == secondWeapon)
                {
                    secondId = i;
                }
            }

            if (firstId >= 0 && secondId >= 0 && firstWeapon.Category == secondWeapon.Category)
            {
                this._Weapons[firstId] = secondWeapon;
                this._Weapons[secondId] = firstWeapon;
            }
            else
            {
                throw new InvalidOperationException("Weapon does not exist in inventory!");
            }
        }

    }
}
