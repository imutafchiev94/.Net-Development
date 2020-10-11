using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heroes
{
    public class HeroRepository
    {

        private List<Hero> data;

        public HeroRepository()
        {
            this.data = new List<Hero>();
        }


        public int Count
        {
            get 
            {
                return this.data.Count();
            }
        }

        public void Add(Hero hero)
        {
            this.data.Add(hero);
        }

        public void Remove(string name)
        {

            var heroToRemove = this.data.FirstOrDefault(h => h.Name == name);

            if(heroToRemove != null)
            {
                this.data.Remove(heroToRemove);
            }

        }

        public Hero GetHeroWithHighestStrength()
        {
            Hero heroWithHighestStrenght = null;

            var strenght = 0;

            foreach (var hero in this.data)
            {
                if(hero.Item.Strength > strenght)
                {
                    strenght = hero.Item.Strength;

                    heroWithHighestStrenght = hero;
                }
            }

            return heroWithHighestStrenght;
        }

        public Hero GetHeroWithHighestAbility()
        {
            Hero heroWithHighestAbility = null;

            var strenght = 0;

            foreach (var hero in this.data)
            {
                if (hero.Item.Ability > strenght)
                {
                    strenght = hero.Item.Ability;

                    heroWithHighestAbility = hero;
                }
            }

            return heroWithHighestAbility;
        }

        public Hero GetHeroWithHighestIntelligence()
        {
            Hero heroWithHighestItelligence = null;

            var strenght = 0;

            foreach (var hero in this.data)
            {
                if (hero.Item.Intelligence > strenght)
                {
                    strenght = hero.Item.Intelligence;

                    heroWithHighestItelligence = hero;
                }
            }

            return heroWithHighestItelligence;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            foreach (var hero in this.data)
            {
                sb.AppendLine(hero.ToString());
            }

            return sb.ToString();
        }
    }
}
