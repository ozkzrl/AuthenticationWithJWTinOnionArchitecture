using GymSpotterAPI.Domain.Entities;
using GymSpotterAPI.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GymSpotterAPI.Persistence.Contexts;

namespace GymSpotterAPI.Persistence.Repositories
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(GymSpotterAPIDbContext context) : base(context)
        {
        }
    }
}
