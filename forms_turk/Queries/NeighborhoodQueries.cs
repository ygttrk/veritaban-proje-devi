using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class NeighborhoodQueries
    {
        private readonly AppDbContext _context;

        public NeighborhoodQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddMahalle(string mahalleAdi, int ilceId)
        {
            var newMahalle = new Mahalle { MahalleAdi = mahalleAdi, IlceId = ilceId };

            _context.Mahalle.Add(newMahalle);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMahalle(int mahalleId)
        {
            var mahalleToDelete = await _context.Mahalle.FindAsync(mahalleId);

            if (mahalleToDelete != null)
            {
                _context.Mahalle.Remove(mahalleToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Mahalle> GetMahalleById(int mahalleId)
        {
            var mahalle = await _context.Mahalle.FindAsync(mahalleId);
            return mahalle;
        }

        public async Task<List<Mahalle>> GetMahalleByName(string mahalleAdi)
        {
            var mahalleler = await _context.Mahalle
                .Where(m => m.MahalleAdi.ToLower() == mahalleAdi.ToLower())
                .ToListAsync();

            return mahalleler;
        }

        public List<Mahalle> GetAllMahalleler()
        {
            var mahalleler = _context.Mahalle.ToList();
            return mahalleler;
        }
    }
}
