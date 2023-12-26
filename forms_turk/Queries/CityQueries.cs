using forms_turk.Context;
using forms_turk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forms_turk.Queries
{

    public class CityQueries
    {
        private readonly AppDbContext _context;

        public CityQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddCity(string cityName)
        {
            var newCity = new Sehir { SehirAdi = cityName };

            _context.Sehir.Add(newCity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCity(int cityId)
        {
            var cityToDelete = await _context.Sehir.FindAsync(cityId);

            if (cityToDelete != null)
            {
                _context.Sehir.Remove(cityToDelete);
                await _context.SaveChangesAsync();
            }
        }
    }
}


