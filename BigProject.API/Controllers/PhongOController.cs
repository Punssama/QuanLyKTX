using KTX.Shared.DTOs;
using BigProject.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhongOController : ControllerBase
    {
        private readonly IPhongOServices _phongOServices;
        public PhongOController(IPhongOServices phongOServices)
        {
            _phongOServices = phongOServices;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhongODTO>>> GetAllPhongOs()
        {
            var phongOs = await _phongOServices.GetAllPhongOsAsync();
            if (phongOs == null)
            {
                return BadRequest("ERROR!, CANT GET YOUR ROOMS");
            }
            else
            {
                return Ok(phongOs);
            }
        }
    }
}
