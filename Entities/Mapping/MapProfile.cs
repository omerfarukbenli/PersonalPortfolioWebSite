using AutoMapper;
using PersonalPortfolioWebSite.Entities.Concrete.Dto;
using PersonalPortfolioWebSite.Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalPortfolioWebSite.Entities.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Contact, ContactDto>();
            CreateMap<Home, HomeDto>();
            CreateMap<Repo, RepoDto>();
            CreateMap<About, AboutDto>();
            CreateMap<Link, LinkDto>();

        }
    }
}
