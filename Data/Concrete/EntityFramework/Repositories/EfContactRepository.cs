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
    public class EfContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _context;

        public EfContactRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Contact>> GetAll()
        {
            var contact = await _context.Contact.ToListAsync();
            return contact;
        }

        public async Task<List<Contact>> GetContactPartId(int id)
        {
            return await _context.Contact.Where(a => a.Id == id).ToListAsync();
        }
    }
}
