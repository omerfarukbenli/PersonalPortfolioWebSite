using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Data.Abstract
{
    public interface IContactRepository
    {
        Task<List<Contact>> GetContactPartId(int id);
        Task<List<Contact>> GetAll();
    }
}
