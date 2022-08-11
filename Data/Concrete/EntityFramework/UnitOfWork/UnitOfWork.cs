using PersonalPortfolioWebSite.Data.Abstract;
using PersonalPortfolioWebSite.Data.Abstract.IUnitOfWork;
using PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Context;
using PersonalPortfolioWebSite.Data.Concrete.EntityFramework.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Concrete.EntityFramework.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private EfContactRepository _contactRepository;
        private EfHomePartRepository _explanationRepository;
        private EfAboutRepository _pictureRepository;
        private EfRepoRepository _titleRepository;
        private EfLinkRepository _linkRepository;

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }

        public IContactRepository Contact => _contactRepository ?? new EfContactRepository(_context);

        public IHomeRepository Explanation => _explanationRepository ?? new EfHomePartRepository(_context);

        public IAboutRepository Picture => _pictureRepository ?? new EfAboutRepository(_context);

        public IRepoRepository Title => _titleRepository ?? new EfRepoRepository(_context);
        public ILinkRepository Link => _linkRepository ?? new EfLinkRepository(_context);

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
