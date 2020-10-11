using StorageMaster.Product.Common;
using StorageMaster.Vehicles.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Storage.Common
{
    public interface IStorage
    {

        public string Name { get; set; }

        public int Capacity { get; set; }

        public int GarageSlots { get; set; }

        public bool IsFull { get; }

        public IReadOnlyCollection<IVehicle> Garage { get; }

        public IReadOnlyCollection<IProduct> Products { get; }

        IVehicle GetVehicle(int garageSlot);

        int SendVehicleTo(int garageSlot, IStorage deliveryLocation);

        int UnloadVehicle(int garageSlot);

    }
}
