using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Abstract
{
    public interface IAboutRepository
    {
        Task<List<About>> GetPicturePartId(int id);
        Task<List<About>> GetAll();
    }
}
