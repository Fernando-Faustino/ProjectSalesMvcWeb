using SalesMvcWeb.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesMvcWeb.Services
{
    public class DepartmentService
    {
        private readonly SalesMvcWebContext _context;

        public DepartmentService(SalesMvcWebContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
