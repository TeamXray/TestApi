using Microsoft.EntityFrameworkCore;
using TestApi.Models;

namespace TestApi
{
    public class Datacontext : DbContext
    {
        public Datacontext(DbContextOptions<Datacontext> options) : base(options)
        {


        }
        public DbSet<UsER>  Users {get; set;}
    }
}