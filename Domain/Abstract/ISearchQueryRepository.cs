using System.Linq;
using Domain.Entity;

namespace Domain.Abstract
{
    public interface ISearchQueryRepository
    {
        IQueryable<SearchQuery> SearchQuries { get; }
    }
}
