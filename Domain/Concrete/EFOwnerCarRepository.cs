using System.Linq;
using Domain.Abstract;
using Domain.Entity;

namespace Domain.Concrete
{
    public class EFOwnerCarRepository : IOwnerCarRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IQueryable<OwnerCar> OwnerCars
        {
            get { return context.OwnerCars; }
        }
    }
}
