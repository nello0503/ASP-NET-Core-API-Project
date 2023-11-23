using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext //imported from entityframeworkcore
{
    public DataContext(DbContextOptions options) : base(options) 
    
    {
    }

    public DbSet<AppUser> Users {get;set; } //Name of database

    

}
