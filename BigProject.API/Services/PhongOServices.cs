using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BigProject.API.Models;
using KTX.Shared.DTOs;

namespace BigProject.API.Services

{
    public interface IPhongOServices
    {
        Task<IEnumerable<PhongODTO>> GetAllPhongOsAsync();
        Task<PhongODTO?> GetPhongOByIdAsync(string id);
        Task<PhongODTO> CreatePhongOAsync(PhongODTO phongODto);
        Task<PhongODTO?> UpdatePhongOAsync(string id, PhongODTO phongODto);
        Task<bool> DeletePhongOAsync(string id);
    }
    public class PhongOServices: IPhongOServices
    {
        private readonly DBContext _context;
        public PhongOServices(DBContext context) {
            _context = context;
        }

        public async Task<IEnumerable<PhongODTO>> GetAllPhongOsAsync()
        {
            var phongOs = await _context.PhongOs.ToListAsync();

            return phongOs.Select(p => new PhongODTO
            {
                maphong = p.maphong,
                matoa = p.matoa,
                succhua = p.succhua,
                songuoihientai = p.songuoihientai,
                giatien = p.giatien, 
                trangthai = p.trangthai,
                ngaycapnhat = p.ngaycapnhat
            });
        }

        public async Task<PhongODTO?> GetPhongOByIdAsync(string id)
        {
            var p = await _context.PhongOs.FindAsync(id);
            if(p == null) return null;
            return new PhongODTO
            {
                maphong = p.maphong,
                matoa = p.matoa,
                succhua = p.succhua,
                songuoihientai = p.songuoihientai,
                giatien = p.giatien, 
                trangthai = p.trangthai,
                ngaycapnhat = p.ngaycapnhat
            };
        }

        public async Task<PhongODTO> CreatePhongOAsync(PhongODTO pDto)
        {
            var p = new PhongO
            {
                maphong = pDto.maphong,
                matoa = pDto.matoa,
                succhua = pDto.succhua,
                songuoihientai = pDto.songuoihientai,
                giatien = pDto.giatien, 
                trangthai = pDto.trangthai,
                ngaycapnhat = pDto.ngaycapnhat ?? DateTime.Now
            };
            _context.PhongOs.Add(p);
            await _context.SaveChangesAsync();
            return pDto;
        }

        public async Task<PhongODTO?> UpdatePhongOAsync(string id, PhongODTO pDto)
        {
            var p = await _context.PhongOs.FindAsync(id);
            if(p == null) return null;

            p.matoa = pDto.matoa;
            p.succhua = pDto.succhua;
            p.songuoihientai = pDto.songuoihientai;
            p.giatien = pDto.giatien;
            p.trangthai = pDto.trangthai;
            p.ngaycapnhat = pDto.ngaycapnhat ?? p.ngaycapnhat;

            await _context.SaveChangesAsync();
            return pDto;
        }

        public async Task<bool> DeletePhongOAsync(string id)
        {
            var p = await _context.PhongOs.FindAsync(id);
            if(p == null) return false;

            _context.PhongOs.Remove(p);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
