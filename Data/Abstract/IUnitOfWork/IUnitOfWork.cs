using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Abstract.IUnitOfWork
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IContactRepository Contact { get; }
        IHomeRepository Explanation { get; }
        IAboutRepository Picture { get; }
        IRepoRepository Title { get; }
        ILinkRepository Link { get; }
        Task<int> SaveAsync();
    }
}
