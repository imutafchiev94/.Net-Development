using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class Repository
    {

        private Dictionary<int, Person> data;


        public Repository()
        {
            this.data = new Dictionary<int, Person>();
        }

        public int Count
        {
            get
            {
                return this.data.Count;
            }
        }

        public void Add(Person person)
        {
            this.data.Add(this.data.Count, person);
        }

        public Person Get(int id)
        {
            var person = this.data.FirstOrDefault(p => p.Key == id);

            return person.Value;
        }

        public bool Update(int id, Person newPerson)
        {

            if(this.data.ContainsKey(id))
            {
                this.data[id] = newPerson;

                return true;
            }

            return false;
        }

        public bool Delete(int id)
        {
            if(this.data.ContainsKey(id))
            {
                this.data.Remove(id);
                return true;
            }
            return false;
        }
    }
}
