using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string StreetName { get; set; }
        public int BuildingNumber { get; set; }
        public int ApartmentNumber { get; set; }

        
        public Apartment Apartment { get; set; }
    }
}
