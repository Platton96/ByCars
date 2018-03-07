using System.Linq;
using Domain.Abstract;
using Domain.Entity;

namespace Domain.Concrete
{
    public class EFSearchQueryRepository : ISearchQueryRepository
    {
        private ApplicationDbContext context = new ApplicationDbContext();
        public IQueryable<SearchQuery> SearchQueries
        {
            get { return context.SearchQueries; }
        }
    }
}
