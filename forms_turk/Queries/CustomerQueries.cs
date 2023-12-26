using forms_turk.Context;
using forms_turk.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class CustomerQueries
    {
        private readonly AppDbContext _context;

        public CustomerQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddCustomer(string firstName, string lastName, string companyName, bool isCorporate, string contact, int mahalleId, string addressDetail)
        {
            var newCustomer = new Musteri
            {
                Ad = firstName,
                Soyad = lastName,
                SirketAdi = companyName,
                IsKurumsal = isCorporate,
                Iletisim = contact,
                MahalleId = mahalleId,
                AdresDetay = addressDetail
            };

            _context.Musteri.Add(newCustomer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomer(int customerId)
        {
            var customerToDelete = await _context.Musteri.FindAsync(customerId);

            if (customerToDelete != null)
            {
                _context.Musteri.Remove(customerToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Musteri> GetCustomerById(int customerId)
        {
            var customer = await _context.Musteri
                .Include(c => c.Mahalle)  // Mahalle nesnesini dahil et
                .FirstOrDefaultAsync(c => c.Id == customerId);

            return customer;
        }

        public async Task<List<Musteri>> GetCustomerByName(string firstName)
        {
            var customers = await _context.Musteri
                .Where(c => c.Ad.ToLower() == firstName.ToLower())
                .ToListAsync();

            return customers;
        }

        public List<Musteri> GetAllCustomers()
        {
            var customers = _context.Musteri.ToList();
            return customers;
        }
    }
}
