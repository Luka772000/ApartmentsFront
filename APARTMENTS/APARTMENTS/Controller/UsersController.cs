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
    
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly Context _context;

        public UsersController(IUserRepository userRepository, IMapper mapper, Context context)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _context = context;
        }

        // GET: api/Users
        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MemberDto>>> GetUsers()
        {
            var users = await _context.Users.Include(c => c.Card).Include(co => co.contracts).ThenInclude(ap => ap.Apartment).ToListAsync();
            
            return Ok(users);
        }

        // GET: api/Users/5
        [Authorize(Roles = "Member")]
        [HttpGet("{id}")]
        public async Task<ActionResult<List<User>>> GetUser(int id)
        {
            var user = await _context.Users.Where(u => u.Id == id).Include(c => c.Card).ToListAsync();

            if (user == null)
            {
                return NotFound();
            }

            return user;
        }
        [HttpPost("apartment")]
        public async Task<ActionResult<User>> AddContract(AddContract contract)
        {
            var apartment = await _context.Apartments.FindAsync(contract.ApartmentId);
            if (apartment == null)
                return NotFound();
            var user = await _context.Users.FindAsync(contract.UserId);
            if (user == null)
                return NotFound();
            var newContract = new Contract
            {
                UserId = user.Id,
                User = user,
                ApartmentId = apartment.Id,
                Apartment = apartment
                
            };
            _context.Contracts.Add(newContract);
            await _context.SaveChangesAsync();
            return Ok();
        }



    }
}
