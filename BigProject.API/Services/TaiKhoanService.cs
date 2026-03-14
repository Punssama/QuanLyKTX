using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BigProject.API.Models;
using BigProject.API.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
namespace BigProject.API.Services
{
    public interface ITaiKhoanService
    {
        Task<IEnumerable<TaiKhoan>> GetTaiKhoansAsync();
        Task<TaiKhoan> LoginAsync(string tenDangNhap, string matKhau);
        Task<bool> AddTaiKhoanAsync(createdAccountDto accountDto);
        Task<bool> DeleteTaiKhoan(int id);
    }

    public class TaiKhoanService : ITaiKhoanService
    {
        private readonly DBContext _context;
        public TaiKhoanService(DBContext context)
        {
            _context = context;
        }

        public async Task<bool> AddTaiKhoanAsync(createdAccountDto accountDto)
        {

            bool exists = await _context.TaiKhoans.AnyAsync(a => a.TenDangNhap == accountDto.TenDangNhap);
            if (exists)
            {
                return false;
            }

            var taikhoan = new TaiKhoan
            {
                Id = accountDto.ID,
                TenDangNhap = accountDto.TenDangNhap,
                MatKhau = accountDto.MatKhau
            };
            _context.TaiKhoans.Add(taikhoan);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<TaiKhoan>> GetTaiKhoansAsync()
        {
            var taikhoans = await _context.TaiKhoans.ToListAsync();
            return taikhoans;
        }

        public async Task<TaiKhoan> LoginAsync(string tenDangNhap, string matKhau)
        {
            var taikhoan = await _context.TaiKhoans.FirstOrDefaultAsync(t => t.TenDangNhap == tenDangNhap && t.MatKhau == matKhau);
            if (taikhoan == null)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
            else
            {
                return taikhoan;
            }
        }

        public async Task<bool> DeleteTaiKhoan(int id)
        {
            var taikhoan = await _context.TaiKhoans.FirstOrDefaultAsync(t => t.Id == id);
            if (taikhoan == null)
            {
                return false;
            }
            _context.TaiKhoans.Remove(taikhoan);
            await _context.SaveChangesAsync();
            return true;
        }

    }
}
