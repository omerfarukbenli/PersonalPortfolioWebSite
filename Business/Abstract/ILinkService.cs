using PersonalPortfolioWebSite.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Business.Abstract
{
    public interface ILinkService
    {
        Task<List<LinkDto>> GetLinkID(int id);
        Task<List<LinkDto>> GetAllLink();
    }
}
