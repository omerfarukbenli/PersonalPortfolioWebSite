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
    public class RepoManager : IRepoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RepoManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<RepoDto>> GetAllTitle()
        {
            var titles = await _unitOfWork.Title.GetAll();
            var list = _mapper.Map<List<RepoDto>>(titles);
            return list;
        }

        public async Task<List<RepoDto>> GetTitletID(int id)
        {
            var a = await _unitOfWork.Title.GetTitlePartId(id);
            var list = _mapper.Map<List<RepoDto>>(a);
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
