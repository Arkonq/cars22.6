using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using WebApplication4.Models;

namespace WebApplication4.Data
{
    public class CarsContext : DbContext
    {
        public virtual DbSet<Car> Cars { get; set; }

        public CarsContext(DbContextOptions<CarsContext> options) : base(options)
        {
        }

    }
}