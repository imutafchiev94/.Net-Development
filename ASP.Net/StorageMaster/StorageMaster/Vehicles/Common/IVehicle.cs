using StorageMaster.Product.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageMaster.Vehicles.Common
{
    public interface IVehicle
    {

        public int Capacity { get; set; }

        public IReadOnlyCollection<IProduct> Trunk { get; }

        public bool IsFull { get; }

        public bool IsEmpty { get; }

        void LoadProduct(IProduct product);

        IProduct Unload();
    }
}
