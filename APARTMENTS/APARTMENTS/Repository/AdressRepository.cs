using APARTMENTS.Dtos;
using APARTMENTS.Interfaces;
using APARTMENTS.Models;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APARTMENTS.Repository
{
    public class AdressRepository : IAdressRepository
    {
        private readonly Context _context;
        private readonly IMapper _mapper;
        public AdressRepository(Context context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Adress>> GetAdressAsync()
        {
            return await _context.Adresses
                .Include(c => c.Apartment)
                .ToListAsync();
        }

        public async Task<Adress> GetAdressByIdAsync(int id)
        {
            return await _context.Adresses.FindAsync(id);
        }

       

        public async Task<bool> SaveAllAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void Update(Adress adress)
        {
            _context.Entry(adress).State = EntityState.Modified;
        }
        public void Create(Adress adress)
        {
            _context.Adresses.Add(adress);
        }

        public async Task<IEnumerable<AdressCreateDto>> GetAdressesAsync()
        {
            return await _context.Adresses.
                ProjectTo<AdressCreateDto>(_mapper.ConfigurationProvider)
                .ToListAsync();



        }

        public async Task<AdressCreateDto> GetAdresssAsync(int id)
        {
            return await _context.Adresses
                .Where(x => x.Id == id)
                .ProjectTo<AdressCreateDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
        }

        
    }
}

