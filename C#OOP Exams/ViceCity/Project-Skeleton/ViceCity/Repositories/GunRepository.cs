using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private List<IGun> models;

        public GunRepository()
        {
            this.models = new List<IGun>();
        }

        public IReadOnlyCollection<IGun> Models
        {
            get
            {
                return this.models.AsReadOnly();
            }
        }

        public void Add(IGun model)
        {
            var gun = this.models.FirstOrDefault(g => g.Name == model.Name);
            if (gun == null)
            {
                this.models.Add(model);
            }
        }

        public IGun Find(string name)
        {
            var gun = this.models.FirstOrDefault(g => g.Name == name);

            return gun;
        }

        public bool Remove(IGun model)
        {

            var gun = this.models.FirstOrDefault(g => g.Name == model.Name);
            if (gun == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
