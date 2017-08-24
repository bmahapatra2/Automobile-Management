using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileShowroomIVehicleRepo;
using AutomobileShowroom.Entity;

namespace AutomobileShowroom.OnServiceVehicle
{
    public class FourWheeler : IVehicleRepo
    {


        private int _allotment = 0;
        private int _basePrice = 650;
        private int _price = 0;

        List<Vehicle> fourwheeler { get; set; }

        public FourWheeler()
        {
            fourwheeler=new List<Vehicle>();
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
            return _price = price + _basePrice;

        }

        public int VehiclesAlloted()
        {
            return _allotment;
        }
        public void AddVehicle(Vehicle vehicle)
        {
            fourwheeler.Add(vehicle);
        }

        public List<Vehicle> GetWheeler()
        {
            return fourwheeler;
        }
    }
}
