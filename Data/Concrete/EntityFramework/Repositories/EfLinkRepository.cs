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
    public class EfLinkRepository : ILinkRepository
    {
        private readonly ApplicationDbContext _context;

        public EfLinkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Link>> GetAll()
        {
            var contact = await _context.Link.ToListAsync();
            return contact;
        }

        public async Task<List<Link>> GetLinkPartId(int id)
        {
            return await _context.Link.Where(a => a.Id == id).ToListAsync();
        }
    }
}
