using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Models
{
    public class Apartment
    {
        public int Id { get; set; }
        public string ApartmentDescription { get; set; }
        public int NumberOfRooms { get; set; }
        public int MonthlyPrice { get; set; }
        public int AdressId { get; set; }
        public Adress Adress { get; set; }
        public ICollection<Contract> contracts { get; set; }

    }
}
