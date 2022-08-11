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
    public class EfAboutRepository : IAboutRepository
    {
        private readonly ApplicationDbContext _context;

        public EfAboutRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<About>> GetAll()
        {
            var contact = await _context.About.ToListAsync();
            return contact;
        }

        public async Task<List<About>> GetPicturePartId(int id)
        {
            return await _context.About.Where(a => a.Id == id).ToListAsync();
        }
    }
}
