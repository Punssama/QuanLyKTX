using KTX.Shared.DTOs;
using BigProject.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BigProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HopDongController : ControllerBase
    {
        private readonly IHopDongServices _hopDongServices;

        public HopDongController(IHopDongServices hopDongServices)
        {
            _hopDongServices = hopDongServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HopDongDTO>>> GetAllHopDongs()
        {
            var hopDongs = await _hopDongServices.GetAllHopDongsAsync();
            if (hopDongs == null)
            {
                return BadRequest("ERROR!, CANT GET HOP DONGS");
            }
            return Ok(hopDongs);
        }
    }
}