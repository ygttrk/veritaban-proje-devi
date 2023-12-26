using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class CountyQueries
    {
        private readonly AppDbContext _context;

        public CountyQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddIlce(string ilceAdi, int sehirId)
        {
            var newIlce = new Ilce { IlceAdi = ilceAdi, SehirId = sehirId };

            _context.Ilce.Add(newIlce);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteIlce(int ilceId)
        {
            var ilceToDelete = await _context.Ilce.FindAsync(ilceId);

            if (ilceToDelete != null)
            {
                _context.Ilce.Remove(ilceToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Ilce> GetIlceById(int ilceId)
        {
            var ilce = await _context.Ilce.FindAsync(ilceId);
            return ilce;
        }

        public async Task<List<Ilce>> GetIlceByName(string ilceAdi)
        {
            var ilceler = await _context.Ilce
                .Where(i => i.IlceAdi.ToLower() == ilceAdi.ToLower())
                .ToListAsync();

            return ilceler;
        }

        public List<Ilce> GetAllIlceler()
        {
            var ilceler = _context.Ilce.ToList();
            return ilceler;
        }
    }
}
