using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebSite.Business.Abstract;

namespace PersonalPortfolioWebSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RepoController : ControllerBase
    {
        private readonly IRepoService _repoService;

        public RepoController(IRepoService repoService)
        {
            _repoService = repoService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetTitleId(int id)
        {
            return Ok(await _repoService.GetTitletID(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllTitle()
        {
            return Ok(await _repoService.GetAllTitle());
        }
    }
}
