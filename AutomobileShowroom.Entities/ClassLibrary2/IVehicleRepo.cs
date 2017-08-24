using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileShowroom.Entity;

namespace AutomobileShowroomIVehicleRepo

{
    public interface IVehicleRepo

    {
        int Price();
        int NoOfAllotments();
        int TotalRevenue(int price);
        void AddVehicle(Vehicle vehicle);
        List<Vehicle> GetWheeler(Vehicle vehcile);
        int VehiclesAlloted();
    }
}
