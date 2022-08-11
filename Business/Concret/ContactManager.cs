using AutoMapper;
using PersonalPortfolioWebSite.Business.Abstract;
using PersonalPortfolioWebSite.Data.Abstract.IUnitOfWork;
using PersonalPortfolioWebSite.Entities.Concrete.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Business.Concret
{
    public class ContactManager : IContactPartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ContactManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ContactDto>> GetAllContact()
        {

            var contacts = await _unitOfWork.Contact.GetAll();
            var list = _mapper.Map<List<ContactDto>>(contacts);
            return list;
        }

        public async Task<List<ContactDto>> GetContactID(int id)
        {
            var a = await _unitOfWork.Contact.GetContactPartId(id);
            var list = _mapper.Map<List<ContactDto>>(a);
            if (a.Count > 0)
            {
                return list;
            }
            else
            {
                return null;
            }
        }
    }
}
