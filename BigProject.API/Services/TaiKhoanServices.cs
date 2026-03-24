using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BigProject.API.Models;
using BigProject.API.DTOs;

namespace BigProject.API.Services
{
    public interface ITaiKhoanServices
    {
        Task<IEnumerable<TaiKhoan>> GetTaiKhoansAsync();
        Task<LoginResponseDto?> LoginAsync(string tenDangNhap, string matKhau);
        Task<TaiKhoan> DeleteAccountAsync(int id);
        Task<TaiKhoan> CreateAccountAsync(CreatedAccountDto accountDto);
    }

    public class TaiKhoanServices : ITaiKhoanServices
    {
        private readonly DBContext _context;

        public TaiKhoanServices(DBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TaiKhoan>> GetTaiKhoansAsync()
        {
            return await _context.TaiKhoans.Where(t => t.TrangThai == true).ToListAsync();
        }

        public async Task<LoginResponseDto?> LoginAsync(string tenDangNhap, string matKhau)
        {
            var user = await _context.TaiKhoans
                .AsNoTracking()
                .Where(t => t.TenDangNhap == tenDangNhap && t.MatKhau == matKhau)
                .Select(t => new { t.TenDangNhap, t.QuyenHan })
                .FirstOrDefaultAsync();

            if (user == null)
            {
                return null;
            }
            return new LoginResponseDto
            {
                TenDangNhap = user.TenDangNhap,
                QuyenHan = user.QuyenHan
            };
        }

        public async Task<TaiKhoan> DeleteAccountAsync(int id)
        {
            var taiKhoan = await _context.TaiKhoans.FindAsync(id);
            if (taiKhoan != null)
            {
                taiKhoan.TrangThai = false;
                await _context.SaveChangesAsync();
            }
            return taiKhoan;
        }

        public async Task<TaiKhoan> CreateAccountAsync(CreatedAccountDto accountDto)
        {
            var taiKhoan = new TaiKhoan
            {
                TenDangNhap = accountDto.TenDangNhap,
                MatKhau = accountDto.MatKhau,
                QuyenHan = accountDto.QuyenHan,
                MaNV = accountDto.MaNV,
                TrangThai = accountDto.TrangThai
            };
            if (accountDto.Id > 0)
            {
                taiKhoan.Id = accountDto.Id;
            }

            _context.TaiKhoans.Add(taiKhoan);
            await _context.SaveChangesAsync();
            return taiKhoan;
        }
    }
}

