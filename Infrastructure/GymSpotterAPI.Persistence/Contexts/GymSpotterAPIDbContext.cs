using GymSpotterAPI.Domain.Entities;
using GymSpotterAPI.Domain.Entities.Identity;
using GymSpotterAPI.Persistence.Contexts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymSpotterAPI.Persistence.Contexts
{
    public class GymSpotterAPIDbContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public GymSpotterAPIDbContext(DbContextOptions options) : base(options)
        {



        }

        public DbSet<Product> Products {  get; set; }

    
    }
}
