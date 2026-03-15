using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BigProject.API.Models;
using BigProject.API.Services;
using BigProject.API.DTOs;

namespace BigProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaiKhoanController : ControllerBase
    {
        private readonly ITaiKhoanServices _taiKhoanServices;

        public TaiKhoanController(ITaiKhoanServices taiKhoanServices)
        {
            _taiKhoanServices = taiKhoanServices;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaiKhoan>>> GetTaiKhoan()
        {
            var taiKhoans = await _taiKhoanServices.GetTaiKhoansAsync();
            return Ok(taiKhoans);
        }

        [HttpPost("dangnhap")]
        public async Task<IActionResult> Login([FromBody] LoginRequestDto request)
        {
            var taikhoan = await _taiKhoanServices.LoginAsync(request.TenDangNhap, request.MatKhau);

            if (taikhoan == null)
            {
                return Unauthorized();
            }

            return Ok(taikhoan);
        }

        [HttpPost("themtaikhoan")]
        public async Task<IActionResult> CreateAccount([FromBody] CreatedAccountDto request)
        {
            var taikhoan = await _taiKhoanServices.CreateAccountAsync(request);
            return Ok(taikhoan);
        }

        [HttpDelete("xoataikhoan/{id}")]
        public async Task<IActionResult> DeleteAccount([FromRoute] int id)
        {
            var taikhoan = await _taiKhoanServices.DeleteAccountAsync(id);
            if (taikhoan == null)
            {
                return NotFound("Account not found.");
            }

            return Ok("Deleted successfully!!!!!");
        }
    }
}
