using forms_turk.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace forms_turk.Queries
{
    public class EmployeeQueries
    {
        private readonly AppDbContext _context;

        public EmployeeQueries(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddEmployee(string firstName, string lastName, string phoneNumber)
        {
            var newEmployee = new Employee { FirstName = firstName, LastName = lastName, PhoneNumber = phoneNumber };

            _context.Employee.Add(newEmployee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployee(int employeeId)
        {
            var employeeToDelete = await _context.Employee.FindAsync(employeeId);

            if (employeeToDelete != null)
            {
                _context.Employee.Remove(employeeToDelete);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            var employee = await _context.Employee.FindAsync(employeeId);
            return employee;
        }

        public async Task<List<Employee>> GetEmployeeByName(string firstName)
        {
            var employees = await _context.Employee
                .Where(e => e.FirstName.ToLower() == firstName.ToLower())
                .ToListAsync();

            return employees;
        }



