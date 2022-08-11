using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Abstract
{
    public interface IRepoRepository
    {
        Task<List<Repo>> GetTitlePartId(int id);
        Task<List<Repo>> GetAll();
    }
}
