using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KTX.Shared.DTOs;
using BigProject.API.Models;
using BigProject.API.Services;

namespace BigProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaoCaoThongKeController : ControllerBase
    {
        private readonly IBaoCaoThongKeServices _thongKeService;

        public BaoCaoThongKeController(IBaoCaoThongKeServices thongKeService)
        {
            _thongKeService = thongKeService;
        }

        [HttpGet("thong-ke-sinh-vien")]
        public async Task<ActionResult<IEnumerable<ThongKeSinhVienToaDTO>>> GetThongKeSinhVien()
        {
            var result = await _thongKeService.GetThongKeSinhVienAsync();
            return Ok(result);
        }

        [HttpGet("thong-ke-doanh-thu")]
        public async Task<ActionResult<IEnumerable<ThongKeDoanhThuToaDTO>>> GetThongKeDoanhThu([FromQuery] DateTime? tuNgay, [FromQuery] DateTime? denNgay)
        {
            var result = await _thongKeService.GetThongKeDoanhThuAsync(tuNgay, denNgay);
            return Ok(result);
        }
    }
}
