using System.Linq;
using Domain.Abstract;
using Domain.Entity;

namespace Domain.Concrete
{
    public class EFBuyingCarRepository : IBuyingCarRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IQueryable<BuyingCar> BuyingCars
        {
            get { return context.BuyingCars; }
        }
            
    }
}
