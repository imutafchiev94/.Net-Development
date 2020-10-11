using StorageMaster.Product.Common;
using StorageMaster.Vehicles.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Vehicles
{
    public abstract class Vehicle : IVehicle
    {
        private int capacity;

        private List<IProduct> trunk;

        protected Vehicle(int capacity)
        {
            this.Capacity = capacity;
            this.trunk = new List<IProduct>();
        }


        public int Capacity
        {
            get
            {
                return this.capacity;
            }
            set
            {
                this.capacity = value;
            }
        }

        public IReadOnlyCollection<IProduct> Trunk
        {
            get
            {
                return this.trunk.AsReadOnly();
            }
        }

        public bool IsFull
        {
            get
            {
                double sum = 0;
                foreach (var product in trunk)
                {
                    sum += product.Weight;
                }
                if(sum >= capacity)
                {
                    return true;
                }
                return false;
            }
        }

        public bool IsEmpty
        {
            get
            {
                if(this.trunk.Count == 0)
                {
                    return true;
                }
                return false;
            }
        }

        public void LoadProduct(IProduct product)
        {
            if(this.IsFull)
            {
                throw new InvalidOperationException("Vehicle is full!");
            }
            this.trunk.Add(product);
        }

        public IProduct Unload()
        {
            if(this.IsEmpty)
            {
                throw new InvalidOperationException("No products left in vehicle!");
            }
            var product = this.trunk[this.trunk.Count - 1];

            this.trunk.RemoveAt(this.trunk.Count - 1);

            return product;
        }
    }
}
