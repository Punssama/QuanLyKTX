using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BigProject.API.Models;
using KTX.Shared.DTOs;

namespace BigProject.API.Services
{
    public interface IHopDongServices
    {
        Task<IEnumerable<HopDongDTO>> GetAllHopDongsAsync();
    }

    public class HopDongServices : IHopDongServices
    {
        private readonly DBContext _context;
        public HopDongServices(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HopDongDTO>> GetAllHopDongsAsync()
        {
            var hopDongs = await _context.HopDongs.ToListAsync();
            return hopDongs.Select(h => new HopDongDTO
            {
                MaHopDong = h.MaHopDong,
                MaSV = h.MaSV,
                TenSV = h.TenSV,
                NgayKy = h.NgayKy,
                SoPhong = h.SoPhong,
                TinhTrang = h.TinhTrang
            });
        }
    }
}