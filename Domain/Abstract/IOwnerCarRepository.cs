using System.Linq;
using Domain.Entity;

namespace Domain.Abstract
{
    public interface IOwnerCarRepository
    {
        IQueryable<OwnerCar> OwnerCars { get; }
    }
}
