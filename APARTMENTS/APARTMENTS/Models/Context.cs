using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APARTMENTS.Models;

namespace APARTMENTS.Models
{
    public class Context : 
        IdentityDbContext<User, AppRole, int, IdentityUserClaim<int>, AppUserRole, 
        IdentityUserLogin<int>,IdentityRoleClaim<int>,IdentityUserToken<int>>
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           
            
            modelBuilder.Entity<User>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.User)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
                
            modelBuilder.Entity<AppRole>()
                .HasMany(ur => ur.UserRoles)
                .WithOne(u => u.Role)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();
            modelBuilder.Entity<Contract>()
                .HasKey(k => new { k.ApartmentId, k.UserId });
            modelBuilder.Entity<Contract>()
                .HasOne(a => a.User)
                .WithMany(c => c.contracts)
                .HasForeignKey(ai => ai.UserId)
                .OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<Contract>()
                .HasOne(a => a.Apartment)
                .WithMany(c => c.contracts)
                .HasForeignKey(ai => ai.ApartmentId)
                .OnDelete(DeleteBehavior.Cascade);
            


        }
        
        public DbSet<Card> Cards { get; set; }
        public DbSet<Contract> Contracts { get; set; }
        public DbSet<Apartment> Apartments { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        

    }
        
    }
