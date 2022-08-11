using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PersonalPortfolioWebSite.Business.Abstract;

namespace PersonalPortfolioWebSite.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactPartService _contactService;

        public ContactController(IContactPartService contactService)
        {
            _contactService = contactService;
        }
        [HttpGet("{id}")]
        public async Task<ActionResult> GetContactId(int id)
        {
            return Ok(await _contactService.GetContactID(id));
        }
        [HttpGet("GetAll")]
        public async Task<ActionResult> GetAllContent()
        {
            return Ok(await _contactService.GetAllContact());
        }
    }
}
