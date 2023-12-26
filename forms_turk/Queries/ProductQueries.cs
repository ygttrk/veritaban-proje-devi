using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class ProductQueries
    {
        private readonly AppDbContext _context;

        public ProductQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddProduct(string marka, string model, string urunKodu, decimal fiyat, int stokBilgisi, int urunTuruId)
        {
            var newProduct = new Urun
            {
                UrunMarka = marka,
                UrunModel = model,
                UrunKodu = urunKodu,
                Fiyat = fiyat,
                StokBilgisi = stokBilgisi,
                UrunTuruId = urunTuruId
            };

            _context.Urun.Add(newProduct);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProduct(int productId)
        {
            var productToDelete = await _context.Urun.FindAsync(productId);

            if (productToDelete != null)
            {
                _context.Urun.Remove(productToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Urun> GetProductById(int productId)
        {
            var product = await _context.Urun
                .Include(p => p.UrunTuru)  // UrunTuru nesnesini dahil et
                .FirstOrDefaultAsync(p => p.Id == productId);

            return product;
        }

        public async Task<List<Urun>> GetProductByMarka(string marka)
        {
            var products = await _context.Urun
                .Where(p => p.UrunMarka.ToLower() == marka.ToLower())
                .ToListAsync();

            return products;
        }

        public List<Urun> GetAllProducts()
        {
            var products = _context.Urun.ToList();
            return products;
        }
    }
}
