using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebSite.Business.Abstract;

namespace PersonalPortfolioWebSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomePartService _homeService;

        public HomeController(IHomePartService homeService)
        {
            _homeService = homeService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetExplanationId(int id)
        {
            return Ok(await _homeService.GetExplanationID(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllExplanation()
        {
            return Ok(await _homeService.GetAllExplanation());
        }
    }
}
