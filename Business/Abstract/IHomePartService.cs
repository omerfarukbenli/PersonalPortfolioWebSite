using PersonalPortfolioWebSite.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Business.Abstract
{
    public interface IHomePartService
    {
        Task<List<HomeDto>> GetExplanationID(int id);
        Task<List<HomeDto>> GetAllExplanation();
    }
}
