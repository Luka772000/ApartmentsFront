using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Dtos
{
    public class CreateCardDto
    {
        public string Name { get; set; }
        public int CardNumber { get; set; }
        public int Cvc { get; set; }
        public int Date { get; set; }
        public int UserId { get; set; }
    }
}
