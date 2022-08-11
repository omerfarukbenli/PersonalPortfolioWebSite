using PersonalPortfolioWebSite.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Business.Abstract
{
    public interface IContactPartService
    {
        Task<List<ContactDto>> GetContactID(int id);
        Task<List<ContactDto>> GetAllContact();
    }
}
