using APARTMENTS.Dtos;
using APARTMENTS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Interfaces
{
    public interface IAdressRepository
    {
        void Update(Adress adress);
        void Create(Adress adress);

        Task<bool> SaveAllAsync();
        Task<IEnumerable<Adress>> GetAdressAsync();
        Task<Adress> GetAdressByIdAsync(int id);
        Task<IEnumerable<AdressCreateDto>> GetAdressesAsync();
        Task<AdressCreateDto> GetAdresssAsync(int id);
    }
}
