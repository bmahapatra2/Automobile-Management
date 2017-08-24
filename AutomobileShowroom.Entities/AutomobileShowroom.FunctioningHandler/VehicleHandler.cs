using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileShowroom.Entity;
using AutomobileShowroom.OnServiceVehicle;
using AutomobileShowroomIVehicleRepo;

namespace AutomobileShowroom.FunctioningHandler
{
    public class VehicleHandler
    {
        Customer cust = new Customer();
        Vehicle vehicle = new Vehicle();
        IVehicleRepo wheel;
        void CustomerDemand(Customer cust)
        {
            if(cust.VehicleDemand= "twoseat")
            {
                 wheel = new TwoWheeler();
            }
            else if(cust.VehicleDemand = "fourseat")
            {
                wheel = new FourWheeler();
            }
            else
            {
               wheel = new TenWheeler();
            }
        }
        
      

        public void AllotVehicle(IVehicleRepo sitter)
        {
            wheel.GetWheeler(vehicle);
        }

        public void ReturnVehicle(Vehicle vehicle)
        {
           wheel.AddVehicle(vehicle);
        }
    }
}
