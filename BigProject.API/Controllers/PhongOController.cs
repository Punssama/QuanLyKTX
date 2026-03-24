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
            return Ok(phongOs);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PhongODTO>> GetPhongOById(string id)
        {
            var p = await _phongOServices.GetPhongOByIdAsync(id);
            if(p == null) return NotFound();
            return Ok(p);
        }

        [HttpPost]
        public async Task<ActionResult<PhongODTO>> CreatePhongO(PhongODTO dto)
        {
            var created = await _phongOServices.CreatePhongOAsync(dto);
            return CreatedAtAction(nameof(GetPhongOById), new { id = created.maphong }, created);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<PhongODTO>> UpdatePhongO(string id, PhongODTO dto)
        {
            var updated = await _phongOServices.UpdatePhongOAsync(id, dto);
            if(updated == null) return NotFound();
            return Ok(updated);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePhongO(string id)
        {
            var success = await _phongOServices.DeletePhongOAsync(id);
            if(!success) return NotFound();
            return NoContent();
        }
    }
}
