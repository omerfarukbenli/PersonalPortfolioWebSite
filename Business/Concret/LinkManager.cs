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
    public class LinkManager : ILinkService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public LinkManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<LinkDto>> GetAllLink()
        {
            var picture = await _unitOfWork.Link.GetAll();
            var list = _mapper.Map<List<LinkDto>>(picture);
            return list;
        }

        public async Task<List<LinkDto>> GetLinkID(int id)
        {
            var a = await _unitOfWork.Link.GetLinkPartId(id);
            var list = _mapper.Map<List<LinkDto>>(a);
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
