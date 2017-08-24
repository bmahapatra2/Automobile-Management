using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutomobileShowroom.Entity;
using AutomobileShowroom.OnServiceVehicle;

namespace AutomobileShowroom.FunctioningHandler
{
    public class ShowRoomManager
    {
        Vehicle vehicle = new Vehicle();

        List<Vehicle> vehicledata { get; set; }

        public ShowRoomManager()
        {
            vehicledata= new List<Vehicle>();
        }


    }
}
