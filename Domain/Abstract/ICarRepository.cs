using System.Linq;
using Domain.Entity;

namespace Domain.Abstract
{
    public interface ICarRepository
    {
        IQueryable<Car> Cars { get; }
    }
}
