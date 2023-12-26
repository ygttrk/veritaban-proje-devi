using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class PersonelQueries
    {
        private readonly AppDbContext _context;

        public PersonelQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddPersonel(string ad, string soyad, string telNo)
        {
            var newPersonel = new Personel { Ad = ad, Soyad = soyad, TelNo = telNo };

            _context.Personel.Add(newPersonel);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePersonel(int personelId)
        {
            var personelToDelete = await _context.Personel.FindAsync(personelId);

            if (personelToDelete != null)
            {
                _context.Personel.Remove(personelToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Personel> GetPersonelById(int personelId)
        {
            var personel = await _context.Personel.FindAsync(personelId);
            return personel;
        }

        public async Task<List<Personel>> GetPersonelByName(string ad)
        {
            var personeller = await _context.Personel
                .Where(p => p.Ad.ToLower() == ad.ToLower())
                .ToListAsync();

            return personeller;
        }

        public List<Personel> GetAllPersoneller()
        {
            var personeller = _context.Personel.ToList();
            return personeller;
        }
    }
}
