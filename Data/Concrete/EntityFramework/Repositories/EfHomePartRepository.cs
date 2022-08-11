using Microsoft.EntityFrameworkCore;
using PersonalPortfolioWebSite.Data.Abstract;
using PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Context;
using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Repositories
{
    public class EfHomePartRepository : IHomeRepository
    {
        private readonly ApplicationDbContext _context;

        public EfHomePartRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Home>> GetAll()
        {
            var explanation = await _context.Home.ToListAsync();
            return explanation;
        }

        public async Task<List<Home>> GetExplanationPartPartId(int id)
        {
            return await _context.Home.Where(a => a.Id == id).ToListAsync();
        }
    }
}
