using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BigProject.API.Models;

namespace BigProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly DBContext _context;
        public TaiKhoanController(DBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaiKhoan>>> GetTaiKhoan()
        {
            return await _context.TaiKhoans.ToListAsync();
        }

        [HttpPost("dangnhap")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var taikhoan = await _context.TaiKhoans.FirstOrDefaultAsync(t => t.TenDangNhap == request.TenDangNhap && t.MatKhau == request.MatKhau);

            if (taikhoan == null)
            {
                return Unauthorized();
            }

            return Ok(taikhoan);
        }

    }

    public class LoginRequest
    {
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
    }
}
