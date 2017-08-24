using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileShowroom.Entity
{
    public class Customer
    {
        public string CustomerName{ get; set; }

        public string CustomerId { get; set; }

        public string TokenNo { get; set; }

        public string PhoneNo { get; set; }

        public Sitter VehicleDemand { get; set; }
    }
}
