using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class ShoppingQueries
    {
        private readonly AppDbContext _context;

        public ShoppingQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddShopping(int urunId, int personelId, int urunAdeti, bool isAlis, decimal toplamTutar, DateTime islemTarihi)
        {
            var newShopping = new AlisVeris
            {
                UrunId = urunId,
                PersonelId = personelId,
                UrunAdeti = urunAdeti,
                IsAlis = isAlis,
                ToplamTutar = toplamTutar,
                IslemTarihi = islemTarihi
            };

            _context.AlisVeris.Add(newShopping);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteShopping(int alisVerisId)
        {
            var ShoppingToDelete = await _context.AlisVeris.FindAsync(alisVerisId);

            if (ShoppingToDelete != null)
            {
                _context.AlisVeris.Remove(ShoppingToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<AlisVeris> GetShoppingById(int alisVerisId)
        {
            var Shopping = await _context.AlisVeris
                .Include(av => av.Uruns)  // Uruns nesnesini dahil et
                .Include(av => av.Musteri)  // Musteri nesnesini dahil et
                .Include(av => av.Personel)  // Personel nesnesini dahil et
                .FirstOrDefaultAsync(av => av.Id == alisVerisId);

            return Shopping;
        }

        public async Task<List<AlisVeris>> GetShoppingByUrunId(int urunId)
        {
            var ShoppingList = await _context.AlisVeris
                .Where(av => av.UrunId == urunId)
                .ToListAsync();

            return ShoppingList;
        }

        public List<AlisVeris> GetAllShopping()
        {
            var ShoppingList = _context.AlisVeris.ToList();
            return ShoppingList;
        }
    }
}

