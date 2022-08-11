using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Abstract
{
    public interface IHomeRepository
    {
        Task<List<Home>> GetExplanationPartPartId(int id);
        Task<List<Home>> GetAll();
    }
}
