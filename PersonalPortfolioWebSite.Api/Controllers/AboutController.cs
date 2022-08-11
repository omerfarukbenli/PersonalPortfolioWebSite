using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebSite.Business.Abstract;

namespace PersonalPortfolioWebSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutPartService _aboutService;

        public AboutController(IAboutPartService aboutService)
        {
            _aboutService = aboutService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPictureId(int id)
        {
            return Ok(await _aboutService.GetPictureID(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllPicture()
        {
            return Ok(await _aboutService.GetAllPicture());
        }
    }
}
