using Microsoft.EntityFrameworkCore;
using KTX.Shared.DTOs;

namespace BigProject.API.Services
{
    public interface IBaoCaoThongKeServices
    {
        Task<IEnumerable<ThongKeSinhVienToaDTO>> GetThongKeSinhVienAsync();
        Task<IEnumerable<ThongKeDoanhThuToaDTO>> GetThongKeDoanhThuAsync(DateTime? tuNgay = null, DateTime? denNgay = null);
    }

    public class BaoCaoThongKeServices : IBaoCaoThongKeServices
    {
        private readonly DBContext _context;

        public BaoCaoThongKeServices(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ThongKeSinhVienToaDTO>> GetThongKeSinhVienAsync()
        {
            return await _context.PhongOs
                .GroupBy(p => p.matoa)
                .Select(g => new ThongKeSinhVienToaDTO
                {
                    MaToa = g.Key,
                    TongSoSinhVien = g.Sum(p => p.songuoihientai)
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ThongKeDoanhThuToaDTO>> GetThongKeDoanhThuAsync(DateTime? tuNgay = null, DateTime? denNgay = null)
        {
            var query = _context.PhongOs.AsQueryable();

            if (tuNgay.HasValue)
            {
                query = query.Where(p => p.ngaycapnhat >= tuNgay.Value);
            }
            if (denNgay.HasValue)
            {
                query = query.Where(p => p.ngaycapnhat <= denNgay.Value);
            }

            return await query
                .GroupBy(p => p.matoa)
                .Select(g => new ThongKeDoanhThuToaDTO
                {
                    MaToa = g.Key,
                    TongDoanhThu = g.Sum(p => p.giatien * p.songuoihientai)
                })
                .ToListAsync();
        }
    }
}
