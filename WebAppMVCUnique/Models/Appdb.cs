using Microsoft.EntityFrameworkCore;

namespace WebAppMVCUnique.Models
{
    public class Appdb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=HDC3-L-94S8B54;Initial Catalog=db_webappMVCUnique;Integrated Security=true;TrustServerCertificate=true");
        }

        public DbSet<UsersModel> Users { get; set; }  //table
    }
}
