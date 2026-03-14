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

        private readonly ITaiKhoanService _taikhoanService;
        public TaiKhoanController(ITaiKhoanService taikhoanService)
        {
            _taikhoanService = taikhoanService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TaiKhoan>>> GetTaiKhoan()
        {
            var taikhoans = await _taikhoanService.GetTaiKhoansAsync();
            return Ok(taikhoans);
        }

        [HttpPost("dangnhap")]
        public async Task<IActionResult> Login([FromBody] LoginRequest request)
        {
            var taikhoan = await _taikhoanService.LoginAsync(request.TenDangNhap, request.MatKhau);

            if (taikhoan == null)
            {
                return Unauthorized();
            }
            var outputTaikhoan = new
            {
                taikhoan.Id,
                taikhoan.TenDangNhap,
            };

            return Ok(outputTaikhoan);
        }
        [HttpPost("themtaikhoan")]
        public async Task<IActionResult> AddTaiKhoan([FromBody] createdAccountDto accountDto)
        {
            var taikhoanmoi = await _taikhoanService.AddTaiKhoanAsync(accountDto);
            if (taikhoanmoi)
            {
                return Ok("Tạo tài khoản thành công!");
            }
            else
            {
                return BadRequest("Tạo tài khoản thất bại, tên người dùng đã tồn tại");
            }
        }
        [HttpDelete("xoataikhoan/{id}")]
        public async Task<IActionResult> DeleteTaiKhoan(int id)
        {
            var taikhoan = await _taikhoanService.DeleteTaiKhoan(id);
            if (taikhoan)
            {
                return Ok("Xoa tai khoan thanh cong!");
            }
            else
            {
                return BadRequest("Xoa tai khoan that bai!");
            }

        }


        public class LoginRequest
        {
            public string TenDangNhap { get; set; } = string.Empty;
            public string MatKhau { get; set; } = string.Empty;
        }
    }
}
