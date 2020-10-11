using StorageMaster.Product.Common;
using StorageMaster.Storage.Common;
using StorageMaster.Vehicles.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorageMaster.Storage
{
    public abstract class Storage : IStorage
    {

        private string name;

        private int capacity;

        private int garageSlots;

        private IVehicle[] garage => new IVehicle[this.garageSlots];

        private List<IProduct> products;

        protected Storage(string name, int capacity, int garageSlots, IEnumerable<IVehicle> vehicles)
        {
            this.Name = name;

            this.Capacity = capacity;

            this.GarageSlots = garageSlots;

            for (int i = 0; i < vehicles.ToArray().Length; i++)
            {
                garage[i] = vehicles.ToArray()[i];
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
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
        public int GarageSlots 
        {
            get
            {
                return this.garageSlots;
            }
            set
            {
                this.garageSlots = value;
            }
        }

        public bool IsFull
        {
            get
            {
                double sum = 0;
                foreach (var product in products)
                {
                    sum += product.Weight;
                }

                if (sum >= this.capacity)
                {
                    return true;
                }
                return false;
            }
        }

        public IReadOnlyCollection<IVehicle> Garage
        {
            get
            {
                return this.garage.ToList().AsReadOnly();
            }
        }

        public IReadOnlyCollection<IProduct> Products
        {
            get
            {
                return this.products.AsReadOnly();
            }
        }

        public IVehicle GetVehicle(int garageSlot)
        {
            if(garageSlot >= this.garageSlots)
            {
                throw new InvalidOperationException("Invalid garage slot!");
            }
            if(this.garage.ToList().Count == 0)
            {
                throw new InvalidOperationException("No vehicle in this garage slot!");
            }

            return this.garage[garageSlot];
        }

        public int SendVehicleTo(int garageSlot, IStorage deliveryLocation)
        {
            throw new NotImplementedException();
        }

        public int UnloadVehicle(int garageSlot)
        {
            throw new NotImplementedException();
        }
    }
}
