using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APARTMENTS.Models;
using Microsoft.AspNetCore.Authorization;
using APARTMENTS.Interfaces;
using APARTMENTS.Dtos;
using AutoMapper;

namespace APARTMENTS.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class AdressController : ControllerBase
    {
        private readonly IAdressRepository _adressRepository;
        private readonly IMapper _mapper;
        private readonly Context _context;

        public AdressController(IAdressRepository adressRepository, IMapper mapper, Context context)
        {
            _adressRepository = adressRepository;
            _mapper = mapper;
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Adress>>> GetAdresses()
        {
            return await _context.Adresses.Include(ad => ad.Apartment).ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Adress>>> GetAdress(int id)
        {
            var adress = await _context.Adresses.Where(ad => ad.Id == id).Include(ap => ap.Apartment).ToListAsync();

            if (adress == null)
            {
                return NotFound();
            }

            return adress;
        }
        [HttpPost]
        public async Task<ActionResult<ICollection<Adress>>> CreateNewAdress(CreateAdressDto adress)
        {
            var newAdress = new Adress
            {

                StreetName = adress.StreetName,
                BuildingNumber = adress.BuildingNumber,
                ApartmentNumber = adress.ApartmentNumber
            };

            _context.Adresses.Add(newAdress);
            await _context.SaveChangesAsync();

            return Ok();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAdress(int id)
        {
            var adress = await _context.Adresses.FindAsync(id);
            if (adress == null)
            {
                return NotFound();
            }

            _context.Adresses.Remove(adress);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
