using GymSpotterAPI.Application.Repositories;
using GymSpotterAPI.Domain.Entities.Common;
using GymSpotterAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GymSpotterAPI.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly GymSpotterAPIDbContext _context;

        public ReadRepository(GymSpotterAPIDbContext context)
        {
            _context = context;
        }

        public DbSet<T> Table => throw new NotImplementedException();

        public IQueryable<T> GetAll()
            => Table;

        public async Task<T> GetByIdAsync(string id)
            => await Table.FirstOrDefaultAsync(data=>data.Id==Guid.Parse(id));



        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method)
            => await Table.FirstOrDefaultAsync(method);
        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
            =>Table.Where(method);
        
    }
}
