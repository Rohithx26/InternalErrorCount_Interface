using Int_Err_Count.Models;
using Microsoft.EntityFrameworkCore;

namespace Int_Err_Count.Data
{
    public class UserDbContext(DbContextOptions<UserDbContext> options) : DbContext(options)
    {
        public DbSet<ErrorCount> ErrorCount { get; set; }
    }
}
