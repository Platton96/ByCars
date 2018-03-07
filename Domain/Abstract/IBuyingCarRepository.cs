using System.Linq;
using Domain.Entity;
namespace Domain.Abstract
{
    public interface IBuyingCarRepository
    {
        IQueryable<BuyingCar> BuyingCars { get; }
    }
}
