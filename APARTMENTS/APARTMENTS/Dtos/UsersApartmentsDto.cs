using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Dtos
{
    public class UsersApartmentsDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int UserRole { get; set; }
        public int PhoneNumber { get; set; }
        public ICollection<GetApartmentDto> apartment { get; set; }
    }
}
