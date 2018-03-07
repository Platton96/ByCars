using System.Linq;
using Domain.Abstract;
using Domain.Entity;

namespace Domain.Concrete
{
    public class EFCarRepository : ICarRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IQueryable<Car> Cars
        {
            get {return context.Cars; }
        }
    }
}
