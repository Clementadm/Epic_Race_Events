
using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class AppDbContext : DbContext
    {
        internal object Vehicle;

        public  DbSet<Race> Races {get; set;}
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder){

        }


    }
}