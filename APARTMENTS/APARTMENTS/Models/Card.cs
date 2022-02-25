using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Models
{
    public class Card
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CardNumber {get;set;}
        public int Cvc { get; set; }
        public int Date { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
