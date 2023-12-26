using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class MonthlyRevenueQueries
    {
        private readonly AppDbContext _context;

        public MonthlyRevenueQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddMonthlyRevenue(DateTime ayBilgisi, decimal ciro)
        {
            var newMonthlyRevenue = new AylikCiro
            {
                ay_bilgisi = ayBilgisi,
                ciro = ciro
            };

            _context.AylikCiro.Add(newMonthlyRevenue);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteMonthlyRevenue(int aylikCiroId)
        {
            var MonthlyRevenueToDelete = await _context.AylikCiro.FindAsync(aylikCiroId);

            if (MonthlyRevenueToDelete != null)
            {
                _context.AylikCiro.Remove(MonthlyRevenueToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<AylikCiro> GetMonthlyRevenueById(int aylikCiroId)
        {
            var MonthlyRevenue = await _context.AylikCiro.FindAsync(aylikCiroId);
            return MonthlyRevenue;
        }

        public async Task<List<AylikCiro>> GetMonthlyRevenueByAy(DateTime ayBilgisi)
        {
            var MonthlyRevenueList = await _context.AylikCiro
                .Where(a => a.ay_bilgisi.Month == ayBilgisi.Month && a.ay_bilgisi.Year == ayBilgisi.Year)
                .ToListAsync();

            return MonthlyRevenueList;
        }

        public List<AylikCiro> GetAllMonthlyRevenue()
        {
            var MonthlyRevenueList = _context.AylikCiro.ToList();
            return MonthlyRevenueList;
        }
    }
}
