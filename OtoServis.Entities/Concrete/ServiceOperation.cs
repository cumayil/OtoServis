using System;
using System.Collections.Generic;
using System.Text;
using OtoServis.Entities.Abstract;

namespace OtoServis.Entities.Concrete
{
    public class ServiceOperation:IEntity
    {
        public int Id { get; set; }
        public string LicensePlate { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int KM { get; set; }
        public DateTime DateOfArrival { get; set; }
        public string ChassisLubrication { get; set; }
        public string AddingAntifreeze { get; set; }
        public string OilChange { get; set; }

        public string TireWheelAlignment { get; set; }
        public string AirFilterReplacement { get; set; }
        public string CoolingSystemCleaning { get; set; }
        public string OilFilterReplacement { get; set; }
        public string BalanceAdjustment { get; set; }
        public string OtherOperations { get; set; }

    }
}
