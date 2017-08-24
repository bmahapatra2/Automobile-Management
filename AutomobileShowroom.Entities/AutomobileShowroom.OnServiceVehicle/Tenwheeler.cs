using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileShowroomIVehicleRepo;
using AutomobileShowroom.Entity;

namespace AutomobileShowroom.OnServiceVehicle
{
    public class TenWheeler : IVehicleRepo
    {
        private int _allotment = 0;
        private int _basePrice = 1050;
        private int _price = 0;

        List<Vehicle> tenwheeler { get; set; }

        public TenWheeler()
        {
            tenwheeler=new List<Vehicle>();
        }
        public int NoOfAllotments()
        {
            _allotment++;
            return _allotment;
        }

        public int Price()
        {
            
            return _basePrice;
        }

        public int TotalRevenue(int price)

        {
            return  _price = price+_basePrice;

        }

        public int VehiclesAlloted()
        {
            return _allotment;
        }

        public void AddVehicle(Vehicle vehicle)
        {
            tenwheeler.Add(vehicle);
        }

        public List<Vehicle> GetWheeler()
        {
            return tenwheeler;
        }
    }
}
