using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Abstract
{
    public interface ILinkRepository
    {
        Task<List<Link>> GetLinkPartId(int id);
        Task<List<Link>> GetAll();
    }
}
