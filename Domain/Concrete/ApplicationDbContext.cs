using Domain.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;


namespace Domain.Concrete
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<OwnerCar> OwnerCars { get; set; }
        public DbSet<BuyingCar> BuyingCars { get; set; }
        public DbSet<SearchQuery> SearchQueries { get; set; }
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
