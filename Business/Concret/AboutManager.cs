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
    public class AboutManager : IAboutPartService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public AboutManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<AboutDto>> GetAllPicture()
        {
            var picture = await _unitOfWork.Picture.GetAll();
            var list = _mapper.Map<List<AboutDto>>(picture);
            return list;
        }

        public async Task<List<AboutDto>> GetPictureID(int id)
        {
            var a = await _unitOfWork.Picture.GetPicturePartId(id);
            var list = _mapper.Map<List<AboutDto>>(a);
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
