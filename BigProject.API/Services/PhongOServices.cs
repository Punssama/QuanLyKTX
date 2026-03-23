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
        //Task<PhongO> GetPhongOByIdAsync(int id);
        //Task<PhongO> CreatePhongOAsync(PhongODTO);
        //Task<PhongO> UpdatePhongOAsync(int id, PhongODTO phongODto);
        //eTask<bool> DeletePhongOAsync(int id);
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
                trangthai = p.trangthai
            });
        }
    }
}
