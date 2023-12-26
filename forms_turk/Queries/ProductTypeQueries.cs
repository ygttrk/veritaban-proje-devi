using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class ProductTypeQueries
    {
        private readonly AppDbContext _context;

        public ProductTypeQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddUrunTuru(string urunTuruAdi)
        {
            var newUrunTuru = new UrunTuru { UrunTuruAdi = urunTuruAdi };

            _context.UrunTuru.Add(newUrunTuru);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUrunTuru(int urunTuruId)
        {
            var urunTuruToDelete = await _context.UrunTuru.FindAsync(urunTuruId);

            if (urunTuruToDelete != null)
            {
                _context.UrunTuru.Remove(urunTuruToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<UrunTuru> GetUrunTuruById(int urunTuruId)
        {
            var urunTuru = await _context.UrunTuru.FindAsync(urunTuruId);
            return urunTuru;
        }

        public async Task<List<UrunTuru>> GetUrunTuruByName(string urunTuruAdi)
        {
            var urunTurleri = await _context.UrunTuru
                .Where(ut => ut.UrunTuruAdi.ToLower() == urunTuruAdi.ToLower())
                .ToListAsync();

            return urunTurleri;
        }

        public List<UrunTuru> GetAllUrunTurleri()
        {
            var urunTurleri = _context.UrunTuru.ToList();
            return urunTurleri;
        }
    }
}

