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
        Task<TaiKhoan> LoginAsync(string tenDangNhap, string matKhau);
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
            return await _context.TaiKhoans.ToListAsync();
        }

        public async Task<TaiKhoan> LoginAsync(string tenDangNhap, string matKhau)
        {
            return await _context.TaiKhoans.FirstOrDefaultAsync(t => t.TenDangNhap == tenDangNhap && t.MatKhau == matKhau);
        }

        public async Task<TaiKhoan> DeleteAccountAsync(int id)
        {
            var taiKhoan = await _context.TaiKhoans.FindAsync(id);
            if (taiKhoan != null)
            {
                _context.TaiKhoans.Remove(taiKhoan);
                await _context.SaveChangesAsync();
            }
            return taiKhoan;
        }

        public async Task<TaiKhoan> CreateAccountAsync(CreatedAccountDto accountDto)
        {
            var taiKhoan = new TaiKhoan
            {
                TenDangNhap = accountDto.TenDangNhap,
                MatKhau = accountDto.MatKhau
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

