using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebSite.Business.Abstract;

namespace PersonalPortfolioWebSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkController : ControllerBase
    {
        private readonly ILinkService _linkService;

        public LinkController(ILinkService linkService)
        {
            _linkService = linkService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetPictureId(int id)
        {
            return Ok(await _linkService.GetLinkID(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllPicture()
        {
            return Ok(await _linkService.GetAllLink());
        }
    }
}
