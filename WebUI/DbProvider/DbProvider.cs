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
            return queries
                .Where(q => q.ApplicationUser.Id == userId);
        }
        public IEnumerable<CarForUser> GetAllCarForUser(IQueryable<BuyingCar> buyingCars)
        {
            return buyingCars
                .Where(buyingCar => buyingCar.ApplicationUser.Id == userId)
                .Select(offer => new CarForUser
                {
                    Model = offer.Car.Model,
                    Brand = offer.Car.Brand,
                    Cost = offer.Car.Cost,
                    Year = offer.Car.Year,
                    UrlImg = offer.Car.UrlImg,
                    Description = offer.Car.Description,
                    NameOwner = offer.OwnerCar.Name,
                    PhoneNumberOwner = offer.OwnerCar.PhoneNumber,
                    Country = offer.OwnerCar.Country,
                    District = offer.OwnerCar.District,
                    Region = offer.OwnerCar.Region,
                    NewOffer = offer.NewOffer,
                    DateOffer = offer.DateOffer

                }
                ).OrderByDescending(offer=>offer.NewOffer)
                 .ThenByDescending(offer=>offer.DateOffer);
        }


    }
}