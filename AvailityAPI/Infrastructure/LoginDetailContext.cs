using AvailityAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace AvailityAPI.Infrastructure
{
    public class LoginDetailContext : DbContext
    {
        public LoginDetailContext(DbContextOptions<LoginDetailContext> options) : base(options)
        { }

        public DbSet<LoginDetail> MyProperty { get; set; }
    }
}
