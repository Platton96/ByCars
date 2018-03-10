using WebUI.Models;
using System.Collections.Generic;
using System.Linq;
using Domain.Entity;


namespace WebUI.DbProvider
{
    public class DbProvider
    {
        private string userId=null;
        public DbProvider(string id)
        {
            userId = id;
        }
        public IEnumerable<SearchQuery> GetAllSearchQueryUser(IQueryable<SearchQuery> queries)
        {
            return queries.Where(q => q.ApplicationUser.Id == userId);
        }
        //public IEnumerable<CarForUser> GetAllCarForUser(IQueryable<BuyingCar> buyingCars, IQueryable<Car> cars, IQueryable<OwnerCar> owners)
        //{

        //}
    }
}